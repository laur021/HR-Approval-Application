Imports Dapper
Imports HRIS2024.Models
Imports System.Data.SqlClient
Imports HRIS2024.Utility
Public Class ChangeShift_Repository
    Implements IInformation_Repository(Of ChangeShift)

    Public Async Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of ChangeShift)) Implements IInformation_Repository(Of ChangeShift).GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(ChangeShift))
            End If

            Dim queryString = $"SELECT * FROM Information_ChangeShift WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)

            Return (Await db.QueryAsync(Of ChangeShift)(queryString, parameter))

        End Using
    End Function
End Class
