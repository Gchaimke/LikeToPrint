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
        Me.BtnSendFile = New System.Windows.Forms.Button()
        Me.BtnSendString = New System.Windows.Forms.Button()
        Me.TxbMain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSendFile
        '
        Me.BtnSendFile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSendFile.Location = New System.Drawing.Point(0, 236)
        Me.BtnSendFile.MaximumSize = New System.Drawing.Size(100, 25)
        Me.BtnSendFile.Name = "BtnSendFile"
        Me.BtnSendFile.Size = New System.Drawing.Size(100, 25)
        Me.BtnSendFile.TabIndex = 0
        Me.BtnSendFile.Text = "Send File"
        Me.BtnSendFile.UseVisualStyleBackColor = True
        '
        'BtnSendString
        '
        Me.BtnSendString.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSendString.Location = New System.Drawing.Point(0, 213)
        Me.BtnSendString.MaximumSize = New System.Drawing.Size(100, 23)
        Me.BtnSendString.Name = "BtnSendString"
        Me.BtnSendString.Size = New System.Drawing.Size(100, 23)
        Me.BtnSendString.TabIndex = 1
        Me.BtnSendString.Text = "Send String"
        Me.BtnSendString.UseVisualStyleBackColor = True
        '
        'TxbMain
        '
        Me.TxbMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxbMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxbMain.Location = New System.Drawing.Point(0, 0)
        Me.TxbMain.Margin = New System.Windows.Forms.Padding(5)
        Me.TxbMain.Multiline = True
        Me.TxbMain.Name = "TxbMain"
        Me.TxbMain.Size = New System.Drawing.Size(368, 213)
        Me.TxbMain.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(368, 261)
        Me.Controls.Add(Me.TxbMain)
        Me.Controls.Add(Me.BtnSendString)
        Me.Controls.Add(Me.BtnSendFile)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSendFile As Button
    Friend WithEvents BtnSendString As Button
    Friend WithEvents TxbMain As TextBox
End Class
