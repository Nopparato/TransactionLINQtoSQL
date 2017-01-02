Option Explicit On
Option Strict On
Imports System.Transactions

Public Class Form1
    Dim db As New dbNorthwindDataContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cs = From c In db.Categories
        If cs.Count() > 0 Then
            With cboCategory
                .BeginUpdate()
                .DisplayMember = "CategoryName"
                .ValueMember = "CategoryID"
                .DataSource = cs.ToList()
                .EndUpdate()
            End With
        End If
        Dim ss = From s In db.Suppliers
        If ss.Count() > 0 Then
            With cboSupplier
                .BeginUpdate()
                .DisplayMember = "CompanyName"
                .ValueMember = "SupplierID"
                .DataSource = ss.ToList
                .EndUpdate()
            End With
            ShowProduct()
            FormatDgvProductList()
        End If
    End Sub

    Private Sub ShowProduct()
        Dim ps = From p In db.Products
                 From c In db.Categories
                 From s In db.Suppliers
                 Where p.CategoryID = c.CategoryID AndAlso p.SupplierID = s.SupplierID
                 Select New With {
                     .ProductID = p.ProductID,
                     .ProductName = p.ProductName,
                     .CategoryName = c.CategoryName,
                     .CompanyName = s.CompanyName
        }
        dgvProductsList.DataSource = ps.ToList()
    End Sub

    Private Sub FormatDgvProductList()
        With dgvProductsList
            If .RowCount > 0 Then
                .Columns(0).HeaderText = "รหัสสินค้า"
                .Columns(1).HeaderText = "ชื่อสินค้า"
                .Columns(2).HeaderText = "ประเภทสินค้า"
                .Columns(3).HeaderText = "จัดจำหน่าย"
                .Columns(0).Width = 80
                .Columns(1).Width = 150
                .Columns(2).Width = 100
                .Columns(3).Width = 100
            End If
        End With
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        db.Connection.Close()
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ClearAllData()
        txtProductName.Focus()
    End Sub

    Private Sub ClearAllData()
        lblProductID.Text = ""
        txtProductName.Clear()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim result = CheckProductData()
        If result = True Then
            Dim p As New Product()
            p.ProductName = txtProductName.Text
            p.CategoryID = Convert.ToInt32(cboCategory.SelectedValue)
            p.SupplierID = Convert.ToInt32(cboSupplier.SelectedValue)

            If MessageBox.Show("คุณต้องการเพิ่มข้อมูลสินค้าใหม่ ใช่หรือไม่?", "คำยืนยัน", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Using ts As New TransactionScope()
                    db.Products.InsertOnSubmit(p)
                    db.SubmitChanges()
                    ts.Complete()
                End Using
                ClearAllData()
                ShowProduct()
                MessageBox.Show("เพิ่มข้อมูลสินค้าใหม่ เรียบร้อยแล้ว", "ผลการทำงาน")
                txtProductName.Focus()
            End If
        End If
    End Sub

    Private Function CheckProductData() As Boolean
        CheckProductData = False
        If (txtProductName.Text.Trim() = "") OrElse (cboCategory.Text.Trim() = "") OrElse (cboSupplier.Text.Trim() = "") Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ!!", "ข้อผิดพลาด")
            txtProductName.Focus()
            txtProductName.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub dgvProductsList_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductsList.CellMouseUp
        'If e.RowIndex = -1 Then Exit Sub
        With dgvProductsList
            lblProductID.Text = .Rows.Item(e.RowIndex).Cells("ProductID").Value.ToString()
            txtProductName.Text = .Rows.Item(e.RowIndex).Cells("ProductName").Value.ToString()
            cboCategory.Text = .Rows.Item(e.RowIndex).Cells("CategoryName").Value.ToString()
            cboSupplier.Text = .Rows.Item(e.RowIndex).Cells("CompanyName").Value.ToString()
            txtProductName.Focus()
            txtProductName.SelectAll()
        End With
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim Result = CheckProductData()
        If Result = True Then
            Dim ps = (From p In db.Products
                      Where p.ProductID.ToString() = lblProductID.Text.Trim()
                      Select p).FirstOrDefault()
            If ps IsNot Nothing Then
                ps.ProductName = txtProductName.Text.Trim()
                ps.CategoryID = Convert.ToInt32(cboCategory.SelectedValue)
                ps.SupplierID = Convert.ToInt32(cboSupplier.SelectedValue)

                If MessageBox.Show("คุณต้องการแก้ไขข้อมูลสินค้า ใช่หรือไม่?", "คำยืนยัน", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Using ts As New TransactionScope()
                        db.SubmitChanges()
                        ts.Complete()
                    End Using
                    ClearAllData()
                    ShowProduct()
                    MessageBox.Show("แก้ไขข้อมูลสิน ค้าเรียบร้อยแล้ว", "ผลการทำงาน")
                    txtProductName.Focus()
                End If
            End If
        End If
    End Sub
End Class
