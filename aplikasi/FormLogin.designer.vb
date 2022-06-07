<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PanelLuar = New System.Windows.Forms.Panel()
        Me.txtNamaUser = New System.Windows.Forms.ComboBox()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLogin = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelLuar.SuspendLayout()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLuar
        '
        Me.PanelLuar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelLuar.Controls.Add(Me.txtNamaUser)
        Me.PanelLuar.Controls.Add(Me.btCancel)
        Me.PanelLuar.Controls.Add(Me.btLogin)
        Me.PanelLuar.Controls.Add(Me.Label3)
        Me.PanelLuar.Controls.Add(Me.Label2)
        Me.PanelLuar.Controls.Add(Me.txtPassword)
        Me.PanelLuar.Controls.Add(Me.Label4)
        Me.PanelLuar.Controls.Add(Me.Label1)
        Me.PanelLuar.Controls.Add(Me.picLogin)
        Me.PanelLuar.Location = New System.Drawing.Point(422, 189)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(443, 285)
        Me.PanelLuar.TabIndex = 0
        '
        'txtNamaUser
        '
        Me.txtNamaUser.FormattingEnabled = True
        Me.txtNamaUser.Location = New System.Drawing.Point(218, 59)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.Size = New System.Drawing.Size(187, 21)
        Me.txtNamaUser.TabIndex = 9
        Me.txtNamaUser.Text = "- pilih pengguna -"
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Image = CType(resources.GetObject("btCancel.Image"), System.Drawing.Image)
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCancel.Location = New System.Drawing.Point(319, 145)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(88, 44)
        Me.btCancel.TabIndex = 8
        Me.btCancel.Text = "&C a n c e l"
        Me.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btLogin
        '
        Me.btLogin.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Image = CType(resources.GetObject("btLogin.Image"), System.Drawing.Image)
        Me.btLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btLogin.Location = New System.Drawing.Point(220, 145)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(88, 44)
        Me.btLogin.TabIndex = 7
        Me.btLogin.Text = "&L o g i n"
        Me.btLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "P a s s w o r d"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Pegawai"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(218, 95)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(126)
        Me.txtPassword.Size = New System.Drawing.Size(187, 20)
        Me.txtPassword.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(3, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(438, 2)
        Me.Label4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Log-In Sistem"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picLogin
        '
        Me.picLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogin.Image = CType(resources.GetObject("picLogin.Image"), System.Drawing.Image)
        Me.picLogin.Location = New System.Drawing.Point(0, 0)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(439, 281)
        Me.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogin.TabIndex = 0
        Me.picLogin.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.ForestGreen
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1007, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Log-In Sistem"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1007, 612)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PanelLuar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginSistem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLuar.ResumeLayout(False)
        Me.PanelLuar.PerformLayout()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNamaUser As System.Windows.Forms.ComboBox
    Friend WithEvents picLogin As System.Windows.Forms.PictureBox
End Class
