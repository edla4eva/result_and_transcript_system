    
    {
        //general
    }

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

            var dataTemp=data;
            endMenu=getMenu("0");
            //console.log("Generated list for CleanTree: " + "\n" + endMenu)
            document.getElementById(dDiv).innerHTML = '<h1>Family Tree</h1><ul id="genCleanUL" class="tree">'+endMenu.join('')+ '</ul>';
            //next batch
            data=dataTemp;
            endMenu=getMenu("7");
            $("#"+dDiv).append ('<ul id="genCleanUL" class="tree">'+endMenu.join('')+ '</ul>');

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
    addFamilyLinkEvents();
    }



      //CLEAN TREE: AJAX for CleanTree Family 
      $(document).ready( function() {
       // $(document).animate({scrollLeft: 300},500);     //now scrollright
        $.ajax({
            type: 'POST',
            url:  'svr/php-to-json.php',  //evaluates to ->svr/model.php?parent_idr<6'
            data: {'parent_idr' : '0'},
            dataType: 'json',
            cache: false,
            success: function(result) {
               
                console.log('Hey!' + JSON.stringify(result));
                var dR;
                dR= JSON.stringify(result);
                dR.replace(/\s+/g,'');
                call_getMenu(dR,'auto-tree', 'cleanTree'); 
                
            },
        });

        var Html = "<div id='myDivWM'>Copyright Obadan Family</div>";
        $("body").append(Html);
      
        $("#myDivWM").css({
          "color":"#bbb","font-size":"100px",
          "position":"absolute","top":"10px","left":"15px",
          "z-index":"-1","transform":"rotate(45deg)"
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


