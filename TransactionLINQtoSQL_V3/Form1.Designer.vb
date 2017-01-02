<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProductsList = New System.Windows.Forms.DataGridView()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductsList
        '
        Me.dgvProductsList.AllowUserToAddRows = False
        Me.dgvProductsList.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.dgvProductsList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductsList.BackgroundColor = System.Drawing.Color.Azure
        Me.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductsList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvProductsList.Location = New System.Drawing.Point(13, 156)
        Me.dgvProductsList.MultiSelect = False
        Me.dgvProductsList.Name = "dgvProductsList"
        Me.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductsList.Size = New System.Drawing.Size(505, 279)
        Me.dgvProductsList.TabIndex = 58
        Me.dgvProductsList.TabStop = False
        '
        'cmdClear
        '
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClear.Location = New System.Drawing.Point(365, 71)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 52
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lblProductID
        '
        Me.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblProductID.Location = New System.Drawing.Point(123, 19)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(71, 20)
        Me.lblProductID.TabIndex = 57
        '
        'cboSupplier
        '
        Me.cboSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(123, 98)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(190, 21)
        Me.cboSupplier.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "บริษัทจัดจำหน่าย :"
        '
        'cboCategory
        '
        Me.cboCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(123, 71)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(190, 21)
        Me.cboCategory.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "ประเภทสินค้า :"
        '
        'cmdEdit
        '
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.Location = New System.Drawing.Point(365, 45)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 51
        Me.cmdEdit.Text = "แก้ไขข้อมูล"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Location = New System.Drawing.Point(365, 19)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 50
        Me.cmdAdd.Text = "เพิ่มข้อมูล"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(123, 45)
        Me.txtProductName.MaxLength = 40
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(190, 20)
        Me.txtProductName.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "รหัสสินค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "ชื่อสินค้า :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 445)
        Me.Controls.Add(Me.dgvProductsList)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.cboSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductsList As DataGridView
    Friend WithEvents cmdClear As Button
    Friend WithEvents lblProductID As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
