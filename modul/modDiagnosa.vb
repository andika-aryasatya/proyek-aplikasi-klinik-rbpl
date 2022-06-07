Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Module modDiagnosa
    Dim koneksi As New aksesData.AksesMedical
    Dim mProses As String
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
#Region "UMUM"
    Sub FormLoad()
        With FormDiagnosa
            .Text = "Entri Data Pemeriksaan Pasien Oleh Dokter"
            .WindowState = FormWindowState.Maximized
            .ControlBox = False
            .PanelLuar.Top = (.Height - .PanelLuar.Height) / 2
            .PanelLuar.Left = (.Width - .PanelLuar.Width) / 2
            .btAdd.Focus()
            .txtNoRM.Enabled = False
            .txtNama_pas.Enabled = False
            .txtNama_dok.Enabled = False
        End With
    End Sub
#End Region
#Region "AksesTABEL"
    Friend Sub GETCodeRM()
        Dim koneksi As New aksesData.aksesMedical
        Dim dr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim kode1, kode2 As String
        Dim urut As String
        cmd = koneksi.buka.CreateCommand
        cmd.CommandText = "select count(nomor_rm) as jml from tperiksa"
        dr = cmd.ExecuteReader
        With FormDiagnosa
            Try
                If dr.Read() Then
                    If dr.Item("jml") > 0 Then
                        koneksi.tutup()
                        cmd = koneksi.buka.CreateCommand
                        cmd.CommandText = "select max(nomor_rm) as kode from tperiksa"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        kode1 = dr.Item("kode")
                        kode2 = Val(Microsoft.VisualBasic.Right(kode1, 7))
                        urut = Microsoft.VisualBasic.Right("000000" & (Val(kode2 + 1)), 7)
                        .txtNoRM.Text = "RM-" & urut
                    Else
                        .txtNoRM.Text = "RM-0000001"
                    End If
                    koneksi.tutup()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub
    Sub SaveRecord()
        With FormDiagnosa
            If .txtCounter.Text = "0" Then
                MsgBox("Record pada Listview belum ada" & vbCrLf & "Silakan diisi dahulu", MsgBoxStyle.Information, ".:Perhatian:.")
                Exit Sub
            End If
            If .txtDiBayar.Text = "" Then
                MsgBox("Pembayaran masih Kosong...!" & vbCrLf & "Silakan diisi dahulu!", MsgBoxStyle.Information, ".:Perhatian:.")
                .txtDiBayar.Focus()
                Exit Sub
            End If
            Dim tanya As Int16
            tanya = MsgBox("Apakah sudah mengecek semuanya", MsgBoxStyle.OkCancel, ".:Perhatian:.")
            If tanya = vbCancel Then
                .btAdd.PerformClick()
                Exit Sub
            End If
            Try
                If (.txtNama_dok.Text = Nothing) Then
                    MsgBox("Record Nama Dokter harus diisi", MsgBoxStyle.Information, ".:Perhatian:.")
                    .txtNama_dok.Focus()
                    Exit Sub
                Else
                    Dim sql As String
                    sql = "Insert into tperiksa values('"
                    sql += .txtNoRM.Text & "','" & .dtpPeriksa.Value & "','"
                    sql += .txtKode_dok.Text & "','" & .txtKode_pas.Text & "','" & .txtDiagnosa.Text & "','"
                    sql += Val(.txtBiaya_obat.Text) & "','" & .txtKeterangan.Text & "')"

                    cmd = New MySqlCommand(sql)
                    cmd.Connection = koneksi.buka
                    cmd.ExecuteNonQuery()
                    koneksi.tutup()
                    MsgBox("Record pada tabel Diagnosa dengan Nomor " & .txtNoRM.Text & " dan Nama " & .txtNama_pas.Text & " berhasil di Simpan.", MsgBoxStyle.Information, ".:Saved record:.")
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Information, ".:Saved record:.")
                koneksi.tutup()
            End Try
        End With
    End Sub
    Sub RefreshRecord()
        With FormDiagnosa
            Try
                da = New MySqlDataAdapter("select * from tperiksa", koneksi.buka)
                Dim tbPeriksa As New DataTable
                tbPeriksa.Clear()
                da.Fill(tbPeriksa)
                koneksi.tutup()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, ".:.:Perhatian:.:.")
                koneksi.tutup()
            End Try
        End With
    End Sub
#End Region
End Module
