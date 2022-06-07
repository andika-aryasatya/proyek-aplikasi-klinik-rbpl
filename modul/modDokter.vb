Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Module modDokter
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
        With FormDokter
            .WindowState = FormWindowState.Maximized
            .Text = "Master Data Dokter"
            .ControlBox = False
            .rbKode_dokter.Checked = True
            .PanelLuar.Top = (.Height - .PanelLuar.Height) / 2
            .PanelLuar.Left = (.Width - .PanelLuar.Width) / 2
            .GroupBox1.Text = "|Cari Data|"
        End With
    End Sub
    Sub LayarBersih()
        With FormDokter
            .txtNama_dok.Clear()
            .cbSpesialis.Text = "--pilih--"
            .cbKelamin.Text = "--pilih--"
            .txtAlamat.Clear()
            .txtKota.Clear()
            .txtTelepon.Clear()
            .txtEmail.Clear()
            .txtCari.Text = ""
            .txtCari.Focus()
        End With
    End Sub
    Sub Navigasi(ByVal tombol As Boolean)
        With FormDokter
            .btAdd.Enabled = tombol
            .btCancel.Enabled = Not tombol
            .btSave.Enabled = Not tombol
            .btDelete.Enabled = tombol
            .btEdit.Enabled = tombol
        End With
    End Sub
    Sub EnabledTextBox(ByVal aktif As Boolean)
        With FormDokter
            .txtNama_dok.Enabled = Not aktif
            .cbKelamin.Enabled = Not aktif
            .cbSpesialis.Enabled = Not aktif
            .txtAlamat.Enabled = Not aktif
            .txtKota.Enabled = Not aktif
            .txtTelepon.Enabled = Not aktif
            .txtEmail.Enabled = Not aktif
        End With
    End Sub
#End Region
#Region "AksesTABEL"
    Sub BuatKodeDokter()
        Dim koneksi As New aksesData.aksesMedical
        Dim dr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim kode1, kode2 As String
        Dim urut As String
        cmd = koneksi.buka.CreateCommand
        cmd.CommandText = "select count(kode_dok) as jml from tdokter"
        dr = cmd.ExecuteReader
        With FormDokter
            Try
                If dr.Read() Then
                    If dr.Item("jml") > 0 Then
                        koneksi.tutup()
                        cmd = koneksi.buka.CreateCommand
                        cmd.CommandText = "select max(kode_dok) as kode from tdokter"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        kode1 = dr.Item("kode")
                        kode2 = Val(Microsoft.VisualBasic.Right(kode1, 3))
                        urut = Microsoft.VisualBasic.Right("000" & (Val(kode2 + 1)), 3)
                        .txtKode_dok.Text = "D-" & urut
                    Else
                        .txtKode_dok.Text = "D-0001"
                    End If
                    koneksi.tutup()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub
    Sub databinding()
        With FormDokter
            .BindingNavigator1.BindingSource = bndata
            .txtKode_dok.DataBindings.Clear()
            .txtKode_dok.DataBindings.Add("text", bndata, "kodedokter")
            .txtNama_dok.DataBindings.Clear()
            .txtNama_dok.DataBindings.Add("text", bndata, "NamaDokter")
            .cbKelamin.DataBindings.Clear()
            .cbKelamin.DataBindings.Add("text", bndata, "Jeniskelamin")
            .cbSpesialis.DataBindings.Clear()
            .cbSpesialis.DataBindings.Add("text", bndata, "spesialis")
            .txtAlamat.DataBindings.Clear()
            .txtAlamat.DataBindings.Add("text", bndata, "alamat")
            .txtKota.DataBindings.Clear()
            .txtKota.DataBindings.Add("text", bndata, "kota")
            .txtTelepon.DataBindings.Clear()
            .txtTelepon.DataBindings.Add("text", bndata, "telepon")
            .txtEmail.DataBindings.Clear()
            .txtEmail.DataBindings.Add("text", bndata, "email")
        End With
    End Sub
    Public Sub RefreshRecord()
        Dim koneksi As New aksesData.aksesMedical
        With FormDokter
            Try
                da = New MySqlDataAdapter("Select kode_dok As KodeDokter,nama_dok as NamaDokter, kelamin as JenisKelamin,spesialis as Spesialis,alamat as Alamat,kota as Kota,telpon as Telepon,email as Email from tdokter", koneksi.buka)
                Dim tbdokter As New DataTable
                tbdokter.Clear()
                da.Fill(tbdokter)
                .DataGridDokter.DataSource = tbdokter
                bndata.DataSource = tbdokter
                .listrecord()
                .txtCari.Clear()
                .txtCari.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            koneksi.tutup()
        End With
    End Sub
    Public Function SearchRecord(ByVal vSearch As String)
        Dim Koneksi As New aksesData.aksesMedical
        With FormDokter
            If .txtCari.Text = "" Then
                MsgBox("Data Belum diinput", , "Searching record")
                .txtCari.Focus()
            End If
            Try
                If .rbKode_dokter.Checked = True Then
                    da = New MySqlDataAdapter("select kode_dok as KodeDokter,nama_dok as NamaDokter,kelamin as JenisKelamin,spesialis as Spesialis,alamat as Alamat,kota as Kota,telpon as Telepon,email as Email from tdokter where kode_dok = '" & vSearch & "'", Koneksi.buka)
                Else
                    da = New MySqlDataAdapter("select kode_dok as KodeDokter,nama_dok as NamaDokter,kelamin as JenisKelamin,spesialis as Spesialis,alamat as Alamat,kota as Kota,telpon as Telepon,email as Email from tdokter where nama_dok like '" & vSearch & "%'", Koneksi.buka)
                End If
                Dim tbdokter As New DataTable
                tbdokter.Clear()
                da.Fill(tbdokter)
                If tbdokter.Rows.Count = Nothing Then
                    MsgBox("Data tidak ditemukan, isikan Input yang tepat...!", MsgBoxStyle.Information, "Perhatian")
                    .txtCari.Clear()
                    .txtCari.Focus()
                End If
                .DataGridDokter.DataSource = tbdokter
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            Koneksi.tutup()
        End With
        Return 0
    End Function
