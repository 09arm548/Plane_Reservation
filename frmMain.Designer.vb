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
        Me.btnBookSeat = New System.Windows.Forms.Button()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(542, 266)
        Me.btnMap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(106, 34)
        Me.btnMap.TabIndex = 0
        Me.btnMap.Text = "Show Map"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'lstMap
        '
        Me.lstMap.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMap.FormattingEnabled = True
        Me.lstMap.ItemHeight = 16
        Me.lstMap.Location = New System.Drawing.Point(33, 25)
        Me.lstMap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstMap.Name = "lstMap"
        Me.lstMap.Size = New System.Drawing.Size(397, 196)
        Me.lstMap.TabIndex = 1
        '
        'txtSeatNum
        '
        Me.txtSeatNum.Location = New System.Drawing.Point(299, 266)
        Me.txtSeatNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSeatNum.Name = "txtSeatNum"
        Me.txtSeatNum.Size = New System.Drawing.Size(132, 22)
        Me.txtSeatNum.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(297, 356)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 22)
        Me.txtName.TabIndex = 3
        '
        'btnBookSeat
        '
        Me.btnBookSeat.Location = New System.Drawing.Point(542, 356)
        Me.btnBookSeat.Name = "btnBookSeat"
        Me.btnBookSeat.Size = New System.Drawing.Size(106, 32)
        Me.btnBookSeat.TabIndex = 4
        Me.btnBookSeat.Text = "Book Seat"
        Me.btnBookSeat.UseVisualStyleBackColor = True
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Location = New System.Drawing.Point(145, 266)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(129, 17)
        Me.lblSeat.TabIndex = 5
        Me.lblSeat.Text = "Enter Seat Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(148, 356)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 17)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Enter Name"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 476)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.btnBookSeat)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSeatNum)
        Me.Controls.Add(Me.lstMap)
        Me.Controls.Add(Me.btnMap)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMap As System.Windows.Forms.Button
    Friend WithEvents lstMap As System.Windows.Forms.ListBox
    Friend WithEvents txtSeatNum As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnBookSeat As System.Windows.Forms.Button
    Friend WithEvents lblSeat As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
