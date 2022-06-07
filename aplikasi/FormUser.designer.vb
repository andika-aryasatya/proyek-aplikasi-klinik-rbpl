<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.PanelLogin = New System.Windows.Forms.Panel
        Me.txtIDUser = New System.Windows.Forms.ComboBox
        Me.cbLevelUser = New System.Windows.Forms.ComboBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btClose = New System.Windows.Forms.Button
        Me.btDelete = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNamaUser = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanelLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.txtIDUser)
        Me.PanelLogin.Controls.Add(Me.cbLevelUser)
        Me.PanelLogin.Controls.Add(Me.txtPassword)
        Me.PanelLogin.Controls.Add(Me.Label6)
        Me.PanelLogin.Controls.Add(Me.Label7)
        Me.PanelLogin.Controls.Add(Me.btClose)
        Me.PanelLogin.Controls.Add(Me.btDelete)
        Me.PanelLogin.Controls.Add(Me.btSave)
        Me.PanelLogin.Controls.Add(Me.Label4)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Controls.Add(Me.txtNamaUser)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.PictureBox1)
        Me.PanelLogin.Location = New System.Drawing.Point(361, 189)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(554, 377)
        Me.PanelLogin.TabIndex = 0
        '
        'txtIDUser
        '
        Me.txtIDUser.FormattingEnabled = True
        Me.txtIDUser.Location = New System.Drawing.Point(194, 60)
        Me.txtIDUser.Name = "txtIDUser"
        Me.txtIDUser.Size = New System.Drawing.Size(263, 21)
        Me.txtIDUser.TabIndex = 17
        '
        'cbLevelUser
        '
        Me.cbLevelUser.FormattingEnabled = True
        Me.cbLevelUser.Location = New System.Drawing.Point(194, 168)
        Me.cbLevelUser.Name = "cbLevelUser"
        Me.cbLevelUser.Size = New System.Drawing.Size(263, 21)
        Me.cbLevelUser.TabIndex = 16
        Me.cbLevelUser.Text = "- pilih -"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(194, 131)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtPassword.Size = New System.Drawing.Size(263, 20)
        Me.txtPassword.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.PowderBlue
        Me.Label6.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Level User"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.PowderBlue
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama Pegawai"
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(397, 215)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(60, 44)
        Me.btClose.TabIndex = 11
        Me.btClose.Text = "&Close"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btDelete.Location = New System.Drawing.Point(331, 215)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(60, 44)
        Me.btDelete.TabIndex = 10
        Me.btDelete.Text = "&Delete"
        Me.btDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSave.Location = New System.Drawing.Point(265, 215)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(60, 44)
        Me.btSave.TabIndex = 8
        Me.btSave.Text = "&Save"
        Me.btSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.PowderBlue
        Me.Label4.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "P a s s w o r d"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No.Induk Pegawai"
        '
        'txtNamaUser
        '
        Me.txtNamaUser.Location = New System.Drawing.Point(194, 94)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.Size = New System.Drawing.Size(263, 20)
        Me.txtNamaUser.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(3, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(548, 2)
        Me.Label2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Daftar User Baru"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 377)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.ForestGreen
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1036, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Daftar User Baru"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PanelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginSistem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLogin As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaUser As System.Windows.Forms.TextBox
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents cbLevelUser As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIDUser As System.Windows.Forms.ComboBox
End Class
