Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Module modPasien
#Region "BAGIAN VARIABEL"
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
#Region "BAGIAN UMUM"
    '-- sub-program --
    Sub FormLoad()
        With FormPasien
            .WindowState = FormWindowState.Maximized
            .Text = "Master Data Pasien"
            .ControlBox = False
            .TabPage1.Text = ".:ENTRI DATA PASIEN:."
            .TabPage1.BackColor = Color.MediumSeaGreen
            .TabPage2.Text = ".:BROWSE DATA PASIEN:."
            .TabPage2.BackColor = Color.Honeydew
            .gbNavigasi.Text = "| Navigasi |"
            .gbNavigasi.BackColor = Color.RosyBrown '  Wheat 'SeaGreen
            .gbData.Text = "Search record |"
            .gbData.BackColor = Color.DarkSeaGreen
            .rbKode_Pasien.Checked = True
            .TabControl1.Top = (.Height - .TabControl1.Height) / 2
            .TabControl1.Left = (.Width - .TabControl1.Width) / 2
        End With
    End Sub
    Sub BersihkanLayar()
        With FormPasien
            .txtNama_Pasien.Clear()
            .cbKelamin.Text = ""
            .cbPekerjaan.Text = ""
            .txtUsia.Clear()
            .txtKtp.Clear()
            .txtAlamat.Clear()
            .txtKota.Clear()
            .txtTelepon.Clear()
            .txtEmail.Clear()
            .txtKode_Pasien.Focus()
        End With
    End Sub
    Sub Navigasi(ByVal tombol As Boolean)
        With FormPasien
            .btAdd.Enabled = tombol
            .btSave.Enabled = Not tombol
            .btCancel.Enabled = Not tombol
            '.btUpdate.Enabled = Not tombol
            .btEdit.Enabled = tombol
            .btDelete.Enabled = tombol
            .btExit.Enabled = tombol
        End With
    End Sub
    Sub TextboxEnable(ByVal aktif As Boolean)
        With FormPasien
            .txtNama_Pasien.Enabled = aktif
            .cbKelamin.Enabled = aktif
            .cbPekerjaan.Enabled = aktif
            .txtAlamat.Enabled = aktif
            .txtTelepon.Enabled = aktif
            .txtUsia.Enabled = aktif
            .txtKtp.Enabled = aktif
        End With
    End Sub
