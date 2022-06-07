Imports MySql.Data.mySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class FormDiagnosa
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
    '-- deklarasi variabel untuk perhitungan
    Dim banyak, harga, biayaObat, biayaPeriksa, totalBiaya, jumlahTotal, totPpn, totBayar As Long
    Dim kodeObat, namaObat, kemasan As String
    Dim i As Integer
    Dim n As Integer = 0
#End Region
    
#Region "Tampilan ListView"
    '-- Buat judul kolom untuk ListView --
    Sub DaftarViewObat()
        Dim colKode, colNama, colBanyak, colHarga, colBiayaObat, colBiayaPeriksa, colTotalBiaya As ColumnHeader
        colKode = New ColumnHeader
        With colKode
            .Text = "Kode Obat"
            .TextAlign = HorizontalAlignment.Left
            .Width = 70
        End With

        colNama = New ColumnHeader
        With colNama
            .Text = "Nama Obat"
            .TextAlign = HorizontalAlignment.Left
            .Width = 175
        End With

        colBanyak = New ColumnHeader
        With colBanyak
            .Text = "Jumlah Obat"
            .TextAlign = HorizontalAlignment.Right
            .Width = 80
        End With

        colHarga = New ColumnHeader
        With colHarga
            .Text = "Harga Satuan"
            .TextAlign = HorizontalAlignment.Right
            .Width = 100
        End With

        colBiayaObat = New ColumnHeader
        With colBiayaObat
            .Text = "Biaya Obat"
            .TextAlign = HorizontalAlignment.Right
            .Width = 90
        End With

        colBiayaPeriksa = New ColumnHeader
        With colBiayaPeriksa
            .Text = "Biaya Periksa"
            .TextAlign = HorizontalAlignment.Right
            .Width = 90
        End With

        colTotalBiaya = New ColumnHeader
        With colTotalBiaya
            .Text = "Total Biaya"
            .TextAlign = HorizontalAlignment.Right
            .Width = 100
        End With

        '--menampilkan judul kolom ke ListView --
        With Me.ListViewObat
            .Columns.Add(colKode)
            .Columns.Add(colNama)
            .Columns.Add(colBanyak)
            .Columns.Add(colHarga)
            .Columns.Add(colBiayaObat)
            .Columns.Add(colBiayaPeriksa)
            .Columns.Add(colTotalBiaya)
            .View = View.Details
            .GridLines = True
        End With
    End Sub
    
    '-- mengisi data pada listView --
    Private Sub IsiListViewObat()
        i = Val(txtCounter.Text)
        txtCounter.Text = Str(Val(txtCounter.Text) + 1)
        ListViewObat.Items.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
        kodeObat = txtKode_obat.Text
        namaObat = txtNama_obat.Text
        banyak = txtBanyak.Text
        harga = txtHarga.Text
        biayaObat = banyak * harga
        biayaPeriksa = txtBiaya_periksa.Text
        totalBiaya = biayaObat + biayaPeriksa

        ListViewObat.Items(i).SubItems(0).Text = kodeObat
        ListViewObat.Items(i).SubItems(1).Text = namaObat
        ListViewObat.Items(i).SubItems(2).Text = banyak 'Format(banyak, "##,##0")
        ListViewObat.Items(i).SubItems(3).Text = harga 'Format(harga, "##,##0")
        ListViewObat.Items(i).SubItems(4).Text = biayaObat 'Format(biayaObat, "##,##0")
        ListViewObat.Items(i).SubItems(5).Text = biayaPeriksa 'Format(biayaPeriksa, "##,##0")
        ListViewObat.Items(i).SubItems(6).Text = totalBiaya 'Format(totalBiaya, "##,##0")
        jumlahTotal = jumlahTotal + totalBiaya
        totPpn = 0.1 * jumlahTotal
        totBayar = jumlahTotal + totPpn
        txtJumlahTotal.Text = jumlahTotal 'Format(jumlahTotal, "###,###,###,#0")
        txtPajak.Text = totPpn 'Format(totPpn, "###,###,###,#0")
        txtTotalBayar.Text = totBayar 'Format(totBayar, "###,###,###,#0")

    End Sub
    '-- Bersihkan layar isian form --
    Sub FormIsianBersih()
        Me.txtNoRM.Clear()
        Me.txtKode_pas.Clear()
        Me.txtKode_dok.Clear()
        Me.txtNama_pas.Clear()
        Me.txtNama_dok.Clear()
        Me.txtDiagnosa.Clear()
        Me.txtJumlahTotal.Clear()
        Me.txtPajak.Clear()
        Me.txtTotalBayar.Clear()
        Me.txtKembali.Clear()
        Me.txtDiBayar.Clear()
        Me.txtKeterangan.Clear()
        Me.txtNoRM.Enabled = False
        Me.ListViewObat.Items.Clear()
        Me.dtpPeriksa.Focus()
    End Sub

