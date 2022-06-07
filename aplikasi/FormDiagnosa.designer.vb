<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiagnosa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDiagnosa))
        Me.PanelLuar = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDiBayar = New System.Windows.Forms.TextBox()
        Me.txtPajak = New System.Windows.Forms.TextBox()
        Me.txtJumlahTotal = New System.Windows.Forms.TextBox()
        Me.ListViewObat = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.btKeListView = New System.Windows.Forms.Button()
        Me.txtBiaya_periksa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtKode_dok = New System.Windows.Forms.TextBox()
        Me.txtKode_pas = New System.Windows.Forms.TextBox()
        Me.btCariObat = New System.Windows.Forms.Button()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.txtBiaya_obat = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtBanyak = New System.Windows.Forms.TextBox()
        Me.txtNama_obat = New System.Windows.Forms.TextBox()
        Me.txtKode_obat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCariDokter = New System.Windows.Forms.Button()
        Me.btCariPasien = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.dtpPeriksa = New System.Windows.Forms.DateTimePicker()
        Me.txtDiagnosa = New System.Windows.Forms.TextBox()
        Me.txtNama_dok = New System.Windows.Forms.TextBox()
        Me.txtNama_pas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoRM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLuar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLuar
        '
        Me.PanelLuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelLuar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelLuar.Controls.Add(Me.Label15)
        Me.PanelLuar.Controls.Add(Me.txtTotalBayar)
        Me.PanelLuar.Controls.Add(Me.txtKembali)
        Me.PanelLuar.Controls.Add(Me.Label17)
        Me.PanelLuar.Controls.Add(Me.Label16)
        Me.PanelLuar.Controls.Add(Me.Label14)
        Me.PanelLuar.Controls.Add(Me.Label13)
        Me.PanelLuar.Controls.Add(Me.txtDiBayar)
        Me.PanelLuar.Controls.Add(Me.txtPajak)
        Me.PanelLuar.Controls.Add(Me.txtJumlahTotal)
        Me.PanelLuar.Controls.Add(Me.ListViewObat)
        Me.PanelLuar.Controls.Add(Me.GroupBox1)
        Me.PanelLuar.Location = New System.Drawing.Point(165, 0)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(777, 569)
        Me.PanelLuar.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(434, 443)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 31)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Total Bayar  Rp "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(572, 443)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(136, 31)
        Me.txtTotalBayar.TabIndex = 13
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKembali
        '
        Me.txtKembali.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembali.Location = New System.Drawing.Point(572, 513)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.ReadOnly = True
        Me.txtKembali.Size = New System.Drawing.Size(136, 31)
        Me.txtKembali.TabIndex = 12
        Me.txtKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(438, 513)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 31)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "K e m b a l i  Rp  "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(448, 478)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 31)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Di Bayar  Rp "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(449, 407)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 31)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Pajak 10%  Rp "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(430, 373)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 23)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Jumlah Total Rp "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiBayar
        '
        Me.txtDiBayar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiBayar.Location = New System.Drawing.Point(572, 478)
        Me.txtDiBayar.Name = "txtDiBayar"
        Me.txtDiBayar.Size = New System.Drawing.Size(136, 31)
        Me.txtDiBayar.TabIndex = 7
        Me.txtDiBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPajak
        '
        Me.txtPajak.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPajak.Location = New System.Drawing.Point(572, 407)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.ReadOnly = True
        Me.txtPajak.Size = New System.Drawing.Size(136, 31)
        Me.txtPajak.TabIndex = 6
        Me.txtPajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJumlahTotal
        '
        Me.txtJumlahTotal.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahTotal.Location = New System.Drawing.Point(572, 373)
        Me.txtJumlahTotal.Name = "txtJumlahTotal"
        Me.txtJumlahTotal.ReadOnly = True
        Me.txtJumlahTotal.Size = New System.Drawing.Size(136, 31)
        Me.txtJumlahTotal.TabIndex = 5
        Me.txtJumlahTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ListViewObat
        '
        Me.ListViewObat.BackColor = System.Drawing.Color.Silver
        Me.ListViewObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListViewObat.Location = New System.Drawing.Point(0, 242)
        Me.ListViewObat.Name = "ListViewObat"
        Me.ListViewObat.Size = New System.Drawing.Size(773, 128)
        Me.ListViewObat.TabIndex = 1
        Me.ListViewObat.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtKeterangan)
        Me.GroupBox1.Controls.Add(Me.btKeListView)
        Me.GroupBox1.Controls.Add(Me.txtBiaya_periksa)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtKode_dok)
        Me.GroupBox1.Controls.Add(Me.txtKode_pas)
        Me.GroupBox1.Controls.Add(Me.btCariObat)
        Me.GroupBox1.Controls.Add(Me.txtCounter)
        Me.GroupBox1.Controls.Add(Me.txtBiaya_obat)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtBanyak)
        Me.GroupBox1.Controls.Add(Me.txtNama_obat)
        Me.GroupBox1.Controls.Add(Me.txtKode_obat)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btCariDokter)
        Me.GroupBox1.Controls.Add(Me.btCariPasien)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpPeriksa)
        Me.GroupBox1.Controls.Add(Me.txtDiagnosa)
        Me.GroupBox1.Controls.Add(Me.txtNama_dok)
        Me.GroupBox1.Controls.Add(Me.txtNama_pas)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNoRM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Data Diagnosa |"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(13, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Keterangan / Catatan:"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(156, 139)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(370, 46)
        Me.txtKeterangan.TabIndex = 35
        '
        'btKeListView
        '
        Me.btKeListView.BackColor = System.Drawing.Color.Olive
        Me.btKeListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btKeListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKeListView.Image = CType(resources.GetObject("btKeListView.Image"), System.Drawing.Image)
        Me.btKeListView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btKeListView.Location = New System.Drawing.Point(529, 138)
        Me.btKeListView.Name = "btKeListView"
        Me.btKeListView.Size = New System.Drawing.Size(78, 46)
        Me.btKeListView.TabIndex = 34
        Me.btKeListView.Text = "C a t a t"
        Me.btKeListView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btKeListView.UseVisualStyleBackColor = False
        '
        'txtBiaya_periksa
        '
        Me.txtBiaya_periksa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya_periksa.Location = New System.Drawing.Point(528, 213)
        Me.txtBiaya_periksa.Name = "txtBiaya_periksa"
        Me.txtBiaya_periksa.Size = New System.Drawing.Size(80, 21)
        Me.txtBiaya_periksa.TabIndex = 33
        Me.txtBiaya_periksa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(527, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Biaya Periksa"
        '
        'txtKode_dok
        '
        Me.txtKode_dok.Location = New System.Drawing.Point(156, 81)
        Me.txtKode_dok.MaxLength = 5
        Me.txtKode_dok.Name = "txtKode_dok"
        Me.txtKode_dok.Size = New System.Drawing.Size(124, 20)
        Me.txtKode_dok.TabIndex = 29
        Me.txtKode_dok.Text = "D-"
        '
        'txtKode_pas
        '
        Me.txtKode_pas.Location = New System.Drawing.Point(156, 54)
        Me.txtKode_pas.MaxLength = 6
        Me.txtKode_pas.Name = "txtKode_pas"
        Me.txtKode_pas.Size = New System.Drawing.Size(124, 20)
        Me.txtKode_pas.TabIndex = 28
        Me.txtKode_pas.Text = "P-"
        '
        'btCariObat
        '
        Me.btCariObat.Image = CType(resources.GetObject("btCariObat.Image"), System.Drawing.Image)
        Me.btCariObat.Location = New System.Drawing.Point(56, 210)
        Me.btCariObat.Name = "btCariObat"
        Me.btCariObat.Size = New System.Drawing.Size(25, 25)
        Me.btCariObat.TabIndex = 27
        Me.btCariObat.UseVisualStyleBackColor = True
        '
        'txtCounter
        '
        Me.txtCounter.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCounter.Location = New System.Drawing.Point(156, 191)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.Size = New System.Drawing.Size(65, 20)
        Me.txtCounter.TabIndex = 15
        Me.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCounter.Visible = False
        '
        'txtBiaya_obat
        '
        Me.txtBiaya_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya_obat.Location = New System.Drawing.Point(446, 213)
        Me.txtBiaya_obat.Name = "txtBiaya_obat"
        Me.txtBiaya_obat.Size = New System.Drawing.Size(80, 21)
        Me.txtBiaya_obat.TabIndex = 26
        Me.txtBiaya_obat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(368, 214)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(74, 20)
        Me.txtHarga.TabIndex = 25
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBanyak
        '
        Me.txtBanyak.Location = New System.Drawing.Point(286, 214)
        Me.txtBanyak.Name = "txtBanyak"
        Me.txtBanyak.Size = New System.Drawing.Size(76, 20)
        Me.txtBanyak.TabIndex = 24
        Me.txtBanyak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNama_obat
        '
        Me.txtNama_obat.Location = New System.Drawing.Point(83, 214)
        Me.txtNama_obat.Name = "txtNama_obat"
        Me.txtNama_obat.Size = New System.Drawing.Size(197, 20)
        Me.txtNama_obat.TabIndex = 22
        '
        'txtKode_obat
        '
        Me.txtKode_obat.Location = New System.Drawing.Point(7, 214)
        Me.txtKode_obat.MaxLength = 6
        Me.txtKode_obat.Name = "txtKode_obat"
        Me.txtKode_obat.Size = New System.Drawing.Size(46, 20)
        Me.txtKode_obat.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(447, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Biaya Obat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(369, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Harga Obat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(283, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Banyak"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(84, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nama Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(6, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Kode Obat"
        '
        'btCariDokter
        '
        Me.btCariDokter.Image = CType(resources.GetObject("btCariDokter.Image"), System.Drawing.Image)
        Me.btCariDokter.Location = New System.Drawing.Point(286, 77)
        Me.btCariDokter.Name = "btCariDokter"
        Me.btCariDokter.Size = New System.Drawing.Size(25, 25)
        Me.btCariDokter.TabIndex = 14
        Me.btCariDokter.UseVisualStyleBackColor = True
        '
        'btCariPasien
        '
        Me.btCariPasien.Image = CType(resources.GetObject("btCariPasien.Image"), System.Drawing.Image)
        Me.btCariPasien.Location = New System.Drawing.Point(285, 50)
        Me.btCariPasien.Name = "btCariPasien"
        Me.btCariPasien.Size = New System.Drawing.Size(25, 25)
        Me.btCariPasien.TabIndex = 13
        Me.btCariPasien.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox2.Controls.Add(Me.btAdd)
        Me.GroupBox2.Controls.Add(Me.btClose)
        Me.GroupBox2.Controls.Add(Me.btPrint)
        Me.GroupBox2.Controls.Add(Me.btSave)
        Me.GroupBox2.Location = New System.Drawing.Point(623, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 217)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Navigasi |"
        '
        'btAdd
        '
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btAdd.Location = New System.Drawing.Point(16, 15)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(100, 40)
        Me.btAdd.TabIndex = 3
        Me.btAdd.Text = "&Add Diagnosa"
        Me.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(16, 164)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(100, 40)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "&C l o s e"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btPrint
        '
        Me.btPrint.Image = CType(resources.GetObject("btPrint.Image"), System.Drawing.Image)
        Me.btPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btPrint.Location = New System.Drawing.Point(16, 109)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(100, 40)
        Me.btPrint.TabIndex = 1
        Me.btPrint.Text = "&P r i n t"
        Me.btPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSave.Location = New System.Drawing.Point(16, 63)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(100, 40)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "&S a v e"
        Me.btSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSave.UseVisualStyleBackColor = True
        '
        'dtpPeriksa
        '
        Me.dtpPeriksa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriksa.Location = New System.Drawing.Point(442, 22)
        Me.dtpPeriksa.Name = "dtpPeriksa"
        Me.dtpPeriksa.Size = New System.Drawing.Size(165, 20)
        Me.dtpPeriksa.TabIndex = 11
        Me.dtpPeriksa.Value = New Date(2009, 11, 1, 0, 0, 0, 0)
        '
        'txtDiagnosa
        '
        Me.txtDiagnosa.Location = New System.Drawing.Point(156, 112)
        Me.txtDiagnosa.Name = "txtDiagnosa"
        Me.txtDiagnosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDiagnosa.Size = New System.Drawing.Size(451, 20)
        Me.txtDiagnosa.TabIndex = 10
        '
        'txtNama_dok
        '
        Me.txtNama_dok.Location = New System.Drawing.Point(317, 82)
        Me.txtNama_dok.Name = "txtNama_dok"
        Me.txtNama_dok.Size = New System.Drawing.Size(290, 20)
        Me.txtNama_dok.TabIndex = 9
        '
        'txtNama_pas
        '
        Me.txtNama_pas.Location = New System.Drawing.Point(317, 54)
        Me.txtNama_pas.Name = "txtNama_pas"
        Me.txtNama_pas.Size = New System.Drawing.Size(290, 20)
        Me.txtNama_pas.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(314, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tanggal Periksa"
        '
        'txtNoRM
        '
        Me.txtNoRM.Location = New System.Drawing.Point(156, 27)
        Me.txtNoRM.Name = "txtNoRM"
        Me.txtNoRM.Size = New System.Drawing.Size(124, 20)
        Me.txtNoRM.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(13, 112)
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
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode - Nama Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(13, 52)
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
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Rekam Medis"
        '
        'FormDiagnosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 782)
        Me.Controls.Add(Me.PanelLuar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDiagnosa"
        Me.ShowInTaskbar = False
        Me.Text = "FormDiagnosa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLuar.ResumeLayout(False)
        Me.PanelLuar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewObat As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoRM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriksa As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_dok As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_pas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btPrint As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btCariDokter As System.Windows.Forms.Button
    Friend WithEvents btCariPasien As System.Windows.Forms.Button
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents txtDiBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtPajak As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtKembali As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtBiaya_obat As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtBanyak As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_obat As System.Windows.Forms.TextBox
    Friend WithEvents txtKode_obat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btCariObat As System.Windows.Forms.Button
    Friend WithEvents txtKode_dok As System.Windows.Forms.TextBox
    Friend WithEvents txtKode_pas As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtBiaya_periksa As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btKeListView As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
End Class
