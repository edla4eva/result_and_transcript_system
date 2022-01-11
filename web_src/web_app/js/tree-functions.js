    
    {
        //general
    }
    
    // Function to add carets (calling this twise adds double event listener)
      function addCarets(){
        var toggler = document.getElementsByClassName("caret");
        var i;

        for (i = 0; i < toggler.length; i++) {
            //check if added before
             if (toggler[i].getAttribute('listener') == 'true') {
            toggler[i].removeEventListener("click", funList_Clicked); //// Remove the event handler from <div>
            toggler[i].setAttribute('listener', 'false'); //note it
            }
            toggler[i].addEventListener("click", funList_Clicked);
            toggler[i].setAttribute('listener', 'true'); //note it
        }
      }
      //Callback for addCarets()
      function funList_Clicked() {
        this.parentElement.querySelector(".nested").classList.toggle("active");
        this.classList.toggle("caret-down");
      }
     addCarets(); //initial function call

     //this function calles the iterative getMenu function
     //the purpose is to create a ul list from JSON
     function call_getMenu(dataIn, dDiv, treeType){
      var dataIn_testIn = [{"id": "1", "first_name": "name_1", "parent_idr": "0", "depth": "0"},
                        {"id": "2", "first_name": "name_2", "parent_idr": "0", "depth": "0"},
                        {"id": "3", "first_name": "name_3", "parent_idr": "1", "depth": "1"},
                        {"id": "4", "first_name": "Obadan Pedro", "parent_idr": "41", "depth": "1"},
                         {"id": "4", "first_name": "name_4", "parent_idr": "3", "depth": "2"}
                      ];
        //var dataIn_testIn= [{"id": "1","first_name": "Irotore","sur_name": "Obadan","parent_idr": "0","year": "1770","gender": "male","depth": "0"}, {"id": "2","first_name": "Irorie","sur_name": "Obadan","parent_idr": 3,"year": "1779","gender": "female","depth": "3"}]; //,{"id":3,"first_name":"Udoigbe","sur_name":"Obadan","parent_idr":5,"year":1775,"gender":"male","depth":5},{"id":4,"first_name":"Oiseoruinmwan","sur_name":"Obadan","parent_idr":1,"year":1776,"gender":"male","depth":1},{"id":5,"first_name":"Ishoshenho","sur_name":"Obadan","parent_idr":4,"year":1777,"gender":"male","depth":4},{"id":6,"first_name":"Igele","sur_name":"Obadan","parent_idr":3,"year":1779,"gender":"male","depth":3},{"id":7,"first_name":"Uzebba","sur_name":"Obadan","parent_idr":6,"year":1777,"gender":"male","depth":6},{"id":8,"first_name":"Uduigwome","sur_name":"Obadan","parent_idr":6,"year":1775,"gender":"male","depth":6},{"id":9,"first_name":"OBADAN","sur_name":"Obadan","parent_idr":6,"year":0,"gender":"male","depth":6},{"id":10,"first_name":"Oiseorunmwn","sur_name":"Obadan","parent_idr":6,"year":0,"gender":"male","depth":6},{"id":11,"first_name":"Oikelome","sur_name":"Obadan","parent_idr":6,"year":0,"gender":"male","depth":6},{"id":12,"first_name":"Omiunu","sur_name":"Obadan","parent_idr":6,"year":0,"gender":"male","depth":6},{"id":13,"first_name":"Name Unknown","sur_name":"Surname Unknown","parent_idr":6,"year":0,"gender":"female","depth":6},{"id":14,"first_name":"Mama","sur_name":"Idiegbeah","parent_idr":7,"year":1821,"gender":"female","depth":7},{"id":15,"first_name":"Ishanmiewan","sur_name":"Obadan","parent_idr":7,"year":0,"gender":"male","depth":7},{"id":16,"first_name":"Jaueola","sur_name":"Obadan","parent_idr":7,"year":0,"gender":"male","depth":7},{"id":17,"first_name":"Ezekiel","sur_name":"Obadan","parent_idr":7,"year":0,"gender":"male","depth":7},{"id":18,"first_name":"Modupe","sur_name":"Nee Obadan","parent_idr":7,"year":0,"gender":"female","depth":7},{"id":19,"first_name":"sdfsd","sur_name":"ffaSf","parent_idr":8,"year":0,"gender":"7t","depth":8}];
        //dataIntest = (JSON.stringify(dataIn_testIn)).trim();

        //console.log('data inputed to call_getMenu() \n' + dataIn); 
        data=JSON.parse(dataIn); //finally worked (Why does this cause error?)
        //console.log('Parsed data in call_getMenu() \n' + data[0]); 
        //console.log('Item[0] Parsed data in call_getMenu() \n' + data[1]);                
          var initLevel = 0;
          var parentID= "0";
          //endMenu=getMenu("0");
         // document.getElementById(dDiv).innerHTML = '<ul id="genBasicUL" >'+endMenu.join('')+ '</ul>';
          //var dDiv='demoAjax'
          //console.log('TreeType \n' + treeType); 
          if (treeType=="basicTree"){
            endMenu=getMenu("0");
            //console.log("Generated list for BasicTree: " + "\n" + endMenu)
            document.getElementById(dDiv).innerHTML = '<ul id="genBasicUL"><li>Family Tree</li>'+endMenu.join('')+ '</ul>';
          }else if (treeType=="cleanTree"){
            var dataTemp=data;
            endMenu=getMenu("0");
            //console.log("Generated list for CleanTree: " + "\n" + endMenu)
            document.getElementById(dDiv).innerHTML = '<h1>Family Tree</h1><ul id="genCleanUL" class="tree">'+endMenu.join('')+ '</ul>';
            //next batch
            //data=dataTemp;
            //endMenu=getMenu("7");
            //$("#"+dDiv).append ('<ul id="genCleanUL" class="tree">'+endMenu.join('')+ '</ul>');

          } else if(treeType=="pillsTree"){
            initLevel="0";              //TODO: select a depth
            endMenu=getMenu(initLevel); 
            //endMenu.replace('<li>', '<li>');
            endMenu.replace('</li>', '<a href="http://localhost/efamily/app/update.php?id=2">update </a></li>');
            //console.log("Generated list: " + "\n" + endMenu)
            document.getElementById(dDiv).innerHTML = '<ul id="genPillsUL"><li>Family Tree</li>'+endMenu.join('')+ '</ul>';
          }else {
            endMenu=getMenu("0");  
            //console.log("Generated list: " + "\n" + endMenu)
            document.getElementById(dDiv).innerHTML = '<ul id="genUL"><li>Family Tree</li>'+endMenu.join('')+ '</ul>';
          }
          
          function getMenugggg (parentID){
            //array.filter creates new array with all elements that passes test in fxn 
            console.log('\n parent ID, node, condition:\n');
            x1=data.filter(function(node){    //select child nodes of parentID
                
               return (node.parent_idr === parentID);
               //map creates new array with result of provided fxn on each element 
            })
            console.log(x1);
           x2=x1.map(function(node){
            var exists = data.some(function(childNode){   //search for 1st child of node
              return childNode.parent_idr === node.id; 
            });
            if (exists) {
              console.log('nod2 is parent ' + node.id);
              return 'parennt:'+getMenu(node.id);
            }

           });
           console.log(x2);
           return "<li>test</li>"
          }

           function getMenu (parentID){
              //array.filter creates new array with all elements that passes test in fxn 
              //console.log('parent ID, node, condition:');
              return data.filter(function(node){    //select child nodes of parentID
                  //console.log(parentID + ', ' + node.id + ', ' + node.parent_idr === parentID);
                 return (node.parent_idr === parentID);
                 //map creates new array with result of provided fxn on each element 
              }).map(function(node){
                 //console.log('Filtered to be mapped parent ID, node:' + parentID+ node.id );
                  //array.some executes callback fxn for each element until first callback returns true 
                  var exists = data.some(function(childNode){   //search for 1st child of node
                        return childNode.parent_idr === node.id; 
                  });
                  if (exists) {
                    subMenu='<ul class ="nested active">'+ getMenu(node.id).join('') + '</ul>';
                    //console.log('iteration(n)  subMenu: ' + "\n" + subMenu); //svr/api.php/records/efamily/'+ id //GET /records/categories?filter=name,eq,Internet
                    if (treeType=="cleanTree")
                          {return '<li><span class="caret caret-down"><a class="clean-family-link" href="tree.php?id='+node.id+'" id="'+node.id + '">'+ node.first_name + '</a></span>'  + subMenu + '</li>' ;}
                    else  {return '<li><span class="caret caret-down"><a class="family-link" href="tree.php?id='+node.id+'" id="'+node.id + '">'+ node.first_name + '</a></span>'  + subMenu + '</li>' ;}
                  }  else {
                    subMenu='';
                    if (treeType=="cleanTree")
                          { return '<li><span><a class="clean-family-link" href="tree.php?id='+node.id+'" id="'+ node.id + '">'+node.first_name+ '</a></span>' +  subMenu + '</li>' ;}
                    else  {return '<li><span><a class="family-link" href="tree.php?id='+node.id+'" id="'+ node.id + '">'+node.first_name+ '</a></span>' +  subMenu + '</li>' ;}
                  }
                  //subMenu = (exists) ? '<ul class ="nested">'+ getMenu(node.id).join('') + '</ul>' : "";
                  //return '<li><span class="caret">'+node.name +  subMenu + '</li>' ;
              }); //end map
            }; // end getMenu fxn

          
    addCarets();
    addFamilyLinkEvents();
    }


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
          console.log('data inputed to call_getMenu_with_PILLS() \n' + strdataIn);
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
        //$('#btn_ajax_post_data_array').click(function() {
            $.ajax({
                type: 'POST',
                url: 'svr/php-to-json.php',
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
                    call_getMenu(dR,'basic-tree', 'basicTree'); 
                    //document.getElementById("list-json").innerHTML = '<ul id="genUL">'+endMenu.join('')+ '</ul>';

                    // addCarets();
                },
            });
        //});
            //get default id and use it to load immediate family
            var def_fam_id = document.getElementById("default_id").innerHTML 
            //TODO: How do we invoke the jQuery Ajax function for immediate tree?
            //instead of copy paste here?
    });

    //BASIC TREE: json post array using ajax on button clickuses <div id=basic-tree> and calls php-to-json.php
    $(document).ready( function() {
        $('#btn_ajax_post_data_array').click(function() {
            $.ajax({
                type: 'POST',
                url: 'svr/php-to-json.php', //'svr/api.php/records/efamily',
                //data: 'id=1',              //'svr/php-to-json.php',
                dataType: 'json', //todo: json
                //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                cache: false,
                success: function(result) {
                    //$('#demoAjax').append(result[0]); //.html(result[0]);
                    //
                    //console.log('result of AJAX call on doc load \n'+ result);
                    //result comes
                    var dR;
                    dR= JSON.stringify(result).trim();
                    dR.replace(/\s+/g,'');
                    console.log('result of AJAX call on doc load Stringified \n'+ dR);
                    call_getMenu(dR,'basic-tree', 'basicTree'); 

                    // //-----------API <MTHD -----
                    // //result from api comes as {records:}
                    // dR= JSON.stringify(result.records[0]).trim(); //NOTE WHEN USING API
                    // console.log('Extracted Stringified JSON return val from API: \n' + dR);
                    // //dR.replace(/\s+/g,'');
                    // call_getMenu_with_pills(result.records,'basic-tree', 'basicTree'); 
                   
                },
            });
        });
    });

    //loads biodata and photo <div id=info> and calls get-bio.php
    //Or //PILLS TREE: AJAX for Immediate Family 
