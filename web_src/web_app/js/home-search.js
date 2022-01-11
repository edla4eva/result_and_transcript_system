    


    function call_getMenu_with_pills(dataIn2, dDiv2, treeType2){
      var dataIn2Test = [{"id": "1", "first_name": "name_1", "parent_idr": "1", "depth": "1"},
                        {"id": "2", "first_name": "name_2", "parent_idr": "1", "depth": "1"},
                        {"id": "3", "first_name": "name_3", "parent_idr": "1", "depth": "1"},
                        {"id": "4", "first_name": "Obadan Pedro", "parent_idr": "41", "depth": "1"},
                         {"id": "4", "first_name": "name_4", "parent_idr": "3", "depth": "2"}
                      ];
          //alert(data);           //data=data_test;
          //console.log('data inputed to call_getMenu_with_PILLS() \n' + dataIn2); 
          //$.trim(dataIn2).then(JSON.parse(dataIn2));
          //data2=jQuery.parseJSON(dataIn2); //JSON.parse(dataIn2); //finally worked
          //dataIn2=' [{"id":"1","first_name":"Irotore","sur_name":"Obadan","parent_idr":"0","year":"1770","gender":"male","depth":"0"},{"id":"2","first_name":"Irorie","sur_name":"Obadan","parent_idr":"3","year":"1779","gender":"female","depth":"3"},{"id":"3","first_name":"Udoigbe","sur_name":"Obadan","parent_idr":"5","year":"1775","gender":"male","depth":"5"},{"id":"4","first_name":"Oiseoruinmwan","sur_name":"Obadan","parent_idr":"1","year":"1776","gender":"male","depth":"1"}]';
        try {

          var strdataIn = JSON.stringify(dataIn2);
          //console.log('data inputed to call_getMenu_with_PILLS() \n' + strdataIn);
          var data2 = JSON.parse($.trim(strdataIn), function (key, value) { //use reviver function  
            if (key == "first_name") {
              //console.log('reviver '+ value);
              return value + ""; //new Date(value);
            } else {
              return value;
            }
          });

          //console.log('parsed data inputed to call_getMenu() obj \n' + data2); 
          //console.log('stringified data inputed to call_getMenu() str \n' + JSON.stringify(data2)); 
          var initLevel = 0;
          var parentID= "0";
            initLevel="0";              //TODO: select a depth
            endMenu2=getMenu2(initLevel); 
            //console.log('data inputed to endmenu \n' + endMenu2); 
            document.getElementById(dDiv2).innerHTML = '<ul id="genPillsUL" class="list-group animate__animated animate__backInRight animate__delay-1s"><li class="list-group-item active"><span>Immediate Family Tree</span></li> '+endMenu2.join('')+ '</ul>';       
        } catch (error) {
                                                            //<li class="list-group-item active"><a href="#">1</a><span>Obadan Family Members</span></li>
          document.getElementById(dDiv2).innerHTML = '<ul id="genPillsUL" class="list-group animate__animated animate__backInRight animate__delay-1s"><li class="list-group-item active"><span>Immediate Family Tree</span></li> <li>There was an issue in the databse </li></ul>';
        }


           function getMenu2 ( parentID ){
              return data2.map(function(node2){
                    subMenu2='';
                    //        <li class="list-group-item d-flex justify-content-between  align-items-center"><a class="family-link" href="svr/api.php/records/efamily?filter=id,eq,23">                                                                  Oni</a><a href="update.php?id=23"> <span class="badge badge-primary badge-pill">update</span></a> <span class="badge badge-primary badge-pill">M</span></li>  
                    tmpLi = '<li class="list-group-item d-flex justify-content-between  align-items-center"><a class="family-link" href="#" id="'+ node2.id + '">'+node2.first_name+ '</a><a href="update.php?id='+node2.id+'"> <span class="badge badge-primary badge-pill">Update</span></a>' +  subMenu2 + '</li>' ;
                    return tmpLi;
              });
            }; // end inner fxn
    
      addFamilyLinkEvents();
    }



    //BASIC TREE: json post array using ajax uses <div id=basic-tree> and calls php-to-json.php
    $(document).ready( function() {
        $('#search_lineage').click(function() {
            $.ajax({
                type: 'POST',
                url: 'svr/model.php?parent_idr=' + $(this).attr('id'),  //'svr/php-to-json.php',
                data: 'id=testdata',
                dataType: 'json',
                cache: false,
                success: function(result) {
                    //$('#demoAjax').append(result[0]); //.html(result[0]);
                    //
                    //console.log('result of AJAX call on doc load \n'+ result);
                    //data=result;
                    var dR;
                    dR= JSON.stringify(result);
                    dR.replace(/\s+/g,'');
                    console.log('result of AJAX call on doc load Stringified \n'+ dR);
                    //$('#demoAjax').text(dR); //.html(result[0]);
                    call_getMenu_with_pills(dR,'lineage', 'pillsTree'); 
                    //document.getElementById("list-json").innerHTML = '<ul id="genUL">'+endMenu.join('')+ '</ul>';

                    // addCarets();
                },
            });
        });

    });

    // Function to custom event handlers for familyLinks 
    function addFamilyLinkEvents(){
      var toggler = document.getElementsByClassName("family-link");
      var i;

      for (i = 0; i < toggler.length; i++) {
          //check if added before
            if (toggler[i].getAttribute('listener') == 'true') {
              toggler[i].removeEventListener("click", funFamList_Clicked); //// Remove the event handler from <div>
              toggler[i].setAttribute('listener', 'false'); //note it
          }
              toggler[i].setAttribute('listener', 'true'); //note it
             toggler[i].addEventListener("click", funFamList_Clicked);
      }        
      
    }
    //Callback for addFamilyLinkEvents()
    function funFamList_Clicked() {
       // console.log('hyperlink family-link caught');
        isBio=true;
        event.preventDefault();
        //console.log('hyperlink family-link  ignore, custum handler activated');
        //console.log('svr/api.php/records/efamily?filter=parent_idr,eq,' + $(this).attr('id') + '\n actual href=' + $(this).attr('href'))
        
        $.ajax({
            type: 'GET',
            // 'svr/api.php/records/efamily?filter=parent_idr,eq,' + $(this).attr('id'),
            url: 'svr/model.php?parent_idr=' + $(this).attr('id'), //$(this).attr('href'), //'svr/php-to-json.php', //get-bio.php',
            //data: '{"id" : 1}', //TODO: how do we get ID $('#btn_ajax_post_data_array').text
            dataType: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            cache: false,
            success: function(result) {
                  //console.log('Stringified JSON output from AJAX call on link: \n' + JSON.stringify(result));
                  var dR;
                  //result from api comes as {records:}
                  dR= JSON.stringify(result.records[0]).trim(); //NOTE WHEN USING API
                  //console.log('Extracted Stringified JSON output from AJAX call on link: \n' + dR);
                  //dR.replace(/\s+/g,'');
                  call_getMenu_with_pills(result.records,'json-list-branch', 'pillsTree'); 
                  $(document).scrollTop($("#container").offset().top);  //scroll to top
            },
        });

        $.ajax({
          type: 'GET',
          //svr/api.php/records/efamily?filter=id,eq,
          url: 'svr/model.php?id=' + $(this).attr('id'), //$(this).attr('href'), //'svr/php-to-json.php', //get-bio.php',
          //data: '{"id" : 1}', //TODO: how do we get ID $('#btn_ajax_post_data_array').text
          dataType: 'json',
          contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
          cache: false,
          success: function(result) {
                //console.log('Stringified JSON output from AJAX call on link: \n' + JSON.stringify(result));
                var dR;
                //result from api comes as {records:}
                dR= JSON.stringify(result.records[0]).trim();
                
                dR.replace(/\s+/g,'');
               // TODO update bio call_getMenu_with_pills(dR,'json-list-branch', 'pillsTree'); 
               //TODO: if result.records[0].has_children
                var dBio = result.records[0].first_name + ' '+ result.records[0].sur_name + '<br>' + result.records[0].bio + '<br> survived by :' + result.records[0].children_names;
                document.getElementById("info-name").innerHTML = result.records[0].first_name + ' '+ result.records[0].sur_name;
                document.getElementById("info").innerHTML =  result.records[0].bio + '<br> survived by ' + result.records[0].children_names; //.left(30);
                document.getElementById("info-id").innerHTML = 'ID: ' + result.records[0].id;
                document.getElementById("generated-full-info").innerHTML = dBio;
                console.log('Extracted Bio: \n' + dBio);
                $(document).scrollTop($("#container").offset().top);     //now scroll to top of bio (#info) section

          },
      });
    }


