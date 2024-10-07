Imports HRIS2024.Models

Public Interface IApplicationRecord_Repository
    Function GetSingleDataAsync(ApplicationId As String) As Task(Of ApplicationRecord)
    Function GetAllDataAsync() As Task(Of IEnumerable(Of ApplicationRecord))
    Function GetAllDataCountAsync() As Task(Of Integer)

End Interface
