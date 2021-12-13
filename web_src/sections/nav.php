<nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
  <a class="navbar-brand" href="index.php">eFamily</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarsExampleDefault">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item">
        <a class="nav-link" href="home.html">Home</a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="#">Family Tree <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link disabled" href="sign-in.php" tabindex="-1" aria-disabled="true">Sign In</a>
      </li>
      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="dropdown01" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">User</a>
        <div class="dropdown-menu" aria-labelledby="dropdown01">
          <a class="dropdown-item" href="album.html">Album</a>
          <a class="dropdown-item" href="#">Input Data</a>
          <a class="dropdown-item" href="svr/logout.php">sign Out</a>
        </div>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input id="myInput" class="form-control mr-sm-2" onkeyup="mySearchFunction();" type="text" placeholder="Search for Family Member" aria-label="Search">
      <button class="btn btn-outline-success my-2 my-sm-0"  type="submit">Search</button>
    </form>
  </div>
</nav>