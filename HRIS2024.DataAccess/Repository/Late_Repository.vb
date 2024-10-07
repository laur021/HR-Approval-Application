Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility
Public Class Late_Repository
    Implements ILate_Repository

    'This method wont cause any error cause I inherited the IInformation_Repository into ILate_Repository
    Public Async Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Late)) Implements IInformation_Repository(Of Late).GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(Late))
            End If

            Dim queryString = $"SELECT * FROM Information_Late WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)

            Return Await db.QueryAsync(Of Late)(queryString, parameter)

        End Using
    End Function
    Private Async Function Update(ApplicationId As String, isExcused As String) As Task Implements ILate_Repository.Update
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            'Dim updateQuery = $"UPDATE [Information_Late] SET isExcused_HR = @isExcused_HR WHERE ApplicationID = @ApplicationID"
            Dim updateQuery = $"UPDATE [Information_Late] SET isExcused_HR = '{isExcused}' WHERE ApplicationID = '{ApplicationId}'"
            Dim parameter As New DynamicParameters()

            'parameter.Add("@ApplicationID'", ApplicationId)
            'parameter.Add("@isExcused_HR", isExcused)

            Await db.ExecuteAsync(updateQuery)

        End Using
    End Function
End Class
