Imports Dapper
Imports System.Data.SqlClient
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class Comment_Repository
    Implements IComment_Repository

    Private Async Function IComment_Repository_GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Comment)) Implements IComment_Repository.GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(Comment))
            End If

            Dim queryString = $"SELECT * FROM Comment WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)
            Return (Await db.QueryAsync(Of Comment)(queryString, parameter))

        End Using
    End Function

    Public Async Function AddData(commentObj As HRIS2024.Models.Comment) As Task Implements IComment_Repository.AddData
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            Dim queryString = $"INSERT INTO [Comment] ([ApplicationID], [Commentor], [Comment], [Status], [AddedDate]) VALUES (@ApplicationID, @Commentor, @Comment, @Status, @AddedDate)"
            Dim parameter As New DynamicParameters()

            With commentObj

                parameter.Add("@ApplicationID", .ApplicationID)
                parameter.Add("@Commentor", .Commentor)
                parameter.Add("@Comment", .Comment)
                parameter.Add("@Status", .Status)
                parameter.Add("@AddedDate", .AddedDate)

            End With

            Await db.ExecuteAsync(queryString, parameter)

        End Using
    End Function

End Class
