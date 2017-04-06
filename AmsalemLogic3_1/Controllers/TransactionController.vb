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

        Function TransactionToPDF() As ActionResult
            Return View()

        End Function


    End Class
End Namespace