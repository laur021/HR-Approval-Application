Public Class CountOfPendingInTabPage

    Public Shared Sub CountofPending(tab As TabPage)

        Dim dataGridViewCount As Integer = 0
        Dim originaltext = tab.Text.Substring(0, tab.Text.LastIndexOf("  (")) 'save the text of tabcontrol header

        For Each panel As Control In tab.Controls 'need 2 for loop kasi yung datagrid nasa loob pa ng panel
            For Each control As Control In panel.Controls 'para mafilter na datagridview lang
                If TypeOf control Is DataGridView Then
                    Dim dataGridView As DataGridView = DirectCast(control, DataGridView) 'need icast to datagridview para maaccess yung rows.count
                    dataGridViewCount += dataGridView.Rows.Count
                End If
            Next
        Next

        tab.Text = originaltext 'reset the text
        tab.Text = tab.Text & "  " & "(" & dataGridViewCount.ToString & ")" 'show again the text with count

    End Sub

End Class
