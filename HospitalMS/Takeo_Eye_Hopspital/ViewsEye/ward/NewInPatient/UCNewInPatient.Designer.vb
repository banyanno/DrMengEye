<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCNewInPatient
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
        Dim GridNewInPatient_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCNewInPatient))
        Me.GridNewInPatient = New Janus.Windows.GridEX.GridEX
        Me.ContextNewInPatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DaillyBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PrepareOTRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OTRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnPrepareOTRegistrattion1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MoveToListOTToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMovePatientWaiting1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSetToNormal1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnReferal = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNoPermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.MUndoCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator
        Me.DSWardWithOT = New HospitalMS.DSWardWithOT
        Me.ContextMenuPrepareOT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToWaitingOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DSPrepareOTList = New HospitalMS.DSPrepareOTList
        Me.ContextMenuTreatment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnViewOTHistory = New System.Windows.Forms.Button
        Me.BtnShow = New System.Windows.Forms.Button
        Me.DateToAdmid = New System.Windows.Forms.DateTimePicker
        Me.DateFromAdmid = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReloadData = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.TxtPatientNo = New System.Windows.Forms.ToolStripTextBox
        Me.BtnFind = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewDiallyBook = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnPrepareOTRegistrattion = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMovePatientWaiting = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSetToNormal = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton
        Me.Referal = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.PermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.NoPermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SaveDailyInPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewDailyInpatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnOrder = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.Statistic = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.BgLoadNewInpatient = New System.ComponentModel.BackgroundWorker
        Me.V_NewInpatientDetialTableAdapterPrepare = New HospitalMS.DSPrepareOTListTableAdapters.V_NewInpatientDetialTableAdapter
        Me.View_OTRegistrationTableAdapterPrepare = New HospitalMS.DSPrepareOTListTableAdapters.View_OTRegistrationTableAdapter
        Me.V_IOLRegistrationTableAdapterPrepare = New HospitalMS.DSPrepareOTListTableAdapters.V_IOLRegistrationTableAdapter
        Me.V_NewInpatientDetialTableAdapter = New HospitalMS.DSWardWithOTTableAdapters.V_NewInpatientDetialTableAdapter
        Me.View_OTRegistrationTableAdapter = New HospitalMS.DSWardWithOTTableAdapters.View_OTRegistrationTableAdapter
        Me.V_IOLRegistrationTableAdapter = New HospitalMS.DSWardWithOTTableAdapters.V_IOLRegistrationTableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnFindHistoryPatient = New System.Windows.Forms.Button
        Me.BtnReportDisease = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnNewInpatient = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.GridNewInPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextNewInPatient.SuspendLayout()
        CType(Me.DSWardWithOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuPrepareOT.SuspendLayout()
        CType(Me.DSPrepareOTList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuTreatment.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridNewInPatient
        '
        Me.GridNewInPatient.AllowChildTableGroups = True
        Me.GridNewInPatient.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridNewInPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridNewInPatient.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridNewInPatient.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet
        Me.GridNewInPatient.ContextMenuStrip = Me.ContextNewInPatient
        Me.GridNewInPatient.DataMember = "V_NewInpatientDetial"
        Me.GridNewInPatient.DataSource = Me.DSWardWithOT
        GridNewInPatient_DesignTimeLayout.LayoutString = resources.GetString("GridNewInPatient_DesignTimeLayout.LayoutString")
        Me.GridNewInPatient.DesignTimeLayout = GridNewInPatient_DesignTimeLayout
        Me.GridNewInPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNewInPatient.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridNewInPatient.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridNewInPatient.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridNewInPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridNewInPatient.GroupByBoxVisible = False
        Me.GridNewInPatient.GroupRowFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridNewInPatient.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridNewInPatient.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.GridNewInPatient.HeaderFormatStyle.FontSize = 11.0!
        Me.GridNewInPatient.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridNewInPatient.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridNewInPatient.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridNewInPatient.Location = New System.Drawing.Point(3, 33)
        Me.GridNewInPatient.Name = "GridNewInPatient"
        Me.GridNewInPatient.RecordNavigator = True
        Me.GridNewInPatient.RowFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridNewInPatient.RowFormatStyle.FontSize = 12.0!
        Me.GridNewInPatient.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridNewInPatient.SelectedFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.GridNewInPatient.SelectedFormatStyle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GridNewInPatient.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridNewInPatient.Size = New System.Drawing.Size(1174, 1129)
        Me.GridNewInPatient.TabIndex = 1
        Me.GridNewInPatient.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ContextNewInPatient
        '
        Me.ContextNewInPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ContextNewInPatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaillyBooksToolStripMenuItem, Me.ToolStripSeparator2, Me.PrepareOTRegistrationToolStripMenuItem, Me.OTRegistrationToolStripMenuItem, Me.ToolStripMenuItem1, Me.LeaveToolStripMenuItem, Me.ToolStripMenuItem3, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem12})
        Me.ContextNewInPatient.Name = "ContextMenuStrip1"
        Me.ContextNewInPatient.Size = New System.Drawing.Size(171, 138)
        '
        'DaillyBooksToolStripMenuItem
        '
        Me.DaillyBooksToolStripMenuItem.Name = "DaillyBooksToolStripMenuItem"
        Me.DaillyBooksToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DaillyBooksToolStripMenuItem.Text = "Dailly Treatment..."
        Me.DaillyBooksToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'PrepareOTRegistrationToolStripMenuItem
        '
        Me.PrepareOTRegistrationToolStripMenuItem.Name = "PrepareOTRegistrationToolStripMenuItem"
        Me.PrepareOTRegistrationToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PrepareOTRegistrationToolStripMenuItem.Text = "Prepare Operatin"
        '
        'OTRegistrationToolStripMenuItem
        '
        Me.OTRegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrepareOTRegistrattion1, Me.MoveToListOTToolStripMenuItem, Me.BtnMovePatientWaiting1, Me.ToolStripMenuItem2, Me.BtnSetToNormal1})
        Me.OTRegistrationToolStripMenuItem.Name = "OTRegistrationToolStripMenuItem"
        Me.OTRegistrationToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OTRegistrationToolStripMenuItem.Text = "OT Registration"
        Me.OTRegistrationToolStripMenuItem.Visible = False
        '
        'BtnPrepareOTRegistrattion1
        '
        Me.BtnPrepareOTRegistrattion1.Name = "BtnPrepareOTRegistrattion1"
        Me.BtnPrepareOTRegistrattion1.Size = New System.Drawing.Size(261, 22)
        Me.BtnPrepareOTRegistrattion1.Text = "Prepare OT Registration..."
        '
        'MoveToListOTToolStripMenuItem
        '
        Me.MoveToListOTToolStripMenuItem.Name = "MoveToListOTToolStripMenuItem"
        Me.MoveToListOTToolStripMenuItem.Size = New System.Drawing.Size(258, 6)
        '
        'BtnMovePatientWaiting1
        '
        Me.BtnMovePatientWaiting1.Name = "BtnMovePatientWaiting1"
        Me.BtnMovePatientWaiting1.Size = New System.Drawing.Size(261, 22)
        Me.BtnMovePatientWaiting1.Text = "Move Patient Waiting to List OT >>"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(258, 6)
        '
        'BtnSetToNormal1
        '
        Me.BtnSetToNormal1.Name = "BtnSetToNormal1"
        Me.BtnSetToNormal1.Size = New System.Drawing.Size(261, 22)
        Me.BtnSetToNormal1.Text = "Set To Normal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnReferal, Me.ToolStripMenuItem4, Me.BtnPermissionLeave, Me.ToolStripMenuItem5, Me.BtnNoPermissionLeave})
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        Me.LeaveToolStripMenuItem.Visible = False
        '
        'BtnReferal
        '
        Me.BtnReferal.Name = "BtnReferal"
        Me.BtnReferal.Size = New System.Drawing.Size(184, 22)
        Me.BtnReferal.Text = "Referal"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 6)
        '
        'BtnPermissionLeave
        '
        Me.BtnPermissionLeave.Name = "BtnPermissionLeave"
        Me.BtnPermissionLeave.Size = New System.Drawing.Size(184, 22)
        Me.BtnPermissionLeave.Text = "Permission Leave"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 6)
        '
        'BtnNoPermissionLeave
        '
        Me.BtnNoPermissionLeave.Name = "BtnNoPermissionLeave"
        Me.BtnNoPermissionLeave.Size = New System.Drawing.Size(184, 22)
        Me.BtnNoPermissionLeave.Text = "No Permission Leave"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(167, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MCancel, Me.ToolStripMenuItem6, Me.MUndoCancel})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DeleteToolStripMenuItem.Text = "Remove"
        '
        'MCancel
        '
        Me.MCancel.Name = "MCancel"
        Me.MCancel.Size = New System.Drawing.Size(142, 22)
        Me.MCancel.Text = "Cancel"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(139, 6)
        Me.ToolStripMenuItem6.Visible = False
        '
        'MUndoCancel
        '
        Me.MUndoCancel.Name = "MUndoCancel"
        Me.MUndoCancel.Size = New System.Drawing.Size(142, 22)
        Me.MUndoCancel.Text = "Undo Cancel"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(167, 6)
        Me.ToolStripMenuItem12.Visible = False
        '
        'DSWardWithOT
        '
        Me.DSWardWithOT.DataSetName = "DSWardWithOT"
        Me.DSWardWithOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuPrepareOT
        '
        Me.ContextMenuPrepareOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ContextMenuPrepareOT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToWaitingOTToolStripMenuItem})
        Me.ContextMenuPrepareOT.Name = "ContextMenuPrepareOT"
        Me.ContextMenuPrepareOT.Size = New System.Drawing.Size(204, 26)
        '
        'MoveToWaitingOTToolStripMenuItem
        '
        Me.MoveToWaitingOTToolStripMenuItem.Name = "MoveToWaitingOTToolStripMenuItem"
        Me.MoveToWaitingOTToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MoveToWaitingOTToolStripMenuItem.Text = "<< Move To Waiting OT"
        '
        'DSPrepareOTList
        '
        Me.DSPrepareOTList.DataSetName = "DSPrepareOTList"
        Me.DSPrepareOTList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuTreatment
        '
        Me.ContextMenuTreatment.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ContextMenuTreatment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ContextMenuTreatment.Name = "ContextMenuTreatment"
        Me.ContextMenuTreatment.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnViewOTHistory)
        Me.GroupBox4.Controls.Add(Me.BtnShow)
        Me.GroupBox4.Controls.Add(Me.DateToAdmid)
        Me.GroupBox4.Controls.Add(Me.DateFromAdmid)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(18, 403)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(268, 143)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Patient Admission History"
        Me.GroupBox4.Visible = False
        '
        'BtnViewOTHistory
        '
        Me.BtnViewOTHistory.BackgroundImage = CType(resources.GetObject("BtnViewOTHistory.BackgroundImage"), System.Drawing.Image)
        Me.BtnViewOTHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnViewOTHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewOTHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnViewOTHistory.ForeColor = System.Drawing.Color.White
        Me.BtnViewOTHistory.Location = New System.Drawing.Point(153, 99)
        Me.BtnViewOTHistory.Name = "BtnViewOTHistory"
        Me.BtnViewOTHistory.Size = New System.Drawing.Size(92, 31)
        Me.BtnViewOTHistory.TabIndex = 4
        Me.BtnViewOTHistory.Text = "View OT History"
        Me.BtnViewOTHistory.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.BackColor = System.Drawing.Color.Transparent
        Me.BtnShow.BackgroundImage = CType(resources.GetObject("BtnShow.BackgroundImage"), System.Drawing.Image)
        Me.BtnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShow.ForeColor = System.Drawing.Color.White
        Me.BtnShow.Location = New System.Drawing.Point(68, 99)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(79, 30)
        Me.BtnShow.TabIndex = 3
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = False
        '
        'DateToAdmid
        '
        Me.DateToAdmid.CustomFormat = "dd - MM - yyyy"
        Me.DateToAdmid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToAdmid.Location = New System.Drawing.Point(68, 67)
        Me.DateToAdmid.Name = "DateToAdmid"
        Me.DateToAdmid.Size = New System.Drawing.Size(177, 26)
        Me.DateToAdmid.TabIndex = 0
        '
        'DateFromAdmid
        '
        Me.DateFromAdmid.CustomFormat = "dd - MM - yyyy"
        Me.DateFromAdmid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFromAdmid.Location = New System.Drawing.Point(68, 36)
        Me.DateFromAdmid.Name = "DateFromAdmid"
        Me.DateFromAdmid.Size = New System.Drawing.Size(177, 26)
        Me.DateFromAdmid.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "From:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 20)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "To:"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "sort_ascending.ico")
        Me.imageList1.Images.SetKeyName(1, "sort_descending.ico")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.BtnReloadData, Me.ToolStripSeparator8, Me.ToolStripLabel1, Me.TxtPatientNo, Me.BtnFind, Me.ToolStripSeparator6, Me.BtnNewDiallyBook, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator3, Me.ToolStripDropDownButton2, Me.ToolStripSeparator4, Me.ToolStripDropDownButton3, Me.ToolStripSeparator7, Me.BtnOrder, Me.ToolStripSeparator9, Me.Statistic, Me.ToolStripSeparator10})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1342, 33)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 33)
        '
        'BtnReloadData
        '
        Me.BtnReloadData.BackgroundImage = CType(resources.GetObject("BtnReloadData.BackgroundImage"), System.Drawing.Image)
        Me.BtnReloadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReloadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnReloadData.ForeColor = System.Drawing.Color.White
        Me.BtnReloadData.Image = Global.HospitalMS.My.Resources.Resources.refresh
        Me.BtnReloadData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReloadData.Name = "BtnReloadData"
        Me.BtnReloadData.Size = New System.Drawing.Size(146, 30)
        Me.BtnReloadData.Text = "   Refresh Data   "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 30)
        Me.ToolStripLabel1.Text = "Patient No:"
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(200, 33)
        '
        'BtnFind
        '
        Me.BtnFind.BackgroundImage = CType(resources.GetObject("BtnFind.BackgroundImage"), System.Drawing.Image)
        Me.BtnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFind.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Image = Global.HospitalMS.My.Resources.Resources.search
        Me.BtnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(81, 30)
        Me.BtnFind.Text = "Find       "
        Me.BtnFind.ToolTipText = "    Find"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 33)
        '
        'BtnNewDiallyBook
        '
        Me.BtnNewDiallyBook.BackgroundImage = CType(resources.GetObject("BtnNewDiallyBook.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewDiallyBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewDiallyBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNewDiallyBook.ForeColor = System.Drawing.Color.White
        Me.BtnNewDiallyBook.Image = CType(resources.GetObject("BtnNewDiallyBook.Image"), System.Drawing.Image)
        Me.BtnNewDiallyBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewDiallyBook.Name = "BtnNewDiallyBook"
        Me.BtnNewDiallyBook.Size = New System.Drawing.Size(117, 30)
        Me.BtnNewDiallyBook.Text = "Patient history"
        Me.BtnNewDiallyBook.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.BackgroundImage = CType(resources.GetObject("ToolStripDropDownButton1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrepareOTRegistrattion, Me.ToolStripMenuItem7, Me.BtnMovePatientWaiting, Me.ToolStripMenuItem9, Me.BtnSetToNormal})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(136, 30)
        Me.ToolStripDropDownButton1.Text = "OT Registration"
        Me.ToolStripDropDownButton1.Visible = False
        '
        'BtnPrepareOTRegistrattion
        '
        Me.BtnPrepareOTRegistrattion.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.BtnPrepareOTRegistrattion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrepareOTRegistrattion.ForeColor = System.Drawing.Color.White
        Me.BtnPrepareOTRegistrattion.Name = "BtnPrepareOTRegistrattion"
        Me.BtnPrepareOTRegistrattion.Size = New System.Drawing.Size(329, 22)
        Me.BtnPrepareOTRegistrattion.Text = "Prepare OT Registration..."
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(326, 6)
        '
        'BtnMovePatientWaiting
        '
        Me.BtnMovePatientWaiting.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.BtnMovePatientWaiting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMovePatientWaiting.ForeColor = System.Drawing.Color.White
        Me.BtnMovePatientWaiting.Name = "BtnMovePatientWaiting"
        Me.BtnMovePatientWaiting.Size = New System.Drawing.Size(329, 22)
        Me.BtnMovePatientWaiting.Text = "Move Patient Waiting to List OT >>"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(326, 6)
        '
        'BtnSetToNormal
        '
        Me.BtnSetToNormal.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.BtnSetToNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSetToNormal.ForeColor = System.Drawing.Color.White
        Me.BtnSetToNormal.Name = "BtnSetToNormal"
        Me.BtnSetToNormal.Size = New System.Drawing.Size(329, 22)
        Me.BtnSetToNormal.Text = "Set To Normal"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator3.Visible = False
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.BackgroundImage = CType(resources.GetObject("ToolStripDropDownButton2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Referal, Me.ToolStripMenuItem10, Me.PermissionLeave, Me.ToolStripMenuItem8, Me.NoPermissionLeave})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(65, 30)
        Me.ToolStripDropDownButton2.Text = "Leave"
        Me.ToolStripDropDownButton2.Visible = False
        '
        'Referal
        '
        Me.Referal.ForeColor = System.Drawing.Color.Blue
        Me.Referal.Name = "Referal"
        Me.Referal.Size = New System.Drawing.Size(229, 22)
        Me.Referal.Text = "Referal"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(226, 6)
        '
        'PermissionLeave
        '
        Me.PermissionLeave.ForeColor = System.Drawing.Color.Blue
        Me.PermissionLeave.Name = "PermissionLeave"
        Me.PermissionLeave.Size = New System.Drawing.Size(229, 22)
        Me.PermissionLeave.Text = "Permission Leave"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(226, 6)
        '
        'NoPermissionLeave
        '
        Me.NoPermissionLeave.ForeColor = System.Drawing.Color.Blue
        Me.NoPermissionLeave.Name = "NoPermissionLeave"
        Me.NoPermissionLeave.Size = New System.Drawing.Size(229, 22)
        Me.NoPermissionLeave.Text = "No Permission Leave"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator4.Visible = False
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.BackgroundImage = CType(resources.GetObject("ToolStripDropDownButton3.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveDailyInPatient, Me.ToolStripMenuItem11, Me.ViewDailyInpatient})
        Me.ToolStripDropDownButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripDropDownButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton3.Image = Global.HospitalMS.My.Resources.Resources.alarm_hareketli
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(117, 30)
        Me.ToolStripDropDownButton3.Text = "Nurse on call"
        Me.ToolStripDropDownButton3.Visible = False
        '
        'SaveDailyInPatient
        '
        Me.SaveDailyInPatient.ForeColor = System.Drawing.Color.Blue
        Me.SaveDailyInPatient.Name = "SaveDailyInPatient"
        Me.SaveDailyInPatient.Size = New System.Drawing.Size(194, 22)
        Me.SaveDailyInPatient.Text = "Save Daily In-Patient"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(191, 6)
        '
        'ViewDailyInpatient
        '
        Me.ViewDailyInpatient.ForeColor = System.Drawing.Color.Blue
        Me.ViewDailyInpatient.Name = "ViewDailyInpatient"
        Me.ViewDailyInpatient.Size = New System.Drawing.Size(194, 22)
        Me.ViewDailyInpatient.Text = "View Daily Inpatient"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator7.Visible = False
        '
        'BtnOrder
        '
        Me.BtnOrder.BackgroundImage = CType(resources.GetObject("BtnOrder.BackgroundImage"), System.Drawing.Image)
        Me.BtnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnOrder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnOrder.ForeColor = System.Drawing.Color.White
        Me.BtnOrder.Image = CType(resources.GetObject("BtnOrder.Image"), System.Drawing.Image)
        Me.BtnOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(146, 30)
        Me.BtnOrder.Text = "  Group Type of Patient  "
        Me.BtnOrder.Visible = False
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator9.Visible = False
        '
        'Statistic
        '
        Me.Statistic.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.Statistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Statistic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Statistic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Statistic.ForeColor = System.Drawing.Color.White
        Me.Statistic.Image = CType(resources.GetObject("Statistic.Image"), System.Drawing.Image)
        Me.Statistic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Statistic.Name = "Statistic"
        Me.Statistic.Size = New System.Drawing.Size(129, 30)
        Me.Statistic.Text = "  In Patient Statistic  "
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 33)
        '
        'BgLoadNewInpatient
        '
        '
        'V_NewInpatientDetialTableAdapterPrepare
        '
        Me.V_NewInpatientDetialTableAdapterPrepare.ClearBeforeFill = True
        '
        'View_OTRegistrationTableAdapterPrepare
        '
        Me.View_OTRegistrationTableAdapterPrepare.ClearBeforeFill = True
        '
        'V_IOLRegistrationTableAdapterPrepare
        '
        Me.V_IOLRegistrationTableAdapterPrepare.ClearBeforeFill = True
        '
        'V_NewInpatientDetialTableAdapter
        '
        Me.V_NewInpatientDetialTableAdapter.ClearBeforeFill = True
        '
        'View_OTRegistrationTableAdapter
        '
        Me.View_OTRegistrationTableAdapter.ClearBeforeFill = True
        '
        'V_IOLRegistrationTableAdapter
        '
        Me.V_IOLRegistrationTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BtnFindHistoryPatient
        '
        Me.BtnFindHistoryPatient.BackgroundImage = CType(resources.GetObject("BtnFindHistoryPatient.BackgroundImage"), System.Drawing.Image)
        Me.BtnFindHistoryPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFindHistoryPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindHistoryPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFindHistoryPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindHistoryPatient.ForeColor = System.Drawing.Color.White
        Me.BtnFindHistoryPatient.Location = New System.Drawing.Point(3, 280)
        Me.BtnFindHistoryPatient.Name = "BtnFindHistoryPatient"
        Me.BtnFindHistoryPatient.Size = New System.Drawing.Size(137, 37)
        Me.BtnFindHistoryPatient.TabIndex = 6
        Me.BtnFindHistoryPatient.Text = "Prepare OP"
        Me.BtnFindHistoryPatient.UseVisualStyleBackColor = True
        '
        'BtnReportDisease
        '
        Me.BtnReportDisease.BackgroundImage = CType(resources.GetObject("BtnReportDisease.BackgroundImage"), System.Drawing.Image)
        Me.BtnReportDisease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReportDisease.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportDisease.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReportDisease.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportDisease.ForeColor = System.Drawing.Color.White
        Me.BtnReportDisease.Location = New System.Drawing.Point(3, 237)
        Me.BtnReportDisease.Name = "BtnReportDisease"
        Me.BtnReportDisease.Size = New System.Drawing.Size(137, 37)
        Me.BtnReportDisease.TabIndex = 6
        Me.BtnReportDisease.Text = "Report Disease"
        Me.BtnReportDisease.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print Prepare OT list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnNewInpatient
        '
        Me.BtnNewInpatient.BackgroundImage = CType(resources.GetObject("BtnNewInpatient.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewInpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewInpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewInpatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewInpatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewInpatient.ForeColor = System.Drawing.Color.White
        Me.BtnNewInpatient.Location = New System.Drawing.Point(3, 151)
        Me.BtnNewInpatient.Name = "BtnNewInpatient"
        Me.BtnNewInpatient.Size = New System.Drawing.Size(137, 37)
        Me.BtnNewInpatient.TabIndex = 2
        Me.BtnNewInpatient.Text = "&New In-patient"
        Me.BtnNewInpatient.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnReportDisease)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnFindHistoryPatient)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnNewInpatient)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1342, 1167)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridNewInPatient)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1180, 1165)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ចំនួន អ្នករង់ចាំវះកាត់"
        '
        'UCNewInPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCNewInPatient"
        Me.Size = New System.Drawing.Size(1342, 1200)
        CType(Me.GridNewInPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextNewInPatient.ResumeLayout(False)
        CType(Me.DSWardWithOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuPrepareOT.ResumeLayout(False)
        CType(Me.DSPrepareOTList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuTreatment.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Leave1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leave2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContextNewInPatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DaillyBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OTRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnNewInpatient As System.Windows.Forms.Button
    Friend WithEvents LeaveTest As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveFromInpatient As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContextMenuTreatment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents q As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReferal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNoPermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DSWardWithOT As HospitalMS.DSWardWithOT
    Friend WithEvents V_NewInpatientDetialTableAdapter As HospitalMS.DSWardWithOTTableAdapters.V_NewInpatientDetialTableAdapter
    Friend WithEvents View_OTRegistrationTableAdapter As HospitalMS.DSWardWithOTTableAdapters.View_OTRegistrationTableAdapter
    Friend WithEvents BgLoadNewInpatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents V_IOLRegistrationTableAdapter As HospitalMS.DSWardWithOTTableAdapters.V_IOLRegistrationTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridNewInPatient As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReportDisease As System.Windows.Forms.Button
    Friend WithEvents BtnFindHistoryPatient As System.Windows.Forms.Button
    Friend WithEvents DSPrepareOTList As HospitalMS.DSPrepareOTList
    Friend WithEvents V_NewInpatientDetialTableAdapterPrepare As HospitalMS.DSPrepareOTListTableAdapters.V_NewInpatientDetialTableAdapter
    Friend WithEvents View_OTRegistrationTableAdapterPrepare As HospitalMS.DSPrepareOTListTableAdapters.View_OTRegistrationTableAdapter
    Friend WithEvents V_IOLRegistrationTableAdapterPrepare As HospitalMS.DSPrepareOTListTableAdapters.V_IOLRegistrationTableAdapter
    Friend WithEvents BtnPrepareOTRegistrattion1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToListOTToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMovePatientWaiting1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuPrepareOT As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoveToWaitingOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSetToNormal1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateFromAdmid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateToAdmid As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents MCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MUndoCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewDiallyBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrepareOTRegistrattion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMovePatientWaiting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSetToNormal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Referal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReloadData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoPermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SaveDailyInPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewDailyInpatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Statistic As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtPatientNo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BtnFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewOTHistory As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrepareOTRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
