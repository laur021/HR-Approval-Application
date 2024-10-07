Imports HRIS2024.Models

Public Interface IApplication_Repository

    Function GetAllDataAsync() As Task(Of IEnumerable(Of Application))

    Function UpdateDataAsync(Application As Application) As Task

    Function GetDataByIdAsync(ApplicationId As String) As Task(Of Application)

End Interface
