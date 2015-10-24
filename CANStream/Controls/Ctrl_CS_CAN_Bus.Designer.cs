﻿/*
 * Created by SharpDevelop.
 * User: VBrault
 * Date: 10/13/2014
 * Time: 14:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CANStream
{
	partial class Ctrl_CS_CAN_Bus
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_CS_CAN_Bus));
            this.CtrlMain_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TSB_Refresh_USB_CAN_Device = new System.Windows.Forms.ToolStripButton();
            this.TS_Cmb_PCAN_USB_Devices = new System.Windows.Forms.ToolStripComboBox();
            this.TS_Lbl_CanSpeed = new System.Windows.Forms.ToolStripLabel();
            this.TSB_CAN_LinkOff = new System.Windows.Forms.ToolStripButton();
            this.TSB_CAN_LinkOn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_StartCANTraceRecording = new System.Windows.Forms.ToolStripButton();
            this.TSB_StopCANTraceRecording = new System.Windows.Forms.ToolStripButton();
            this.TSB_RecordSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSSB_View = new System.Windows.Forms.ToolStripSplitButton();
            this.TSMI_SpyManual = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TxMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TxMessages_Eng = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TxMessages_Raw = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RxMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RxMessages_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RxMsg_Data_Eng = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RxMsg_Data_Raw = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RxMessages_Graph = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CyclePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CyclePlayer_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CyclePlayer_Data_Eng = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CyclePlayer_Data_Raw = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CyclePlayer_Graph = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_ResetLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPg_SpyAndManual = new System.Windows.Forms.TabPage();
            this.Split_RxTx = new System.Windows.Forms.SplitContainer();
            this.Split_Tx_EngRaw = new System.Windows.Forms.SplitContainer();
            this.Grid_CANData = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RxTx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuxVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endianess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinGain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinZero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context_ManualGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHiddenRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualGrid_Filter_Combo_TSMI = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextManual_columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_hideAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Context_Manual_iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_rxTxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_periodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_muxValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_lengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_endianessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_signedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_gainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_zeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Manual_commentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_CANRawData = new System.Windows.Forms.DataGridView();
            this.GridCol_Raw_Tx_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_DLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_Sent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GridCol_Raw_Tx_BtnTx = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GridCol_Raw_Tx_B0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCol_Raw_Tx_B7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context_ManualRawGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Ctxt_TxRaw_Add_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Ctxt_TxRaw_Del_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Ctxt_TxRaw_Clear_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Ctxt_TxRaw_Save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Ctxt_TxRaw_Open_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Split_Rx_DataGraph = new System.Windows.Forms.SplitContainer();
            this.Manual_SpyDataViewer = new CANStream.Ctrl_SpyDataViewer();
            this.Tab_SpyHistory = new System.Windows.Forms.TabControl();
            this.Tab_SpyHistory_Graph = new System.Windows.Forms.TabPage();
            this.Graph_Spy = new ChartDirector.WinChartViewer();
            this.Cmd_GraphSpyRec = new System.Windows.Forms.Button();
            this.Img_Cmd_GraphSpyRec = new System.Windows.Forms.ImageList(this.components);
            this.ChkLst_ChannelSel = new System.Windows.Forms.CheckedListBox();
            this.Context_SpyGraphChannels = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_SpyGraph_Filter_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_SpyGraph_Filter_TSCmb = new System.Windows.Forms.ToolStripComboBox();
            this.Cmd_GraphSpyPause = new System.Windows.Forms.Button();
            this.Img_Cmd_GraphSpyPause = new System.Windows.Forms.ImageList(this.components);
            this.Grp_GraphProperties = new System.Windows.Forms.GroupBox();
            this.Txt_SpyGraphTimeWindow = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_SpyGraphYMax = new System.Windows.Forms.TextBox();
            this.Txt_SpyGraphYMin = new System.Windows.Forms.TextBox();
            this.Chk_SpyGraphAutoScale = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tab_SpyHistory_Data = new System.Windows.Forms.TabPage();
            this.Lst_SpyDataHistory = new System.Windows.Forms.ListBox();
            this.TS_SpyDataHistory = new System.Windows.Forms.ToolStrip();
            this.TSB_FreezeHistory = new System.Windows.Forms.ToolStripButton();
            this.TSB_ResumeHistory = new System.Windows.Forms.ToolStripButton();
            this.TSB_ClearHistory = new System.Windows.Forms.ToolStripButton();
            this.TSB_ExportHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSLbl_IdFilterFrom = new System.Windows.Forms.ToolStripLabel();
            this.TSTxt_IdFilterFrom = new System.Windows.Forms.ToolStripTextBox();
            this.TSLbl_IdFilterTo = new System.Windows.Forms.ToolStripLabel();
            this.TSTxt_IdFilterTo = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Chk_VirtualParamTxEnabled = new System.Windows.Forms.CheckBox();
            this.Chk_CycleMux = new System.Windows.Forms.CheckBox();
            this.Lbl_MsgCounter = new System.Windows.Forms.Label();
            this.Txt_MsgCounter = new System.Windows.Forms.TextBox();
            this.Cmb_SpyCANRate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_SpyIdFilterMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_SpyIdFilterMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_SpyCANRxMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmd_StopSpy = new System.Windows.Forms.Button();
            this.Cmd_StartSpy = new System.Windows.Forms.Button();
            this.TabPg_Cycle = new System.Windows.Forms.TabPage();
            this.Panel_Cycle = new System.Windows.Forms.Panel();
            this.Split_Cycle_VirtualSig_Graph = new System.Windows.Forms.SplitContainer();
            this.Cycle_SpyDataViewer = new CANStream.Ctrl_SpyDataViewer();
            this.Graph_Cycle = new ChartDirector.WinChartViewer();
            this.Context_CycleGraph = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Chk_CycleVirtualParamTxEnabled = new System.Windows.Forms.CheckBox();
            this.Txt_CycleEnd = new System.Windows.Forms.TextBox();
            this.Txt_CycleStart = new System.Windows.Forms.TextBox();
            this.Lbl_CycleEnd = new System.Windows.Forms.Label();
            this.Lbl_CycleStart = new System.Windows.Forms.Label();
            this.Chk_InfinitePlay = new System.Windows.Forms.CheckBox();
            this.Lbl_TotalProgress = new System.Windows.Forms.Label();
            this.Txt_CurrentCycleNum = new System.Windows.Forms.TextBox();
            this.Lbl_CurrentCycleNum = new System.Windows.Forms.Label();
            this.PB_TotalProgress = new System.Windows.Forms.ProgressBar();
            this.PB_CurrentProgress = new System.Windows.Forms.ProgressBar();
            this.Lbl_CurrentProgress = new System.Windows.Forms.Label();
            this.Lbl_CycleCount = new System.Windows.Forms.Label();
            this.NumUpDown_CycleCount = new System.Windows.Forms.NumericUpDown();
            this.Cmd_StopCycle = new System.Windows.Forms.Button();
            this.Cmd_BreakCycle = new System.Windows.Forms.Button();
            this.Cmd_PlayCycle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTxt_CycleComments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_CanConfig = new System.Windows.Forms.Label();
            this.Lbl_CycleFile = new System.Windows.Forms.Label();
            this.Img_TabControl = new System.Windows.Forms.ImageList(this.components);
            this.Timer_CycleGraph = new System.Windows.Forms.Timer(this.components);
            this.Timer_CheckDevice = new System.Windows.Forms.Timer(this.components);
            this.BGWrk_Cycle = new System.ComponentModel.BackgroundWorker();
            this.BGWrk_Manual = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BGWrk_Spy = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CtrlMain_ToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPg_SpyAndManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split_RxTx)).BeginInit();
            this.Split_RxTx.Panel1.SuspendLayout();
            this.Split_RxTx.Panel2.SuspendLayout();
            this.Split_RxTx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split_Tx_EngRaw)).BeginInit();
            this.Split_Tx_EngRaw.Panel1.SuspendLayout();
            this.Split_Tx_EngRaw.Panel2.SuspendLayout();
            this.Split_Tx_EngRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CANData)).BeginInit();
            this.Context_ManualGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CANRawData)).BeginInit();
            this.Context_ManualRawGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split_Rx_DataGraph)).BeginInit();
            this.Split_Rx_DataGraph.Panel1.SuspendLayout();
            this.Split_Rx_DataGraph.Panel2.SuspendLayout();
            this.Split_Rx_DataGraph.SuspendLayout();
            this.Tab_SpyHistory.SuspendLayout();
            this.Tab_SpyHistory_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Spy)).BeginInit();
            this.Context_SpyGraphChannels.SuspendLayout();
            this.Grp_GraphProperties.SuspendLayout();
            this.Tab_SpyHistory_Data.SuspendLayout();
            this.TS_SpyDataHistory.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabPg_Cycle.SuspendLayout();
            this.Panel_Cycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split_Cycle_VirtualSig_Graph)).BeginInit();
            this.Split_Cycle_VirtualSig_Graph.Panel1.SuspendLayout();
            this.Split_Cycle_VirtualSig_Graph.Panel2.SuspendLayout();
            this.Split_Cycle_VirtualSig_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Cycle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_CycleCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlMain_ToolStrip
            // 
            this.CtrlMain_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Refresh_USB_CAN_Device,
            this.TS_Cmb_PCAN_USB_Devices,
            this.TS_Lbl_CanSpeed,
            this.TSB_CAN_LinkOff,
            this.TSB_CAN_LinkOn,
            this.toolStripSeparator2,
            this.TSB_StartCANTraceRecording,
            this.TSB_StopCANTraceRecording,
            this.TSB_RecordSelection,
            this.toolStripSeparator1,
            this.TSSB_View});
            this.CtrlMain_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CtrlMain_ToolStrip.Name = "CtrlMain_ToolStrip";
            this.CtrlMain_ToolStrip.Size = new System.Drawing.Size(978, 25);
            this.CtrlMain_ToolStrip.TabIndex = 7;
            this.CtrlMain_ToolStrip.Text = "toolStrip1";
            // 
            // TSB_Refresh_USB_CAN_Device
            // 
            this.TSB_Refresh_USB_CAN_Device.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Refresh_USB_CAN_Device.Image = global::CANStream.Icones.Refresh_CAN_Controllers;
            this.TSB_Refresh_USB_CAN_Device.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Refresh_USB_CAN_Device.Name = "TSB_Refresh_USB_CAN_Device";
            this.TSB_Refresh_USB_CAN_Device.Size = new System.Drawing.Size(23, 22);
            this.TSB_Refresh_USB_CAN_Device.Text = "toolStripButton4";
            this.TSB_Refresh_USB_CAN_Device.ToolTipText = "Refresh PCAN USB Devices list";
            this.TSB_Refresh_USB_CAN_Device.Click += new System.EventHandler(this.TSB_Refresh_USB_CAN_DeviceClick);
            // 
            // TS_Cmb_PCAN_USB_Devices
            // 
            this.TS_Cmb_PCAN_USB_Devices.BackColor = System.Drawing.SystemColors.Control;
            this.TS_Cmb_PCAN_USB_Devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TS_Cmb_PCAN_USB_Devices.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TS_Cmb_PCAN_USB_Devices.Name = "TS_Cmb_PCAN_USB_Devices";
            this.TS_Cmb_PCAN_USB_Devices.Size = new System.Drawing.Size(121, 25);
            this.TS_Cmb_PCAN_USB_Devices.SelectedIndexChanged += new System.EventHandler(this.TS_Cmb_PCAN_USB_DevicesSelectedIndexChanged);
            // 
            // TS_Lbl_CanSpeed
            // 
            this.TS_Lbl_CanSpeed.Enabled = false;
            this.TS_Lbl_CanSpeed.Name = "TS_Lbl_CanSpeed";
            this.TS_Lbl_CanSpeed.Size = new System.Drawing.Size(88, 22);
            this.TS_Lbl_CanSpeed.Text = "CAN Baud rate:";
            // 
            // TSB_CAN_LinkOff
            // 
            this.TSB_CAN_LinkOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_CAN_LinkOff.Image = global::CANStream.Icones.CAN_Link_Off;
            this.TSB_CAN_LinkOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CAN_LinkOff.Name = "TSB_CAN_LinkOff";
            this.TSB_CAN_LinkOff.Size = new System.Drawing.Size(23, 22);
            this.TSB_CAN_LinkOff.Text = "toolStripButton4";
            this.TSB_CAN_LinkOff.ToolTipText = "Start connection";
            this.TSB_CAN_LinkOff.Click += new System.EventHandler(this.TSB_CAN_LinkOffClick);
            // 
            // TSB_CAN_LinkOn
            // 
            this.TSB_CAN_LinkOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_CAN_LinkOn.Image = global::CANStream.Icones.CAN_Link_On;
            this.TSB_CAN_LinkOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CAN_LinkOn.Name = "TSB_CAN_LinkOn";
            this.TSB_CAN_LinkOn.Size = new System.Drawing.Size(23, 22);
            this.TSB_CAN_LinkOn.Text = "toolStripButton5";
            this.TSB_CAN_LinkOn.ToolTipText = "Stop connection";
            this.TSB_CAN_LinkOn.Visible = false;
            this.TSB_CAN_LinkOn.Click += new System.EventHandler(this.TSB_CAN_LinkOnClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_StartCANTraceRecording
            // 
            this.TSB_StartCANTraceRecording.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_StartCANTraceRecording.Enabled = false;
            this.TSB_StartCANTraceRecording.Image = global::CANStream.Icones.Start_Record;
            this.TSB_StartCANTraceRecording.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_StartCANTraceRecording.Name = "TSB_StartCANTraceRecording";
            this.TSB_StartCANTraceRecording.Size = new System.Drawing.Size(23, 22);
            this.TSB_StartCANTraceRecording.Text = "toolStripButton4";
            this.TSB_StartCANTraceRecording.ToolTipText = "Start stream recording";
            this.TSB_StartCANTraceRecording.Click += new System.EventHandler(this.TSB_StartCANTraceRecordingClick);
            // 
            // TSB_StopCANTraceRecording
            // 
            this.TSB_StopCANTraceRecording.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_StopCANTraceRecording.Enabled = false;
            this.TSB_StopCANTraceRecording.Image = global::CANStream.Icones.Stop_Recording;
            this.TSB_StopCANTraceRecording.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_StopCANTraceRecording.Name = "TSB_StopCANTraceRecording";
            this.TSB_StopCANTraceRecording.Size = new System.Drawing.Size(23, 22);
            this.TSB_StopCANTraceRecording.Text = "toolStripButton5";
            this.TSB_StopCANTraceRecording.ToolTipText = "Stop stream recording";
            this.TSB_StopCANTraceRecording.Click += new System.EventHandler(this.TSB_StopCANTraceRecordingClick);
            // 
            // TSB_RecordSelection
            // 
            this.TSB_RecordSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_RecordSelection.Image = global::CANStream.Icones.Run_Process_16;
            this.TSB_RecordSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_RecordSelection.Name = "TSB_RecordSelection";
            this.TSB_RecordSelection.Size = new System.Drawing.Size(23, 22);
            this.TSB_RecordSelection.Text = "TSB_RecordSelection";
            this.TSB_RecordSelection.ToolTipText = "Select record to convert";
            this.TSB_RecordSelection.Click += new System.EventHandler(this.TSB_RecordSelection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSSB_View
            // 
            this.TSSB_View.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSB_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SpyManual,
            this.TSMI_CyclePlayer,
            this.toolStripMenuItem2,
            this.TSMI_ResetLayout});
            this.TSSB_View.Image = global::CANStream.Icones.Controller_Layout;
            this.TSSB_View.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSB_View.Name = "TSSB_View";
            this.TSSB_View.Size = new System.Drawing.Size(32, 22);
            this.TSSB_View.Text = "toolStripSplitButton1";
            this.TSSB_View.ToolTipText = "View";
            // 
            // TSMI_SpyManual
            // 
            this.TSMI_SpyManual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TxMessages,
            this.TSMI_RxMessages});
            this.TSMI_SpyManual.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_SpyManual.Image")));
            this.TSMI_SpyManual.Name = "TSMI_SpyManual";
            this.TSMI_SpyManual.Size = new System.Drawing.Size(159, 22);
            this.TSMI_SpyManual.Text = "Spy and Manual";
            // 
            // TSMI_TxMessages
            // 
            this.TSMI_TxMessages.Checked = true;
            this.TSMI_TxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_TxMessages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TxMessages_Eng,
            this.TSMI_TxMessages_Raw});
            this.TSMI_TxMessages.Image = global::CANStream.Icones.Message_Tx;
            this.TSMI_TxMessages.Name = "TSMI_TxMessages";
            this.TSMI_TxMessages.Size = new System.Drawing.Size(140, 22);
            this.TSMI_TxMessages.Text = "Messages Tx";
            this.TSMI_TxMessages.ToolTipText = "Show/Hide CAN Transmission control";
            this.TSMI_TxMessages.Click += new System.EventHandler(this.TSMI_TxMessagesClick);
            // 
            // TSMI_TxMessages_Eng
            // 
            this.TSMI_TxMessages_Eng.Checked = true;
            this.TSMI_TxMessages_Eng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_TxMessages_Eng.Image = global::CANStream.Icones.Engineering_Data;
            this.TSMI_TxMessages_Eng.Name = "TSMI_TxMessages_Eng";
            this.TSMI_TxMessages_Eng.Size = new System.Drawing.Size(191, 22);
            this.TSMI_TxMessages_Eng.Text = "Engineering messages";
            this.TSMI_TxMessages_Eng.Click += new System.EventHandler(this.TSMI_TxMessages_EngClick);
            // 
            // TSMI_TxMessages_Raw
            // 
            this.TSMI_TxMessages_Raw.Checked = true;
            this.TSMI_TxMessages_Raw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_TxMessages_Raw.Image = global::CANStream.Icones.Raw_Data;
            this.TSMI_TxMessages_Raw.Name = "TSMI_TxMessages_Raw";
            this.TSMI_TxMessages_Raw.Size = new System.Drawing.Size(191, 22);
            this.TSMI_TxMessages_Raw.Text = "Raw messages";
            this.TSMI_TxMessages_Raw.Click += new System.EventHandler(this.TSMI_TxMessages_RawClick);
            // 
            // TSMI_RxMessages
            // 
            this.TSMI_RxMessages.Checked = true;
            this.TSMI_RxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_RxMessages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_RxMessages_Data,
            this.TSMI_RxMessages_Graph});
            this.TSMI_RxMessages.Image = global::CANStream.Icones.Message_Rx;
            this.TSMI_RxMessages.Name = "TSMI_RxMessages";
            this.TSMI_RxMessages.Size = new System.Drawing.Size(140, 22);
            this.TSMI_RxMessages.Text = "Messages Rx";
            this.TSMI_RxMessages.ToolTipText = "Show/Hide CAN Spy control";
            this.TSMI_RxMessages.Click += new System.EventHandler(this.TSMI_RxMessagesClick);
            // 
            // TSMI_RxMessages_Data
            // 
            this.TSMI_RxMessages_Data.Checked = true;
            this.TSMI_RxMessages_Data.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_RxMessages_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_RxMsg_Data_Eng,
            this.TSMI_RxMsg_Data_Raw});
            this.TSMI_RxMessages_Data.Image = global::CANStream.Icones.Message_Rx;
            this.TSMI_RxMessages_Data.Name = "TSMI_RxMessages_Data";
            this.TSMI_RxMessages_Data.Size = new System.Drawing.Size(106, 22);
            this.TSMI_RxMessages_Data.Text = "Data";
            this.TSMI_RxMessages_Data.ToolTipText = "Show/Hide CAN Spy control data";
            this.TSMI_RxMessages_Data.Click += new System.EventHandler(this.TSMI_RxMessages_DataClick);
            // 
            // TSMI_RxMsg_Data_Eng
            // 
            this.TSMI_RxMsg_Data_Eng.Checked = true;
            this.TSMI_RxMsg_Data_Eng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_RxMsg_Data_Eng.Image = global::CANStream.Icones.Engineering_Data;
            this.TSMI_RxMsg_Data_Eng.Name = "TSMI_RxMsg_Data_Eng";
            this.TSMI_RxMsg_Data_Eng.Size = new System.Drawing.Size(191, 22);
            this.TSMI_RxMsg_Data_Eng.Text = "Engineering messages";
            this.TSMI_RxMsg_Data_Eng.Click += new System.EventHandler(this.TSMI_RxMsg_Data_EngClick);
            // 
            // TSMI_RxMsg_Data_Raw
            // 
            this.TSMI_RxMsg_Data_Raw.Checked = true;
            this.TSMI_RxMsg_Data_Raw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_RxMsg_Data_Raw.Image = global::CANStream.Icones.Raw_Data;
            this.TSMI_RxMsg_Data_Raw.Name = "TSMI_RxMsg_Data_Raw";
            this.TSMI_RxMsg_Data_Raw.Size = new System.Drawing.Size(191, 22);
            this.TSMI_RxMsg_Data_Raw.Text = "Raw messages";
            this.TSMI_RxMsg_Data_Raw.Click += new System.EventHandler(this.TSMI_RxMsg_Data_RawClick);
            // 
            // TSMI_RxMessages_Graph
            // 
            this.TSMI_RxMessages_Graph.Checked = true;
            this.TSMI_RxMessages_Graph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_RxMessages_Graph.Image = global::CANStream.Icones.Graph;
            this.TSMI_RxMessages_Graph.Name = "TSMI_RxMessages_Graph";
            this.TSMI_RxMessages_Graph.Size = new System.Drawing.Size(106, 22);
            this.TSMI_RxMessages_Graph.Text = "Graph";
            this.TSMI_RxMessages_Graph.ToolTipText = "Show/Hide CAN Spy control graph";
            this.TSMI_RxMessages_Graph.Click += new System.EventHandler(this.TSMI_RxMessages_GraphClick);
            // 
            // TSMI_CyclePlayer
            // 
            this.TSMI_CyclePlayer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CyclePlayer_Data,
            this.TSMI_CyclePlayer_Graph});
            this.TSMI_CyclePlayer.Enabled = false;
            this.TSMI_CyclePlayer.Image = global::CANStream.Icones.Cycle_16;
            this.TSMI_CyclePlayer.Name = "TSMI_CyclePlayer";
            this.TSMI_CyclePlayer.Size = new System.Drawing.Size(159, 22);
            this.TSMI_CyclePlayer.Text = "Cycle player";
            // 
            // TSMI_CyclePlayer_Data
            // 
            this.TSMI_CyclePlayer_Data.Checked = true;
            this.TSMI_CyclePlayer_Data.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_CyclePlayer_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CyclePlayer_Data_Eng,
            this.TSMI_CyclePlayer_Data_Raw});
            this.TSMI_CyclePlayer_Data.Image = global::CANStream.Icones.Message_Rx;
            this.TSMI_CyclePlayer_Data.Name = "TSMI_CyclePlayer_Data";
            this.TSMI_CyclePlayer_Data.Size = new System.Drawing.Size(106, 22);
            this.TSMI_CyclePlayer_Data.Text = "Data";
            this.TSMI_CyclePlayer_Data.Click += new System.EventHandler(this.TSMI_CyclePlayer_DataClick);
            // 
            // TSMI_CyclePlayer_Data_Eng
            // 
            this.TSMI_CyclePlayer_Data_Eng.Checked = true;
            this.TSMI_CyclePlayer_Data_Eng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_CyclePlayer_Data_Eng.Image = global::CANStream.Icones.Engineering_Data;
            this.TSMI_CyclePlayer_Data_Eng.Name = "TSMI_CyclePlayer_Data_Eng";
            this.TSMI_CyclePlayer_Data_Eng.Size = new System.Drawing.Size(191, 22);
            this.TSMI_CyclePlayer_Data_Eng.Text = "Engineering messages";
            this.TSMI_CyclePlayer_Data_Eng.Click += new System.EventHandler(this.TSMI_CyclePlayer_Data_EngClick);
            // 
            // TSMI_CyclePlayer_Data_Raw
            // 
            this.TSMI_CyclePlayer_Data_Raw.Checked = true;
            this.TSMI_CyclePlayer_Data_Raw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_CyclePlayer_Data_Raw.Image = global::CANStream.Icones.Raw_Data;
            this.TSMI_CyclePlayer_Data_Raw.Name = "TSMI_CyclePlayer_Data_Raw";
            this.TSMI_CyclePlayer_Data_Raw.Size = new System.Drawing.Size(191, 22);
            this.TSMI_CyclePlayer_Data_Raw.Text = "Raw messages";
            this.TSMI_CyclePlayer_Data_Raw.Click += new System.EventHandler(this.TSMI_CyclePlayer_Data_RawClick);
            // 
            // TSMI_CyclePlayer_Graph
            // 
            this.TSMI_CyclePlayer_Graph.Checked = true;
            this.TSMI_CyclePlayer_Graph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_CyclePlayer_Graph.Image = global::CANStream.Icones.Graph;
            this.TSMI_CyclePlayer_Graph.Name = "TSMI_CyclePlayer_Graph";
            this.TSMI_CyclePlayer_Graph.Size = new System.Drawing.Size(106, 22);
            this.TSMI_CyclePlayer_Graph.Text = "Graph";
            this.TSMI_CyclePlayer_Graph.Click += new System.EventHandler(this.TSMI_CyclePlayer_GraphClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // TSMI_ResetLayout
            // 
            this.TSMI_ResetLayout.Image = global::CANStream.Icones.Controller_Layout;
            this.TSMI_ResetLayout.Name = "TSMI_ResetLayout";
            this.TSMI_ResetLayout.Size = new System.Drawing.Size(159, 22);
            this.TSMI_ResetLayout.Text = "Reset";
            this.TSMI_ResetLayout.ToolTipText = "Reset layout to default";
            this.TSMI_ResetLayout.Click += new System.EventHandler(this.TSMI_ResetLayoutClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabPg_SpyAndManual);
            this.tabControl1.Controls.Add(this.TabPg_Cycle);
            this.tabControl1.ImageList = this.Img_TabControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 637);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1Deselecting);
            // 
            // TabPg_SpyAndManual
            // 
            this.TabPg_SpyAndManual.BackColor = System.Drawing.SystemColors.Control;
            this.TabPg_SpyAndManual.Controls.Add(this.Split_RxTx);
            this.TabPg_SpyAndManual.Controls.Add(this.groupBox4);
            this.TabPg_SpyAndManual.ImageIndex = 0;
            this.TabPg_SpyAndManual.Location = new System.Drawing.Point(4, 23);
            this.TabPg_SpyAndManual.Name = "TabPg_SpyAndManual";
            this.TabPg_SpyAndManual.Size = new System.Drawing.Size(967, 610);
            this.TabPg_SpyAndManual.TabIndex = 4;
            this.TabPg_SpyAndManual.Tag = "1";
            this.TabPg_SpyAndManual.Text = "Spy & Manual";
            // 
            // Split_RxTx
            // 
            this.Split_RxTx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Split_RxTx.Location = new System.Drawing.Point(0, 72);
            this.Split_RxTx.Name = "Split_RxTx";
            // 
            // Split_RxTx.Panel1
            // 
            this.Split_RxTx.Panel1.Controls.Add(this.Split_Tx_EngRaw);
            // 
            // Split_RxTx.Panel2
            // 
            this.Split_RxTx.Panel2.Controls.Add(this.Split_Rx_DataGraph);
            this.Split_RxTx.Size = new System.Drawing.Size(967, 538);
            this.Split_RxTx.SplitterDistance = 290;
            this.Split_RxTx.TabIndex = 3;
            // 
            // Split_Tx_EngRaw
            // 
            this.Split_Tx_EngRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split_Tx_EngRaw.Location = new System.Drawing.Point(0, 0);
            this.Split_Tx_EngRaw.Name = "Split_Tx_EngRaw";
            this.Split_Tx_EngRaw.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Split_Tx_EngRaw.Panel1
            // 
            this.Split_Tx_EngRaw.Panel1.Controls.Add(this.Grid_CANData);
            this.Split_Tx_EngRaw.Panel1.Controls.Add(this.label2);
            // 
            // Split_Tx_EngRaw.Panel2
            // 
            this.Split_Tx_EngRaw.Panel2.Controls.Add(this.Grid_CANRawData);
            this.Split_Tx_EngRaw.Size = new System.Drawing.Size(290, 538);
            this.Split_Tx_EngRaw.SplitterDistance = 410;
            this.Split_Tx_EngRaw.TabIndex = 0;
            // 
            // Grid_CANData
            // 
            this.Grid_CANData.AllowUserToAddRows = false;
            this.Grid_CANData.AllowUserToDeleteRows = false;
            this.Grid_CANData.AllowUserToResizeColumns = false;
            this.Grid_CANData.AllowUserToResizeRows = false;
            this.Grid_CANData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_CANData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_CANData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.RxTx,
            this.MsgPeriod,
            this.MuxVal,
            this.CANParameter,
            this.StartBit,
            this.ParamLength,
            this.Endianess,
            this.Signed,
            this.LinGain,
            this.LinZero,
            this.DefaultValue,
            this.Unit,
            this.Comment});
            this.Grid_CANData.ContextMenuStrip = this.Context_ManualGrid;
            this.Grid_CANData.Location = new System.Drawing.Point(3, 17);
            this.Grid_CANData.Name = "Grid_CANData";
            this.Grid_CANData.RowHeadersVisible = false;
            this.Grid_CANData.RowHeadersWidth = 40;
            this.Grid_CANData.Size = new System.Drawing.Size(287, 391);
            this.Grid_CANData.TabIndex = 9;
            this.Grid_CANData.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grid_CANData_CellBeginEdit);
            this.Grid_CANData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CANData_CellValueChanged);
            this.Grid_CANData.SizeChanged += new System.EventHandler(this.Grid_CANDataSizeChanged);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.MinimumWidth = 40;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // RxTx
            // 
            this.RxTx.HeaderText = "RxTx";
            this.RxTx.MinimumWidth = 30;
            this.RxTx.Name = "RxTx";
            this.RxTx.ReadOnly = true;
            this.RxTx.Width = 40;
            // 
            // MsgPeriod
            // 
            this.MsgPeriod.HeaderText = "Period";
            this.MsgPeriod.MinimumWidth = 40;
            this.MsgPeriod.Name = "MsgPeriod";
            this.MsgPeriod.ReadOnly = true;
            this.MsgPeriod.Width = 50;
            // 
            // MuxVal
            // 
            this.MuxVal.HeaderText = "Mux value";
            this.MuxVal.MinimumWidth = 20;
            this.MuxVal.Name = "MuxVal";
            this.MuxVal.ReadOnly = true;
            this.MuxVal.Visible = false;
            this.MuxVal.Width = 40;
            // 
            // CANParameter
            // 
            this.CANParameter.HeaderText = "Parameter";
            this.CANParameter.MinimumWidth = 100;
            this.CANParameter.Name = "CANParameter";
            this.CANParameter.ReadOnly = true;
            // 
            // StartBit
            // 
            this.StartBit.HeaderText = "Start";
            this.StartBit.MinimumWidth = 20;
            this.StartBit.Name = "StartBit";
            this.StartBit.ReadOnly = true;
            this.StartBit.Visible = false;
            this.StartBit.Width = 40;
            // 
            // ParamLength
            // 
            this.ParamLength.HeaderText = "Length";
            this.ParamLength.MinimumWidth = 20;
            this.ParamLength.Name = "ParamLength";
            this.ParamLength.ReadOnly = true;
            this.ParamLength.Visible = false;
            this.ParamLength.Width = 50;
            // 
            // Endianess
            // 
            this.Endianess.HeaderText = "Endianess";
            this.Endianess.MinimumWidth = 20;
            this.Endianess.Name = "Endianess";
            this.Endianess.ReadOnly = true;
            this.Endianess.Visible = false;
            this.Endianess.Width = 40;
            // 
            // Signed
            // 
            this.Signed.HeaderText = "Signed";
            this.Signed.MinimumWidth = 20;
            this.Signed.Name = "Signed";
            this.Signed.ReadOnly = true;
            this.Signed.Visible = false;
            this.Signed.Width = 40;
            // 
            // LinGain
            // 
            this.LinGain.HeaderText = "Gain";
            this.LinGain.MinimumWidth = 20;
            this.LinGain.Name = "LinGain";
            this.LinGain.ReadOnly = true;
            this.LinGain.Visible = false;
            this.LinGain.Width = 40;
            // 
            // LinZero
            // 
            this.LinZero.HeaderText = "Zero";
            this.LinZero.MinimumWidth = 20;
            this.LinZero.Name = "LinZero";
            this.LinZero.ReadOnly = true;
            this.LinZero.Visible = false;
            this.LinZero.Width = 40;
            // 
            // DefaultValue
            // 
            this.DefaultValue.HeaderText = "Value";
            this.DefaultValue.MinimumWidth = 80;
            this.DefaultValue.Name = "DefaultValue";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 20;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 40;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 20;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // Context_ManualGrid
            // 
            this.Context_ManualGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideRowToolStripMenuItem,
            this.showHiddenRowsToolStripMenuItem,
            this.FiltertoolStripMenuItem,
            this.toolStripMenuItem9,
            this.ContextManual_columnsToolStripMenuItem});
            this.Context_ManualGrid.Name = "Context_ManualGrid";
            this.Context_ManualGrid.Size = new System.Drawing.Size(174, 98);
            // 
            // hideRowToolStripMenuItem
            // 
            this.hideRowToolStripMenuItem.Image = global::CANStream.Icones.Row_Hide_16;
            this.hideRowToolStripMenuItem.Name = "hideRowToolStripMenuItem";
            this.hideRowToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hideRowToolStripMenuItem.Text = "Hide selected rows";
            this.hideRowToolStripMenuItem.Click += new System.EventHandler(this.HideRowToolStripMenuItemClick);
            // 
            // showHiddenRowsToolStripMenuItem
            // 
            this.showHiddenRowsToolStripMenuItem.Image = global::CANStream.Icones.Row_Show_16;
            this.showHiddenRowsToolStripMenuItem.Name = "showHiddenRowsToolStripMenuItem";
            this.showHiddenRowsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showHiddenRowsToolStripMenuItem.Text = "Show hidden rows";
            this.showHiddenRowsToolStripMenuItem.Click += new System.EventHandler(this.ShowHiddenRowsToolStripMenuItemClick);
            // 
            // FiltertoolStripMenuItem
            // 
            this.FiltertoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualGrid_Filter_Combo_TSMI});
            this.FiltertoolStripMenuItem.Name = "FiltertoolStripMenuItem";
            this.FiltertoolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.FiltertoolStripMenuItem.Text = "Filter";
            // 
            // ManualGrid_Filter_Combo_TSMI
            // 
            this.ManualGrid_Filter_Combo_TSMI.Name = "ManualGrid_Filter_Combo_TSMI";
            this.ManualGrid_Filter_Combo_TSMI.Size = new System.Drawing.Size(121, 23);
            this.ManualGrid_Filter_Combo_TSMI.SelectedIndexChanged += new System.EventHandler(this.ManualGrid_Filter_Combo_TSMISelectedIndexChanged);
            this.ManualGrid_Filter_Combo_TSMI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManualGrid_Filter_Combo_TSMIKeyDown);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(170, 6);
            // 
            // ContextManual_columnsToolStripMenuItem
            // 
            this.ContextManual_columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Context_Manual_showAllToolStripMenuItem,
            this.Context_Manual_hideAllToolStripMenuItem,
            this.toolStripSeparator5,
            this.Context_Manual_iDToolStripMenuItem,
            this.Context_Manual_rxTxToolStripMenuItem,
            this.Context_Manual_periodToolStripMenuItem,
            this.Context_Manual_muxValueToolStripMenuItem,
            this.Context_Manual_startToolStripMenuItem,
            this.Context_Manual_lengthToolStripMenuItem,
            this.Context_Manual_endianessToolStripMenuItem,
            this.Context_Manual_signedToolStripMenuItem,
            this.Context_Manual_gainToolStripMenuItem,
            this.Context_Manual_zeroToolStripMenuItem,
            this.Context_Manual_unitToolStripMenuItem,
            this.Context_Manual_commentToolStripMenuItem});
            this.ContextManual_columnsToolStripMenuItem.Image = global::CANStream.Icones.Columns_16;
            this.ContextManual_columnsToolStripMenuItem.Name = "ContextManual_columnsToolStripMenuItem";
            this.ContextManual_columnsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ContextManual_columnsToolStripMenuItem.Text = "Columns";
            // 
            // Context_Manual_showAllToolStripMenuItem
            // 
            this.Context_Manual_showAllToolStripMenuItem.Name = "Context_Manual_showAllToolStripMenuItem";
            this.Context_Manual_showAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_showAllToolStripMenuItem.Text = "Show All";
            this.Context_Manual_showAllToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_showAllToolStripMenuItemClick);
            // 
            // Context_Manual_hideAllToolStripMenuItem
            // 
            this.Context_Manual_hideAllToolStripMenuItem.Name = "Context_Manual_hideAllToolStripMenuItem";
            this.Context_Manual_hideAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_hideAllToolStripMenuItem.Text = "Hide All";
            this.Context_Manual_hideAllToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_hideAllToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // Context_Manual_iDToolStripMenuItem
            // 
            this.Context_Manual_iDToolStripMenuItem.Name = "Context_Manual_iDToolStripMenuItem";
            this.Context_Manual_iDToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_iDToolStripMenuItem.Text = "ID";
            this.Context_Manual_iDToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_iDToolStripMenuItemClick);
            // 
            // Context_Manual_rxTxToolStripMenuItem
            // 
            this.Context_Manual_rxTxToolStripMenuItem.Name = "Context_Manual_rxTxToolStripMenuItem";
            this.Context_Manual_rxTxToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_rxTxToolStripMenuItem.Text = "RxTx";
            this.Context_Manual_rxTxToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_rxTxToolStripMenuItemClick);
            // 
            // Context_Manual_periodToolStripMenuItem
            // 
            this.Context_Manual_periodToolStripMenuItem.Name = "Context_Manual_periodToolStripMenuItem";
            this.Context_Manual_periodToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_periodToolStripMenuItem.Text = "Period";
            this.Context_Manual_periodToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_periodToolStripMenuItemClick);
            // 
            // Context_Manual_muxValueToolStripMenuItem
            // 
            this.Context_Manual_muxValueToolStripMenuItem.Name = "Context_Manual_muxValueToolStripMenuItem";
            this.Context_Manual_muxValueToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_muxValueToolStripMenuItem.Text = "Mux value";
            this.Context_Manual_muxValueToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_muxValueToolStripMenuItemClick);
            // 
            // Context_Manual_startToolStripMenuItem
            // 
            this.Context_Manual_startToolStripMenuItem.Name = "Context_Manual_startToolStripMenuItem";
            this.Context_Manual_startToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_startToolStripMenuItem.Text = "Start";
            this.Context_Manual_startToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_startToolStripMenuItemClick);
            // 
            // Context_Manual_lengthToolStripMenuItem
            // 
            this.Context_Manual_lengthToolStripMenuItem.Name = "Context_Manual_lengthToolStripMenuItem";
            this.Context_Manual_lengthToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_lengthToolStripMenuItem.Text = "Length";
            this.Context_Manual_lengthToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_lengthToolStripMenuItemClick);
            // 
            // Context_Manual_endianessToolStripMenuItem
            // 
            this.Context_Manual_endianessToolStripMenuItem.Name = "Context_Manual_endianessToolStripMenuItem";
            this.Context_Manual_endianessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_endianessToolStripMenuItem.Text = "Endianess";
            this.Context_Manual_endianessToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_endianessToolStripMenuItemClick);
            // 
            // Context_Manual_signedToolStripMenuItem
            // 
            this.Context_Manual_signedToolStripMenuItem.Name = "Context_Manual_signedToolStripMenuItem";
            this.Context_Manual_signedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_signedToolStripMenuItem.Text = "Signedness";
            this.Context_Manual_signedToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_signedToolStripMenuItemClick);
            // 
            // Context_Manual_gainToolStripMenuItem
            // 
            this.Context_Manual_gainToolStripMenuItem.Name = "Context_Manual_gainToolStripMenuItem";
            this.Context_Manual_gainToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_gainToolStripMenuItem.Text = "Gain";
            this.Context_Manual_gainToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_gainToolStripMenuItemClick);
            // 
            // Context_Manual_zeroToolStripMenuItem
            // 
            this.Context_Manual_zeroToolStripMenuItem.Name = "Context_Manual_zeroToolStripMenuItem";
            this.Context_Manual_zeroToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_zeroToolStripMenuItem.Text = "Zero";
            this.Context_Manual_zeroToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_zeroToolStripMenuItemClick);
            // 
            // Context_Manual_unitToolStripMenuItem
            // 
            this.Context_Manual_unitToolStripMenuItem.Name = "Context_Manual_unitToolStripMenuItem";
            this.Context_Manual_unitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_unitToolStripMenuItem.Text = "Unit";
            this.Context_Manual_unitToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_unitToolStripMenuItemClick);
            // 
            // Context_Manual_commentToolStripMenuItem
            // 
            this.Context_Manual_commentToolStripMenuItem.Name = "Context_Manual_commentToolStripMenuItem";
            this.Context_Manual_commentToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Context_Manual_commentToolStripMenuItem.Text = "Comment";
            this.Context_Manual_commentToolStripMenuItem.Click += new System.EventHandler(this.Context_Manual_commentToolStripMenuItemClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Transmitted";
            // 
            // Grid_CANRawData
            // 
            this.Grid_CANRawData.AllowUserToAddRows = false;
            this.Grid_CANRawData.AllowUserToDeleteRows = false;
            this.Grid_CANRawData.AllowUserToResizeColumns = false;
            this.Grid_CANRawData.AllowUserToResizeRows = false;
            this.Grid_CANRawData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_CANRawData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_CANRawData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridCol_Raw_Tx_Id,
            this.GridCol_Raw_Tx_DLC,
            this.GridCol_Raw_Tx_Period,
            this.GridCol_Raw_Tx_Sent,
            this.GridCol_Raw_Tx_BtnTx,
            this.GridCol_Raw_Tx_B0,
            this.GridCol_Raw_Tx_B1,
            this.GridCol_Raw_Tx_B2,
            this.GridCol_Raw_Tx_B3,
            this.GridCol_Raw_Tx_B4,
            this.GridCol_Raw_Tx_B5,
            this.GridCol_Raw_Tx_B6,
            this.GridCol_Raw_Tx_B7});
            this.Grid_CANRawData.ContextMenuStrip = this.Context_ManualRawGrid;
            this.Grid_CANRawData.Location = new System.Drawing.Point(3, 0);
            this.Grid_CANRawData.Name = "Grid_CANRawData";
            this.Grid_CANRawData.RowHeadersVisible = false;
            this.Grid_CANRawData.RowHeadersWidth = 40;
            this.Grid_CANRawData.Size = new System.Drawing.Size(287, 124);
            this.Grid_CANRawData.TabIndex = 8;
            this.Grid_CANRawData.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grid_CANRawData_CellBeginEdit);
            this.Grid_CANRawData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CANRawDataCellClick);
            this.Grid_CANRawData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CANRawDataCellValueChanged);
            this.Grid_CANRawData.SizeChanged += new System.EventHandler(this.Grid_CANRawDataSizeChanged);
            this.Grid_CANRawData.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Grid_CANRawData_PreviewKeyDown);
            // 
            // GridCol_Raw_Tx_Id
            // 
            this.GridCol_Raw_Tx_Id.HeaderText = "ID";
            this.GridCol_Raw_Tx_Id.MinimumWidth = 40;
            this.GridCol_Raw_Tx_Id.Name = "GridCol_Raw_Tx_Id";
            this.GridCol_Raw_Tx_Id.Width = 50;
            // 
            // GridCol_Raw_Tx_DLC
            // 
            this.GridCol_Raw_Tx_DLC.HeaderText = "DLC";
            this.GridCol_Raw_Tx_DLC.MinimumWidth = 20;
            this.GridCol_Raw_Tx_DLC.Name = "GridCol_Raw_Tx_DLC";
            this.GridCol_Raw_Tx_DLC.Width = 40;
            // 
            // GridCol_Raw_Tx_Period
            // 
            this.GridCol_Raw_Tx_Period.HeaderText = "Period";
            this.GridCol_Raw_Tx_Period.MinimumWidth = 20;
            this.GridCol_Raw_Tx_Period.Name = "GridCol_Raw_Tx_Period";
            this.GridCol_Raw_Tx_Period.Width = 40;
            // 
            // GridCol_Raw_Tx_Sent
            // 
            this.GridCol_Raw_Tx_Sent.HeaderText = "Sent";
            this.GridCol_Raw_Tx_Sent.MinimumWidth = 30;
            this.GridCol_Raw_Tx_Sent.Name = "GridCol_Raw_Tx_Sent";
            this.GridCol_Raw_Tx_Sent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCol_Raw_Tx_Sent.Width = 40;
            // 
            // GridCol_Raw_Tx_BtnTx
            // 
            this.GridCol_Raw_Tx_BtnTx.HeaderText = "Tx";
            this.GridCol_Raw_Tx_BtnTx.Name = "GridCol_Raw_Tx_BtnTx";
            this.GridCol_Raw_Tx_BtnTx.Text = "Tx";
            this.GridCol_Raw_Tx_BtnTx.ToolTipText = "Send frame now";
            // 
            // GridCol_Raw_Tx_B0
            // 
            this.GridCol_Raw_Tx_B0.HeaderText = "B0";
            this.GridCol_Raw_Tx_B0.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B0.Name = "GridCol_Raw_Tx_B0";
            this.GridCol_Raw_Tx_B0.Width = 30;
            // 
            // GridCol_Raw_Tx_B1
            // 
            this.GridCol_Raw_Tx_B1.HeaderText = "B1";
            this.GridCol_Raw_Tx_B1.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B1.Name = "GridCol_Raw_Tx_B1";
            this.GridCol_Raw_Tx_B1.Width = 30;
            // 
            // GridCol_Raw_Tx_B2
            // 
            this.GridCol_Raw_Tx_B2.HeaderText = "B2";
            this.GridCol_Raw_Tx_B2.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B2.Name = "GridCol_Raw_Tx_B2";
            this.GridCol_Raw_Tx_B2.Width = 30;
            // 
            // GridCol_Raw_Tx_B3
            // 
            this.GridCol_Raw_Tx_B3.HeaderText = "B3";
            this.GridCol_Raw_Tx_B3.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B3.Name = "GridCol_Raw_Tx_B3";
            this.GridCol_Raw_Tx_B3.Width = 30;
            // 
            // GridCol_Raw_Tx_B4
            // 
            this.GridCol_Raw_Tx_B4.HeaderText = "B4";
            this.GridCol_Raw_Tx_B4.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B4.Name = "GridCol_Raw_Tx_B4";
            this.GridCol_Raw_Tx_B4.Width = 30;
            // 
            // GridCol_Raw_Tx_B5
            // 
            this.GridCol_Raw_Tx_B5.HeaderText = "B5";
            this.GridCol_Raw_Tx_B5.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B5.Name = "GridCol_Raw_Tx_B5";
            this.GridCol_Raw_Tx_B5.Width = 30;
            // 
            // GridCol_Raw_Tx_B6
            // 
            this.GridCol_Raw_Tx_B6.HeaderText = "B6";
            this.GridCol_Raw_Tx_B6.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B6.Name = "GridCol_Raw_Tx_B6";
            this.GridCol_Raw_Tx_B6.Width = 30;
            // 
            // GridCol_Raw_Tx_B7
            // 
            this.GridCol_Raw_Tx_B7.HeaderText = "B7";
            this.GridCol_Raw_Tx_B7.MinimumWidth = 30;
            this.GridCol_Raw_Tx_B7.Name = "GridCol_Raw_Tx_B7";
            this.GridCol_Raw_Tx_B7.Width = 30;
            // 
            // Context_ManualRawGrid
            // 
            this.Context_ManualRawGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ctxt_TxRaw_Add_TSMI,
            this.Ctxt_TxRaw_Del_TSMI,
            this.Ctxt_TxRaw_Clear_TSMI,
            this.toolStripMenuItem1,
            this.Ctxt_TxRaw_Save_TSMI,
            this.Ctxt_TxRaw_Open_TSMI});
            this.Context_ManualRawGrid.Name = "Context_ManualRawGrid";
            this.Context_ManualRawGrid.Size = new System.Drawing.Size(171, 120);
            // 
            // Ctxt_TxRaw_Add_TSMI
            // 
            this.Ctxt_TxRaw_Add_TSMI.Image = global::CANStream.Icones.Item_Add_16;
            this.Ctxt_TxRaw_Add_TSMI.Name = "Ctxt_TxRaw_Add_TSMI";
            this.Ctxt_TxRaw_Add_TSMI.Size = new System.Drawing.Size(170, 22);
            this.Ctxt_TxRaw_Add_TSMI.Text = "Add message";
            this.Ctxt_TxRaw_Add_TSMI.Click += new System.EventHandler(this.Ctxt_TxRaw_Add_TSMIClick);
            // 
            // Ctxt_TxRaw_Del_TSMI
            // 
            this.Ctxt_TxRaw_Del_TSMI.Image = global::CANStream.Icones.Item_Del_16;
            this.Ctxt_TxRaw_Del_TSMI.Name = "Ctxt_TxRaw_Del_TSMI";
            this.Ctxt_TxRaw_Del_TSMI.Size = new System.Drawing.Size(170, 22);
            this.Ctxt_TxRaw_Del_TSMI.Text = "Del message";
            this.Ctxt_TxRaw_Del_TSMI.Click += new System.EventHandler(this.Ctxt_TxRaw_Del_TSMIClick);
            // 
            // Ctxt_TxRaw_Clear_TSMI
            // 
            this.Ctxt_TxRaw_Clear_TSMI.Image = global::CANStream.Icones.Item_Clear_16;
            this.Ctxt_TxRaw_Clear_TSMI.Name = "Ctxt_TxRaw_Clear_TSMI";
            this.Ctxt_TxRaw_Clear_TSMI.Size = new System.Drawing.Size(170, 22);
            this.Ctxt_TxRaw_Clear_TSMI.Text = "Clear messages";
            this.Ctxt_TxRaw_Clear_TSMI.Click += new System.EventHandler(this.Ctxt_TxRaw_Clear_TSMIClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // Ctxt_TxRaw_Save_TSMI
            // 
            this.Ctxt_TxRaw_Save_TSMI.Image = global::CANStream.Icones.File_Save_16;
            this.Ctxt_TxRaw_Save_TSMI.Name = "Ctxt_TxRaw_Save_TSMI";
            this.Ctxt_TxRaw_Save_TSMI.Size = new System.Drawing.Size(170, 22);
            this.Ctxt_TxRaw_Save_TSMI.Text = "Save message list";
            this.Ctxt_TxRaw_Save_TSMI.Click += new System.EventHandler(this.Ctxt_TxRaw_Save_TSMIClick);
            // 
            // Ctxt_TxRaw_Open_TSMI
            // 
            this.Ctxt_TxRaw_Open_TSMI.Image = global::CANStream.Icones.File_Open_16;
            this.Ctxt_TxRaw_Open_TSMI.Name = "Ctxt_TxRaw_Open_TSMI";
            this.Ctxt_TxRaw_Open_TSMI.Size = new System.Drawing.Size(170, 22);
            this.Ctxt_TxRaw_Open_TSMI.Text = "Open message list";
            this.Ctxt_TxRaw_Open_TSMI.Click += new System.EventHandler(this.Ctxt_TxRaw_Open_TSMIClick);
            // 
            // Split_Rx_DataGraph
            // 
            this.Split_Rx_DataGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split_Rx_DataGraph.Location = new System.Drawing.Point(0, 0);
            this.Split_Rx_DataGraph.Name = "Split_Rx_DataGraph";
            this.Split_Rx_DataGraph.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Split_Rx_DataGraph.Panel1
            // 
            this.Split_Rx_DataGraph.Panel1.Controls.Add(this.Manual_SpyDataViewer);
            // 
            // Split_Rx_DataGraph.Panel2
            // 
            this.Split_Rx_DataGraph.Panel2.Controls.Add(this.Tab_SpyHistory);
            this.Split_Rx_DataGraph.Size = new System.Drawing.Size(673, 538);
            this.Split_Rx_DataGraph.SplitterDistance = 276;
            this.Split_Rx_DataGraph.TabIndex = 0;
            // 
            // Manual_SpyDataViewer
            // 
            this.Manual_SpyDataViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Manual_SpyDataViewer.EngDataGridVisible = true;
            this.Manual_SpyDataViewer.EngineeringGridColumnsVisible = CANStream.SpyEngineering_Grid_Columns.Default;
            this.Manual_SpyDataViewer.GridOrientation = System.Windows.Forms.Orientation.Vertical;
            this.Manual_SpyDataViewer.GridSplitterDistance = 0;
            this.Manual_SpyDataViewer.Location = new System.Drawing.Point(2, 0);
            this.Manual_SpyDataViewer.Name = "Manual_SpyDataViewer";
            this.Manual_SpyDataViewer.RawDataGridVisible = true;
            this.Manual_SpyDataViewer.RawGridColumnsVisible = CANStream.SpyRaw_Grid_Columns.Default;
            this.Manual_SpyDataViewer.Size = new System.Drawing.Size(668, 276);
            this.Manual_SpyDataViewer.TabIndex = 0;
            this.Manual_SpyDataViewer.RawGridColumnsVisibleChanged += new System.EventHandler<CANStream.RawGridColVisibleChangedEventArgs>(this.Manual_SpyDataViewerRawGridColumnsVisibleChanged);
            this.Manual_SpyDataViewer.EngGridColumnsVisibleChanged += new System.EventHandler<CANStream.EngGridColVisibleChangedEventArgs>(this.Manual_SpyDataViewerEngGridColumnsVisibleChanged);
            // 
            // Tab_SpyHistory
            // 
            this.Tab_SpyHistory.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.Tab_SpyHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_SpyHistory.Controls.Add(this.Tab_SpyHistory_Graph);
            this.Tab_SpyHistory.Controls.Add(this.Tab_SpyHistory_Data);
            this.Tab_SpyHistory.Location = new System.Drawing.Point(2, 3);
            this.Tab_SpyHistory.Multiline = true;
            this.Tab_SpyHistory.Name = "Tab_SpyHistory";
            this.Tab_SpyHistory.SelectedIndex = 0;
            this.Tab_SpyHistory.Size = new System.Drawing.Size(671, 256);
            this.Tab_SpyHistory.TabIndex = 10;
            // 
            // Tab_SpyHistory_Graph
            // 
            this.Tab_SpyHistory_Graph.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_SpyHistory_Graph.Controls.Add(this.Graph_Spy);
            this.Tab_SpyHistory_Graph.Controls.Add(this.Cmd_GraphSpyRec);
            this.Tab_SpyHistory_Graph.Controls.Add(this.ChkLst_ChannelSel);
            this.Tab_SpyHistory_Graph.Controls.Add(this.Cmd_GraphSpyPause);
            this.Tab_SpyHistory_Graph.Controls.Add(this.Grp_GraphProperties);
            this.Tab_SpyHistory_Graph.Location = new System.Drawing.Point(4, 4);
            this.Tab_SpyHistory_Graph.Name = "Tab_SpyHistory_Graph";
            this.Tab_SpyHistory_Graph.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SpyHistory_Graph.Size = new System.Drawing.Size(644, 248);
            this.Tab_SpyHistory_Graph.TabIndex = 0;
            this.Tab_SpyHistory_Graph.Tag = "Graph";
            this.Tab_SpyHistory_Graph.Text = "Graphic";
            // 
            // Graph_Spy
            // 
            this.Graph_Spy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph_Spy.ChartSizeMode = ChartDirector.WinChartSizeMode.StretchImage;
            this.Graph_Spy.Location = new System.Drawing.Point(164, 0);
            this.Graph_Spy.Name = "Graph_Spy";
            this.Graph_Spy.Size = new System.Drawing.Size(477, 245);
            this.Graph_Spy.TabIndex = 3;
            this.Graph_Spy.TabStop = false;
            this.Graph_Spy.Visible = false;
            // 
            // Cmd_GraphSpyRec
            // 
            this.Cmd_GraphSpyRec.ImageIndex = 0;
            this.Cmd_GraphSpyRec.ImageList = this.Img_Cmd_GraphSpyRec;
            this.Cmd_GraphSpyRec.Location = new System.Drawing.Point(95, 0);
            this.Cmd_GraphSpyRec.Name = "Cmd_GraphSpyRec";
            this.Cmd_GraphSpyRec.Size = new System.Drawing.Size(32, 32);
            this.Cmd_GraphSpyRec.TabIndex = 9;
            this.Cmd_GraphSpyRec.UseVisualStyleBackColor = true;
            this.Cmd_GraphSpyRec.Visible = false;
            this.Cmd_GraphSpyRec.Click += new System.EventHandler(this.Cmd_GraphSpyRecClick);
            // 
            // Img_Cmd_GraphSpyRec
            // 
            this.Img_Cmd_GraphSpyRec.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_Cmd_GraphSpyRec.ImageStream")));
            this.Img_Cmd_GraphSpyRec.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_Cmd_GraphSpyRec.Images.SetKeyName(0, "stop-icone-5072-16.png");
            this.Img_Cmd_GraphSpyRec.Images.SetKeyName(1, "media-recorder-icone-9075-16.png");
            // 
            // ChkLst_ChannelSel
            // 
            this.ChkLst_ChannelSel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkLst_ChannelSel.ContextMenuStrip = this.Context_SpyGraphChannels;
            this.ChkLst_ChannelSel.FormattingEnabled = true;
            this.ChkLst_ChannelSel.Location = new System.Drawing.Point(6, 39);
            this.ChkLst_ChannelSel.Name = "ChkLst_ChannelSel";
            this.ChkLst_ChannelSel.Size = new System.Drawing.Size(152, 79);
            this.ChkLst_ChannelSel.TabIndex = 5;
            this.ChkLst_ChannelSel.Visible = false;
            this.ChkLst_ChannelSel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkLst_ChannelSelItemCheck);
            // 
            // Context_SpyGraphChannels
            // 
            this.Context_SpyGraphChannels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem,
            this.Context_SpyGraph_Filter_TSMI});
            this.Context_SpyGraphChannels.Name = "Context_SpyGraphChannels";
            this.Context_SpyGraphChannels.Size = new System.Drawing.Size(136, 70);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.checkAllToolStripMenuItem.Text = "Check all";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.CheckAllToolStripMenuItemClick);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck all";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.UncheckAllToolStripMenuItemClick);
            // 
            // Context_SpyGraph_Filter_TSMI
            // 
            this.Context_SpyGraph_Filter_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Context_SpyGraph_Filter_TSCmb});
            this.Context_SpyGraph_Filter_TSMI.Name = "Context_SpyGraph_Filter_TSMI";
            this.Context_SpyGraph_Filter_TSMI.Size = new System.Drawing.Size(135, 22);
            this.Context_SpyGraph_Filter_TSMI.Text = "Filter";
            // 
            // Context_SpyGraph_Filter_TSCmb
            // 
            this.Context_SpyGraph_Filter_TSCmb.Name = "Context_SpyGraph_Filter_TSCmb";
            this.Context_SpyGraph_Filter_TSCmb.Size = new System.Drawing.Size(121, 23);
            this.Context_SpyGraph_Filter_TSCmb.SelectedIndexChanged += new System.EventHandler(this.Context_SpyGraph_Filter_TSCmbSelectedIndexChanged);
            this.Context_SpyGraph_Filter_TSCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Context_SpyGraph_Filter_TSCmbKeyDown);
            // 
            // Cmd_GraphSpyPause
            // 
            this.Cmd_GraphSpyPause.ImageIndex = 0;
            this.Cmd_GraphSpyPause.ImageList = this.Img_Cmd_GraphSpyPause;
            this.Cmd_GraphSpyPause.Location = new System.Drawing.Point(126, 0);
            this.Cmd_GraphSpyPause.Name = "Cmd_GraphSpyPause";
            this.Cmd_GraphSpyPause.Size = new System.Drawing.Size(32, 32);
            this.Cmd_GraphSpyPause.TabIndex = 8;
            this.Cmd_GraphSpyPause.UseVisualStyleBackColor = true;
            this.Cmd_GraphSpyPause.Visible = false;
            this.Cmd_GraphSpyPause.Click += new System.EventHandler(this.Cmd_GraphSpyPauseClick);
            // 
            // Img_Cmd_GraphSpyPause
            // 
            this.Img_Cmd_GraphSpyPause.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_Cmd_GraphSpyPause.ImageStream")));
            this.Img_Cmd_GraphSpyPause.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_Cmd_GraphSpyPause.Images.SetKeyName(0, "break-icone-9058-16.png");
            this.Img_Cmd_GraphSpyPause.Images.SetKeyName(1, "play-icone-6427-16.png");
            // 
            // Grp_GraphProperties
            // 
            this.Grp_GraphProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Grp_GraphProperties.Controls.Add(this.Txt_SpyGraphTimeWindow);
            this.Grp_GraphProperties.Controls.Add(this.label11);
            this.Grp_GraphProperties.Controls.Add(this.Txt_SpyGraphYMax);
            this.Grp_GraphProperties.Controls.Add(this.Txt_SpyGraphYMin);
            this.Grp_GraphProperties.Controls.Add(this.Chk_SpyGraphAutoScale);
            this.Grp_GraphProperties.Controls.Add(this.label10);
            this.Grp_GraphProperties.Controls.Add(this.label9);
            this.Grp_GraphProperties.Location = new System.Drawing.Point(6, 125);
            this.Grp_GraphProperties.Name = "Grp_GraphProperties";
            this.Grp_GraphProperties.Size = new System.Drawing.Size(152, 120);
            this.Grp_GraphProperties.TabIndex = 4;
            this.Grp_GraphProperties.TabStop = false;
            this.Grp_GraphProperties.Text = "Graphic properties";
            this.Grp_GraphProperties.Visible = false;
            // 
            // Txt_SpyGraphTimeWindow
            // 
            this.Txt_SpyGraphTimeWindow.Location = new System.Drawing.Point(78, 19);
            this.Txt_SpyGraphTimeWindow.Name = "Txt_SpyGraphTimeWindow";
            this.Txt_SpyGraphTimeWindow.Size = new System.Drawing.Size(56, 20);
            this.Txt_SpyGraphTimeWindow.TabIndex = 6;
            this.Txt_SpyGraphTimeWindow.Text = "30";
            this.Txt_SpyGraphTimeWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_SpyGraphTimeWindow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SpyGraphTimeWindowKeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Time window";
            // 
            // Txt_SpyGraphYMax
            // 
            this.Txt_SpyGraphYMax.Enabled = false;
            this.Txt_SpyGraphYMax.Location = new System.Drawing.Point(78, 71);
            this.Txt_SpyGraphYMax.Name = "Txt_SpyGraphYMax";
            this.Txt_SpyGraphYMax.Size = new System.Drawing.Size(56, 20);
            this.Txt_SpyGraphYMax.TabIndex = 4;
            this.Txt_SpyGraphYMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_SpyGraphYMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SpyGraphYMaxKeyDown);
            // 
            // Txt_SpyGraphYMin
            // 
            this.Txt_SpyGraphYMin.Enabled = false;
            this.Txt_SpyGraphYMin.Location = new System.Drawing.Point(78, 45);
            this.Txt_SpyGraphYMin.Name = "Txt_SpyGraphYMin";
            this.Txt_SpyGraphYMin.Size = new System.Drawing.Size(56, 20);
            this.Txt_SpyGraphYMin.TabIndex = 3;
            this.Txt_SpyGraphYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_SpyGraphYMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SpyGraphYMinKeyDown);
            // 
            // Chk_SpyGraphAutoScale
            // 
            this.Chk_SpyGraphAutoScale.Checked = true;
            this.Chk_SpyGraphAutoScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_SpyGraphAutoScale.Location = new System.Drawing.Point(6, 99);
            this.Chk_SpyGraphAutoScale.Name = "Chk_SpyGraphAutoScale";
            this.Chk_SpyGraphAutoScale.Size = new System.Drawing.Size(76, 15);
            this.Chk_SpyGraphAutoScale.TabIndex = 2;
            this.Chk_SpyGraphAutoScale.Text = "Auto scale";
            this.Chk_SpyGraphAutoScale.UseVisualStyleBackColor = true;
            this.Chk_SpyGraphAutoScale.CheckedChanged += new System.EventHandler(this.Chk_SpyGraphAutoScaleCheckedChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Y Max";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y Min";
            // 
            // Tab_SpyHistory_Data
            // 
            this.Tab_SpyHistory_Data.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_SpyHistory_Data.Controls.Add(this.Lst_SpyDataHistory);
            this.Tab_SpyHistory_Data.Controls.Add(this.TS_SpyDataHistory);
            this.Tab_SpyHistory_Data.Location = new System.Drawing.Point(4, 4);
            this.Tab_SpyHistory_Data.Name = "Tab_SpyHistory_Data";
            this.Tab_SpyHistory_Data.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SpyHistory_Data.Size = new System.Drawing.Size(644, 248);
            this.Tab_SpyHistory_Data.TabIndex = 1;
            this.Tab_SpyHistory_Data.Tag = "Data";
            this.Tab_SpyHistory_Data.Text = "Data";
            // 
            // Lst_SpyDataHistory
            // 
            this.Lst_SpyDataHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lst_SpyDataHistory.FormattingEnabled = true;
            this.Lst_SpyDataHistory.Location = new System.Drawing.Point(3, 31);
            this.Lst_SpyDataHistory.Name = "Lst_SpyDataHistory";
            this.Lst_SpyDataHistory.Size = new System.Drawing.Size(638, 212);
            this.Lst_SpyDataHistory.TabIndex = 1;
            // 
            // TS_SpyDataHistory
            // 
            this.TS_SpyDataHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_FreezeHistory,
            this.TSB_ResumeHistory,
            this.TSB_ClearHistory,
            this.TSB_ExportHistory,
            this.toolStripSeparator3,
            this.TSLbl_IdFilterFrom,
            this.TSTxt_IdFilterFrom,
            this.TSLbl_IdFilterTo,
            this.TSTxt_IdFilterTo});
            this.TS_SpyDataHistory.Location = new System.Drawing.Point(3, 3);
            this.TS_SpyDataHistory.Name = "TS_SpyDataHistory";
            this.TS_SpyDataHistory.Size = new System.Drawing.Size(638, 25);
            this.TS_SpyDataHistory.TabIndex = 0;
            this.TS_SpyDataHistory.Text = "toolStrip1";
            // 
            // TSB_FreezeHistory
            // 
            this.TSB_FreezeHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_FreezeHistory.Image = global::CANStream.Icones.Pause_16;
            this.TSB_FreezeHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_FreezeHistory.Name = "TSB_FreezeHistory";
            this.TSB_FreezeHistory.Size = new System.Drawing.Size(23, 22);
            this.TSB_FreezeHistory.Text = "toolStripButton1";
            this.TSB_FreezeHistory.ToolTipText = "Freeze";
            this.TSB_FreezeHistory.Click += new System.EventHandler(this.TSB_FreezeHistory_Click);
            // 
            // TSB_ResumeHistory
            // 
            this.TSB_ResumeHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_ResumeHistory.Image = global::CANStream.Icones.Play_16;
            this.TSB_ResumeHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ResumeHistory.Name = "TSB_ResumeHistory";
            this.TSB_ResumeHistory.Size = new System.Drawing.Size(23, 22);
            this.TSB_ResumeHistory.Text = "toolStripButton2";
            this.TSB_ResumeHistory.ToolTipText = "Resume";
            this.TSB_ResumeHistory.Visible = false;
            this.TSB_ResumeHistory.Click += new System.EventHandler(this.TSB_ResumeHistory_Click);
            // 
            // TSB_ClearHistory
            // 
            this.TSB_ClearHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_ClearHistory.Image = global::CANStream.Icones.Delete_16;
            this.TSB_ClearHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ClearHistory.Name = "TSB_ClearHistory";
            this.TSB_ClearHistory.Size = new System.Drawing.Size(23, 22);
            this.TSB_ClearHistory.Text = "toolStripButton3";
            this.TSB_ClearHistory.ToolTipText = "Clear history";
            this.TSB_ClearHistory.Click += new System.EventHandler(this.TSB_ClearHistory_Click);
            // 
            // TSB_ExportHistory
            // 
            this.TSB_ExportHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_ExportHistory.Image = global::CANStream.Icones.Export_File_16;
            this.TSB_ExportHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ExportHistory.Name = "TSB_ExportHistory";
            this.TSB_ExportHistory.Size = new System.Drawing.Size(23, 22);
            this.TSB_ExportHistory.Text = "toolStripButton4";
            this.TSB_ExportHistory.ToolTipText = "Export history";
            this.TSB_ExportHistory.Click += new System.EventHandler(this.TSB_ExportHistory_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TSLbl_IdFilterFrom
            // 
            this.TSLbl_IdFilterFrom.Name = "TSLbl_IdFilterFrom";
            this.TSLbl_IdFilterFrom.Size = new System.Drawing.Size(106, 22);
            this.TSLbl_IdFilterFrom.Text = "CAN Id filter: From";
            // 
            // TSTxt_IdFilterFrom
            // 
            this.TSTxt_IdFilterFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSTxt_IdFilterFrom.Name = "TSTxt_IdFilterFrom";
            this.TSTxt_IdFilterFrom.Size = new System.Drawing.Size(50, 25);
            this.TSTxt_IdFilterFrom.Text = "000";
            this.TSTxt_IdFilterFrom.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TSTxt_IdFilterFrom.TextChanged += new System.EventHandler(this.TSTxt_IdFilterFrom_TextChanged);
            // 
            // TSLbl_IdFilterTo
            // 
            this.TSLbl_IdFilterTo.Name = "TSLbl_IdFilterTo";
            this.TSLbl_IdFilterTo.Size = new System.Drawing.Size(20, 22);
            this.TSLbl_IdFilterTo.Text = "To";
            // 
            // TSTxt_IdFilterTo
            // 
            this.TSTxt_IdFilterTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSTxt_IdFilterTo.Name = "TSTxt_IdFilterTo";
            this.TSTxt_IdFilterTo.Size = new System.Drawing.Size(50, 25);
            this.TSTxt_IdFilterTo.Text = "7FF";
            this.TSTxt_IdFilterTo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TSTxt_IdFilterTo.TextChanged += new System.EventHandler(this.TSTxt_IdFilterTo_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Chk_VirtualParamTxEnabled);
            this.groupBox4.Controls.Add(this.Chk_CycleMux);
            this.groupBox4.Controls.Add(this.Lbl_MsgCounter);
            this.groupBox4.Controls.Add(this.Txt_MsgCounter);
            this.groupBox4.Controls.Add(this.Cmb_SpyCANRate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Txt_SpyIdFilterMax);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Txt_SpyIdFilterMin);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Cmb_SpyCANRxMode);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Cmd_StopSpy);
            this.groupBox4.Controls.Add(this.Cmd_StartSpy);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(961, 65);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // Chk_VirtualParamTxEnabled
            // 
            this.Chk_VirtualParamTxEnabled.Enabled = false;
            this.Chk_VirtualParamTxEnabled.Location = new System.Drawing.Point(451, 36);
            this.Chk_VirtualParamTxEnabled.Name = "Chk_VirtualParamTxEnabled";
            this.Chk_VirtualParamTxEnabled.Size = new System.Drawing.Size(128, 22);
            this.Chk_VirtualParamTxEnabled.TabIndex = 21;
            this.Chk_VirtualParamTxEnabled.Text = "Virtual parameters Tx";
            this.Chk_VirtualParamTxEnabled.UseVisualStyleBackColor = true;
            this.Chk_VirtualParamTxEnabled.CheckedChanged += new System.EventHandler(this.Chk_VirtualParamTxEnabledCheckedChanged);
            // 
            // Chk_CycleMux
            // 
            this.Chk_CycleMux.Enabled = false;
            this.Chk_CycleMux.Location = new System.Drawing.Point(451, 14);
            this.Chk_CycleMux.Name = "Chk_CycleMux";
            this.Chk_CycleMux.Size = new System.Drawing.Size(112, 22);
            this.Chk_CycleMux.TabIndex = 20;
            this.Chk_CycleMux.Text = "Cycle Multiplexers";
            this.Chk_CycleMux.UseVisualStyleBackColor = true;
            // 
            // Lbl_MsgCounter
            // 
            this.Lbl_MsgCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_MsgCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MsgCounter.Location = new System.Drawing.Point(716, 30);
            this.Lbl_MsgCounter.Name = "Lbl_MsgCounter";
            this.Lbl_MsgCounter.Size = new System.Drawing.Size(121, 22);
            this.Lbl_MsgCounter.TabIndex = 19;
            this.Lbl_MsgCounter.Text = "Sent messages";
            this.Lbl_MsgCounter.Visible = false;
            // 
            // Txt_MsgCounter
            // 
            this.Txt_MsgCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MsgCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MsgCounter.Location = new System.Drawing.Point(843, 24);
            this.Txt_MsgCounter.Name = "Txt_MsgCounter";
            this.Txt_MsgCounter.ReadOnly = true;
            this.Txt_MsgCounter.Size = new System.Drawing.Size(112, 29);
            this.Txt_MsgCounter.TabIndex = 18;
            this.Txt_MsgCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_MsgCounter.Visible = false;
            // 
            // Cmb_SpyCANRate
            // 
            this.Cmb_SpyCANRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SpyCANRate.FormattingEnabled = true;
            this.Cmb_SpyCANRate.Items.AddRange(new object[] {
            "500 kBit/s",
            "1000 kBit/s"});
            this.Cmb_SpyCANRate.Location = new System.Drawing.Point(108, 32);
            this.Cmb_SpyCANRate.Name = "Cmb_SpyCANRate";
            this.Cmb_SpyCANRate.Size = new System.Drawing.Size(80, 21);
            this.Cmb_SpyCANRate.TabIndex = 17;
            this.Cmb_SpyCANRate.SelectedIndexChanged += new System.EventHandler(this.Cmb_SpyCANRateSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(108, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "CAN Rate";
            // 
            // Txt_SpyIdFilterMax
            // 
            this.Txt_SpyIdFilterMax.Location = new System.Drawing.Point(396, 32);
            this.Txt_SpyIdFilterMax.Name = "Txt_SpyIdFilterMax";
            this.Txt_SpyIdFilterMax.Size = new System.Drawing.Size(40, 20);
            this.Txt_SpyIdFilterMax.TabIndex = 15;
            this.Txt_SpyIdFilterMax.Text = "7FF";
            this.Txt_SpyIdFilterMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(370, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(288, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "From";
            // 
            // Txt_SpyIdFilterMin
            // 
            this.Txt_SpyIdFilterMin.Location = new System.Drawing.Point(324, 32);
            this.Txt_SpyIdFilterMin.Name = "Txt_SpyIdFilterMin";
            this.Txt_SpyIdFilterMin.Size = new System.Drawing.Size(40, 20);
            this.Txt_SpyIdFilterMin.TabIndex = 12;
            this.Txt_SpyIdFilterMin.Text = "000";
            this.Txt_SpyIdFilterMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(335, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "CAN Id filter (hex)";
            // 
            // Cmb_SpyCANRxMode
            // 
            this.Cmb_SpyCANRxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SpyCANRxMode.FormattingEnabled = true;
            this.Cmb_SpyCANRxMode.Location = new System.Drawing.Point(198, 32);
            this.Cmb_SpyCANRxMode.Name = "Cmb_SpyCANRxMode";
            this.Cmb_SpyCANRxMode.Size = new System.Drawing.Size(80, 21);
            this.Cmb_SpyCANRxMode.TabIndex = 9;
            this.Cmb_SpyCANRxMode.SelectedIndexChanged += new System.EventHandler(this.Cmb_SpyCANRxModeSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(198, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CAN Rx mode";
            // 
            // Cmd_StopSpy
            // 
            this.Cmd_StopSpy.Enabled = false;
            this.Cmd_StopSpy.Image = global::CANStream.Icones.Stop_32;
            this.Cmd_StopSpy.Location = new System.Drawing.Point(57, 14);
            this.Cmd_StopSpy.Name = "Cmd_StopSpy";
            this.Cmd_StopSpy.Size = new System.Drawing.Size(45, 45);
            this.Cmd_StopSpy.TabIndex = 1;
            this.Cmd_StopSpy.UseVisualStyleBackColor = true;
            this.Cmd_StopSpy.Click += new System.EventHandler(this.Cmd_StopSpyClick);
            // 
            // Cmd_StartSpy
            // 
            this.Cmd_StartSpy.Enabled = false;
            this.Cmd_StartSpy.Image = global::CANStream.Icones.Play_32;
            this.Cmd_StartSpy.Location = new System.Drawing.Point(6, 14);
            this.Cmd_StartSpy.Name = "Cmd_StartSpy";
            this.Cmd_StartSpy.Size = new System.Drawing.Size(45, 45);
            this.Cmd_StartSpy.TabIndex = 0;
            this.Cmd_StartSpy.UseVisualStyleBackColor = true;
            this.Cmd_StartSpy.Click += new System.EventHandler(this.Cmd_StartSpyClick);
            // 
            // TabPg_Cycle
            // 
            this.TabPg_Cycle.BackColor = System.Drawing.SystemColors.Control;
            this.TabPg_Cycle.Controls.Add(this.Panel_Cycle);
            this.TabPg_Cycle.Controls.Add(this.groupBox2);
            this.TabPg_Cycle.Controls.Add(this.groupBox1);
            this.TabPg_Cycle.ImageIndex = 1;
            this.TabPg_Cycle.Location = new System.Drawing.Point(4, 23);
            this.TabPg_Cycle.Name = "TabPg_Cycle";
            this.TabPg_Cycle.Padding = new System.Windows.Forms.Padding(3);
            this.TabPg_Cycle.Size = new System.Drawing.Size(967, 610);
            this.TabPg_Cycle.TabIndex = 0;
            this.TabPg_Cycle.Tag = "2";
            this.TabPg_Cycle.Text = "Cycle";
            // 
            // Panel_Cycle
            // 
            this.Panel_Cycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Cycle.Controls.Add(this.Split_Cycle_VirtualSig_Graph);
            this.Panel_Cycle.Location = new System.Drawing.Point(6, 82);
            this.Panel_Cycle.Name = "Panel_Cycle";
            this.Panel_Cycle.Size = new System.Drawing.Size(961, 439);
            this.Panel_Cycle.TabIndex = 3;
            // 
            // Split_Cycle_VirtualSig_Graph
            // 
            this.Split_Cycle_VirtualSig_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split_Cycle_VirtualSig_Graph.Location = new System.Drawing.Point(0, 0);
            this.Split_Cycle_VirtualSig_Graph.Name = "Split_Cycle_VirtualSig_Graph";
            // 
            // Split_Cycle_VirtualSig_Graph.Panel1
            // 
            this.Split_Cycle_VirtualSig_Graph.Panel1.Controls.Add(this.Cycle_SpyDataViewer);
            // 
            // Split_Cycle_VirtualSig_Graph.Panel2
            // 
            this.Split_Cycle_VirtualSig_Graph.Panel2.Controls.Add(this.Graph_Cycle);
            this.Split_Cycle_VirtualSig_Graph.Size = new System.Drawing.Size(961, 439);
            this.Split_Cycle_VirtualSig_Graph.SplitterDistance = 302;
            this.Split_Cycle_VirtualSig_Graph.TabIndex = 0;
            this.Split_Cycle_VirtualSig_Graph.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.Split_Cycle_VirtualSig_GraphSplitterMoved);
            // 
            // Cycle_SpyDataViewer
            // 
            this.Cycle_SpyDataViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cycle_SpyDataViewer.EngDataGridVisible = true;
            this.Cycle_SpyDataViewer.EngineeringGridColumnsVisible = CANStream.SpyEngineering_Grid_Columns.Default;
            this.Cycle_SpyDataViewer.GridOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.Cycle_SpyDataViewer.GridSplitterDistance = 432;
            this.Cycle_SpyDataViewer.Location = new System.Drawing.Point(0, 1);
            this.Cycle_SpyDataViewer.Margin = new System.Windows.Forms.Padding(1);
            this.Cycle_SpyDataViewer.Name = "Cycle_SpyDataViewer";
            this.Cycle_SpyDataViewer.RawDataGridVisible = true;
            this.Cycle_SpyDataViewer.RawGridColumnsVisible = CANStream.SpyRaw_Grid_Columns.Default;
            this.Cycle_SpyDataViewer.Size = new System.Drawing.Size(301, 437);
            this.Cycle_SpyDataViewer.TabIndex = 0;
            this.Cycle_SpyDataViewer.RawGridColumnsVisibleChanged += new System.EventHandler<CANStream.RawGridColVisibleChangedEventArgs>(this.Cycle_SpyDataViewerRawGridColumnsVisibleChanged);
            this.Cycle_SpyDataViewer.EngGridColumnsVisibleChanged += new System.EventHandler<CANStream.EngGridColVisibleChangedEventArgs>(this.Cycle_SpyDataViewerEngGridColumnsVisibleChanged);
            // 
            // Graph_Cycle
            // 
            this.Graph_Cycle.ChartSizeMode = ChartDirector.WinChartSizeMode.StretchImage;
            this.Graph_Cycle.ContextMenuStrip = this.Context_CycleGraph;
            this.Graph_Cycle.Location = new System.Drawing.Point(1, 1);
            this.Graph_Cycle.Margin = new System.Windows.Forms.Padding(1);
            this.Graph_Cycle.Name = "Graph_Cycle";
            this.Graph_Cycle.Size = new System.Drawing.Size(798, 438);
            this.Graph_Cycle.TabIndex = 2;
            this.Graph_Cycle.TabStop = false;
            this.Graph_Cycle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Graph_CycleMouseClick);
            this.Graph_Cycle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Graph_CyclePreviewKeyDown);
            // 
            // Context_CycleGraph
            // 
            this.Context_CycleGraph.Name = "Context_CycleGraph";
            this.Context_CycleGraph.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Chk_CycleVirtualParamTxEnabled);
            this.groupBox2.Controls.Add(this.Txt_CycleEnd);
            this.groupBox2.Controls.Add(this.Txt_CycleStart);
            this.groupBox2.Controls.Add(this.Lbl_CycleEnd);
            this.groupBox2.Controls.Add(this.Lbl_CycleStart);
            this.groupBox2.Controls.Add(this.Chk_InfinitePlay);
            this.groupBox2.Controls.Add(this.Lbl_TotalProgress);
            this.groupBox2.Controls.Add(this.Txt_CurrentCycleNum);
            this.groupBox2.Controls.Add(this.Lbl_CurrentCycleNum);
            this.groupBox2.Controls.Add(this.PB_TotalProgress);
            this.groupBox2.Controls.Add(this.PB_CurrentProgress);
            this.groupBox2.Controls.Add(this.Lbl_CurrentProgress);
            this.groupBox2.Controls.Add(this.Lbl_CycleCount);
            this.groupBox2.Controls.Add(this.NumUpDown_CycleCount);
            this.groupBox2.Controls.Add(this.Cmd_StopCycle);
            this.groupBox2.Controls.Add(this.Cmd_BreakCycle);
            this.groupBox2.Controls.Add(this.Cmd_PlayCycle);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cycle control";
            // 
            // Chk_CycleVirtualParamTxEnabled
            // 
            this.Chk_CycleVirtualParamTxEnabled.Enabled = false;
            this.Chk_CycleVirtualParamTxEnabled.Location = new System.Drawing.Point(307, 40);
            this.Chk_CycleVirtualParamTxEnabled.Name = "Chk_CycleVirtualParamTxEnabled";
            this.Chk_CycleVirtualParamTxEnabled.Size = new System.Drawing.Size(129, 22);
            this.Chk_CycleVirtualParamTxEnabled.TabIndex = 22;
            this.Chk_CycleVirtualParamTxEnabled.Text = "Virtual parameters Tx";
            this.Chk_CycleVirtualParamTxEnabled.UseVisualStyleBackColor = true;
            this.Chk_CycleVirtualParamTxEnabled.CheckedChanged += new System.EventHandler(this.Chk_CycleVirtualParamTxEnabledCheckedChanged);
            // 
            // Txt_CycleEnd
            // 
            this.Txt_CycleEnd.Enabled = false;
            this.Txt_CycleEnd.Location = new System.Drawing.Point(473, 43);
            this.Txt_CycleEnd.Name = "Txt_CycleEnd";
            this.Txt_CycleEnd.Size = new System.Drawing.Size(47, 20);
            this.Txt_CycleEnd.TabIndex = 16;
            this.Txt_CycleEnd.TextChanged += new System.EventHandler(this.Txt_CycleEndTextChanged);
            // 
            // Txt_CycleStart
            // 
            this.Txt_CycleStart.Enabled = false;
            this.Txt_CycleStart.Location = new System.Drawing.Point(473, 17);
            this.Txt_CycleStart.Name = "Txt_CycleStart";
            this.Txt_CycleStart.Size = new System.Drawing.Size(47, 20);
            this.Txt_CycleStart.TabIndex = 15;
            this.Txt_CycleStart.TextChanged += new System.EventHandler(this.Txt_CycleStartTextChanged);
            // 
            // Lbl_CycleEnd
            // 
            this.Lbl_CycleEnd.Enabled = false;
            this.Lbl_CycleEnd.Location = new System.Drawing.Point(436, 46);
            this.Lbl_CycleEnd.Name = "Lbl_CycleEnd";
            this.Lbl_CycleEnd.Size = new System.Drawing.Size(31, 15);
            this.Lbl_CycleEnd.TabIndex = 14;
            this.Lbl_CycleEnd.Text = "End";
            // 
            // Lbl_CycleStart
            // 
            this.Lbl_CycleStart.Enabled = false;
            this.Lbl_CycleStart.Location = new System.Drawing.Point(436, 20);
            this.Lbl_CycleStart.Name = "Lbl_CycleStart";
            this.Lbl_CycleStart.Size = new System.Drawing.Size(31, 17);
            this.Lbl_CycleStart.TabIndex = 13;
            this.Lbl_CycleStart.Text = "Start";
            // 
            // Chk_InfinitePlay
            // 
            this.Chk_InfinitePlay.Enabled = false;
            this.Chk_InfinitePlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_InfinitePlay.Location = new System.Drawing.Point(307, 14);
            this.Chk_InfinitePlay.Name = "Chk_InfinitePlay";
            this.Chk_InfinitePlay.Size = new System.Drawing.Size(155, 28);
            this.Chk_InfinitePlay.TabIndex = 11;
            this.Chk_InfinitePlay.Text = "Infinite play";
            this.Chk_InfinitePlay.UseVisualStyleBackColor = true;
            this.Chk_InfinitePlay.CheckedChanged += new System.EventHandler(this.Chk_InfinitePlayCheckedChanged);
            // 
            // Lbl_TotalProgress
            // 
            this.Lbl_TotalProgress.Location = new System.Drawing.Point(707, 39);
            this.Lbl_TotalProgress.Name = "Lbl_TotalProgress";
            this.Lbl_TotalProgress.Size = new System.Drawing.Size(64, 23);
            this.Lbl_TotalProgress.TabIndex = 9;
            this.Lbl_TotalProgress.Text = "Total";
            this.Lbl_TotalProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_TotalProgress.Visible = false;
            // 
            // Txt_CurrentCycleNum
            // 
            this.Txt_CurrentCycleNum.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_CurrentCycleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CurrentCycleNum.Location = new System.Drawing.Point(613, 20);
            this.Txt_CurrentCycleNum.Name = "Txt_CurrentCycleNum";
            this.Txt_CurrentCycleNum.ReadOnly = true;
            this.Txt_CurrentCycleNum.Size = new System.Drawing.Size(88, 44);
            this.Txt_CurrentCycleNum.TabIndex = 8;
            this.Txt_CurrentCycleNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_CurrentCycleNum.Visible = false;
            // 
            // Lbl_CurrentCycleNum
            // 
            this.Lbl_CurrentCycleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CurrentCycleNum.Location = new System.Drawing.Point(526, 19);
            this.Lbl_CurrentCycleNum.Name = "Lbl_CurrentCycleNum";
            this.Lbl_CurrentCycleNum.Size = new System.Drawing.Size(92, 44);
            this.Lbl_CurrentCycleNum.TabIndex = 7;
            this.Lbl_CurrentCycleNum.Text = "Cycle #";
            this.Lbl_CurrentCycleNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_CurrentCycleNum.Visible = false;
            // 
            // PB_TotalProgress
            // 
            this.PB_TotalProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_TotalProgress.Location = new System.Drawing.Point(788, 41);
            this.PB_TotalProgress.Name = "PB_TotalProgress";
            this.PB_TotalProgress.Size = new System.Drawing.Size(161, 23);
            this.PB_TotalProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_TotalProgress.TabIndex = 6;
            this.PB_TotalProgress.Visible = false;
            // 
            // PB_CurrentProgress
            // 
            this.PB_CurrentProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_CurrentProgress.Location = new System.Drawing.Point(788, 16);
            this.PB_CurrentProgress.Name = "PB_CurrentProgress";
            this.PB_CurrentProgress.Size = new System.Drawing.Size(161, 23);
            this.PB_CurrentProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_CurrentProgress.TabIndex = 2;
            this.PB_CurrentProgress.Visible = false;
            // 
            // Lbl_CurrentProgress
            // 
            this.Lbl_CurrentProgress.Location = new System.Drawing.Point(707, 16);
            this.Lbl_CurrentProgress.Name = "Lbl_CurrentProgress";
            this.Lbl_CurrentProgress.Size = new System.Drawing.Size(75, 23);
            this.Lbl_CurrentProgress.TabIndex = 5;
            this.Lbl_CurrentProgress.Text = "Current cycle";
            this.Lbl_CurrentProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_CurrentProgress.Visible = false;
            // 
            // Lbl_CycleCount
            // 
            this.Lbl_CycleCount.Enabled = false;
            this.Lbl_CycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CycleCount.Location = new System.Drawing.Point(159, 20);
            this.Lbl_CycleCount.Name = "Lbl_CycleCount";
            this.Lbl_CycleCount.Size = new System.Drawing.Size(81, 44);
            this.Lbl_CycleCount.TabIndex = 4;
            this.Lbl_CycleCount.Text = "Count";
            this.Lbl_CycleCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumUpDown_CycleCount
            // 
            this.NumUpDown_CycleCount.Enabled = false;
            this.NumUpDown_CycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDown_CycleCount.Location = new System.Drawing.Point(246, 20);
            this.NumUpDown_CycleCount.Name = "NumUpDown_CycleCount";
            this.NumUpDown_CycleCount.Size = new System.Drawing.Size(55, 44);
            this.NumUpDown_CycleCount.TabIndex = 3;
            this.NumUpDown_CycleCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cmd_StopCycle
            // 
            this.Cmd_StopCycle.Enabled = false;
            this.Cmd_StopCycle.Image = global::CANStream.Icones.Stop_32;
            this.Cmd_StopCycle.Location = new System.Drawing.Point(108, 19);
            this.Cmd_StopCycle.Name = "Cmd_StopCycle";
            this.Cmd_StopCycle.Size = new System.Drawing.Size(45, 45);
            this.Cmd_StopCycle.TabIndex = 2;
            this.Cmd_StopCycle.UseVisualStyleBackColor = true;
            this.Cmd_StopCycle.Click += new System.EventHandler(this.Cmd_StopCycleClick);
            // 
            // Cmd_BreakCycle
            // 
            this.Cmd_BreakCycle.Enabled = false;
            this.Cmd_BreakCycle.Image = global::CANStream.Icones.Pause_32;
            this.Cmd_BreakCycle.Location = new System.Drawing.Point(57, 19);
            this.Cmd_BreakCycle.Name = "Cmd_BreakCycle";
            this.Cmd_BreakCycle.Size = new System.Drawing.Size(45, 45);
            this.Cmd_BreakCycle.TabIndex = 1;
            this.Cmd_BreakCycle.UseVisualStyleBackColor = true;
            this.Cmd_BreakCycle.Click += new System.EventHandler(this.Cmd_BreakCycleClick);
            // 
            // Cmd_PlayCycle
            // 
            this.Cmd_PlayCycle.Enabled = false;
            this.Cmd_PlayCycle.Image = global::CANStream.Icones.Play_32;
            this.Cmd_PlayCycle.Location = new System.Drawing.Point(6, 19);
            this.Cmd_PlayCycle.Name = "Cmd_PlayCycle";
            this.Cmd_PlayCycle.Size = new System.Drawing.Size(45, 45);
            this.Cmd_PlayCycle.TabIndex = 0;
            this.Cmd_PlayCycle.UseVisualStyleBackColor = true;
            this.Cmd_PlayCycle.Click += new System.EventHandler(this.Cmd_PlayCycleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rTxt_CycleComments);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbl_CanConfig);
            this.groupBox1.Controls.Add(this.Lbl_CycleFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rTxt_CycleComments
            // 
            this.rTxt_CycleComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxt_CycleComments.BackColor = System.Drawing.SystemColors.Control;
            this.rTxt_CycleComments.Location = new System.Drawing.Point(86, 46);
            this.rTxt_CycleComments.Name = "rTxt_CycleComments";
            this.rTxt_CycleComments.ReadOnly = true;
            this.rTxt_CycleComments.Size = new System.Drawing.Size(863, 33);
            this.rTxt_CycleComments.TabIndex = 3;
            this.rTxt_CycleComments.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comments:";
            // 
            // Lbl_CanConfig
            // 
            this.Lbl_CanConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CanConfig.Location = new System.Drawing.Point(28, 28);
            this.Lbl_CanConfig.Name = "Lbl_CanConfig";
            this.Lbl_CanConfig.Size = new System.Drawing.Size(921, 18);
            this.Lbl_CanConfig.TabIndex = 1;
            this.Lbl_CanConfig.Text = "CAN Configuration:";
            // 
            // Lbl_CycleFile
            // 
            this.Lbl_CycleFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CycleFile.Location = new System.Drawing.Point(28, 12);
            this.Lbl_CycleFile.Name = "Lbl_CycleFile";
            this.Lbl_CycleFile.Size = new System.Drawing.Size(921, 15);
            this.Lbl_CycleFile.TabIndex = 0;
            this.Lbl_CycleFile.Text = "Cycle file:";
            // 
            // Img_TabControl
            // 
            this.Img_TabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_TabControl.ImageStream")));
            this.Img_TabControl.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_TabControl.Images.SetKeyName(0, "personal.png");
            this.Img_TabControl.Images.SetKeyName(1, "windows-movie-maker-icone-8672-16.png");
            // 
            // Timer_CycleGraph
            // 
            this.Timer_CycleGraph.Interval = 50;
            this.Timer_CycleGraph.Tick += new System.EventHandler(this.Timer_CycleGraphTick);
            // 
            // Timer_CheckDevice
            // 
            this.Timer_CheckDevice.Interval = 5000;
            this.Timer_CheckDevice.Tick += new System.EventHandler(this.Timer_CheckDeviceTick);
            // 
            // BGWrk_Cycle
            // 
            this.BGWrk_Cycle.WorkerReportsProgress = true;
            this.BGWrk_Cycle.WorkerSupportsCancellation = true;
            this.BGWrk_Cycle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWrk_CycleDoWork);
            this.BGWrk_Cycle.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWrk_CycleProgressChanged);
            this.BGWrk_Cycle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWrk_CycleRunWorkerCompleted);
            // 
            // BGWrk_Manual
            // 
            this.BGWrk_Manual.WorkerReportsProgress = true;
            this.BGWrk_Manual.WorkerSupportsCancellation = true;
            this.BGWrk_Manual.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWrk_ManualDoWork);
            this.BGWrk_Manual.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWrk_ManualProgressChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BGWrk_Spy
            // 
            this.BGWrk_Spy.WorkerReportsProgress = true;
            this.BGWrk_Spy.WorkerSupportsCancellation = true;
            this.BGWrk_Spy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWrk_SpyDoWork);
            this.BGWrk_Spy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWrk_SpyProgressChanged);
            this.BGWrk_Spy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWrk_SpyRunWorkerCompleted);
            // 
            // Ctrl_CS_CAN_Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CtrlMain_ToolStrip);
            this.Name = "Ctrl_CS_CAN_Bus";
            this.Size = new System.Drawing.Size(978, 665);
            this.CtrlMain_ToolStrip.ResumeLayout(false);
            this.CtrlMain_ToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPg_SpyAndManual.ResumeLayout(false);
            this.Split_RxTx.Panel1.ResumeLayout(false);
            this.Split_RxTx.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split_RxTx)).EndInit();
            this.Split_RxTx.ResumeLayout(false);
            this.Split_Tx_EngRaw.Panel1.ResumeLayout(false);
            this.Split_Tx_EngRaw.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split_Tx_EngRaw)).EndInit();
            this.Split_Tx_EngRaw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CANData)).EndInit();
            this.Context_ManualGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CANRawData)).EndInit();
            this.Context_ManualRawGrid.ResumeLayout(false);
            this.Split_Rx_DataGraph.Panel1.ResumeLayout(false);
            this.Split_Rx_DataGraph.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split_Rx_DataGraph)).EndInit();
            this.Split_Rx_DataGraph.ResumeLayout(false);
            this.Tab_SpyHistory.ResumeLayout(false);
            this.Tab_SpyHistory_Graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Spy)).EndInit();
            this.Context_SpyGraphChannels.ResumeLayout(false);
            this.Grp_GraphProperties.ResumeLayout(false);
            this.Grp_GraphProperties.PerformLayout();
            this.Tab_SpyHistory_Data.ResumeLayout(false);
            this.Tab_SpyHistory_Data.PerformLayout();
            this.TS_SpyDataHistory.ResumeLayout(false);
            this.TS_SpyDataHistory.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabPg_Cycle.ResumeLayout(false);
            this.Panel_Cycle.ResumeLayout(false);
            this.Split_Cycle_VirtualSig_Graph.Panel1.ResumeLayout(false);
            this.Split_Cycle_VirtualSig_Graph.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split_Cycle_VirtualSig_Graph)).EndInit();
            this.Split_Cycle_VirtualSig_Graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Cycle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_CycleCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripComboBox Context_SpyGraph_Filter_TSCmb;
		private System.Windows.Forms.ToolStripMenuItem Context_SpyGraph_Filter_TSMI;
		private System.Windows.Forms.ToolStripComboBox ManualGrid_Filter_Combo_TSMI;
		private System.Windows.Forms.ToolStripMenuItem FiltertoolStripMenuItem;
		private System.Windows.Forms.DataGridViewButtonColumn GridCol_Raw_Tx_BtnTx;
		private System.Windows.Forms.ToolStripMenuItem TSMI_CyclePlayer_Data_Raw;
		private System.Windows.Forms.ToolStripMenuItem TSMI_CyclePlayer_Data_Eng;
		private System.Windows.Forms.ImageList Img_TabControl;
		private System.Windows.Forms.ToolStripMenuItem TSMI_SpyManual;
		private System.Windows.Forms.ToolStripMenuItem TSMI_CyclePlayer_Graph;
		private System.Windows.Forms.ToolStripMenuItem TSMI_CyclePlayer_Data;
		private System.Windows.Forms.ToolStripMenuItem TSMI_CyclePlayer;
		private CANStream.Ctrl_SpyDataViewer Cycle_SpyDataViewer;
		private CANStream.Ctrl_SpyDataViewer Manual_SpyDataViewer;
		private System.Windows.Forms.Panel Panel_Cycle;
		private System.Windows.Forms.SplitContainer Split_Cycle_VirtualSig_Graph;
		private System.Windows.Forms.ToolStripMenuItem TSMI_ResetLayout;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.CheckBox Chk_CycleVirtualParamTxEnabled;
		private System.Windows.Forms.CheckBox Chk_VirtualParamTxEnabled;
		private System.Windows.Forms.ToolStripMenuItem TSMI_RxMsg_Data_Raw;
		private System.Windows.Forms.ToolStripMenuItem TSMI_RxMsg_Data_Eng;
		private System.Windows.Forms.SplitContainer Split_Rx_DataGraph;
		private System.Windows.Forms.SplitContainer Split_Tx_EngRaw;
		private System.Windows.Forms.SplitContainer Split_RxTx;
		private System.Windows.Forms.TabPage TabPg_SpyAndManual;
		private System.Windows.Forms.ToolStripMenuItem TSMI_TxMessages_Raw;
		private System.Windows.Forms.ToolStripMenuItem TSMI_TxMessages_Eng;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_hideAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_showAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_iDToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem Ctxt_TxRaw_Open_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Ctxt_TxRaw_Save_TSMI;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem Ctxt_TxRaw_Clear_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Ctxt_TxRaw_Del_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Ctxt_TxRaw_Add_TSMI;
		private System.Windows.Forms.ContextMenuStrip Context_ManualRawGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B7;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B6;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B5;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B4;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B3;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B2;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B1;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_B0;
		private System.Windows.Forms.DataGridViewCheckBoxColumn GridCol_Raw_Tx_Sent;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_Period;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_DLC;
		private System.Windows.Forms.DataGridViewTextBoxColumn GridCol_Raw_Tx_Id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView Grid_CANRawData;
		private System.Windows.Forms.Button Cmd_GraphSpyPause;
		private System.Windows.Forms.Button Cmd_GraphSpyRec;
		private System.Windows.Forms.CheckedListBox ChkLst_ChannelSel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox Chk_SpyGraphAutoScale;
		private System.Windows.Forms.TextBox Txt_SpyGraphYMin;
		private System.Windows.Forms.TextBox Txt_SpyGraphYMax;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox Txt_SpyGraphTimeWindow;
		private System.Windows.Forms.GroupBox Grp_GraphProperties;
		private ChartDirector.WinChartViewer Graph_Spy;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_signedToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Signed;
		private System.Windows.Forms.ToolStripMenuItem TSMI_RxMessages_Graph;
		private System.Windows.Forms.ToolStripMenuItem TSMI_RxMessages_Data;
		private System.Windows.Forms.ToolStripMenuItem TSMI_RxMessages;
		private System.Windows.Forms.ToolStripMenuItem TSMI_TxMessages;
		private System.Windows.Forms.ToolStripSplitButton TSSB_View;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.CheckBox Chk_CycleMux;
		private System.Windows.Forms.ImageList Img_Cmd_GraphSpyRec;
		private System.Windows.Forms.ImageList Img_Cmd_GraphSpyPause;
		private System.Windows.Forms.ContextMenuStrip Context_CycleGraph;
		private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip Context_SpyGraphChannels;
		private System.ComponentModel.BackgroundWorker BGWrk_Spy;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.ComponentModel.BackgroundWorker BGWrk_Manual;
		private System.ComponentModel.BackgroundWorker BGWrk_Cycle;
		private System.Windows.Forms.Timer Timer_CheckDevice;
		private System.Windows.Forms.Timer Timer_CycleGraph;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_commentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_unitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_zeroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_gainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_endianessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_lengthToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_muxValueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_periodToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Context_Manual_rxTxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ContextManual_columnsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem showHiddenRowsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideRowToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip Context_ManualGrid;
		private System.Windows.Forms.Label Lbl_CycleFile;
		private System.Windows.Forms.Label Lbl_CanConfig;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rTxt_CycleComments;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Cmd_PlayCycle;
		private System.Windows.Forms.Button Cmd_BreakCycle;
		private System.Windows.Forms.Button Cmd_StopCycle;
		private System.Windows.Forms.NumericUpDown NumUpDown_CycleCount;
		private System.Windows.Forms.Label Lbl_CycleCount;
		private System.Windows.Forms.Label Lbl_CurrentProgress;
		private System.Windows.Forms.ProgressBar PB_CurrentProgress;
		private System.Windows.Forms.ProgressBar PB_TotalProgress;
		private System.Windows.Forms.Label Lbl_CurrentCycleNum;
		private System.Windows.Forms.TextBox Txt_CurrentCycleNum;
		private System.Windows.Forms.Label Lbl_TotalProgress;
		private System.Windows.Forms.CheckBox Chk_InfinitePlay;
		private System.Windows.Forms.Label Lbl_CycleStart;
		private System.Windows.Forms.Label Lbl_CycleEnd;
		private System.Windows.Forms.TextBox Txt_CycleStart;
		private System.Windows.Forms.TextBox Txt_CycleEnd;
		private System.Windows.Forms.GroupBox groupBox2;
		private ChartDirector.WinChartViewer Graph_Cycle;
		private System.Windows.Forms.TabPage TabPg_Cycle;
		private System.Windows.Forms.Button Cmd_StartSpy;
		private System.Windows.Forms.Button Cmd_StopSpy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Cmb_SpyCANRxMode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Txt_SpyIdFilterMin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Txt_SpyIdFilterMax;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox Cmb_SpyCANRate;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox Txt_MsgCounter;
		private System.Windows.Forms.Label Lbl_MsgCounter;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn LinZero;
		private System.Windows.Forms.DataGridViewTextBoxColumn LinGain;
		private System.Windows.Forms.DataGridViewTextBoxColumn Endianess;
		private System.Windows.Forms.DataGridViewTextBoxColumn ParamLength;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartBit;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANParameter;
		private System.Windows.Forms.DataGridViewTextBoxColumn MuxVal;
		private System.Windows.Forms.DataGridViewTextBoxColumn MsgPeriod;
		private System.Windows.Forms.DataGridViewTextBoxColumn RxTx;
		private System.Windows.Forms.DataGridView Grid_CANData;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripButton TSB_StopCANTraceRecording;
		private System.Windows.Forms.ToolStripButton TSB_StartCANTraceRecording;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton TSB_CAN_LinkOn;
		private System.Windows.Forms.ToolStripButton TSB_CAN_LinkOff;
		private System.Windows.Forms.ToolStripLabel TS_Lbl_CanSpeed;
		private System.Windows.Forms.ToolStripComboBox TS_Cmb_PCAN_USB_Devices;
		private System.Windows.Forms.ToolStripButton TSB_Refresh_USB_CAN_Device;
		private System.Windows.Forms.ToolStrip CtrlMain_ToolStrip;
        private System.Windows.Forms.TabControl Tab_SpyHistory;
        private System.Windows.Forms.TabPage Tab_SpyHistory_Graph;
        private System.Windows.Forms.TabPage Tab_SpyHistory_Data;
        private System.Windows.Forms.ListBox Lst_SpyDataHistory;
        private System.Windows.Forms.ToolStrip TS_SpyDataHistory;
        private System.Windows.Forms.ToolStripButton TSB_FreezeHistory;
        private System.Windows.Forms.ToolStripButton TSB_ResumeHistory;
        private System.Windows.Forms.ToolStripButton TSB_ClearHistory;
        private System.Windows.Forms.ToolStripButton TSB_ExportHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel TSLbl_IdFilterFrom;
        private System.Windows.Forms.ToolStripTextBox TSTxt_IdFilterFrom;
        private System.Windows.Forms.ToolStripLabel TSLbl_IdFilterTo;
        private System.Windows.Forms.ToolStripTextBox TSTxt_IdFilterTo;
        private System.Windows.Forms.ToolStripButton TSB_RecordSelection;
    }
}
