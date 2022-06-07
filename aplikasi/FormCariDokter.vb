Imports MySql.Data.mySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class FormCariDokter
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
    Dim PosisiRecord As Integer
#End Region
    Sub AmbilData()
        Try
            dt.Clear()
            sql = "Select * from tdokter"
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

    Private Sub FormCariDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Pencarian Data Dokter"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.rbKode_Dokter.Checked = True
        '-- memanggil sub-program pada modul --
        'modKoneksiDatabase.BukaDatabase()
        Me.AmbilData()
    End Sub

    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCari.Click
        If txtCari.Text = "" Then
            MsgBox("Isikan kata kunci pencarian", , "Searching record")
            txtCari.Focus()
            Exit Sub
        End If
        Try
            If rbKode_Dokter.Checked = True Then
                da = New MySqlDataAdapter("select * from tdokter where kode_dok = '" & txtCari.Text & "'", koneksi.Buka)
            Else
                da = New MySqlDataAdapter("select * from tdokter where Nama_dok like '" & txtCari.Text & "%'", koneksi.Buka)
            End If
            Dim tbDokter As New DataTable
            tbDokter.Clear()
            da.Fill(tbDokter)
            If tbDokter.Rows.Count = Nothing Then
                MsgBox("Data tidak ditemukan, isikan Input yang tepat...!", MsgBoxStyle.Information, "Perhatian")
                txtCari.Clear()
                txtCari.Focus()
                Exit Sub
            End If
            DataGridDokter.DataSource = tbDokter
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        Try
            da = New MySqlDataAdapter("select * from tdokter where kode_dok = '" & txtCari.Text & "'", koneksi.Buka)
            Dim tbDokter As New DataTable
            tbDokter.Clear()
            da.Fill(tbDokter)
            DataGridDokter.DataSource = tbDokter
            txtCari.Clear()
            txtCari.Focus()
            modDokter.LayarBersih()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub
End Class