<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMainNew_Outpatient
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMainNew_Outpatient))
        Dim GridEXNewPatientBook_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnPrintViewOther = New System.Windows.Forms.Button
        Me.DateOtherFrom = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateOtherTo = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnStatistic = New System.Windows.Forms.Button
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.DailyDateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.DailyDateTo = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboDiagnosis = New System.Windows.Forms.ComboBox
        Me.ChDiagnosis = New System.Windows.Forms.CheckBox
        Me.TxtTotalDolar = New System.Windows.Forms.TextBox
        Me.TxtTotalPatientFee = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnDisplay = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupPatient = New System.Windows.Forms.GroupBox
        Me.SplitNewOuppatient = New System.Windows.Forms.SplitContainer
        Me.tbCountMoney = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblQuickSocial = New System.Windows.Forms.LinkLabel
        Me.lstSocial = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label20 = New System.Windows.Forms.Label
        Me.dgvSDolar = New System.Windows.Forms.DataGridView
        Me.dgvSRiel = New System.Windows.Forms.DataGridView
        Me.lblCloseSocial = New System.Windows.Forms.LinkLabel
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.GridEXNewPatientBook = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuNewOutpatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MEnterDiagnosis = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.MCreateVA = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.CreateNewOutpatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.MRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.MCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.MUndoCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.ShowDetailFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateReferral = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.PrintWithDiagnosis = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintNotFillDiagnosis = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDisplaySort = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.BtnShowEnterDiagnosis = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.BtnShowVA = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.BtnShowPatientCanceled = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel
        Me.LblM = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel
        Me.LblF = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel
        Me.LblTotalMF = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel11 = New System.Windows.Forms.ToolStripLabel
        Me.LblFillDiagnosis = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel13 = New System.Windows.Forms.ToolStripLabel
        Me.LblPatientNil = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel15 = New System.Windows.Forms.ToolStripLabel
        Me.LblPatientCancel = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.PicLoad2 = New System.Windows.Forms.PictureBox
        Me.CRVDaillyNewOut = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BGNewOutpatient = New System.ComponentModel.BackgroundWorker
        Me.BgLoadNewReport = New System.ComponentModel.BackgroundWorker
        Me.BgLoadOtherNewReport = New System.ComponentModel.BackgroundWorker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DSOutPatientReport = New HospitalMS.DSOutPatientReport
        Me.DataTable1TableAdapter = New HospitalMS.DSOutPatientReportTableAdapters.DataTable1TableAdapter
        Me.TblOtherNewPatientTableAdapter = New HospitalMS.DSOutPatientReportTableAdapters.TblOtherNewPatientTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupPatient.SuspendLayout()
        Me.SplitNewOuppatient.Panel1.SuspendLayout()
        Me.SplitNewOuppatient.Panel2.SuspendLayout()
        Me.SplitNewOuppatient.SuspendLayout()
        Me.tbCountMoney.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvSDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSRiel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXNewPatientBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuNewOutpatient.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PicLoad2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DSOutPatientReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1186, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1180, 179)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnPrintViewOther)
        Me.GroupBox5.Controls.Add(Me.DateOtherFrom)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.DateOtherTo)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(988, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 127)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Others Report"
        Me.GroupBox5.Visible = False
        '
        'BtnPrintViewOther
        '
        Me.BtnPrintViewOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintViewOther.Location = New System.Drawing.Point(105, 85)
        Me.BtnPrintViewOther.Name = "BtnPrintViewOther"
        Me.BtnPrintViewOther.Size = New System.Drawing.Size(81, 34)
        Me.BtnPrintViewOther.TabIndex = 17
        Me.BtnPrintViewOther.Text = "&Print Preview"
        Me.BtnPrintViewOther.UseVisualStyleBackColor = True
        '
        'DateOtherFrom
        '
        Me.DateOtherFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateOtherFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOtherFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOtherFrom.Location = New System.Drawing.Point(61, 22)
        Me.DateOtherFrom.Name = "DateOtherFrom"
        Me.DateOtherFrom.Size = New System.Drawing.Size(125, 26)
        Me.DateOtherFrom.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Between"
        '
        'DateOtherTo
        '
        Me.DateOtherTo.CustomFormat = "dd/MM/yyyy"
        Me.DateOtherTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOtherTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOtherTo.Location = New System.Drawing.Point(61, 53)
        Me.DateOtherTo.Name = "DateOtherTo"
        Me.DateOtherTo.Size = New System.Drawing.Size(125, 26)
        Me.DateOtherTo.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "And"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnStatistic)
        Me.GroupBox2.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox2.Controls.Add(Me.DailyDateFrom)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DailyDateTo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(434, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 124)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily New out-patient Report"
        '
        'BtnStatistic
        '
        Me.BtnStatistic.BackColor = System.Drawing.Color.Transparent
        Me.BtnStatistic.BackgroundImage = CType(resources.GetObject("BtnStatistic.BackgroundImage"), System.Drawing.Image)
        Me.BtnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStatistic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnStatistic.ForeColor = System.Drawing.Color.White
        Me.BtnStatistic.Location = New System.Drawing.Point(6, 84)
        Me.BtnStatistic.Name = "BtnStatistic"
        Me.BtnStatistic.Size = New System.Drawing.Size(93, 33)
        Me.BtnStatistic.TabIndex = 13
        Me.BtnStatistic.Text = "Statistict"
        Me.BtnStatistic.UseVisualStyleBackColor = False
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrintPreview.BackgroundImage = CType(resources.GetObject("BtnPrintPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Location = New System.Drawing.Point(105, 84)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(81, 33)
        Me.BtnPrintPreview.TabIndex = 12
        Me.BtnPrintPreview.Text = "&Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = False
        '
        'DailyDateFrom
        '
        Me.DailyDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DailyDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DailyDateFrom.Location = New System.Drawing.Point(61, 21)
        Me.DailyDateFrom.Name = "DailyDateFrom"
        Me.DailyDateFrom.Size = New System.Drawing.Size(125, 26)
        Me.DailyDateFrom.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Between"
        '
        'DailyDateTo
        '
        Me.DailyDateTo.CustomFormat = "dd/MM/yyyy"
        Me.DailyDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DailyDateTo.Location = New System.Drawing.Point(61, 53)
        Me.DailyDateTo.Name = "DailyDateTo"
        Me.DailyDateTo.Size = New System.Drawing.Size(125, 26)
        Me.DailyDateTo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "And"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboDiagnosis)
        Me.GroupBox4.Controls.Add(Me.ChDiagnosis)
        Me.GroupBox4.Controls.Add(Me.TxtTotalDolar)
        Me.GroupBox4.Controls.Add(Me.TxtTotalPatientFee)
        Me.GroupBox4.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.DateFrom)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.BtnDisplay)
        Me.GroupBox4.Controls.Add(Me.DateTo)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(422, 124)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "By patient info"
        '
        'cboDiagnosis
        '
        Me.cboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDiagnosis.Enabled = False
        Me.cboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiagnosis.FormattingEnabled = True
        Me.cboDiagnosis.Location = New System.Drawing.Point(200, 52)
        Me.cboDiagnosis.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDiagnosis.Name = "cboDiagnosis"
        Me.cboDiagnosis.Size = New System.Drawing.Size(197, 28)
        Me.cboDiagnosis.TabIndex = 15
        '
        'ChDiagnosis
        '
        Me.ChDiagnosis.AutoSize = True
        Me.ChDiagnosis.Location = New System.Drawing.Point(203, 25)
        Me.ChDiagnosis.Margin = New System.Windows.Forms.Padding(2)
        Me.ChDiagnosis.Name = "ChDiagnosis"
        Me.ChDiagnosis.Size = New System.Drawing.Size(105, 17)
        Me.ChDiagnosis.TabIndex = 14
        Me.ChDiagnosis.Text = "Select Diagnosis"
        Me.ChDiagnosis.UseVisualStyleBackColor = True
        '
        'TxtTotalDolar
        '
        Me.TxtTotalDolar.BackColor = System.Drawing.Color.White
        Me.TxtTotalDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDolar.Location = New System.Drawing.Point(537, 74)
        Me.TxtTotalDolar.Name = "TxtTotalDolar"
        Me.TxtTotalDolar.ReadOnly = True
        Me.TxtTotalDolar.Size = New System.Drawing.Size(204, 30)
        Me.TxtTotalDolar.TabIndex = 13
        Me.TxtTotalDolar.Text = "0"
        Me.TxtTotalDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalDolar.Visible = False
        '
        'TxtTotalPatientFee
        '
        Me.TxtTotalPatientFee.BackColor = System.Drawing.Color.White
        Me.TxtTotalPatientFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPatientFee.Location = New System.Drawing.Point(537, 17)
        Me.TxtTotalPatientFee.Name = "TxtTotalPatientFee"
        Me.TxtTotalPatientFee.ReadOnly = True
        Me.TxtTotalPatientFee.Size = New System.Drawing.Size(204, 30)
        Me.TxtTotalPatientFee.TabIndex = 11
        Me.TxtTotalPatientFee.Text = "0"
        Me.TxtTotalPatientFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalPatientFee.Visible = False
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(69, 22)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(125, 26)
        Me.TxtPatientNo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Patient No:"
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(69, 55)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(125, 26)
        Me.DateFrom.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "From:"
        '
        'BtnDisplay
        '
        Me.BtnDisplay.BackColor = System.Drawing.Color.Transparent
        Me.BtnDisplay.BackgroundImage = CType(resources.GetObject("BtnDisplay.BackgroundImage"), System.Drawing.Image)
        Me.BtnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplay.ForeColor = System.Drawing.Color.White
        Me.BtnDisplay.Location = New System.Drawing.Point(200, 83)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(79, 32)
        Me.BtnDisplay.TabIndex = 2
        Me.BtnDisplay.Text = "&Display"
        Me.BtnDisplay.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(69, 87)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(125, 26)
        Me.DateTo.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "To:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(419, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 34)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "ចំនួនលុយរៀល"
        Me.Label9.Visible = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(419, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 32)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "ចំនួនលុយដុល្លារ"
        Me.Label13.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1180, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NEW PATIENT BOOK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupPatient
        '
        Me.GroupPatient.Controls.Add(Me.SplitNewOuppatient)
        Me.GroupPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPatient.ForeColor = System.Drawing.Color.Blue
        Me.GroupPatient.Location = New System.Drawing.Point(0, 221)
        Me.GroupPatient.Name = "GroupPatient"
        Me.GroupPatient.Size = New System.Drawing.Size(1186, 722)
        Me.GroupPatient.TabIndex = 1
        Me.GroupPatient.TabStop = False
        Me.GroupPatient.Text = "New out patient"
        '
        'SplitNewOuppatient
        '
        Me.SplitNewOuppatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitNewOuppatient.Location = New System.Drawing.Point(3, 22)
        Me.SplitNewOuppatient.Name = "SplitNewOuppatient"
        Me.SplitNewOuppatient.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitNewOuppatient.Panel1
        '
        Me.SplitNewOuppatient.Panel1.Controls.Add(Me.tbCountMoney)
        Me.SplitNewOuppatient.Panel1.Controls.Add(Me.PictLoading)
        Me.SplitNewOuppatient.Panel1.Controls.Add(Me.GridEXNewPatientBook)
        Me.SplitNewOuppatient.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitNewOuppatient.Panel2
        '
        Me.SplitNewOuppatient.Panel2.Controls.Add(Me.PicLoad2)
        Me.SplitNewOuppatient.Panel2.Controls.Add(Me.CRVDaillyNewOut)
        Me.SplitNewOuppatient.Panel2Collapsed = True
        Me.SplitNewOuppatient.Size = New System.Drawing.Size(1180, 697)
        Me.SplitNewOuppatient.SplitterDistance = 360
        Me.SplitNewOuppatient.TabIndex = 3
        '
        'tbCountMoney
        '
        Me.tbCountMoney.Controls.Add(Me.TabPage2)
        Me.tbCountMoney.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbCountMoney.Location = New System.Drawing.Point(321, 129)
        Me.tbCountMoney.Name = "tbCountMoney"
        Me.tbCountMoney.SelectedIndex = 0
        Me.tbCountMoney.Size = New System.Drawing.Size(804, 478)
        Me.tbCountMoney.TabIndex = 3
        Me.tbCountMoney.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblQuickSocial)
        Me.TabPage2.Controls.Add(Me.lstSocial)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.dgvSDolar)
        Me.TabPage2.Controls.Add(Me.dgvSRiel)
        Me.TabPage2.Controls.Add(Me.lblCloseSocial)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(796, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Patient Fees"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblQuickSocial
        '
        Me.lblQuickSocial.AutoSize = True
        Me.lblQuickSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickSocial.Location = New System.Drawing.Point(19, 9)
        Me.lblQuickSocial.Name = "lblQuickSocial"
        Me.lblQuickSocial.Size = New System.Drawing.Size(84, 13)
        Me.lblQuickSocial.TabIndex = 15
        Me.lblQuickSocial.TabStop = True
        Me.lblQuickSocial.Text = "Click to view:"
        '
        'lstSocial
        '
        Me.lstSocial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSocial.FullRowSelect = True
        Me.lstSocial.GridLines = True
        Me.lstSocial.Location = New System.Drawing.Point(334, 25)
        Me.lstSocial.Name = "lstSocial"
        Me.lstSocial.Size = New System.Drawing.Size(442, 408)
        Me.lstSocial.TabIndex = 11
        Me.lstSocial.UseCompatibleStateImageBehavior = False
        Me.lstSocial.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Riels"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "$"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Number"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 82
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subtotal"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 115
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(331, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(246, 20)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Number of amount after selected:"
        '
        'dgvSDolar
        '
        Me.dgvSDolar.AllowUserToAddRows = False
        Me.dgvSDolar.AllowUserToDeleteRows = False
        Me.dgvSDolar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSDolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSDolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSDolar.Location = New System.Drawing.Point(189, 25)
        Me.dgvSDolar.Name = "dgvSDolar"
        Me.dgvSDolar.ReadOnly = True
        Me.dgvSDolar.RowHeadersVisible = False
        Me.dgvSDolar.RowHeadersWidth = 55
        Me.dgvSDolar.RowTemplate.Height = 24
        Me.dgvSDolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSDolar.Size = New System.Drawing.Size(128, 410)
        Me.dgvSDolar.TabIndex = 8
        '
        'dgvSRiel
        '
        Me.dgvSRiel.AllowUserToAddRows = False
        Me.dgvSRiel.AllowUserToDeleteRows = False
        Me.dgvSRiel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSRiel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSRiel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSRiel.Location = New System.Drawing.Point(22, 25)
        Me.dgvSRiel.Name = "dgvSRiel"
        Me.dgvSRiel.ReadOnly = True
        Me.dgvSRiel.RowHeadersWidth = 50
        Me.dgvSRiel.RowTemplate.Height = 24
        Me.dgvSRiel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSRiel.Size = New System.Drawing.Size(168, 410)
        Me.dgvSRiel.TabIndex = 8
        '
        'lblCloseSocial
        '
        Me.lblCloseSocial.AutoSize = True
        Me.lblCloseSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseSocial.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCloseSocial.Location = New System.Drawing.Point(757, 3)
        Me.lblCloseSocial.Name = "lblCloseSocial"
        Me.lblCloseSocial.Size = New System.Drawing.Size(38, 13)
        Me.lblCloseSocial.TabIndex = 7
        Me.lblCloseSocial.TabStop = True
        Me.lblCloseSocial.Text = "Close"
        '
        'PictLoading
        '
        Me.PictLoading.Image = Global.HospitalMS.My.Resources.Resources.loading_bar
        Me.PictLoading.Location = New System.Drawing.Point(499, 198)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(190, 25)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 2
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'GridEXNewPatientBook
        '
        Me.GridEXNewPatientBook.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXNewPatientBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridEXNewPatientBook.ContextMenuStrip = Me.ContextMenuNewOutpatient
        GridEXNewPatientBook_DesignTimeLayout.LayoutString = resources.GetString("GridEXNewPatientBook_DesignTimeLayout.LayoutString")
        Me.GridEXNewPatientBook.DesignTimeLayout = GridEXNewPatientBook_DesignTimeLayout
        Me.GridEXNewPatientBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXNewPatientBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXNewPatientBook.GroupByBoxVisible = False
        Me.GridEXNewPatientBook.HeaderFormatStyle.FontSize = 12.0!
        Me.GridEXNewPatientBook.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXNewPatientBook.Location = New System.Drawing.Point(0, 0)
        Me.GridEXNewPatientBook.Name = "GridEXNewPatientBook"
        Me.GridEXNewPatientBook.RecordNavigator = True
        Me.GridEXNewPatientBook.RowFormatStyle.FontSize = 11.0!
        Me.GridEXNewPatientBook.Size = New System.Drawing.Size(1180, 672)
        Me.GridEXNewPatientBook.TabIndex = 5
        Me.GridEXNewPatientBook.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ContextMenuNewOutpatient
        '
        Me.ContextMenuNewOutpatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEnterDiagnosis, Me.ToolStripMenuItem4, Me.MCreateVA, Me.ToolStripMenuItem2, Me.CreateNewOutpatientToolStripMenuItem, Me.ToolStripMenuItem1, Me.MRemove, Me.ToolStripMenuItem5, Me.ShowDetailFeesToolStripMenuItem, Me.ToolStripSeparator10, Me.BtnUpdateReferral})
        Me.ContextMenuNewOutpatient.Name = "ContextMenuNewOutpatient"
        Me.ContextMenuNewOutpatient.Size = New System.Drawing.Size(205, 166)
        '
        'MEnterDiagnosis
        '
        Me.MEnterDiagnosis.Name = "MEnterDiagnosis"
        Me.MEnterDiagnosis.Size = New System.Drawing.Size(204, 22)
        Me.MEnterDiagnosis.Text = "Enter Diagnosis..."
        Me.MEnterDiagnosis.Visible = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(201, 6)
        Me.ToolStripMenuItem4.Visible = False
        '
        'MCreateVA
        '
        Me.MCreateVA.Name = "MCreateVA"
        Me.MCreateVA.Size = New System.Drawing.Size(204, 22)
        Me.MCreateVA.Text = "Create V A ..."
        Me.MCreateVA.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(201, 6)
        Me.ToolStripMenuItem2.Visible = False
        '
        'CreateNewOutpatientToolStripMenuItem
        '
        Me.CreateNewOutpatientToolStripMenuItem.Name = "CreateNewOutpatientToolStripMenuItem"
        Me.CreateNewOutpatientToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CreateNewOutpatientToolStripMenuItem.Text = "Create New Out-patient"
        Me.CreateNewOutpatientToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(201, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'MRemove
        '
        Me.MRemove.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MCancel, Me.ToolStripMenuItem3, Me.MUndoCancel})
        Me.MRemove.Name = "MRemove"
        Me.MRemove.Size = New System.Drawing.Size(204, 22)
        Me.MRemove.Text = "Remove"
        '
        'MCancel
        '
        Me.MCancel.Name = "MCancel"
        Me.MCancel.Size = New System.Drawing.Size(151, 22)
        Me.MCancel.Text = "Cancel"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(148, 6)
        '
        'MUndoCancel
        '
        Me.MUndoCancel.Name = "MUndoCancel"
        Me.MUndoCancel.Size = New System.Drawing.Size(151, 22)
        Me.MUndoCancel.Text = "Undo Cancel..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(201, 6)
        Me.ToolStripMenuItem5.Visible = False
        '
        'ShowDetailFeesToolStripMenuItem
        '
        Me.ShowDetailFeesToolStripMenuItem.Name = "ShowDetailFeesToolStripMenuItem"
        Me.ShowDetailFeesToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ShowDetailFeesToolStripMenuItem.Text = "Show Detail Fees...."
        Me.ShowDetailFeesToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(201, 6)
        '
        'BtnUpdateReferral
        '
        Me.BtnUpdateReferral.Name = "BtnUpdateReferral"
        Me.BtnUpdateReferral.Size = New System.Drawing.Size(204, 22)
        Me.BtnUpdateReferral.Text = "Update Patient Referral..."
        Me.BtnUpdateReferral.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator5, Me.BtnDisplaySort, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.BtnShowEnterDiagnosis, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.BtnShowVA, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.BtnShowPatientCanceled, Me.ToolStripSeparator4, Me.ToolStripLabel2, Me.ToolStripLabel7, Me.LblM, Me.ToolStripLabel6, Me.LblF, Me.ToolStripLabel9, Me.LblTotalMF, Me.ToolStripSeparator6, Me.ToolStripLabel11, Me.LblFillDiagnosis, Me.ToolStripSeparator7, Me.ToolStripLabel13, Me.LblPatientNil, Me.ToolStripSeparator8, Me.ToolStripLabel15, Me.LblPatientCancel, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 672)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1180, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintWithDiagnosis, Me.ToolStripMenuItem6, Me.PrintNotFillDiagnosis})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripSplitButton1.Image = Global.HospitalMS.My.Resources.Resources.printer
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(120, 23)
        Me.ToolStripSplitButton1.Text = "Print Utility"
        Me.ToolStripSplitButton1.Visible = False
        '
        'PrintWithDiagnosis
        '
        Me.PrintWithDiagnosis.ForeColor = System.Drawing.Color.Blue
        Me.PrintWithDiagnosis.Name = "PrintWithDiagnosis"
        Me.PrintWithDiagnosis.Size = New System.Drawing.Size(239, 24)
        Me.PrintWithDiagnosis.Text = "Print With Diagnosis"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(236, 6)
        '
        'PrintNotFillDiagnosis
        '
        Me.PrintNotFillDiagnosis.ForeColor = System.Drawing.Color.Blue
        Me.PrintNotFillDiagnosis.Name = "PrintNotFillDiagnosis"
        Me.PrintNotFillDiagnosis.Size = New System.Drawing.Size(239, 24)
        Me.PrintNotFillDiagnosis.Text = "Print Not Fill Diagnosis"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BtnDisplaySort
        '
        Me.BtnDisplaySort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnDisplaySort.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDisplaySort.ForeColor = System.Drawing.Color.Blue
        Me.BtnDisplaySort.Image = CType(resources.GetObject("BtnDisplaySort.Image"), System.Drawing.Image)
        Me.BtnDisplaySort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDisplaySort.Name = "BtnDisplaySort"
        Me.BtnDisplaySort.Size = New System.Drawing.Size(52, 22)
        Me.BtnDisplaySort.Text = "Display"
        Me.BtnDisplaySort.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(19, 22)
        Me.ToolStripLabel3.Text = "   "
        Me.ToolStripLabel3.Visible = False
        '
        'BtnShowEnterDiagnosis
        '
        Me.BtnShowEnterDiagnosis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnShowEnterDiagnosis.ForeColor = System.Drawing.Color.Blue
        Me.BtnShowEnterDiagnosis.Image = CType(resources.GetObject("BtnShowEnterDiagnosis.Image"), System.Drawing.Image)
        Me.BtnShowEnterDiagnosis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnShowEnterDiagnosis.Name = "BtnShowEnterDiagnosis"
        Me.BtnShowEnterDiagnosis.Size = New System.Drawing.Size(103, 22)
        Me.BtnShowEnterDiagnosis.Text = "Patient Diagnosis"
        Me.BtnShowEnterDiagnosis.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Bisque
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel1.Text = "    "
        Me.ToolStripLabel1.Visible = False
        '
        'BtnShowVA
        '
        Me.BtnShowVA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnShowVA.ForeColor = System.Drawing.Color.Blue
        Me.BtnShowVA.Image = CType(resources.GetObject("BtnShowVA.Image"), System.Drawing.Image)
        Me.BtnShowVA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnShowVA.Name = "BtnShowVA"
        Me.BtnShowVA.Size = New System.Drawing.Size(74, 22)
        Me.BtnShowVA.Text = "Patient V-A"
        Me.BtnShowVA.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.BackColor = System.Drawing.Color.Red
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel4.Text = "    "
        Me.ToolStripLabel4.Visible = False
        Me.ToolStripLabel4.VisitedLinkColor = System.Drawing.Color.Red
        '
        'BtnShowPatientCanceled
        '
        Me.BtnShowPatientCanceled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnShowPatientCanceled.ForeColor = System.Drawing.Color.Blue
        Me.BtnShowPatientCanceled.Image = CType(resources.GetObject("BtnShowPatientCanceled.Image"), System.Drawing.Image)
        Me.BtnShowPatientCanceled.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnShowPatientCanceled.Name = "BtnShowPatientCanceled"
        Me.BtnShowPatientCanceled.Size = New System.Drawing.Size(103, 22)
        Me.BtnShowPatientCanceled.Text = "Patient Canceled"
        Me.BtnShowPatientCanceled.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator4.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(28, 22)
        Me.ToolStripLabel2.Text = "M +"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel7.Text = "F="
        '
        'LblM
        '
        Me.LblM.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblM.ForeColor = System.Drawing.Color.Blue
        Me.LblM.Name = "LblM"
        Me.LblM.Size = New System.Drawing.Size(19, 22)
        Me.LblM.Text = "0"
        Me.LblM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(15, 22)
        Me.ToolStripLabel6.Text = "+"
        '
        'LblF
        '
        Me.LblF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblF.ForeColor = System.Drawing.Color.Blue
        Me.LblF.Name = "LblF"
        Me.LblF.Size = New System.Drawing.Size(19, 22)
        Me.LblF.Text = "0"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel9.Text = "Total="
        '
        'LblTotalMF
        '
        Me.LblTotalMF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalMF.ForeColor = System.Drawing.Color.Blue
        Me.LblTotalMF.Name = "LblTotalMF"
        Me.LblTotalMF.Size = New System.Drawing.Size(19, 22)
        Me.LblTotalMF.Text = "0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel11
        '
        Me.ToolStripLabel11.Name = "ToolStripLabel11"
        Me.ToolStripLabel11.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripLabel11.Text = "Not Fill Diagnosis="
        Me.ToolStripLabel11.Visible = False
        '
        'LblFillDiagnosis
        '
        Me.LblFillDiagnosis.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblFillDiagnosis.ForeColor = System.Drawing.Color.Blue
        Me.LblFillDiagnosis.Name = "LblFillDiagnosis"
        Me.LblFillDiagnosis.Size = New System.Drawing.Size(19, 22)
        Me.LblFillDiagnosis.Text = "0"
        Me.LblFillDiagnosis.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel13
        '
        Me.ToolStripLabel13.Name = "ToolStripLabel13"
        Me.ToolStripLabel13.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel13.Text = "Patient Nil="
        Me.ToolStripLabel13.Visible = False
        '
        'LblPatientNil
        '
        Me.LblPatientNil.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblPatientNil.ForeColor = System.Drawing.Color.Blue
        Me.LblPatientNil.Name = "LblPatientNil"
        Me.LblPatientNil.Size = New System.Drawing.Size(19, 22)
        Me.LblPatientNil.Text = "0"
        Me.LblPatientNil.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator8.Visible = False
        '
        'ToolStripLabel15
        '
        Me.ToolStripLabel15.Name = "ToolStripLabel15"
        Me.ToolStripLabel15.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel15.Text = "Canceled="
        Me.ToolStripLabel15.Visible = False
        '
        'LblPatientCancel
        '
        Me.LblPatientCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblPatientCancel.ForeColor = System.Drawing.Color.Blue
        Me.LblPatientCancel.Name = "LblPatientCancel"
        Me.LblPatientCancel.Size = New System.Drawing.Size(19, 22)
        Me.LblPatientCancel.Text = "0"
        Me.LblPatientCancel.Visible = False
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator9.Visible = False
        '
        'PicLoad2
        '
        Me.PicLoad2.Image = Global.HospitalMS.My.Resources.Resources.loading_bar
        Me.PicLoad2.Location = New System.Drawing.Point(495, 168)
        Me.PicLoad2.Name = "PicLoad2"
        Me.PicLoad2.Size = New System.Drawing.Size(190, 25)
        Me.PicLoad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoad2.TabIndex = 3
        Me.PicLoad2.TabStop = False
        Me.PicLoad2.Visible = False
        '
        'CRVDaillyNewOut
        '
        Me.CRVDaillyNewOut.ActiveViewIndex = -1
        Me.CRVDaillyNewOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CRVDaillyNewOut.DisplayGroupTree = False
        Me.CRVDaillyNewOut.DisplayStatusBar = False
        Me.CRVDaillyNewOut.DisplayToolbar = False
        Me.CRVDaillyNewOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVDaillyNewOut.Location = New System.Drawing.Point(0, 0)
        Me.CRVDaillyNewOut.Name = "CRVDaillyNewOut"
        Me.CRVDaillyNewOut.SelectionFormula = ""
        Me.CRVDaillyNewOut.Size = New System.Drawing.Size(150, 46)
        Me.CRVDaillyNewOut.TabIndex = 0
        Me.CRVDaillyNewOut.ViewTimeSelectionFormula = ""
        '
        'BGNewOutpatient
        '
        '
        'BgLoadNewReport
        '
        '
        'BgLoadOtherNewReport
        '
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1186, 221)
        Me.Panel1.TabIndex = 2
        '
        'DSOutPatientReport
        '
        Me.DSOutPatientReport.DataSetName = "DSOutPatientReport"
        Me.DSOutPatientReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TblOtherNewPatientTableAdapter
        '
        Me.TblOtherNewPatientTableAdapter.ClearBeforeFill = True
        '
        'UCMainNew_Outpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.GroupPatient)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCMainNew_Outpatient"
        Me.Size = New System.Drawing.Size(1186, 943)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupPatient.ResumeLayout(False)
        Me.SplitNewOuppatient.Panel1.ResumeLayout(False)
        Me.SplitNewOuppatient.Panel1.PerformLayout()
        Me.SplitNewOuppatient.Panel2.ResumeLayout(False)
        Me.SplitNewOuppatient.ResumeLayout(False)
        Me.tbCountMoney.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvSDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSRiel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXNewPatientBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuNewOutpatient.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PicLoad2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DSOutPatientReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPatient As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuNewOutpatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateNewOutpatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents BGNewOutpatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DailyDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DailyDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents SplitNewOuppatient As System.Windows.Forms.SplitContainer
    Friend WithEvents CRVDaillyNewOut As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BgLoadNewReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicLoad2 As System.Windows.Forms.PictureBox
    Friend WithEvents DSOutPatientReport As HospitalMS.DSOutPatientReport
    Friend WithEvents DataTable1TableAdapter As HospitalMS.DSOutPatientReportTableAdapters.DataTable1TableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPatientFee As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintViewOther As System.Windows.Forms.Button
    Friend WithEvents DateOtherFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateOtherTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BgLoadOtherNewReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents TblOtherNewPatientTableAdapter As HospitalMS.DSOutPatientReportTableAdapters.TblOtherNewPatientTableAdapter
    Friend WithEvents TxtTotalDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MCreateVA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MUndoCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MEnterDiagnosis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnStatistic As System.Windows.Forms.Button
    Friend WithEvents tbCountMoney As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblQuickSocial As System.Windows.Forms.LinkLabel
    Friend WithEvents lstSocial As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dgvSDolar As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSRiel As System.Windows.Forms.DataGridView
    Friend WithEvents lblCloseSocial As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowDetailFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnShowVA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnShowEnterDiagnosis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnShowPatientCanceled As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDisplaySort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblM As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblF As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblTotalMF As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel11 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblFillDiagnosis As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel13 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblPatientNil As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel15 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblPatientCancel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridEXNewPatientBook As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateReferral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PrintWithDiagnosis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintNotFillDiagnosis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents ChDiagnosis As System.Windows.Forms.CheckBox

End Class
