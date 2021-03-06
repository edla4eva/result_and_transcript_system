<?php 
  //require_once( 'adminCMS/cms.php' );   //couchCMS makes content editable
	define('BASEPATH', ''); // Path to the system directory
  session_start();
  if (!isset( $_SESSION['UserData']['inputEmail'])) {
    header("location:sign-in.php") ;
  } else {
    $usernamePara='('.$_SESSION['UserData']['inputEmail'].')';
    $username=$_SESSION['UserData']['inputEmail'];
    $id=1;
    if (isset( $_SESSION['UserData']['id'])) $id=$_SESSION['UserData']['id'];
  }
//print_r($_SESSION); //debug
?>
<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Jekyll v4.0.1">
    <title>RTPS Software Home</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/4.5/examples/jumbotron/">

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

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
  <a class="navbar-brand" href="index.php">eFamily</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarsExampleDefault">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="index.php">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link disabled" href="sign-in.html">Sign In</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="input.php?id=<?php echo $id; ?>" tabindex="-1" >Course Registration</a>
      </li>
      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="dropdown01" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Member Area<?php echo $usernamePara; ?></a>
        <div class="dropdown-menu" aria-labelledby="dropdown01">
          <a class="dropdown-item" href="tree.php?id=<?php echo $id; ?>">User Page/Profile</a>
          <a class="dropdown-item" href="update.php?id=<?php echo $id; ?>">Update Records</a>
           <a class="dropdown-item" href="upload.php?username=<?php echo $username; ?>">Upload Pix</a>
          <a class="dropdown-item" href="result.php?username=<?php echo $username; ?>">View Result</a>
          <a class="dropdown-item" href="password.php?username=<?php echo $username; ?>">Change Password</a>
          <a class="dropdown-item" href="svr/logout.php">Sign Out (Exit)</a>
        </div>
      </li>

    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search">
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
    </form>
  </div>
</nav>

<main role="main">

  <!-- Main jumbotron for a primary marketing message or call to action -->
  <div class="jumbotron">
    <div class="container">
      <h1 class="display-3">RTPS Result Software</h1>
      <p>Your Sign In was successful!</p>
       You can register your courses of view your results.  the family tree and photo album. To contribute to the records click <a href="input.php">here</a> To view your page click <a href="tree.php?id=<?php echo $id; ?>">here</a>
        </div>
  </div>

  <div class="container">
    <!-- Example row of columns -->
    <div class="row">
      <div class="col-md-4">
      <!-- <h4>Trace your lineage</h4> -->
        <!-- <p>Select the most applicable       </p> -->
        <div class="col-md-4 ">
          <!-- <ul class="list-pills">
            <li><a href="#" class="text-black">First Generation</a></li>
            <li><a href="#" class="text-black">Second Generation</a></li>

          </ul>
          Enter your father or grandfathers name<input></input>
          <button id="search_lineage" class="btn btn-success">Trace</button> -->
          <div id="lineage"></div>
        </div>
        <br>
        <h4>Quick Links</h4>
        <p>There are a lot more we can achieve together, contact us
        </p>
        <div class="col-md-4 ">
          <ul class="list-unstyled">
            
            <li><a href="mailto:eddio.olaye@gmail.com?subject=RTPS" class="text-black">Email Us</a></li>

          </ul>
        </div>
        
      </div>
      <div class="col-md-8">
      <h2>Quick Guide</h2>
      <cms:editable name='quick_guide' type='richtext'>
        <p>This Web application was developed to make
            it easier for students to register their courses with their Course Advisers. 
        </p>
        <p>
            Each student is to fill out the course
            registration form. Note that the courses hat must be registered will be
            prefilled by the Course Adviser. After submitting the form, an appointment will
            be booked for the Course Adviser to vet the registered courses. The hard copy
            registration slip should be submitted to the course adviser.

      </p>
      </cms:editable>
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
<script src="js/home-search.js"></script>
</html>
<?php //COUCH::invoke(); ?>