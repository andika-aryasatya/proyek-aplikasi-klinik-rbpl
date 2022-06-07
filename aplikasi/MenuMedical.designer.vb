<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMenuMedical
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMenuMedical))
        Me.statusMenuMedical = New System.Windows.Forms.StatusStrip()
        Me.tssBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssBatas1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuMedical = New System.Windows.Forms.ToolStrip()
        Me.mnSistem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnTambahUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnBackupData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRestoreData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMaster = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnDataPasien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDataDokter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDataObat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnDataPegawai = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStockObat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDiagnosa = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnPemeriksan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnDiagnosaPasien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLaporan = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnLapPasien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLapPasienJK = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLapDokter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLapDokterSpesialis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnLapDiagnosa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLapHasilDiagnosa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLapDiagnosaRekap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTentang = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnTentangPembuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnTentangProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHelp = New System.Windows.Forms.ToolStripButton()
        Me.iconMenuMedical = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPasien = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDokter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbObat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbResep = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHasilDiagnosa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbKeluar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPilihan = New System.Windows.Forms.ToolStripLabel()
        Me.mnLapObat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDaftarObatKemasan = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMenuMedical.SuspendLayout()
        Me.menuMedical.SuspendLayout()
        Me.iconMenuMedical.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusMenuMedical
        '
        Me.statusMenuMedical.BackColor = System.Drawing.Color.SeaGreen
        Me.statusMenuMedical.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssBy, Me.tssBatas1, Me.tssUser})
        Me.statusMenuMedical.Location = New System.Drawing.Point(0, 460)
        Me.statusMenuMedical.Name = "statusMenuMedical"
        Me.statusMenuMedical.Size = New System.Drawing.Size(853, 27)
        Me.statusMenuMedical.TabIndex = 1
        Me.statusMenuMedical.Text = "StatusStrip1"
        '
        'tssBy
        '
        Me.tssBy.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssBy.ForeColor = System.Drawing.Color.LavenderBlush
        Me.tssBy.Name = "tssBy"
        Me.tssBy.Size = New System.Drawing.Size(0, 22)
        '
        'tssBatas1
        '
        Me.tssBatas1.Name = "tssBatas1"
        Me.tssBatas1.Size = New System.Drawing.Size(83, 22)
        Me.tssBatas1.Text = "| Pengguna ->"
        '
        'tssUser
        '
        Me.tssUser.AutoSize = False
        Me.tssUser.BackColor = System.Drawing.Color.Gold
        Me.tssUser.Name = "tssUser"
        Me.tssUser.Size = New System.Drawing.Size(250, 22)
        Me.tssUser.Text = "tidak ada pengguna"
        '
        'menuMedical
        '
        Me.menuMedical.AutoSize = False
        Me.menuMedical.BackColor = System.Drawing.Color.RosyBrown
        Me.menuMedical.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuMedical.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMedical.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuMedical.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSistem, Me.mnMaster, Me.mnDiagnosa, Me.mnLaporan, Me.mnTentang, Me.mnHelp})
        Me.menuMedical.Location = New System.Drawing.Point(0, 0)
        Me.menuMedical.Name = "menuMedical"
        Me.menuMedical.Size = New System.Drawing.Size(85, 460)
        Me.menuMedical.TabIndex = 4
        Me.menuMedical.Text = "ToolStrip1"
        '
        'mnSistem
        '
        Me.mnSistem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLogin, Me.mnLogOut, Me.ToolStripMenuItem1, Me.mnTambahUser, Me.ToolStripMenuItem2, Me.mnBackupData, Me.mnRestoreData, Me.ToolStripMenuItem3, Me.mnKeluar})
        Me.mnSistem.Image = CType(resources.GetObject("mnSistem.Image"), System.Drawing.Image)
        Me.mnSistem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mnSistem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnSistem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnSistem.Name = "mnSistem"
        Me.mnSistem.Size = New System.Drawing.Size(83, 56)
        Me.mnSistem.Text = "&Sistem"
        Me.mnSistem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mnSistem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnSistem.ToolTipText = "Data Sistem"
        '
        'mnLogin
        '
        Me.mnLogin.Image = CType(resources.GetObject("mnLogin.Image"), System.Drawing.Image)
        Me.mnLogin.Name = "mnLogin"
        Me.mnLogin.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnLogin.Size = New System.Drawing.Size(266, 24)
        Me.mnLogin.Text = "Log-&In Sistem"
        '
        'mnLogOut
        '
        Me.mnLogOut.Image = CType(resources.GetObject("mnLogOut.Image"), System.Drawing.Image)
        Me.mnLogOut.Name = "mnLogOut"
        Me.mnLogOut.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnLogOut.Size = New System.Drawing.Size(266, 24)
        Me.mnLogOut.Text = "Log-&Out Sistem"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(263, 6)
        '
        'mnTambahUser
        '
        Me.mnTambahUser.Image = CType(resources.GetObject("mnTambahUser.Image"), System.Drawing.Image)
        Me.mnTambahUser.Name = "mnTambahUser"
        Me.mnTambahUser.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnTambahUser.Size = New System.Drawing.Size(266, 24)
        Me.mnTambahUser.Text = "&Tambah User"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(263, 6)
        '
        'mnBackupData
        '
        Me.mnBackupData.Image = CType(resources.GetObject("mnBackupData.Image"), System.Drawing.Image)
        Me.mnBackupData.Name = "mnBackupData"
        Me.mnBackupData.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnBackupData.Size = New System.Drawing.Size(266, 24)
        Me.mnBackupData.Text = "&Backup Data"
        '
        'mnRestoreData
        '
        Me.mnRestoreData.Image = CType(resources.GetObject("mnRestoreData.Image"), System.Drawing.Image)
        Me.mnRestoreData.Name = "mnRestoreData"
        Me.mnRestoreData.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnRestoreData.Size = New System.Drawing.Size(266, 24)
        Me.mnRestoreData.Text = "&Restore Data"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(263, 6)
        '
        'mnKeluar
        '
        Me.mnKeluar.Image = CType(resources.GetObject("mnKeluar.Image"), System.Drawing.Image)
        Me.mnKeluar.Name = "mnKeluar"
        Me.mnKeluar.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnKeluar.Size = New System.Drawing.Size(266, 24)
        Me.mnKeluar.Text = "&Keluar Dari Aplikasi"
        '
        'mnMaster
        '
        Me.mnMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDataPasien, Me.mnDataDokter, Me.mnDataObat, Me.ToolStripMenuItem4, Me.mnDataPegawai, Me.mnStockObat})
        Me.mnMaster.Image = CType(resources.GetObject("mnMaster.Image"), System.Drawing.Image)
        Me.mnMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mnMaster.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnMaster.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnMaster.Name = "mnMaster"
        Me.mnMaster.Size = New System.Drawing.Size(83, 56)
        Me.mnMaster.Text = "&Master"
        Me.mnMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mnMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnMaster.ToolTipText = "Data Master"
        '
        'mnDataPasien
        '
        Me.mnDataPasien.Image = CType(resources.GetObject("mnDataPasien.Image"), System.Drawing.Image)
        Me.mnDataPasien.Name = "mnDataPasien"
        Me.mnDataPasien.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnDataPasien.Size = New System.Drawing.Size(228, 24)
        Me.mnDataPasien.Text = "Data &Pasien"
        '
        'mnDataDokter
        '
        Me.mnDataDokter.Image = CType(resources.GetObject("mnDataDokter.Image"), System.Drawing.Image)
        Me.mnDataDokter.Name = "mnDataDokter"
        Me.mnDataDokter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnDataDokter.Size = New System.Drawing.Size(228, 24)
        Me.mnDataDokter.Text = "Data &Dokter"
        '
        'mnDataObat
        '
        Me.mnDataObat.Image = CType(resources.GetObject("mnDataObat.Image"), System.Drawing.Image)
        Me.mnDataObat.Name = "mnDataObat"
        Me.mnDataObat.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnDataObat.Size = New System.Drawing.Size(228, 24)
        Me.mnDataObat.Text = "Data &Obat"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(225, 6)
        '
        'mnDataPegawai
        '
        Me.mnDataPegawai.Checked = True
        Me.mnDataPegawai.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnDataPegawai.Image = CType(resources.GetObject("mnDataPegawai.Image"), System.Drawing.Image)
        Me.mnDataPegawai.Name = "mnDataPegawai"
        Me.mnDataPegawai.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnDataPegawai.Size = New System.Drawing.Size(228, 24)
        Me.mnDataPegawai.Text = "Data Pe&gawai"
        '
        'mnStockObat
        '
        Me.mnStockObat.Image = CType(resources.GetObject("mnStockObat.Image"), System.Drawing.Image)
        Me.mnStockObat.Name = "mnStockObat"
        Me.mnStockObat.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnStockObat.Size = New System.Drawing.Size(228, 24)
        Me.mnStockObat.Text = "&Stock Obat"
        '
        'mnDiagnosa
        '
        Me.mnDiagnosa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPemeriksan, Me.ToolStripSeparator8, Me.mnDiagnosaPasien})
        Me.mnDiagnosa.Image = CType(resources.GetObject("mnDiagnosa.Image"), System.Drawing.Image)
        Me.mnDiagnosa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mnDiagnosa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnDiagnosa.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnDiagnosa.Name = "mnDiagnosa"
        Me.mnDiagnosa.Size = New System.Drawing.Size(83, 56)
        Me.mnDiagnosa.Text = "&Diagnosa"
        Me.mnDiagnosa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mnDiagnosa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnDiagnosa.ToolTipText = "Data Diagnosa"
        '
        'mnPemeriksan
        '
        Me.mnPemeriksan.Image = CType(resources.GetObject("mnPemeriksan.Image"), System.Drawing.Image)
        Me.mnPemeriksan.Name = "mnPemeriksan"
        Me.mnPemeriksan.Size = New System.Drawing.Size(192, 24)
        Me.mnPemeriksan.Text = "Diagnosa Pasien"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(189, 6)
        '
        'mnDiagnosaPasien
        '
        Me.mnDiagnosaPasien.Image = CType(resources.GetObject("mnDiagnosaPasien.Image"), System.Drawing.Image)
        Me.mnDiagnosaPasien.Name = "mnDiagnosaPasien"
        Me.mnDiagnosaPasien.Size = New System.Drawing.Size(192, 24)
        Me.mnDiagnosaPasien.Text = "Hasil Diagnosa"
        '
        'mnLaporan
        '
        Me.mnLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLapPasien, Me.mnLapDokter, Me.mnLapObat, Me.ToolStripMenuItem6, Me.mnLapDiagnosa})
        Me.mnLaporan.Image = CType(resources.GetObject("mnLaporan.Image"), System.Drawing.Image)
        Me.mnLaporan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mnLaporan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnLaporan.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnLaporan.Name = "mnLaporan"
        Me.mnLaporan.Size = New System.Drawing.Size(83, 56)
        Me.mnLaporan.Text = "&Laporan"
        Me.mnLaporan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnLaporan.ToolTipText = "Data Laporan"
        '
        'mnLapPasien
        '
        Me.mnLapPasien.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLapPasienJK})
        Me.mnLapPasien.Image = CType(resources.GetObject("mnLapPasien.Image"), System.Drawing.Image)
        Me.mnLapPasien.Name = "mnLapPasien"
        Me.mnLapPasien.Size = New System.Drawing.Size(215, 24)
        Me.mnLapPasien.Text = "Daftar Pasien"
        '
        'mnLapPasienJK
        '
        Me.mnLapPasienJK.Name = "mnLapPasienJK"
        Me.mnLapPasienJK.Size = New System.Drawing.Size(286, 24)
        Me.mnLapPasienJK.Text = "-> Berdasarkan Jenis Kelamin"
        '
        'mnLapDokter
        '
        Me.mnLapDokter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLapDokterSpesialis})
        Me.mnLapDokter.Image = CType(resources.GetObject("mnLapDokter.Image"), System.Drawing.Image)
        Me.mnLapDokter.Name = "mnLapDokter"
        Me.mnLapDokter.Size = New System.Drawing.Size(215, 24)
        Me.mnLapDokter.Text = "Daftar Dokter"
        '
        'mnLapDokterSpesialis
        '
        Me.mnLapDokterSpesialis.Name = "mnLapDokterSpesialis"
        Me.mnLapDokterSpesialis.Size = New System.Drawing.Size(249, 24)
        Me.mnLapDokterSpesialis.Text = "-> Berdasarkan Spesialis"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(212, 6)
        '
        'mnLapDiagnosa
        '
        Me.mnLapDiagnosa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLapHasilDiagnosa, Me.mnLapDiagnosaRekap})
        Me.mnLapDiagnosa.Image = CType(resources.GetObject("mnLapDiagnosa.Image"), System.Drawing.Image)
        Me.mnLapDiagnosa.Name = "mnLapDiagnosa"
        Me.mnLapDiagnosa.Size = New System.Drawing.Size(215, 24)
        Me.mnLapDiagnosa.Text = "Diagnosa dan Biaya"
        '
        'mnLapHasilDiagnosa
        '
        Me.mnLapHasilDiagnosa.Name = "mnLapHasilDiagnosa"
        Me.mnLapHasilDiagnosa.Size = New System.Drawing.Size(202, 24)
        Me.mnLapHasilDiagnosa.Text = "-> Hasil Diagnosa"
        '
        'mnLapDiagnosaRekap
        '
        Me.mnLapDiagnosaRekap.Name = "mnLapDiagnosaRekap"
        Me.mnLapDiagnosaRekap.Size = New System.Drawing.Size(202, 24)
        Me.mnLapDiagnosaRekap.Text = "-> Rekap Biaya"
        '
        'mnTentang
        '
        Me.mnTentang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnTentangPembuat, Me.ToolStripMenuItem5, Me.mnTentangProgram})
        Me.mnTentang.Image = CType(resources.GetObject("mnTentang.Image"), System.Drawing.Image)
        Me.mnTentang.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mnTentang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnTentang.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnTentang.Name = "mnTentang"
        Me.mnTentang.Size = New System.Drawing.Size(83, 56)
        Me.mnTentang.Text = "&Tentang"
        Me.mnTentang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mnTentang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnTentang.ToolTipText = "Tentang Program"
        '
        'mnTentangPembuat
        '
        Me.mnTentangPembuat.Checked = True
        Me.mnTentangPembuat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnTentangPembuat.Name = "mnTentangPembuat"
        Me.mnTentangPembuat.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mnTentangPembuat.Size = New System.Drawing.Size(238, 24)
        Me.mnTentangPembuat.Text = "&Tentang Pembuat"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(235, 6)
        '
        'mnTentangProgram
        '
        Me.mnTentangProgram.Checked = True
        Me.mnTentangProgram.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnTentangProgram.Name = "mnTentangProgram"
        Me.mnTentangProgram.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.mnTentangProgram.Size = New System.Drawing.Size(238, 24)
        Me.mnTentangProgram.Text = "&Tentang Program"
        '
        'mnHelp
        '
        Me.mnHelp.Image = CType(resources.GetObject("mnHelp.Image"), System.Drawing.Image)
        Me.mnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnHelp.Name = "mnHelp"
        Me.mnHelp.Size = New System.Drawing.Size(83, 56)
        Me.mnHelp.Text = "&Bantuan"
        Me.mnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnHelp.ToolTipText = "Bantuan Program"
        '
        'iconMenuMedical
        '
        Me.iconMenuMedical.BackColor = System.Drawing.Color.SeaGreen
        Me.iconMenuMedical.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbPasien, Me.ToolStripSeparator2, Me.tsbDokter, Me.ToolStripSeparator3, Me.tsbObat, Me.ToolStripSeparator4, Me.tsbResep, Me.ToolStripSeparator5, Me.tsbHasilDiagnosa, Me.ToolStripSeparator6, Me.tsbKeluar, Me.ToolStripSeparator7, Me.tsPilihan})
        Me.iconMenuMedical.Location = New System.Drawing.Point(85, 0)
        Me.iconMenuMedical.Name = "iconMenuMedical"
        Me.iconMenuMedical.Size = New System.Drawing.Size(768, 25)
        Me.iconMenuMedical.TabIndex = 5
        Me.iconMenuMedical.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPasien
        '
        Me.tsbPasien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPasien.Image = CType(resources.GetObject("tsbPasien.Image"), System.Drawing.Image)
        Me.tsbPasien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPasien.Name = "tsbPasien"
        Me.tsbPasien.Size = New System.Drawing.Size(23, 22)
        Me.tsbPasien.Text = "ToolStripButton1"
        Me.tsbPasien.ToolTipText = "Data pasien"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDokter
        '
        Me.tsbDokter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDokter.Image = CType(resources.GetObject("tsbDokter.Image"), System.Drawing.Image)
        Me.tsbDokter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDokter.Name = "tsbDokter"
        Me.tsbDokter.Size = New System.Drawing.Size(23, 22)
        Me.tsbDokter.Text = "ToolStripButton2"
        Me.tsbDokter.ToolTipText = "Data dokter"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbObat
        '
        Me.tsbObat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbObat.Image = CType(resources.GetObject("tsbObat.Image"), System.Drawing.Image)
        Me.tsbObat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbObat.Name = "tsbObat"
        Me.tsbObat.Size = New System.Drawing.Size(23, 22)
        Me.tsbObat.Text = "ToolStripButton3"
        Me.tsbObat.ToolTipText = "Data obat"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbResep
        '
        Me.tsbResep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbResep.Image = CType(resources.GetObject("tsbResep.Image"), System.Drawing.Image)
        Me.tsbResep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbResep.Name = "tsbResep"
        Me.tsbResep.Size = New System.Drawing.Size(23, 22)
        Me.tsbResep.Text = "ToolStripButton4"
        Me.tsbResep.ToolTipText = "Data resep"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbHasilDiagnosa
        '
        Me.tsbHasilDiagnosa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHasilDiagnosa.Image = CType(resources.GetObject("tsbHasilDiagnosa.Image"), System.Drawing.Image)
        Me.tsbHasilDiagnosa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHasilDiagnosa.Name = "tsbHasilDiagnosa"
        Me.tsbHasilDiagnosa.Size = New System.Drawing.Size(23, 22)
        Me.tsbHasilDiagnosa.Text = "ToolStripButton5"
        Me.tsbHasilDiagnosa.ToolTipText = "Diagnosa Pasien"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbKeluar
        '
        Me.tsbKeluar.BackColor = System.Drawing.Color.Orange
        Me.tsbKeluar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbKeluar.Image = CType(resources.GetObject("tsbKeluar.Image"), System.Drawing.Image)
        Me.tsbKeluar.ImageTransparentColor = System.Drawing.Color.Goldenrod
        Me.tsbKeluar.Name = "tsbKeluar"
        Me.tsbKeluar.Size = New System.Drawing.Size(23, 22)
        Me.tsbKeluar.Text = "ToolStripButton6"
        Me.tsbKeluar.ToolTipText = "Keluar dari aplikasi"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsPilihan
        '
        Me.tsPilihan.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPilihan.ForeColor = System.Drawing.Color.LimeGreen
        Me.tsPilihan.Name = "tsPilihan"
        Me.tsPilihan.Size = New System.Drawing.Size(263, 22)
        Me.tsPilihan.Text = "pilihan melalui ShortCutKey (icon)"
        '
        'mnLapObat
        '
        Me.mnLapObat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDaftarObatKemasan})
        Me.mnLapObat.Name = "mnLapObat"
        Me.mnLapObat.Size = New System.Drawing.Size(215, 24)
        Me.mnLapObat.Text = "Daftar Obat"
        '
        'mnDaftarObatKemasan
        '
        Me.mnDaftarObatKemasan.Name = "mnDaftarObatKemasan"
        Me.mnDaftarObatKemasan.Size = New System.Drawing.Size(254, 24)
        Me.mnDaftarObatKemasan.Text = "-> Berdasarkan Kemasan"
        '
        'frMenuMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 487)
        Me.Controls.Add(Me.iconMenuMedical)
        Me.Controls.Add(Me.menuMedical)
        Me.Controls.Add(Me.statusMenuMedical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frMenuMedical"
        Me.Text = "MenuMedical"
        Me.statusMenuMedical.ResumeLayout(False)
        Me.statusMenuMedical.PerformLayout()
        Me.menuMedical.ResumeLayout(False)
        Me.menuMedical.PerformLayout()
        Me.iconMenuMedical.ResumeLayout(False)
        Me.iconMenuMedical.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusMenuMedical As System.Windows.Forms.StatusStrip
    Friend WithEvents tssBy As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssBatas1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuMedical As System.Windows.Forms.ToolStrip
    Friend WithEvents mnSistem As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnMaster As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnDiagnosa As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnLaporan As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnTentang As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iconMenuMedical As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPasien As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDokter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbObat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbResep As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHasilDiagnosa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbKeluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPilihan As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnTambahUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnBackupData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRestoreData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnDataPasien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataDokter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataObat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnStockObat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnTentangPembuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnTentangProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPemeriksan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDiagnosaPasien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapPasien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapDokter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnLapDiagnosa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapPasienJK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapDokterSpesialis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapHasilDiagnosa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapDiagnosaRekap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataPegawai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnLapObat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDaftarObatKemasan As System.Windows.Forms.ToolStripMenuItem
End Class
