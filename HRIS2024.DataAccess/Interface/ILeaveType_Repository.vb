Imports HRIS2024.Models

Public Interface ILeaveType_Repository

    Function AddAsync(Leave As LeaveType) As Task
    Function UpdateAsync(Leave As LeaveType) As Task
    Function GetListAsync() As Task(Of IEnumerable(Of LeaveType))
    Function GetCountsAsync(leaveType As String) As Task(Of Integer)
    Function RemoveAsync(Id As Integer) As Task
End Interface
