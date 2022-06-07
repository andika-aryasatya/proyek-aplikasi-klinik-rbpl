Imports MySql.Data.MySqlClient
Module modLogin
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.aksesMedical
#End Region
#Region "UMUM"
    Sub FormLoad()
        With FormLogin
            .WindowState = FormWindowState.Maximized
            .ControlBox = False
            .PanelLuar.Top = (.Height - .PanelLuar.Height) / 2
            .PanelLuar.Left = (.Width - .PanelLuar.Width) / 2
            .PanelLuar.BackColor = Color.PaleGreen
            .txtNamaUser.Focus()
        End With
    End Sub
    Sub FormNavigasi(ByVal tombol As Boolean)
        With FormLogin
            .btLogin.Enabled = tombol
            .btCancel.Enabled = tombol
            .txtPassword.Enabled = tombol
        End With
    End Sub
    Sub levAdministrator(ByVal admin As Boolean)
        With frMenuMedical
            .mnMaster.Enabled = admin
            .mnLaporan.Enabled = admin
            .mnSistem.Enabled = Not admin
            .mnDiagnosa.Enabled = Not admin
        End With
    End Sub
    Public Sub levelAdmin(ByVal aktif As Boolean)
        With frMenuMedical
            .mnMaster.Enabled = aktif
            .mnDiagnosa.Enabled = aktif
            .mnLaporan.Enabled = aktif
            .mnTentang.Enabled = aktif
            .mnLogin.Enabled = Not aktif
            .mnLogOut.Enabled = aktif
            .mnBackupData.Enabled = aktif
            .mnRestoreData.Enabled = aktif
            .mnTambahUser.Enabled = aktif
            .tsbPasien.Enabled = aktif
            .tsbDokter.Enabled = aktif
            .tsbObat.Enabled = aktif
            .tsbResep.Enabled = aktif
            .tsbHasilDiagnosa.Enabled = aktif
        End With
    End Sub
    Public Sub levelMaster(ByVal aktif As Boolean)
        With frMenuMedical
            .mnMaster.Enabled = aktif
            .mnLaporan.Enabled = aktif
            .mnTentang.Enabled = aktif
            .mnLogOut.Enabled = aktif
            .tsbPasien.Enabled = aktif
            .tsbDokter.Enabled = aktif
            .tsbObat.Enabled = aktif
            .mnDiagnosa.Enabled = Not aktif
            .mnLogin.Enabled = Not aktif
            .mnBackupData.Enabled = Not aktif
            .mnRestoreData.Enabled = Not aktif
            .mnTambahUser.Enabled = Not aktif
            .tsbResep.Enabled = Not aktif
            .tsbHasilDiagnosa.Enabled = Not aktif
        End With
    End Sub
    Public Sub levelTransaksi(ByVal aktif As Boolean)
        With frMenuMedical
            .mnMaster.Enabled = Not aktif
            .mnLaporan.Enabled = Not aktif
            .mnTentang.Enabled = aktif
            .mnLogOut.Enabled = aktif
            .tsbPasien.Enabled = aktif
            .tsbDokter.Enabled = aktif
            .tsbObat.Enabled = aktif
            .mnDiagnosa.Enabled = aktif
            .mnLogin.Enabled = Not aktif
            .mnBackupData.Enabled = Not aktif
            .mnRestoreData.Enabled = Not aktif
            .mnTambahUser.Enabled = Not aktif
            .tsbResep.Enabled = Not aktif
            .tsbHasilDiagnosa.Enabled = Not aktif
        End With
    End Sub
    Sub IsiCombo(ByVal sql As String, ByVal cbIsi As ComboBox)
        cbIsi.Items.Clear()
        Dim cmd As New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = koneksi.buka
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Do While dr.Read
                cbIsi.Items.Add(dr.Item(0))
            Loop
        End If
        dr.Close()
        cmd.Dispose()
        koneksi.tutup()
    End Sub
#End Region
End Module
