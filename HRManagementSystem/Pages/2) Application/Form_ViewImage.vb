Imports System.Data.SqlClient
Imports System.IO
Public Class Form_ViewImage

    Private AttachFile As HRIS2024.Models.Attachment
    Private fileinfo As FileInfo

    Public Sub New(AttachFile)

        InitializeComponent()

        'Set all font to roboto
        Dim font As New Font("Roboto", 9, FontStyle.Regular)
        SetFontForLabels(Me, font)

        Me.AttachFile = AttachFile

        fileinfo = New FileInfo(Me.AttachFile.FileName)

        File.WriteAllBytes(fileinfo.FullName, Me.AttachFile.FileBytes)

        pbImage.Image = Image.FromFile(fileinfo.FullName)

        pbImage.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    ' Function to set all text font style into Roboto
    Private Sub SetFontForLabels(parentControl As Control, font As Font)
        For Each control As Control In parentControl.Controls
            If TypeOf control Is Label Then
                control.Font = New Font("Roboto", control.Font.Size, control.Font.Style)
            End If

            If control.HasChildren Then
                SetFontForLabels(control, font)
            End If
        Next
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        Try

            Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

                If AttachFile IsNot Nothing Then

                    Dim savefile As New SaveFileDialog()
                    savefile.FileName = fileinfo.Name
                    savefile.Filter = "JPEG Image|*.jpg"

                    If savefile.ShowDialog() = DialogResult.OK Then

                        File.WriteAllBytes(savefile.FileName, Me.AttachFile.FileBytes)

                        ' Me.DialogResult = DialogResult.OK

                        Dim EventCode = 11

                        Dim DialogBoxOK As New DialogBoxOK(EventCode) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}

                        DialogBoxOK.ShowDialog()

                    End If

                End If

            End Using


        Catch ex As Exception



        End Try


    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)

        MyBase.OnFormClosed(e)
        pbImage.Image.Dispose()

    End Sub

End Class