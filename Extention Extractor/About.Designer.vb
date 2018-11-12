<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Lbl_AboutContent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LLbl_Email = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_AboutContent
        '
        Me.Lbl_AboutContent.AutoSize = True
        Me.Lbl_AboutContent.Location = New System.Drawing.Point(32, 43)
        Me.Lbl_AboutContent.Name = "Lbl_AboutContent"
        Me.Lbl_AboutContent.Size = New System.Drawing.Size(219, 169)
        Me.Lbl_AboutContent.TabIndex = 0
        Me.Lbl_AboutContent.Text = resources.GetString("Lbl_AboutContent.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Extention Extractor Version 1.0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.LLbl_Email)
        Me.Panel1.Controls.Add(Me.Lbl_AboutContent)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(25, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 220)
        Me.Panel1.TabIndex = 2
        '
        'LLbl_Email
        '
        Me.LLbl_Email.AutoSize = True
        Me.LLbl_Email.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLbl_Email.Location = New System.Drawing.Point(44, 186)
        Me.LLbl_Email.Name = "LLbl_Email"
        Me.LLbl_Email.Size = New System.Drawing.Size(132, 13)
        Me.LLbl_Email.TabIndex = 2
        Me.LLbl_Email.TabStop = True
        Me.LLbl_Email.Text = "rehansidiquii@hotmail.com"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_AboutContent As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LLbl_Email As System.Windows.Forms.LinkLabel
End Class
