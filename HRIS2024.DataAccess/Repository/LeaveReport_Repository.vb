Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class LeaveReport_Repository
    Implements ILeaveReport_Repository

    Public Async Function GetAllDataAsync() As Task(Of IEnumerable(Of LeaveReport)) Implements ILeaveReport_Repository.GetAllDataAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()
            'Return Await Await Task.FromResult(db.QueryAsync(Of LeaveReport)($"SELECT * FROM View_LeaveReport WHERE Status = 'HR Approved'"))
            Return Await Await Task.FromResult(db.QueryAsync(Of LeaveReport)($"SELECT * FROM View_LeaveReport"))
        End Using
    End Function

    Public Async Function GetLeaveCountAsync(startDate As Date, endDate As Date) As Task(Of IEnumerable(Of LeaveCount)) Implements ILeaveReport_Repository.GetLeaveCountAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()
            Dim sqlquery = $"SELECT Applicant,
                                    Department,
                                    SUM(CASE WHEN RequestType = 'Vacation Leave' THEN 1 END) AS VL_Count,
                                    SUM(CASE WHEN RequestType = 'Sick Leave' THEN 1 END) AS SL_Count,
                                    SUM(CASE WHEN RequestType = 'Emergency Leave' THEN 1 END) AS EL_Count,
                                    SUM(CASE WHEN RequestType = 'Maternity Leave' THEN 1 END) AS ML_Count,
                                    SUM(CASE WHEN RequestType = 'Paternity Leave' THEN 1 END) AS PL_Count,
                                    SUM(CASE WHEN RequestType = 'Solo Parent Leave' THEN 1 END) AS SPL_Count,
                                    SUM(CASE WHEN RequestType = 'Leave Without Pay' THEN 1 END) AS LWOP_Count,
                                    SUM(CASE WHEN RequestType = 'Indefinite Leave' THEN 1 END) AS IL_Count,
                                    SUM(CASE WHEN RequestType = 'Carry Over Vacation Leave' THEN 1 END) AS COVL_Count,
                                    SUM(CASE WHEN RequestType = 'MCW Special Leave' THEN 1 END) AS MCW_Count
                                    FROM [View_LeaveReport]
                                    WHERE Status = 'HR Approved'
                                    AND RequestDate BETWEEN '{startDate}' AND '{endDate}' 
                                    GROUP BY Applicant, Department
                                    ORDER BY Applicant"
            Return Await Await Task.FromResult(db.QueryAsync(Of LeaveCount)(sqlquery))
        End Using
    End Function
End Class
