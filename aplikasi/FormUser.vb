Public Class FormUser

#Region "SubProgram"
    Sub Navigasi(ByVal tombol As Boolean)
        Me.btSave.Enabled = Not tombol
        Me.btDelete.Enabled = Not tombol
        'Me.btClose.Enabled = tombol
    End Sub
    Sub IsianForm(ByVal aktif As Boolean)
        'Me.txtIDUser.Enabled = aktif
        Me.txtNamaUser.Enabled = Not aktif
        Me.txtPassword.Enabled = Not aktif
        Me.cbLevelUser.Enabled = Not aktif
    End Sub
    Sub ComboLevel()
        cbLevelUser.Items.Add(1)
        cbLevelUser.Items.Add(2)
    End Sub
#End Region
    Private Sub frUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modLogin.IsiCombo("select nip,nama from tpegawai", txtIDUser)
        Me.WindowState = FormWindowState.Maximized
        Me.Text = ":: DAFTAR USER ::"
        Me.ControlBox = False
        Me.BackColor = Color.DarkSeaGreen
        Me.PanelLogin.BackColor = Color.PaleGreen
        Me.txtIDUser.Focus()
        Me.Navigasi(True)
        Me.IsianForm(False)
        Me.ComboLevel()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        ModuleUser.SaveRecordUser()
        MsgBox("Data telah tersimpan")
        Me.IsianForm(False)
        Me.Navigasi(True)
        modLogin.levelAdmin(False)
        Me.Close()
    End Sub

    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        If txtPassword.Text = "" Then
            MsgBox("Pegawai dengan Nama : " & txtNamaUser.Text & " Belum terdaftar sebagai user")
        Else
            ModuleUser.DeleteRecordUser()
            Me.IsianForm(False)
            Me.Navigasi(True)
        End If
    End Sub
    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
        'modLogin.levelAdmin(False)
    End Sub

    Private Sub txtIDUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDUser.SelectedIndexChanged
        Dim user As String
        user = ModuleUser.user
        If user = 1 Or user = 2 Then
            ModuleUser.tampiluser()
            'ModuleUser.AddRecordUser()
            Me.IsianForm(True)
            Me.Navigasi(False)
            Me.txtNamaUser.Focus()
        Else
            ModuleUser.AddRecordUser()
            Me.IsianForm(False)
            txtNamaUser.Enabled = False
            txtPassword.Text = ""
            cbLevelUser.Text = "- pilih -"
            Me.Navigasi(False)
            ModuleUser.tampilpegawai()
            Me.txtNamaUser.Focus()
        End If
    End Sub
End Class