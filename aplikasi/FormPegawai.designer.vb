<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPegawai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPegawai))
        Me.PanelLuar = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.DataGridPegawai = New System.Windows.Forms.DataGridView()
        Me.rbNama_peg = New System.Windows.Forms.RadioButton()
        Me.rbnip = New System.Windows.Forms.RadioButton()
        Me.btCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtKtp = New System.Windows.Forms.TextBox()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKelamin = New System.Windows.Forms.ComboBox()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.cbAgama = New System.Windows.Forms.ComboBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama_peg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PanelLuar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnData.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLuar
        '
        Me.PanelLuar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelLuar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLuar.Controls.Add(Me.GroupBox1)
        Me.PanelLuar.Controls.Add(Me.pnData)
        Me.PanelLuar.Controls.Add(Me.Panel4)
        Me.PanelLuar.Location = New System.Drawing.Point(27, 12)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(770, 537)
        Me.PanelLuar.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btRefresh)
        Me.GroupBox1.Controls.Add(Me.DataGridPegawai)
        Me.GroupBox1.Controls.Add(Me.rbNama_peg)
        Me.GroupBox1.Controls.Add(Me.rbnip)
        Me.GroupBox1.Controls.Add(Me.btCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 204)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRefresh.Location = New System.Drawing.Point(502, 17)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(85, 36)
        Me.btRefresh.TabIndex = 6
        Me.btRefresh.Text = "&Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'DataGridPegawai
        '
        Me.DataGridPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPegawai.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridPegawai.Location = New System.Drawing.Point(3, 59)
        Me.DataGridPegawai.Name = "DataGridPegawai"
        Me.DataGridPegawai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPegawai.Size = New System.Drawing.Size(762, 142)
        Me.DataGridPegawai.TabIndex = 5
        '
        'rbNama_peg
        '
        Me.rbNama_peg.AutoSize = True
        Me.rbNama_peg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNama_peg.Location = New System.Drawing.Point(284, 36)
        Me.rbNama_peg.Name = "rbNama_peg"
        Me.rbNama_peg.Size = New System.Drawing.Size(109, 17)
        Me.rbNama_peg.TabIndex = 4
        Me.rbNama_peg.TabStop = True
        Me.rbNama_peg.Text = "Nama Pegawai"
        Me.rbNama_peg.UseVisualStyleBackColor = True
        '
        'rbnip
        '
        Me.rbnip.AutoSize = True
        Me.rbnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnip.Location = New System.Drawing.Point(284, 13)
        Me.rbnip.Name = "rbnip"
        Me.rbnip.Size = New System.Drawing.Size(129, 17)
        Me.rbnip.TabIndex = 3
        Me.rbnip.TabStop = True
        Me.rbnip.Text = "No.Induk Pegawai"
        Me.rbnip.UseVisualStyleBackColor = True
        '
        'btCari
        '
        Me.btCari.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCari.Image = CType(resources.GetObject("btCari.Image"), System.Drawing.Image)
        Me.btCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCari.Location = New System.Drawing.Point(419, 17)
        Me.btCari.Name = "btCari"
        Me.btCari.Size = New System.Drawing.Size(77, 36)
        Me.btCari.TabIndex = 2
        Me.btCari.Text = "&Search"
        Me.btCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(152, 19)
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
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnData.Controls.Add(Me.Label14)
        Me.pnData.Controls.Add(Me.txtJabatan)
        Me.pnData.Controls.Add(Me.Label13)
        Me.pnData.Controls.Add(Me.txtEmail)
        Me.pnData.Controls.Add(Me.txtKtp)
        Me.pnData.Controls.Add(Me.txtUsia)
        Me.pnData.Controls.Add(Me.Label11)
        Me.pnData.Controls.Add(Me.Label12)
        Me.pnData.Controls.Add(Me.Label8)
        Me.pnData.Controls.Add(Me.Label10)
        Me.pnData.Controls.Add(Me.Label1)
        Me.pnData.Controls.Add(Me.cbKelamin)
        Me.pnData.Controls.Add(Me.txtNip)
        Me.pnData.Controls.Add(Me.Label7)
        Me.pnData.Controls.Add(Me.Label5)
        Me.pnData.Controls.Add(Me.txtTelepon)
        Me.pnData.Controls.Add(Me.cbAgama)
        Me.pnData.Controls.Add(Me.txtKota)
        Me.pnData.Controls.Add(Me.txtAlamat)
        Me.pnData.Controls.Add(Me.txtNama_peg)
        Me.pnData.Controls.Add(Me.Label4)
        Me.pnData.Controls.Add(Me.Label6)
        Me.pnData.Controls.Add(Me.Label3)
        Me.pnData.Controls.Add(Me.Label2)
        Me.pnData.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnData.Location = New System.Drawing.Point(0, 0)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(768, 252)
        Me.pnData.TabIndex = 3
        '
        'txtJabatan
        '
        Me.txtJabatan.Location = New System.Drawing.Point(204, 218)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(232, 20)
        Me.txtJabatan.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(37, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "J a b a t a n"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(455, 218)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(273, 20)
        Me.txtEmail.TabIndex = 29
        '
        'txtKtp
        '
        Me.txtKtp.BackColor = System.Drawing.Color.White
        Me.txtKtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKtp.Location = New System.Drawing.Point(206, 188)
        Me.txtKtp.Name = "txtKtp"
        Me.txtKtp.Size = New System.Drawing.Size(230, 22)
        Me.txtKtp.TabIndex = 27
        '
        'txtUsia
        '
        Me.txtUsia.BackColor = System.Drawing.Color.White
        Me.txtUsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsia.Location = New System.Drawing.Point(206, 134)
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(230, 22)
        Me.txtUsia.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(455, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Email"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(455, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "A l a m a t"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 28)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "No. KTP"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ".: Entri Data Pegawai"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbKelamin
        '
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cbKelamin.Location = New System.Drawing.Point(206, 83)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(230, 21)
        Me.cbKelamin.TabIndex = 21
        Me.cbKelamin.Text = "-- pilih --"
        '
        'txtNip
        '
        Me.txtNip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNip.Location = New System.Drawing.Point(206, 31)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(230, 20)
        Me.txtNip.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(455, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "K o t a"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Agama"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(455, 172)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(273, 20)
        Me.txtTelepon.TabIndex = 14
        '
        'cbAgama
        '
        Me.cbAgama.FormattingEnabled = True
        Me.cbAgama.Items.AddRange(New Object() {"Islam", "Protestan", "Katholic", "Hindu", "Budha", "Lain-lain"})
        Me.cbAgama.Location = New System.Drawing.Point(206, 110)
        Me.cbAgama.Name = "cbAgama"
        Me.cbAgama.Size = New System.Drawing.Size(230, 21)
        Me.cbAgama.TabIndex = 13
        Me.cbAgama.Text = "-- pilih --"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(455, 125)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(273, 20)
        Me.txtKota.TabIndex = 12
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(455, 54)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(273, 46)
        Me.txtAlamat.TabIndex = 7
        '
        'txtNama_peg
        '
        Me.txtNama_peg.Location = New System.Drawing.Point(206, 57)
        Me.txtNama_peg.Name = "txtNama_peg"
        Me.txtNama_peg.Size = New System.Drawing.Size(230, 20)
        Me.txtNama_peg.TabIndex = 6
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
        Me.Label6.Text = "Usia"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Pegawai"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No.Induk Pegawai"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btEdit)
        Me.Panel4.Controls.Add(Me.BindingNavigator1)
        Me.Panel4.Controls.Add(Me.btCancel)
        Me.Panel4.Controls.Add(Me.btAdd)
        Me.Panel4.Controls.Add(Me.btExit)
        Me.Panel4.Controls.Add(Me.btDelete)
        Me.Panel4.Controls.Add(Me.btSave)
        Me.Panel4.Location = New System.Drawing.Point(10, 255)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(752, 77)
        Me.Panel4.TabIndex = 2
        '
        'btEdit
        '
        Me.btEdit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Image = CType(resources.GetObject("btEdit.Image"), System.Drawing.Image)
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btEdit.Location = New System.Drawing.Point(238, 12)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 50)
        Me.btEdit.TabIndex = 1
        Me.btEdit.Text = "&Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(491, 12)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(226, 48)
        Me.BindingNavigator1.TabIndex = 33
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 45)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 45)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 45)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 48)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 45)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 45)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Image = CType(resources.GetObject("btCancel.Image"), System.Drawing.Image)
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCancel.Location = New System.Drawing.Point(157, 10)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 50)
        Me.btCancel.TabIndex = 20
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btAdd.Location = New System.Drawing.Point(3, 10)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 50)
        Me.btAdd.TabIndex = 19
        Me.btAdd.Text = "&Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.Image = CType(resources.GetObject("btExit.Image"), System.Drawing.Image)
        Me.btExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btExit.Location = New System.Drawing.Point(400, 12)
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
        Me.btDelete.Location = New System.Drawing.Point(319, 11)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 50)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "&Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSave.Location = New System.Drawing.Point(79, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 50)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "&Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(451, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(162, 19)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Telepon (rm|hp)"
        '
        'FormPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(978, 570)
        Me.Controls.Add(Me.PanelLuar)
        Me.Name = "FormPegawai"
        Me.Text = "FormPegawai"
        Me.PanelLuar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnData.ResumeLayout(False)
        Me.pnData.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents DataGridPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents rbNama_peg As System.Windows.Forms.RadioButton
    Friend WithEvents rbnip As System.Windows.Forms.RadioButton
    Friend WithEvents btCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents txtNip As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents cbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_peg As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKtp As System.Windows.Forms.TextBox
    Friend WithEvents txtUsia As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
