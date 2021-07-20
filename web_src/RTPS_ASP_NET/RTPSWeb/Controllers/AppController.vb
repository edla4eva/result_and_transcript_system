Public Class AppController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Results() As ActionResult
        Dim x As New ClassResultTable
        ViewData("ResulHeading") = "This is a fancy heading for the result: CPE001"
        ViewData("Result") = x.getAllResult

        ViewData("ResultSummary") = "Average Score:"

        Return View()
    End Function
End Class
