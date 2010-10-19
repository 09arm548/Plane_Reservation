<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnMap = New System.Windows.Forms.Button()
        Me.lstMap = New System.Windows.Forms.ListBox()
        Me.txtSeatNum = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(470, 313)
        Me.btnMap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(56, 19)
        Me.btnMap.TabIndex = 0
        Me.btnMap.Text = "Show Map"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'lstMap
        '
        Me.lstMap.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMap.FormattingEnabled = True
        Me.lstMap.ItemHeight = 12
        Me.lstMap.Location = New System.Drawing.Point(25, 20)
        Me.lstMap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstMap.Name = "lstMap"
        Me.lstMap.Size = New System.Drawing.Size(299, 172)
        Me.lstMap.TabIndex = 1
        '
        'txtSeatNum
        '
        Me.txtSeatNum.Location = New System.Drawing.Point(224, 216)
        Me.txtSeatNum.Name = "txtSeatNum"
        Me.txtSeatNum.Size = New System.Drawing.Size(100, 20)
        Me.txtSeatNum.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(223, 289)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 387)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSeatNum)
        Me.Controls.Add(Me.lstMap)
        Me.Controls.Add(Me.btnMap)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMap As System.Windows.Forms.Button
    Friend WithEvents lstMap As System.Windows.Forms.ListBox
    Friend WithEvents txtSeatNum As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox

End Class
