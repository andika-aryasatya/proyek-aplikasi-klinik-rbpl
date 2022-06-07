Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class frDaftarDokter
    Inherits System.Windows.Forms.Form
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.AksesMedical
    Dim da As MySqlDataAdapter
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridDokter As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNamaDokter As System.Windows.Forms.RadioButton
    Friend WithEvents rbKodeDokter As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariDokter As System.Windows.Forms.TextBox
    Friend WithEvents btCariDokter As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frDaftarDokter))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridDokter = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNamaDokter = New System.Windows.Forms.RadioButton()
        Me.rbKodeDokter = New System.Windows.Forms.RadioButton()
        Me.txtCariDokter = New System.Windows.Forms.TextBox()
        Me.btCariDokter = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridDokter)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 432)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 50)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Daftar Dokter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridDokter
        '
        Me.DataGridDokter.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridDokter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDokter.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDokter.Location = New System.Drawing.Point(10, 53)
        Me.DataGridDokter.Name = "DataGridDokter"
        Me.DataGridDokter.RowHeadersWidth = 51
        Me.DataGridDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDokter.Size = New System.Drawing.Size(571, 272)
        Me.DataGridDokter.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNamaDokter)
        Me.GroupBox1.Controls.Add(Me.rbKodeDokter)
        Me.GroupBox1.Controls.Add(Me.txtCariDokter)
        Me.GroupBox1.Controls.Add(Me.btCariDokter)
        Me.GroupBox1.Location = New System.Drawing.Point(254, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 105)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Pencarian |"
        '
        'rbNamaDokter
        '
        Me.rbNamaDokter.Location = New System.Drawing.Point(224, 66)
        Me.rbNamaDokter.Name = "rbNamaDokter"
        Me.rbNamaDokter.Size = New System.Drawing.Size(112, 26)
        Me.rbNamaDokter.TabIndex = 31
        Me.rbNamaDokter.Text = "Nama Dokter"
        '
        'rbKodeDokter
        '
        Me.rbKodeDokter.Location = New System.Drawing.Point(224, 40)
        Me.rbKodeDokter.Name = "rbKodeDokter"
        Me.rbKodeDokter.Size = New System.Drawing.Size(102, 21)
        Me.rbKodeDokter.TabIndex = 30
        Me.rbKodeDokter.Text = "Kode Dokter"
        '
        'txtCariDokter
        '
        Me.txtCariDokter.Location = New System.Drawing.Point(14, 21)
        Me.txtCariDokter.Name = "txtCariDokter"
        Me.txtCariDokter.Size = New System.Drawing.Size(186, 22)
        Me.txtCariDokter.TabIndex = 29
        Me.txtCariDokter.Text = "cari dokter"
        '
        'btCariDokter
        '
        Me.btCariDokter.Image = CType(resources.GetObject("btCariDokter.Image"), System.Drawing.Image)
        Me.btCariDokter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCariDokter.Location = New System.Drawing.Point(16, 48)
        Me.btCariDokter.Name = "btCariDokter"
        Me.btCariDokter.Size = New System.Drawing.Size(184, 47)
        Me.btCariDokter.TabIndex = 28
        Me.btCariDokter.Text = "&C a r i"
        Me.btCariDokter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btRefresh)
        Me.GroupBox2.Controls.Add(Me.btClose)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 102)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Tombol Proses |"
        '
        'btRefresh
        '
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btRefresh.Location = New System.Drawing.Point(10, 18)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(108, 73)
        Me.btRefresh.TabIndex = 30
        Me.btRefresh.Text = "&Refresh"
        '
        'btClose
        '
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(115, 18)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(108, 73)
        Me.btClose.TabIndex = 28
        Me.btClose.Text = "&Close"
        '
        'frDaftarDokter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frDaftarDokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frDaftarDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ControlBox = False
        Me.txtCariDokter.Clear()
        Me.rbKodeDokter.Checked = True
        Me.btRefresh.PerformClick()
        Me.GroupBox1.BackColor = Color.DarkSeaGreen
        Me.GroupBox2.BackColor = Color.DarkSeaGreen
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub btCariDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCariDokter.Click
        If Me.txtCariDokter.Text = "" Then
            MsgBox("Kunci pencarian masih Kosong...!", , "Search Dokter")
            Me.txtCariDokter.Focus()
            Exit Sub
        End If
        Try
            If rbKodeDokter.Checked = True Then
                da = New MySqlDataAdapter("select kode_dok as KodeDokter,nama_dok as NamaDokter from tDokter where kode_dok = '" & txtCariDokter.Text & "'", koneksi.Buka)
            Else
                da = New MySqlDataAdapter("select kode_dok as KodeDokter,nama_dok as Nama Dokter from tDokter where nama_dok like '" & txtCariDokter.Text & "%'", koneksi.Buka)
            End If

            Dim dtDokter As New DataTable
            dtDokter.Clear()
            da.Fill(dtDokter)

            If dtDokter.Rows.Count = Nothing Then
                MsgBox("Record tidak ditemukan, masukkan input yang tepat", MsgBoxStyle.Information, "Perhatian")
                Me.txtCariDokter.Clear()
                Me.txtCariDokter.Focus()
                Exit Sub
            End If
            koneksi.Tutup()
            Me.DataGridDokter.DataSource = dtDokter
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try

    End Sub

    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        Try
            Me.DataGridDokter.BringToFront()
            da = New MySqlDataAdapter("select kode_dok as KodeDokter,nama_dok as NamaDokter,alamat as Alamat from tdokter", koneksi.Buka)
            Dim dtDokter As New DataTable
            dtDokter.Clear()
            da.Fill(dtDokter)
            Me.DataGridDokter.DataSource = dtDokter
            Me.txtCariDokter.Clear()
            koneksi.tutup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub


    Private Sub DataGridDokter_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridDokter.DoubleClick
        FormDiagnosa.txtKode_dok.Text = DataGridDokter.SelectedCells(0).FormattedValue
        FormDiagnosa.txtNama_dok.Text = DataGridDokter.SelectedCells(1).FormattedValue
        Me.Close()
    End Sub
End Class
