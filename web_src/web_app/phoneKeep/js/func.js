/*!
 * Common funcs
 * Licensed under the MIT license
 */

 function loadProducts(){
     var strTemp = "";
     var i = 0;
     var productArray=["yam", "Tomatoes", "Books", "cryons"]
     var productObject={"1": "Books", "2": "Oranges", "2": "Pepper"}  
    
     
     strTemp= "Oranges are yummy, yudfsd yummy yummy, Straberry is yummy too";
     for (i=0;i<20;i++)
     {
      strTemp=strTemp + ", Straberry is yummy too";
     }
     // Display he content
     document.getElementById("product1-header").innerHTML = productObject['1'];
     document.getElementById("product2-header").innerHTML = productObject['2'];
     document.getElementById("product3-header").innerHTML = productObject['3'];
     document.getElementById("product1-body").innerHTML = strTemp

     document.getElementById("product1-body").style.display="none";
     document.getElementById("btn-products").innerHTML="done"; //.style.display = "none"

    }

  function checkUser(usr) {
    var usersObject={"admin": "admin", "client": "client"}  
    if (usr==usersObject['1']) {
      document.getElementById("psw").innerHTML = usr;
    }  
  }

