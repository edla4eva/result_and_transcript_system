      call_tree_getMenu();
      //Get_json_from_php_using_AJAX();
      
      function call_tree_getMenu(){
            var input_data = [{"id": "1", "name": "Pa Obadan", "parent_id": "0", "depth": "0"},
            {"id": "2", "name": "Madam Obadan", "parent_id": "0", "depth": "0"},
            {"id": "3", "name": "James Obadan", "parent_id": "1", "depth": "1"},
            {"id": "3", "name": "Aimuah Obadan", "parent_id": "4", "depth": "1"},
            {"id": "4", "name": "Peter Obadan", "parent_id": "3", "depth": "2"}];
           
          var dendMenu= getMenu("0", input_data);
          document.getElementById("list-json").innerHTML = '<ul>'+ dendMenu.join('')+ '</ul>';
          
      }
      function getMenu( parentID, data ){
            return data.filter(function(node){
                 return ( node.parent_id === parentID ) ; }).map(function(node){
                                                var exists = data.some(function(childNode){
                                                        return childNode.parent_id === node.id; });
                var subMenu = (exists) ? '<ul>'+ getMenu(node.id).join('') + '</ul>' : "";
                return '<li>'+node.name +  subMenu + '</li>' ;
            });

      }

/* 
      // Get json from php using AJAX
      function reqListener () {
            console.log(this.responseText);
          }
         Get_json_from_php_using_AJAX();
      function Get_json_from_php_using_AJAX () { 
          var oReq = new XMLHttpRequest(); // New request object
          oReq.onload = function() {
              // The actual data is found on this.responseText
             //alert(this.responseText); // Will alert: the json

               // This is where you handle what to do with the response.
              data = this.responsetext;
              var initLevel = 0;
              var endMenu= getMenu("0");
              document.getElementById("json-list-branch").innerHTML = '<ul>'+endMenu.join('')+ '</ul>';
    
          };
          oReq.open("get", "svr/php-to-json.php", true);
          //                               ^ Don't block the rest of the execution.
          //                                 Don't wait until the request finishes to
          //                                 continue.
          oReq.send();
      }  */