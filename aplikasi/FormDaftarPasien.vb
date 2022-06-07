Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Public Class frDaftarPasien
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
    Friend WithEvents DataGridPasien As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNamaPasien As System.Windows.Forms.RadioButton
    Friend WithEvents rbKodePasien As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariPasien As System.Windows.Forms.TextBox
    Friend WithEvents btCariPasien As System.Windows.Forms.Button
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frDaftarPasien))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridPasien = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNamaPasien = New System.Windows.Forms.RadioButton()
        Me.rbKodePasien = New System.Windows.Forms.RadioButton()
        Me.txtCariPasien = New System.Windows.Forms.TextBox()
        Me.btCariPasien = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridPasien)
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
        Me.Label1.Text = "Daftar Pasien"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridPasien
        '
        Me.DataGridPasien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridPasien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPasien.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridPasien.Location = New System.Drawing.Point(10, 53)
        Me.DataGridPasien.Name = "DataGridPasien"
        Me.DataGridPasien.RowHeadersWidth = 51
        Me.DataGridPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPasien.Size = New System.Drawing.Size(571, 272)
        Me.DataGridPasien.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNamaPasien)
        Me.GroupBox1.Controls.Add(Me.rbKodePasien)
        Me.GroupBox1.Controls.Add(Me.txtCariPasien)
        Me.GroupBox1.Controls.Add(Me.btCariPasien)
        Me.GroupBox1.Location = New System.Drawing.Point(254, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 120)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Pencarian |"
        '
        'rbNamaPasien
        '
        Me.rbNamaPasien.Location = New System.Drawing.Point(224, 66)
        Me.rbNamaPasien.Name = "rbNamaPasien"
        Me.rbNamaPasien.Size = New System.Drawing.Size(112, 26)
        Me.rbNamaPasien.TabIndex = 31
        Me.rbNamaPasien.Text = "Nama Pasien"
        '
        'rbKodePasien
        '
        Me.rbKodePasien.Location = New System.Drawing.Point(224, 40)
        Me.rbKodePasien.Name = "rbKodePasien"
        Me.rbKodePasien.Size = New System.Drawing.Size(102, 21)
        Me.rbKodePasien.TabIndex = 30
        Me.rbKodePasien.Text = "Kode Pasien"
        '
        'txtCariPasien
        '
        Me.txtCariPasien.Location = New System.Drawing.Point(14, 21)
        Me.txtCariPasien.Name = "txtCariPasien"
        Me.txtCariPasien.Size = New System.Drawing.Size(186, 22)
        Me.txtCariPasien.TabIndex = 29
        Me.txtCariPasien.Text = "TextBox10"
        '
        'btCariPasien
        '
        Me.btCariPasien.Image = CType(resources.GetObject("btCariPasien.Image"), System.Drawing.Image)
        Me.btCariPasien.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCariPasien.Location = New System.Drawing.Point(16, 48)
        Me.btCariPasien.Name = "btCariPasien"
        Me.btCariPasien.Size = New System.Drawing.Size(184, 47)
        Me.btCariPasien.TabIndex = 28
        Me.btCariPasien.Text = "&C a r i"
        Me.btCariPasien.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        'frDaftarPasien
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(937, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frDaftarPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frDaftarPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ControlBox = False
        Me.txtCariPasien.Clear()
        Me.rbKodePasien.Checked = True
        Me.btRefresh.PerformClick()
        Me.GroupBox1.BackColor = Color.DarkSeaGreen
        Me.GroupBox2.BackColor = Color.DarkSeaGreen
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub btCariPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCariPasien.Click
        If Me.txtCariPasien.Text = "" Then
            MsgBox("Kunci pencarian masih Kosong...!", , "Search Pasien")
            Me.txtCariPasien.Focus()
            Exit Sub
        End If
        Try
            If rbKodePasien.Checked = True Then
                da = New MySqlDataAdapter("select kode_pas as KodePasien,nama_pas as NamaPasien from tpasien where kode_pas = '" & txtCariPasien.Text & "'", koneksi.buka)
            Else
                da = New MySqlDataAdapter("select kode_pas as KodePasien,nama_pas as Nama Pasien from tpasien where nama_pas like '" & txtCariPasien.Text & "%'", koneksi.buka)
            End If

            Dim dtPasien As New DataTable
            dtPasien.Clear()
            da.Fill(dtPasien)

            If dtPasien.Rows.Count = Nothing Then
                MsgBox("Record tidak ditemukan, masukkan input yang tepat", MsgBoxStyle.Information, "Perhatian")
                Me.txtCariPasien.Clear()
                Me.txtCariPasien.Focus()
                Exit Sub
            End If
            koneksi.tutup()
            Me.DataGridPasien.DataSource = dtPasien
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
        koneksi.Tutup()
    End Sub

    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
        Try
            Me.DataGridPasien.BringToFront()
            da = New MySqlDataAdapter("select kode_pas As KodePasien,nama_pas As NamaPasien,kelamin as JenisKelamin,alamat as Alamat,telpon as Telepon from tpasien", koneksi.buka)
            Dim dtPasien As New DataTable
            dtPasien.Clear()
            da.Fill(dtPasien)
            Me.DataGridPasien.DataSource = dtPasien
            Me.txtCariPasien.Clear()
            koneksi.tutup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
        koneksi.Tutup()
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub


   
    Private Sub DataGridPasien_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridPasien.DoubleClick
        FormDiagnosa.txtKode_pas.Text = DataGridPasien.SelectedCells(0).FormattedValue
        FormDiagnosa.txtNama_pas.Text = DataGridPasien.SelectedCells(1).FormattedValue
        Me.Close()
    End Sub

    Private Sub DataGridPasien_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridPasien.CellContentClick

    End Sub
End Class
