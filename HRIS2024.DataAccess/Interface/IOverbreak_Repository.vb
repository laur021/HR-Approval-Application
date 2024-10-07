Imports HRIS2024.Models

Public Interface IOverbreak_Repository
    Function GetCounts(startDate As Date, endDate As Date) As Task(Of IEnumerable(Of OverBreakCount))
    Function GetSummary() As Task(Of IEnumerable(Of OverBreakSummary))
End Interface
