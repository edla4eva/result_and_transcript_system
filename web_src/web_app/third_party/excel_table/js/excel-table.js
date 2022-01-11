(function () {
    var d = $(document),
    b = $('body'),
    keys = { RETURN: 13, LEFT: 37, UP: 38, RIGHT: 39, DOWN: 40, C: 67, V: 86, X: 88, Z: 90 },
    active = "",
    md = false,
    p = "",
    dragStarted = false,
    dragging = false,
    cb = [],
    shiftDown = false;
    undoStack = [];
    cTable = null, fTable = null;
    var init = function (tb, options) {
        t = $(tb);
        t.addClass("excel-table tbl-editable");
        et = t;
        //bind col resizable
        if ($.fn.colResizable || $.colResizable) {
            et.colResizable({
                liveDrag: false,
                onDrag: onResizingColumns,
                onResize: onResizingColumns
            });
        }
        p = t.parent();
        p.css("position", "relative");
        cbta = $("<textarea/>");
        cbd = $("<div/>").css("display", "none");
        cbta.attr("id", "cbta");
        cbd.append(cbta);
        b.append(cbd);
        //var ph = p.html();
        //if (p) {
        //    var wr = $("<div/>");
        //    wr.prop("id", "et_wrapper").attr("id", "et_wrapper").addClass("et-wrapper");
        //    p.empty();
        //    p.append(wr.html(ph));
        //}
        t.opts = options;
        t.addClass("noselect");
        //t.addEventListener('contextmenu', function (e) {
        //    e.preventDefault();
        //    alert('Disabled');
        //    return false;
        //}, false);
        setGridCells(t);
        setGridIdentities(t);
        bindShortCutKeys(d);
        mouseEvents(d);
        bindHeaderEvents(t);

        //Extend max min
        Array.prototype.max = function () {
            return Math.max.apply(null, this);
        }

        Array.prototype.min = function () {
            return Math.min.apply(null, this);
        }

        Array.prototype.countNumbers = function () {
            var numbers = 0;
            for (var i = 0; i < this.length; i++) {
                if (!isNaN(this[i]))
                    numbers++;
            }
            return numbers;
        }
    },
    setGridIdentities = function (t) {
        $.each(t.find("tbody>tr>td"), function (i, e) {
            var td = $(this);
            var identity = td.parents("tr").index() + "_" + td.index();
            td.prop("data-id", identity);
            td.attr("data-id", identity);
        });
    },
    onResizingColumns = function () {
        var activeCell = et.find("td.active:visible");
        if (activeCell.length > 0)
            createActiveCell(activeCell);

        var event = jQuery.Event("colResizing");
        $(document).trigger(event, $(this));
    },
    setGridCells = function (t) {
        var tds = t.find("tbody>tr>td");
        tds.each(function (i, e) {
            bindCellEvents($(this));
        });

        var inputs = t.find("tbody>tr>td>input.editable");
        inputs.each(function (i, e) {
            var td = $(this).closest("td");
            bindCellEvents(td);
            td.on("dblclick", function () {
                var i = $(this).find("input.editable");
                if (i) {
                    editCell(i);
                    i.on("blur", function () {
                        $(this).addClass("readonly").removeClass("editing");
                    }).on("keyup", function (e) {
                        if (e.keyCode == keys.RETURN) {
                            if ($(this).hasClass("editing")) {
                                $(this).trigger("blur");
                            } else {
                                editCell($(this));
                            }
                        }
                    });
                }
            }).on("keydown", function (e) {
                var input = $(this).find("input.editable");
                input.data("oldval", input.val()).attr("data-oldval", input.val());
            }).on("change", function (e) {
                console.log($(this).data("id") + " has changed");
                var item = $(this);
                var id = item.data("id");
                var input = item.find("input.editable");

                undoStack.push([{ id: id, value: input.data('oldval') }]);

                console.log(undoStack);
            }).on("keyup", function (e) {
                shiftDown = e.shiftKey;
                if (e.keyCode == keys.RETURN) {
                    //editCell($(this));
                }
            });
        });
    },
    selectRange = function (s, e) {
        var sRowIndex = s.parents("tr").index();
        var sColIndex = s.index();
        var eRowIndex = e.parents("tr").index();
        var eColIndex = e.index();
    },
    editCell = function (c) {
        c.removeClass("readonly");
        c.focus();
        c.addClass("editing");
    },
    keepCell = function (c) {

    },
    mouseEvents = function (d) {
        d.on("dblclick", ".et-active", function () {
            activateCell();
        }).on("keydown", function (e) {
            if ($(".et-active").length > 0) {
                //activateCell();
            }
        }).on("undo", function (e) {
            onUndo();
        }).on("mousedown", function (e) {
            if ($(e.target).hasClass("tingu")) {
                //raise dragging event
                var event = new CustomEvent('dragStart');
                document.addEventListener("dragStart", onDragStarted);
                document.dispatchEvent(event);
            }
            switch (e.which) {
                case 1: // left click
                    if (!$(e.target).hasClass("editable") && $(e.target).parents("table").length > 0) {
                        resetRange();
                        $(".et-active").show();
                    }
                    md = true;
                    break;
                case 2://middle click

                    break;
                case 3://right click
                    e.preventDefault();
                    e.stopPropagation();
                    break;
            }
        }).on("mouseup", function (e) {
            md = false;
            if (dragStarted) {
                var sourceCell = $(".excel-table tbody tr td.active");
                var cells = et.find("tbody tr:visible td.range:visible");
                var uItems = [];
                $.each(cells, function (i, e) {
                    var cell = $(e), inp = cell.find("input.editable");
                    inp.data("oldval", inp.val()).attr("data-oldval", inp.val());
                    inp.val(sourceCell.find("input.editable").val());
                    cell.hide().fadeIn(900);
                    uItems.push({ id: cell.data("id"), value: inp.attr("data-oldval") });
                });
                undoStack.push(uItems);
                $("body").removeClass("et-dragging");
            }
            dragging = false;
            dragStarted = false;
        }).on("mouseover", ".tbl-editable tbody> tr> td", function (e) {
            if (md) {
                $(".tbl-editable>tbody>tr>td").removeClass("range");
                //select range
                var src = $(".tbl-editable tbody tr td.active");
                var sX = src.parent().index();
                var sY = src.index();
                var target = $(this);
                var tX = target.parent().index();
                var tY = target.index();
                var minX = sX > tX ? tX : sX;
                var maxX = sX > tX ? sX : tX;
                var minY = sY > tY ? tY : sY;
                var maxY = sY > tY ? sY : tY;

                for (var i = minX; i <= maxX; i++) {
                    var row = $(".tbl-editable tbody tr").eq(i);
                    for (var j = minY; j <= maxY; j++) {
                        row.find("td").eq(j).addClass("range");
                    }
                }
            }
        }).on("mouseleave", ".tbl-editable>tbody>tr>td", function (e) {
        }).on("mousemove", function (e) {
        });
    },
    onDragStarted = function () {
        $("body").addClass("et-dragging");
        dragStarted = true;
    },
    activateCell = function () {
        var aCell = $(".excel-table tr td.active");
        if (aCell) { aCell.trigger("dblclick").focus(); }
        $(".et-active").hide();
    },
    onUndo = function () {
        if (undoStack && undoStack.length > 0) {
            //Code to Undo
            var lastChange = undoStack.pop();
            $.each(lastChange, function (i, e) {
                var td = $(et.find("td[data-id='" + e.id + "']:visible"));
                if (td.length > 0) {
                    var item = td.find("input.editable");
                    item.val(e.value);
                    td.hide().fadeIn(900);
                }
            });
        }
    },
    bindShortCutKeys = function (d) {
        d.on("keydown", function (e) {
            shiftDown = e.shiftKey;
            if (e.ctrlKey && e.keyCode == keys.C) {
                copyValues();
                return;
            } else if (e.ctrlKey && e.keyCode == keys.V) {
                pasteValues();
                return;
            } else if (e.ctrlKey && e.keyCode == keys.Z) {
                var event = new CustomEvent('undo');
                document.dispatchEvent(event);
            } if ([keys.LEFT, keys.RIGHT, keys.UP, keys.DOWN, keys.RETURN].indexOf(e.which) > -1) {
                e.preventDefault();
                e.stopPropagation();
                active = $(".excel-table tbody tr td.active");
                var y = active.parents('tr').index("tbody tr:visible");
                var x = active.index();
                var hiddenCols = active.parents("tr").find("td:lt(" + x + "):hidden").length;
                x = x - hiddenCols;
                switch (e.keyCode) {
                    case keys.LEFT:
                        x--;
                        break;
                    case keys.UP:
                        y--;
                        break;
                    case keys.RIGHT:
                        x++;
                        break;
                    case keys.DOWN:
                        y++;
                        break;
                }
                if (x > -1 && y > -1) {
                    var newActive = $('.excel-table tbody tr:visible').eq(y).find('td:visible').eq(x);
                    if (newActive.length > 0) {
                        resetRange();
                        active = $(".excel-table tbody tr td.active").removeClass("active");
                        newActive.addClass('active');
                        createActiveCell(newActive);
                    }
                }

                if (e.keyCode == keys.RETURN) {
                    var e = $.Event("keyup");
                    e.which = 40;
                    d.trigger(e);
                    //editCell($(active.find("input.editable")));
                }
            }
        });
    },
    copyValues = function () {
        cb = [];
        if ($(".excel-table tbody tr td.range:visible :input").length == 0)
            cb.push([$(".tbl-editable td.active :input").val()]);
        var trs = [];
        $.each($(".excel-table tbody tr td.range:visible"), function (i, e) {
            var rIndex = $(this).parents("tr").index();
            if (trs.indexOf(rIndex) < 0)
                trs.push(rIndex);
        });
        $.each(trs, function (i, e) {
            var cells = $(".excel-table tbody tr").eq(e).find("td.range:visible");
            var items = [];
            $.each(cells, function (i, e) {
                if (e) {
                    items.push($(e).find("input").val());
                }
            });
            cb.push(items);
        });
        cbta.val(cb);
    },
    pasteValues = function () {
        if (cb.length > 0) {
            var cellStart = et.find("tbody tr:visible td.range:visible:first").length > 0 ? et.find("tbody tr:visible td.range:visible:first") : et.find("tbody tr:visible td:visible.active");
            var sRowIndex = cellStart.parents('tr').index("tbody tr:visible");
            var sColIndex = cellStart.index();
            var hiddenCols = cellStart.parents("tr").find("td:lt(" + sColIndex + "):hidden").length;
            sColIndex = sColIndex - hiddenCols;

            var uItems = [];
            for (var i = 0; i < cb.length; i++) {
                for (var j = 0; j < cb[i].length; j++) {
                    var val = cb[i][j];
                    var cell = $(".excel-table tbody tr:visible").eq(i + sRowIndex).find("td:visible").eq(j + sColIndex);
                    if (cell) {
                        var inp = cell.find("input");
                        inp.data("oldval", inp.val()).attr("data-oldval", inp.val()).val(val);
                        cell.hide().fadeIn(800);

                        uItems.push({ id: cell.data("id"), value: inp.data("oldval") });
                    }
                }
            }
            undoStack.push(uItems);
        }
    },
    getSelectedRangeGrid = function () {
        var range = et.find('td.range:visible');
        var trs = [];
        var sRange = [];
        $.each(range, function (i, e) {
            var rIndex = $(this).parents("tr").index();
            if (trs.indexOf(rIndex) < 0)
                trs.push(rIndex);
        });

        $.each(trs, function (i, e) {
            var cells = $(".excel-table tbody tr").eq(e).find("td.range:visible");
            var items = [];
            $.each(cells, function (i, e) {
                if (e) {
                    items.push($(e).index());
                }
            });
            sRange.push(items);
        });
        return sRange;
    },
    getSelectedRange = function () {
        return et.find('td.range:visible');
    },
    bindCellEvents = function (tds) {
        tds.on("mousedown", function (e) {
            t.find("tbody>tr>td.active").removeClass("active");
            if (!$(e.target).hasClass("editing")) {
                $(this).addClass("active");
                createActiveCell($(this));
            }
        });
    },
    createActiveCell = function (c) {
        var ad = $("<div/>"), cp = c.position();
        ad.css({ position: 'absolute', width: c.width(), height: c.height() });
        ad.offset({ left: cp.left, top: cp.top });
        ad.append($("<div/>").addClass("tingu"));
        ad.addClass("et-active");
        if ($(".et-active").length > 0)
            $(".et-active").remove();
        p.append(ad);
    },
    resetRange = function () {
        $("td.range").removeClass("range");
    },
    bindHeaderEvents = function (t) {
        cTable = $(t.data("content")), fTable = $(t.data("footer"));
        var at = cTable ? cTable : t;
        t.on("click", "thead tr:last-child th", function (e) {
            if (!$(e.target).is("th"))
                return;
            e.preventDefault();
            e.stopPropagation();
            var th = $(this);
            var hiddenCells = at.find("td:hidden");
            at.find("tr td:nth-of-type(" + (th.index() + 1) + ")").addClass("range");

            dispatchEvent(t, "rangeSelected", { range: $(at.find("tbody td.range:visible")) });
        });
    },
    dispatchEvent = function (elem, eventName, eventData) {
        var event = jQuery.Event(eventName);
        $(elem).trigger(event, eventData);
    }
    $.fn.extend({
        exceltable: function (options) {
            var defaults = {
                defaultClass: "excel-table"
            }, options = $.extend(defaults, options);
            return this.each(function () {
                init(this, options)
            })
        }
    })
})(jQuery);