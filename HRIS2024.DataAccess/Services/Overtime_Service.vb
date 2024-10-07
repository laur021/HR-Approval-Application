Imports HRIS2024.Models
Imports HRIS2024.Utility
Imports System.Data.SqlClient

Public Class Overtime_Service
    Implements IFullInformation_Repository

    Private ReadOnly AppRepo As IApplication_Repository
    Private ReadOnly infoRepo As IInformation_Repository(Of OverTime)
    Private ReadOnly commentRepo As IComment_Repository
    Private ReadOnly attachmentRepo As IAttachment_Repository

    Public Sub New()

        AppRepo = New Application_Repository
        infoRepo = New OverTime_Repository
        commentRepo = New Comment_Repository
        attachmentRepo = New Attachment_Repository

    End Sub

    Public Async Function GetFullInformationAsync(ApplicationId As String) As Task(Of viewFullInformation) Implements IFullInformation_Repository.GetFullInformationAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            Dim applicationEntity = Await AppRepo.GetDataByIdAsync(ApplicationId)
            Dim informationEntity = Await infoRepo.GetDataByIdAsync(ApplicationId)
            Dim commentEntities = Await commentRepo.GetDataByIdAsync(ApplicationId)
            Dim attachmentEntities = Await attachmentRepo.GetDataByIdAsync(ApplicationId)

            Dim fullInformation = New viewFullInformation With {
                .Application = applicationEntity,
                .Information = informationEntity,
                .Comment = commentEntities,
                .Attachment = attachmentEntities
            }

            If fullInformation Is Nothing Then
                Throw New ArgumentNullException(NameOf(fullInformation))
            End If

            Return fullInformation
        End Using
    End Function
End Class