#End Region
#Region "BAGIAN AKSES TABEL"
    Sub BuatKodePasien()
        Dim koneksi As New aksesData.AksesMedical
        Dim dr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim kode1, kode2 As String
        Dim urut As String
        cmd = koneksi.Buka.CreateCommand
        cmd.CommandText = "select count(kode_pas) as jml from tpasien"
        dr = cmd.ExecuteReader
        With FormPasien
            Try
                If dr.Read() Then
                    If dr.Item("jml") > 0 Then
                        koneksi.Tutup()
                        cmd = koneksi.Buka.CreateCommand
                        cmd.CommandText = "select max(kode_pas) as kode from tpasien"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        kode1 = dr.Item("kode")
                        kode2 = Val(Microsoft.VisualBasic.Right(kode1, 3))
                        urut = Microsoft.VisualBasic.Right("000" & (Val(kode2 + 1)), 4)
                        .txtKode_Pasien.Text = "P-" & urut
                    Else
                        .txtKode_Pasien.Text = "P-0001"
                    End If
                    koneksi.Tutup()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub
    Sub SearchRecord()
        Dim Koneksi As New aksesData.AksesMedical
        With FormPasien
            If .txtCari.Text = "" Then
                MsgBox("Data Belum diinput", , "Searching record")
                .txtCari.Focus()
            End If
            Try
                If .rbKode_Pasien.Checked = True Then
                    'da = New MySqlDataAdapter("Select kode_pas As KodePasien,nama_pas as NamaPasien, kelamin as JenisKelamin,usia as Usia,pekerjaan as Pekerjaan,ktp as KTP,alamat as Alamat,kota as Kota,telpon as Telpon,email as E-mail from tpasien where kode_pas = '" & .txtCari.Text & "'", Koneksi.Buka)
                    da = New MySqlDataAdapter("Select * from tpasien where kode_pas = '" & .txtCari.Text & "'", Koneksi.Buka)
                Else
                    'da = New MySqlDataAdapter("Select kode_pas As KodePasien,nama_pas as NamaPasien, kelamin as JenisKelamin,usia as Usia,pekerjaan as Pekerjaan,ktp as KTP,alamat as Alamat,kota as Kota,telpon as Telpon,email as E-mail from tpasien where nama_pas like '" & .txtCari.Text & "%'", Koneksi.Buka)
                    da = New MySqlDataAdapter("Select * from tpasien where nama_pas LIKE = '" & .txtCari.Text & "'", Koneksi.Buka)
                End If
                Dim tbPasien As New DataTable
                tbPasien.Clear()
                da.Fill(tbPasien)
                If tbPasien.Rows.Count = Nothing Then
                    MsgBox("Data tidak ditemukan, isikan Input yang tepat...!", MsgBoxStyle.Information, "Perhatian")
                    .txtCari.Clear()
                    .txtCari.Focus()
                End If
                .DataGridViewPasien.DataSource = tbPasien
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            Koneksi.Tutup()
        End With
    End Sub
    Sub DataBinding()
        With FormPasien
            .BindingNavigator1.BindingSource = bndata      'bndata diambil dari subProg Refreshrecord
            .txtKode_Pasien.DataBindings.Clear()
            .txtKode_Pasien.DataBindings.Add("text", bndata, "kodePasien") 'nilai kodePasien diambil dari da Refreshrecord
            .txtNama_Pasien.DataBindings.Clear()
            .txtNama_Pasien.DataBindings.Add("text", bndata, "namaPasien")
            .cbKelamin.DataBindings.Clear()
            .cbKelamin.DataBindings.Add("text", bndata, "jenisKelamin")
            .txtUsia.DataBindings.Clear()
            .txtUsia.DataBindings.Add("text", bndata, "usia")
            .cbPekerjaan.DataBindings.Clear()
            .cbPekerjaan.DataBindings.Add("text", bndata, "pekerjaan")
            .txtKtp.DataBindings.Clear()
            .txtKtp.DataBindings.Add("text", bndata, "ktp")
            .txtAlamat.DataBindings.Clear()
            .txtAlamat.DataBindings.Add("text", bndata, "alamat")
            .txtKota.DataBindings.Clear()
            .txtKota.DataBindings.Add("text", bndata, "kota")
            .txtTelepon.DataBindings.Clear()
            .txtTelepon.DataBindings.Add("text", bndata, "telpon")
            .txtEmail.DataBindings.Clear()
            .txtEmail.DataBindings.Add("text", bndata, "email")
        End With
    End Sub
    Sub RefreshRecord()
        Dim koneksi As New aksesData.AksesMedical
        With FormPasien
            Try
                da = New MySqlDataAdapter("Select kode_pas As KodePasien,nama_pas as NamaPasien, kelamin as JenisKelamin,usia as Usia,pekerjaan as Pekerjaan,ktp as KTP,alamat as Alamat,kota as kota,telpon as Telpon,email as Email from tpasien", koneksi.Buka)
                Dim tbpasien As New DataTable
                tbpasien.Clear()
                da.Fill(tbpasien)
                .DataGridViewPasien.DataSource = tbpasien
                bndata.DataSource = tbpasien
                .txtCari.Clear()
                .txtCari.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            koneksi.Tutup()
        End With
    End Sub
