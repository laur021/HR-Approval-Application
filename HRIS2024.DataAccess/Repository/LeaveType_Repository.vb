Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class LeaveType_Repository
    Implements ILeaveType_Repository

    Public Async Function AddAsync(Leave As LeaveType) As Task Implements ILeaveType_Repository.AddAsync

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            If Leave Is Nothing Then
                MsgBox("LeaveType is null")
            End If

            Dim sqlInsert = "INSERT INTO [Type_Leave] (LeaveType, Description, AddedBy, AddedDate) VALUES (@LeaveType, @Description, @AddedBy, @AddedDate)"
            Dim parameter As New DynamicParameters()

            With Leave
                parameter.Add("@LeaveType", .LeaveType?.Trim.ToString())
                parameter.Add("@Description", .Description?.Trim.ToString())
                parameter.Add("@AddedBy", .AddedBy?.ToString())
                parameter.Add("@AddedDate", .AddedDate)
            End With

            Await db.ExecuteAsync(sqlInsert, parameter)

        End Using

    End Function

    Public Async Function UpdateAsync(Leave As LeaveType) As Task Implements ILeaveType_Repository.UpdateAsync

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            If Leave Is Nothing Then
                MsgBox("LeaveType is null")
            End If

            Dim sqlUpdate = "UPDATE [Type_Leave] SET LeaveType = @LeaveType, Description = @Description, AddedBy = @AddedBy, AddedDate = @AddedDate WHERE Id = @Id"
            Dim parameter As New DynamicParameters()

            With Leave
                parameter.Add("@Id", .Id)
                parameter.Add("@LeaveType", .LeaveType?.Trim.ToString())
                parameter.Add("@Description", .Description?.Trim.ToString())
                parameter.Add("@AddedBy", .AddedBy?.ToString())
                parameter.Add("@AddedDate", .AddedDate)
            End With

            Await db.ExecuteAsync(sqlUpdate, parameter)

        End Using

    End Function

    Public Async Function GetListAsync() As Task(Of IEnumerable(Of HRIS2024.Models.LeaveType)) Implements ILeaveType_Repository.GetListAsync

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            Dim leaveTypeObj = Await Task.FromResult(db.QueryAsync(Of HRIS2024.Models.LeaveType)("SELECT * FROM [Type_Leave] WHERE isDeleted IS NULL"))

            If leaveTypeObj Is Nothing Then
                MsgBox("No List of Data")
            End If

            Return Await leaveTypeObj

        End Using

    End Function

    Public Async Function GetCountsAsync(leaveType As String) As Task(Of Integer) Implements ILeaveType_Repository.GetCountsAsync

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            Dim countObj = Await db.ExecuteScalarAsync(Of Integer)($"SELECT COUNT(*) FROM [Type_Leave] WHERE LeaveType LIKE '%{leaveType.Trim()}%' AND isDeleted IS NULL")

            Return countObj

        End Using

    End Function

    Public Async Function RemoveAsync(Id As Integer) As Task Implements ILeaveType_Repository.RemoveAsync

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            Await db.ExecuteAsync($"UPDATE [Type_Leave] SET isDeleted = '{True}' WHERE Id = '{Id}'")

        End Using

    End Function
End Class
