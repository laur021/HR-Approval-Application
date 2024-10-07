Imports HRIS2024.Models

Public Interface IAttachment_Repository
    Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Attachment))
    Function AddAsync(Attachment As Attachment) As Task
    Function UpdateAsync(Attachment As Attachment) As Task
End Interface
