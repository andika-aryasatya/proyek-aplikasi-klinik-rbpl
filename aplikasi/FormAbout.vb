Public NotInheritable Class FormAbout

    Private Sub FormAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Kelompok RBPL"
        Me.LabelVersion.Text = "Andika Aryasatya, Umi Rohmah NH, Inge Dwi Pratiwi"
        Me.LabelCopyright.Text = "UPN Veteran Yogyakarta"
        Me.LabelCompanyName.Text = "Yogyakarta"
        Me.TextBoxDescription.Text = My.Application.Info.Description
        Me.BackColor = Color.Goldenrod
        Me.WindowState = FormWindowState.Maximized
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
