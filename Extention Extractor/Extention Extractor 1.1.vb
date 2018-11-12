Imports System.Threading

Public Class Title_Window

    Private Sub ExtractExtentionsMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractExtentionsMenuItem.Click
        Dim DB = New DialogueBox
        DB.Show()
    End Sub

    Private Sub CloseMenuItem_Click(sender As Object, e As EventArgs) Handles CloseMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
        Dim AB As New About
        AB.Show()
    End Sub

End Class
