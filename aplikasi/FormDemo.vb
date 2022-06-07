Public Class FormDemo

    Private Sub FormDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Form Backup | Restore | Stock Obat"
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.BackColor = Color.DarkGreen
        Me.btClose.BackColor = Color.Chocolate
        PanelLuar.Top = (Me.Height - PanelLuar.Height) / 2
        PanelLuar.Left = (Me.Width - PanelLuar.Width) / 2
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbNama.Text = Microsoft.VisualBasic.Right(lbNama.Text, 1) + Microsoft.VisualBasic.Left(lbNama.Text, Len(lbNama.Text) - 1)
        lbNama.ForeColor = Color.White
    End Sub

End Class