#End Region
#Region "Pemanggilan StoredProcedure"
    Public Function insertDokter(ByVal vKode_dok As String, ByVal vNama_dok As String, ByVal vKelamin As String, ByVal vSpesialis As String, ByVal vAlamat As String, ByVal vKota As String, ByVal vTelpon As String, ByVal vEmail As String)
        Try
            Dim tambah As String = "DokterTAMBAH"
            Dim conn As New aksesData.aksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(tambah, conn.buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kode_dok"
            kode.Value = vKode_dok
            cmd.Parameters.Add(kode)
            Dim nama As New MySqlParameter
            nama.ParameterName = "@nama_dok"
            nama.Value = vNama_dok
            cmd.Parameters.Add(nama)
            Dim kelamin As New MySqlParameter
            kelamin.ParameterName = "@kelamin"
            kelamin.Value = vKelamin
            cmd.Parameters.Add(kelamin)
            Dim spesialis As New MySqlParameter
            spesialis.ParameterName = "@spesialis"
            spesialis.Value = vSpesialis
            cmd.Parameters.Add(spesialis)
            Dim alamat As New MySqlParameter
            alamat.ParameterName = "@alamat"
            alamat.Value = vAlamat
            cmd.Parameters.Add(alamat)
            Dim kota As New MySqlParameter
            kota.ParameterName = "@kota"
            kota.Value = vKota
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
        koneksi.Tutup()

    End Function
    Public Function updateDokter(ByVal vkode_dok As String, ByVal vnama_dok As String, ByVal vkelamin As String, ByVal vspesialis As String, ByVal valamat As String, ByVal vkota As String, ByVal vtelpon As String, ByVal vemail As String)
        Try
            Dim ubah As String = "DokterUBAH"
            Dim conn As New aksesData.aksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(ubah, conn.buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kodedok"
            kode.Value = vkode_dok
            cmd.Parameters.Add(kode)
            Dim nama As New MySqlParameter
            nama.ParameterName = "@nama_dok"
            nama.Value = vnama_dok
            cmd.Parameters.Add(nama)
            Dim kelamin As New MySqlParameter
            kelamin.ParameterName = "@kelamin"
            kelamin.Value = vkelamin
            cmd.Parameters.Add(kelamin)
            Dim spesialis As New MySqlParameter
            spesialis.ParameterName = "@spesialis"
            spesialis.Value = vspesialis
            cmd.Parameters.Add(spesialis)
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
    Public Function hapusDokter(ByVal id As String) As MySqlDataReader
        Try
            Dim hapus As String = "DokterHAPUS"
            Dim conn As New aksesData.aksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(hapus, conn.buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim iddokter As New MySqlParameter
            iddokter.ParameterName = "@kodedok"
            iddokter.Value = id
            cmd.Parameters.Add(iddokter)

            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try
        koneksi.Tutup()
    End Function
    '*** cara kedua mendifinisikan STORED PROCEDURE ***
    Friend Sub InsertDataDOKTER(ByVal Simpan As String)
        With FormDokter
            Dim KodeDok As String = .txtKode_dok.Text
            Dim NamaDok As String = .txtNama_dok.Text
            Dim Kelamin As String = .cbKelamin.Text
            Dim Spesialis As String = .cbSpesialis.Text
            Dim Alamat As String = .txtAlamat.Text
            Dim Kota As String = .txtKota.Text
            Dim Telepon As String = .txtTelepon.Text
            Dim Email As String = .txtEmail.Text
            Try
                cmd = New MySqlCommand(Simpan)
                With cmd
                    .Connection = koneksi.buka
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = Simpan
                    With cmd
                        .Parameters.AddWithValue("Kode_Dok", KodeDok)
                        .Parameters.AddWithValue("Nama_Dok", NamaDok)
                        .Parameters.AddWithValue("Kelamin", Kelamin)
                        .Parameters.AddWithValue("Spesialis", Spesialis)
                        .Parameters.AddWithValue("alamat", Alamat)
                        .Parameters.AddWithValue("kota", Kota)
                        .Parameters.AddWithValue("telpon", Telepon)
                        .Parameters.AddWithValue("email", Email)
                    End With
                    .ExecuteNonQuery()
                    MsgBox("Record berhasil di SIMPAN")
                    koneksi.tutup()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            koneksi.Tutup()

        End With
    End Sub
    Friend Sub UpdateDataDOKTER(ByVal Ubah As String)
        With FormDokter
            Dim KodeDok As String = .txtKode_dok.Text
            Dim NamaDok As String = .txtNama_dok.Text
            Dim Kelamin As String = .cbKelamin.Text
            Dim Spesialis As String = .cbSpesialis.Text
            Dim Alamat As String = .txtAlamat.Text
            Dim Kota As String = .txtKota.Text
            Dim Telepon As String = .txtTelepon.Text
            Dim Email As String = .txtEmail.Text
            Try
                cmd = New MySqlCommand(Ubah)
                With cmd
                    .Connection = koneksi.buka
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = Ubah
                    With cmd
                        .Parameters.AddWithValue("KodeDok", KodeDok)
                        .Parameters.AddWithValue("Nama_Dok", NamaDok)
                        .Parameters.AddWithValue("Kelamin", Kelamin)
                        .Parameters.AddWithValue("Spesialis", Spesialis)
                        .Parameters.AddWithValue("alamat", Alamat)
                        .Parameters.AddWithValue("kota", Kota)
                        .Parameters.AddWithValue("telpon", Telepon)
                        .Parameters.AddWithValue("email", Email)
                    End With
                    .ExecuteNonQuery()
                    MsgBox("Record berhasil di UBAH")
                    koneksi.tutup()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            koneksi.Tutup()

        End With
    End Sub
    Friend Sub DeleteDataDOKTER(ByVal Hapus As String)
        With FormDokter
            Dim KodeDok As String = .txtKode_dok.Text
            Try
                cmd = New MySqlCommand(Hapus)
                With cmd
                    .Connection = koneksi.buka
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = Hapus
                    With cmd
                        .Parameters.AddWithValue("KodeDok", KodeDok)
                    End With
                    .ExecuteNonQuery()
                    MsgBox("Record berhasil di HAPUS...!")
                    koneksi.tutup()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            koneksi.Tutup()
        End With
    End Sub
#End Region
End Module
