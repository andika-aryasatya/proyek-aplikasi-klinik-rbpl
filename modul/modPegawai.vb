Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Module modPegawai
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.AksesMedical
    Dim mProses As String
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim bndata As New BindingSource
#End Region
#Region "UMUM"
    Sub FormLoad()
        With FormPegawai
            .Text = "Master Data Pegawai"
            .rbnip.Checked = True
            .WindowState = FormWindowState.Maximized
            .ControlBox = False
            .PanelLuar.Top = (.Height - .PanelLuar.Height) / 2
            .PanelLuar.Left = (.Width - .PanelLuar.Width) / 2
            .GroupBox1.Text = "| Cari Data |"
        End With
    End Sub
    Sub FormLayarBersih()
        With FormPegawai
            '.txtKode_dok.Clear()
            .txtNama_peg.Clear()
            .cbAgama.Text = "--pilih--"
            .cbKelamin.Text = "--pilih--"
            .txtAlamat.Clear()
            .txtKota.Clear()
            .txtTelepon.Clear()
            .txtJabatan.Clear()
            '.cbPekerjaan.Text = "--pilih--"
            .txtKtp.Clear()
            .txtUsia.Clear()
            .txtEmail.Clear()
            .txtCari.Text = ""
            .txtCari.Focus()
        End With
    End Sub
    Sub FormNavigasi(ByVal tombol As Boolean)
        With FormPegawai
            .btAdd.Enabled = tombol
            .btCancel.Enabled = Not tombol
            .btSave.Enabled = Not tombol
            .btDelete.Enabled = tombol
            .btEdit.Enabled = tombol
            '--- diganti dengan binding data/navigator --
            '.BtFirst.Enabled = tombol
            '.BtLast.Enabled = tombol
            '.btPrev.Enabled = tombol
            '.BtNext.Enabled = tombol
            '.btCari.Enabled = tombol
            '.btRefresh.Enabled = tombol
        End With
    End Sub
    Sub FormEnabledTextBox(ByVal aktif As Boolean)
        With FormPegawai
            .txtNip.Enabled = Not aktif
            .txtNama_peg.Enabled = Not aktif
            .cbAgama.Enabled = Not aktif
            .cbKelamin.Enabled = Not aktif
            .txtAlamat.Enabled = Not aktif
            .txtKota.Enabled = Not aktif
            .txtTelepon.Enabled = Not aktif
            .txtJabatan.Enabled = Not aktif
            '.cbPekerjaan.Enabled = Not aktif
            .txtKtp.Enabled = Not aktif
            .txtUsia.Enabled = Not aktif
            .txtEmail.Enabled = Not aktif
        End With
    End Sub
