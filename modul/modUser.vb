Imports MySql.Data.MySqlClient
Imports aplikasiMEDICAL.aksesData.aksesMedical
Module ModuleUser
#Region "DeklarasiVARIABEL"
    Dim koneksi As New aksesData.AksesMedical
    Dim mProses As String
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
#End Region
#Region "AksesTABEL"
    Sub AddRecordUser()
        With FormUser
            Try
                .txtIDUser.DataBindings.Clear()
                .txtNamaUser.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Added record")
            End Try
        End With
    End Sub
    Sub SaveRecordUser()
        With FormUser
            Try
                If (.txtNamaUser.Text = Nothing) Then
                    MsgBox("Record Nama User harus diisi", MsgBoxStyle.Information, "Perhatian")
                    .txtNamaUser.Focus()
                    Exit Sub
                Else
                    Dim sqlInsert As String

                    sqlInsert = "Insert into tlogin values('"
                    sqlInsert += Left(.txtIDUser.Text, 5) & "','"
                    sqlInsert += .txtPassword.Text & "','" & .cbLevelUser.Text & "')"

                    cmd = New MySqlCommand(sqlInsert)
                    cmd.Connection = koneksi.Buka
                    cmd.ExecuteNonQuery()
                    koneksi.Tutup()
                End If
            Catch ex As OleDb.OleDbException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Saved record")
            End Try
        End With
    End Sub
    Sub DeleteRecordUser()
        With FormUser
            Try
                If Len(.txtNamaUser.Text) = 0 Then
                    MsgBox("tidak ada data yang akan dihapus", MsgBoxStyle.Information, "Perhatian")
                    Exit Sub
                Else
                    Dim sqlDelete As String
                    Dim hapus As Int16

                    hapus = MsgBox("Benar User ini akan dihapus...! " & .txtNamaUser.Text & "?", MsgBoxStyle.OkCancel, "Delete record")
                    Select Case hapus
                        Case vbCancel
                            Exit Sub
                        Case vbOK
                            sqlDelete = "Delete from tlogin where nip= '" & .txtIDUser.Text & "'"
                            cmd = New MySqlCommand(sqlDelete)
                            cmd.Connection = koneksi.Buka
                            cmd.ExecuteNonQuery()
                            koneksi.Tutup()
                            MsgBox("Record pada tabel User, dengan ID " & .txtIDUser.Text & " telah terhapus", MsgBoxStyle.Information, "Delete record")
                            FormUser.Close()
                    End Select
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
        End With
    End Sub
    Sub tampilUser()
        Dim koneksi As New aksesData.AksesMedical
        Dim sql As String
        sql = "Select p.nama,l.pass,l.level_user from tpegawai p,tlogin l where p.nip='" & FormUser.txtIDUser.Text & "'and p.nip=l.nip"
        cmd = New MySqlCommand(sql, koneksi.Buka)
        dr = cmd.ExecuteReader
        If dr.Read Then
            FormUser.txtNamaUser.Text = dr.Item("nama")
            FormUser.txtPassword.Text = dr.Item("pass")
            FormUser.cbLevelUser.Text = dr.Item("level_user")
        Else
            'MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
    Sub tampilPegawai()
        Dim koneksi As New aksesData.AksesMedical
        Dim sql As String
        sql = "Select nama from tpegawai where nip='" & FormUser.txtIDUser.Text & "'"
        cmd = New MySqlCommand(sql, koneksi.Buka)
        dr = cmd.ExecuteReader
        If dr.Read Then
            FormUser.txtNamaUser.Text = dr.Item("nama")
        Else
            'MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
    Function user() As Integer
        Dim koneksi As New aksesData.AksesMedical
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader
            Try
                cmd.Connection = koneksi.Buka
                cmd.CommandType = CommandType.Text
                cmd.CommandText = ("select l.level_user from tlogin l,tpegawai p where l.nip=p.nip and p.nip='" & FormUser.txtIDUser.Text & "'")
                dr = cmd.ExecuteReader
                If (dr.Read()) Then
                    Return CStr(dr.GetValue(0))
                Else
                    Return 0
                End If
                koneksi.Tutup()
            Catch ex As Exception
                koneksi.Tutup()
            End Try
        End Function
#End Region
End Module
