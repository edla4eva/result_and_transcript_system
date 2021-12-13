<?php 
define('BASEPATH', '');
session_start(); /* Starts the session */
$msg="";
if ($_SERVER["REQUEST_METHOD"] == "GET") {
  if (isset($_GET["msg"])){
     $msg = $_GET["msg"];
      if ($msg=="1") $msg='<div class="alert alert-info">Message submitted successfully! </div>';
      if ($msg=="-1") $msg="Could not submit message! Wrong credentials";
      if ($msg=="-2") $msg="Could not submit message! Database error";
  }
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
    <title>RTPS</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/4.5/examples/jumbotron/">
  <script> 
          
      // Function to check Whether both passwords 
      // is same or not. 
      function checkPassword(form) { 
          password1 = form.password1.value; 
          password2 = form.password2.value; 

          // If password not entered 
          if (password1 == '') 
              alert ("Please enter Password"); 
                
          // If confirm password not entered 
          else if (password2 == '') 
              alert ("Please enter confirm password"); 
                
          // If Not same return False.     
          else if (password1 != password2) { 
              alert ("\nPassword did not match: Please try again...") 
              return false; 
          } 

          // If same return True. 
          else{ 
              alert("Password Match: Welcome to GeeksforGeeks!") 
              return true; 
          } 
      } 
  </script> 
    <!-- Bootstrap core CSS -->
<link href="css/bootstrap.css" rel="stylesheet">

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>
    <!-- Custom styles for this template -->
    <link href="css/welcome.css" rel="stylesheet">
  </head>
  <body>
    <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
  <a class="navbar-brand" href="index.php">RTPS</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarsExampleDefault">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item">
        <a class="nav-link" href="index.php">Home</a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="#">Guide  <span class="sr-only">(current)</span></a>
      </li>

      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="dropdown01" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">About the Package</a>
        <div class="dropdown-menu" aria-labelledby="dropdown01">
          <a class="dropdown-item" href="guide.php#how">How to access</a>
          <a class="dropdown-item" href="guide.php#who">Who can Access</a>

        </div>
      </li>
    </ul>

  </div>
</nav>

<main role="main">

  <!-- Main jumbotron for a primary marketing message or call to action -->
  <div class="jumbotron">
    <div class="container">
      <h1 class="display-3">User's Guide</h1>
      <p>You are in the right place to learn more about the RTPS Result Sotware
        Use the menu above to navigate this guide.
      </p>
    </div>
  </div>

  <div class="container">
    <!-- Example row of columns -->
    <div class="row">
      <div class="col-md-4">
        <h2>Contact Us</h2><a id="enquiry"></a>
        <?php if (isset($msg)) echo $msg; ?>
        <p>If you have anny request, kindly send an email to admin@eobadan.descedants.com or fill the contact form below</p>
        <form class= "form-signin" method="post" action="svr/contact.php">  <!-- form action="svr/login.php" or button onClick="pasuser(this.form)"  -->
          <!-- <img class="mb-4" src="brand/tree.jpg" alt="" width="72" height="72"> -->
        <label for="username" class="sr-only">Name</label>
        <input type="text" id="username" name="username"  class="form-control" placeholder="Name" required autofocus>

        <label for="inputEmail" class="sr-only">Email address (Optional)</label>
        <input type="email" id="inputEmail" name="inputEmail"  class="form-control" placeholder="Email address">
        <label for="phone" class="sr-only">Phone Number</label>
        <input type="text" id="phone" name="phone"  class="form-control" placeholder="Phone" required autofocus>

        <label for="request" class="sr-only">Request</label>
        <textarea  type="text" id="request" name="request" class="form-control" placeholder="request" required></textarea>
        <button class="btn btn-lg btn-primary btn-block"  type="submit" name ="submit">Send</button>
        
      </form>

        

        
      </div>
      <div class="col-md-8">
        <h2>Introduction</h2>
        <p>Introduction  </p>

        <h2>Who can access</h2><a id="who"></a>.
        <p>
          
          Bonafide Students
        </p>

        <h2>How to access</h2><a id="how"></a>.
        <p>You can access the package right away. Navigate to the home page and fill the signup form. 
            The system will log you in automatically. <br> 
        </p>


      </div>
    </div>

    <hr>

  </div> <!-- /container -->

</main>

<footer class="container">
  <p>&copy; 2017-2020</p>
</footer>
<!-- <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
      <script>window.jQuery || document.write('<script src="../assets/js/vendor/jquery.slim.min.js"><\/script>')</script><script src="../assets/dist/js/bootstrap.bundle.js"></script></body>
-->
<script src="js/jquery.min.js"> </script> 
<script src="js/bootstrap.bundle.js"></script>

</html>
