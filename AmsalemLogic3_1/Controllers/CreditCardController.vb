﻿Imports System.Web.Mvc
Imports System.Windows
Imports AmsalemLogic.NewLogic
Imports AmsalemLogic.NewLogic.Classes
Imports AmsalemLogic.VBClasses
Imports AmsalemLogic.VBClasses.Administration
Imports AmsalemLogic
Imports Amsalem.Types
Imports AmsalemLogic.NewLogic.Classes.Products.ArchiveMongoDB
Imports System.Drawing
Imports System.IO

Namespace Controllers
    Public Class CreditCardController
        Inherits Controller

        Function CreditCardTable() As ActionResult

            If (PermissionCheck("Credit Card Admin")) Then
                Dim Handler = New PaidByUsHandler()
                Dim ListOfCardes = Handler.GetAllCards
                Return View(ListOfCardes)
            Else
                Return Content("<script language='javascript' type='text/javascript'>alert('Not Permission!');</script>")

            End If

        End Function

        Function ShowImage(id As String) As FileContentResult

            Dim Handler = New MongoDBHandler()
            Dim byteArrayImage = Handler.ReadImage(id)
            Return File(byteArrayImage, "image/png")

        End Function

        <HttpPost()>
        Function UploadImage(file As HttpPostedFileBase, fileName As String) As ActionResult

            Dim theImage = Image.FromStream(file.InputStream, True, True)
            'Dim theImageName = Path.GetFileNameWithoutExtension(file.FileName)
            Dim theImageName = fileName
            Dim Handler = New MongoDBHandler()
            Handler.UploadImage(theImage, theImageName)

            Return Redirect(Request.UrlReferrer.PathAndQuery)
        End Function

        Function PermissionCheck(permissionName As String) As Boolean
            Dim user = ClassUsers.GetCurrentUser()
            Dim userPermission = New UserPermissionHandler()
            Dim permission = userPermission.IsActionAllowed(user.PermissionGroup, permissionName, "")
            If (Not permission) Then
                'Throw New ApplicationException(userPermission.UNAUTHORIZED_MESSAGE)
                Return False
            Else
                Return True
            End If
        End Function

    End Class
End Namespace