#End Region
#Region "AksesTABEL"
    Friend Sub BuatKodePegawai()
        Dim koneksi As New aksesData.aksesMedical
        Dim dr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim kode1, kode2 As String
        Dim urut As String
        cmd = koneksi.buka.CreateCommand
        cmd.CommandText = "select count(nip) as jml from tpegawai"
        dr = cmd.ExecuteReader
        With FormPegawai
            Try
                If dr.Read() Then
                    If dr.Item("jml") > 0 Then
                        koneksi.tutup()
                        cmd = koneksi.buka.CreateCommand
                        cmd.CommandText = "select max(nip) as kode from tpegawai"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        kode1 = dr.Item("kode")
                        kode2 = Val(Microsoft.VisualBasic.Right(kode1, 3))
                        urut = Microsoft.VisualBasic.Right("000" & (Val(kode2 + 1)), 3)
                        .txtNip.Text = "P0" & urut
                    Else
                        .txtNip.Text = "P0001"
                    End If
                    koneksi.tutup()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub
    '-- untuk pencarian & menampilkan data pada Form & Grid --
    Friend Sub DaftarPegawai()
        With FormPegawai
            cmd = koneksi.buka.CreateCommand
            cmd.CommandText = "Select * from tpegawai"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                .txtNip.Text = dr.Item("nip")
                .txtNama_peg.Text = dr.Item("nama").ToString
                .cbKelamin.Text = dr.Item("kelamin").ToString
                .cbAgama.Text = dr.Item("agama").ToString
                .txtUsia.Text = dr.Item("usia").ToString
                '.cbPekerjaan.Text = dr.Item("pekerjaan").ToString
                .txtKtp.Text = dr.Item("ktp").ToString
                .txtJabatan.Text = dr.Item("jabatan").ToString
                .txtAlamat.Text = dr.Item("alamat").ToString
                .txtKota.Text = dr.Item("kota").ToString
                .txtTelepon.Text = dr.Item("telepon").ToString
                .txtEmail.Text = dr.Item("email").ToString
                koneksi.tutup()
            End If
        End With
    End Sub
    Friend Sub RefreshRecord()
        Dim koneksi As New aksesData.aksesMedical
        With FormPegawai
            Try
                da = New MySqlDataAdapter("Select nip As NIP,nama as NamaPegawai, kelamin as JenisKelamin,agama as Agama,usia as Usia,ktp as KTP,jabatan as Jabatan,alamat as Alamat,kota as Kota,telepon as Telepon,email as Email from tpegawai", koneksi.Buka)
                Dim tbpegawai As New DataTable
                tbpegawai.Clear()
                da.Fill(tbpegawai)
                .DataGridPegawai.DataSource = tbpegawai
                bndata.DataSource = tbpegawai
                .txtCari.Clear()
                .txtCari.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            koneksi.tutup()
        End With
    End Sub
    Friend Sub DataBinding()
        With FormPegawai
            .BindingNavigator1.BindingSource = bndata     'bddata untuk membinding/mengaitkan ke obyek
            .txtNip.DataBindings.Clear()                  'BindingNavigator
            .txtNip.DataBindings.Add("text", bndata, "NIP")
            .txtNama_peg.DataBindings.Clear()
            .txtNama_peg.DataBindings.Add("text", bndata, "NamaPegawai")
            .cbKelamin.DataBindings.Clear()
            .cbKelamin.DataBindings.Add("text", bndata, "JenisKelamin")
            .cbAgama.DataBindings.Clear()
            .cbAgama.DataBindings.Add("text", bndata, "Agama")
            .txtUsia.DataBindings.Clear()
            .txtUsia.DataBindings.Add("text", bndata, "Usia")
            ' .cbPekerjaan.DataBindings.Clear()
            '.cbPekerjaan.DataBindings.Add("text", bndata, "Pekerjaan")
            .txtKtp.DataBindings.Clear()
            .txtKota.DataBindings.Add("text", bndata, "Ktp")
            .txtAlamat.DataBindings.Clear()
            .txtAlamat.DataBindings.Add("text", bndata, "Alamat")
            .txtKota.DataBindings.Clear()
            .txtKota.DataBindings.Add("text", bndata, "Kota")
            .txtTelepon.DataBindings.Clear()
            .txtTelepon.DataBindings.Add("text", bndata, "Telepon")
            .txtEmail.DataBindings.Clear()
            .txtEmail.DataBindings.Add("text", bndata, "Email")
        End With
    End Sub
    Friend Function SearchRecord(ByVal vSearch As String)
        Dim Koneksi As New aksesData.aksesMedical
        With FormPegawai
            If .txtCari.Text = "" Then
                MsgBox("Data Belum diinput", , "Searching record")
                .txtCari.Focus()
            End If
            Try
                If .rbnip.Checked = True Then
                    da = New MySqlDataAdapter("select * from tpegawai where nip = '" & vSearch & "'", Koneksi.buka)
                Else
                    da = New MySqlDataAdapter("select * from tpegawai where nama like '" & vSearch & "%'", Koneksi.buka)
                End If
                Dim tbpegawai As New DataTable
                tbpegawai.Clear()
                da.Fill(tbpegawai)
                If tbpegawai.Rows.Count = Nothing Then
                    MsgBox("Data tidak ditemukan, isikan Input yang tepat...!", MsgBoxStyle.Information, "Perhatian")
                    .txtCari.Clear()
                    .txtCari.Focus()
                End If
                .DataGridPegawai.DataSource = tbpegawai
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            Koneksi.tutup()
        End With
        Return 0
    End Function
#End Region
End Module
