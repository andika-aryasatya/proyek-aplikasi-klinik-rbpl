<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frDaftarObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frDaftarObat))
        Me.btClose = New System.Windows.Forms.Button
        Me.btCariObat = New System.Windows.Forms.Button
        Me.btRefresh = New System.Windows.Forms.Button
        Me.txtCariObat = New System.Windows.Forms.TextBox
        Me.rbNama_Obat = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbKode_Obat = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridObat = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btClose
        '
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(112, 16)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(90, 72)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "&Close"
        '
        'btCariObat
        '
        Me.btCariObat.Image = CType(resources.GetObject("btCariObat.Image"), System.Drawing.Image)
        Me.btCariObat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCariObat.Location = New System.Drawing.Point(13, 50)
        Me.btCariObat.Name = "btCariObat"
        Me.btCariObat.Size = New System.Drawing.Size(168, 40)
        Me.btCariObat.TabIndex = 1
        Me.btCariObat.Text = " &C a r i"
        Me.btCariObat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btRefresh
        '
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btRefresh.Location = New System.Drawing.Point(16, 16)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(90, 72)
        Me.btRefresh.TabIndex = 1
        Me.btRefresh.Text = "&Refresh"
        '
        'txtCariObat
        '
        Me.txtCariObat.Location = New System.Drawing.Point(12, 22)
        Me.txtCariObat.Name = "txtCariObat"
        Me.txtCariObat.Size = New System.Drawing.Size(167, 23)
        Me.txtCariObat.TabIndex = 0
        Me.txtCariObat.Text = "txtCari"
        '
        'rbNama_Obat
        '
        Me.rbNama_Obat.Location = New System.Drawing.Point(194, 48)
        Me.rbNama_Obat.Name = "rbNama_Obat"
        Me.rbNama_Obat.Size = New System.Drawing.Size(96, 22)
        Me.rbNama_Obat.TabIndex = 31
        Me.rbNama_Obat.Text = "Nama Obat"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbNama_Obat)
        Me.GroupBox3.Controls.Add(Me.rbKode_Obat)
        Me.GroupBox3.Controls.Add(Me.txtCariObat)
        Me.GroupBox3.Controls.Add(Me.btCariObat)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(252, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 96)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "| P e n c a r i a n |"
        '
        'rbKode_Obat
        '
        Me.rbKode_Obat.Location = New System.Drawing.Point(195, 24)
        Me.rbKode_Obat.Name = "rbKode_Obat"
        Me.rbKode_Obat.Size = New System.Drawing.Size(95, 18)
        Me.rbKode_Obat.TabIndex = 30
        Me.rbKode_Obat.Text = "Kode Obat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btClose)
        Me.GroupBox2.Controls.Add(Me.btRefresh)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 96)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[ Tombol Proses ]"
        '
        'DataGridObat
        '
        Me.DataGridObat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridObat.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridObat.Location = New System.Drawing.Point(20, 49)
        Me.DataGridObat.Name = "DataGridObat"
        Me.DataGridObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridObat.Size = New System.Drawing.Size(528, 179)
        Me.DataGridObat.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Ivory
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 46)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Daftar Obat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frDaftarObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(569, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridObat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frDaftarObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btCariObat As System.Windows.Forms.Button
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents txtCariObat As System.Windows.Forms.TextBox
    Friend WithEvents rbNama_Obat As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbKode_Obat As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridObat As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