#End Region
   
    '-- kejadian untuk menampilkan Daftar Pasien & mengambil isinya --
    Private Sub btCariPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCariPasien.Click
        If txtNoRM.Text = "" Then
            MsgBox("Nomor Rekam Medis harus diisi" & vbCrLf, MsgBoxStyle.Information, ".:Perhatian:.")
            Me.txtNoRM.Focus()
            Exit Sub
        End If
        frDaftarPasien.ShowDialog()
    End Sub
    '-- kejadian untuk menampilkan Daftar Dokter & mengambil isinya --
    Private Sub btCariDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCariDokter.Click
        If txtNoRM.Text = "" Then
            MsgBox("Nomor Rekam Medis harus diisi" & vbCrLf, MsgBoxStyle.Information, ".:Perhatian:.")
            Me.txtNoRM.Focus()
            Exit Sub
        End If
        'Dim DaftarDokter As New frDaftarDokter
        frDaftarDokter.ShowDialog()
    End Sub
    '-- kejadian untuk menampilkan Daftar Obat & mengambil isinya --
    Private Sub btCariObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCariObat.Click
        If txtNoRM.Text = "" Then
            MsgBox("Nomor Rekam Medis harus diisi" & vbCrLf, MsgBoxStyle.Information, ".:Perhatian:.")
            Me.btAdd.Focus()
            Exit Sub
        End If
        Dim DaftarObat As New frDaftarObat
        DaftarObat.ShowDialog()
    End Sub

    '-- mengisi nama Pasien, nama Dokter, dan Obat melalui kode masing-masing 
    Private Sub txtKode_pas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKode_pas.Validating
        Try
            If Not txtKode_pas.Text = "" Then
                txtNama_pas.Text = ""
                da = New MySqlDataAdapter("Select * from tpasien where kode_pas = '" & txtKode_pas.Text & "'", koneksi.buka)
                Dim dtPasien As New DataTable
                dtPasien.Clear()
                da.Fill(dtPasien)
                txtNama_pas.DataBindings.Add("Text", dtPasien, "nama_pas")
                txtNama_pas.DataBindings.Clear()
            Else
                Me.txtKode_pas.Text = ""
                Me.txtNama_pas.Text = ""
                Me.txtBanyak.Focus()
                koneksi.tutup()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, ".:Perhatian:.")
        End Try
    End Sub
    Private Sub txtKode_dok_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKode_dok.Validating
        Try
            If Not txtKode_dok.Text = "" Then
                txtNama_dok.Text = ""
                da = New MySqlDataAdapter("Select * from tdokter where kode_dok = '" & txtKode_dok.Text & "'", koneksi.buka)
                Dim dtDokter As New DataTable
                dtDokter.Clear()
                da.Fill(dtDokter)
                txtNama_dok.DataBindings.Add("Text", dtDokter, "nama_dok")
                txtNama_dok.DataBindings.Clear()
            Else
                Me.txtKode_dok.Text = ""
                Me.txtNama_dok.Text = ""
            End If
            koneksi.tutup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, ".:Perhatian:.")
        End Try
    End Sub
    Private Sub txtKode_obat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKode_obat.Validating
        Try
            If Not txtKode_obat.Text = "" Then
                txtNama_obat.Text = ""
                txtBiaya_periksa.Text = "0"
                da = New MySqlDataAdapter("Select * from tobat where kode_obat = '" & txtKode_obat.Text & "'", koneksi.buka)
                Dim dtObat As New DataTable
                dtObat.Clear()
                da.Fill(dtObat)

                txtNama_obat.DataBindings.Add("Text", dtObat, "nama_obat")
                'txtKemasan.DataBindings.Add("text", dtObat, "kemasan")
                txtBanyak.DataBindings.Add("text", dtObat, "jumlah_obat")
                txtHarga.DataBindings.Add("text", dtObat, "harga_obat")

                '-- hitung biaya obat dan total biaya
                banyak = Val(txtBanyak.Text)
                harga = Val(txtHarga.Text)
                biayaObat = banyak * harga
                txtBiaya_obat.Text = Format(biayaObat, "###,##0")
                biayaPeriksa = Val(txtBiaya_periksa.Text)

                '-- bebaskan databinding
                txtNama_obat.DataBindings.Clear()
                'txtKemasan.DataBindings.Clear()
                txtBanyak.DataBindings.Clear()
                txtHarga.DataBindings.Clear()
                txtBiaya_obat.DataBindings.Clear()
                txtBiaya_periksa.DataBindings.Clear()
            Else
                Me.txtKode_obat.Text = ""
                Me.txtNama_obat.Text = ""
            End If
            koneksi.tutup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Rekam Medis")
        End Try
    End Sub
    '-- kejadian menambah nomor RM yang baru
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Try
            modDiagnosa.GETCodeRM()
            txtNoRM.Enabled = False
            dtpPeriksa.Focus()
            txtCounter.Text = "0"
            ListViewObat.Items.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            ListViewObat.Items(ListViewObat.Items.Count - 1).SubItems.Add("")
            Me.txtNama_obat.Enabled = False
            Me.txtHarga.Enabled = False
            koneksi.tutup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, ".:Perhatian:.")
        End Try
    End Sub
    '-- kejadian untuk mengisi jumlah pembayaran --
    Private Sub txtDiBayar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiBayar.Validating
        Try
            If Me.txtTotalBayar.Text = "" Then
                Exit Sub
            ElseIf Me.txtDiBayar.Text = "" Then
                Exit Sub
            ElseIf Not IsNumeric(txtDiBayar.Text) Then
                MsgBox("Harap diisi dengan Angka" & vbCrLf & "Harap diisi dengan benar", MsgBoxStyle.Information, ".:Perhatian:.")
                Me.txtDiBayar.Clear()
                Me.txtDiBayar.Focus()
                Exit Sub
            Else
                Dim totalBayar, Bayar, Kembali As Long
                Bayar = Me.txtDiBayar.Text
                totalBayar = Me.txtTotalBayar.Text
                txtKembali.Text = CStr(Bayar - totalBayar)
                If txtKembali.Text.Chars(0) = "-" Then
                    MsgBox("Pembayaran masih Lebih Kecil dari Pada Jumlah Total" & vbCrLf & "Bayar dengan uang pass", MsgBoxStyle.Information, ".:Perhatian:.")
                    Me.txtDiagnosa.Focus()
                    Me.txtKembali.Clear()
                    Exit Sub
                End If
                Bayar = txtDiBayar.Text
                txtDiBayar.Text = Format(Bayar, "##,##0")
                totalBayar = Me.txtTotalBayar.Text
                Kembali = Bayar - totalBayar
                Me.txtKembali.Text = Format(Kembali, "##,##0")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, ".:Perhatian:.")
        End Try
    End Sub
    '-- kejadian untuk format uang pada pembayaran
    Private Sub txtDiBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiBayar.TextChanged
        Try
            Dim formatUang As Long
            If txtDiBayar.Text = "" Or Not IsNumeric(txtDiBayar.Text) Then
                Exit Sub
            End If
            formatUang = txtDiBayar.Text
            txtDiBayar.Text = Format(formatUang, "##,##0")
            txtDiBayar.SelectionStart = Len(txtDiBayar.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Rekam Medis")
        End Try
    End Sub
    '-- kejadian untuk mengisi ke ListView --
    Private Sub btKeListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKeListView.Click
        Try
            n = n + 1
            If n > 1 Then
                Call IsiListViewObat()
            Else
                Call IsiListViewObat()
            End If
            Me.txtKode_obat.Text = ""
            Me.txtNama_obat.Text = ""
            Me.txtBanyak.Text = ""
            Me.txtHarga.Text = ""
            Me.txtBiaya_obat.Text = ""
            txtBiaya_periksa.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, ".:Perhatian:.")
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim nomor As Int16
        If Me.txtCounter.Text = "0" Then
            MsgBox("Daftar Obat belum tersedia" & vbCrLf & "Silakan diisi dahulu", MsgBoxStyle.Information, "RekamMedis")
            Exit Sub
        End If
        If txtDiBayar.Text = "" Then
            MsgBox("Pembayaran Kosong" & vbCrLf & "Silakan diisi dahulu!", MsgBoxStyle.Information, "RekamMedis")
            Me.txtDiBayar.Focus()
            Exit Sub
        End If
        
        Try
            Dim cmd As New MySqlCommand
            Dim koneksi As New aksesData.aksesMedical

            nomor = 0
            Do While nomor < Me.ListViewObat.Items.Count - 1
                If nomor = Me.ListViewObat.Items.Count - 2 Then
                    cmd.CommandText = "insert into tperiksa_detail values (" & "'" & txtNoRM.Text & "','" & ListViewObat.Items(nomor).SubItems(0).Text & "','" & Val(ListViewObat.Items(nomor).SubItems(4).Text) & "','" & Val(ListViewObat.Items(nomor).SubItems(6).Text) & "','" & txtJumlahTotal.Text & "','" & txtPajak.Text & "','" & txtTotalBayar.Text & "');"
                Else
                    cmd.CommandText = "insert into tperiksa_detail values (" & "'" & txtNoRM.Text & "','" & ListViewObat.Items(nomor).SubItems(0).Text & "','" & Val(ListViewObat.Items(nomor).SubItems(4).Text) & "','" & Val(ListViewObat.Items(nomor).SubItems(6).Text) & "','0','0','0');"
                End If
                cmd.Connection = koneksi.buka()
                cmd.ExecuteNonQuery()
                koneksi.tutup()
               
                nomor += 1
            Loop
            cmd.CommandText = "insert into tperiksa values (" & "'" & txtNoRM.Text & "','" & Format(dtpPeriksa.Value, "yyyy-MM-dd") & "','" & txtKode_dok.Text & "','" & txtKode_pas.Text & "','" & txtDiagnosa.Text & "','" & Val(ListViewObat.Items(0).SubItems(5).Text) & "');"

            cmd.Connection = koneksi.buka()
            cmd.ExecuteNonQuery()
            koneksi.tutup()

            MsgBox("Record pada tabel Diagnosa dengan Nomor " & txtNoRM.Text & " dan Nama " & txtNama_pas.Text & " berhasil di Simpan.", MsgBoxStyle.Information)
            FormIsianBersih()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "RekamMedis")
            koneksi.tutup()
        End Try
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    
    Private Sub txtBanyak_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBanyak.TextChanged
        If txtBanyak.Text = "" Then
            txtBiaya_obat.Text = 0
        Else
            txtBiaya_obat.Text = Val(txtBanyak.Text * txtHarga.Text)
        End If
    End Sub

    Private Sub txtBiaya_periksa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBiaya_periksa.KeyPress
        e.Handled = koneksi.cumaangka(Asc(e.KeyChar))
    End Sub

    Private Sub FormDiagnosa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        modDiagnosa.FormLoad()
        modDiagnosa.RefreshRecord()
        DaftarViewObat()
        dtpPeriksa.Value = Now
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class