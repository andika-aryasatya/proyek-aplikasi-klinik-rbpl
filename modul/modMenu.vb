Module modMenu
    Sub FormLoad()
        With frMenuMedical
            .ControlBox = False
            .Text = ":: APLIKASI SISTEM BASIS DATA REKAM MEDIS ::"
            .WindowState = FormWindowState.Maximized
            .tsPilihan.Text = "pilihan melalui ShortCutKey (icon)"
            .tsPilihan.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .tsPilihan.ForeColor = Color.Yellow 'LimeGreen
            .iconMenuMedical.BackColor = Color.SeaGreen
            .statusMenuMedical.BackColor = Color.SeaGreen
            .tssBy.ForeColor = Color.GhostWhite
        End With
    End Sub
End Module
