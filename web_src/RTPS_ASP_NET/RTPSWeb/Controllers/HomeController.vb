Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Result and Transcript Processing System."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "eddie.olaye@gmail.com; sites.google.com/dreolaye"

        Return View()
    End Function

    Function SignIn() As ActionResult
        ViewData("Prompt") = "Requires db Access"
        Return View()
    End Function


End Class
