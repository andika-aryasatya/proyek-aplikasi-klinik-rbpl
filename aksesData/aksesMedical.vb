Imports MySql.Data.MySqlClient
Namespace aksesData
    Public Class AksesMedical
        Public Shared VerifikasiUser As String
        Dim Koneksi As New MySqlConnection("Data Source=localhost;Database=Rekam_medis;User Id=root;Password=''")
        Public Function Buka() As MySqlConnection
            Koneksi.Open()
            Return Koneksi
        End Function
        Public Function Tutup() As MySqlConnection
            Koneksi.Close()
            Return Koneksi
        End Function

        Function cumaAngka(ByVal kode As String, Optional ByVal spasi As Boolean = False) As Boolean
            Select Case kode
                Case 40 To 57
                    Return False
                Case 8
                    Return False
                Case 32
                    If spasi Then
                        Return False
                    Else
                        Return True
                    End If
                Case Else
                    Return True
            End Select
        End Function
    End Class
End Namespace