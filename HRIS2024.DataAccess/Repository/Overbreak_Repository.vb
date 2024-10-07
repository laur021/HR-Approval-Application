Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class Overbreak_Repository
    Implements IOverbreak_Repository
    Public Async Function GetCounts(startDate As Date, endDate As Date) As Task(Of IEnumerable(Of OverBreakCount)) Implements IOverbreak_Repository.GetCounts
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringBUS)
            Await db.OpenAsync()
            Dim obj = Await db.QueryAsync(Of OverBreakCount)($"SELECT EmployeeName,
                                                                Department,
                                                                SUM(CASE WHEN HRApproved = 'HR Pending' THEN 1 END) AS Pending,
                                                                SUM(CASE WHEN HRApproved = 'Disapproved' THEN 1 END) AS DisApproved, 
                                                                SUM(CASE WHEN HRApproved = 'Approved' THEN 1 END) AS Approved
                                                                FROM [View_OverBreakSummary]
                                                                WHERE StartTime BETWEEN '{startDate.ToShortDateString} 00:00:00'
                                                                AND '{endDate.ToShortDateString} 23:59:59'
                                                                GROUP BY EmployeeName, Department")
            Return obj
        End Using
    End Function

    Public Async Function GetSummary() As Task(Of IEnumerable(Of OverBreakSummary)) Implements IOverbreak_Repository.GetSummary
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringBUS)
            Await db.OpenAsync()
            Return Await Await Task.FromResult(db.QueryAsync(Of OverBreakSummary)($"SELECT * FROM View_OverBreakSummary"))
        End Using
    End Function
End Class
