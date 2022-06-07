<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiagnosaPasien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDiagnosaPasien))
        Me.btKeListView = New System.Windows.Forms.Button
        Me.btClose = New System.Windows.Forms.Button
        Me.txtKode_dok = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btPrint = New System.Windows.Forms.Button
        Me.txtDiagnosa = New System.Windows.Forms.TextBox
        Me.txtNama_dok = New System.Windows.Forms.TextBox
        Me.txtNama_pas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PanelLuar = New System.Windows.Forms.Panel
        Me.DataGridresepobat = New System.Windows.Forms.DataGridView
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotalBayar = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPajak = New System.Windows.Forms.TextBox
        Me.txtJumlahTotal = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpPeriksa = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbNoRM = New System.Windows.Forms.ComboBox
        Me.cbKode_pas = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.PanelLuar.SuspendLayout()
        CType(Me.DataGridresepobat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btKeListView
        '
        Me.btKeListView.BackColor = System.Drawing.Color.Olive
        Me.btKeListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btKeListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKeListView.Image = CType(resources.GetObject("btKeListView.Image"), System.Drawing.Image)
        Me.btKeListView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btKeListView.Location = New System.Drawing.Point(156, 141)
        Me.btKeListView.Name = "btKeListView"
        Me.btKeListView.Size = New System.Drawing.Size(385, 46)
        Me.btKeListView.TabIndex = 34
        Me.btKeListView.Text = "Resep Obat"
        Me.btKeListView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btKeListView.UseVisualStyleBackColor = False
        '
        'btClose
        '
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(16, 119)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(100, 40)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "&C l o s e"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btClose.UseVisualStyleBackColor = True
        '
        'txtKode_dok
        '
        Me.txtKode_dok.Location = New System.Drawing.Point(156, 84)
        Me.txtKode_dok.MaxLength = 5
        Me.txtKode_dok.Name = "txtKode_dok"
        Me.txtKode_dok.Size = New System.Drawing.Size(124, 20)
        Me.txtKode_dok.TabIndex = 29
        Me.txtKode_dok.Text = "D-"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox2.Controls.Add(Me.btClose)
        Me.GroupBox2.Controls.Add(Me.btPrint)
        Me.GroupBox2.Location = New System.Drawing.Point(556, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 165)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Navigasi |"
        '
        'btPrint
        '
        Me.btPrint.Image = CType(resources.GetObject("btPrint.Image"), System.Drawing.Image)
        Me.btPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btPrint.Location = New System.Drawing.Point(16, 19)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(100, 91)
        Me.btPrint.TabIndex = 1
        Me.btPrint.Text = "&P r i n t"
        Me.btPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'txtDiagnosa
        '
        Me.txtDiagnosa.Location = New System.Drawing.Point(156, 115)
        Me.txtDiagnosa.Name = "txtDiagnosa"
        Me.txtDiagnosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDiagnosa.Size = New System.Drawing.Size(385, 20)
        Me.txtDiagnosa.TabIndex = 10
        '
        'txtNama_dok
        '
        Me.txtNama_dok.Location = New System.Drawing.Point(317, 85)
        Me.txtNama_dok.Name = "txtNama_dok"
        Me.txtNama_dok.Size = New System.Drawing.Size(224, 20)
        Me.txtNama_dok.TabIndex = 9
        '
        'txtNama_pas
        '
        Me.txtNama_pas.Location = New System.Drawing.Point(317, 57)
        Me.txtNama_pas.Name = "txtNama_pas"
        Me.txtNama_pas.Size = New System.Drawing.Size(224, 20)
        Me.txtNama_pas.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(314, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tanggal Periksa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil Diagnosa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode - Nama Dokter"
        '
        'PanelLuar
        '
        Me.PanelLuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelLuar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelLuar.Controls.Add(Me.DataGridresepobat)
        Me.PanelLuar.Controls.Add(Me.Label15)
        Me.PanelLuar.Controls.Add(Me.txtTotalBayar)
        Me.PanelLuar.Controls.Add(Me.Label14)
        Me.PanelLuar.Controls.Add(Me.Label13)
        Me.PanelLuar.Controls.Add(Me.txtPajak)
        Me.PanelLuar.Controls.Add(Me.txtJumlahTotal)
        Me.PanelLuar.Controls.Add(Me.GroupBox1)
        Me.PanelLuar.Location = New System.Drawing.Point(122, 12)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(715, 494)
        Me.PanelLuar.TabIndex = 1
        '
        'DataGridresepobat
        '
        Me.DataGridresepobat.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridresepobat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridresepobat.Location = New System.Drawing.Point(3, 215)
        Me.DataGridresepobat.Name = "DataGridresepobat"
        Me.DataGridresepobat.Size = New System.Drawing.Size(705, 146)
        Me.DataGridresepobat.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(434, 446)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 31)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Total Bayar  Rp "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(572, 446)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(136, 31)
        Me.txtTotalBayar.TabIndex = 13
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(449, 410)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 31)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Pajak 10%  Rp "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(430, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 23)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Jumlah Total Rp "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPajak
        '
        Me.txtPajak.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPajak.Location = New System.Drawing.Point(572, 410)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.ReadOnly = True
        Me.txtPajak.Size = New System.Drawing.Size(136, 31)
        Me.txtPajak.TabIndex = 6
        Me.txtPajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJumlahTotal
        '
        Me.txtJumlahTotal.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahTotal.Location = New System.Drawing.Point(572, 376)
        Me.txtJumlahTotal.Name = "txtJumlahTotal"
        Me.txtJumlahTotal.ReadOnly = True
        Me.txtJumlahTotal.Size = New System.Drawing.Size(136, 31)
        Me.txtJumlahTotal.TabIndex = 5
        Me.txtJumlahTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Controls.Add(Me.cbKode_pas)
        Me.GroupBox1.Controls.Add(Me.cbNoRM)
        Me.GroupBox1.Controls.Add(Me.dtpPeriksa)
        Me.GroupBox1.Controls.Add(Me.btKeListView)
        Me.GroupBox1.Controls.Add(Me.txtKode_dok)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtDiagnosa)
        Me.GroupBox1.Controls.Add(Me.txtNama_dok)
        Me.GroupBox1.Controls.Add(Me.txtNama_pas)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Data Diagnosa |"
        '
        'dtpPeriksa
        '
        Me.dtpPeriksa.CustomFormat = "yyyy-MM-dd"
        Me.dtpPeriksa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriksa.Location = New System.Drawing.Point(418, 27)
        Me.dtpPeriksa.Name = "dtpPeriksa"
        Me.dtpPeriksa.Size = New System.Drawing.Size(123, 20)
        Me.dtpPeriksa.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode - Nama Pasien"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Rekam Medis"
        '
        'cbNoRM
        '
        Me.cbNoRM.FormattingEnabled = True
        Me.cbNoRM.Location = New System.Drawing.Point(156, 26)
        Me.cbNoRM.Name = "cbNoRM"
        Me.cbNoRM.Size = New System.Drawing.Size(124, 21)
        Me.cbNoRM.TabIndex = 38
        '
        'cbKode_pas
        '
        Me.cbKode_pas.FormattingEnabled = True
        Me.cbKode_pas.Location = New System.Drawing.Point(156, 55)
        Me.cbKode_pas.Name = "cbKode_pas"
        Me.cbKode_pas.Size = New System.Drawing.Size(124, 21)
        Me.cbKode_pas.TabIndex = 39
        '
        'FormDiagnosaPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 635)
        Me.Controls.Add(Me.PanelLuar)
        Me.Name = "FormDiagnosaPasien"
        Me.Text = "FormDiagnosaPasien"
        Me.GroupBox2.ResumeLayout(False)
        Me.PanelLuar.ResumeLayout(False)
        Me.PanelLuar.PerformLayout()
        CType(Me.DataGridresepobat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btKeListView As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents txtKode_dok As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btPrint As System.Windows.Forms.Button
    Friend WithEvents txtDiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_dok As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_pas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPajak As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridresepobat As System.Windows.Forms.DataGridView
    Friend WithEvents dtpPeriksa As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbKode_pas As System.Windows.Forms.ComboBox
    Friend WithEvents cbNoRM As System.Windows.Forms.ComboBox
End Class
