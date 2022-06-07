Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Module modObat
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
        With FormObat
            .Text = "Master Data Obat"
            .rbKode_obat.Checked = True
            .WindowState = FormWindowState.Maximized
            .ControlBox = False
            .PanelLuar.Top = (.Height - .PanelLuar.Height) / 2
            .PanelLuar.Left = (.Width - .PanelLuar.Width) / 2
            .GroupBox1.Text = "|Cari Data|"
        End With
    End Sub
    Sub LayarBersih()
        With FormObat
            '.txtKode_dok.Clear()
            .txtNama_Obat.Clear()
            .cbJenis.Text = "--pilih--"
            .cbKemasan.Text = "--pilih--"
            .txtHarga.Clear()
            .txtJumlah.Clear()
            .txtJumlah_harga.Clear()
            .txtCari.Text = ""
            .txtCari.Focus()
        End With
    End Sub
    Sub Navigasi(ByVal tombol As Boolean)
        With FormObat
            .btAdd.Enabled = tombol
            .btCancel.Enabled = Not tombol
            .btSave.Enabled = Not tombol
            .btDelete.Enabled = tombol
            .btUpdate.Enabled = tombol
            '.BtFirst.Enabled = tombol
            '.BtLast.Enabled = tombol
            '.btPrev.Enabled = tombol
            '.BtNext.Enabled = tombol
            '.btCari.Enabled = tombol
            '.btRefresh.Enabled = tombol
        End With
    End Sub
    Sub EnabledTextBox(ByVal aktif As Boolean)
        With FormObat
            .txtNama_Obat.Enabled = Not aktif
            .cbJenis.Enabled = Not aktif
            .cbKemasan.Enabled = Not aktif
            .txtHarga.Enabled = Not aktif
            .txtJumlah.Enabled = Not aktif
            '.txtJumlah_harga.Enabled = Not aktif
        End With
    End Sub
#End Region
#Region "AksesTABEL"
    Sub BuatKodeObat()
        Dim koneksi As New aksesData.aksesMedical
        Dim dr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim kode1, kode2 As String
        Dim urut As String
        cmd = koneksi.buka.CreateCommand
        cmd.CommandText = "select count(kode_obat) as jml from tobat"
        dr = cmd.ExecuteReader
        With FormObat
            Try
                If dr.Read() Then
                    If dr.Item("jml") > 0 Then
                        koneksi.tutup()
                        cmd = koneksi.buka.CreateCommand
                        cmd.CommandText = "select max(kode_obat) as kode from tobat"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        kode1 = dr.Item("kode")
                        kode2 = Val(Microsoft.VisualBasic.Right(kode1, 3))
                        urut = Microsoft.VisualBasic.Right("000" & (Val(kode2 + 1)), 4)
                        .txtKode_Obat.Text = "O-" & urut
                    Else
                        .txtKode_Obat.Text = "O-0001"
                    End If
                    koneksi.tutup()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub
    Sub databinding()
        With FormObat
            .BindingNavigator1.BindingSource = bndata
            .txtKode_Obat.DataBindings.Clear()
            .txtKode_Obat.DataBindings.Add("text", bndata, "kodeobat")
            .txtNama_Obat.DataBindings.Clear()
            .txtNama_Obat.DataBindings.Add("text", bndata, "Namaobat")
            .cbJenis.DataBindings.Clear()
            .cbJenis.DataBindings.Add("text", bndata, "jenisobat")
            .cbKemasan.DataBindings.Clear()
            .cbKemasan.DataBindings.Add("text", bndata, "kemasan")
            .txtHarga.DataBindings.Clear()
            .txtHarga.DataBindings.Add("text", bndata, "hargaobat")
            .txtJumlah.DataBindings.Clear()
            .txtJumlah.DataBindings.Add("text", bndata, "jumlahobat")
        End With
    End Sub
    Public Sub RefreshRecord()
        Dim koneksi As New aksesData.aksesMedical
        With FormObat
            Try
                da = New MySqlDataAdapter("Select kode_obat As KodeObat,nama_obat as NamaObat, jenis as JenisObat,kemasan as Kemasan,harga_obat as HargaObat,jumlah_obat as JumlahObat,(harga_obat*jumlah_obat) as JumlahHarga from tobat", koneksi.buka)
                Dim tbObat As New DataTable
                tbObat.Clear()
                da.Fill(tbObat)
                .DataGridViewObat.DataSource = tbObat
                bndata.DataSource = tbObat
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
        With FormObat
            If .txtCari.Text = "" Then
                MsgBox("Data Belum diinput", , "Searching record")
                .txtCari.Focus()
            End If
            Try
                If .rbKode_obat.Checked = True Then
                    da = New MySqlDataAdapter("select kode_obat as KodeObat,nama_obat as NamaObat,jenis as JenisObat,kemasan as Kemasan,harga_obat as HargaObat,jumlah_obat as JumlahObat,(harga_obat*jumlah_obat) as JumlahHarga from tobat where kode_obat = '" & vSearch & "'", Koneksi.buka)
                Else
                    da = New MySqlDataAdapter("select kode_obat as KodeObat,nama_obat as NamaObat,jenis as JenisObat,kemasan as Kemasan,harga_obat as HargaObat,jumlah_obat as JumlahObat,(harga_obat*jumlah_obat) as JumlahHarga from tobat where nama_obat like '" & vSearch & "%'", Koneksi.buka)
                End If
                Dim tbObat As New DataTable
                tbObat.Clear()
                da.Fill(tbObat)
                If tbObat.Rows.Count = Nothing Then
                    MsgBox("Data tidak ditemukan, isikan Input yang tepat...!", MsgBoxStyle.Information, "Perhatian")
                    .txtCari.Clear()
                    .txtCari.Focus()
                End If
                .DataGridViewObat.DataSource = tbObat
                'FormObat.listrecord()
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
            Koneksi.tutup()
        End With
        Return 0
    End Function
