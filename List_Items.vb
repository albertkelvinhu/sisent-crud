Public Class List_Items
    Dim Proses As New clsKoneksi
    Dim TblItems As DataTable

    Private Sub TampilData()
        TblItems = Proses.ExecuteQuery("SELECT * FROM tbl_Items")
        DGV.DataSource = TblItems
        DGV.ReadOnly = True
    End Sub

    Private Sub List_Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub

End Class