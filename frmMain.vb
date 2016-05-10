Imports System.Drawing.Imaging
Imports System.Text.Encoding
Imports System.IO

Public Class frmMain
    Dim FileCount As Long
    Dim Precision As Integer
    Dim Cancelled As Boolean

    Private Sub cmdSource_Click(sender As Object, e As EventArgs) Handles cmdSource.Click
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog

        fd.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyPictures

        If fd.ShowDialog() = DialogResult.OK Then
            txtSource.Text = fd.SelectedPath
        End If
    End Sub

    Private Sub cmdEXIF_Click(sender As Object, e As EventArgs) Handles cmdEXIF.Click
        Dim S As BasicListItem
        S = cboPrecision.SelectedItem
        Precision = S.ID

        FileCount = 0

        cmdEXIF.Enabled = False
        cmdCancel.Enabled = True
        Cancelled = False
        Me.Cursor = Cursors.AppStarting

        Call ScanFolder(txtSource.Text)
        MessageBox.Show("Done!")

        cmdEXIF.Enabled = True
        cmdCancel.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ScanFolder(ByVal Foldername As String)
        If Cancelled = True Then
            Exit Sub
        End If

        ' This is the current folder as specified when entering this sub
        Dim CurrFolder As DirectoryInfo = New DirectoryInfo(Foldername)

        ' Loop round the subfolders
        Dim Subfolders As DirectoryInfo() = CurrFolder.GetDirectories()
        For Each Subfolder As DirectoryInfo In Subfolders
            If Cancelled = True Then
                Exit Sub
            End If
            Application.DoEvents()
            Call ScanFolder(Subfolder.FullName)
        Next

        ' Loop round the files in this folder
        lblStatus.Text = Foldername

        Dim Files As FileInfo() = CurrFolder.GetFiles()
        For Each File As FileInfo In Files
            If Cancelled = True Then
                Exit Sub
            End If
            Application.DoEvents()
            Dim Filename As String = File.FullName
            lblStatus.Text = Filename

            If Filename.ToUpper.EndsWith(".JPG") Or Filename.ToUpper.EndsWith(".JPEG") Then
                Dim FileDate As String = GetDateOfFile(Filename)
                Dim DestFolder As String = txtDest.Text

                If IsDate(FileDate) Then ' YYYY-MM-DD (0123-56-89)
                    Dim DP(2) As String
                    DP(0) = FileDate.Substring(0, 4)
                    DP(1) = FileDate.Substring(5, 2)
                    DP(2) = FileDate.Substring(8, 2)


                    For DL As Integer = 0 To 1
                        DestFolder = DestFolder & "\" & DP(DL)

                        If DL = 1 Then
                            DestFolder = DestFolder & " - " & MonthName(Val(DP(DL)), True)
                        End If
                        CheckFolderExists(DestFolder)
                    Next

                Else
                    DestFolder = DestFolder & "\Unknown"
                    CheckFolderExists(DestFolder)
                End If
                FileCount = FileCount + 1

                Dim FilesInFolder As Long
                FilesInFolder = CountFilesInFolder(DestFolder)

                Dim DestFileName As String
                Do
                    DestFileName = DestFolder & "\" & "PHO" & Format(FilesInFolder, "000000000") & ".jpg"
                    If My.Computer.FileSystem.FileExists(DestFileName) = False Then
                        Exit Do
                    End If

                    FilesInFolder = FilesInFolder + 1
                Loop

                My.Computer.FileSystem.CopyFile(Filename, DestFileName)
            End If
        Next

    End Sub

    Private Function CountFilesInFolder(ByVal FolderName As String) As Long
        Return My.Computer.FileSystem.GetDirectoryInfo(FolderName).GetFiles().Count
    End Function

    Private Sub CheckFolderExists(ByVal FolderName As String)
        If My.Computer.FileSystem.DirectoryExists(FolderName) = False Then
            My.Computer.FileSystem.CreateDirectory(FolderName)
        End If
    End Sub

    Private Sub cmdDest_Click(sender As Object, e As EventArgs) Handles cmdDest.Click
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog

        fd.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If fd.ShowDialog() = DialogResult.OK Then
            txtDest.Text = fd.SelectedPath
        End If
    End Sub

    Private Function GetDateOfFile(ByVal Filename As String) As String ' Returns YYYY-MM-DD
        ' 306 / 36867
        Dim RetVal As String = ""

        Try
            Dim Jpg As Bitmap = New Bitmap(Filename)
            Dim Props() As PropertyItem = Jpg.PropertyItems


            For Each MyItem As PropertyItem In Props
                If MyItem.Id = 36867 Then
                    RetVal = ASCII.GetString(MyItem.Value)
                    RetVal = RetVal.Substring(0, 10).Replace(":", "-")
                    Exit For
                End If
            Next

            If RetVal Like "[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]" Then
                ' It is a date!
            ElseIf chkFileDate.Checked = True Then
                Dim ThisPic As FileInfo = New FileInfo(Filename)

                RetVal = ThisPic.CreationTime.ToString("yyyy-MM-dd")
            End If
        Catch ex As Exception

        End Try

        Return RetVal
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Precision(3) As String
        Dim Item As BasicListItem

        Precision(1) = "Year"
        Precision(2) = "Month"
        Precision(3) = "Day"

        With cboPrecision
            For i As Integer = 1 To 3
                Item = New BasicListItem
                Item.Text = Precision(i)
                Item.ID = i

                .Items.Add(Item)
                Item = Nothing
            Next

            .SelectedIndex = 1
        End With
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Cancelled = True
        cmdCancel.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("PhotoOrganiser" & vbCrLf & vbCrLf & "(c) 2016 Paul Turner", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
