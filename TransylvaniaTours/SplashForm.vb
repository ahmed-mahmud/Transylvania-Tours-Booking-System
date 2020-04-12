Public Class SplashForm

    Private Sub TimerSplash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGoOrder.Tick
        Me.Hide()
        TimerGoOrder.Enabled = False
        OrderForm.Show()
    End Sub


End Class
