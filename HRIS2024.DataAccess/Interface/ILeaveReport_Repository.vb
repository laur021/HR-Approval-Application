Imports HRIS2024.Models

Public Interface ILeaveReport_Repository

    Function GetAllDataAsync() As Task(Of IEnumerable(Of LeaveReport))

    Function GetLeaveCountAsync(startDate As DateTime, endDate As DateTime) As Task(Of IEnumerable(Of LeaveCount))

End Interface
