Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class FormPegawai
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.aksesMedical
    Dim mProses As String
    Dim PosisiRecord As Integer
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
#End Region
#Region "AktifkanStoredProcedure"
    Friend Sub InsertDataPEGAWAI(ByVal Simpan As String)
        Dim nip As String = txtNip.Text
        Dim nama As String = txtNama_peg.Text
        Dim kelamin As String = cbKelamin.Text
        Dim agama As String = cbAgama.Text
        Dim usia As String = txtUsia.Text
        ' Dim pekerjaan As String = cbPekerjaan.Text
        Dim ktp As String = txtKtp.Text
        Dim jabatan As String = txtJabatan.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text
        Dim telepon As String = txtTelepon.Text
        Dim email As String = txtEmail.Text
        Try
            cmd = New MySqlCommand(Simpan)
            With cmd
                .Connection = koneksi.buka
                .CommandType = CommandType.StoredProcedure
                .CommandText = Simpan
                With cmd
                    .Parameters.AddWithValue("nip", nip)      'Variabel vnip = vnip pada storedProc. 
                    .Parameters.AddWithValue("nama", nama)
                    .Parameters.AddWithValue("kelamin", kelamin)
                    .Parameters.AddWithValue("agama", agama)
                    .Parameters.AddWithValue("usia", usia)
                    '.Parameters.AddWithValue("vpekerjaan", pekerjaan)
                    .Parameters.AddWithValue("ktp", ktp)
                    .Parameters.AddWithValue("jabatan", jabatan)
                    .Parameters.AddWithValue("alamat", alamat)
                    .Parameters.AddWithValue("kota", kota)
                    .Parameters.AddWithValue("telepon", telepon)
                    .Parameters.AddWithValue("email", email)
                End With
                .ExecuteNonQuery()
                .Connection = koneksi.Tutup
                MsgBox("Record berhasil di simpan")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend Sub UpdateDataPEGAWAI(ByVal Ubah As String)
        Dim nip As String = txtNip.Text
        Dim nama As String = txtNama_peg.Text
        Dim kelamin As String = cbKelamin.Text
        Dim agama As String = cbAgama.Text
        Dim usia As String = txtUsia.Text
        'Dim pekerjaan As String = cbPekerjaan.Text
        Dim ktp As String = txtKtp.Text
        Dim jabatan As String = txtJabatan.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text
        Dim telepon As String = txtTelepon.Text
        Dim email As String = txtEmail.Text
        Try
            cmd = New MySqlCommand(Ubah)
            With cmd
                .Connection = koneksi.buka
                .CommandType = CommandType.StoredProcedure
                .CommandText = Ubah
                With cmd
                    .Parameters.AddWithValue("vnip", nip)
                    .Parameters.AddWithValue("nama", nama)
                    .Parameters.AddWithValue("kelamin", kelamin)
                    .Parameters.AddWithValue("agama", agama)
                    .Parameters.AddWithValue("usia", usia)
                    '.Parameters.AddWithValue("vpekerjaan", pekerjaan)
                    .Parameters.AddWithValue("ktp", ktp)
                    .Parameters.AddWithValue("jabatan", jabatan)
                    .Parameters.AddWithValue("alamat", alamat)
                    .Parameters.AddWithValue("kota", kota)
                    .Parameters.AddWithValue("telepon", telepon)
                    .Parameters.AddWithValue("email", email)
                End With
                .ExecuteNonQuery()
                MsgBox("Record berhasil di UBAH")
                .Connection = koneksi.Tutup
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend Sub DeleteDataPegawai(ByVal Hapus As String)
        Try
            cmd = New MySqlCommand(Hapus)
            With cmd
                .Connection = koneksi.buka
                .CommandType = CommandType.StoredProcedure
                .CommandText = Hapus
                With cmd
                    .Parameters.AddWithValue("vnip", txtNip.Text)
                End With
                .ExecuteNonQuery()
                MsgBox("Record berhasil di HAPUS...!")
                .Connection = koneksi.Tutup()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "EVENT&METHOD Terhadap FORM"
    '-- event & method terhadap Form --
    Private Sub FormPegawai_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        modPegawai.FormLoad()
        modPegawai.FormNavigasi(True)
        modPegawai.FormEnabledTextBox(True)
        modPegawai.DaftarPegawai()
        modPegawai.RefreshRecord()
        modPegawai.DataBinding()
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Try
            mProses = "Tambah"
            btSave.Text = "Save"
            txtNip.Enabled = False
            modPegawai.FormEnabledTextBox(False)
            modPegawai.FormLayarBersih()
            modPegawai.FormNavigasi(False)
            modPegawai.BuatKodePegawai()
            txtNama_peg.Focus()
        Catch When Err.Number <> 0
            MsgBox("Program Error " & vbCrLf & Err.Description)
            'koneksi.tutup()
        End Try

    End Sub
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Select Case btSave.Text
                Case "Update"
                    If MsgBox("Record Akan Diuabah.....?", vbYesNo) = vbYes Then
                        UpdateDataPEGAWAI("PegawaiUBAH")    '--- pemanggilan Stored Procedure untuk UPDATE
                        modPegawai.FormEnabledTextBox(True)
                        modPegawai.FormNavigasi(True)
                        modPegawai.FormLayarBersih()
                        btRefresh.PerformClick()
                    Else
                        Exit Sub
                    End If
                Case "Save"
                    If MsgBox("Record Akan Disimpan.....?", vbYesNo) = vbYes Then
                        InsertDataPEGAWAI("PegawaiTAMBAH")  '--- pemanggilan Stored Procedure untuk INSERT
                        modPegawai.FormEnabledTextBox(True)
                        modPegawai.FormNavigasi(True)
                        modPegawai.FormLayarBersih()
                        btRefresh.PerformClick()
                    Else
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btDelete.Click
        If txtNip.Text = "" Then
            MsgBox("Tidak Ada Data Yang Akan Di Hapus")
        Else
            If MsgBox("Yakin akan Dihapus????", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete") = MsgBoxResult.Yes Then
                DeleteDataPegawai("PegawaiHAPUS")          '--- pemanggilan Stored Procedure untuk DELETE
            Else
                Exit Sub
            End If
        End If
        btRefresh.PerformClick()
    End Sub
    Private Sub btCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCancel.Click
        modPegawai.FormEnabledTextBox(True)
        modPegawai.FormLayarBersih()
        modPegawai.FormNavigasi(True)
        modPegawai.DaftarPegawai()
        btRefresh.PerformClick()
    End Sub
    Private Sub btEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEdit.Click
        btSave.Text = "Update"
        modPegawai.FormEnabledTextBox(False)
        modPegawai.FormNavigasi(False)
    End Sub
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        modPegawai.RefreshRecord()
        modPegawai.DaftarPegawai()
    End Sub
    Private Sub btExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
    Private Sub btCari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCari.Click
        modPegawai.SearchRecord(vSearch:=txtCari.Text)
    End Sub
    Private Sub DataGridPegawai_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridPegawai.CellClick
        Try
            txtNip.Text = DataGridPegawai.CurrentRow.Cells(0).Value
            txtNama_peg.Text = DataGridPegawai.CurrentRow.Cells(1).Value
            cbKelamin.Text = DataGridPegawai.CurrentRow.Cells(2).Value
            cbAgama.Text = DataGridPegawai.CurrentRow.Cells(3).Value
            txtUsia.Text = DataGridPegawai.CurrentRow.Cells(4).Value
            txtKtp.Text = DataGridPegawai.CurrentRow.Cells(5).Value
            txtJabatan.Text = DataGridPegawai.CurrentRow.Cells(6).Value
            txtAlamat.Text = DataGridPegawai.CurrentRow.Cells(7).Value
            txtKota.Text = DataGridPegawai.CurrentRow.Cells(8).Value
            txtTelepon.Text = DataGridPegawai.CurrentRow.Cells(9).Value
            txtEmail.Text = DataGridPegawai.CurrentRow.Cells(10).Value
        Catch ex As Exception
            MsgBox("Data Kosong")
            modPegawai.FormLayarBersih()
            txtNip.Text = ""
        End Try
    End Sub
    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        e.Handled = koneksi.cumaAngka(Asc(e.KeyChar))
    End Sub
#End Region
End Class