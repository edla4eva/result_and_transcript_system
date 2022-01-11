<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Jekyll v4.0.1">
    <title>Error</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/4.5/examples/sign-in/">

    <!-- Bootstrap core CSS -->
  <link href="../css/bootstrap.min.css" rel="stylesheet">

</head>
  <body>
  <nav class="navbar navbar-expand-md navbar-dark bg-dark">
    <a class="navbar-brand" href="../index.php">eFamily</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse" id="navbarsExampleDefault">
        <ul class="navbar-nav mr-auto">
        <li class="nav-item">
            <a class="nav-link" href="../index.php">Home</a>
        </li>


        </ul>
    <!--     <form class="form-inline my-2 my-lg-0">
        <input id="myGenSearchInput" class="form-control mr-sm-2" onkeyup="mySearchFunction();" type="text" placeholder="Search for Family Member" aria-label="Search">
        <button class="btn btn-outline-success my-2 my-sm-0"  type="submit">Search</button>
        </form> -->
    </div>
  </nav>



  <div class="jumbotron">
  <div class="header"><h1 class="text-center text-danger">Error!</h1> <hr></div>
    <h3 class="text-center"><?php if (isset($msg)) echo $msg; ?></h3>

    <h3 class="text-center">Oops! Theere was an error</h3>
    <p class="text-center">Please contact your administrator. </br> 
    Go back to <a href="../index.php">home</a> page</p>
  </div>
    


<script src="../js/jquery.min.js" type="text/javascript"></script>
<script src="../js/bootstrap.min.js" type="text/javascript"></script>

  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js" type="text/javascript"></script>
</body>
</html>
