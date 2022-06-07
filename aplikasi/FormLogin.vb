Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class FormLogin
    Function Login() As Integer
        Dim koneksi As New aksesData.aksesMedical
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try
            cmd.Connection = koneksi.buka
            cmd.CommandType = CommandType.Text
            cmd.CommandText = ("select l.level_user from tlogin l,tpegawai p where l.nip=p.nip and p.nama='" & Me.txtNamaUser.Text & "' and l.pass='" & Me.txtPassword.Text & "'")
            dr = cmd.ExecuteReader
            If (dr.Read()) Then
                Return CStr(dr.GetValue(0))
            Else
                Return 0
            End If
            koneksi.Tutup()

        Catch ex As Exception
            MsgBox("Nama User Atau Password Tidak Terdaftar, Ulangi...!", MsgBoxStyle.OkCancel, "Login-sistem")
            koneksi.tutup()
        End Try

    End Function

    Private Sub frLoginSistem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modLogin.FormLoad()
        modLogin.levelAdmin(False)
        modLogin.FormNavigasi(False)
        Me.txtNamaUser.Text = "- pilih -"
        modLogin.IsiCombo("select tpegawai.nama from tpegawai inner join tlogin on tpegawai.nip=tlogin.nip", txtNamaUser)
    End Sub

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        VerifikasiUser = Login()
        If (VerifikasiUser = 1) Then
            Dim menuMedical As New frMenuMedical
            modLogin.levelAdmin(True)
            menuMedical.ShowInTaskbar = False
            menuMedical.mnLogin.Enabled = False
            frMenuMedical.tssUser.Text = txtNamaUser.Text
            Me.Close()
        ElseIf (VerifikasiUser = 2) Then
            Dim mnuMedical As New frMenuMedical
            modLogin.levelMaster(True)
            mnuMedical.mnLogin.Enabled = False
            frMenuMedical.tssUser.Text = txtNamaUser.Text
            Me.Close()
        ElseIf (VerifikasiUser = 3) Then
            Dim mnuMedical As New frMenuMedical
            modLogin.levelTransaksi(True)
            mnuMedical.mnLogin.Enabled = False
            frMenuMedical.tssUser.Text = txtNamaUser.Text
            Me.Close()
        Else
            Me.txtNamaUser.Focus()
        End If
    End Sub

    Private Sub txtNamaUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modLogin.FormNavigasi(True)
    End Sub

    Private Sub txtNamaUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaUser.SelectedIndexChanged
        modLogin.FormNavigasi(True)
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()
        modLogin.levelAdmin(False)
    End Sub

End Class