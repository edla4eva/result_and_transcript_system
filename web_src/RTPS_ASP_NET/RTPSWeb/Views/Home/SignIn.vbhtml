@Code
    ViewData("Title") = "Sign In"
End Code

<div class="banner">

    
</div>

<div class="row">
    <div class="col-md-4">
        <h2></h2>
        <p>

        </p>
        <p><a class="btn btn-default" href="/about/?LinkId=301865">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2 class="center-block">RTPS Sign In</h2>
        <p class="lead">
            Enter your username and password.
        </p>
        <p class="center-block">password is case sensitive!</p>
        <div class="form">
            <form class="form-signin border" method="post" action="/App">
                <!-- form action="svr/login.php" or button onClick="pasuser(this.form)"  -->
                <img class="center-block" src="~/Content/images/unibenlogo.png" alt="" width="100" height="100">
                <br>

                <label for="username" class="sr-only">Username (or Email)</label>
                <input type="text" id="username" name="username" class="form-control" placeholder="Username" required autofocus>
                <label for="inputPassword" class="sr-only">Password</label>
                <input type="password" id="inputPassword" name="inputPassword" class="form-control-password" placeholder="Password" required>

                <div class="input-inline-custom">
                    <div class="input-inline-cell-custom"> <input type="password" id="inputPassword" name="inputPassword" class="form-control-password" placeholder="Password" required></div>
                    <div class="input-inline-cell-custom" style="max-width:100px;"><span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password" onclick="myFunction()"></span></div>
                </div>
                <!-- An element to toggle between password visibility -->
                <!-- <input type="checkbox" onclick="myFunction()"> Show Password  -->

                <div class="checkbox mb-3">
                    <label>
                        <input type="checkbox" value="remember-me"> Remember me
                    </label>
                </div>
                <button class="btn btn-lg btn-primary btn-block" type="submit" name="submit">Sign in</button>
                <p class="mt-5 mb-3 text-muted">&copy; 2017-2020</p>
            </form>

        </div>
        <p><a class="btn btn-default" href="~/signin">Sign In &raquo;</a></p>
        <p>passDont have an account? You can sign up for one</p>
        <p><a href="#" class="btn btn-primary btn-lg">Sign Up &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2></h2>

    </div>
</div>
