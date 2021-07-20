@Code
    ViewData("Title") = "Results"
End Code


<div>
    <div class="row bg-success">
        <div class="btn-group-vertical col-md-2"></div>
        <div class="btn-group-vertical col-md-10">
            <h2>@ViewData("Title")</h2>
        </div>
    </div>
    <div class="row">
        <div class="glyphicon glyphicon-circle-arrow-down"></div>
        <div class="btn-group-vertical col-md-2">
            <div class="dropdown-menu">
                <ul class="dropdown-menu">
                    <li>Home</li>
                    <li>User</li>
                </ul>
            </div>
            <p><a href="~/App/Index" class="btn btn-primary btn-lg  btn-block">Upload All <span class="glyphicon glyphicon-cloud-upload glyphicon-align-right"></span></a></p>
            <p><a href="~/Home/Contact" class="btn btn-primary btn-lg  btn-block text-left">Browse <span class="glyphicon glyphicon-folder-open glyphicon-align-right"></span></a></p>
            <p><a href="~/Home/Contact" class="btn btn-primary btn-lg  btn-block">Check Result <span class="glyphicon glyphicon-check glyphicon-align-right"></span></a></p>
            <p><a href="~/Home/Contact" class="btn btn-primary btn-lg  btn-block">Upload <span class="glyphicon glyphicon-upload glyphicon-align-right"></span></a></p>
            <p><a href="~/Home/Contact" class="btn btn-primary btn-lg  btn-block">
                <span class="spinner-grow spinner-grow-sm"></span>Uploading</a>
            </p>
            <p><a href="~/Home/Contact" class="btn btn-primary btn-lg  btn-block">List Results <span class="glyphicon glyphicon-download glyphicon-align-right"></span></a></p>

            <p><a href="home/contact" class="btn btn-primary btn-lg  btn-block">Sync <span class="glyphicon glyphicon-cloud glyphicon-align-right"></span></a></p>
            <p><a href="home/contact" class="btn btn-primary btn-lg  btn-block">Close <span class="glyphicon glyphicon-arrow-down glyphicon-align-right"></span></a></p>

        </div>
        <div class="btn-group-vertical col-md-10">
                    <div class=" alert alert-info"><h3>The Table below shows a Summary of All results</h3></div>
            <h3>@ViewData("ResultHeading").</h3>

            <input class="center-block" id="TextFileName" type="text" />
            @ViewData("Results")

            <hr />
            <div class="table-responsive">
                <table class="table table-striped table-sm" style="width:100%;">
                    <tr><td>MatNo</td><td>Name</td><td>&nbsp;</td></tr>
                    <tr><td>12000</td><td>Bala</td><td>12</td></tr>
                    <tr>
                        <td>180900</td>
                        <td>Cobo</td>
                        <td>15</td>
                    </tr>
                    <tr>
                        <td>189999</td>
                        <td>Ola</td>
                        <td>30</td>
                    </tr>
                </table>
            </div>
            <hr />
            <div class="container">
                <p>Details</p>
                <p class="panel-info">
                    Go ahead and schedule your exam in advance. By scheduling ahead, you can choose a time for your exam appointment that is most convenient for you and stay motivated by the date on your calendar.
                    Learn more about taking your exam from home with online proctoring through Pearson VUE

                </p>
                <table class="table table-striped table-sm" style="width:100%;">
                    <tr><td>MatNo</td><td>Name</td><td>&nbsp;</td></tr>
                    <tr><td>12000</td><td>Bala</td><td>12</td></tr>
                    <tr>
                        <td>180900</td>
                        <td>Cobo</td>
                        <td>15</td>
                    </tr>
                    <tr>
                        <td>189999</td>
                        <td>Ola</td>
                        <td>30</td>
                    </tr>
                </table>
                <p>
                    Go ahead and schedule your exam in advance. By scheduling ahead, you can choose a time for your exam appointment that is most convenient for you and stay motivated by the date on your calendar.
                    Learn more about taking your exam from home with online proctoring through Pearson VUE

                </p>
                <p><a href="~/Home/Contact" class="btn btn-warning btn-lg  btn-block">Browse <span class="glyphicon-arrow-down"></span></a></p>


            </div>
        </div>

    </div>
    <div class="row">
        <span class="icon-bar"></span>
        <div class="alert alert-warning fade">
            <img src="http://entechprod.blob.core.windows.net/dotnetfiddle/morpheus.jpg" style="max-width:100%;" /><br /><br />
            <strong><span class="alert-content"></span></strong>
        </div>
    </div>


    <div class="row">
        <table class="table-responsive table-striped" style="width:100%;">
            <tr><td>MatNo</td><td>Name</td><td>&nbsp;</td></tr>
            <tr><td>12000</td><td>Bala</td><td>12</td></tr>
            <tr>
                <td>180900</td>
                <td>Cobo</td>
                <td>15</td>
            </tr>
            <tr>
                <td>189999</td>
                <td>Ola</td>
                <td>30</td>
            </tr>
        </table>
    </div>



</div>

<div class="container col-xl-10 col-xxl-8 px-4 py-5">
    <div class="row align-items-center g-lg-5 py-5">
        <div class="col-lg-7 text-center text-lg-start">
            <h1 class="display-4 fw-bold lh-1 mb-3">Vertically centered hero sign-up form</h1>
            <p class="col-lg-10 fs-4">Below is an example form built entirely with Bootstrap’s form controls. Each required form group has a validation state that can be triggered by attempting to submit the form without completing it.</p>
        </div>
        <div class="col-md-10 mx-auto col-lg-5">
            <form class="p-4 p-md-5 border rounded-3 bg-light">
                <div class="form-floating mb-3">
                    <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
                    <label for="floatingInput">Email address</label>
                </div>
                <div class="form-floating mb-3">
                    <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
                    <label for="floatingPassword">Password</label>
                </div>
                <div class="checkbox mb-3">
                    <label>
                        <input type="checkbox" value="remember-me"> Remember me
                    </label>
                </div>
                <button class="w-100 btn btn-lg btn-primary" type="submit">Sign up</button>
                <hr class="my-4">
                <small class="text-muted">By clicking Sign up, you agree to the terms of use.</small>
            </form>
        </div>
    </div>
</div>


<code>@ViewData("ResultSummary").</code>
