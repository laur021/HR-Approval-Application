Public Class PageDatagridProperties

    Public Shared Sub InitializedTheme(dgv As DataGridView)

        With dgv

            'Set datagrid to full width
            .Dock = DockStyle.Fill

            'Set the column to full width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Set the cell border with only horizontal border
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Set datagrid grid color
            .GridColor = SystemColors.InactiveBorder

            'Set font for header and body
            .ColumnHeadersDefaultCellStyle.Font = New Font("Roboto", 9)
            .DefaultCellStyle.Font = New Font("Roboto", 9)

            'Set font color  for header and body
            .ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            .DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark

            'Set alignment for Header and body
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Set height for body row | In height for header row - I set the height property in columndefaultstyle in control properties
            .RowTemplate.Height = 45

        End With

    End Sub

End Class
