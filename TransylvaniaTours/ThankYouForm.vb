Public Class ThankYouForm

    Private Sub ThankYouForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'should use thread to show Thank you after 5 secs terminate app
    End Sub

    Private Sub TimerThankYou_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCloseApp.Tick
        Me.Close()
    End Sub
End Class