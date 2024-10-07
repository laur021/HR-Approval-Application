Public Class DbSqlConnection

    Private Shared _connectionStringHRIS As String
    Private Shared connectionStringBUS As String

    ' Method to set the connection string based on user selection from formlogin.vb
    Public Shared Sub SetConnectionString(connectionString As String)
        _connectionStringHRIS = connectionString
        connectionStringBUS = "Server=192.168.17.100\TITANIUM,51433; Database=BreakApp;User Id=sa;Password=Righteousn3ss;TrustServerCertificate=True;"
    End Sub

    ' Method to retrieve the current connection string
    Public Shared Function GetConnectionStringHRIS() As String
        Return _connectionStringHRIS
    End Function

    Public Shared Function GetConnectionStringBUS() As String
        Return connectionStringBUS
    End Function

End Class