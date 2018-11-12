<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogueBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_DirectoryToScan = New System.Windows.Forms.Label()
        Me.TxtBx_DirectoryToScan = New System.Windows.Forms.TextBox()
        Me.TxtB_SaveFilePath = New System.Windows.Forms.TextBox()
        Me.Btn_BrowseDirectory = New System.Windows.Forms.Button()
        Me.Btn_FileToSave = New System.Windows.Forms.Button()
        Me.ChckB_RemoveDot = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Btn_Extract = New System.Windows.Forms.Button()
        Me.Lbl_FileToSaveExtention = New System.Windows.Forms.Label()
        Me.Lbl_FileNames = New System.Windows.Forms.Label()
        Me.Btn_StopExt = New System.Windows.Forms.Button()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Lbl_DirectoryToScan
        '
        Me.Lbl_DirectoryToScan.AutoSize = True
        Me.Lbl_DirectoryToScan.Location = New System.Drawing.Point(13, 31)
        Me.Lbl_DirectoryToScan.Name = "Lbl_DirectoryToScan"
        Me.Lbl_DirectoryToScan.Size = New System.Drawing.Size(95, 17)
        Me.Lbl_DirectoryToScan.TabIndex = 0
        Me.Lbl_DirectoryToScan.Text = "Directory To Scan"
        Me.Lbl_DirectoryToScan.UseCompatibleTextRendering = True
        Me.Lbl_DirectoryToScan.UseWaitCursor = True
        '
        'TxtBx_DirectoryToScan
        '
        Me.TxtBx_DirectoryToScan.Location = New System.Drawing.Point(112, 24)
        Me.TxtBx_DirectoryToScan.Name = "TxtBx_DirectoryToScan"
        Me.TxtBx_DirectoryToScan.Size = New System.Drawing.Size(308, 20)
        Me.TxtBx_DirectoryToScan.TabIndex = 2
        '
        'TxtB_SaveFilePath
        '
        Me.TxtB_SaveFilePath.Location = New System.Drawing.Point(163, 59)
        Me.TxtB_SaveFilePath.Name = "TxtB_SaveFilePath"
        Me.TxtB_SaveFilePath.Size = New System.Drawing.Size(257, 20)
        Me.TxtB_SaveFilePath.TabIndex = 3
        '
        'Btn_BrowseDirectory
        '
        Me.Btn_BrowseDirectory.Location = New System.Drawing.Point(426, 21)
        Me.Btn_BrowseDirectory.Name = "Btn_BrowseDirectory"
        Me.Btn_BrowseDirectory.Size = New System.Drawing.Size(75, 23)
        Me.Btn_BrowseDirectory.TabIndex = 4
        Me.Btn_BrowseDirectory.Text = "Browse"
        Me.Btn_BrowseDirectory.UseVisualStyleBackColor = True
        '
        'Btn_FileToSave
        '
        Me.Btn_FileToSave.Location = New System.Drawing.Point(426, 56)
        Me.Btn_FileToSave.Name = "Btn_FileToSave"
        Me.Btn_FileToSave.Size = New System.Drawing.Size(75, 23)
        Me.Btn_FileToSave.TabIndex = 5
        Me.Btn_FileToSave.Text = "Browse"
        Me.Btn_FileToSave.UseVisualStyleBackColor = True
        '
        'ChckB_RemoveDot
        '
        Me.ChckB_RemoveDot.AutoSize = True
        Me.ChckB_RemoveDot.Location = New System.Drawing.Point(267, 96)
        Me.ChckB_RemoveDot.Name = "ChckB_RemoveDot"
        Me.ChckB_RemoveDot.Size = New System.Drawing.Size(153, 17)
        Me.ChckB_RemoveDot.TabIndex = 6
        Me.ChckB_RemoveDot.Text = "Remove 'Dot' in Extentions"
        Me.ChckB_RemoveDot.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        '
        'Btn_Extract
        '
        Me.Btn_Extract.Location = New System.Drawing.Point(152, 154)
        Me.Btn_Extract.Name = "Btn_Extract"
        Me.Btn_Extract.Size = New System.Drawing.Size(105, 23)
        Me.Btn_Extract.TabIndex = 8
        Me.Btn_Extract.Text = "Extract Extentions"
        Me.Btn_Extract.UseVisualStyleBackColor = True
        '
        'Lbl_FileToSaveExtention
        '
        Me.Lbl_FileToSaveExtention.AutoSize = True
        Me.Lbl_FileToSaveExtention.Location = New System.Drawing.Point(12, 66)
        Me.Lbl_FileToSaveExtention.Name = "Lbl_FileToSaveExtention"
        Me.Lbl_FileToSaveExtention.Size = New System.Drawing.Size(141, 13)
        Me.Lbl_FileToSaveExtention.TabIndex = 9
        Me.Lbl_FileToSaveExtention.Text = "File To Save The Extentions"
        '
        'Lbl_FileNames
        '
        Me.Lbl_FileNames.AutoEllipsis = True
        Me.Lbl_FileNames.AutoSize = True
        Me.Lbl_FileNames.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl_FileNames.Location = New System.Drawing.Point(13, 130)
        Me.Lbl_FileNames.MaximumSize = New System.Drawing.Size(500, 13)
        Me.Lbl_FileNames.MinimumSize = New System.Drawing.Size(500, 13)
        Me.Lbl_FileNames.Name = "Lbl_FileNames"
        Me.Lbl_FileNames.Size = New System.Drawing.Size(500, 13)
        Me.Lbl_FileNames.TabIndex = 10
        '
        'Btn_StopExt
        '
        Me.Btn_StopExt.Location = New System.Drawing.Point(253, 154)
        Me.Btn_StopExt.Name = "Btn_StopExt"
        Me.Btn_StopExt.Size = New System.Drawing.Size(105, 23)
        Me.Btn_StopExt.TabIndex = 11
        Me.Btn_StopExt.Text = "Stop Extraction"
        Me.Btn_StopExt.UseVisualStyleBackColor = True
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'DialogueBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Extention_Extractor.My.Resources.Resources.wallpaper_131761
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 189)
        Me.Controls.Add(Me.Btn_StopExt)
        Me.Controls.Add(Me.Lbl_FileNames)
        Me.Controls.Add(Me.Lbl_FileToSaveExtention)
        Me.Controls.Add(Me.Btn_Extract)
        Me.Controls.Add(Me.ChckB_RemoveDot)
        Me.Controls.Add(Me.Btn_FileToSave)
        Me.Controls.Add(Me.Btn_BrowseDirectory)
        Me.Controls.Add(Me.TxtB_SaveFilePath)
        Me.Controls.Add(Me.TxtBx_DirectoryToScan)
        Me.Controls.Add(Me.Lbl_DirectoryToScan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(539, 223)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(539, 223)
        Me.Name = "DialogueBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extention Extractor 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_DirectoryToScan As System.Windows.Forms.Label
    Friend WithEvents TxtBx_DirectoryToScan As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_SaveFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Btn_BrowseDirectory As System.Windows.Forms.Button
    Friend WithEvents Btn_FileToSave As System.Windows.Forms.Button
    Friend WithEvents ChckB_RemoveDot As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Btn_Extract As System.Windows.Forms.Button
    Friend WithEvents Lbl_FileToSaveExtention As System.Windows.Forms.Label
    Friend WithEvents Lbl_FileNames As System.Windows.Forms.Label
    Friend WithEvents Btn_StopExt As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
