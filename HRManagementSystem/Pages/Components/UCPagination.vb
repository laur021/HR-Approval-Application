Imports HRIS2024.Models

Public Class UCPagination

    Private _pagination As Pagination

    ' Define the event
    Public Event PageChanged(sender As Object, e As EventArgs)
    Public Event Export(sender As Object, e As EventArgs)

    Public Sub New(Pagination As Pagination, recordsPerPage As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _pagination = Pagination

        With _pagination
            .currentPage = 1
            .recordsPerPage = recordsPerPage
            .totalRecords = 0
            .totalPages = 0
            .offset = 0
            lblCurrentPage.Text = .currentPage.ToString()
            lblTotalPage.Text = .totalPages.ToString()
        End With

    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        With _pagination
            If .totalRecords > 0 Then
                If .currentPage > 1 Then
                    .currentPage -= 1
                    .offset = (.currentPage - 1) * .recordsPerPage
                    RaiseEvent PageChanged(Me, EventArgs.Empty)
                    lblCurrentPage.Text = .currentPage
                    'ElseIf .currentPage <= 1 Then
                    '    btnPrevious.Enabled = False
                End If
            Else
                lblTotalPage.Text = 0
                lblCurrentPage.Text = 0
            End If
        End With
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        With _pagination
            If .totalRecords > 0 Then
                If .currentPage < .totalPages Then
                    .currentPage += 1
                    .offset = (.currentPage - 1) * .recordsPerPage
                    RaiseEvent PageChanged(Me, EventArgs.Empty)
                    lblCurrentPage.Text = .currentPage
                    'ElseIf .currentPage >= .totalPages Then
                    '    btnNext.Enabled = False
                End If
            Else
                lblTotalPage.Text = 0
                lblCurrentPage.Text = 0
            End If
        End With
    End Sub

    Public Sub ResetPageForAllRecords(TotalRecords As Integer)
        With _pagination
            If TotalRecords > 0 Then
                .offset = 0
                .currentPage = 1
                .totalPages = Math.Ceiling(TotalRecords / .recordsPerPage)
                Me.lblTotalPage.Text = .totalPages.ToString()
                Me.lblCurrentPage.Text = .currentPage.ToString()
            Else
                Me.lblTotalPage.Text = 0
                Me.lblCurrentPage.Text = 0
            End If
        End With
    End Sub

    Public Sub FilterPage(TotalRecords As Integer)
        With _pagination
            If TotalRecords > 0 Then
                .totalPages = Math.Ceiling(TotalRecords / .recordsPerPage)
                Me.lblTotalPage.Text = .totalPages.ToString()
                Me.lblCurrentPage.Text = .currentPage.ToString()
            Else
                Me.lblTotalPage.Text = 0
                Me.lblCurrentPage.Text = 0
            End If
        End With
    End Sub

End Class
