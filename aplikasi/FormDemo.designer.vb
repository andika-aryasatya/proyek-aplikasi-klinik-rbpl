<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDemo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDemo))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLuar = New System.Windows.Forms.Panel
        Me.lbNama = New System.Windows.Forms.Label
        Me.btClose = New System.Windows.Forms.Button
        Me.PanelLuar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PanelLuar
        '
        Me.PanelLuar.BackColor = System.Drawing.Color.Transparent
        Me.PanelLuar.Controls.Add(Me.lbNama)
        Me.PanelLuar.Controls.Add(Me.btClose)
        Me.PanelLuar.Location = New System.Drawing.Point(31, 57)
        Me.PanelLuar.Name = "PanelLuar"
        Me.PanelLuar.Size = New System.Drawing.Size(566, 215)
        Me.PanelLuar.TabIndex = 2
        '
        'lbNama
        '
        Me.lbNama.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.Location = New System.Drawing.Point(3, 172)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(431, 31)
        Me.lbNama.TabIndex = 3
        Me.lbNama.Text = ".:maaf aplikasi ini versi demo...!"
        '
        'btClose
        '
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btClose.Location = New System.Drawing.Point(488, 169)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 40)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "&Close"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btClose.UseVisualStyleBackColor = True
        '
        'FormDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 367)
        Me.Controls.Add(Me.PanelLuar)
        Me.Name = "FormDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:Form Demo :."
        Me.PanelLuar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelLuar As System.Windows.Forms.Panel
    Friend WithEvents lbNama As System.Windows.Forms.Label
    Friend WithEvents btClose As System.Windows.Forms.Button
End Class
