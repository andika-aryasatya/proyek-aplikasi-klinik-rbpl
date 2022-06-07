Public Class FormBantuanProgram

    Private Sub frbantuanprogram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.AllowNavigation = False
        WebBrowser1.Navigate(frMenuMedical.App_Path & "help.htm")
    End Sub
End Class