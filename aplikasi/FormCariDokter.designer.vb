<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariDokter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariDokter))
        Me.DataGridDokter = New System.Windows.Forms.DataGridView
        Me.gbData = New System.Windows.Forms.GroupBox
        Me.btClose = New System.Windows.Forms.Button
        Me.btRefresh = New System.Windows.Forms.Button
        Me.rbNama_Dokter = New System.Windows.Forms.RadioButton
        Me.rbKode_Dokter = New System.Windows.Forms.RadioButton
        Me.btCari = New System.Windows.Forms.Button
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        CType(Me.DataGridDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridDokter
        '
        Me.DataGridDokter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridDokter.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridDokter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridDokter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDokter.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridDokter.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridDokter.Location = New System.Drawing.Point(3, 90)
        Me.DataGridDokter.Name = "DataGridDokter"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDokter.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridDokter.RowHeadersWidth = 50
        Me.DataGridDokter.Size = New System.Drawing.Size(696, 342)
        Me.DataGridDokter.TabIndex = 3
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.btClose)
        Me.gbData.Controls.Add(Me.btRefresh)
        Me.gbData.Controls.Add(Me.rbNama_Dokter)
        Me.gbData.Controls.Add(Me.rbKode_Dokter)
        Me.gbData.Controls.Add(Me.btCari)
        Me.gbData.Controls.Add(Me.txtCari)
        Me.gbData.Controls.Add(Me.Label9)
        Me.gbData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbData.Location = New System.Drawing.Point(3, 3)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(696, 81)
        Me.gbData.TabIndex = 2
        Me.gbData.TabStop = False
        Me.gbData.Text = "| Pencarian Data |"
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(577, 16)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(113, 55)
        Me.btClose.TabIndex = 6
        Me.btClose.Text = "&Close"
        Me.btClose.UseVisualStyleBackColor = True
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
        'rbNama_Dokter
        '
        Me.rbNama_Dokter.AutoSize = True
        Me.rbNama_Dokter.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNama_Dokter.Location = New System.Drawing.Point(295, 44)
        Me.rbNama_Dokter.Name = "rbNama_Dokter"
        Me.rbNama_Dokter.Size = New System.Drawing.Size(92, 21)
        Me.rbNama_Dokter.TabIndex = 4
        Me.rbNama_Dokter.TabStop = True
        Me.rbNama_Dokter.Text = "Nama Dokter"
        Me.rbNama_Dokter.UseVisualStyleBackColor = True
        '
        'rbKode_Dokter
        '
        Me.rbKode_Dokter.AutoSize = True
        Me.rbKode_Dokter.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKode_Dokter.Location = New System.Drawing.Point(295, 20)
        Me.rbKode_Dokter.Name = "rbKode_Dokter"
        Me.rbKode_Dokter.Size = New System.Drawing.Size(89, 21)
        Me.rbKode_Dokter.TabIndex = 3
        Me.rbKode_Dokter.TabStop = True
        Me.rbKode_Dokter.Text = "Kode Dokter"
        Me.rbKode_Dokter.UseVisualStyleBackColor = True
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
        Me.txtCari.Location = New System.Drawing.Point(141, 27)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(130, 30)
        Me.txtCari.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kunci Pencarian"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.gbData)
        Me.FlowLayoutPanel1.Controls.Add(Me.DataGridDokter)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(699, 432)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FormCariDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 436)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "FormCariDokter"
        Me.Text = "FormCariDokter"
        CType(Me.DataGridDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridDokter As System.Windows.Forms.DataGridView
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents rbNama_Dokter As System.Windows.Forms.RadioButton
    Friend WithEvents rbKode_Dokter As System.Windows.Forms.RadioButton
    Friend WithEvents btCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
