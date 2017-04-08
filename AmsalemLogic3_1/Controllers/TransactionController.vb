Imports System.Web.Mvc
Imports AmsalemLogic.NewLogic.Classes
Imports AmsalemLogic.VBClasses
Imports AmsalemLogic.VBClasses.Administration
Imports AmsalemLogic
Imports Amsalem.Types
Imports AmsalemLogic.NewLogic.Classes.Products.ArchiveMongoDB
Imports System.Drawing
Imports System.IO

Namespace Controllers
    Public Class TransactionController
        Inherits Controller

        Function Index() As ActionResult
            Return View()

        End Function

        Function TransactionTable() As ActionResult
            Return View()

        End Function

        Function NewForm() As ActionResult
            Dim user = ClassUsers.GetCurrentUser()
            ViewBag.user = user
            ViewBag.trip = Nothing
            Return View()
        End Function

        Function Create(transaction As PaidByUsTransaction) As ActionResult
            'TODO
            Dim handler = New PaidByUsHandler()
            Dim user = ClassUsers.GetCurrentUser()
            Dim rop = handler.CreateNewTransaction(transaction, user)
            Return Json(rop)
        End Function

        Function TransactionToPDF(id As String) As ActionResult
            'ViewBag.TransactionId = id
            Dim transaction = New PaidByUsTransaction()
            transaction.OriginalCurrencyCode = "USD"
            transaction.For = "Shay zohar"
            transaction.Item = "LepTop"
            transaction.OriginalAmount = 2050
            ViewBag.Transaction = transaction
            Return View()
        End Function


    End Class
End Namespace