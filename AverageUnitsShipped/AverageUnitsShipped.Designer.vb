<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.tbSoldHolder = New System.Windows.Forms.TextBox()
        Me.lblDayNumber = New System.Windows.Forms.Label()
        Me.frmAverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(17, 364)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "&Enter"
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Click to enter daily sales")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(123, 364)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Click to reset form and input data")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(229, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Click to close form and end program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(33, 21)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.lblUnits, "Input units sold here")
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(29, 239)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(255, 66)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.lblAverage, "Displays the calculated average, once all entries are made")
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(96, 19)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(100, 22)
        Me.tbInput.TabIndex = 1
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.tbInput, "Input your sales for current day here.")
        '
        'tbSoldHolder
        '
        Me.tbSoldHolder.Location = New System.Drawing.Point(25, 60)
        Me.tbSoldHolder.Multiline = True
        Me.tbSoldHolder.Name = "tbSoldHolder"
        Me.tbSoldHolder.Size = New System.Drawing.Size(263, 144)
        Me.tbSoldHolder.TabIndex = 4
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.tbSoldHolder, "Contains all entered sales for previous days")
        '
        'lblDayNumber
        '
        Me.lblDayNumber.Location = New System.Drawing.Point(213, 22)
        Me.lblDayNumber.Name = "lblDayNumber"
        Me.lblDayNumber.Size = New System.Drawing.Size(91, 17)
        Me.lblDayNumber.TabIndex = 3
        Me.lblDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me.lblDayNumber, "This label shows your current day of the week")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(325, 426)
        Me.Controls.Add(Me.lblDayNumber)
        Me.Controls.Add(Me.tbSoldHolder)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.frmAverageUnitsShippedToolTip.SetToolTip(Me, "Someone's bored ... This is a form!")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents tbSoldHolder As TextBox
    Friend WithEvents lblDayNumber As Label
    Friend WithEvents frmAverageUnitsShippedToolTip As ToolTip
End Class
