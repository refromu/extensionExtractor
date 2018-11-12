Public Class About

    Private Sub LLbl_Email_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLbl_Email.LinkClicked
        Process.Start("iexplore.exe", "www.hotmail.com")
    End Sub
End Class