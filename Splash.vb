Public Class frmSplash

    Private Sub tmrSplashChange_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSplashChange.Tick
        picSplash2.Visible = True                               'Swap images
        picSplash.Visible = False
        tmrSplashChange.Enabled = False
    End Sub

    Private Sub tmrEndSplash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEndSplash.Tick
        frmControl.Show()                                       'Show Control form
        MyBase.Close()
        tmrEndSplash.Enabled = False
    End Sub

End Class