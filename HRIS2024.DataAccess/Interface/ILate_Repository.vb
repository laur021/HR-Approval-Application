'This is special condition, i need to create Late interface because I need to have update method on late repository
'Unlike with Leave, CS, OT and infraction, all method that I needed to implement is getDataById, thats why they are all share same Interface
Imports HRIS2024.Models

Public Interface ILate_Repository
    Inherits IInformation_Repository(Of Late) 'inherit the iinformation repository

    Function Update(ApplicationId As String, isExcused As String) As Task


End Interface
