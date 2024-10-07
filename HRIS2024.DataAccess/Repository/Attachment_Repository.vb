Imports Dapper
Imports System.Data.SqlClient
Imports HRIS2024.Models
Imports HRIS2024.Utility
Imports System.DirectoryServices.AccountManagement
Imports System.IO

'dito na ko.xxx
Public Class Attachment_Repository
    Implements IAttachment_Repository
    Public Async Function AddAsync(Attachment As Attachment) As Task Implements IAttachment_Repository.AddAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If Attachment Is Nothing Then
                MsgBox("No added data")
                Return
            End If

            Dim sqlInsert = $"INSERT INTO
                              [Attachment]
                              ([ApplicationId], [FileName], [FileExtension], [FileBytes], [UploadedBy], [UploadedDate])
                              VALUES
                              (@ApplicationId, @FileName, @FileExtension, CONVERT(varbinary(max), @FileBytes), @UploadedBy, @UploadedDate)"

            Dim parameter As New DynamicParameters()
            parameter.Add("@ApplicationId", "Leave Policy")
            parameter.Add("@FileName", Attachment.FileName)
            parameter.Add("@FileExtension", Attachment.FileExtension)
            parameter.Add("@FileBytes", Attachment.FileBytes)
            parameter.Add("@UploadedBy", Attachment.UploadedBy)
            parameter.Add("@UploadedDate", Attachment.UploadedDate)
            Dim sqlint = Await db.ExecuteAsync(sqlInsert, parameter)


        End Using
    End Function

    Public Async Function UpdateAsync(Attachment As Attachment) As Task Implements IAttachment_Repository.UpdateAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If Attachment Is Nothing Then
                MsgBox("Data not exists")
                Return
            End If

            Dim sqlUpdate = $"UPDATE
                              [Attachment]
                              SET
                              [FileName] = @FileName,
                              [FileExtension] = @FileExtension,
                              [FileBytes] = CONVERT(varbinary(max), @FileBytes),
                              [UploadedBy] = @UploadedBy,
                              [UploadedDate] = @UploadedDate
                              WHERE
                              [ApplicationId] = @ApplicationId"

            Dim parameter As New DynamicParameters()
            parameter.Add("@ApplicationId", "Leave Policy")
            parameter.Add("@FileName", Attachment.FileName)
            parameter.Add("@FileExtension", Attachment.FileExtension)
            parameter.Add("@FileBytes", Attachment.FileBytes)
            parameter.Add("@UploadedBy", Attachment.UploadedBy)
            parameter.Add("@UploadedDate", Attachment.UploadedDate)
            Dim sqlint = Await db.ExecuteAsync(sqlUpdate, parameter)


        End Using
    End Function

    Private Async Function IAttachment_Repository_GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Attachment)) Implements IAttachment_Repository.GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(Attachment))
            End If

            Dim queryString = $"SELECT * FROM Attachment WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)

            Return Await db.QueryAsync(Of Attachment)(queryString, parameter)

        End Using
    End Function
End Class
