<?php 
define('BASEPATH', '');
session_start(); /* Starts the session */
if (!isset( $_SESSION['UserData']['inputEmail'])) {
  header("location:sign-in.php") ;
} else {
  $usernamePara='('.$_SESSION['UserData']['inputEmail'].')';
  $username=$_SESSION['UserData']['inputEmail'];
}
$msg="";
if ($_SERVER["REQUEST_METHOD"] == "GET") {
  if (isset( $_GET["msg"])) $msg = $_GET["msg"];
  if ($msg=="-1") $msg="Could not add record! Please check the inputs and try again";
}
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
      




      <!-- </body>
      </html> -->

      <div class="row">
        
        <div class="col-sm-3 input-box" id="input">
            <h3> Instructions</h3>
            Click on browse button to upload a picture to the album
          </br>
          </div> <!-- col1 -->

        <div class="col-sm-6 input-box" id="input">
            
          <form class= "form-signin" method="post" action="svr/input-data.php">  <!-- form action="svr/login.php" or button onClick="pasuser(this.form)"  -->

          </form>
          <?php include 'svr/upload-pix.php'; ?>
           <!-- Upload form -->
          <form method='post' action='' enctype='multipart/form-data'>
            <br><hr>
            <input type='file' name='imagefiles' >
            <label for="title" class="sr-only">Title</label>
            <br><hr>
            <input type="text" id="title" name="title" class="form-control" placeholder="*Title" required>
            <input class="btn btn-lg btn-primary btn-block"  type='submit' value='Upload' name='upload'> 
          </form>

        </div> <!-- col2 -->
          
        <div class="col-sm-3 input-box" id="input">
            <h4>Info</h4>
        </div> <!-- col3 -->
      
      </div>
      <div class="footer"><p class="mt-5 mb-3  text-center text-muted">&copy; 2017-2020</p></div>
    </div>

    <div id="scripts">
        <script language="javascript">

          function showConfirmation(){
            this.document.getElementById("submit").style="display:block"
            
          }
        </script>

        <script src="js/jquery.min.js" type="text/javascript"></script>
        <script src="js/bootstrap.min.js" type="text/javascript"></script>

        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js" type="text/javascript"></script>
    </div>
  </body>
</html>
