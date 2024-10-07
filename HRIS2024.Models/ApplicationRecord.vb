Public Class ApplicationRecord
    Public Property ApplicationID As String
    Public Property Applicant As String
    Public Property ApplicationDate As Date
    Public Property Department As String
    Public Property Position As String
    Public Property ApplicationType As String
    Public Property RequestType As String

    Public Property Leave_StartDate As Date
    Public Property Leave_EndDate As Date
    Public Property Leave_NoOfDays As Integer

    Public Property ChangeShift_ShiftDate As Date
    Public Property ChangeShift_OriginalSchedule As String
    Public Property ChangeShift_NewSchedule As String

    Public Property OverTime_ShiftDate As Date
    Public Property OverTime_StartTime As Date
    Public Property OverTime_EndTime As Date
    Public Property OverTime_TotalHours As Decimal

    Public Property Late_OriginalSchedule As Date
    Public Property Late_ActualTimeIn As Date
    Public Property Late_TotalLateTime As TimeSpan
    Public Property Late_isExcusedLeader As String
    Public Property Late_isExcusedManager As String
    Public Property Late_isExcusedHR As String


    Public Property Infraction_ShiftDate As Date
    Public Property Infraction_ScheduledInOut As Date
    Public Property Infraction_SystemInOut As Date
    Public Property Infraction_ActualInOut As Date

    Public Property Description As String
    Public Property LeaderApprovedBy As String
    Public Property LeaderApprovedDate As Date
    Public Property HeadApprovedBy As String
    Public Property HeadApprovedDate As Date
    Public Property HRApprovedBy As String
    Public Property HRApprovedDate As Date
    Public Property UpdateTime As Date
    Public Property Status As String

End Class
