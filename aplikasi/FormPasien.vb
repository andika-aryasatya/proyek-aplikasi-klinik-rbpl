
Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class FormPasien
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
    Dim posisiRecord As Integer
#End Region
#Region "BAGIAN STORED PROCEDURE"
    Sub saveData()
        modPasien.insertPasien(vkode_pas:=txtKode_Pasien.Text, vnama_pas:=txtNama_Pasien.Text, _
                vkelamin:=cbKelamin.Text, vusia:=txtUsia.Text, vpekerjaan:=cbPekerjaan.Text, _
                vktp:=txtKtp.Text, valamat:=txtAlamat.Text, vkota:=txtKota.Text, _
                vtelpon:=txtTelepon.Text, vemail:=txtEmail.Text)
    End Sub
    Sub updateData()
        modPasien.updatePasien(vkode_pas:=txtKode_Pasien.Text, vnama_pas:=txtNama_Pasien.Text, _
                            vkelamin:=cbKelamin.Text, vusia:=txtUsia.Text, _
                            vpekerjaan:=cbPekerjaan.Text, _
                            vktp:=txtKtp.Text, valamat:=txtAlamat.Text, _
                            vkota:=txtKota.Text, vTelpon:=txtTelepon.Text, vEmail:=txtEmail.Text)
    End Sub
    Sub delete()
        modPasien.deletePasien(vkode_pas:=txtKode_Pasien.Text)
    End Sub
#End Region
#Region "BAGIAN AKSES TABEL"
    Sub displaydata()
        Try
            dt.Clear()
            sql = "Select * from tpasien order by kode_pas asc"
            cmd = New MySqlCommand
            cmd.Connection = koneksi.Buka
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "tpasien")
            koneksi.Tutup()
            dt = ds.Tables("tpasien")
        Catch ex As Exception
            MsgBox("Program Error" & vbCrLf & Err.Description)
            koneksi.Tutup()
        End Try
    End Sub
    Sub ListRecordPasien()
        cmd = koneksi.Buka.CreateCommand
        cmd.CommandText = "Select * from tpasien"
        dr = cmd.ExecuteReader
        If dr.Read() Then
            txtKode_Pasien.Text = dr.Item("kode_pas")
            txtNama_Pasien.Text = dr.Item("nama_pas").ToString
            cbKelamin.Text = dr.Item("kelamin").ToString
            txtUsia.Text = dr.Item("usia").ToString
            cbPekerjaan.Text = dr.Item("pekerjaan").ToString
            txtKtp.Text = dr.Item("ktp").ToString
            txtAlamat.Text = dr.Item("alamat").ToString
            txtTelepon.Text = dr.Item("telpon").ToString
            'posisiRecord = ds.Tables("tdokter").Rows.Count - 1
            'lbRecno.Text = ds.Tables("tdokter").Rows(PosisiRecord)("kode_dok").ToString()
            koneksi.Tutup()
        End If
    End Sub
#End Region
#Region "BAGIAN EVENT & METHOD PADA FORM"
    Private Sub frPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-- mengisi properti untuk form --
        modPasien.FormLoad()
        '-- memanggil sub-program pada modul --
        modPasien.Navigasi(True)
        modPasien.TextboxEnable(False)
        txtKode_Pasien.Enabled = False
        'Me.displaydata()
        Me.ListRecordPasien()
        modPasien.RefreshRecord()
        modPasien.DataBinding()
    End Sub
    Private Sub btAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Try
            mProses = "Tambah"
            btSave.Text = "Save"
            txtKode_Pasien.Enabled = False
            modPasien.TextboxEnable(True)
            modPasien.BersihkanLayar()
            modPasien.Navigasi(False)
            modPasien.BuatKodePasien()
            txtNama_Pasien.Focus()
        Catch When Err.Number <> 0
            MsgBox("Program Error " & vbCrLf & Err.Description)
            koneksi.Tutup()
        End Try
    End Sub
    Private Sub btSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Select Case btSave.Text
                Case "Update"
                    If MsgBox("Record Akan Diubah.....?", vbYesNo) = vbYes Then
                        updateData()
                        modPasien.TextboxEnable(False)
                        modPasien.Navigasi(True)
                        modPasien.BersihkanLayar()
                        modPasien.RefreshRecord()
                        ListRecordPasien()
                    Else
                        Exit Sub
                    End If
                Case "Save"
                    If MsgBox("Record Akan Disimpan.....?", vbYesNo) = vbYes Then
                        saveData()
                        modPasien.TextboxEnable(False)
                        modPasien.Navigasi(True)
                        modPasien.BersihkanLayar()
                        modPasien.RefreshRecord()
                        ListRecordPasien()
                    Else
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCancel.Click
        modPasien.BersihkanLayar()
        modPasien.Navigasi(True)
        modPasien.TextboxEnable(False)
        Me.ListRecordPasien()
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        btSave.Text = "Update"
        modPasien.TextboxEnable(True)
        modPasien.Navigasi(False)
        Me.txtNama_Pasien.Focus()
    End Sub
    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCari.Click
        modPasien.SearchRecord()
        Try
            txtKode_Pasien.Text = DataGridViewPasien.CurrentRow.Cells(0).Value
            txtNama_Pasien.Text = DataGridViewPasien.CurrentRow.Cells(1).Value
            cbKelamin.Text = DataGridViewPasien.CurrentRow.Cells(2).Value
            txtUsia.Text = DataGridViewPasien.CurrentRow.Cells(3).Value
            cbPekerjaan.Text = DataGridViewPasien.CurrentRow.Cells(4).Value
            txtKtp.Text = DataGridViewPasien.CurrentRow.Cells(5).Value
            txtAlamat.Text = DataGridViewPasien.CurrentRow.Cells(6).Value
            txtKota.Text = DataGridViewPasien.CurrentRow.Cells(7).Value
            txtTelepon.Text = DataGridViewPasien.CurrentRow.Cells(8).Value
            txtEmail.Text = DataGridViewPasien.CurrentRow.Cells(9).Value
        Catch ex As Exception
            MsgBox("Data Kosong")
            modPasien.BersihkanLayar()
            txtKode_Pasien.Text = ""
        End Try
    End Sub
    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        If txtKode_Pasien.Text = "" Then
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
    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        modPasien.RefreshRecord()
    End Sub
    Private Sub btExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
    Private Sub DataGridViewPasien_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPasien.CellClick
        Try
            txtKode_Pasien.Text = DataGridViewPasien.CurrentRow.Cells(0).Value
            txtNama_Pasien.Text = DataGridViewPasien.CurrentRow.Cells(1).Value
            cbKelamin.Text = DataGridViewPasien.CurrentRow.Cells(2).Value
            txtUsia.Text = DataGridViewPasien.CurrentRow.Cells(3).Value
            cbPekerjaan.Text = DataGridViewPasien.CurrentRow.Cells(4).Value
            txtKtp.Text = DataGridViewPasien.CurrentRow.Cells(5).Value
            txtAlamat.Text = DataGridViewPasien.CurrentRow.Cells(6).Value
            txtKota.Text = DataGridViewPasien.CurrentRow.Cells(7).Value
            txtTelepon.Text = DataGridViewPasien.CurrentRow.Cells(8).Value
            txtEmail.Text = DataGridViewPasien.CurrentRow.Cells(9).Value
        Catch ex As Exception
            MsgBox("Data Kosong")
            modPasien.BersihkanLayar()
            txtKode_Pasien.Text = ""
        End Try
    End Sub
    Private Sub txtKtp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKtp.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
    Private Sub txtUsia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsia.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
#End Region
End Class
