<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvAddressBook = New System.Windows.Forms.DataGridView()
        Me.clnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnPhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAddressBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(149, 136)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(251, 28)
        Me.txtName.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(409, 136)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(159, 28)
        Me.txtPhone.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(577, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(375, 28)
        Me.txtEmail.TabIndex = 3
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(149, 116)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(44, 16)
        Me.lbName.TabIndex = 6
        Me.lbName.Text = "Name"
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Location = New System.Drawing.Point(406, 116)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(97, 16)
        Me.lbPhone.TabIndex = 7
        Me.lbPhone.Text = "Phone Number"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(583, 114)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(94, 16)
        Me.lbEmail.TabIndex = 8
        Me.lbEmail.Text = "Email address"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(149, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(835, 64)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(117, 23)
        Me.btnDeleteAll.TabIndex = 10
        Me.btnDeleteAll.Text = "Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(699, 64)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Del. Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvAddressBook
        '
        Me.dgvAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddressBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnName, Me.clnPhoneNumber, Me.clnEmail})
        Me.dgvAddressBook.Location = New System.Drawing.Point(149, 181)
        Me.dgvAddressBook.Name = "dgvAddressBook"
        Me.dgvAddressBook.RowHeadersWidth = 51
        Me.dgvAddressBook.RowTemplate.Height = 24
        Me.dgvAddressBook.Size = New System.Drawing.Size(803, 350)
        Me.dgvAddressBook.TabIndex = 12
        '
        'clnName
        '
        Me.clnName.HeaderText = "Name"
        Me.clnName.MinimumWidth = 6
        Me.clnName.Name = "clnName"
        Me.clnName.Width = 250
        '
        'clnPhoneNumber
        '
        Me.clnPhoneNumber.HeaderText = "Phone Number"
        Me.clnPhoneNumber.MinimumWidth = 6
        Me.clnPhoneNumber.Name = "clnPhoneNumber"
        Me.clnPhoneNumber.Width = 150
        '
        'clnEmail
        '
        Me.clnEmail.HeaderText = "Email"
        Me.clnEmail.MinimumWidth = 6
        Me.clnEmail.Name = "clnEmail"
        Me.clnEmail.Width = 350
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 646)
        Me.Controls.Add(Me.dgvAddressBook)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbPhone)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvAddressBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbPhone As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvAddressBook As DataGridView
    Friend WithEvents clnName As DataGridViewTextBoxColumn
    Friend WithEvents clnPhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents clnEmail As DataGridViewTextBoxColumn
End Class
