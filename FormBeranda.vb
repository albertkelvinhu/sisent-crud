Imports Bunifu
Public Class FormBeranda
    Dim bunifufb As New Bunifu.Framework.UI.BunifuFlatButton
    Dim bunifufm As Bunifu.Framework.UI.Drag = New Bunifu.Framework.UI.Drag

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub Header_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Header_panel.MouseDown
        bunifufm.Grab(Me)
    End Sub

    Private Sub Header_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles Header_panel.MouseUp
        bunifufm.Release()
    End Sub

    Private Sub Header_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Header_panel.MouseMove
        bunifufm.MoveObject()
    End Sub

    Private Sub Beranda_button_Click(sender As Object, e As EventArgs) Handles Beranda_button.Click
        UC_control(UserControl11, InventoryUC1)
    End Sub
    Private Sub Inventory_button_Click(sender As Object, e As EventArgs) Handles Inventory_button.Click
        UC_control(InventoryUC1, UserControl11)
    End Sub

    Private Sub UC_control(sender As Object, sender2 As Object)
        sender.Show()
        sender2.Hide()
    End Sub

End Class