<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObat))
        Me.txtKode_Obat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbKemasan = New System.Windows.Forms.ComboBox()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.txtJumlah_harga = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picObat = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama_Obat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.rbNama_obat = New System.Windows.Forms.RadioButton()
        Me.rbKode_obat = New System.Windows.Forms.RadioButton()
        Me.btCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelLuar = New System.Windows.Forms.Panel()
        Me.DataGridViewObat = New System.Windows.Forms.DataGridView()
        Me.pnData.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelLuar.SuspendLayout()
        CType(Me.DataGridViewObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKode_Obat
        '
        Me.txtKode_Obat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKode_Obat.Location = New System.Drawing.Point(209, 32)
        Me.txtKode_Obat.Name = "txtKode_Obat"
        Me.txtKode_Obat.Size = New System.Drawing.Size(230, 20)
        Me.txtKode_Obat.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Jumlah - Harga Obat"
        '
        'cbKemasan
        '
        Me.cbKemasan.FormattingEnabled = True
        Me.cbKemasan.Items.AddRange(New Object() {"Botol", "Butir", "Buah", "Box", "Dus", "Tablet"})
        Me.cbKemasan.Location = New System.Drawing.Point(209, 113)
        Me.cbKemasan.Name = "cbKemasan"
        Me.cbKemasan.Size = New System.Drawing.Size(230, 21)
        Me.cbKemasan.TabIndex = 4
        Me.cbKemasan.Text = "-- pilih --"
        '
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.Color.CadetBlue
        Me.pnData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnData.Controls.Add(Me.BindingNavigator1)
        Me.pnData.Controls.Add(Me.txtCounter)
        Me.pnData.Controls.Add(Me.txtJumlah_harga)
        Me.pnData.Controls.Add(Me.txtHarga)
        Me.pnData.Controls.Add(Me.txtJumlah)
        Me.pnData.Controls.Add(Me.btClose)
        Me.pnData.Controls.Add(Me.btEdit)
        Me.pnData.Controls.Add(Me.Label8)
        Me.pnData.Controls.Add(Me.btUpdate)
        Me.pnData.Controls.Add(Me.btCancel)
        Me.pnData.Controls.Add(Me.btAdd)
        Me.pnData.Controls.Add(Me.btDelete)
        Me.pnData.Controls.Add(Me.Panel3)
        Me.pnData.Controls.Add(Me.btSave)
        Me.pnData.Controls.Add(Me.Label1)
        Me.pnData.Controls.Add(Me.cbJenis)
        Me.pnData.Controls.Add(Me.txtKode_Obat)
        Me.pnData.Controls.Add(Me.Label7)
        Me.pnData.Controls.Add(Me.Label6)
        Me.pnData.Controls.Add(Me.cbKemasan)
        Me.pnData.Controls.Add(Me.txtNama_Obat)
        Me.pnData.Controls.Add(Me.Label5)
        Me.pnData.Controls.Add(Me.Label4)
        Me.pnData.Controls.Add(Me.Label2)
        Me.pnData.Location = New System.Drawing.Point(0, 175)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(608, 276)
        Me.pnData.TabIndex = 30
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(377, 220)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(229, 47)
        Me.BindingNavigator1.TabIndex = 32
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 44)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 44)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 47)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 44)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'txtCounter
        '
        Me.txtCounter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCounter.Location = New System.Drawing.Point(53, 191)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.Size = New System.Drawing.Size(55, 20)
        Me.txtCounter.TabIndex = 31
        Me.txtCounter.Visible = False
        '
        'txtJumlah_harga
        '
        Me.txtJumlah_harga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJumlah_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah_harga.Location = New System.Drawing.Point(209, 169)
        Me.txtJumlah_harga.Name = "txtJumlah_harga"
        Me.txtJumlah_harga.Size = New System.Drawing.Size(230, 29)
        Me.txtJumlah_harga.TabIndex = 30
        Me.txtJumlah_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHarga
        '
        Me.txtHarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHarga.Location = New System.Drawing.Point(328, 140)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(113, 20)
        Me.txtHarga.TabIndex = 29
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJumlah
        '
        Me.txtJumlah.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJumlah.Location = New System.Drawing.Point(209, 141)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(113, 20)
        Me.txtJumlah.TabIndex = 28
        Me.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(309, 217)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(65, 50)
        Me.btClose.TabIndex = 14
        Me.btClose.Text = "E&xit"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Image = CType(resources.GetObject("btEdit.Image"), System.Drawing.Image)
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btEdit.Location = New System.Drawing.Point(189, 217)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(60, 50)
        Me.btEdit.TabIndex = 11
        Me.btEdit.Text = "&Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Jumlah Harga Obat"
        '
        'btUpdate
        '
        Me.btUpdate.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdate.Image = CType(resources.GetObject("btUpdate.Image"), System.Drawing.Image)
        Me.btUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btUpdate.Location = New System.Drawing.Point(189, 217)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(60, 50)
        Me.btUpdate.TabIndex = 12
        Me.btUpdate.Text = "&Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Image = CType(resources.GetObject("btCancel.Image"), System.Drawing.Image)
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCancel.Location = New System.Drawing.Point(129, 217)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(60, 50)
        Me.btCancel.TabIndex = 10
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btAdd.Location = New System.Drawing.Point(9, 217)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(60, 50)
        Me.btAdd.TabIndex = 8
        Me.btAdd.Text = "&Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btDelete.Location = New System.Drawing.Point(249, 217)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(60, 50)
        Me.btDelete.TabIndex = 13
        Me.btDelete.Text = "&Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.picObat)
        Me.Panel3.Location = New System.Drawing.Point(453, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(144, 137)
        Me.Panel3.TabIndex = 22
        '
        'picObat
        '
        Me.picObat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picObat.Image = CType(resources.GetObject("picObat.Image"), System.Drawing.Image)
        Me.picObat.Location = New System.Drawing.Point(0, 0)
        Me.picObat.Name = "picObat"
        Me.picObat.Size = New System.Drawing.Size(144, 137)
        Me.picObat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObat.TabIndex = 0
        Me.picObat.TabStop = False
        '
        'btSave
        '
        Me.btSave.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSave.Location = New System.Drawing.Point(69, 217)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(60, 50)
        Me.btSave.TabIndex = 9
        Me.btSave.Text = "&Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ".: Entri Data Master Obat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Generic", "Non Generic"})
        Me.cbJenis.Location = New System.Drawing.Point(209, 86)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(230, 21)
        Me.cbJenis.TabIndex = 3
        Me.cbJenis.Text = "-- pilih --"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Kemasan Obat"
        '
        'txtNama_Obat
        '
        Me.txtNama_Obat.Location = New System.Drawing.Point(209, 60)
        Me.txtNama_Obat.Name = "txtNama_Obat"
        Me.txtNama_Obat.Size = New System.Drawing.Size(230, 20)
        Me.txtNama_Obat.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jenis Obat"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Obat"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Obat"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.btRefresh)
        Me.GroupBox1.Controls.Add(Me.rbNama_obat)
        Me.GroupBox1.Controls.Add(Me.rbKode_obat)
        Me.GroupBox1.Controls.Add(Me.btCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 453)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 92)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btRefresh.Location = New System.Drawing.Point(512, 29)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(80, 55)
        Me.btRefresh.TabIndex = 23
        Me.btRefresh.Text = "&Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'rbNama_obat
        '
        Me.rbNama_obat.AutoSize = True
        Me.rbNama_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNama_obat.Location = New System.Drawing.Point(284, 61)
        Me.rbNama_obat.Name = "rbNama_obat"
        Me.rbNama_obat.Size = New System.Drawing.Size(88, 17)
        Me.rbNama_obat.TabIndex = 21
        Me.rbNama_obat.TabStop = True
        Me.rbNama_obat.Text = "Nama Obat"
        Me.rbNama_obat.UseVisualStyleBackColor = True
        '
        'rbKode_obat
        '
        Me.rbKode_obat.AutoSize = True
        Me.rbKode_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKode_obat.Location = New System.Drawing.Point(284, 30)
        Me.rbKode_obat.Name = "rbKode_obat"
        Me.rbKode_obat.Size = New System.Drawing.Size(85, 17)
        Me.rbKode_obat.TabIndex = 20
        Me.rbKode_obat.TabStop = True
        Me.rbKode_obat.Text = "Kode Obat"
        Me.rbKode_obat.UseVisualStyleBackColor = True
        '
        'btCari
        '
        Me.btCari.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCari.Image = CType(resources.GetObject("btCari.Image"), System.Drawing.Image)
        Me.btCari.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCari.Location = New System.Drawing.Point(428, 30)
        Me.btCari.Name = "btCari"
        Me.btCari.Size = New System.Drawing.Size(80, 55)
        Me.btCari.TabIndex = 22
        Me.btCari.Text = "&Search"
        Me.btCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(152, 33)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(119, 30)
        Me.txtCari.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bradley Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kunci Pencarian"
        '
        'PanelLuar
        '
        Me.PanelLuar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelLuar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLuar.Controls.Add(Me.DataGridViewObat)
        Me.PanelLuar.Controls.Add(Me.GroupBox1)
        Me.PanelLuar.Controls.Add(Me.pnData)
        Me.PanelLuar.Location = New System.Drawing.Point(348, 75)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(610, 547)
        Me.PanelLuar.TabIndex = 6
        '
        'DataGridViewObat
        '
        Me.DataGridViewObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewObat.Location = New System.Drawing.Point(0, 3)
        Me.DataGridViewObat.Name = "DataGridViewObat"
        Me.DataGridViewObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewObat.Size = New System.Drawing.Size(607, 170)
        Me.DataGridViewObat.TabIndex = 32
        '
        'FormObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 631)
        Me.Controls.Add(Me.PanelLuar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormObat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnData.ResumeLayout(False)
        Me.pnData.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.picObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelLuar.ResumeLayout(False)
        CType(Me.DataGridViewObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtKode_Obat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbKemasan As System.Windows.Forms.ComboBox
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents cbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNama_Obat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents rbNama_obat As System.Windows.Forms.RadioButton
    Friend WithEvents rbKode_obat As System.Windows.Forms.RadioButton
    Friend WithEvents btCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picObat As System.Windows.Forms.PictureBox
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJumlah_harga As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewObat As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
End Class
