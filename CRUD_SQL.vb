
Public Class CRUD_SQL
    Dim Proses As New clsKoneksi
    Dim TblMhs As DataTable
    Dim SSQL As String

    Private Sub Kosong()
        txtNim.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtJurusan.Text = ""
        txtNim.Focus()
    End Sub

    Private Sub TampilData()
        TblMhs = Proses.ExecuteQuery("SELECT * FROM tbl_Mahasiswa")
        DGV.DataSource = TblMhs
        DGV.ReadOnly = True
    End Sub

    Private Sub CRUD_SQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "&Save" Then
                SSQL = ""
                SSQL = "INSERT INTO Tbl_Mahasiswa VALUES('" & txtNim.Text & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & txtJurusan.Text & "')"
                Proses.ExecuteNonQuery(SSQL)
                Call Kosong()
                Call TampilData()
            ElseIf btnSave.Text = "&Update" Then
                SSQL = ""
                SSQL = "UPDATE Tbl_Mahasiswa Set nama='" & txtNama.Text & "',Alamat='" & txtAlamat.Text & "',jurusan='" & txtJurusan.Text & "' WHERE nim='" & txtNim.Text & "'"
                Proses.ExecuteNonQuery(SSQL)

                Call Kosong()
                Call TampilData()
                btnSave.Text = "&Save"
                txtNim.Enabled = True

            End If
        Catch ex As Exception
            MessageBox.Show("Proses Penyimpanan Gagal !, Karena " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call Kosong()
        btnSave.Text = "&Save"
        txtNim.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin Data Ini Akan dihapus?", "Konfirmasi...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            SSQL = ""
            SSQL = "DELETE FROM Tbl_Mahasiswa WHERE nim ='" & txtNim.Text & "'"
            Proses.ExecuteNonQuery(SSQL)

            Call Kosong()
            Call TampilData()

            txtNim.Enabled = True
            btnSave.Text = "&Save"

        Else
            Call Kosong()
            txtNim.Enabled = True
            btnSave.Text = "&Save"
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub DGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.DoubleClick
        txtNim.Text = DGV.Item(0, DGV.CurrentRow.Index).Value
        txtNama.Text = DGV.Item(1, DGV.CurrentRow.Index).Value
        txtAlamat.Text = DGV.Item(2, DGV.CurrentRow.Index).Value
        txtJurusan.Text = DGV.Item(3, DGV.CurrentRow.Index).Value
        btnSave.Text = "&Update"
        txtNim.Enabled = False
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class
