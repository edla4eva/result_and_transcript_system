<?php 
session_start(); /* Starts the session */
define('BASEPATH', '');
if (!isset( $_SESSION['UserData']['inputEmail'])) {
  header("location:sign-in.php") ;
} else {
  $usernamePara='('.$_SESSION['UserData']['inputEmail'].')';
  $username=$_SESSION['UserData']['inputEmail'];
}
$msg="";
$id="1";
//if ($_SERVER["REQUEST_METHOD"] == "GET") {
  if (isset($_GET["msg"])) $msg = $_GET["msg"];
  if ($msg=="-1") $msg="Could not add record! Please check the inputs and try again </br>";
  if (isset($_GET["id"])) $id = $_GET["id"];
  //use php to autofill form
  include "svr/autofill-update.php"
//}
?>
<!doctype html>
<html lang="en">
  <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
      <meta name="description" content="">
      <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
      <meta name="generator" content="Jekyll v4.0.1">
      <title>Input Data</title>

      <link rel="canonical" href="https://getbootstrap.com/docs/4.5/examples/sign-in/">

      <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

  
    <style>
        @media (min-width: 768px) {
          .bd-placeholder-img-lg {
            font-size: 3.5rem;
          }
        }

            /* The Modal (background) */
      .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
      }

      /* Modal Content/Box */
      .modal-content {
        background-color: #fefefe;
        margin: 15% auto; /* 15% from the top and centered */
        padding: 20px;
        border: 1px solid #888;
        width: 80%; /* Could be more or less, depending on screen size */
      }

      /* The Close Button */
      .close {
        color: black;
        float: right;
        font-size: 14px;
        font-weight: bold;
      }

      .close:hover,
      .close:focus {
        color: #aaa;
        text-decoration: none;
        cursor: pointer;
      } 
      </style>


      <!-- Custom styles for this template -->
      <!-- <link href="css/signin.css" rel="stylesheet"> -->
  </head>
  <body style = "padding-top: 65px;">
  <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
        <a class="navbar-brand" href="index.php">RTPS</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarsExampleDefault">
          <ul class="navbar-nav mr-auto">
            <li class="nav-item">
              <a class="nav-link" href="home.php">Home</a>
            </li>

            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" id="dropdown01" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">User</a>
              <div class="dropdown-menu" aria-labelledby="dropdown01">
                <a class="dropdown-item" href="album.html">Course Registration<span class="sr-only">(current)</span></a>
                <a class="dropdown-item" href="#">Upload Pix </a>
                <a class="dropdown-item" href="svr/logout.php">sign Out</a>
              </div>
            </li>
          </ul>
      <!--     <form class="form-inline my-2 my-lg-0">
            <input id="myGenSearchInput" class="form-control mr-sm-2" onkeyup="mySearchFunction();" type="text" placeholder="Search for Family Member" aria-label="Search">
            <button class="btn btn-outline-success my-2 my-sm-0"  type="submit">Search</button>
          </form> -->
        </div>
    </nav>
      <!-- id 	first_name 	sur_name 	title 	parent_idr 	has_children 	children_names 	dob  year 	is_alive 	gender 	pix 	bio 	paternal_maternal 	dod 	 -->
    <div class="container">
      <div class="header"><h1 class="text-center">Input Data</h1> <hr></div>
      <div class="row">
        
        <div class="col-sm-3 input-box" id="input">
            <h3> Options</h3>
          <button class="btn btn-primary btn-block"  onClick="showLateDiv(1);"> Show input for deaseased family member</button>
          <button class="btn btn-primary btn-block"  onClick="showLateDiv(0);"> Hide input for deaseased family member</button>
          </br>
          <!-- Button to Open the Modal -->
          <!--  <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myBootstrapModal">   Lookup Unique Numbers  </button> -->
        </div> <!-- col1 -->

        <div class="col-sm-6 input-box" id="input">
            
          <form class= "form-signin" method="post" action="svr/update-data.php">  <!-- form action="svr/login.php" or button onClick="pasuser(this.form)"  -->
        
            <h1 class="h3 mb-3 font-weight-normal">Please Enter Requested Information</h1>
            <?php if (isset($msg)) echo $msg; ?>
            <label for="inputEmail"  >Email address</label>
            <input type="email" id="inputEmail" name="inputEmail"  class="form-control" placeholder="Email address"  autofocus>
            <label for="inputPassword"  >Password</label>
            <input type="password" id="inputPassword" name="inputPassword" class="form-control" placeholder="Password" >
            </br>
            <label for="id"  >id</label>
            <input type="text" id="id" name="id" class="form-control" value="<?php echo $id; ?>" required>


              <label for="first_name"  >Name of Family Member</label>
            <input type="text" id="first_name" name="first_name" class="form-control" value="<?php echo $first_name; ?>" placeholder="*first name" required>
              <label for="other_names"  >Other names of Family Member</label>
            <input type="text" id="other_names" name="other_names" class="form-control" value="<?php echo $other_names; ?>" placeholder="Other names">
              <label for="sur_name"  >Surname of Family Member</label>
            <input type="text" id="sur_name" name="sur_name" class="form-control" value="<?php echo $sur_name; ?>" placeholder="*Surname" required>
              <label for="title"  >Title</label>
            <input type="text" id="title" name="title" class="form-control" value="<?php echo $title; ?>" placeholder="*Title" required>

              <label for="parent_idr">Unique number of Parent of Family Member. look it up <span id="myBtn"  class="btn btn-secondary">here</span></label>
            <input type="text" id="parent_idr" name="parent_idr" class="form-control" value="<?php echo $parent_idr; ?>" placeholder="Parent Unique No." >
            
            <label for="has_children">Children (no. of male & no of female)</label>
            <input type="text" id="has_children" name="has_children" class="form-control" value="<?php echo $has_children; ?>" placeholder="Children (no. of male & no of female)" >
              <label for="children_names">Names of Children (Seperate with comma)</label>
            <input type="text" id="children_names" name="children_names" class="form-control" value="<?php echo $children_names; ?>" placeholder="children_names">
            <label for="dob"  >Date of Birth (yyyy-mm-dd)</label>
            <input type="text" id="dob" name="dob" class="form-control" value="<?php echo $dob; ?>" placeholder="DOB (yyyy-mm-dd)" >
              <label for="is_alive"  >Gender</label>
            <input type="text" id="gender" name="gender" class="form-control" value="<?php echo $gender; ?>" placeholder="*Gender (Male/Female)?" required>
            
            <label for="pix">Picture</label>
            <input type="file" id="pix" name="pix" class="form-control" value="<?php echo $pix; ?>" placeholder="Picture">
            <label for="bio"  >Bio</label>
            <input type="text" id="bio" name="bio" class="form-control" value="<?php echo $bio; ?>" placeholder="Bio" >
            <label for="bio"  >How are you related? Paternal or Maternal?</label>
            <input type="text" id="paternal_maternal" name="paternal_maternal" class="form-control" value="<?php echo $paternal_maternal; ?>" placeholder="*Paternal/Maternal?" required>
            <div id="late">
                  <label for="is_alive">Is this data for you (Yes), Are you entering it for a deceased family member (No)</label>
                  <input type="text" id="is_alive" name="is_alive" class="form-control" placeholder="Alive?" value="<?php echo $is_alive; ?>" required>

                  <label for="dod"  >Date of Death - If applicable (yyyy-mm-dd)</label>
                  <input type="text" id="dod" name="dod" class="form-control" value="<?php echo $dod; ?>" placeholder="DOD (yyyy-mm-dd)">
              </div>
            
            <div class="information" id='validate_msg' style="display:none">Please Read the Information Carefully</div>
            </br>
            <span class="btn btn-lg btn-primary btn-block" onClick="showConfirmation();">Request for Update</span>
            <button class="btn btn-lg btn-primary btn-block"  type="submit" 
            name ="submit" id ="submit" style="display: none;">Confirm Update</button>
          </form>
            <!-- Modal -->
            <div class="modal" id="myModal"  style="display: none;"> <!--  wrapper for Modal -->
              <div class="card" id="myModalCard" style="width: 22rem; margin:auto;">
                  <div class="card-header"> </div>
                  <div class="card-body" >
                  <h4 class="card-title"><hr></h4>
                  <button type="button" class="close" data-dismiss="modal">&times;</button>  
                  <h4 class="card-title">Unique Number Lookup</h4>
                  
                  <p class="card-subtitle">For data input</p> </br>
                  <!-- <img src="brand/tree.jpg"></img> -->
                      <label class="card-text" for="children_names">Enter Surname and Click Search:</label>
                      <!-- <input type="text" name="search" class="form-control" placeholder="surname"> -->
                      <!-- <span class="btn btn-primary">Search</span>  -->
                    </br> </br>

                                    
                      <form class="form-inline my-2 my-lg-0">
                        <input id="myInput" class="form-control mr-sm-2" onkeyup="mySearchFunction();" type="text" placeholder="Search for Family Member" aria-label="Search">
                        <span id="btnRefresh" class="btn btn-outline-success my-2 my-sm-0">Refresh</span>
                      </form>
                      <div class="card-text" id="card-data" style="border-width:1; display: block;">
                        <ul id="myULSearch" class="list-group" style="display: none;">
                          <li class="list-group-item"><a href="#">Adele (1)</a></li>
                          <li class="list-group-item"><a href="#">Agnes (2)</a></li>
                          <li class="list-group-item"><a href="#">Billy (3)</a></li>
                          <li class="list-group-item"><a href="#">Bob (4)</a></li>
                          <li class="list-group-item"><a href="#">Calvin (7)</a></li>
                          <li class="list-group-item"><a href="#">Christina</a></li>
                          <li class="list-group-item"><a href="#">Cindy</a></li>
                        </ul> 
                        Loading ...
                      </div>
                      <p class="card-text"> Take note of the unique number that will be displayed above  </p>
                      <div class="card-footer">eFamily</div>
                    </div>

              </div>
            </div> <!-- wrapper -->
        </div> <!-- col2 -->
          
        <div class="col-sm-3 input-box" id="input">
            <h4>Info</h4>
        </div> <!-- col3 -->
      
      </div>
      <div class="footer"><p class="mt-5 mb-3  text-center text-muted">&copy; 2017-2020</p></div>
    </div>

    <div id="scripts">
        <script src="js/jquery.min.js" type="text/javascript"></script>
        <script src="js/bootstrap.min.js" type="text/javascript"></script>

        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js" type="text/javascript"></script>
        <script language="javascript">
          //show late div
          function showLateDiv(dVal){
            if (dVal==1) 
            this.document.getElementById("late").style="display:block"
            else
            this.document.getElementById("late").style="display:none"
          }

          function showConfirmation(){
            this.document.getElementById("submit").style="display:block"
            
          }
        </script>

        <script language="javascript">
                    
                      var modal = document.getElementById("myModal");   // Get the modal         
                      var btn = document.getElementById("myBtn");// Get the button that opens the modal
                      var span = document.getElementsByClassName("close")[0];// Get the <span> element that closes the modal
                      var btnRefresh = document.getElementById('btnRefresh');
                      btn.onclick = function() {    // When the user clicks on the button, open the modal
                        modal.style.display = "block";
                      }

                      span.onclick = function() {   // When the user clicks on <span> (x), close the modal
                        modal.style.display = "none";
                      }
                      window.onclick = function(event) { // When the user clicks anywhere outside of the modal, close it
                        if (event.target == modal) {
                          modal.style.display = "none";
                        }
                      } 
                      

              
              
              var btnRefresh = document.getElementById('btnRefresh');
          
              btnRefresh.onclick = function() {    // When the user clicks on the button, clear text
                inputT = document.getElementById('myInput');
                  inputT.value="";
                
              }

              function mySearchFunction() {
              // Declare variables
              var input, filter, ul, li, a, i, txtValue;
              input = document.getElementById('myInput');
          
              filter = input.value.toUpperCase();
              ul = document.getElementById("myULSearch");
              li = ul.getElementsByTagName('li');
              ul.style.display = "" //first show all
              // Loop through all list items, and hide those who don't match the search query
              for (i = 0; i < li.length; i++) {
                a = li[i].getElementsByTagName("a")[0];
                txtValue = a.textContent || a.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                  li[i].style.display = "";
                } else {
                  li[i].style.display = "none";
                }
              }
            }
        </script>
        <!-- Autofill Script unstable - discontinued -->
        <script  type="text/javascript">
                //auto fill form
                // $(document).ready( function() {
                // //$('.form-control').on("change", function() {
                    
                //     var id= $('#id').val();
                //     //alert('yeh: got the id = ' + id);
                //     //$('#first_name').val('auto filled: '); //dR;
                //     $.ajax({
                //         type: 'GET',
                //         url:  'svr/api.php/records/efamily/'+ id,
                //         data: {'other_names' : '1'},
                //         dataType: 'json',
                //         cache: false,
                //         success: function(result) {
                //             var dR;
                //             dR= JSON.stringify(result);
                //             $('#first_name').val(result["first_name"]);
                //             $('#sur_name').val(result["sur_name"]);
                //             $('#title').val(result["title"]);
                //             $('#parent_idr').val(result["parent_idr"]);
                //             $('#has_children').val(result["has_children"]);
                //             $('#children_names').val(result["children_names"]);
                //             $('#dob').val(result["dob"]);
                //             $('#is_alive').val(result["is_alive"]);
                //             $('#gender').val(result["gender"]);
                //             $('#pix').val(result["pix"]);
                //             $('#bio').val(result["bio"]);
                //             $('#paternal_maternal').val(result["paternal_maternal"]);
                //             $('#dod').val(result["dod"]);
                //             $('#other_names').val(result["other_names"]);
                //             //alert('yeh: ' + ' returned' + dR);
                //         },
                //     });
                // });
        
        </script>
    
    
    </div>
  </body>
</html>
