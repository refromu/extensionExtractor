Imports System.IO.Directory
Imports System.IO

Public Class EventsandFunctions
    Dim Extensions As New List(Of String) 'Is Used both in scanning and writing the extention to file
    Public Event FilesScanned(ByVal sender As Object, ByVal e As EventArgs) 'This event is raised every time a file is scanned to count he files
    Dim FilesCounter As Integer 'Counter to show the number of scanned files.
    Public Event DirectoryScanned(ByVal sender As Object, ByVal e As EventArgs) 'This event is raised every time a directory is scanned to count the directories
    Dim DirectoryCounter As Integer 'Counter to show the number of scanned directories.

    'This method is called every time the FileScanned event is raised and increases the counter.
    Public Sub FilesScannedCounterIncrease(ByVal sender As Object, ByVal e As EventArgs)
        Me.FilesCounter += 1
    End Sub
    'This method is called every time the DirectoryScanned event is raised and increases the counter.
    Public Sub DirectoryScannedCounterIncrease(ByVal sender As Object, ByVal e As EventArgs)
        Me.DirectoryCounter += 1
    End Sub
    '1) Checks for CancellationPending Property of BackGroundWorker in Each Recursion, Cancel the Async Operation if it's true.
    '2) Checks the Path Argument if its Null.
    '3) Extract Extention of Each File Which has Extention and a Valid File Name andPut it in The 'Extensions' List.
    '4) While Scanning and Adding Extensions to List, this Method Displays the File Name of the File being Scanned to User through a Label.
    '5) Raises Event FileScanned to Increase the FileScanned Counter.
    '6) Checks Nullability of 'Path' Argument and Validity of Directory Name.
    '7) Calls Itself REcursively to Scan all The Files in The Current Directory.
#Region "Method to Scan Files Recursively"
    Public Sub RecursivelyScanFiles(ByVal Path As String, ByVal ObjectDb As DialogueBox, ByVal BW As System.ComponentModel.BackgroundWorker)
        If BW.CancellationPending = True Then
            BW.CancelAsync()
        Else
            If Path <> Nothing Then
                For Each File In GetFiles(Path)
                    If File.Length < 260 Then
                        If System.IO.Path.HasExtension(File) = True Then
                            Extensions.Add(System.IO.Path.GetExtension(File).ToLower)
                        End If
                        ObjectDb.SetText(File)
                        ObjectDb.RefreshLabel()
                        RaiseEvent FilesScanned(Me, EventArgs.Empty)
                    End If
                Next
            End If
            If Path <> Nothing Then
                For Each SubDir In GetDirectories(Path)
                    If SubDir.Length < 248 Then
                        Try
                            RaiseEvent DirectoryScanned(Me, EventArgs.Empty)
                            RecursivelyScanFiles(SubDir, ObjectDb, BW)
                        Catch ex As UnauthorizedAccessException
                            Continue For
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                        End Try
                    End If
                Next
            End If

        End If
    End Sub
#End Region
    '1) Using the 'Extensions' List, Add only idstinct Items in a New List.
    '2) Using 'Path' Argument, Checks if File Already Exists. 
    '3) If File Exists Already, Delete the file, Create a New One and Write the Extensions in It Else Creats the File and Write Extensions.
#Region "Method to Write Extensions to A File with 'Dot'"
    Public Sub WriteExtensionsToFile(ByVal Path As String)
        Dim NoDupicateExtensions As New List(Of String)
        NoDupicateExtensions.AddRange(Extensions.Distinct)
        If Path <> Nothing Then
            Dim filein As New FileInfo(Path)
            If filein.Exists Then
                My.Computer.FileSystem.DeleteFile(Path)
                For Each item In NoDupicateExtensions
                    My.Computer.FileSystem.WriteAllText(Path, item & vbCrLf, True)
                Next
            Else
                For Each item In NoDupicateExtensions
                    My.Computer.FileSystem.WriteAllText(Path, item & vbCrLf, True)
                Next
            End If
        End If

    End Sub
#End Region
    '1) Same Operation As That of 'WriteExtensionsToFile' Method With One Difference, This Method Removes The Dot in Each Extension.
#Region "Method To Write Extensions to a File With 'Dot'"
    Public Sub WriteExtensionsToFileWithoutDot(ByVal Path As String)
        Dim NoDupicateExtensions As New List(Of String)
        NoDupicateExtensions.AddRange(Extensions.Distinct)
        Dim filein As New FileInfo(Path)
        If filein.Exists Then
            My.Computer.FileSystem.DeleteFile(Path)
            For Each item In NoDupicateExtensions
                Dim Extention = item.Remove(0, 1)
                My.Computer.FileSystem.WriteAllText(Path, Extention & vbCrLf, True)
            Next
        Else
            For Each item In NoDupicateExtensions
                Dim Extention = item.Remove(0, 1)
                My.Computer.FileSystem.WriteAllText(Path, Extention & vbCrLf, True)
            Next
        End If
    End Sub
#End Region
    Public Sub FileCounterToZero()
        Me.FilesCounter = 0
    End Sub
    Public Sub DirectoryCountertoZero()
        Me.DirectoryCounter = 0
    End Sub
    Public Function FileCounterReturn()
        Return Me.FilesCounter
    End Function
    Public Function DirectoryCounterReturn()
        Return Me.DirectoryCounter
    End Function

End Class
