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
  <link href="../css/bootstrap.min.css" rel="stylesheet">

</head>
  <body>
  <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
    <a class="navbar-brand" href="index.php">RTPS</a>
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



<div class="jumbotron">
    <div class="container">
      <h1 class="display-3">RTPS Result Software</h1>
      <p>Your Sign In was successful!</p>
       You can register your courses of view your results.  the family tree and photo album. To contribute to the records click <a href="input.php">here</a> To view your page click <a href="tree.php?id=<?php echo $id; ?>">here</a>
        </div>
  </div>
    


<!-- <script src="../js/jquery.min.js" type="text/javascript"></script>
<script src="../js/bootstrap.min.js" type="text/javascript"></script> -->
</body>
</html>