#End Region
#Region "Stored Procedure"
    Public Function insertobat(ByVal vkode_obat As String, ByVal vnama_obat As String, ByVal vjenis As String, ByVal vkemasan As String, ByVal vharga As String, ByVal vjumlah As String)
        Try
            Dim tambah As String = "ObatTAMBAH"
            Dim conn As New aksesData.aksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(tambah, conn.buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kode_obat"
            kode.Value = vkode_obat
            cmd.Parameters.Add(kode)
            Dim nama As New MySqlParameter
            nama.ParameterName = "@nama_obat"
            nama.Value = vnama_obat
            cmd.Parameters.Add(nama)
            Dim jenis As New MySqlParameter
            jenis.ParameterName = "@jenis"
            jenis.Value = vjenis
            cmd.Parameters.Add(jenis)
            Dim kemasan As New MySqlParameter
            kemasan.ParameterName = "@kemasan"
            kemasan.Value = vkemasan
            cmd.Parameters.Add(kemasan)
            Dim harga As New MySqlParameter
            harga.ParameterName = "@harga_obat"
            harga.Value = vharga
            cmd.Parameters.Add(harga)
            Dim jumlah As New MySqlParameter
            jumlah.ParameterName = "@jumlah_obat"
            jumlah.Value = vjumlah
            cmd.Parameters.Add(jumlah)
            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try

    End Function
    Public Function updateobat(ByVal vkode_obat As String, ByVal vnama_obat As String, ByVal vjenis As String, ByVal vkemasan As String, ByVal vharga As String, ByVal vjumlah As String)
        Try
            Dim ubah As String = "ObatUBAH"
            Dim conn As New aksesData.aksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(ubah, conn.buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kodeobat"
            kode.Value = vkode_obat
            cmd.Parameters.Add(kode)
            Dim nama As New MySqlParameter
            nama.ParameterName = "@nama_obat"
            nama.Value = vnama_obat
            cmd.Parameters.Add(nama)
            Dim jenis As New MySqlParameter
            jenis.ParameterName = "@jenis"
            jenis.Value = vjenis
            cmd.Parameters.Add(jenis)
            Dim kemasan As New MySqlParameter
            kemasan.ParameterName = "@kemasan"
            kemasan.Value = vkemasan
            cmd.Parameters.Add(kemasan)
            Dim harga As New MySqlParameter
            harga.ParameterName = "@harga_obat"
            harga.Value = vharga
            cmd.Parameters.Add(harga)
            Dim jumlah As New MySqlParameter
            jumlah.ParameterName = "@jumlah_obat"
            jumlah.Value = vjumlah
            cmd.Parameters.Add(jumlah)
            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try
    End Function
    Public Function deleteObat(ByVal vkode_obat As String)
        Try
            Dim hapus As String = "ObatHAPUS"
            Dim conn As New aksesData.aksesMedical
            Dim cmd As MySqlCommand = New MySqlCommand(hapus, conn.buka)
            cmd.CommandType = CommandType.StoredProcedure
            Dim kode As New MySqlParameter
            kode.ParameterName = "@kodeobat"
            kode.Value = vkode_obat
            cmd.Parameters.Add(kode)
            Dim hasil As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return hasil

        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message)
        End Try

    End Function
#End Region
End Module
