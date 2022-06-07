Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class FormObat
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.aksesMedical
    Dim mProses As String
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
#End Region
#Region "AksesTABEL"
    Sub displaydata()
        Try
            dt.Clear()
            sql = "Select * from tobat order by kode_obat asc"
            cmd = New MySqlCommand
            cmd.Connection = koneksi.Buka
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "tobat")
            koneksi.Tutup()
            dt = ds.Tables("tobat")
        Catch ex As Exception
            MsgBox("Program Error" & vbCrLf & Err.Description)
            koneksi.tutup()
        End Try
    End Sub
    Sub listrecord()
        cmd = koneksi.buka.CreateCommand
        cmd.CommandText = "Select * from tobat"
        dr = cmd.ExecuteReader
        If dr.Read() Then
            txtKode_Obat.Text = dr.Item("kode_obat")
            txtNama_Obat.Text = dr.Item("nama_obat").ToString
            cbJenis.Text = dr.Item("jenis").ToString
            cbKemasan.Text = dr.Item("kemasan").ToString
            txtHarga.Text = dr.Item("harga_obat").ToString
            txtJumlah.Text = dr.Item("jumlah_obat").ToString
            'PosisiRecord = ds.Tables("tdokter").Rows.Count - 1
            'lbRecno.Text = ds.Tables("tdokter").Rows(PosisiRecord)("kode_dok").ToString()
            koneksi.Tutup()
        End If
    End Sub
    Sub cari()
        modObat.SearchRecord(vSearch:=txtCari.Text)
        Try
            txtKode_Obat.Text = DataGridViewObat.CurrentRow.Cells(0).Value
            txtNama_Obat.Text = DataGridViewObat.CurrentRow.Cells(1).Value
            cbJenis.Text = DataGridViewObat.CurrentRow.Cells(2).Value
            cbKemasan.Text = DataGridViewObat.CurrentRow.Cells(3).Value
            txtHarga.Text = DataGridViewObat.CurrentRow.Cells(4).Value
            txtJumlah.Text = DataGridViewObat.CurrentRow.Cells(5).Value
            txtJumlah_harga.Text = DataGridViewObat.CurrentRow.Cells(6).Value
        Catch ex As Exception
            'MsgBox("data kososng")
            modObat.LayarBersih()
            txtKode_Obat.Text = ""
        End Try
    End Sub
#End Region
#Region "NilaiStoredProcedure"
    Sub saveData()
        modObat.insertobat(vkode_obat:=txtKode_Obat.Text, vnama_obat:=txtNama_Obat.Text, _
                            vjenis:=cbJenis.Text, _
                            vkemasan:=cbKemasan.Text, _
                            vharga:=txtHarga.Text, _
                            vjumlah:=txtJumlah.Text)
    End Sub
    Sub updateData()
        modObat.updateobat(vkode_obat:=txtKode_Obat.Text, vnama_obat:=txtNama_Obat.Text, _
                            vjenis:=cbJenis.Text, _
                            vkemasan:=cbKemasan.Text, _
                            vharga:=txtHarga.Text, _
                            vjumlah:=txtJumlah.Text)
    End Sub
    Sub delete()
        modObat.deleteObat(vkode_obat:=txtKode_Obat.Text)
    End Sub
#End Region
#Region "EVENT&METHOD Terhadap FORM"
    '-- memberikan event & method terhadap tombol proses --
    Private Sub FormObat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        modObat.FormLoad()
        Me.listrecord()
        Me.txtJumlah_harga.Enabled = False
        modObat.RefreshRecord()
        modObat.databinding()
        modObat.Navigasi(True)
        modObat.EnabledTextBox(True)
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Try
            mProses = "Tambah"
            btSave.Text = "Save"
            txtKode_Obat.Enabled = False
            modObat.EnabledTextBox(False)
            modObat.LayarBersih()
            modObat.Navigasi(False)
            modObat.BuatKodeObat()
            txtNama_Obat.Focus()
        Catch When Err.Number <> 0
            MsgBox("Program Error " & vbCrLf & Err.Description)
            koneksi.tutup()
        End Try
    End Sub
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Select Case btSave.Text
                Case "Update"
                    If MsgBox("Record Akan Diuabah.....?", vbYesNo) = vbYes Then
                        updateData()
                        modObat.EnabledTextBox(True)
                        modObat.Navigasi(True)
                        modObat.LayarBersih()
                        btRefresh.PerformClick()
                    Else
                        Exit Sub
                    End If
                Case "Save"
                    If MsgBox("Record Akan Disimpan.....?", vbYesNo) = vbYes Then
                        saveData()
                        modObat.EnabledTextBox(True)
                        modObat.Navigasi(True)
                        modObat.LayarBersih()
                        btRefresh.PerformClick()
                    Else
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        modObat.EnabledTextBox(True)
        modObat.LayarBersih()
        modObat.Navigasi(True)
        btRefresh.PerformClick()
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        btSave.Text = "Update"
        modObat.EnabledTextBox(False)
        modObat.Navigasi(False)
    End Sub
    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        If txtKode_Obat.Text = "" Then
            MsgBox("Tidak Ada Data Yang Akan Di Hapus")
        Else
            If MsgBox("Yakin akan Dihapus????", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete") = MsgBoxResult.Yes Then
                delete()
            Else
                Exit Sub
            End If
        End If
        btRefresh.PerformClick()
    End Sub
    Private Sub btcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCari.Click
        cari()
    End Sub
    Private Sub btrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        modObat.RefreshRecord()
        listrecord()
    End Sub
    Private Sub DataGridViewObat_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewObat.CellClick
        Try
            txtKode_Obat.Text = DataGridViewObat.CurrentRow.Cells(0).Value
            txtNama_Obat.Text = DataGridViewObat.CurrentRow.Cells(1).Value
            cbJenis.Text = DataGridViewObat.CurrentRow.Cells(2).Value
            cbKemasan.Text = DataGridViewObat.CurrentRow.Cells(3).Value
            txtHarga.Text = DataGridViewObat.CurrentRow.Cells(4).Value
            txtJumlah.Text = DataGridViewObat.CurrentRow.Cells(5).Value
            txtJumlah_harga.Text = DataGridViewObat.CurrentRow.Cells(6).Value
        Catch ex As Exception
            MsgBox("data kososng")
            modObat.LayarBersih()
            txtKode_Obat.Text = ""
        End Try
    End Sub
    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
    Private Sub txtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
    Private Sub txtJumlah_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged
        If txtJumlah.Text = "" Or txtHarga.Text = "" Then
            txtJumlah_harga.Text = 0
        Else
            txtJumlah_harga.Text = Val(txtHarga.Text * txtJumlah.Text)
        End If
    End Sub
    Private Sub txtHarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHarga.TextChanged
        If txtJumlah.Text = "" Or txtHarga.Text = "" Then
            txtJumlah_harga.Text = 0
        Else
            txtJumlah_harga.Text = Val(txtHarga.Text * txtJumlah.Text)
        End If
    End Sub
    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub
#End Region
End Class