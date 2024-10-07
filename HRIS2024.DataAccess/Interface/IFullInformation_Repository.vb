Imports HRIS2024.Models

Public Interface IFullInformation_Repository

    Function GetFullInformationAsync(ApplicationId As String) As Task(Of viewFullInformation)

End Interface
