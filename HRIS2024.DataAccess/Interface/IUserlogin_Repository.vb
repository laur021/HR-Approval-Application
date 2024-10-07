Imports HRIS2024.Models

Public Interface IUserlogin_Repository

    Function GetUser(UserName As String, Password As String) As Task(Of UserLogin)

End Interface
