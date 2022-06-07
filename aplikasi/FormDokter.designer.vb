<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDokter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDokter))
        Me.txtKode_dok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.cbSpesialis = New System.Windows.Forms.ComboBox()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKelamin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama_dok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.DataGridDokter = New System.Windows.Forms.DataGridView()
        Me.rbNama_dokter = New System.Windows.Forms.RadioButton()
        Me.rbKode_dokter = New System.Windows.Forms.RadioButton()
        Me.btCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.PanelLuar = New System.Windows.Forms.Panel()
        Me.pnData.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.PanelLuar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKode_dok
        '
        Me.txtKode_dok.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKode_dok.Location = New System.Drawing.Point(206, 31)
        Me.txtKode_dok.Name = "txtKode_dok"
        Me.txtKode_dok.Size = New System.Drawing.Size(294, 20)
        Me.txtKode_dok.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Kota - Telepon (rm|hp)"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(441, 218)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(224, 20)
        Me.txtTelepon.TabIndex = 14
        '
        'cbSpesialis
        '
        Me.cbSpesialis.FormattingEnabled = True
        Me.cbSpesialis.Items.AddRange(New Object() {"Anak", "Bedah", "G i g i", "Kandungan", "Umum", "T.H.T."})
        Me.cbSpesialis.Location = New System.Drawing.Point(206, 110)
        Me.cbSpesialis.Name = "cbSpesialis"
        Me.cbSpesialis.Size = New System.Drawing.Size(294, 21)
        Me.cbSpesialis.TabIndex = 13
        Me.cbSpesialis.Text = "-- pilih --"
        '
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnData.Controls.Add(Me.txtEmail)
        Me.pnData.Controls.Add(Me.Label8)
        Me.pnData.Controls.Add(Me.Panel3)
        Me.pnData.Controls.Add(Me.Label1)
        Me.pnData.Controls.Add(Me.cbKelamin)
        Me.pnData.Controls.Add(Me.txtKode_dok)
        Me.pnData.Controls.Add(Me.Label7)
        Me.pnData.Controls.Add(Me.Label5)
        Me.pnData.Controls.Add(Me.txtTelepon)
        Me.pnData.Controls.Add(Me.cbSpesialis)
        Me.pnData.Controls.Add(Me.txtKota)
        Me.pnData.Controls.Add(Me.txtAlamat)
        Me.pnData.Controls.Add(Me.txtNama_dok)
        Me.pnData.Controls.Add(Me.Label4)
        Me.pnData.Controls.Add(Me.Label6)
        Me.pnData.Controls.Add(Me.Label3)
        Me.pnData.Controls.Add(Me.Label2)
        Me.pnData.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnData.Location = New System.Drawing.Point(0, 0)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(684, 252)
        Me.pnData.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(206, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(294, 20)
        Me.txtEmail.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Email"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(506, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(159, 179)
        Me.Panel3.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(682, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ".: Entri Data Dokter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbKelamin
        '
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cbKelamin.Location = New System.Drawing.Point(206, 83)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(294, 21)
        Me.cbKelamin.TabIndex = 21
        Me.cbKelamin.Text = "-- pilih --"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "S p e s i a l i s"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(204, 218)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(231, 20)
        Me.txtKota.TabIndex = 12
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(206, 137)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(294, 47)
        Me.txtAlamat.TabIndex = 7
        '
        'txtNama_dok
        '
        Me.txtNama_dok.Location = New System.Drawing.Point(206, 57)
        Me.txtNama_dok.Name = "txtNama_dok"
        Me.txtNama_dok.Size = New System.Drawing.Size(294, 20)
        Me.txtNama_dok.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "A l a m a t"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Dokter"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Dokter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btRefresh)
        Me.GroupBox1.Controls.Add(Me.DataGridDokter)
        Me.GroupBox1.Controls.Add(Me.rbNama_dokter)
        Me.GroupBox1.Controls.Add(Me.rbKode_dokter)
        Me.GroupBox1.Controls.Add(Me.btCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 249)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRefresh.Location = New System.Drawing.Point(559, 5)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(119, 36)
        Me.btRefresh.TabIndex = 6
        Me.btRefresh.Text = "&Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'DataGridDokter
        '
        Me.DataGridDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDokter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridDokter.Location = New System.Drawing.Point(3, 79)
        Me.DataGridDokter.Name = "DataGridDokter"
        Me.DataGridDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDokter.Size = New System.Drawing.Size(678, 167)
        Me.DataGridDokter.TabIndex = 5
        '
        'rbNama_dokter
        '
        Me.rbNama_dokter.AutoSize = True
        Me.rbNama_dokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNama_dokter.Location = New System.Drawing.Point(284, 24)
        Me.rbNama_dokter.Name = "rbNama_dokter"
        Me.rbNama_dokter.Size = New System.Drawing.Size(99, 17)
        Me.rbNama_dokter.TabIndex = 4
        Me.rbNama_dokter.TabStop = True
        Me.rbNama_dokter.Text = "Nama Dokter"
        Me.rbNama_dokter.UseVisualStyleBackColor = True
        '
        'rbKode_dokter
        '
        Me.rbKode_dokter.AutoSize = True
        Me.rbKode_dokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKode_dokter.Location = New System.Drawing.Point(284, 5)
        Me.rbKode_dokter.Name = "rbKode_dokter"
        Me.rbKode_dokter.Size = New System.Drawing.Size(96, 17)
        Me.rbKode_dokter.TabIndex = 3
        Me.rbKode_dokter.TabStop = True
        Me.rbKode_dokter.Text = "Kode Dokter"
        Me.rbKode_dokter.UseVisualStyleBackColor = True
        '
        'btCari
        '
        Me.btCari.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCari.Image = CType(resources.GetObject("btCari.Image"), System.Drawing.Image)
        Me.btCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCari.Location = New System.Drawing.Point(442, 5)
        Me.btCari.Name = "btCari"
        Me.btCari.Size = New System.Drawing.Size(111, 36)
        Me.btCari.TabIndex = 2
        Me.btCari.Text = "&Search"
        Me.btCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(152, 13)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(119, 30)
        Me.txtCari.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bradley Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kunci Pencarian"
        '
        'btExit
        '
        Me.btExit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.Image = CType(resources.GetObject("btExit.Image"), System.Drawing.Image)
        Me.btExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btExit.Location = New System.Drawing.Point(391, 3)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(82, 50)
        Me.btExit.TabIndex = 3
        Me.btExit.Text = "E&xit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btDelete.Location = New System.Drawing.Point(313, 3)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 50)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "&Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btAdd.Location = New System.Drawing.Point(3, 3)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 50)
        Me.btAdd.TabIndex = 19
        Me.btAdd.Text = "&Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.BindingNavigator1)
        Me.Panel4.Controls.Add(Me.btEdit)
        Me.Panel4.Controls.Add(Me.btCancel)
        Me.Panel4.Controls.Add(Me.btAdd)
        Me.Panel4.Controls.Add(Me.btExit)
        Me.Panel4.Controls.Add(Me.btDelete)
        Me.Panel4.Controls.Add(Me.btSave)
        Me.Panel4.Controls.Add(Me.btUpdate)
        Me.Panel4.Location = New System.Drawing.Point(0, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(684, 67)
        Me.Panel4.TabIndex = 2
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(479, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(197, 49)
        Me.BindingNavigator1.TabIndex = 22
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 46)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 46)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 46)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 49)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 49)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 46)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'btEdit
        '
        Me.btEdit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Image = CType(resources.GetObject("btEdit.Image"), System.Drawing.Image)
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btEdit.Location = New System.Drawing.Point(235, 3)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 50)
        Me.btEdit.TabIndex = 1
        Me.btEdit.Text = "&Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Image = CType(resources.GetObject("btCancel.Image"), System.Drawing.Image)
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCancel.Location = New System.Drawing.Point(158, 3)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 50)
        Me.btCancel.TabIndex = 20
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSave.Location = New System.Drawing.Point(80, 3)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 50)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "&Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btUpdate
        '
        Me.btUpdate.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdate.Image = CType(resources.GetObject("btUpdate.Image"), System.Drawing.Image)
        Me.btUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btUpdate.Location = New System.Drawing.Point(234, 2)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 50)
        Me.btUpdate.TabIndex = 21
        Me.btUpdate.Text = "&Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'PanelLuar
        '
        Me.PanelLuar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelLuar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLuar.Controls.Add(Me.GroupBox1)
        Me.PanelLuar.Controls.Add(Me.pnData)
        Me.PanelLuar.Controls.Add(Me.Panel4)
        Me.PanelLuar.Location = New System.Drawing.Point(279, 65)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(686, 582)
        Me.PanelLuar.TabIndex = 6
        '
        'FormDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 578)
        Me.Controls.Add(Me.PanelLuar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDokter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnData.ResumeLayout(False)
        Me.pnData.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.PanelLuar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtKode_dok As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents cbSpesialis As System.Windows.Forms.ComboBox
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents cbKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_dok As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNama_dokter As System.Windows.Forms.RadioButton
    Friend WithEvents rbKode_dokter As System.Windows.Forms.RadioButton
    Friend WithEvents btCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents DataGridDokter As System.Windows.Forms.DataGridView
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
