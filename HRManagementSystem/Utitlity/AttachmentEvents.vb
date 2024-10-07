Imports System.IO

Public Class AttachmentEvents

    Public Shared Sub SetImageLabel(Attachment As HRIS2024.Models.Attachment, panelFiles As Panel)

        Select Case Attachment.FileExtension.ToLower()
            Case ".jpg", ".jpeg", ".png", ".gif"
                Dim pictureImage As New PictureBox With {
                        .Size = New Size(30, 30),
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .SizeMode = PictureBoxSizeMode.Zoom,
                        .Image = My.Resources.icons8_image_24,
                        .Anchor = AnchorStyles.Left,
                        .Margin = New Padding(0)
}

                panelFiles.Controls.Add(pictureImage)

                Dim label As New Label With {
                .Text = If(Attachment.FileName.Length < 7, Attachment.FileName & Attachment.FileExtension, Attachment.FileName.Substring(0, 7) & Attachment.FileExtension),
                .Font = New Font("Roboto", 8, FontStyle.Regular),
                .ForeColor = SystemColors.ControlDarkDark,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Anchor = AnchorStyles.Left,
                .Margin = New Padding(0)
                }

                ' Add the MouseEnter event handler
                AddHandler pictureImage.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                        ' Change the appearance of the control when the mouse enters
                                                        pictureImage.BackColor = SystemColors.Control
                                                        pictureImage.Size = New Size(28, 28)
                                                    End Sub

                ' Add the MouseLeave event handler
                AddHandler pictureImage.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                        ' Change the appearance of the control when the mouse leaves
                                                        pictureImage.BackColor = Color.Transparent
                                                        pictureImage.Size = New Size(30, 30)
                                                    End Sub
                panelFiles.Controls.Add(label)

                'handler for viewing image file and btnimage icon
                AddHandler pictureImage.Click, Sub(sender As Object, e As EventArgs)

                                                   Dim FormViewImage As New Form_ViewImage(Attachment) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}

                                                   FormViewImage.ShowDialog()

                                               End Sub
                Exit Select
            Case ".doc", ".docx"
                Dim pictureWord As New PictureBox With {
                        .Size = New Size(30, 30),
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .SizeMode = PictureBoxSizeMode.Zoom,
                        .Image = My.Resources.icons8_word_24,
                        .Text = Attachment.FileName.ToString(),
                        .Anchor = AnchorStyles.Left,
                        .Margin = New Padding(0)
                        }
                panelFiles.Controls.Add(pictureWord)

                Dim label As New Label With {
                .Text = If(Attachment.FileName.Length < 7, Attachment.FileName & Attachment.FileExtension, Attachment.FileName.Substring(0, 7) & Attachment.FileExtension),
                .Font = New Font("Roboto", 8, FontStyle.Regular),
                .ForeColor = SystemColors.ControlDarkDark,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Anchor = AnchorStyles.Left,
                .Margin = New Padding(0)
                }

                ' Add the MouseEnter event handler
                AddHandler pictureWord.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                       ' Change the appearance of the control when the mouse enters
                                                       pictureWord.BackColor = SystemColors.Control
                                                       pictureWord.Size = New Size(28, 28)
                                                   End Sub

                ' Add the MouseLeave event handler
                AddHandler pictureWord.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                       ' Change the appearance of the control when the mouse leaves
                                                       pictureWord.BackColor = Color.Transparent
                                                       pictureWord.Size = New Size(30, 30)
                                                   End Sub

                panelFiles.Controls.Add(label)

                ' Add click event handler to open the Word file
                AddHandler pictureWord.Click, Sub(sender As Object, e As EventArgs)

                                                  Try

                                                      Dim tempFolderPath As String = Path.Combine(Path.GetTempPath(), "HRIS 2024")
                                                      Dim tempFilePath As String = Path.Combine(tempFolderPath, Attachment.FileName & Attachment.FileExtension)

                                                      If Not Directory.Exists(tempFolderPath) Then
                                                          Directory.CreateDirectory(tempFolderPath)
                                                      End If

                                                      File.WriteAllBytes(tempFilePath, Attachment.FileBytes)

                                                      Dim psi = New ProcessStartInfo(tempFilePath) With {
                                                        .UseShellExecute = True
                                                       }

                                                      Dim fileOpeningProcess As Process = Process.Start(psi)

                                                  Catch ex As Exception

                                                      Dim EventCode = 12

                                                      Dim DialogBoxOK As New DialogBoxOK(EventCode, ex.Message) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}

                                                      DialogBoxOK.ShowDialog()

                                                  End Try


                                              End Sub
                Exit Select
            Case ".xls", ".xlsx"
                Dim pictureExcel As New PictureBox With {
                        .Size = New Size(30, 30),
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .SizeMode = PictureBoxSizeMode.Zoom,
                        .Image = My.Resources.icons8_excel_24,
                        .Anchor = AnchorStyles.Left,
                        .Margin = New Padding(0)
                        }
                panelFiles.Controls.Add(pictureExcel)

                Dim label As New Label With {
                .Text = If(Attachment.FileName.Length < 7, Attachment.FileName & Attachment.FileExtension, Attachment.FileName.Substring(0, 7) & Attachment.FileExtension),
                .Font = New Font("Roboto", 8, FontStyle.Regular),
                .ForeColor = SystemColors.ControlDarkDark,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Anchor = AnchorStyles.Left,
                .Margin = New Padding(0)
                }

                ' Add the MouseEnter event handler
                AddHandler pictureExcel.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                        ' Change the appearance of the control when the mouse enters
                                                        pictureExcel.BackColor = SystemColors.Control
                                                        pictureExcel.Size = New Size(28, 28)
                                                    End Sub

                ' Add the MouseLeave event handler
                AddHandler pictureExcel.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                        ' Change the appearance of the control when the mouse leaves
                                                        pictureExcel.BackColor = Color.Transparent
                                                        pictureExcel.Size = New Size(30, 30)
                                                    End Sub

                panelFiles.Controls.Add(label)

                ' Add click event handler to open the Excel file
                AddHandler pictureExcel.Click, Sub(sender As Object, e As EventArgs)

                                                   Try

                                                       Dim tempFolderPath As String = Path.Combine(Path.GetTempPath(), "HRIS 2024")
                                                       Dim tempFilePath As String = Path.Combine(tempFolderPath, Attachment.FileName & Attachment.FileExtension)

                                                       If Not Directory.Exists(tempFolderPath) Then
                                                           Directory.CreateDirectory(tempFolderPath)
                                                       End If

                                                       File.WriteAllBytes(tempFilePath, Attachment.FileBytes)

                                                       Dim psi = New ProcessStartInfo(tempFilePath) With {
                                                        .UseShellExecute = True
                                                       }

                                                       Dim fileOpeningProcess As Process = Process.Start(psi)

                                                   Catch ex As Exception

                                                       Dim EventCode = 12

                                                       Dim DialogBoxOK As New DialogBoxOK(EventCode, ex.Message) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}

                                                       DialogBoxOK.ShowDialog()

                                                   End Try


                                               End Sub
                Exit Select
            Case ".pdf"
                Dim picturePDF As New PictureBox With {
                            .Size = New Size(30, 30),
                            .BackgroundImageLayout = ImageLayout.Zoom,
                            .SizeMode = PictureBoxSizeMode.Zoom,
                            .Image = My.Resources.icons8_pdf_24,
                        .Anchor = AnchorStyles.Left,
                        .Margin = New Padding(0)
                            }
                panelFiles.Controls.Add(picturePDF)

                Dim label As New Label With {
                .Text = If(Attachment.FileName.Length < 7, Attachment.FileName & Attachment.FileExtension, Attachment.FileName.Substring(0, 7) & Attachment.FileExtension),
                .Font = New Font("Roboto", 8, FontStyle.Regular),
                .ForeColor = SystemColors.ControlDarkDark,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Anchor = AnchorStyles.Left,
                .Margin = New Padding(0)
                }

                ' Add the MouseEnter event handler
                AddHandler picturePDF.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                      ' Change the appearance of the control when the mouse enters
                                                      picturePDF.BackColor = SystemColors.Control
                                                      picturePDF.Size = New Size(28, 28)
                                                  End Sub

                ' Add the MouseLeave event handler
                AddHandler picturePDF.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                      ' Change the appearance of the control when the mouse leaves
                                                      picturePDF.BackColor = Color.Transparent
                                                      picturePDF.Size = New Size(30, 30)
                                                  End Sub

                panelFiles.Controls.Add(label)

                ' Add click event handler to open the Word file
                AddHandler picturePDF.Click, Sub(sender As Object, e As EventArgs)

                                                 Try

                                                     Dim tempFolderPath As String = Path.Combine(Path.GetTempPath(), "HRIS 2024")
                                                     Dim tempFilePath As String = Path.Combine(tempFolderPath, Attachment.FileName & Attachment.FileExtension)

                                                     If Not Directory.Exists(tempFolderPath) Then
                                                         Directory.CreateDirectory(tempFolderPath)
                                                     End If

                                                     File.WriteAllBytes(tempFilePath, Attachment.FileBytes)

                                                     Dim psi = New ProcessStartInfo(tempFilePath) With {
                                                        .UseShellExecute = True
                                                       }

                                                     Dim fileOpeningProcess As Process = Process.Start(psi)

                                                 Catch ex As Exception

                                                     Dim EventCode = 12

                                                     Dim DialogBoxOK As New DialogBoxOK(EventCode, ex.Message) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}

                                                     DialogBoxOK.ShowDialog()

                                                 End Try

                                             End Sub
                Exit Select
            Case ".zip", ".rar"
                Dim pictureZIP As New PictureBox With {
                       .Size = New Size(30, 30),
                       .BackgroundImageLayout = ImageLayout.Zoom,
                       .SizeMode = PictureBoxSizeMode.Zoom,
                       .Image = My.Resources.icons8_zip_24,
                       .Anchor = AnchorStyles.Left,
                       .Margin = New Padding(0)
                       }

                panelFiles.Controls.Add(pictureZIP)

                Dim label As New Label With {
                .Text = If(Attachment.FileName.Length < 7, Attachment.FileName & Attachment.FileExtension, Attachment.FileName.Substring(0, 7) & Attachment.FileExtension),
                .Font = New Font("Roboto", 8, FontStyle.Regular),
                .ForeColor = SystemColors.ControlDarkDark,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Anchor = AnchorStyles.Left,
                .Margin = New Padding(0)
                }

                ' Add the MouseEnter event handler
                AddHandler pictureZIP.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                      ' Change the appearance of the control when the mouse enters
                                                      pictureZIP.BackColor = SystemColors.Control
                                                      pictureZIP.Size = New Size(28, 28)
                                                  End Sub

                ' Add the MouseLeave event handler
                AddHandler pictureZIP.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                      ' Change the appearance of the control when the mouse leaves
                                                      pictureZIP.BackColor = Color.Transparent
                                                      pictureZIP.Size = New Size(30, 30)
                                                  End Sub

                panelFiles.Controls.Add(label)

                ' Add click event handler to open the Excel file
                AddHandler pictureZIP.Click, Sub(sender As Object, e As EventArgs)


                                                 Dim EventCode = 13

                                                 Dim DialogBoxOK As New DialogBoxOK(EventCode) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}

                                                 DialogBoxOK.ShowDialog()


                                             End Sub
                Exit Select

        End Select

    End Sub


    Public Shared Async Function DownloadAttachments(selectedFolderPath As String, attachments As List(Of HRIS2024.Models.Attachment)) As Task

        For Each AttachmentFile As HRIS2024.Models.Attachment In attachments

            Dim fileName As String = AttachmentFile.FileName & AttachmentFile.FileExtension
            Dim filePath As String = Path.Combine(selectedFolderPath, fileName)
            Dim counter As Integer = 0

            While File.Exists(filePath)
                Dim extension As String = Path.GetExtension(fileName)
                counter += 1
                Dim newFileName As String = $"{Path.GetFileNameWithoutExtension(fileName)} ({counter}){extension}"
                filePath = Path.Combine(selectedFolderPath, newFileName)
            End While

            Using fs As New FileStream(filePath, FileMode.Create)
                Await fs.WriteAsync(AttachmentFile.FileBytes, 0, AttachmentFile.FileBytes.Length)
            End Using

        Next


    End Function

End Class
