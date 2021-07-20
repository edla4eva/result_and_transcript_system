@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>RTPS Result Software</h1>
    <p class="lead">
        Welcome
        .
    </p>

</div>

<div class="row">
    <div class="col-md-2">
        <h2>Course Adviser</h2>
        <p>
            Carry out tasks like generating broadsheet d...

        </p>
        <p><a href="App/Results" class="btn btn-primary btn-lg">Upload Results &raquo;</a></p>
        <p><a href="App/Results" class="btn btn-primary btn-lg">Generate Broadsheets &raquo;</a></p>
        <p><a class="btn btn-default" href="App/Results">Transcripts &raquo;</a></p>

        We have successfully received your letter of recommendation for X to Graduate School at the University of Cincinnati.
    </div>
    <div class="col-md-10">
        <h2>Get Started</h2>
        <p>Start using the Web version right away!</p>
        <p><a class="btn btn-default" href="/signin">Sign In &raquo;</a></p>
        <div class="col-md-6">
            <h2>Results Submitted</h2>
            <p>The number of results submitted by course Lecturers.</p>
            <div class="card"><h1 class="lead">27/100</h1></div>
            <p><a class="btn btn-default" href="/contact">Get Support &raquo;</a></p>

        </div>
        <div class="col-md-6">
            <h2>Registered Students</h2>
            <p>Our team are ever ready to provide support for you.</p>
            <p><a class="btn btn-default" href="/contact">Get Support &raquo;</a></p>
            <div class="card"><h1 class="lead">27/100</h1></div>
        </div>
    </div>
</div>

<div class="container px-4 py-5" id="custom-cards">
    <h2 class="pb-2 border-bottom">Custom cards</h2>

    <div class="row row-cols-1 row-cols-lg-3 align-items-stretch g-4 py-5">
        <div class="col">
            <div class="card card-cover h-100 overflow-hidden text-white bg-dark rounded-5 shadow-lg" style="background-image: url('unsplash-photo-1.jpg');">
                <div class="d-flex flex-column h-100 p-5 pb-3 text-white text-shadow-1">
                    <h2 class="pt-5 mt-5 mb-4 display-6 lh-1 fw-bold">Short title, long jacket</h2>
                    <ul class="d-flex list-unstyled mt-auto">
                        <li class="me-auto">
                            <img src="https://github.com/twbs.png" alt="Bootstrap" width="32" height="32" class="rounded-circle border border-white">
                        </li>
                        <li class="d-flex align-items-center me-3">
                            <svg class="bi me-2" width="1em" height="1em"><use xlink:href="#geo-fill" /></svg>
                            <small>Earth</small>
                        </li>
                        <li class="d-flex align-items-center">
                            <svg class="bi me-2" width="1em" height="1em"><use xlink:href="#calendar3" /></svg>
                            <small>3d</small>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

        <div class="col">
            <div class="card card-cover h-100 overflow-hidden text-white bg-dark rounded-5 shadow-lg" style="background-image: url('unsplash-photo-2.jpg');">
                <div class="d-flex flex-column h-100 p-5 pb-3 text-white text-shadow-1">
                    <h2 class="pt-5 mt-5 mb-4 display-6 lh-1 fw-bold">Much longer title that wraps to multiple lines</h2>
                    <ul class="d-flex list-unstyled mt-auto">
                        <li class="me-auto">
                            <img src="https://github.com/twbs.png" alt="Bootstrap" width="32" height="32" class="rounded-circle border border-white">
                        </li>
                        <li class="d-flex align-items-center me-3">
                            <svg class="bi me-2" width="1em" height="1em"><use xlink:href="#geo-fill" /></svg>
                            <small>Pakistan</small>
                        </li>
                        <li class="d-flex align-items-center">
                            <svg class="bi me-2" width="1em" height="1em"><use xlink:href="#calendar3" /></svg>
                            <small>4d</small>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

        <div class="col">
            <div class="card card-cover h-100 overflow-hidden text-white bg-dark rounded-5 shadow-lg" style="background-image: url('unsplash-photo-3.jpg');">
                <div class="d-flex flex-column h-100 p-5 pb-3 text-shadow-1">
                    <h2 class="pt-5 mt-5 mb-4 display-6 lh-1 fw-bold">Another longer title belongs here</h2>
                    <ul class="d-flex list-unstyled mt-auto">
                        <li class="me-auto">
                            <img src="https://github.com/twbs.png" alt="Bootstrap" width="32" height="32" class="rounded-circle border border-white">
                        </li>
                        <li class="d-flex align-items-center me-3">
                            <svg class="bi me-2" width="1em" height="1em"><use xlink:href="#geo-fill" /></svg>
                            <small>California</small>
                        </li>
                        <li class="d-flex align-items-center">
                            <svg class="bi me-2" width="1em" height="1em"><use xlink:href="#calendar3" /></svg>
                            <small>5d</small>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
