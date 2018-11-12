Imports System.IO
Imports System.IO.Directory
Imports System.Threading
Imports System.ComponentModel

Public Class DialogueBox
    Dim eventobject As New EventsandFunctions
    Delegate Sub SetTextCallBack(ByVal text As String) 'For Thread-Safe Text Setting to 'Lbl_FileNames'
    Delegate Sub RefreashLabelDelegate() 'For Thread-Safe Refreshing the Control 'Lbl_FileNames'

    Private Sub DialogueBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_BrowseDirectory.Click
        FolderBrowserDialog1.Description() = "Select The Directory to Scan"
        FolderBrowserDialog1.ShowDialog()
        TxtBx_DirectoryToScan.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Btn_FileToSave_Click(sender As Object, e As EventArgs) Handles Btn_FileToSave.Click
        SaveFileDialog1.Title = "Select Directory to Store the Extension File"
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.AddExtension = True 'Automatically Adding Extension To FIle
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|Word Document (*.doc)|*.doc|All files (*.*)|*.*" 'Optional Extensions Available to User While Saving The File 
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TxtB_SaveFilePath.Text = SaveFileDialog1.FileName 'User Specified SaveFilePath
        End If
    End Sub

    Private Sub Btn_Extract_Click(sender As Object, e As EventArgs) Handles Btn_Extract.Click

        EventObject.FileCounterToZero()
        EventObject.DirectoryCountertoZero()
        Btn_BrowseDirectory.Enabled = False 'Disabling the Button Control While Scanning the Files
        Btn_FileToSave.Enabled = False 'Disabling the Button Control While Scanning the Files
        ChckB_RemoveDot.Enabled = False 'Disabling the CheckBox Control While Scanning the Files 
        If TxtB_SaveFilePath.Text = Nothing Or TxtBx_DirectoryToScan.Text = Nothing Then
            MessageBox.Show("Scan Path, Output File Path or Both Missing", "Error")
            Btn_BrowseDirectory.Enabled = True
            Btn_FileToSave.Enabled = True
            ChckB_RemoveDot.Enabled = True
        Else
            If BackgroundWorker.IsBusy <> True Then
                BackgroundWorker.RunWorkerAsync(EventObject)
            End If
        End If
        
    End Sub

    Private Sub Btn_StopExt_Click(sender As Object, e As EventArgs) Handles Btn_StopExt.Click
        If BackgroundWorker.WorkerSupportsCancellation = True Then
            BackgroundWorker.CancelAsync()
        End If
        eventobject.DirectoryCountertoZero()
        eventobject.FileCounterToZero()

    End Sub
#Region "ThreadSafe Method for Setting Text In the Label"
    Public Sub SetText(ByVal Text As String)
        If Me.Lbl_FileNames.InvokeRequired Then
            Dim d As New SetTextCallBack(AddressOf SetText)
            Me.Invoke(d, New Object() {Text})
        Else
            Me.Lbl_FileNames.Text = CompactString(Text, Lbl_FileNames.Width, Lbl_FileNames.Font, TextFormatFlags.PathEllipsis)
        End If
    End Sub
#End Region
#Region "ThreadSafe Method for Refreshing the Label"
    Public Sub RefreshLabel()
        If Me.Lbl_FileNames.InvokeRequired Then
            Dim d As New RefreashLabelDelegate(AddressOf RefreshLabel)
            Me.Invoke(d)
        Else
            Me.Lbl_FileNames.Refresh()

        End If
    End Sub
#End Region
#Region "Method for DoWork Event of BackGroundWorker"

    '1) It Adds Handles for FileScanned and DirectoryScanned Events to Count Number of Files, Directories scanned
    '2) Then It Checks For Empty TextFields, Gives Error IF TextFields Are Empty and Starts The Time Consuming Operation If TExtFields are Not Empty by Calling 'RecursivelyScanFiles' Method.
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

        AddHandler EventObject.FilesScanned, AddressOf EventObject.FilesScannedCounterIncrease
        AddHandler EventObject.DirectoryScanned, AddressOf EventObject.DirectoryScannedCounterIncrease
        EventObject.RecursivelyScanFiles(TxtBx_DirectoryToScan.Text, Me, Me.BackgroundWorker)
    End Sub
#End Region

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged

    End Sub
#Region "RunWorkerCompleted Event Handler"
    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        If ChckB_RemoveDot.Checked Then
            EventObject.WriteExtensionsToFileWithoutDot(TxtB_SaveFilePath.Text)
        Else
            EventObject.WriteExtensionsToFile(TxtB_SaveFilePath.Text)
        End If
        'Showing Number of Files and Directory Scanned
        MessageBox.Show("Operation Completed Successfully." & vbCrLf & vbCrLf & "Total Directory Scanned: " & EventObject.DirectoryCounterReturn & vbCrLf & "Total Files Scanned: " & EventObject.FileCounterReturn, "Completion Notification")
        Process.Start("notepad.exe", TxtB_SaveFilePath.Text) 'Showing the Extension File to User
        If e.Cancelled = True Then
            Lbl_FileNames.Text = "Cancelled"
        ElseIf e.Error IsNot Nothing Then
            Lbl_FileNames.Text = "Error"
        Else
            Lbl_FileNames.Text = "Scanning && Writing Completed"
        End If
        Btn_BrowseDirectory.Enabled = True 'Enabling the Control After Scanning
        Btn_FileToSave.Enabled = True 'Enabling the Control After Scanning
        ChckB_RemoveDot.Enabled = True 'Enabling the Control After Scanning 

    End Sub
#End Region
    'Setting the Text in Label in a Limited Width and Inserting Ellipsis When Needed
    Function CompactString(ByVal MyString As String, ByVal Width As Integer, ByVal Font As Drawing.Font, ByVal FormatFlags As Windows.Forms.TextFormatFlags) As String
        Dim Result As String = String.Copy(MyString)
        TextRenderer.MeasureText(Result, Font, New Drawing.Size(Width, 0), FormatFlags Or TextFormatFlags.ModifyString)
        Return Result
    End Function
   
End Class