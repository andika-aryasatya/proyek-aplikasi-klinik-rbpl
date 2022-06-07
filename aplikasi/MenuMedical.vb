Imports System.IO
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Public Class frMenuMedical
        Private Sub frMenuMedical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modMenu.FormLoad()
        modLogin.levelAdmin(False)
    End Sub
#Region "MENU SISTEM"
    '--- kejadian pada menu Sistem ---
    Private Sub mnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLogin.Click
        FormLogin.MdiParent = Me
        FormLogin.Show()
        ' Call modLogin.levelUser(True)
        Me.mnLogin.Enabled = False
    End Sub
    Private Sub mnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLogOut.Click
        Dim logout As String = MsgBox("Logout dari program Rekam Medis...?", vbYesNo, "Logout-System")
        If logout = vbYes Then
            modLogin.levelAdmin(False)
            Me.tssUser.Text = "tidak ada pengguna"

        Else
            Exit Sub
        End If
    End Sub
    Private Sub mnTambahUser_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTambahUser.Click
        FormUser.MdiParent = Me
        FormUser.Show()
    End Sub
    Private Sub mnBackupData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBackupData.Click
        FormDemo.MdiParent = Me
        FormDemo.Show()
    End Sub
    Private Sub mnRestoreData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnRestoreData.Click
        FormDemo.MdiParent = Me
        FormDemo.Show()
    End Sub
    Private Sub mnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnKeluar.Click
        Try
            Dim Keluar As Int16
            Keluar = MsgBox("Keluar Dari Aplikasi Basis Data Rekam Medis...!!!", MsgBoxStyle.OkCancel, "Aplikasi Rekam Medis")
            Select Case Keluar
                Case vbOK
                    Application.Exit()
                Case vbCancel
                    Exit Sub
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "MENU MASTER"
    '-- kejadian pada menu Master --
    Private Sub mnDataPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataPasien.Click
        FormPasien.MdiParent = Me
        FormPasien.Show()
    End Sub
    Private Sub mnDataDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataDokter.Click
        FormDokter.MdiParent = Me
        FormDokter.Show()
    End Sub
    Private Sub mnDataObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataObat.Click
        FormObat.MdiParent = Me
        FormObat.Show()
    End Sub
    Private Sub DataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataPegawai.Click
        FormPegawai.MdiParent = Me
        FormPegawai.Show()
    End Sub
    Private Sub mnStockObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStockObat.Click
        FormDemo.MdiParent = Me
        FormDemo.Show()
    End Sub
#End Region
#Region "MENU DIAGNOSA"
    '--- kejadian pada menu Diagnosa ---
    Private Sub mnPemeriksaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPemeriksan.Click
        FormDiagnosa.MdiParent = Me
        FormDiagnosa.Show()
    End Sub
    Private Sub mnDiagnosaPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDiagnosaPasien.Click
        FormDiagnosaPasien.MdiParent = Me
        FormDiagnosaPasien.Show()
    End Sub
#End Region
#Region "MENU LAPORAN"
    '--- kejadian pada menu Laporan ---
    Private Sub mnLapJenisKelamin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLapPasienJK.Click
        ' FormLaporanPasien.MdiParent = Me
        'FormLaporanPasien.Show()
    End Sub
    Private Sub mnLapHasilDiagnosa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLapHasilDiagnosa.Click
        'FormLaporanHasilDiagnosa.MdiParent = Me
        'FormLaporanHasilDiagnosa.Show()
    End Sub
    Private Sub mnLapRekapBiaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLapDiagnosaRekap.Click
        'FormRekapBiaya.MdiParent = Me
        'FormRekapBiaya.Show()
    End Sub
    Private Sub mnLapSpesialis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLapDokterSpesialis.Click
        ' LaporanDokterBySpesialis.MdiParent = Me
        'LaporanDokterBySpesialis.Show()
    End Sub
    Private Sub mnDaftarObatKemasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDaftarObatKemasan.Click
        'LaporanObatByKemasan.MdiParent = Me
        'LaporanObatByKemasan.Show()
    End Sub
#End Region
#Region "MENU TENTANG"
    '--- kejadian pada menu Tentang ---
    Private Sub mnTentangPembuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTentangPembuat.Click
        FormAbout.MdiParent = Me
        FormAbout.Show()
    End Sub
    Private Sub mnTentangProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTentangProgram.Click
        FormAboutProgram.MdiParent = Me
        FormAboutProgram.Show()
    End Sub
#End Region
#Region "BANTUAN PROGRAM"
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    '--- kejadian pada menu Bantuan --
    Private Sub mnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnHelp.Click
        System.Windows.Forms.Help.ShowHelp(Me, App_Path() & "help.chm", HelpNavigator.AssociateIndex)
    End Sub
#End Region
#Region "EVENT PADA TOOLBAR"
    '--- kejadian pada icon atau toolbar ---
    Private Sub tsbPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPasien.Click
        FormPasien.MdiParent = Me
        FormPasien.Show()
    End Sub
    Private Sub tsbDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDokter.Click
        FormDokter.MdiParent = Me
        FormDokter.Show()
    End Sub
    Private Sub tsbObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbObat.Click
        FormObat.MdiParent = Me
        FormObat.Show()
    End Sub
    Private Sub tsbResep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbResep.Click
        FormDiagnosa.MdiParent = Me
        FormDiagnosa.Show()
    End Sub
    Private Sub tsbHasilDiagnosa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbHasilDiagnosa.Click
        FormDiagnosaPasien.MdiParent = Me
        FormDiagnosaPasien.Show()
    End Sub
    Private Sub tsbKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbKeluar.Click
        Try
            Dim Keluar As Int16
            Keluar = MsgBox("Keluar Dari Aplikasi Basis Data Rekam Medis...!!!", MsgBoxStyle.OkCancel, "Aplikasi Rekam Medis")
            Select Case Keluar
                Case vbOK
                    Application.Exit()
                Case vbCancel
                    Exit Sub
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frMenuMedical_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Dim Keluar As Int16
            Keluar = MsgBox("Keluar Dari Aplikasi Basis Data Rekam Medis...!!!", MsgBoxStyle.OkCancel, "Aplikasi Rekam Medis")
            Select Case Keluar
                Case vbOK
                    Me.Dispose()
                    Application.Exit()
                Case vbCancel
                    e.Cancel = True
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class