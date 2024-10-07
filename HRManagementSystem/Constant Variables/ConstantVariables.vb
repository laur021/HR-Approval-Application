Imports DocumentFormat.OpenXml.Office2019.Drawing.Animation

Public Class ConstantVariables

    'Department
    Public Const Department_HR = "HR"
    Public Const Department_OPSA = "OPSA"

    'EmployeeType
    Public Const Officer As String = "Officer"
    Public Const Leader As String = "Leader"
    Public Const Manager As String = "Manager"
    Public Const QA As String = "QA"
    Public Const Timekeeper As String = "Timekeeper"
    Public Const SysAdmin As String = "SysAdmin"

    'Status
    Public Const Leader_Pending As String = "Leader Pending"
    Public Const Leader_Reject As String = "Leader Rejected"
    Public Const Leader_Approve As String = "Leader Approved"
    Public Const Manager_Pending As String = "Manager Pending"
    Public Const Manager_Reject As String = "Manager Rejected"
    Public Const Manager_Approve As String = "Manager Approved"
    Public Const HR_Pending As String = "HR Pending"
    Public Const HR_Reject As String = "HR Rejected"
    Public Const HR_Approve As String = "HR Approved"
    Public Const Cancelled As String = "Cancelled"
    Public Const Withdrawn As String = "Withdrawn"

    'Leave Type
    Public Const VL As String = "Vacation Leave"
    Public Const SL As String = "Sick Leave"
    Public Const EL As String = "Emergency Leave"
    Public Const ML As String = "Maternity Leave"
    Public Const PL As String = "Paternity Leave"
    Public Const SPL As String = "Solo Parent Leave"
    Public Const LWOP As String = "Leave Without Pay"
    Public Const IL As String = "Indefinite Leave"
    Public Const COVL As String = "Carry Over Vacation Leave"
    Public Const MCW As String = "MCW Special Leave"

    'Admin User
    Public Const Laurence As String = "Mark Laurence M. Bacolor"
    Public Const Alvin As String = "Alvin V. Rebulado"
    Public Const Raymart As String = "Raymart B. Larisma"
    Public Const Joep As String = "Joepring M. Acosta"
    Public Const Emron As String = "John Emron G. Laygo"
    Public Const Bron As String = "Ree Brian D. Bron"

    'Application Type
    Public Const LeaveApplication As String = "Leave Application"
    Public Const ChangeShiftApplication As String = "Change Shift Application"
    Public Const OverTimeApplication As String = "Over Time Application"
    Public Const LateApplication As String = "Late Application"
    Public Const Infraction As String = "Timekeeping Infraction"

    'ChangeShift Type
    Public Const Personal As String = "Personal"
    Public Const WorkRequired As String = "Work Required"

    'OverTime Type
    Public Const Regular As String = "Regular OT"
    Public Const Restday As String = "Rest Day OT"
    Public Const Regularholiday As String = "Regular Holiday OT"
    Public Const RegularholidayRD As String = "Regular Holiday + RD OT"
    Public Const Specialholiday As String = "Special Holiday OT"
    Public Const SpecialholidayRD As String = "Special Holiday + RD OT"

    'Timekeeping infraction type
    Public Const ClockingIssue As String = "Clocking Issue"
    Public Const IdIssue As String = "ID Issue"
    Public Const SystemIssue As String = "Odoo System Issue"

    'Type of Decision in late request
    Public Const excused As String = "Excused"
    Public Const unexcused As String = "Unexcused"
    Public Const pending As String = "Pending"


End Class
