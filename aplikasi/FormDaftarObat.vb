Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class frDaftarObat
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.AksesMedical
    Dim da As MySqlDataAdapter
#End Region
    Private Sub FormDaftarObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        Me.ControlBox = False
        Me.txtCariObat.Clear()
        Me.rbKode_Obat.Checked = True
        Me.btRefresh.PerformClick()
        Me.GroupBox2.BackColor = Color.DarkSeaGreen
        Me.GroupBox3.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub btCariObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCariObat.Click
        If Me.txtCariObat.Text = "" Then
            MsgBox("Kunci pencarian masih Kosong...!", , "Search Obat")
            Me.txtCariObat.Focus()
            Exit Sub
        End If
        Try
            If rbKode_Obat.Checked = True Then

                da = New MySqlDataAdapter("select kode_obat as KodeObat,nama_obat as NamaObat from tobat where kode_obat = '" & txtCariObat.Text & "'", koneksi.Buka)
            Else
                da = New MySqlDataAdapter("select kode_obat as KodeObat,nama_obat as NamaObat from tobat where nama_obat like '" & txtCariObat.Text & "%'", koneksi.Buka)
            End If

            Dim dtObat As New DataTable
            dtObat.Clear()
            da.Fill(dtObat)

            If dtObat.Rows.Count = Nothing Then
                MsgBox("Record tidak ditemukan, masukkan input yang tepat", MsgBoxStyle.Information, "Perhatian")
                Me.txtCariObat.Clear()
                Me.txtCariObat.Focus()
                Exit Sub
            End If
            Me.DataGridObat.DataSource = dtObat
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        Try
            Me.DataGridObat.BringToFront()
            da = New MySqlDataAdapter("select Kode_obat as KodeObat,Nama_obat as NamaObat,harga_obat as HargaObat from tobat", koneksi.Buka)
            Dim dtObat As New DataTable
            dtObat.Clear()
            da.Fill(dtObat)
            Me.DataGridObat.DataSource = dtObat
            Me.txtCariObat.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridObat_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridObat.DoubleClick
        FormDiagnosa.txtKode_obat.Text = DataGridObat.SelectedCells(0).FormattedValue
        FormDiagnosa.txtNama_obat.Text = DataGridObat.SelectedCells(1).FormattedValue
        FormDiagnosa.txtHarga.Text = DataGridObat.SelectedCells(2).FormattedValue
        Me.Close()
    End Sub
End Class