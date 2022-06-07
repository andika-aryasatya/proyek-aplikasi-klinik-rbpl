Public NotInheritable Class FormSplashScreen
    Private Sub frSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Thistle
        Me.WindowState = FormWindowState.Maximized
        PanelLuar.Top = (Me.Height - PanelLuar.Height) / 2
        PanelLuar.Left = (Me.Width - PanelLuar.Width) / 2
    End Sub

    Private Sub SplashTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplashTimer.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value <= 30 Then
            Label1.Text = "Inisialisasi Program ....."
        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Loading Component Program ....."
        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "Koneksi ke Database ...."
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Silahkan Ditunggu ...."
        End If

        If ProgressBar1.Value = 100 Then
            SplashTimer.Dispose()
            Timer1.Dispose()
            Me.Visible = False
            frMenuMedical.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim logika As New Boolean
        If logika = True Then
            logika = Not logika
        ElseIf logika = False Then
            logika = Not logika
        End If
        If logika = True Then
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.Label7.ForeColor = System.Drawing.Color.BlueViolet
        Else
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.Label7.ForeColor = System.Drawing.Color.Violet

        End If
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        SplashTimer.Dispose()
        Timer1.Dispose()
        Me.Visible = False
        frMenuMedical.Show()
    End Sub
End Class
