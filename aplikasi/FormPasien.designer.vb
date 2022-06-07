<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasien))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.cbPekerjaan = New System.Windows.Forms.ComboBox()
        Me.cbKelamin = New System.Windows.Forms.ComboBox()
        Me.txtKtp = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.txtNama_Pasien = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtKode_Pasien = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbNavigasi = New System.Windows.Forms.GroupBox()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewPasien = New System.Windows.Forms.DataGridView()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.rbNama_Pasien = New System.Windows.Forms.RadioButton()
        Me.rbKode_Pasien = New System.Windows.Forms.RadioButton()
        Me.btCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNavigasi.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(238, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(720, 510)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtKota)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.BindingNavigator1)
        Me.TabPage1.Controls.Add(Me.cbPekerjaan)
        Me.TabPage1.Controls.Add(Me.cbKelamin)
        Me.TabPage1.Controls.Add(Me.txtKtp)
        Me.TabPage1.Controls.Add(Me.txtTelepon)
        Me.TabPage1.Controls.Add(Me.txtAlamat)
        Me.TabPage1.Controls.Add(Me.txtUsia)
        Me.TabPage1.Controls.Add(Me.txtNama_Pasien)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.txtKode_Pasien)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.gbNavigasi)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(712, 484)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(224, 339)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(409, 22)
        Me.txtEmail.TabIndex = 24
        '
        'txtKota
        '
        Me.txtKota.BackColor = System.Drawing.Color.White
        Me.txtKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(224, 301)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(227, 22)
        Me.txtKota.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "K o t a | Telpon"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(338, 26)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(295, 23)
        Me.BindingNavigator1.TabIndex = 12
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 29)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 29)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 32)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 29)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 29)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'cbPekerjaan
        '
        Me.cbPekerjaan.BackColor = System.Drawing.Color.White
        Me.cbPekerjaan.FormattingEnabled = True
        Me.cbPekerjaan.Items.AddRange(New Object() {"Pegawai Negeri", "Pegawai Swasta", "D o s e n", "Wiraswasta", "Petani", "Lain-lain"})
        Me.cbPekerjaan.Location = New System.Drawing.Point(226, 156)
        Me.cbPekerjaan.Name = "cbPekerjaan"
        Me.cbPekerjaan.Size = New System.Drawing.Size(225, 21)
        Me.cbPekerjaan.TabIndex = 21
        Me.cbPekerjaan.Text = "-- pilih --"
        '
        'cbKelamin
        '
        Me.cbKelamin.BackColor = System.Drawing.Color.White
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Items.AddRange(New Object() {"P r i a", "Wanita"})
        Me.cbKelamin.Location = New System.Drawing.Point(226, 91)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(225, 21)
        Me.cbKelamin.TabIndex = 20
        Me.cbKelamin.Text = "-- pilih --"
        '
        'txtKtp
        '
        Me.txtKtp.BackColor = System.Drawing.Color.White
        Me.txtKtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKtp.Location = New System.Drawing.Point(226, 192)
        Me.txtKtp.Name = "txtKtp"
        Me.txtKtp.Size = New System.Drawing.Size(225, 22)
        Me.txtKtp.TabIndex = 19
        '
        'txtTelepon
        '
        Me.txtTelepon.BackColor = System.Drawing.Color.White
        Me.txtTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelepon.Location = New System.Drawing.Point(459, 302)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(174, 22)
        Me.txtTelepon.TabIndex = 18
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.Color.White
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(226, 228)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(407, 55)
        Me.txtAlamat.TabIndex = 17
        '
        'txtUsia
        '
        Me.txtUsia.BackColor = System.Drawing.Color.White
        Me.txtUsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsia.Location = New System.Drawing.Point(226, 122)
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(225, 22)
        Me.txtUsia.TabIndex = 15
        '
        'txtNama_Pasien
        '
        Me.txtNama_Pasien.BackColor = System.Drawing.Color.White
        Me.txtNama_Pasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama_Pasien.Location = New System.Drawing.Point(226, 60)
        Me.txtNama_Pasien.Name = "txtNama_Pasien"
        Me.txtNama_Pasien.Size = New System.Drawing.Size(225, 22)
        Me.txtNama_Pasien.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(482, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txtKode_Pasien
        '
        Me.txtKode_Pasien.BackColor = System.Drawing.Color.White
        Me.txtKode_Pasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode_Pasien.Location = New System.Drawing.Point(226, 27)
        Me.txtKode_Pasien.Name = "txtKode_Pasien"
        Me.txtKode_Pasien.Size = New System.Drawing.Size(100, 22)
        Me.txtKode_Pasien.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 28)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "No. KTP"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E m a i l"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "P e k e r j a a n"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "A l a m a t"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Usia Sekarang"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pasien"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Pasien"
        '
        'gbNavigasi
        '
        Me.gbNavigasi.Controls.Add(Me.btEdit)
        Me.gbNavigasi.Controls.Add(Me.btExit)
        Me.gbNavigasi.Controls.Add(Me.btDelete)
        Me.gbNavigasi.Controls.Add(Me.btCancel)
        Me.gbNavigasi.Controls.Add(Me.btSave)
        Me.gbNavigasi.Controls.Add(Me.btAdd)
        Me.gbNavigasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbNavigasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbNavigasi.Location = New System.Drawing.Point(3, 391)
        Me.gbNavigasi.Name = "gbNavigasi"
        Me.gbNavigasi.Size = New System.Drawing.Size(702, 86)
        Me.gbNavigasi.TabIndex = 0
        Me.gbNavigasi.TabStop = False
        Me.gbNavigasi.Text = "GroupBox1"
        '
        'btEdit
        '
        Me.btEdit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btEdit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.ForeColor = System.Drawing.Color.White
        Me.btEdit.Image = CType(resources.GetObject("btEdit.Image"), System.Drawing.Image)
        Me.btEdit.Location = New System.Drawing.Point(179, 19)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(55, 61)
        Me.btEdit.TabIndex = 11
        Me.btEdit.Text = "&Edit"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btEdit.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btExit.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.ForeColor = System.Drawing.Color.White
        Me.btExit.Image = CType(resources.GetObject("btExit.Image"), System.Drawing.Image)
        Me.btExit.Location = New System.Drawing.Point(296, 19)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(55, 61)
        Me.btExit.TabIndex = 5
        Me.btExit.Text = "E &x i t"
        Me.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btExit.UseVisualStyleBackColor = False
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btDelete.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.ForeColor = System.Drawing.Color.White
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.Location = New System.Drawing.Point(238, 19)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(55, 61)
        Me.btDelete.TabIndex = 4
        Me.btDelete.Text = "&Delete"
        Me.btDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btCancel.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.ForeColor = System.Drawing.Color.White
        Me.btCancel.Image = CType(resources.GetObject("btCancel.Image"), System.Drawing.Image)
        Me.btCancel.Location = New System.Drawing.Point(121, 19)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(55, 61)
        Me.btCancel.TabIndex = 2
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btSave.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.ForeColor = System.Drawing.Color.White
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.Location = New System.Drawing.Point(63, 19)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(55, 61)
        Me.btSave.TabIndex = 1
        Me.btSave.Text = "&Save"
        Me.btSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSave.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btAdd.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.Color.White
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(6, 19)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(55, 61)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "&Add"
        Me.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.DataGridViewPasien)
        Me.TabPage2.Controls.Add(Me.gbData)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(712, 484)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewPasien
        '
        Me.DataGridViewPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridViewPasien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewPasien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewPasien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPasien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPasien.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewPasien.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewPasien.Location = New System.Drawing.Point(3, 154)
        Me.DataGridViewPasien.Name = "DataGridViewPasien"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPasien.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewPasien.RowHeadersWidth = 50
        Me.DataGridViewPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPasien.Size = New System.Drawing.Size(702, 323)
        Me.DataGridViewPasien.TabIndex = 1
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.btRefresh)
        Me.gbData.Controls.Add(Me.rbNama_Pasien)
        Me.gbData.Controls.Add(Me.rbKode_Pasien)
        Me.gbData.Controls.Add(Me.btCari)
        Me.gbData.Controls.Add(Me.txtCari)
        Me.gbData.Controls.Add(Me.Label9)
        Me.gbData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbData.Location = New System.Drawing.Point(3, 3)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(702, 81)
        Me.gbData.TabIndex = 0
        Me.gbData.TabStop = False
        Me.gbData.Text = "GroupBox1"
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btRefresh.Location = New System.Drawing.Point(491, 15)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(80, 55)
        Me.btRefresh.TabIndex = 5
        Me.btRefresh.Text = "&Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'rbNama_Pasien
        '
        Me.rbNama_Pasien.AutoSize = True
        Me.rbNama_Pasien.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNama_Pasien.Location = New System.Drawing.Point(295, 44)
        Me.rbNama_Pasien.Name = "rbNama_Pasien"
        Me.rbNama_Pasien.Size = New System.Drawing.Size(89, 21)
        Me.rbNama_Pasien.TabIndex = 4
        Me.rbNama_Pasien.TabStop = True
        Me.rbNama_Pasien.Text = "Nama Pasien"
        Me.rbNama_Pasien.UseVisualStyleBackColor = True
        '
        'rbKode_Pasien
        '
        Me.rbKode_Pasien.AutoSize = True
        Me.rbKode_Pasien.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKode_Pasien.Location = New System.Drawing.Point(295, 20)
        Me.rbKode_Pasien.Name = "rbKode_Pasien"
        Me.rbKode_Pasien.Size = New System.Drawing.Size(86, 21)
        Me.rbKode_Pasien.TabIndex = 3
        Me.rbKode_Pasien.TabStop = True
        Me.rbKode_Pasien.Text = "Kode Pasien"
        Me.rbKode_Pasien.UseVisualStyleBackColor = True
        '
        'btCari
        '
        Me.btCari.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCari.Image = CType(resources.GetObject("btCari.Image"), System.Drawing.Image)
        Me.btCari.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCari.Location = New System.Drawing.Point(407, 16)
        Me.btCari.Name = "btCari"
        Me.btCari.Size = New System.Drawing.Size(80, 55)
        Me.btCari.TabIndex = 2
        Me.btCari.Text = "&Search"
        Me.btCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(173, 29)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(110, 30)
        Me.txtCari.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 27)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kunci Pencarian"
        '
        'FormPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 576)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNavigasi.ResumeLayout(False)
        Me.gbNavigasi.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cbPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents cbKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents txtKtp As System.Windows.Forms.TextBox
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtUsia As System.Windows.Forms.TextBox
    Friend WithEvents txtNama_Pasien As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtKode_Pasien As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbNavigasi As System.Windows.Forms.GroupBox
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewPasien As System.Windows.Forms.DataGridView
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents rbNama_Pasien As System.Windows.Forms.RadioButton
    Friend WithEvents rbKode_Pasien As System.Windows.Forms.RadioButton
    Friend WithEvents btCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
