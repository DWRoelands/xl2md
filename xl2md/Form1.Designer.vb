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
        Me.txtExcelWorkbook = New System.Windows.Forms.TextBox()
        Me.btnSelectWorkbook = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtExcelWorkbook
        '
        Me.txtExcelWorkbook.Location = New System.Drawing.Point(156, 11)
        Me.txtExcelWorkbook.Name = "txtExcelWorkbook"
        Me.txtExcelWorkbook.Size = New System.Drawing.Size(463, 20)
        Me.txtExcelWorkbook.TabIndex = 0
        '
        'btnSelectWorkbook
        '
        Me.btnSelectWorkbook.Location = New System.Drawing.Point(12, 11)
        Me.btnSelectWorkbook.Name = "btnSelectWorkbook"
        Me.btnSelectWorkbook.Size = New System.Drawing.Size(138, 21)
        Me.btnSelectWorkbook.TabIndex = 1
        Me.btnSelectWorkbook.Text = "Select Excel Workbook"
        Me.btnSelectWorkbook.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(623, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(68, 21)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 43)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnSelectWorkbook)
        Me.Controls.Add(Me.txtExcelWorkbook)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XL2MD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtExcelWorkbook As TextBox
    Friend WithEvents btnSelectWorkbook As Button
    Friend WithEvents btnGo As Button
End Class
