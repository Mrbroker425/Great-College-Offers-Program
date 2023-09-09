<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffers
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumWeeks = New System.Windows.Forms.TextBox()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComCourse = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMessageDisplay = New System.Windows.Forms.Label()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Great College offers "
        '
        'txtNumWeeks
        '
        Me.txtNumWeeks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumWeeks.Location = New System.Drawing.Point(375, 76)
        Me.txtNumWeeks.Multiline = True
        Me.txtNumWeeks.Name = "txtNumWeeks"
        Me.txtNumWeeks.Size = New System.Drawing.Size(99, 41)
        Me.txtNumWeeks.TabIndex = 1
        Me.txtNumWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.BtnExit)
        Me.grpBox.Controls.Add(Me.btnClear)
        Me.grpBox.Controls.Add(Me.btnGet)
        Me.grpBox.Controls.Add(Me.lblMessageDisplay)
        Me.grpBox.Controls.Add(Me.Label3)
        Me.grpBox.Controls.Add(Me.ComCourse)
        Me.grpBox.Controls.Add(Me.Label2)
        Me.grpBox.Controls.Add(Me.txtNumWeeks)
        Me.grpBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox.Location = New System.Drawing.Point(233, 84)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(613, 424)
        Me.grpBox.TabIndex = 2
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Please Answer The Following :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please enter Number Of Weeks :"
        '
        'ComCourse
        '
        Me.ComCourse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComCourse.FormattingEnabled = True
        Me.ComCourse.Items.AddRange(New Object() {"Course A", "", "Course B"})
        Me.ComCourse.Location = New System.Drawing.Point(298, 153)
        Me.ComCourse.Name = "ComCourse"
        Me.ComCourse.Size = New System.Drawing.Size(176, 38)
        Me.ComCourse.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Please Choose Course :"
        '
        'lblMessageDisplay
        '
        Me.lblMessageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessageDisplay.Location = New System.Drawing.Point(93, 227)
        Me.lblMessageDisplay.Name = "lblMessageDisplay"
        Me.lblMessageDisplay.Size = New System.Drawing.Size(419, 105)
        Me.lblMessageDisplay.TabIndex = 5
        Me.lblMessageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(36, 357)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(134, 50)
        Me.btnGet.TabIndex = 6
        Me.btnGet.Text = "Get"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(254, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 50)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(455, 357)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(134, 50)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'frmOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 539)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOffers"
        Me.Text = "Great College offers "
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumWeeks As TextBox
    Friend WithEvents grpBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComCourse As ComboBox
    Friend WithEvents lblMessageDisplay As Label
    Friend WithEvents btnGet As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnClear As Button
End Class