/*     $(document).ready( function() {
      $('.family-link').click(function(event) {
          console.log('hyperlink caught');
          isBio=false;
          
            if ($(this).attr('href').includes("bio")) isBio=true;
            event.preventDefault();
            console.log('hyperlink servised');
         
          $.ajax({
              type: 'POST',
              //url:  $(this).attr('href'), //'svr/php-to-json.php', //get-bio.php',
              url:  'svr/api.php/records/efamily?filter=parent_idr,eq,' + $(this).attr('id'), //'svr/php-to-json.php', //get-bio.php',
              data: 'id=1', //TODO: how do we get ID $('#btn_ajax_post_data_array').text
              dataType: 'json',
              cache: false,
              success: function(result) {
                  // {"records":[{"id":4,"first_name":"Oiseoruinmwan","sur_name":"Obadan","title":"Pa","parent_idr":1,"has_children":"yes","children_names":"Ishoshenho","dob":"1776-01-01","year":1776,"is_alive":"no","gender":"male","pix":"\/pix\/2.jpg","bio":"Pa","paternal_maternal":"","dod":"0000-00-00","other_names":"","approved":1,"added_by":0}]}
                  if(isBio){
                    var dR;
                    dR= JSON.stringify(result);
                    dR.replace(/\s+/g,'');
                    //$('#demoAjax').text(dR); //.html(result[0]);
                    console.log('fired');
                    console.log(dR);
                    dR=JSON.parse(result); //convert JSON to HTML
                    console.log('result of AJAX on href clicked for pillsImmediateFamily Stringified \n'+ result);
                    
                    document.getElementById("generated-full-info").innerHTML = '<p id="genBio"> '+ dR + ' </p>';
                    document.getElementById("info").innerHTML = '<p id="genBio"> '+ dR.substr(0, 20) + ' </p>';
                    $(document).scrollTop($("#info").offset().top);     //now scroll to bio section
                  } else {
                    console.log('Link Clicked - Returned data strinified \n' + JSON.stringify(result));
                    var dR;
                    dR= JSON.stringify(result);
                    dR.replace(/\s+/g,'');
                    call_getMenu_with_pills(dR,'json-list-branch', 'pillsTree'); 
                  }
                  // addCarets();
              },
              error: function(jqXHR, exception){
                alert('There wan an error in AJAX call: ' + exception)
                console.log('There wan an error in AJAX call: ' + exception )
              },
          });
      });
    }); */

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
        event.prevesntDefault();
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


