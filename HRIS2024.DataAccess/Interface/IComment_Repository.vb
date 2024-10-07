Imports HRIS2024.Models

Public Interface IComment_Repository

    Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Comment))

    Function AddData(commentObj As Comment) As Task

End Interface
