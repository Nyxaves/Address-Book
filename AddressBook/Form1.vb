Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAddressBook.Columns.Add("Name", "Name")
        dgvAddressBook.Columns.Add("Phone", "Phone Number")
        dgvAddressBook.Columns.Add("Email", "Email")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text.Trim() <> "" And txtPhone.Text.Trim() <> "" And txtEmail.Text.Trim() <> "" Then
            dgvAddressBook.Rows.Add(txtName.Text, txtPhone.Text, txtEmail.Text)

            txtName.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
        Else
            MsgBox("Fill all the informations!")
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        dgvAddressBook.Rows.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvAddressBook.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvAddressBook.SelectedRows
                dgvAddressBook.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
