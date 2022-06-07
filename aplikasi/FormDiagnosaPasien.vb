Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical

Public Class FormDiagnosaPasien
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
#End Region

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        MsgBox("Periksa printer anda", MsgBoxStyle.Information, "RekamMedis")
    End Sub

    Private Sub FormDiagnosaPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PanelLuar.Top = (Me.Height - PanelLuar.Height) / 2
        PanelLuar.Left = (Me.Width - PanelLuar.Width) / 2

    End Sub

    Private Sub dtpPeriksa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriksa.ValueChanged
        modLogin.IsiCombo("select nomor_rm from tperiksa where tgl_perisa = '" & dtpPeriksa.Text & "'", cbNoRM)
        modLogin.IsiCombo("select kode_pas from tperiksa where tgl_perisa = '" & dtpPeriksa.Text & "'", cbKode_pas)
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Close()
    End Sub

    Private Sub cbKode_pas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKode_pas.SelectedIndexChanged
        Dim koneksi As New aksesData.aksesMedical
        Dim sql As String
        sql = "Select p.nama_pas,d.kode_dok,d.nama_dok,r.diagnosa from tpasien p,tdokter d,tperiksa r where r.nomor_rm='" _
        & cbNoRM.Text & "' and p.kode_pas='" & cbKode_pas.Text & "' and p.kode_pas=r.kode_pas and d.kode_dok=r.kode_dok"
        cmd = New MySqlCommand(sql, koneksi.buka)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Me.txtNama_pas.Text = dr.Item("nama_pas")
            Me.txtKode_dok.Text = dr.Item("kode_dok")
            Me.txtNama_dok.Text = dr.Item("nama_dok")
            Me.txtDiagnosa.Text = dr.Item("diagnosa")
        Else
            'MsgBox("Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub btKeListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKeListView.Click
        Try
            Dim koneksi As New aksesData.aksesMedical
            Me.DataGridresepobat.BringToFront()
            da = New MySqlDataAdapter("select o.Kode_obat as KodeObat,o.Nama_obat as NamaObat,d.biaya_obat as BiayaObat,d.total_biaya as TotalBiaya from tobat o,tperiksa_detail d,tperiksa p where p.nomor_rm='" & cbNoRM.Text & "' and o.kode_obat=d.kode_obat and p.nomor_rm=d.nomor_rm", koneksi.Buka)
            Dim dtObat As New DataTable
            dtObat.Clear()
            da.Fill(dtObat)
            Me.DataGridresepobat.DataSource = dtObat
            koneksi.tutup()

            Dim sql As String
            sql = "Select jumlah_total,pajak,total_bayar from tperiksa_detail where nomor_rm='" & cbNoRM.Text & "'"
            cmd = New MySqlCommand(sql, koneksi.buka)
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.Read - 2 Then
                    Me.txtJumlahTotal.Text = dr.Item("jumlah_total")
                    Me.txtPajak.Text = dr.Item("pajak")
                    Me.txtTotalBayar.Text = dr.Item("total_bayar")
                End If
            Else
                'MsgBox("Data Tidak Ditemukan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub
End Class