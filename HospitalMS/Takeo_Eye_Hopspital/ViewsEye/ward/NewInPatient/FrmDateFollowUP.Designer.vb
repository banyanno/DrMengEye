<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDateFollowUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDateFollowUP))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblDateLeave = New System.Windows.Forms.Label
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateDischarge = New System.Windows.Forms.DateTimePicker
        Me.BtnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblDateLeave)
        Me.GroupBox1.Controls.Add(Me.DateFollowUp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(383, 225)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Followup"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(341, 190)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 10
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(mm-dd-yyyy)"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(17, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Note: If you don't check [Date Followup]  then patient won't have the followup."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(17, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 47)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ចំណាំ: ប្រសិនបើអ្នកមិនជ្រើសរើសថ្ងៃណាត់ជួប អ្នកជំងឺក៍មិនមានការណាត់ជួបដែរ។"
        '
        'LblDateLeave
        '
        Me.LblDateLeave.AutoSize = True
        Me.LblDateLeave.Location = New System.Drawing.Point(127, 43)
        Me.LblDateLeave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDateLeave.Name = "LblDateLeave"
        Me.LblDateLeave.Size = New System.Drawing.Size(16, 17)
        Me.LblDateLeave.TabIndex = 2
        Me.LblDateLeave.Text = "0"
        '
        'DateFollowUp
        '
        Me.DateFollowUp.Checked = False
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(131, 68)
        Me.DateFollowUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ShowCheckBox = True
        Me.DateFollowUp.Size = New System.Drawing.Size(227, 30)
        Me.DateFollowUp.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date FollowUp:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Discharge:"
        '
        'DateDischarge
        '
        Me.DateDischarge.Checked = False
        Me.DateDischarge.CustomFormat = "dd/MM/yyyy"
        Me.DateDischarge.Enabled = False
        Me.DateDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDischarge.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDischarge.Location = New System.Drawing.Point(420, 32)
        Me.DateDischarge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateDischarge.Name = "DateDischarge"
        Me.DateDischarge.ShowCheckBox = True
        Me.DateDischarge.Size = New System.Drawing.Size(163, 30)
        Me.DateDischarge.TabIndex = 0
        Me.DateDischarge.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(279, 247)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 38)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmDateFollowUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateDischarge)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDateFollowUP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date FollowUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateDischarge As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents LblDateLeave As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
