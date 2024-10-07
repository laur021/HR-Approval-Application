
'Generic type of Interface for leave, cs, ot, infraction and late
Public Interface IInformation_Repository(Of T)
    Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of T))

End Interface
