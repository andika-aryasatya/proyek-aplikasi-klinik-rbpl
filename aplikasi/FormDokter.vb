Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.AksesMedical
Public Class FormDokter
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
    Dim PosisiRecord As Integer
#End Region
#Region "BAGIAN DISPLAY RECORD"
    Sub displaydata()
        Try
            dt.Clear()
            sql = "Select * from tdokter order by kode_dok asc"
            cmd = New MySqlCommand
            cmd.Connection = koneksi.Buka
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "tdokter")
            koneksi.Tutup()
            dt = ds.Tables("tdokter")
        Catch ex As Exception
            MsgBox("Program Error" & vbCrLf & Err.Description)
            koneksi.Tutup()
        End Try
    End Sub
    Sub listrecord()
        cmd = koneksi.Buka.CreateCommand
        cmd.CommandText = "Select * from tdokter"
        dr = cmd.ExecuteReader
        If dr.Read() Then
            txtKode_dok.Text = dr.Item("kode_dok")
            txtNama_dok.Text = dr.Item("nama_dok").ToString
            txtAlamat.Text = dr.Item("alamat").ToString
            cbKelamin.Text = dr.Item("kelamin").ToString
            cbSpesialis.Text = dr.Item("spesialis").ToString
            txtKota.Text = dr.Item("kota").ToString
            txtTelepon.Text = dr.Item("telpon").ToString
            txtEmail.Text = dr.Item("email").ToString
            'PosisiRecord = ds.Tables("tdokter").Rows.Count - 1
            'lbRecno.Text = ds.Tables("tdokter").Rows(PosisiRecord)("kode_dok").ToString()
            koneksi.Tutup()
        End If
    End Sub
    Sub cariData()
        modDokter.SearchRecord(vSearch:=txtCari.Text)
        Try
            txtKode_dok.Text = DataGridDokter.CurrentRow.Cells(0).Value
            txtNama_dok.Text = DataGridDokter.CurrentRow.Cells(1).Value
            cbKelamin.Text = DataGridDokter.CurrentRow.Cells(2).Value
            cbSpesialis.Text = DataGridDokter.CurrentRow.Cells(3).Value
            txtAlamat.Text = DataGridDokter.CurrentRow.Cells(4).Value
            txtKota.Text = DataGridDokter.CurrentRow.Cells(5).Value
            txtTelepon.Text = DataGridDokter.CurrentRow.Cells(6).Value
            txtEmail.Text = DataGridDokter.CurrentRow.Cells(7).Value
        Catch ex As Exception
            modDokter.LayarBersih()
            txtKode_dok.Text = ""
        End Try
    End Sub
#End Region
#Region "BAGIAN EVENT & METHOD PADA FORM"
    '-- memberikan event & method terhadap tombol proses --
    Private Sub FormDokter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        modDokter.FormLoad()
        modDokter.RefreshRecord()
        modDokter.databinding()
        modDokter.Navigasi(True)
        modDokter.EnabledTextBox(True)
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Try
            mProses = "Tambah"
            btSave.Text = "Save"
            txtKode_dok.Enabled = False
            modDokter.EnabledTextBox(False)
            modDokter.LayarBersih()
            modDokter.BuatKodeDokter()
            modDokter.Navigasi(False)
            modDokter.BuatKodeDokter()
            txtNama_dok.Focus()
        Catch When Err.Number <> 0
            MsgBox("Program Error " & vbCrLf & Err.Description)
            koneksi.Tutup()
        End Try
    End Sub
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Select Case btSave.Text
                Case "Update"
                    If MsgBox("Record Akan Diuabah.....?", vbYesNo) = vbYes Then
                        'updateData()                                    '-- cara pertama
                        modDokter.UpdateDataDOKTER("DokterUBAH")         '-- cara kedua
                        modDokter.EnabledTextBox(True)
                        modDokter.Navigasi(True)
                        modDokter.LayarBersih()
                        btRefresh.PerformClick()
                    Else
                        Exit Sub
                    End If
                Case "Save"
                    If MsgBox("Record Akan Disimpan.....?", vbYesNo) = vbYes Then
                        'saveData()
                        modDokter.InsertDataDOKTER("DokterTAMBAH")
                        modDokter.EnabledTextBox(True)
                        modDokter.Navigasi(True)
                        modDokter.LayarBersih()
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
        modDokter.EnabledTextBox(True)
        modDokter.LayarBersih()
        modDokter.Navigasi(True)
        btRefresh.PerformClick()
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        btSave.Text = "Update"
        modDokter.EnabledTextBox(False)
        modDokter.Navigasi(False)
    End Sub
    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        If txtKode_dok.Text = "" Then
            MsgBox("Tidak Ada Data Yang Akan Di Hapus")
        Else
            If MsgBox("Yakin akan Dihapus????", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete") = MsgBoxResult.Yes Then
                ' deleteData()
                modDokter.DeleteDataDOKTER("DokterHAPUS")
            Else
                Exit Sub
            End If
        End If
        btRefresh.PerformClick()
    End Sub
    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
#End Region
#Region "BAGIAN PENCARIAN RECORD"
    Private Sub btcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCari.Click
        cariData()
    End Sub
    Private Sub btrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        modDokter.RefreshRecord()
        listrecord()
    End Sub
    Private Sub DataGridDokter_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridDokter.CellClick
        Try
            txtKode_dok.Text = DataGridDokter.CurrentRow.Cells(0).Value
            txtNama_dok.Text = DataGridDokter.CurrentRow.Cells(1).Value
            cbKelamin.Text = DataGridDokter.CurrentRow.Cells(2).Value
            cbSpesialis.Text = DataGridDokter.CurrentRow.Cells(3).Value
            txtAlamat.Text = DataGridDokter.CurrentRow.Cells(4).Value
            txtKota.Text = DataGridDokter.CurrentRow.Cells(5).Value
            txtTelepon.Text = DataGridDokter.CurrentRow.Cells(6).Value
            txtEmail.Text = DataGridDokter.CurrentRow.Cells(7).Value
        Catch ex As Exception
            MsgBox("data kososng")
            modDokter.LayarBersih()
            txtKode_dok.Text = ""
        End Try
    End Sub
    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
    Private Sub DataGridDokter_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridDokter.CellValueChanged
        listrecord()
    End Sub
#End Region
End Class