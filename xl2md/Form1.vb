Imports OfficeOpenXml
Public Class Form1
    Private Sub btnSelectWorkbook_Click(sender As Object, e As EventArgs) Handles btnSelectWorkbook.Click
        Dim dlg As New OpenFileDialog
        dlg.RestoreDirectory = True
        dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If dlg.ShowDialog = DialogResult.OK Then
            Me.txtExcelWorkbook.Text = dlg.FileName
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim ExcelFileInfo As New System.IO.FileInfo(Me.txtExcelWorkbook.Text)
        Using package As New ExcelPackage(ExcelFileInfo)
            For Each worksheet As ExcelWorksheet In package.Workbook.Worksheets
                If worksheet.Name.StartsWith("_") Then
                    '' skip this sheet
                Else
                    Dim Headers As New List(Of String)
                    Dim columnNumbers As New List(Of Integer)
                    Dim columnNumber As Integer = 1
                    Do While worksheet.Cells(1, columnNumber).Value IsNot Nothing
                        If worksheet.Cells(1, columnNumber).Value.ToString.StartsWith("_") Then
                            '' skip this column
                        Else
                            Headers.Add(worksheet.Cells(1, columnNumber).Value.ToString)
                            columnNumbers.Add(columnNumber)
                        End If
                        columnNumber += 1
                    Loop

                    Dim markdownTableHeader As New System.Text.StringBuilder
                    Dim markdownTableSpacer As New System.Text.StringBuilder
                    For Each header As String In Headers
                        If markdownTableHeader.Length > 0 Then
                            markdownTableHeader.Append(" | ")
                            markdownTableSpacer.Append("-|-")
                        End If
                        markdownTableHeader.Append(header)
                        markdownTableSpacer.Append("-----")
                    Next

                    Dim markdownTableData As New System.Text.StringBuilder
                    Dim rowNumber As Integer = 2
                    Do While worksheet.Cells(rowNumber, 1).Value IsNot Nothing
                        Dim markDownRow As New System.Text.StringBuilder
                        For Each c As Integer In columnNumbers
                            If markDownRow.Length > 0 Then
                                markDownRow.Append(" | ")
                            End If
                            If worksheet.Cells(rowNumber, c).Value IsNot Nothing Then
                                markDownRow.Append(worksheet.Cells(rowNumber, c).Value)
                            Else
                                markDownRow.Append(" ")
                            End If
                        Next
                        markdownTableData.AppendLine(markDownRow.ToString)
                        rowNumber += 1
                    Loop

                    Dim filename As String = worksheet.Name & ".txt"
                    Using sw As New System.IO.StreamWriter(filename, False)
                        sw.WriteLine(markdownTableHeader.ToString)
                        sw.WriteLine(markdownTableSpacer.ToString)
                        sw.WriteLine(markdownTableData.ToString)
                    End Using
                    Process.Start(filename)

                End If
            Next
        End Using


    End Sub






End Class