#End Region
#Region "BAGIAN STORED PROCEDURE"
    Public Function insertPasien(ByVal vkode_pas As String, ByVal vnama_pas As String, ByVal vkelamin As String, ByVal vusia As String, ByVal vpekerjaan As String, ByVal vktp As String, ByVal valamat As String, ByVal vkota As String, ByVal vtelpon As String, ByVal vemail As String)
        Try
            Dim tambah As String = "PasienTAMBAH"
            Dim conn As New aksesData.AksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(tambah, conn.Buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kode_pas"
            kode.Value = vkode_pas
            cmd.Parameters.Add(kode)
            Dim nama As New MySqlParameter
            nama.ParameterName = "@nama_pas"
            nama.Value = vnama_pas
            cmd.Parameters.Add(nama)
            Dim kelamin As New MySqlParameter
            kelamin.ParameterName = "@kelamin"
            kelamin.Value = vkelamin
            cmd.Parameters.Add(kelamin)
            Dim usia As New MySqlParameter
            usia.ParameterName = "@usia"
            usia.Value = vusia
            cmd.Parameters.Add(usia)
            Dim pekerjaan As New MySqlParameter
            pekerjaan.ParameterName = "@pekerjaan"
            pekerjaan.Value = vpekerjaan
            cmd.Parameters.Add(pekerjaan)
            Dim ktp As New MySqlParameter
            ktp.ParameterName = "@ktp"
            ktp.Value = vktp
            cmd.Parameters.Add(ktp)
            Dim alamat As New MySqlParameter
            alamat.ParameterName = "@alamat"
            alamat.Value = valamat
            cmd.Parameters.Add(alamat)
            Dim kota As New MySqlParameter
            kota.ParameterName = "@kota"
            kota.Value = vkota
            cmd.Parameters.Add(kota)
            Dim telpon As New MySqlParameter
            telpon.ParameterName = "@telpon"
            telpon.Value = vtelpon
            cmd.Parameters.Add(telpon)
            Dim email As New MySqlParameter
            email.ParameterName = "@email"
            email.Value = vemail
            cmd.Parameters.Add(email)
            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try
    End Function
    Public Function updatePasien(ByVal vkode_pas As String, ByVal vnama_pas As String, ByVal vkelamin As String, ByVal vusia As String, ByVal vpekerjaan As String, ByVal vktp As String, ByVal valamat As String, ByVal vkota As String, ByVal vTelpon As String, ByVal vEmail As String)
        Try
            Dim ubah As String = "PasienUBAH"
            Dim conn As New aksesData.AksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(ubah, conn.Buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kodepas"
            kode.Value = vkode_pas
            cmd.Parameters.Add(kode)
            Dim nama As New MySqlParameter
            nama.ParameterName = "@nama_pas"
            nama.Value = vnama_pas
            cmd.Parameters.Add(nama)
            Dim kelamin As New MySqlParameter
            kelamin.ParameterName = "@kelamin"
            kelamin.Value = vkelamin
            cmd.Parameters.Add(kelamin)
            Dim usia As New MySqlParameter
            usia.ParameterName = "@usia"
            usia.Value = vusia
            cmd.Parameters.Add(usia)
            Dim pekerjaan As New MySqlParameter
            pekerjaan.ParameterName = "@pekerjaan"
            pekerjaan.Value = vpekerjaan
            cmd.Parameters.Add(pekerjaan)
            Dim ktp As New MySqlParameter
            ktp.ParameterName = "@ktp"
            ktp.Value = vktp
            cmd.Parameters.Add(ktp)
            Dim alamat As New MySqlParameter
            alamat.ParameterName = "@alamat"
            alamat.Value = valamat
            cmd.Parameters.Add(alamat)
            Dim kota As New MySqlParameter
            kota.ParameterName = "@kota"
            kota.Value = vkota
            cmd.Parameters.Add(kota)
            Dim telpon As New MySqlParameter
            telpon.ParameterName = "@telpon"
            telpon.Value = vTelpon
            cmd.Parameters.Add(telpon)
            Dim email As New MySqlParameter
            email.ParameterName = "@email"
            email.Value = vEmail
            cmd.Parameters.Add(email)
            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try

    End Function
    Public Function deletePasien(ByVal vkode_pas As String)
        Try
            Dim hapus As String = "PasienHAPUS"
            Dim conn As New aksesData.AksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(hapus, conn.Buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kodepas"
            kode.Value = vkode_pas
            cmd.Parameters.Add(kode)
            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try

    End Function
#End Region
End Module
