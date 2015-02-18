﻿namespace ClientcardFB3
{
    partial class EditPreferencesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (clsZipcodes != null)
                {
                    clsZipcodes.Dispose();
                }
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chkBackPack = new System.Windows.Forms.TabPage();
            this.tbcEFAPLeadAgency = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbcAgencyNbr = new System.Windows.Forms.TextBox();
            this.lblAgencyNbr = new System.Windows.Forms.Label();
            this.chkEnableCDBGReporting = new System.Windows.Forms.CheckBox();
            this.tbcFaxNum = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbcCounty = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbcPhysicalAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcPostalAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcEmailAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbcFoodBankName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpFeatures = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpgGeneral = new System.Windows.Forms.TabPage();
            this.chkEnableCA = new System.Windows.Forms.CheckBox();
            this.chkEnableSchSupply = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkEnableFTScale = new System.Windows.Forms.CheckBox();
            this.chkEnableFastTrack = new System.Windows.Forms.CheckBox();
            this.chkFTScaleLbsIncludeTEFAP = new System.Windows.Forms.CheckBox();
            this.chkCaptureSignature = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cboSvcMnuTyp = new System.Windows.Forms.ComboBox();
            this.grpViewGRBy = new System.Windows.Forms.GroupBox();
            this.rdoViewByFullWeek = new System.Windows.Forms.RadioButton();
            this.rdoViewByCalendarWeek = new System.Windows.Forms.RadioButton();
            this.chkEnablePrintClientCard = new System.Windows.Forms.CheckBox();
            this.chkEnableClientReceipt = new System.Windows.Forms.CheckBox();
            this.chkEnableFoodDonations = new System.Windows.Forms.CheckBox();
            this.chkEnableAppointments = new System.Windows.Forms.CheckBox();
            this.chkUseTimeInOutForVols = new System.Windows.Forms.CheckBox();
            this.chkEnableVolunteerHours = new System.Windows.Forms.CheckBox();
            this.chkEnableCashDonations = new System.Windows.Forms.CheckBox();
            this.chkEnableVouchers = new System.Windows.Forms.CheckBox();
            this.chkEnableHomeDeliv = new System.Windows.Forms.CheckBox();
            this.chkAutoGiveService = new System.Windows.Forms.CheckBox();
            this.chkSearchFamilyMember = new System.Windows.Forms.CheckBox();
            this.chkEnableBarcodePrompts = new System.Windows.Forms.CheckBox();
            this.tpgMainForm = new System.Windows.Forms.TabPage();
            this.chkEnableTransportation = new System.Windows.Forms.CheckBox();
            this.chkAllowIntakeEditing = new System.Windows.Forms.CheckBox();
            this.chkEnableClientPhone = new System.Windows.Forms.CheckBox();
            this.chkEnableVerifyId = new System.Windows.Forms.CheckBox();
            this.chkEnableHHUserDefinedFieldsTab = new System.Windows.Forms.CheckBox();
            this.chkEnableHUDIncomeCategory = new System.Windows.Forms.CheckBox();
            this.chkEnableHouseholdIncome = new System.Windows.Forms.CheckBox();
            this.tpgAlerts = new System.Windows.Forms.TabPage();
            this.grpOutofArea = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.nudOoAAlertMonthSvc = new System.Windows.Forms.NumericUpDown();
            this.tbcOoAAlertMinMonthsText = new System.Windows.Forms.TextBox();
            this.nudOoAAlertWeekSvc = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.nudOoAAlertMinimumMonths = new System.Windows.Forms.NumericUpDown();
            this.tbcOoAAlertMonthSvcText = new System.Windows.Forms.TextBox();
            this.tbcOoAAlertMinDaysText = new System.Windows.Forms.TextBox();
            this.tbcOoAAlertWeekSvcText = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.nudOoAAlertMinimumDays = new System.Windows.Forms.NumericUpDown();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.lblAlertMonthSvc = new System.Windows.Forms.Label();
            this.nudAlertMonthSvc = new System.Windows.Forms.NumericUpDown();
            this.tbcAlertMinMonthsText = new System.Windows.Forms.TextBox();
            this.nudAlertWeekSvc = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudAlertMinimumMonths = new System.Windows.Forms.NumericUpDown();
            this.tbcAlertMonthSvcText = new System.Windows.Forms.TextBox();
            this.tbcAlertMinDaysText = new System.Windows.Forms.TextBox();
            this.tbcAlertWeekSvcText = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.nudAlertMinimumDays = new System.Windows.Forms.NumericUpDown();
            this.chkUseLocalOutOfAreaAlerts = new System.Windows.Forms.CheckBox();
            this.grpbxOverRideLevel = new System.Windows.Forms.GroupBox();
            this.rdoOverRideAdmin = new System.Windows.Forms.RadioButton();
            this.rdoOverRideInatkeAdmin = new System.Windows.Forms.RadioButton();
            this.rdoOverRideIntake = new System.Windows.Forms.RadioButton();
            this.chkWarnSvcEachPerson = new System.Windows.Forms.CheckBox();
            this.tpgFoodSvcs = new System.Windows.Forms.TabPage();
            this.chkEnableServiceGroups = new System.Windows.Forms.CheckBox();
            this.chkIncludeLbsOnFoodSvcList = new System.Windows.Forms.CheckBox();
            this.chkCaptureTEFAPSign = new System.Windows.Forms.CheckBox();
            this.chkCSFPShowRoutes = new System.Windows.Forms.CheckBox();
            this.tbcLbsPerCSFPService = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbcCommSigValidFor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkEnableBabyServices = new System.Windows.Forms.CheckBox();
            this.chkEnableFoodService = new System.Windows.Forms.CheckBox();
            this.chkEnableSupplemental = new System.Windows.Forms.CheckBox();
            this.chkEnableTEFAP = new System.Windows.Forms.CheckBox();
            this.chkMustBeACommodityDay = new System.Windows.Forms.CheckBox();
            this.chkEnableCSFPOnNewSvc = new System.Windows.Forms.CheckBox();
            this.chkEnableBackPack = new System.Windows.Forms.CheckBox();
            this.chkEnableCSFP = new System.Windows.Forms.CheckBox();
            this.tpgPoints = new System.Windows.Forms.TabPage();
            this.tbcMaxPointsPerWeek = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbcPointsPerWeekOutOfArea = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbcPointsPerFamMbr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcPointsPerWeek = new System.Windows.Forms.TextBox();
            this.lblPointsAllowed = new System.Windows.Forms.Label();
            this.chkEnablePointsTracking = new System.Windows.Forms.CheckBox();
            this.tpgFamilyMem = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkEnableIDFlds = new System.Windows.Forms.CheckBox();
            this.chkEnableWorksInArea = new System.Windows.Forms.CheckBox();
            this.chkEnableEthnicityHHMTab = new System.Windows.Forms.CheckBox();
            this.chkEnableAdditionalHHMDataTab = new System.Windows.Forms.CheckBox();
            this.tpClientOptions = new System.Windows.Forms.TabPage();
            this.cboFMIDType = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.chkFilterPeriodFromAddress = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobNever = new System.Windows.Forms.RadioButton();
            this.rdobAlways = new System.Windows.Forms.RadioButton();
            this.rdobSometimes = new System.Windows.Forms.RadioButton();
            this.rdobNormally = new System.Windows.Forms.RadioButton();
            this.chkAllowDuplicateMemberNames = new System.Windows.Forms.CheckBox();
            this.chkAllowDuplicateHHNames = new System.Windows.Forms.CheckBox();
            this.tbcDefaultZipcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcDefaultState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcDefaultCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpFormOptions = new System.Windows.Forms.TabPage();
            this.tbcNbrSvcDatesPast = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbcNbrSvcDatesFuture = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbcNbrDaysAllowMods = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbcNbrMealsPerService = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbcApptLogRefreshRate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbcServiceLogRefreshRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkFindClientAutoRefresh = new System.Windows.Forms.CheckBox();
            this.tpMonthlyRpts = new System.Windows.Forms.TabPage();
            this.tbcDonorIdFLL = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbcDonorIdTEFAP = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbcDonorIdEFAP = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbcDonorId2ndHarvest = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.chkMeregeTeens = new System.Windows.Forms.CheckBox();
            this.tbcNWHDonorId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cboFiscalStartMonth = new System.Windows.Forms.ComboBox();
            this.btnRptSaveFldr = new System.Windows.Forms.Button();
            this.tbReportsSavePath = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbcPreparedBy = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoUseLbsDonated = new System.Windows.Forms.RadioButton();
            this.rdoUseLbsServed = new System.Windows.Forms.RadioButton();
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW = new System.Windows.Forms.CheckBox();
            this.chkIncludeCommodityLbsInNorthwestHarvest = new System.Windows.Forms.CheckBox();
            this.chkIncludeCommodityLbsInFoodLifeline = new System.Windows.Forms.CheckBox();
            this.chkIncludeCommodityLbsInCoalition = new System.Windows.Forms.CheckBox();
            this.tbcInkindDollarsPerLb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbcInkindDollarsPerHour = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tpDonorPercent = new System.Windows.Forms.TabPage();
            this.lblDonorId20 = new System.Windows.Forms.Label();
            this.btnDonor20 = new System.Windows.Forms.Button();
            this.tbDonorId20 = new System.Windows.Forms.TextBox();
            this.lblDonorId19 = new System.Windows.Forms.Label();
            this.btnDonor19 = new System.Windows.Forms.Button();
            this.tbDonorId19 = new System.Windows.Forms.TextBox();
            this.lblDonorId18 = new System.Windows.Forms.Label();
            this.btnDonor18 = new System.Windows.Forms.Button();
            this.tbDonorId18 = new System.Windows.Forms.TextBox();
            this.lblDonorId17 = new System.Windows.Forms.Label();
            this.btnDonor17 = new System.Windows.Forms.Button();
            this.tbDonorId17 = new System.Windows.Forms.TextBox();
            this.lblDonorId16 = new System.Windows.Forms.Label();
            this.btnDonor16 = new System.Windows.Forms.Button();
            this.tbDonorId16 = new System.Windows.Forms.TextBox();
            this.lblDonorId15 = new System.Windows.Forms.Label();
            this.btnDonor15 = new System.Windows.Forms.Button();
            this.tbDonorId15 = new System.Windows.Forms.TextBox();
            this.lblDonorId14 = new System.Windows.Forms.Label();
            this.btnDonor14 = new System.Windows.Forms.Button();
            this.tbDonorId14 = new System.Windows.Forms.TextBox();
            this.lblDonorId13 = new System.Windows.Forms.Label();
            this.btnDonor13 = new System.Windows.Forms.Button();
            this.tbDonorId13 = new System.Windows.Forms.TextBox();
            this.lblDonorId12 = new System.Windows.Forms.Label();
            this.btnDonor12 = new System.Windows.Forms.Button();
            this.tbDonorId12 = new System.Windows.Forms.TextBox();
            this.lblDonorId11 = new System.Windows.Forms.Label();
            this.btnDonor11 = new System.Windows.Forms.Button();
            this.tbDonorId11 = new System.Windows.Forms.TextBox();
            this.lblDonorId10 = new System.Windows.Forms.Label();
            this.lblDonorId09 = new System.Windows.Forms.Label();
            this.lblDonorId08 = new System.Windows.Forms.Label();
            this.lblDonorId07 = new System.Windows.Forms.Label();
            this.lblDonorId06 = new System.Windows.Forms.Label();
            this.lblDonorId05 = new System.Windows.Forms.Label();
            this.lblDonorId04 = new System.Windows.Forms.Label();
            this.lblDonorId03 = new System.Windows.Forms.Label();
            this.lblDonorId02 = new System.Windows.Forms.Label();
            this.lblDonorId01 = new System.Windows.Forms.Label();
            this.btnDonor10 = new System.Windows.Forms.Button();
            this.btnDonor09 = new System.Windows.Forms.Button();
            this.btnDonor08 = new System.Windows.Forms.Button();
            this.btnDonor07 = new System.Windows.Forms.Button();
            this.btnDonor06 = new System.Windows.Forms.Button();
            this.btnDonor05 = new System.Windows.Forms.Button();
            this.btnDonor04 = new System.Windows.Forms.Button();
            this.btnDonor03 = new System.Windows.Forms.Button();
            this.btnDonor02 = new System.Windows.Forms.Button();
            this.btnDonor01 = new System.Windows.Forms.Button();
            this.tbDonorId09 = new System.Windows.Forms.TextBox();
            this.tbDonorId10 = new System.Windows.Forms.TextBox();
            this.tbDonorId05 = new System.Windows.Forms.TextBox();
            this.tbDonorId06 = new System.Windows.Forms.TextBox();
            this.tbDonorId07 = new System.Windows.Forms.TextBox();
            this.tbDonorId08 = new System.Windows.Forms.TextBox();
            this.tbDonorId01 = new System.Windows.Forms.TextBox();
            this.tbDonorId02 = new System.Windows.Forms.TextBox();
            this.tbDonorId03 = new System.Windows.Forms.TextBox();
            this.tbDonorId04 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToolTip = new System.Windows.Forms.Label();
            this.chkAlertOAMsgON = new System.Windows.Forms.CheckBox();
            this.tbcAlertOAMessageText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.chkBackPack.SuspendLayout();
            this.tpFeatures.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpgGeneral.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpViewGRBy.SuspendLayout();
            this.tpgMainForm.SuspendLayout();
            this.tpgAlerts.SuspendLayout();
            this.grpOutofArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertMonthSvc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertWeekSvc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertMinimumMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertMinimumDays)).BeginInit();
            this.grpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertMonthSvc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertWeekSvc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertMinimumMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertMinimumDays)).BeginInit();
            this.grpbxOverRideLevel.SuspendLayout();
            this.tpgFoodSvcs.SuspendLayout();
            this.tpgPoints.SuspendLayout();
            this.tpgFamilyMem.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpClientOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpFormOptions.SuspendLayout();
            this.tpMonthlyRpts.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tpDonorPercent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.chkBackPack);
            this.tabControl1.Controls.Add(this.tpFeatures);
            this.tabControl1.Controls.Add(this.tpClientOptions);
            this.tabControl1.Controls.Add(this.tpFormOptions);
            this.tabControl1.Controls.Add(this.tpMonthlyRpts);
            this.tabControl1.Controls.Add(this.tpDonorPercent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1366, 845);
            this.tabControl1.TabIndex = 0;
            // 
            // chkBackPack
            // 
            this.chkBackPack.BackColor = System.Drawing.Color.Ivory;
            this.chkBackPack.Controls.Add(this.tbcEFAPLeadAgency);
            this.chkBackPack.Controls.Add(this.label25);
            this.chkBackPack.Controls.Add(this.tbcAgencyNbr);
            this.chkBackPack.Controls.Add(this.lblAgencyNbr);
            this.chkBackPack.Controls.Add(this.chkEnableCDBGReporting);
            this.chkBackPack.Controls.Add(this.tbcFaxNum);
            this.chkBackPack.Controls.Add(this.label30);
            this.chkBackPack.Controls.Add(this.tbcCounty);
            this.chkBackPack.Controls.Add(this.label31);
            this.chkBackPack.Controls.Add(this.tbcPhysicalAddress);
            this.chkBackPack.Controls.Add(this.label8);
            this.chkBackPack.Controls.Add(this.tbcPostalAddress);
            this.chkBackPack.Controls.Add(this.label7);
            this.chkBackPack.Controls.Add(this.tbcPhoneNumber);
            this.chkBackPack.Controls.Add(this.label6);
            this.chkBackPack.Controls.Add(this.tbcEmailAddress);
            this.chkBackPack.Controls.Add(this.label5);
            this.chkBackPack.Controls.Add(this.tbcFoodBankName);
            this.chkBackPack.Controls.Add(this.label1);
            this.chkBackPack.Location = new System.Drawing.Point(4, 32);
            this.chkBackPack.Name = "chkBackPack";
            this.chkBackPack.Padding = new System.Windows.Forms.Padding(3);
            this.chkBackPack.Size = new System.Drawing.Size(1358, 809);
            this.chkBackPack.TabIndex = 0;
            this.chkBackPack.Tag = "My Food Bank";
            this.chkBackPack.Text = "My Food Bank";
            // 
            // tbcEFAPLeadAgency
            // 
            this.tbcEFAPLeadAgency.BackColor = System.Drawing.Color.White;
            this.tbcEFAPLeadAgency.ForeColor = System.Drawing.Color.Black;
            this.tbcEFAPLeadAgency.Location = new System.Drawing.Point(272, 689);
            this.tbcEFAPLeadAgency.Name = "tbcEFAPLeadAgency";
            this.tbcEFAPLeadAgency.Size = new System.Drawing.Size(235, 26);
            this.tbcEFAPLeadAgency.TabIndex = 17;
            this.tbcEFAPLeadAgency.Tag = "efapleadagency";
            this.tbcEFAPLeadAgency.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcEFAPLeadAgency.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 691);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(247, 22);
            this.label25.TabIndex = 16;
            this.label25.Text = "My EFAP Lead Agency Name";
            // 
            // tbcAgencyNbr
            // 
            this.tbcAgencyNbr.BackColor = System.Drawing.Color.White;
            this.tbcAgencyNbr.ForeColor = System.Drawing.Color.Black;
            this.tbcAgencyNbr.Location = new System.Drawing.Point(272, 648);
            this.tbcAgencyNbr.Name = "tbcAgencyNbr";
            this.tbcAgencyNbr.Size = new System.Drawing.Size(235, 26);
            this.tbcAgencyNbr.TabIndex = 15;
            this.tbcAgencyNbr.Tag = "agencynumber";
            this.tbcAgencyNbr.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcAgencyNbr.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // lblAgencyNbr
            // 
            this.lblAgencyNbr.AutoSize = true;
            this.lblAgencyNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyNbr.Location = new System.Drawing.Point(10, 648);
            this.lblAgencyNbr.Name = "lblAgencyNbr";
            this.lblAgencyNbr.Size = new System.Drawing.Size(223, 22);
            this.lblAgencyNbr.TabIndex = 14;
            this.lblAgencyNbr.Text = "My CDBG Agency Number";
            // 
            // chkEnableCDBGReporting
            // 
            this.chkEnableCDBGReporting.AutoSize = true;
            this.chkEnableCDBGReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableCDBGReporting.Location = new System.Drawing.Point(54, 605);
            this.chkEnableCDBGReporting.Name = "chkEnableCDBGReporting";
            this.chkEnableCDBGReporting.Size = new System.Drawing.Size(249, 29);
            this.chkEnableCDBGReporting.TabIndex = 13;
            this.chkEnableCDBGReporting.Tag = "enablecdbgreporting";
            this.chkEnableCDBGReporting.Text = "Enable CDBG Reporting";
            this.chkEnableCDBGReporting.UseVisualStyleBackColor = true;
            // 
            // tbcFaxNum
            // 
            this.tbcFaxNum.BackColor = System.Drawing.Color.White;
            this.tbcFaxNum.ForeColor = System.Drawing.Color.Black;
            this.tbcFaxNum.Location = new System.Drawing.Point(176, 483);
            this.tbcFaxNum.Name = "tbcFaxNum";
            this.tbcFaxNum.Size = new System.Drawing.Size(235, 26);
            this.tbcFaxNum.TabIndex = 10;
            this.tbcFaxNum.Tag = "faxnumber";
            this.tbcFaxNum.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcFaxNum.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(52, 486);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(108, 22);
            this.label30.TabIndex = 9;
            this.label30.Text = "Fax Number";
            // 
            // tbcCounty
            // 
            this.tbcCounty.BackColor = System.Drawing.Color.White;
            this.tbcCounty.ForeColor = System.Drawing.Color.Black;
            this.tbcCounty.Location = new System.Drawing.Point(176, 526);
            this.tbcCounty.Name = "tbcCounty";
            this.tbcCounty.Size = new System.Drawing.Size(235, 26);
            this.tbcCounty.TabIndex = 12;
            this.tbcCounty.Tag = "county";
            this.tbcCounty.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcCounty.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(99, 528);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 22);
            this.label31.TabIndex = 11;
            this.label31.Text = "County";
            // 
            // tbcPhysicalAddress
            // 
            this.tbcPhysicalAddress.AcceptsReturn = true;
            this.tbcPhysicalAddress.BackColor = System.Drawing.Color.White;
            this.tbcPhysicalAddress.ForeColor = System.Drawing.Color.Black;
            this.tbcPhysicalAddress.Location = new System.Drawing.Point(184, 243);
            this.tbcPhysicalAddress.Multiline = true;
            this.tbcPhysicalAddress.Name = "tbcPhysicalAddress";
            this.tbcPhysicalAddress.Size = new System.Drawing.Size(235, 122);
            this.tbcPhysicalAddress.TabIndex = 4;
            this.tbcPhysicalAddress.Tag = "physicaladdress";
            this.tbcPhysicalAddress.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPhysicalAddress.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Physical Address";
            // 
            // tbcPostalAddress
            // 
            this.tbcPostalAddress.AcceptsReturn = true;
            this.tbcPostalAddress.BackColor = System.Drawing.Color.White;
            this.tbcPostalAddress.ForeColor = System.Drawing.Color.Black;
            this.tbcPostalAddress.Location = new System.Drawing.Point(184, 94);
            this.tbcPostalAddress.Multiline = true;
            this.tbcPostalAddress.Name = "tbcPostalAddress";
            this.tbcPostalAddress.Size = new System.Drawing.Size(235, 122);
            this.tbcPostalAddress.TabIndex = 2;
            this.tbcPostalAddress.Tag = "postaladdress";
            this.tbcPostalAddress.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPostalAddress.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Postal Address";
            // 
            // tbcPhoneNumber
            // 
            this.tbcPhoneNumber.BackColor = System.Drawing.Color.White;
            this.tbcPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.tbcPhoneNumber.Location = new System.Drawing.Point(180, 431);
            this.tbcPhoneNumber.Name = "tbcPhoneNumber";
            this.tbcPhoneNumber.Size = new System.Drawing.Size(235, 26);
            this.tbcPhoneNumber.TabIndex = 8;
            this.tbcPhoneNumber.Tag = "phonenumber";
            this.tbcPhoneNumber.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPhoneNumber.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone Number";
            // 
            // tbcEmailAddress
            // 
            this.tbcEmailAddress.BackColor = System.Drawing.Color.White;
            this.tbcEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.tbcEmailAddress.Location = new System.Drawing.Point(180, 382);
            this.tbcEmailAddress.Name = "tbcEmailAddress";
            this.tbcEmailAddress.Size = new System.Drawing.Size(430, 26);
            this.tbcEmailAddress.TabIndex = 6;
            this.tbcEmailAddress.Tag = "emailaddress";
            this.tbcEmailAddress.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcEmailAddress.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email Address:";
            // 
            // tbcFoodBankName
            // 
            this.tbcFoodBankName.BackColor = System.Drawing.Color.White;
            this.tbcFoodBankName.ForeColor = System.Drawing.Color.Black;
            this.tbcFoodBankName.Location = new System.Drawing.Point(184, 40);
            this.tbcFoodBankName.Name = "tbcFoodBankName";
            this.tbcFoodBankName.Size = new System.Drawing.Size(336, 26);
            this.tbcFoodBankName.TabIndex = 1;
            this.tbcFoodBankName.Tag = "foodbankname";
            this.tbcFoodBankName.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcFoodBankName.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Bank Name";
            // 
            // tpFeatures
            // 
            this.tpFeatures.BackColor = System.Drawing.Color.Ivory;
            this.tpFeatures.Controls.Add(this.tabControl2);
            this.tpFeatures.Location = new System.Drawing.Point(4, 32);
            this.tpFeatures.Name = "tpFeatures";
            this.tpFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tpFeatures.Size = new System.Drawing.Size(1358, 809);
            this.tpFeatures.TabIndex = 1;
            this.tpFeatures.Tag = "Features";
            this.tpFeatures.Text = "Features";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpgGeneral);
            this.tabControl2.Controls.Add(this.tpgMainForm);
            this.tabControl2.Controls.Add(this.tpgAlerts);
            this.tabControl2.Controls.Add(this.tpgFoodSvcs);
            this.tabControl2.Controls.Add(this.tpgPoints);
            this.tabControl2.Controls.Add(this.tpgFamilyMem);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1352, 803);
            this.tabControl2.TabIndex = 0;
            // 
            // tpgGeneral
            // 
            this.tpgGeneral.Controls.Add(this.chkEnableCA);
            this.tpgGeneral.Controls.Add(this.chkEnableSchSupply);
            this.tpgGeneral.Controls.Add(this.groupBox4);
            this.tpgGeneral.Controls.Add(this.chkCaptureSignature);
            this.tpgGeneral.Controls.Add(this.label23);
            this.tpgGeneral.Controls.Add(this.cboSvcMnuTyp);
            this.tpgGeneral.Controls.Add(this.grpViewGRBy);
            this.tpgGeneral.Controls.Add(this.chkEnablePrintClientCard);
            this.tpgGeneral.Controls.Add(this.chkEnableClientReceipt);
            this.tpgGeneral.Controls.Add(this.chkEnableFoodDonations);
            this.tpgGeneral.Controls.Add(this.chkEnableAppointments);
            this.tpgGeneral.Controls.Add(this.chkUseTimeInOutForVols);
            this.tpgGeneral.Controls.Add(this.chkEnableVolunteerHours);
            this.tpgGeneral.Controls.Add(this.chkEnableCashDonations);
            this.tpgGeneral.Controls.Add(this.chkEnableVouchers);
            this.tpgGeneral.Controls.Add(this.chkEnableHomeDeliv);
            this.tpgGeneral.Controls.Add(this.chkAutoGiveService);
            this.tpgGeneral.Controls.Add(this.chkSearchFamilyMember);
            this.tpgGeneral.Controls.Add(this.chkEnableBarcodePrompts);
            this.tpgGeneral.Location = new System.Drawing.Point(4, 29);
            this.tpgGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgGeneral.Name = "tpgGeneral";
            this.tpgGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgGeneral.Size = new System.Drawing.Size(1344, 770);
            this.tpgGeneral.TabIndex = 0;
            this.tpgGeneral.Text = "General";
            this.tpgGeneral.UseVisualStyleBackColor = true;
            // 
            // chkEnableCA
            // 
            this.chkEnableCA.AutoSize = true;
            this.chkEnableCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableCA.Location = new System.Drawing.Point(630, 455);
            this.chkEnableCA.Name = "chkEnableCA";
            this.chkEnableCA.Size = new System.Drawing.Size(413, 30);
            this.chkEnableCA.TabIndex = 130;
            this.chkEnableCA.Tag = "enablechristmasprogram";
            this.chkEnableCA.Text = "Enable Christmas Assistance Program";
            this.chkEnableCA.UseVisualStyleBackColor = true;
            this.chkEnableCA.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableCA.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableCA.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableSchSupply
            // 
            this.chkEnableSchSupply.AutoSize = true;
            this.chkEnableSchSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableSchSupply.Location = new System.Drawing.Point(630, 412);
            this.chkEnableSchSupply.Name = "chkEnableSchSupply";
            this.chkEnableSchSupply.Size = new System.Drawing.Size(329, 30);
            this.chkEnableSchSupply.TabIndex = 129;
            this.chkEnableSchSupply.Tag = "enableschsupply";
            this.chkEnableSchSupply.Text = "Enable School Supply Module";
            this.chkEnableSchSupply.UseVisualStyleBackColor = true;
            this.chkEnableSchSupply.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableSchSupply.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableSchSupply.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkEnableFTScale);
            this.groupBox4.Controls.Add(this.chkEnableFastTrack);
            this.groupBox4.Controls.Add(this.chkFTScaleLbsIncludeTEFAP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(618, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(480, 197);
            this.groupBox4.TabIndex = 128;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fast Track";
            // 
            // chkEnableFTScale
            // 
            this.chkEnableFTScale.AutoSize = true;
            this.chkEnableFTScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableFTScale.Location = new System.Drawing.Point(50, 95);
            this.chkEnableFTScale.Name = "chkEnableFTScale";
            this.chkEnableFTScale.Size = new System.Drawing.Size(364, 30);
            this.chkEnableFTScale.TabIndex = 126;
            this.chkEnableFTScale.Tag = "EnableFTScale";
            this.chkEnableFTScale.Text = "Enable Fast Track Scale Interface";
            this.chkEnableFTScale.UseVisualStyleBackColor = true;
            this.chkEnableFTScale.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableFTScale.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableFTScale.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableFastTrack
            // 
            this.chkEnableFastTrack.AutoSize = true;
            this.chkEnableFastTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableFastTrack.Location = new System.Drawing.Point(20, 46);
            this.chkEnableFastTrack.Name = "chkEnableFastTrack";
            this.chkEnableFastTrack.Size = new System.Drawing.Size(213, 30);
            this.chkEnableFastTrack.TabIndex = 127;
            this.chkEnableFastTrack.Tag = "enablefasttrack";
            this.chkEnableFastTrack.Text = "Enable Fast Track";
            this.chkEnableFastTrack.UseVisualStyleBackColor = true;
            this.chkEnableFastTrack.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableFastTrack.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableFastTrack.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkFTScaleLbsIncludeTEFAP
            // 
            this.chkFTScaleLbsIncludeTEFAP.AutoSize = true;
            this.chkFTScaleLbsIncludeTEFAP.Checked = true;
            this.chkFTScaleLbsIncludeTEFAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFTScaleLbsIncludeTEFAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFTScaleLbsIncludeTEFAP.Location = new System.Drawing.Point(50, 138);
            this.chkFTScaleLbsIncludeTEFAP.Name = "chkFTScaleLbsIncludeTEFAP";
            this.chkFTScaleLbsIncludeTEFAP.Size = new System.Drawing.Size(403, 30);
            this.chkFTScaleLbsIncludeTEFAP.TabIndex = 125;
            this.chkFTScaleLbsIncludeTEFAP.Tag = "LbsIncludeCommodityWt";
            this.chkFTScaleLbsIncludeTEFAP.Text = "Fast Track Scale Lbs includes TEFAP";
            this.chkFTScaleLbsIncludeTEFAP.UseVisualStyleBackColor = true;
            this.chkFTScaleLbsIncludeTEFAP.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkFTScaleLbsIncludeTEFAP.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkFTScaleLbsIncludeTEFAP.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkCaptureSignature
            // 
            this.chkCaptureSignature.AutoSize = true;
            this.chkCaptureSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaptureSignature.Location = new System.Drawing.Point(72, 523);
            this.chkCaptureSignature.Name = "chkCaptureSignature";
            this.chkCaptureSignature.Size = new System.Drawing.Size(299, 30);
            this.chkCaptureSignature.TabIndex = 124;
            this.chkCaptureSignature.Tag = "capturesignature";
            this.chkCaptureSignature.Text = "Enable Capture Signatures";
            this.chkCaptureSignature.UseVisualStyleBackColor = true;
            this.chkCaptureSignature.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkCaptureSignature.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkCaptureSignature.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(80, 625);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(165, 22);
            this.label23.TabIndex = 123;
            this.label23.Text = "Service Menu Type";
            // 
            // cboSvcMnuTyp
            // 
            this.cboSvcMnuTyp.FormattingEnabled = true;
            this.cboSvcMnuTyp.Items.AddRange(new object[] {
            "None",
            "Issaquah Receipt",
            "LCC Receipt",
            "FES Order Form",
            "BG NCFB Order Form"});
            this.cboSvcMnuTyp.Location = new System.Drawing.Point(76, 652);
            this.cboSvcMnuTyp.Name = "cboSvcMnuTyp";
            this.cboSvcMnuTyp.Size = new System.Drawing.Size(240, 28);
            this.cboSvcMnuTyp.TabIndex = 122;
            this.cboSvcMnuTyp.Tag = "ServiceMenuType";
            this.cboSvcMnuTyp.SelectionChangeCommitted += new System.EventHandler(this.cboSvcMnuTyp_SelectionChangeCommitted);
            // 
            // grpViewGRBy
            // 
            this.grpViewGRBy.Controls.Add(this.rdoViewByFullWeek);
            this.grpViewGRBy.Controls.Add(this.rdoViewByCalendarWeek);
            this.grpViewGRBy.Location = new System.Drawing.Point(90, 308);
            this.grpViewGRBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpViewGRBy.Name = "grpViewGRBy";
            this.grpViewGRBy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpViewGRBy.Size = new System.Drawing.Size(288, 111);
            this.grpViewGRBy.TabIndex = 26;
            this.grpViewGRBy.TabStop = false;
            this.grpViewGRBy.Tag = "UseCalendarWeeks";
            this.grpViewGRBy.Text = "Grocery Rescue Display Mode";
            // 
            // rdoViewByFullWeek
            // 
            this.rdoViewByFullWeek.AutoSize = true;
            this.rdoViewByFullWeek.Checked = true;
            this.rdoViewByFullWeek.Location = new System.Drawing.Point(12, 71);
            this.rdoViewByFullWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoViewByFullWeek.Name = "rdoViewByFullWeek";
            this.rdoViewByFullWeek.Size = new System.Drawing.Size(164, 24);
            this.rdoViewByFullWeek.TabIndex = 28;
            this.rdoViewByFullWeek.TabStop = true;
            this.rdoViewByFullWeek.Tag = "False";
            this.rdoViewByFullWeek.Text = "View By Full Week";
            this.rdoViewByFullWeek.UseVisualStyleBackColor = true;
            this.rdoViewByFullWeek.CheckedChanged += new System.EventHandler(this.rdoViewBy_CheckedChanged);
            // 
            // rdoViewByCalendarWeek
            // 
            this.rdoViewByCalendarWeek.AutoSize = true;
            this.rdoViewByCalendarWeek.Location = new System.Drawing.Point(12, 34);
            this.rdoViewByCalendarWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoViewByCalendarWeek.Name = "rdoViewByCalendarWeek";
            this.rdoViewByCalendarWeek.Size = new System.Drawing.Size(203, 24);
            this.rdoViewByCalendarWeek.TabIndex = 26;
            this.rdoViewByCalendarWeek.Tag = "True";
            this.rdoViewByCalendarWeek.Text = "View By Calendar Week";
            this.rdoViewByCalendarWeek.UseVisualStyleBackColor = true;
            this.rdoViewByCalendarWeek.CheckedChanged += new System.EventHandler(this.rdoViewBy_CheckedChanged);
            // 
            // chkEnablePrintClientCard
            // 
            this.chkEnablePrintClientCard.AutoSize = true;
            this.chkEnablePrintClientCard.Checked = true;
            this.chkEnablePrintClientCard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnablePrintClientCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnablePrintClientCard.Location = new System.Drawing.Point(42, 485);
            this.chkEnablePrintClientCard.Name = "chkEnablePrintClientCard";
            this.chkEnablePrintClientCard.Size = new System.Drawing.Size(272, 30);
            this.chkEnablePrintClientCard.TabIndex = 30;
            this.chkEnablePrintClientCard.Tag = "enableprintclientcard";
            this.chkEnablePrintClientCard.Text = "Enable Print Client Card";
            this.chkEnablePrintClientCard.UseVisualStyleBackColor = true;
            this.chkEnablePrintClientCard.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnablePrintClientCard.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnablePrintClientCard.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableClientReceipt
            // 
            this.chkEnableClientReceipt.AutoSize = true;
            this.chkEnableClientReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableClientReceipt.Location = new System.Drawing.Point(42, 583);
            this.chkEnableClientReceipt.Name = "chkEnableClientReceipt";
            this.chkEnableClientReceipt.Size = new System.Drawing.Size(299, 30);
            this.chkEnableClientReceipt.TabIndex = 31;
            this.chkEnableClientReceipt.Tag = "enableclientreceipt";
            this.chkEnableClientReceipt.Text = "Enable Print Client Receipt";
            this.chkEnableClientReceipt.UseVisualStyleBackColor = true;
            this.chkEnableClientReceipt.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableClientReceipt.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableClientReceipt.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableFoodDonations
            // 
            this.chkEnableFoodDonations.AutoSize = true;
            this.chkEnableFoodDonations.Checked = true;
            this.chkEnableFoodDonations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableFoodDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableFoodDonations.Location = new System.Drawing.Point(42, 271);
            this.chkEnableFoodDonations.Name = "chkEnableFoodDonations";
            this.chkEnableFoodDonations.Size = new System.Drawing.Size(370, 30);
            this.chkEnableFoodDonations.TabIndex = 25;
            this.chkEnableFoodDonations.Tag = "enablefooddonations";
            this.chkEnableFoodDonations.Text = "Enable Food Receipts (Donations)";
            this.chkEnableFoodDonations.UseVisualStyleBackColor = true;
            this.chkEnableFoodDonations.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableFoodDonations.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableFoodDonations.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableAppointments
            // 
            this.chkEnableAppointments.AutoSize = true;
            this.chkEnableAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableAppointments.Location = new System.Drawing.Point(42, 37);
            this.chkEnableAppointments.Name = "chkEnableAppointments";
            this.chkEnableAppointments.Size = new System.Drawing.Size(246, 30);
            this.chkEnableAppointments.TabIndex = 20;
            this.chkEnableAppointments.Tag = "enableappointments";
            this.chkEnableAppointments.Text = "Enable Appointments";
            this.chkEnableAppointments.UseVisualStyleBackColor = true;
            this.chkEnableAppointments.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableAppointments.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableAppointments.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkUseTimeInOutForVols
            // 
            this.chkUseTimeInOutForVols.AutoSize = true;
            this.chkUseTimeInOutForVols.Checked = true;
            this.chkUseTimeInOutForVols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseTimeInOutForVols.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseTimeInOutForVols.Location = new System.Drawing.Point(672, 75);
            this.chkUseTimeInOutForVols.Name = "chkUseTimeInOutForVols";
            this.chkUseTimeInOutForVols.Size = new System.Drawing.Size(397, 30);
            this.chkUseTimeInOutForVols.TabIndex = 33;
            this.chkUseTimeInOutForVols.Tag = "usetimeinoutforvols";
            this.chkUseTimeInOutForVols.Text = "Use Time In/Out For Volunteer Hours";
            this.chkUseTimeInOutForVols.UseVisualStyleBackColor = true;
            this.chkUseTimeInOutForVols.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkUseTimeInOutForVols.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkUseTimeInOutForVols.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableVolunteerHours
            // 
            this.chkEnableVolunteerHours.AutoSize = true;
            this.chkEnableVolunteerHours.Checked = true;
            this.chkEnableVolunteerHours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableVolunteerHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableVolunteerHours.Location = new System.Drawing.Point(630, 37);
            this.chkEnableVolunteerHours.Name = "chkEnableVolunteerHours";
            this.chkEnableVolunteerHours.Size = new System.Drawing.Size(269, 30);
            this.chkEnableVolunteerHours.TabIndex = 32;
            this.chkEnableVolunteerHours.Tag = "enablevolunteerhours";
            this.chkEnableVolunteerHours.Text = "Enable Volunteer Hours";
            this.chkEnableVolunteerHours.UseVisualStyleBackColor = true;
            this.chkEnableVolunteerHours.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableVolunteerHours.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableVolunteerHours.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableCashDonations
            // 
            this.chkEnableCashDonations.AutoSize = true;
            this.chkEnableCashDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableCashDonations.Location = new System.Drawing.Point(42, 229);
            this.chkEnableCashDonations.Name = "chkEnableCashDonations";
            this.chkEnableCashDonations.Size = new System.Drawing.Size(267, 30);
            this.chkEnableCashDonations.TabIndex = 24;
            this.chkEnableCashDonations.Tag = "enablecashdonations";
            this.chkEnableCashDonations.Text = "Enable Cash Donations";
            this.chkEnableCashDonations.UseVisualStyleBackColor = true;
            this.chkEnableCashDonations.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableCashDonations.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableCashDonations.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableVouchers
            // 
            this.chkEnableVouchers.AutoSize = true;
            this.chkEnableVouchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableVouchers.Location = new System.Drawing.Point(630, 125);
            this.chkEnableVouchers.Name = "chkEnableVouchers";
            this.chkEnableVouchers.Size = new System.Drawing.Size(204, 30);
            this.chkEnableVouchers.TabIndex = 34;
            this.chkEnableVouchers.Tag = "enablevouchers";
            this.chkEnableVouchers.Text = "Enable Vouchers";
            this.chkEnableVouchers.UseVisualStyleBackColor = true;
            this.chkEnableVouchers.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableVouchers.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableVouchers.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableHomeDeliv
            // 
            this.chkEnableHomeDeliv.AutoSize = true;
            this.chkEnableHomeDeliv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableHomeDeliv.Location = new System.Drawing.Point(42, 437);
            this.chkEnableHomeDeliv.Name = "chkEnableHomeDeliv";
            this.chkEnableHomeDeliv.Size = new System.Drawing.Size(256, 30);
            this.chkEnableHomeDeliv.TabIndex = 29;
            this.chkEnableHomeDeliv.Tag = "enablehomedeliv";
            this.chkEnableHomeDeliv.Text = "Enable Home Delivery";
            this.chkEnableHomeDeliv.UseVisualStyleBackColor = true;
            this.chkEnableHomeDeliv.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableHomeDeliv.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableHomeDeliv.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkAutoGiveService
            // 
            this.chkAutoGiveService.AutoSize = true;
            this.chkAutoGiveService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoGiveService.Location = new System.Drawing.Point(93, 166);
            this.chkAutoGiveService.Name = "chkAutoGiveService";
            this.chkAutoGiveService.Size = new System.Drawing.Size(364, 30);
            this.chkAutoGiveService.TabIndex = 23;
            this.chkAutoGiveService.Tag = "automaticallygiveservice";
            this.chkAutoGiveService.Text = "Allow Automatically Give Service ";
            this.chkAutoGiveService.UseVisualStyleBackColor = true;
            this.chkAutoGiveService.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkAutoGiveService.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkAutoGiveService.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkSearchFamilyMember
            // 
            this.chkSearchFamilyMember.AutoSize = true;
            this.chkSearchFamilyMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchFamilyMember.Location = new System.Drawing.Point(93, 128);
            this.chkSearchFamilyMember.Name = "chkSearchFamilyMember";
            this.chkSearchFamilyMember.Size = new System.Drawing.Size(345, 30);
            this.chkSearchFamilyMember.TabIndex = 22;
            this.chkSearchFamilyMember.Tag = "barcodeusefamilymember";
            this.chkSearchFamilyMember.Text = "Search Family Member ID Field";
            this.chkSearchFamilyMember.UseVisualStyleBackColor = true;
            this.chkSearchFamilyMember.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkSearchFamilyMember.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkSearchFamilyMember.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableBarcodePrompts
            // 
            this.chkEnableBarcodePrompts.AutoSize = true;
            this.chkEnableBarcodePrompts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableBarcodePrompts.Location = new System.Drawing.Point(42, 89);
            this.chkEnableBarcodePrompts.Name = "chkEnableBarcodePrompts";
            this.chkEnableBarcodePrompts.Size = new System.Drawing.Size(281, 30);
            this.chkEnableBarcodePrompts.TabIndex = 21;
            this.chkEnableBarcodePrompts.Tag = "enablebarcodeprompts";
            this.chkEnableBarcodePrompts.Text = "Enable Barcode Prompts";
            this.chkEnableBarcodePrompts.UseVisualStyleBackColor = true;
            this.chkEnableBarcodePrompts.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableBarcodePrompts.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableBarcodePrompts.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tpgMainForm
            // 
            this.tpgMainForm.Controls.Add(this.chkEnableTransportation);
            this.tpgMainForm.Controls.Add(this.chkAllowIntakeEditing);
            this.tpgMainForm.Controls.Add(this.chkEnableClientPhone);
            this.tpgMainForm.Controls.Add(this.chkEnableVerifyId);
            this.tpgMainForm.Controls.Add(this.chkEnableHHUserDefinedFieldsTab);
            this.tpgMainForm.Controls.Add(this.chkEnableHUDIncomeCategory);
            this.tpgMainForm.Controls.Add(this.chkEnableHouseholdIncome);
            this.tpgMainForm.Location = new System.Drawing.Point(4, 29);
            this.tpgMainForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgMainForm.Name = "tpgMainForm";
            this.tpgMainForm.Size = new System.Drawing.Size(1344, 770);
            this.tpgMainForm.TabIndex = 3;
            this.tpgMainForm.Text = "Client Main Form";
            this.tpgMainForm.UseVisualStyleBackColor = true;
            // 
            // chkEnableTransportation
            // 
            this.chkEnableTransportation.AutoSize = true;
            this.chkEnableTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableTransportation.Location = new System.Drawing.Point(36, 312);
            this.chkEnableTransportation.Name = "chkEnableTransportation";
            this.chkEnableTransportation.Size = new System.Drawing.Size(330, 29);
            this.chkEnableTransportation.TabIndex = 43;
            this.chkEnableTransportation.Tag = "enabletransportation";
            this.chkEnableTransportation.Text = "Enable Transportation Type Entry";
            this.chkEnableTransportation.UseVisualStyleBackColor = true;
            // 
            // chkAllowIntakeEditing
            // 
            this.chkAllowIntakeEditing.AutoSize = true;
            this.chkAllowIntakeEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowIntakeEditing.Location = new System.Drawing.Point(522, 37);
            this.chkAllowIntakeEditing.Name = "chkAllowIntakeEditing";
            this.chkAllowIntakeEditing.Size = new System.Drawing.Size(371, 29);
            this.chkAllowIntakeEditing.TabIndex = 42;
            this.chkAllowIntakeEditing.Tag = "allowintakeediting";
            this.chkAllowIntakeEditing.Text = "Allow Intake User Client Edit Privileges";
            this.chkAllowIntakeEditing.UseVisualStyleBackColor = true;
            // 
            // chkEnableClientPhone
            // 
            this.chkEnableClientPhone.AutoSize = true;
            this.chkEnableClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableClientPhone.Location = new System.Drawing.Point(36, 37);
            this.chkEnableClientPhone.Name = "chkEnableClientPhone";
            this.chkEnableClientPhone.Size = new System.Drawing.Size(279, 29);
            this.chkEnableClientPhone.TabIndex = 37;
            this.chkEnableClientPhone.Tag = "enableclientphone";
            this.chkEnableClientPhone.Text = "Track Client Phone Number";
            this.chkEnableClientPhone.UseVisualStyleBackColor = true;
            this.chkEnableClientPhone.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableClientPhone.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableClientPhone.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableVerifyId
            // 
            this.chkEnableVerifyId.AutoSize = true;
            this.chkEnableVerifyId.Checked = true;
            this.chkEnableVerifyId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableVerifyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableVerifyId.Location = new System.Drawing.Point(36, 92);
            this.chkEnableVerifyId.Name = "chkEnableVerifyId";
            this.chkEnableVerifyId.Size = new System.Drawing.Size(232, 29);
            this.chkEnableVerifyId.TabIndex = 38;
            this.chkEnableVerifyId.Tag = "enableverifyid";
            this.chkEnableVerifyId.Text = "Enable Verify Address";
            this.chkEnableVerifyId.UseVisualStyleBackColor = true;
            this.chkEnableVerifyId.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableVerifyId.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableVerifyId.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableHHUserDefinedFieldsTab
            // 
            this.chkEnableHHUserDefinedFieldsTab.AutoSize = true;
            this.chkEnableHHUserDefinedFieldsTab.Checked = true;
            this.chkEnableHHUserDefinedFieldsTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableHHUserDefinedFieldsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableHHUserDefinedFieldsTab.Location = new System.Drawing.Point(36, 148);
            this.chkEnableHHUserDefinedFieldsTab.Name = "chkEnableHHUserDefinedFieldsTab";
            this.chkEnableHHUserDefinedFieldsTab.Size = new System.Drawing.Size(314, 29);
            this.chkEnableHHUserDefinedFieldsTab.TabIndex = 39;
            this.chkEnableHHUserDefinedFieldsTab.Tag = "enablehhuserdefinedfieldstab";
            this.chkEnableHHUserDefinedFieldsTab.Text = "Enable User Defined Fields Tab";
            this.chkEnableHHUserDefinedFieldsTab.UseVisualStyleBackColor = true;
            this.chkEnableHHUserDefinedFieldsTab.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableHHUserDefinedFieldsTab.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableHHUserDefinedFieldsTab.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableHUDIncomeCategory
            // 
            this.chkEnableHUDIncomeCategory.AutoSize = true;
            this.chkEnableHUDIncomeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableHUDIncomeCategory.Location = new System.Drawing.Point(36, 258);
            this.chkEnableHUDIncomeCategory.Name = "chkEnableHUDIncomeCategory";
            this.chkEnableHUDIncomeCategory.Size = new System.Drawing.Size(300, 29);
            this.chkEnableHUDIncomeCategory.TabIndex = 41;
            this.chkEnableHUDIncomeCategory.Tag = "EnableHUDCategory";
            this.chkEnableHUDIncomeCategory.Text = "Enable HUD Income Category";
            this.chkEnableHUDIncomeCategory.UseVisualStyleBackColor = true;
            this.chkEnableHUDIncomeCategory.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableHUDIncomeCategory.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableHUDIncomeCategory.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableHouseholdIncome
            // 
            this.chkEnableHouseholdIncome.AutoSize = true;
            this.chkEnableHouseholdIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableHouseholdIncome.Location = new System.Drawing.Point(36, 203);
            this.chkEnableHouseholdIncome.Name = "chkEnableHouseholdIncome";
            this.chkEnableHouseholdIncome.Size = new System.Drawing.Size(267, 29);
            this.chkEnableHouseholdIncome.TabIndex = 40;
            this.chkEnableHouseholdIncome.Tag = "enablehouseholdincome";
            this.chkEnableHouseholdIncome.Text = "Enable Household Income";
            this.chkEnableHouseholdIncome.UseVisualStyleBackColor = true;
            this.chkEnableHouseholdIncome.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableHouseholdIncome.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableHouseholdIncome.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tpgAlerts
            // 
            this.tpgAlerts.Controls.Add(this.tbcAlertOAMessageText);
            this.tpgAlerts.Controls.Add(this.chkAlertOAMsgON);
            this.tpgAlerts.Controls.Add(this.grpOutofArea);
            this.tpgAlerts.Controls.Add(this.grpAll);
            this.tpgAlerts.Controls.Add(this.chkUseLocalOutOfAreaAlerts);
            this.tpgAlerts.Controls.Add(this.grpbxOverRideLevel);
            this.tpgAlerts.Controls.Add(this.chkWarnSvcEachPerson);
            this.tpgAlerts.Location = new System.Drawing.Point(4, 29);
            this.tpgAlerts.Name = "tpgAlerts";
            this.tpgAlerts.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAlerts.Size = new System.Drawing.Size(1344, 770);
            this.tpgAlerts.TabIndex = 5;
            this.tpgAlerts.Text = "Alerts";
            this.tpgAlerts.UseVisualStyleBackColor = true;
            // 
            // grpOutofArea
            // 
            this.grpOutofArea.Controls.Add(this.label37);
            this.grpOutofArea.Controls.Add(this.nudOoAAlertMonthSvc);
            this.grpOutofArea.Controls.Add(this.tbcOoAAlertMinMonthsText);
            this.grpOutofArea.Controls.Add(this.nudOoAAlertWeekSvc);
            this.grpOutofArea.Controls.Add(this.label38);
            this.grpOutofArea.Controls.Add(this.label39);
            this.grpOutofArea.Controls.Add(this.nudOoAAlertMinimumMonths);
            this.grpOutofArea.Controls.Add(this.tbcOoAAlertMonthSvcText);
            this.grpOutofArea.Controls.Add(this.tbcOoAAlertMinDaysText);
            this.grpOutofArea.Controls.Add(this.tbcOoAAlertWeekSvcText);
            this.grpOutofArea.Controls.Add(this.label40);
            this.grpOutofArea.Controls.Add(this.nudOoAAlertMinimumDays);
            this.grpOutofArea.Location = new System.Drawing.Point(688, 108);
            this.grpOutofArea.Name = "grpOutofArea";
            this.grpOutofArea.Size = new System.Drawing.Size(626, 413);
            this.grpOutofArea.TabIndex = 120;
            this.grpOutofArea.TabStop = false;
            this.grpOutofArea.Text = "Alert for Non-Local ie Out of Area";
            this.grpOutofArea.Visible = false;
            this.grpOutofArea.Enter += new System.EventHandler(this.grpOutofArea_Enter);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(73, 53);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(414, 25);
            this.label37.TabIndex = 106;
            this.label37.Text = "Alert after this number of services in a MONTH";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudOoAAlertMonthSvc
            // 
            this.nudOoAAlertMonthSvc.Location = new System.Drawing.Point(9, 53);
            this.nudOoAAlertMonthSvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOoAAlertMonthSvc.Name = "nudOoAAlertMonthSvc";
            this.nudOoAAlertMonthSvc.Size = new System.Drawing.Size(52, 26);
            this.nudOoAAlertMonthSvc.TabIndex = 105;
            this.nudOoAAlertMonthSvc.Tag = "alertoamonthsvc";
            // 
            // tbcOoAAlertMinMonthsText
            // 
            this.tbcOoAAlertMinMonthsText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcOoAAlertMinMonthsText.Location = new System.Drawing.Point(77, 355);
            this.tbcOoAAlertMinMonthsText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcOoAAlertMinMonthsText.Name = "tbcOoAAlertMinMonthsText";
            this.tbcOoAAlertMinMonthsText.Size = new System.Drawing.Size(517, 29);
            this.tbcOoAAlertMinMonthsText.TabIndex = 117;
            this.tbcOoAAlertMinMonthsText.Tag = "alertminmonthstext";
            // 
            // nudOoAAlertWeekSvc
            // 
            this.nudOoAAlertWeekSvc.Location = new System.Drawing.Point(9, 149);
            this.nudOoAAlertWeekSvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOoAAlertWeekSvc.Name = "nudOoAAlertWeekSvc";
            this.nudOoAAlertWeekSvc.Size = new System.Drawing.Size(52, 26);
            this.nudOoAAlertWeekSvc.TabIndex = 108;
            this.nudOoAAlertWeekSvc.Tag = "alertoaweeksvc";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(73, 324);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(474, 25);
            this.label38.TabIndex = 116;
            this.label38.Text = "Alert when last service less than number of MONTHS";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(73, 149);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(400, 25);
            this.label39.TabIndex = 109;
            this.label39.Text = "Alert after this number of services in a WEEK";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudOoAAlertMinimumMonths
            // 
            this.nudOoAAlertMinimumMonths.Location = new System.Drawing.Point(9, 324);
            this.nudOoAAlertMinimumMonths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOoAAlertMinimumMonths.Name = "nudOoAAlertMinimumMonths";
            this.nudOoAAlertMinimumMonths.Size = new System.Drawing.Size(52, 26);
            this.nudOoAAlertMinimumMonths.TabIndex = 115;
            this.nudOoAAlertMinimumMonths.Tag = "alertoaminimummonths";
            // 
            // tbcOoAAlertMonthSvcText
            // 
            this.tbcOoAAlertMonthSvcText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcOoAAlertMonthSvcText.Location = new System.Drawing.Point(77, 91);
            this.tbcOoAAlertMonthSvcText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcOoAAlertMonthSvcText.Name = "tbcOoAAlertMonthSvcText";
            this.tbcOoAAlertMonthSvcText.Size = new System.Drawing.Size(517, 29);
            this.tbcOoAAlertMonthSvcText.TabIndex = 107;
            this.tbcOoAAlertMonthSvcText.Tag = "alertoamonthsvctext";
            // 
            // tbcOoAAlertMinDaysText
            // 
            this.tbcOoAAlertMinDaysText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcOoAAlertMinDaysText.Location = new System.Drawing.Point(77, 275);
            this.tbcOoAAlertMinDaysText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcOoAAlertMinDaysText.Name = "tbcOoAAlertMinDaysText";
            this.tbcOoAAlertMinDaysText.Size = new System.Drawing.Size(517, 29);
            this.tbcOoAAlertMinDaysText.TabIndex = 114;
            this.tbcOoAAlertMinDaysText.Tag = "alertoamindaystext";
            // 
            // tbcOoAAlertWeekSvcText
            // 
            this.tbcOoAAlertWeekSvcText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcOoAAlertWeekSvcText.Location = new System.Drawing.Point(77, 179);
            this.tbcOoAAlertWeekSvcText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcOoAAlertWeekSvcText.Name = "tbcOoAAlertWeekSvcText";
            this.tbcOoAAlertWeekSvcText.Size = new System.Drawing.Size(517, 29);
            this.tbcOoAAlertWeekSvcText.TabIndex = 110;
            this.tbcOoAAlertWeekSvcText.Tag = "alertoaweeksvctext";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(73, 244);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(441, 25);
            this.label40.TabIndex = 113;
            this.label40.Text = "Alert when last service less than number of DAYS";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudOoAAlertMinimumDays
            // 
            this.nudOoAAlertMinimumDays.Location = new System.Drawing.Point(9, 244);
            this.nudOoAAlertMinimumDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOoAAlertMinimumDays.Name = "nudOoAAlertMinimumDays";
            this.nudOoAAlertMinimumDays.Size = new System.Drawing.Size(52, 26);
            this.nudOoAAlertMinimumDays.TabIndex = 112;
            this.nudOoAAlertMinimumDays.Tag = "alertoaminimumdays";
            // 
            // grpAll
            // 
            this.grpAll.Controls.Add(this.lblAlertMonthSvc);
            this.grpAll.Controls.Add(this.nudAlertMonthSvc);
            this.grpAll.Controls.Add(this.tbcAlertMinMonthsText);
            this.grpAll.Controls.Add(this.nudAlertWeekSvc);
            this.grpAll.Controls.Add(this.label35);
            this.grpAll.Controls.Add(this.label11);
            this.grpAll.Controls.Add(this.nudAlertMinimumMonths);
            this.grpAll.Controls.Add(this.tbcAlertMonthSvcText);
            this.grpAll.Controls.Add(this.tbcAlertMinDaysText);
            this.grpAll.Controls.Add(this.tbcAlertWeekSvcText);
            this.grpAll.Controls.Add(this.label26);
            this.grpAll.Controls.Add(this.nudAlertMinimumDays);
            this.grpAll.Location = new System.Drawing.Point(21, 108);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(626, 413);
            this.grpAll.TabIndex = 119;
            this.grpAll.TabStop = false;
            this.grpAll.Text = "Alert for all Clients";
            // 
            // lblAlertMonthSvc
            // 
            this.lblAlertMonthSvc.AutoSize = true;
            this.lblAlertMonthSvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertMonthSvc.Location = new System.Drawing.Point(73, 53);
            this.lblAlertMonthSvc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertMonthSvc.Name = "lblAlertMonthSvc";
            this.lblAlertMonthSvc.Size = new System.Drawing.Size(414, 25);
            this.lblAlertMonthSvc.TabIndex = 106;
            this.lblAlertMonthSvc.Text = "Alert after this number of services in a MONTH";
            this.lblAlertMonthSvc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAlertMonthSvc
            // 
            this.nudAlertMonthSvc.Location = new System.Drawing.Point(9, 53);
            this.nudAlertMonthSvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAlertMonthSvc.Name = "nudAlertMonthSvc";
            this.nudAlertMonthSvc.Size = new System.Drawing.Size(52, 26);
            this.nudAlertMonthSvc.TabIndex = 105;
            this.nudAlertMonthSvc.Tag = "alertmonthsvc";
            this.nudAlertMonthSvc.Enter += new System.EventHandler(this.nudList_Enter);
            this.nudAlertMonthSvc.Leave += new System.EventHandler(this.nudList_Leave);
            // 
            // tbcAlertMinMonthsText
            // 
            this.tbcAlertMinMonthsText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAlertMinMonthsText.Location = new System.Drawing.Point(77, 355);
            this.tbcAlertMinMonthsText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAlertMinMonthsText.Name = "tbcAlertMinMonthsText";
            this.tbcAlertMinMonthsText.Size = new System.Drawing.Size(517, 29);
            this.tbcAlertMinMonthsText.TabIndex = 117;
            this.tbcAlertMinMonthsText.Tag = "alertminmonthstext";
            // 
            // nudAlertWeekSvc
            // 
            this.nudAlertWeekSvc.Location = new System.Drawing.Point(9, 149);
            this.nudAlertWeekSvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAlertWeekSvc.Name = "nudAlertWeekSvc";
            this.nudAlertWeekSvc.Size = new System.Drawing.Size(52, 26);
            this.nudAlertWeekSvc.TabIndex = 108;
            this.nudAlertWeekSvc.Tag = "alertweeksvc";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(73, 324);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(474, 25);
            this.label35.TabIndex = 116;
            this.label35.Text = "Alert when last service less than number of MONTHS";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 149);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 25);
            this.label11.TabIndex = 109;
            this.label11.Text = "Alert after this number of services in a WEEK";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAlertMinimumMonths
            // 
            this.nudAlertMinimumMonths.Location = new System.Drawing.Point(9, 324);
            this.nudAlertMinimumMonths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAlertMinimumMonths.Name = "nudAlertMinimumMonths";
            this.nudAlertMinimumMonths.Size = new System.Drawing.Size(52, 26);
            this.nudAlertMinimumMonths.TabIndex = 115;
            this.nudAlertMinimumMonths.Tag = "alertminimummonths";
            // 
            // tbcAlertMonthSvcText
            // 
            this.tbcAlertMonthSvcText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAlertMonthSvcText.Location = new System.Drawing.Point(77, 91);
            this.tbcAlertMonthSvcText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAlertMonthSvcText.Name = "tbcAlertMonthSvcText";
            this.tbcAlertMonthSvcText.Size = new System.Drawing.Size(517, 29);
            this.tbcAlertMonthSvcText.TabIndex = 107;
            this.tbcAlertMonthSvcText.Tag = "alertmonthsvctext";
            // 
            // tbcAlertMinDaysText
            // 
            this.tbcAlertMinDaysText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAlertMinDaysText.Location = new System.Drawing.Point(77, 275);
            this.tbcAlertMinDaysText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAlertMinDaysText.Name = "tbcAlertMinDaysText";
            this.tbcAlertMinDaysText.Size = new System.Drawing.Size(517, 29);
            this.tbcAlertMinDaysText.TabIndex = 114;
            this.tbcAlertMinDaysText.Tag = "alertmindaystext";
            // 
            // tbcAlertWeekSvcText
            // 
            this.tbcAlertWeekSvcText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAlertWeekSvcText.Location = new System.Drawing.Point(77, 179);
            this.tbcAlertWeekSvcText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAlertWeekSvcText.Name = "tbcAlertWeekSvcText";
            this.tbcAlertWeekSvcText.Size = new System.Drawing.Size(517, 29);
            this.tbcAlertWeekSvcText.TabIndex = 110;
            this.tbcAlertWeekSvcText.Tag = "alertweeksvctext";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(73, 244);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(441, 25);
            this.label26.TabIndex = 113;
            this.label26.Text = "Alert when last service less than number of DAYS";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAlertMinimumDays
            // 
            this.nudAlertMinimumDays.Location = new System.Drawing.Point(9, 244);
            this.nudAlertMinimumDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAlertMinimumDays.Name = "nudAlertMinimumDays";
            this.nudAlertMinimumDays.Size = new System.Drawing.Size(52, 26);
            this.nudAlertMinimumDays.TabIndex = 112;
            this.nudAlertMinimumDays.Tag = "alertminimumdays";
            // 
            // chkUseLocalOutOfAreaAlerts
            // 
            this.chkUseLocalOutOfAreaAlerts.AutoSize = true;
            this.chkUseLocalOutOfAreaAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseLocalOutOfAreaAlerts.Location = new System.Drawing.Point(688, 32);
            this.chkUseLocalOutOfAreaAlerts.Name = "chkUseLocalOutOfAreaAlerts";
            this.chkUseLocalOutOfAreaAlerts.Size = new System.Drawing.Size(323, 29);
            this.chkUseLocalOutOfAreaAlerts.TabIndex = 118;
            this.chkUseLocalOutOfAreaAlerts.Tag = "UseLocalOutOfAreaAlerts";
            this.chkUseLocalOutOfAreaAlerts.Text = "Use Local and Out of Area Alerts";
            this.chkUseLocalOutOfAreaAlerts.UseVisualStyleBackColor = true;
            this.chkUseLocalOutOfAreaAlerts.CheckedChanged += new System.EventHandler(this.chkUseLocalOutOfAreaAlerts_CheckedChanged);
            this.chkUseLocalOutOfAreaAlerts.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkUseLocalOutOfAreaAlerts.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // grpbxOverRideLevel
            // 
            this.grpbxOverRideLevel.Controls.Add(this.rdoOverRideAdmin);
            this.grpbxOverRideLevel.Controls.Add(this.rdoOverRideInatkeAdmin);
            this.grpbxOverRideLevel.Controls.Add(this.rdoOverRideIntake);
            this.grpbxOverRideLevel.Location = new System.Drawing.Point(21, 554);
            this.grpbxOverRideLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxOverRideLevel.Name = "grpbxOverRideLevel";
            this.grpbxOverRideLevel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxOverRideLevel.Size = new System.Drawing.Size(413, 92);
            this.grpbxOverRideLevel.TabIndex = 111;
            this.grpbxOverRideLevel.TabStop = false;
            this.grpbxOverRideLevel.Text = "Over Ride Level";
            // 
            // rdoOverRideAdmin
            // 
            this.rdoOverRideAdmin.AutoSize = true;
            this.rdoOverRideAdmin.Location = new System.Drawing.Point(318, 43);
            this.rdoOverRideAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoOverRideAdmin.Name = "rdoOverRideAdmin";
            this.rdoOverRideAdmin.Size = new System.Drawing.Size(79, 24);
            this.rdoOverRideAdmin.TabIndex = 79;
            this.rdoOverRideAdmin.TabStop = true;
            this.rdoOverRideAdmin.Tag = "2";
            this.rdoOverRideAdmin.Text = "Admin";
            this.rdoOverRideAdmin.UseVisualStyleBackColor = true;
            this.rdoOverRideAdmin.CheckedChanged += new System.EventHandler(this.rdoOverRide_CheckedChanged);
            // 
            // rdoOverRideInatkeAdmin
            // 
            this.rdoOverRideInatkeAdmin.AutoSize = true;
            this.rdoOverRideInatkeAdmin.Location = new System.Drawing.Point(154, 43);
            this.rdoOverRideInatkeAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoOverRideInatkeAdmin.Name = "rdoOverRideInatkeAdmin";
            this.rdoOverRideInatkeAdmin.Size = new System.Drawing.Size(128, 24);
            this.rdoOverRideInatkeAdmin.TabIndex = 78;
            this.rdoOverRideInatkeAdmin.TabStop = true;
            this.rdoOverRideInatkeAdmin.Tag = "1";
            this.rdoOverRideInatkeAdmin.Text = "Intake Admin";
            this.rdoOverRideInatkeAdmin.UseVisualStyleBackColor = true;
            this.rdoOverRideInatkeAdmin.CheckedChanged += new System.EventHandler(this.rdoOverRide_CheckedChanged);
            // 
            // rdoOverRideIntake
            // 
            this.rdoOverRideIntake.AutoSize = true;
            this.rdoOverRideIntake.Location = new System.Drawing.Point(24, 43);
            this.rdoOverRideIntake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoOverRideIntake.Name = "rdoOverRideIntake";
            this.rdoOverRideIntake.Size = new System.Drawing.Size(79, 24);
            this.rdoOverRideIntake.TabIndex = 77;
            this.rdoOverRideIntake.TabStop = true;
            this.rdoOverRideIntake.Tag = "0";
            this.rdoOverRideIntake.Text = "Intake";
            this.rdoOverRideIntake.UseVisualStyleBackColor = true;
            this.rdoOverRideIntake.CheckedChanged += new System.EventHandler(this.rdoOverRide_CheckedChanged);
            // 
            // chkWarnSvcEachPerson
            // 
            this.chkWarnSvcEachPerson.AutoSize = true;
            this.chkWarnSvcEachPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarnSvcEachPerson.Location = new System.Drawing.Point(21, 32);
            this.chkWarnSvcEachPerson.Name = "chkWarnSvcEachPerson";
            this.chkWarnSvcEachPerson.Size = new System.Drawing.Size(367, 29);
            this.chkWarnSvcEachPerson.TabIndex = 104;
            this.chkWarnSvcEachPerson.Tag = "warnsvceachperson";
            this.chkWarnSvcEachPerson.Text = "Warn For Weekly Services By Person";
            this.chkWarnSvcEachPerson.UseVisualStyleBackColor = true;
            this.chkWarnSvcEachPerson.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkWarnSvcEachPerson.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkWarnSvcEachPerson.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tpgFoodSvcs
            // 
            this.tpgFoodSvcs.Controls.Add(this.chkEnableServiceGroups);
            this.tpgFoodSvcs.Controls.Add(this.chkIncludeLbsOnFoodSvcList);
            this.tpgFoodSvcs.Controls.Add(this.chkCaptureTEFAPSign);
            this.tpgFoodSvcs.Controls.Add(this.chkCSFPShowRoutes);
            this.tpgFoodSvcs.Controls.Add(this.tbcLbsPerCSFPService);
            this.tpgFoodSvcs.Controls.Add(this.label10);
            this.tpgFoodSvcs.Controls.Add(this.tbcCommSigValidFor);
            this.tpgFoodSvcs.Controls.Add(this.label9);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableBabyServices);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableFoodService);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableSupplemental);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableTEFAP);
            this.tpgFoodSvcs.Controls.Add(this.chkMustBeACommodityDay);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableCSFPOnNewSvc);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableBackPack);
            this.tpgFoodSvcs.Controls.Add(this.chkEnableCSFP);
            this.tpgFoodSvcs.Location = new System.Drawing.Point(4, 29);
            this.tpgFoodSvcs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgFoodSvcs.Name = "tpgFoodSvcs";
            this.tpgFoodSvcs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgFoodSvcs.Size = new System.Drawing.Size(1344, 770);
            this.tpgFoodSvcs.TabIndex = 1;
            this.tpgFoodSvcs.Text = "Food Services";
            this.tpgFoodSvcs.UseVisualStyleBackColor = true;
            // 
            // chkEnableServiceGroups
            // 
            this.chkEnableServiceGroups.AutoSize = true;
            this.chkEnableServiceGroups.Checked = true;
            this.chkEnableServiceGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableServiceGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableServiceGroups.Location = new System.Drawing.Point(708, 31);
            this.chkEnableServiceGroups.Name = "chkEnableServiceGroups";
            this.chkEnableServiceGroups.Size = new System.Drawing.Size(239, 29);
            this.chkEnableServiceGroups.TabIndex = 100;
            this.chkEnableServiceGroups.Tag = "enableservicegroups";
            this.chkEnableServiceGroups.Text = "Enable Service Groups";
            this.chkEnableServiceGroups.UseVisualStyleBackColor = true;
            this.chkEnableServiceGroups.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableServiceGroups.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableServiceGroups.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkIncludeLbsOnFoodSvcList
            // 
            this.chkIncludeLbsOnFoodSvcList.AutoSize = true;
            this.chkIncludeLbsOnFoodSvcList.Checked = true;
            this.chkIncludeLbsOnFoodSvcList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeLbsOnFoodSvcList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeLbsOnFoodSvcList.Location = new System.Drawing.Point(708, 86);
            this.chkIncludeLbsOnFoodSvcList.Name = "chkIncludeLbsOnFoodSvcList";
            this.chkIncludeLbsOnFoodSvcList.Size = new System.Drawing.Size(356, 29);
            this.chkIncludeLbsOnFoodSvcList.TabIndex = 88;
            this.chkIncludeLbsOnFoodSvcList.Tag = "IncludeLbsOnSvcList";
            this.chkIncludeLbsOnFoodSvcList.Text = "Include Pounds on Food Service List";
            this.chkIncludeLbsOnFoodSvcList.UseVisualStyleBackColor = true;
            this.chkIncludeLbsOnFoodSvcList.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkIncludeLbsOnFoodSvcList.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkIncludeLbsOnFoodSvcList.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkCaptureTEFAPSign
            // 
            this.chkCaptureTEFAPSign.AutoSize = true;
            this.chkCaptureTEFAPSign.Checked = true;
            this.chkCaptureTEFAPSign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCaptureTEFAPSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaptureTEFAPSign.Location = new System.Drawing.Point(90, 222);
            this.chkCaptureTEFAPSign.Name = "chkCaptureTEFAPSign";
            this.chkCaptureTEFAPSign.Size = new System.Drawing.Size(446, 29);
            this.chkCaptureTEFAPSign.TabIndex = 80;
            this.chkCaptureTEFAPSign.Tag = "CaptureTEFAPSignature";
            this.chkCaptureTEFAPSign.Text = "Prompt Commodity Signature on Every Service";
            this.chkCaptureTEFAPSign.UseVisualStyleBackColor = true;
            this.chkCaptureTEFAPSign.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkCaptureTEFAPSign.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkCaptureTEFAPSign.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkCSFPShowRoutes
            // 
            this.chkCSFPShowRoutes.AutoSize = true;
            this.chkCSFPShowRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCSFPShowRoutes.Location = new System.Drawing.Point(90, 468);
            this.chkCSFPShowRoutes.Name = "chkCSFPShowRoutes";
            this.chkCSFPShowRoutes.Size = new System.Drawing.Size(213, 29);
            this.chkCSFPShowRoutes.TabIndex = 79;
            this.chkCSFPShowRoutes.Tag = "csfpshowroutes";
            this.chkCSFPShowRoutes.Text = "Show CSFP Routes";
            this.chkCSFPShowRoutes.UseVisualStyleBackColor = true;
            this.chkCSFPShowRoutes.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkCSFPShowRoutes.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkCSFPShowRoutes.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tbcLbsPerCSFPService
            // 
            this.tbcLbsPerCSFPService.BackColor = System.Drawing.Color.White;
            this.tbcLbsPerCSFPService.ForeColor = System.Drawing.Color.Black;
            this.tbcLbsPerCSFPService.Location = new System.Drawing.Point(90, 432);
            this.tbcLbsPerCSFPService.Name = "tbcLbsPerCSFPService";
            this.tbcLbsPerCSFPService.Size = new System.Drawing.Size(84, 26);
            this.tbcLbsPerCSFPService.TabIndex = 60;
            this.tbcLbsPerCSFPService.Tag = "CSFPLbsPerService";
            this.tbcLbsPerCSFPService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcLbsPerCSFPService.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcLbsPerCSFPService.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 22);
            this.label10.TabIndex = 62;
            this.label10.Tag = "";
            this.label10.Text = "Pounds per CSFP Service";
            // 
            // tbcCommSigValidFor
            // 
            this.tbcCommSigValidFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCommSigValidFor.Location = new System.Drawing.Point(88, 178);
            this.tbcCommSigValidFor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcCommSigValidFor.Name = "tbcCommSigValidFor";
            this.tbcCommSigValidFor.Size = new System.Drawing.Size(90, 30);
            this.tbcCommSigValidFor.TabIndex = 24;
            this.tbcCommSigValidFor.Tag = "CommSigValidFor";
            this.tbcCommSigValidFor.Text = "12";
            this.tbcCommSigValidFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcCommSigValidFor.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcCommSigValidFor.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Months Comm. Signiture Valid";
            // 
            // chkEnableBabyServices
            // 
            this.chkEnableBabyServices.AutoSize = true;
            this.chkEnableBabyServices.Checked = true;
            this.chkEnableBabyServices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableBabyServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableBabyServices.Location = new System.Drawing.Point(56, 272);
            this.chkEnableBabyServices.Name = "chkEnableBabyServices";
            this.chkEnableBabyServices.Size = new System.Drawing.Size(230, 29);
            this.chkEnableBabyServices.TabIndex = 56;
            this.chkEnableBabyServices.Tag = "EnableBabyServices";
            this.chkEnableBabyServices.Text = "Enable Baby Services";
            this.chkEnableBabyServices.UseVisualStyleBackColor = true;
            this.chkEnableBabyServices.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableBabyServices.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableBabyServices.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableFoodService
            // 
            this.chkEnableFoodService.AutoSize = true;
            this.chkEnableFoodService.Checked = true;
            this.chkEnableFoodService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableFoodService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableFoodService.Location = new System.Drawing.Point(24, 25);
            this.chkEnableFoodService.Name = "chkEnableFoodService";
            this.chkEnableFoodService.Size = new System.Drawing.Size(230, 29);
            this.chkEnableFoodService.TabIndex = 20;
            this.chkEnableFoodService.Tag = "enablefoodservices";
            this.chkEnableFoodService.Text = "Enable Food Services";
            this.chkEnableFoodService.UseVisualStyleBackColor = true;
            this.chkEnableFoodService.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableFoodService.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableFoodService.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableSupplemental
            // 
            this.chkEnableSupplemental.AutoSize = true;
            this.chkEnableSupplemental.Checked = true;
            this.chkEnableSupplemental.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSupplemental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableSupplemental.Location = new System.Drawing.Point(56, 63);
            this.chkEnableSupplemental.Name = "chkEnableSupplemental";
            this.chkEnableSupplemental.Size = new System.Drawing.Size(345, 29);
            this.chkEnableSupplemental.TabIndex = 21;
            this.chkEnableSupplemental.Tag = "enablesupplemental";
            this.chkEnableSupplemental.Text = "Enable Supplemental Food Service";
            this.chkEnableSupplemental.UseVisualStyleBackColor = true;
            this.chkEnableSupplemental.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableSupplemental.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableSupplemental.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableTEFAP
            // 
            this.chkEnableTEFAP.AutoSize = true;
            this.chkEnableTEFAP.Checked = true;
            this.chkEnableTEFAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableTEFAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableTEFAP.Location = new System.Drawing.Point(56, 102);
            this.chkEnableTEFAP.Name = "chkEnableTEFAP";
            this.chkEnableTEFAP.Size = new System.Drawing.Size(302, 29);
            this.chkEnableTEFAP.TabIndex = 22;
            this.chkEnableTEFAP.Tag = "enabletefap";
            this.chkEnableTEFAP.Text = "Enable Commodities (TEFAP)";
            this.chkEnableTEFAP.UseVisualStyleBackColor = true;
            this.chkEnableTEFAP.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableTEFAP.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableTEFAP.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkMustBeACommodityDay
            // 
            this.chkMustBeACommodityDay.AutoSize = true;
            this.chkMustBeACommodityDay.Checked = true;
            this.chkMustBeACommodityDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMustBeACommodityDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMustBeACommodityDay.Location = new System.Drawing.Point(90, 145);
            this.chkMustBeACommodityDay.Name = "chkMustBeACommodityDay";
            this.chkMustBeACommodityDay.Size = new System.Drawing.Size(440, 29);
            this.chkMustBeACommodityDay.TabIndex = 23;
            this.chkMustBeACommodityDay.Tag = "mustbeacommodityday";
            this.chkMustBeACommodityDay.Text = "Serve Commodity ONLY on a Commodity Day";
            this.chkMustBeACommodityDay.UseVisualStyleBackColor = true;
            this.chkMustBeACommodityDay.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkMustBeACommodityDay.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkMustBeACommodityDay.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableCSFPOnNewSvc
            // 
            this.chkEnableCSFPOnNewSvc.AutoSize = true;
            this.chkEnableCSFPOnNewSvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableCSFPOnNewSvc.Location = new System.Drawing.Point(90, 392);
            this.chkEnableCSFPOnNewSvc.Name = "chkEnableCSFPOnNewSvc";
            this.chkEnableCSFPOnNewSvc.Size = new System.Drawing.Size(344, 29);
            this.chkEnableCSFPOnNewSvc.TabIndex = 59;
            this.chkEnableCSFPOnNewSvc.Tag = "enablecsfponnewsvc";
            this.chkEnableCSFPOnNewSvc.Text = "Show CSFP On New Service Form";
            this.chkEnableCSFPOnNewSvc.UseVisualStyleBackColor = true;
            this.chkEnableCSFPOnNewSvc.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableCSFPOnNewSvc.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableCSFPOnNewSvc.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableBackPack
            // 
            this.chkEnableBackPack.AutoSize = true;
            this.chkEnableBackPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableBackPack.Location = new System.Drawing.Point(56, 315);
            this.chkEnableBackPack.Name = "chkEnableBackPack";
            this.chkEnableBackPack.Size = new System.Drawing.Size(197, 29);
            this.chkEnableBackPack.TabIndex = 57;
            this.chkEnableBackPack.Tag = "enablebackpack";
            this.chkEnableBackPack.Text = "Enable Back Pack";
            this.chkEnableBackPack.UseVisualStyleBackColor = true;
            this.chkEnableBackPack.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableBackPack.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableBackPack.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableCSFP
            // 
            this.chkEnableCSFP.AutoSize = true;
            this.chkEnableCSFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableCSFP.Location = new System.Drawing.Point(56, 354);
            this.chkEnableCSFP.Name = "chkEnableCSFP";
            this.chkEnableCSFP.Size = new System.Drawing.Size(158, 29);
            this.chkEnableCSFP.TabIndex = 58;
            this.chkEnableCSFP.Tag = "enablecsfp";
            this.chkEnableCSFP.Text = "Enable CSFP";
            this.chkEnableCSFP.UseVisualStyleBackColor = true;
            this.chkEnableCSFP.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableCSFP.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableCSFP.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tpgPoints
            // 
            this.tpgPoints.Controls.Add(this.tbcMaxPointsPerWeek);
            this.tpgPoints.Controls.Add(this.label36);
            this.tpgPoints.Controls.Add(this.tbcPointsPerWeekOutOfArea);
            this.tpgPoints.Controls.Add(this.label14);
            this.tpgPoints.Controls.Add(this.tbcPointsPerFamMbr);
            this.tpgPoints.Controls.Add(this.label13);
            this.tpgPoints.Controls.Add(this.tbcPointsPerWeek);
            this.tpgPoints.Controls.Add(this.lblPointsAllowed);
            this.tpgPoints.Controls.Add(this.chkEnablePointsTracking);
            this.tpgPoints.Location = new System.Drawing.Point(4, 29);
            this.tpgPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgPoints.Name = "tpgPoints";
            this.tpgPoints.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgPoints.Size = new System.Drawing.Size(1344, 770);
            this.tpgPoints.TabIndex = 2;
            this.tpgPoints.Text = "Points";
            this.tpgPoints.UseVisualStyleBackColor = true;
            // 
            // tbcMaxPointsPerWeek
            // 
            this.tbcMaxPointsPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcMaxPointsPerWeek.Location = new System.Drawing.Point(78, 203);
            this.tbcMaxPointsPerWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcMaxPointsPerWeek.Name = "tbcMaxPointsPerWeek";
            this.tbcMaxPointsPerWeek.Size = new System.Drawing.Size(90, 30);
            this.tbcMaxPointsPerWeek.TabIndex = 86;
            this.tbcMaxPointsPerWeek.Tag = "MaxPointsPerWeek";
            this.tbcMaxPointsPerWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcMaxPointsPerWeek.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcMaxPointsPerWeek.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(172, 208);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(334, 25);
            this.label36.TabIndex = 87;
            this.label36.Text = "Maximum Points Allocated Per Week";
            // 
            // tbcPointsPerWeekOutOfArea
            // 
            this.tbcPointsPerWeekOutOfArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPointsPerWeekOutOfArea.Location = new System.Drawing.Point(78, 154);
            this.tbcPointsPerWeekOutOfArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcPointsPerWeekOutOfArea.Name = "tbcPointsPerWeekOutOfArea";
            this.tbcPointsPerWeekOutOfArea.Size = new System.Drawing.Size(90, 30);
            this.tbcPointsPerWeekOutOfArea.TabIndex = 84;
            this.tbcPointsPerWeekOutOfArea.Tag = "PointsPerWeekOutOfArea";
            this.tbcPointsPerWeekOutOfArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcPointsPerWeekOutOfArea.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPointsPerWeekOutOfArea.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(172, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(535, 25);
            this.label14.TabIndex = 85;
            this.label14.Text = "Base Points Allocated Per Week for Out of Area Households";
            // 
            // tbcPointsPerFamMbr
            // 
            this.tbcPointsPerFamMbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPointsPerFamMbr.Location = new System.Drawing.Point(76, 111);
            this.tbcPointsPerFamMbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcPointsPerFamMbr.Name = "tbcPointsPerFamMbr";
            this.tbcPointsPerFamMbr.Size = new System.Drawing.Size(90, 30);
            this.tbcPointsPerFamMbr.TabIndex = 82;
            this.tbcPointsPerFamMbr.Tag = "PointsPerFamMbr";
            this.tbcPointsPerFamMbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcPointsPerFamMbr.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPointsPerFamMbr.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(331, 25);
            this.label13.TabIndex = 83;
            this.label13.Text = "Points Per Additional Family Member";
            // 
            // tbcPointsPerWeek
            // 
            this.tbcPointsPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPointsPerWeek.Location = new System.Drawing.Point(76, 69);
            this.tbcPointsPerWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcPointsPerWeek.Name = "tbcPointsPerWeek";
            this.tbcPointsPerWeek.Size = new System.Drawing.Size(90, 30);
            this.tbcPointsPerWeek.TabIndex = 80;
            this.tbcPointsPerWeek.Tag = "PointsPerWeek";
            this.tbcPointsPerWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcPointsPerWeek.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPointsPerWeek.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // lblPointsAllowed
            // 
            this.lblPointsAllowed.AutoSize = true;
            this.lblPointsAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsAllowed.Location = new System.Drawing.Point(171, 74);
            this.lblPointsAllowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointsAllowed.Name = "lblPointsAllowed";
            this.lblPointsAllowed.Size = new System.Drawing.Size(294, 25);
            this.lblPointsAllowed.TabIndex = 81;
            this.lblPointsAllowed.Text = "Base Points Allocated Per Week";
            // 
            // chkEnablePointsTracking
            // 
            this.chkEnablePointsTracking.AutoSize = true;
            this.chkEnablePointsTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnablePointsTracking.Location = new System.Drawing.Point(42, 25);
            this.chkEnablePointsTracking.Name = "chkEnablePointsTracking";
            this.chkEnablePointsTracking.Size = new System.Drawing.Size(239, 29);
            this.chkEnablePointsTracking.TabIndex = 79;
            this.chkEnablePointsTracking.Tag = "enablepointstracking";
            this.chkEnablePointsTracking.Text = "Enable Points Tracking";
            this.chkEnablePointsTracking.UseVisualStyleBackColor = true;
            this.chkEnablePointsTracking.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnablePointsTracking.Enter += new System.EventHandler(this.chkBoxes_Enter);
            // 
            // tpgFamilyMem
            // 
            this.tpgFamilyMem.Controls.Add(this.groupBox6);
            this.tpgFamilyMem.Location = new System.Drawing.Point(4, 29);
            this.tpgFamilyMem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgFamilyMem.Name = "tpgFamilyMem";
            this.tpgFamilyMem.Size = new System.Drawing.Size(1344, 770);
            this.tpgFamilyMem.TabIndex = 4;
            this.tpgFamilyMem.Text = "Family Member Form";
            this.tpgFamilyMem.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkEnableIDFlds);
            this.groupBox6.Controls.Add(this.chkEnableWorksInArea);
            this.groupBox6.Controls.Add(this.chkEnableEthnicityHHMTab);
            this.groupBox6.Controls.Add(this.chkEnableAdditionalHHMDataTab);
            this.groupBox6.Location = new System.Drawing.Point(24, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(450, 237);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            // 
            // chkEnableIDFlds
            // 
            this.chkEnableIDFlds.AutoSize = true;
            this.chkEnableIDFlds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableIDFlds.Location = new System.Drawing.Point(14, 166);
            this.chkEnableIDFlds.Name = "chkEnableIDFlds";
            this.chkEnableIDFlds.Size = new System.Drawing.Size(180, 29);
            this.chkEnableIDFlds.TabIndex = 46;
            this.chkEnableIDFlds.Tag = "enableidflds";
            this.chkEnableIDFlds.Text = "Enable ID Fields";
            this.chkEnableIDFlds.UseVisualStyleBackColor = true;
            this.chkEnableIDFlds.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableIDFlds.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableIDFlds.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableWorksInArea
            // 
            this.chkEnableWorksInArea.AutoSize = true;
            this.chkEnableWorksInArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableWorksInArea.Location = new System.Drawing.Point(14, 51);
            this.chkEnableWorksInArea.Name = "chkEnableWorksInArea";
            this.chkEnableWorksInArea.Size = new System.Drawing.Size(229, 29);
            this.chkEnableWorksInArea.TabIndex = 43;
            this.chkEnableWorksInArea.Tag = "EnableWorksInArea";
            this.chkEnableWorksInArea.Text = "Enable Works In Area";
            this.chkEnableWorksInArea.UseVisualStyleBackColor = true;
            this.chkEnableWorksInArea.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableWorksInArea.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableWorksInArea.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableEthnicityHHMTab
            // 
            this.chkEnableEthnicityHHMTab.AutoSize = true;
            this.chkEnableEthnicityHHMTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableEthnicityHHMTab.Location = new System.Drawing.Point(14, 128);
            this.chkEnableEthnicityHHMTab.Name = "chkEnableEthnicityHHMTab";
            this.chkEnableEthnicityHHMTab.Size = new System.Drawing.Size(217, 29);
            this.chkEnableEthnicityHHMTab.TabIndex = 45;
            this.chkEnableEthnicityHHMTab.Tag = "enableethnicityhhmtab";
            this.chkEnableEthnicityHHMTab.Text = "Enable Ethnicity Tab";
            this.chkEnableEthnicityHHMTab.UseVisualStyleBackColor = true;
            this.chkEnableEthnicityHHMTab.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableEthnicityHHMTab.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableEthnicityHHMTab.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkEnableAdditionalHHMDataTab
            // 
            this.chkEnableAdditionalHHMDataTab.AutoSize = true;
            this.chkEnableAdditionalHHMDataTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableAdditionalHHMDataTab.Location = new System.Drawing.Point(14, 89);
            this.chkEnableAdditionalHHMDataTab.Name = "chkEnableAdditionalHHMDataTab";
            this.chkEnableAdditionalHHMDataTab.Size = new System.Drawing.Size(378, 29);
            this.chkEnableAdditionalHHMDataTab.TabIndex = 44;
            this.chkEnableAdditionalHHMDataTab.Tag = "enableadditionalhhmdatatab";
            this.chkEnableAdditionalHHMDataTab.Text = "Enable Additional HhMember Data Tab";
            this.chkEnableAdditionalHHMDataTab.UseVisualStyleBackColor = true;
            this.chkEnableAdditionalHHMDataTab.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkEnableAdditionalHHMDataTab.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkEnableAdditionalHHMDataTab.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tpClientOptions
            // 
            this.tpClientOptions.BackColor = System.Drawing.Color.Ivory;
            this.tpClientOptions.Controls.Add(this.cboFMIDType);
            this.tpClientOptions.Controls.Add(this.label24);
            this.tpClientOptions.Controls.Add(this.chkFilterPeriodFromAddress);
            this.tpClientOptions.Controls.Add(this.groupBox1);
            this.tpClientOptions.Controls.Add(this.chkAllowDuplicateMemberNames);
            this.tpClientOptions.Controls.Add(this.chkAllowDuplicateHHNames);
            this.tpClientOptions.Controls.Add(this.tbcDefaultZipcode);
            this.tpClientOptions.Controls.Add(this.label4);
            this.tpClientOptions.Controls.Add(this.tbcDefaultState);
            this.tpClientOptions.Controls.Add(this.label3);
            this.tpClientOptions.Controls.Add(this.tbcDefaultCity);
            this.tpClientOptions.Controls.Add(this.label2);
            this.tpClientOptions.Location = new System.Drawing.Point(4, 32);
            this.tpClientOptions.Name = "tpClientOptions";
            this.tpClientOptions.Size = new System.Drawing.Size(1358, 809);
            this.tpClientOptions.TabIndex = 3;
            this.tpClientOptions.Tag = "NewClientOptions";
            this.tpClientOptions.Text = "Add Client Options";
            // 
            // cboFMIDType
            // 
            this.cboFMIDType.FormattingEnabled = true;
            this.cboFMIDType.Location = new System.Drawing.Point(954, 37);
            this.cboFMIDType.Name = "cboFMIDType";
            this.cboFMIDType.Size = new System.Drawing.Size(310, 28);
            this.cboFMIDType.TabIndex = 121;
            this.cboFMIDType.Tag = "fiscalyearstartmonth";
            this.cboFMIDType.SelectionChangeCommitted += new System.EventHandler(this.cboFMIDType_SelectionChangeCommitted);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(678, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(261, 22);
            this.label24.TabIndex = 94;
            this.label24.Text = "Default Family Member ID Type";
            // 
            // chkFilterPeriodFromAddress
            // 
            this.chkFilterPeriodFromAddress.AutoSize = true;
            this.chkFilterPeriodFromAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterPeriodFromAddress.Location = new System.Drawing.Point(48, 572);
            this.chkFilterPeriodFromAddress.Name = "chkFilterPeriodFromAddress";
            this.chkFilterPeriodFromAddress.Size = new System.Drawing.Size(269, 29);
            this.chkFilterPeriodFromAddress.TabIndex = 93;
            this.chkFilterPeriodFromAddress.Tag = "FilterPeriodFromAddress";
            this.chkFilterPeriodFromAddress.Text = "Filter Period From Address";
            this.chkFilterPeriodFromAddress.UseVisualStyleBackColor = true;
            this.chkFilterPeriodFromAddress.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkFilterPeriodFromAddress.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkFilterPeriodFromAddress.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobNever);
            this.groupBox1.Controls.Add(this.rdobAlways);
            this.groupBox1.Controls.Add(this.rdobSometimes);
            this.groupBox1.Controls.Add(this.rdobNormally);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 188);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "usefamilylist";
            this.groupBox1.Text = "Use Family List";
            // 
            // rdobNever
            // 
            this.rdobNever.AutoSize = true;
            this.rdobNever.Location = new System.Drawing.Point(38, 145);
            this.rdobNever.Name = "rdobNever";
            this.rdobNever.Size = new System.Drawing.Size(329, 26);
            this.rdobNever.TabIndex = 92;
            this.rdobNever.Tag = "3";
            this.rdobNever.Text = "Never {family list cannot be selected}";
            this.rdobNever.UseVisualStyleBackColor = true;
            this.rdobNever.CheckedChanged += new System.EventHandler(this.rdobUseFamList_CheckedChanged);
            // 
            // rdobAlways
            // 
            this.rdobAlways.AutoSize = true;
            this.rdobAlways.Location = new System.Drawing.Point(38, 111);
            this.rdobAlways.Name = "rdobAlways";
            this.rdobAlways.Size = new System.Drawing.Size(280, 26);
            this.rdobAlways.TabIndex = 91;
            this.rdobAlways.Tag = "2";
            this.rdobAlways.Text = "Always {cannot be unchecked}";
            this.rdobAlways.UseVisualStyleBackColor = true;
            this.rdobAlways.CheckedChanged += new System.EventHandler(this.rdobUseFamList_CheckedChanged);
            // 
            // rdobSometimes
            // 
            this.rdobSometimes.AutoSize = true;
            this.rdobSometimes.Location = new System.Drawing.Point(38, 77);
            this.rdobSometimes.Name = "rdobSometimes";
            this.rdobSometimes.Size = new System.Drawing.Size(315, 26);
            this.rdobSometimes.TabIndex = 90;
            this.rdobSometimes.Tag = "1";
            this.rdobSometimes.Text = "Sometimes {defaults to unchecked}";
            this.rdobSometimes.UseVisualStyleBackColor = true;
            this.rdobSometimes.CheckedChanged += new System.EventHandler(this.rdobUseFamList_CheckedChanged);
            // 
            // rdobNormally
            // 
            this.rdobNormally.AutoSize = true;
            this.rdobNormally.Checked = true;
            this.rdobNormally.Location = new System.Drawing.Point(38, 43);
            this.rdobNormally.Name = "rdobNormally";
            this.rdobNormally.Size = new System.Drawing.Size(417, 26);
            this.rdobNormally.TabIndex = 89;
            this.rdobNormally.TabStop = true;
            this.rdobNormally.Tag = "0";
            this.rdobNormally.Text = "Normally   {defaults to checked} (recommended)";
            this.rdobNormally.UseVisualStyleBackColor = true;
            this.rdobNormally.CheckedChanged += new System.EventHandler(this.rdobUseFamList_CheckedChanged);
            // 
            // chkAllowDuplicateMemberNames
            // 
            this.chkAllowDuplicateMemberNames.AutoSize = true;
            this.chkAllowDuplicateMemberNames.Checked = true;
            this.chkAllowDuplicateMemberNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowDuplicateMemberNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowDuplicateMemberNames.Location = new System.Drawing.Point(48, 285);
            this.chkAllowDuplicateMemberNames.Name = "chkAllowDuplicateMemberNames";
            this.chkAllowDuplicateMemberNames.Size = new System.Drawing.Size(414, 29);
            this.chkAllowDuplicateMemberNames.TabIndex = 87;
            this.chkAllowDuplicateMemberNames.Tag = "AllowDuplicateMemberNames";
            this.chkAllowDuplicateMemberNames.Text = "Allow Duplicate Names for Family Members";
            this.chkAllowDuplicateMemberNames.UseVisualStyleBackColor = true;
            this.chkAllowDuplicateMemberNames.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkAllowDuplicateMemberNames.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkAllowDuplicateMemberNames.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkAllowDuplicateHHNames
            // 
            this.chkAllowDuplicateHHNames.AutoSize = true;
            this.chkAllowDuplicateHHNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowDuplicateHHNames.Location = new System.Drawing.Point(48, 234);
            this.chkAllowDuplicateHHNames.Name = "chkAllowDuplicateHHNames";
            this.chkAllowDuplicateHHNames.Size = new System.Drawing.Size(550, 29);
            this.chkAllowDuplicateHHNames.TabIndex = 86;
            this.chkAllowDuplicateHHNames.Tag = "allowduplicatehhnames";
            this.chkAllowDuplicateHHNames.Text = "Allow Duplicate Names for Households (not recommended)";
            this.chkAllowDuplicateHHNames.UseVisualStyleBackColor = true;
            this.chkAllowDuplicateHHNames.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkAllowDuplicateHHNames.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkAllowDuplicateHHNames.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tbcDefaultZipcode
            // 
            this.tbcDefaultZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.tbcDefaultZipcode, "Press ENTER to auto lookup City and State");
            this.tbcDefaultZipcode.Location = new System.Drawing.Point(195, 32);
            this.tbcDefaultZipcode.Name = "tbcDefaultZipcode";
            this.helpProvider1.SetShowHelp(this.tbcDefaultZipcode, true);
            this.tbcDefaultZipcode.Size = new System.Drawing.Size(94, 28);
            this.tbcDefaultZipcode.TabIndex = 81;
            this.tbcDefaultZipcode.Tag = "defaultzipcode";
            this.tbcDefaultZipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcDefaultZipcode.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcDefaultZipcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDefaultZipcode_KeyDown);
            this.tbcDefaultZipcode.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 80;
            this.label4.Text = "Default ZipCode";
            // 
            // tbcDefaultState
            // 
            this.tbcDefaultState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDefaultState.Location = new System.Drawing.Point(195, 131);
            this.tbcDefaultState.Name = "tbcDefaultState";
            this.tbcDefaultState.Size = new System.Drawing.Size(55, 28);
            this.tbcDefaultState.TabIndex = 85;
            this.tbcDefaultState.Tag = "defaultstate";
            this.tbcDefaultState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcDefaultState.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcDefaultState.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 84;
            this.label3.Text = "Default State";
            // 
            // tbcDefaultCity
            // 
            this.tbcDefaultCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDefaultCity.Location = new System.Drawing.Point(195, 80);
            this.tbcDefaultCity.Name = "tbcDefaultCity";
            this.tbcDefaultCity.Size = new System.Drawing.Size(235, 28);
            this.tbcDefaultCity.TabIndex = 83;
            this.tbcDefaultCity.Tag = "defaultcity";
            this.tbcDefaultCity.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcDefaultCity.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 82;
            this.label2.Text = "Default City";
            // 
            // tpFormOptions
            // 
            this.tpFormOptions.BackColor = System.Drawing.Color.Ivory;
            this.tpFormOptions.Controls.Add(this.tbcNbrSvcDatesPast);
            this.tpFormOptions.Controls.Add(this.label20);
            this.tpFormOptions.Controls.Add(this.tbcNbrSvcDatesFuture);
            this.tpFormOptions.Controls.Add(this.label19);
            this.tpFormOptions.Controls.Add(this.tbcNbrDaysAllowMods);
            this.tpFormOptions.Controls.Add(this.label18);
            this.tpFormOptions.Controls.Add(this.tbcNbrMealsPerService);
            this.tpFormOptions.Controls.Add(this.label17);
            this.tpFormOptions.Controls.Add(this.tbcApptLogRefreshRate);
            this.tpFormOptions.Controls.Add(this.label16);
            this.tpFormOptions.Controls.Add(this.tbcServiceLogRefreshRate);
            this.tpFormOptions.Controls.Add(this.label15);
            this.tpFormOptions.Controls.Add(this.chkFindClientAutoRefresh);
            this.tpFormOptions.Location = new System.Drawing.Point(4, 32);
            this.tpFormOptions.Name = "tpFormOptions";
            this.tpFormOptions.Size = new System.Drawing.Size(1358, 809);
            this.tpFormOptions.TabIndex = 4;
            this.tpFormOptions.Tag = "Form Options";
            this.tpFormOptions.Text = "Form Options";
            // 
            // tbcNbrSvcDatesPast
            // 
            this.tbcNbrSvcDatesPast.BackColor = System.Drawing.Color.White;
            this.tbcNbrSvcDatesPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcNbrSvcDatesPast.ForeColor = System.Drawing.Color.Black;
            this.tbcNbrSvcDatesPast.Location = new System.Drawing.Point(51, 397);
            this.tbcNbrSvcDatesPast.Name = "tbcNbrSvcDatesPast";
            this.tbcNbrSvcDatesPast.Size = new System.Drawing.Size(84, 28);
            this.tbcNbrSvcDatesPast.TabIndex = 111;
            this.tbcNbrSvcDatesPast.Tag = "NbrSvcDatesPast";
            this.tbcNbrSvcDatesPast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcNbrSvcDatesPast.Visible = false;
            this.tbcNbrSvcDatesPast.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcNbrSvcDatesPast.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(141, 398);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(536, 22);
            this.label20.TabIndex = 112;
            this.label20.Tag = "nbrsvcdatespast";
            this.label20.Text = "Number of Service Dates in the PAST to include on DropDown list";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Visible = false;
            // 
            // tbcNbrSvcDatesFuture
            // 
            this.tbcNbrSvcDatesFuture.BackColor = System.Drawing.Color.White;
            this.tbcNbrSvcDatesFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcNbrSvcDatesFuture.ForeColor = System.Drawing.Color.Black;
            this.tbcNbrSvcDatesFuture.Location = new System.Drawing.Point(51, 363);
            this.tbcNbrSvcDatesFuture.Name = "tbcNbrSvcDatesFuture";
            this.tbcNbrSvcDatesFuture.Size = new System.Drawing.Size(84, 28);
            this.tbcNbrSvcDatesFuture.TabIndex = 109;
            this.tbcNbrSvcDatesFuture.Tag = "NbrSvcDatesFuture";
            this.tbcNbrSvcDatesFuture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcNbrSvcDatesFuture.Visible = false;
            this.tbcNbrSvcDatesFuture.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcNbrSvcDatesFuture.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(141, 363);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(562, 22);
            this.label19.TabIndex = 110;
            this.label19.Tag = "nbrsvcdatesfuture";
            this.label19.Text = "Number of Service Dates in the FUTURE to include on DropDown list";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Visible = false;
            // 
            // tbcNbrDaysAllowMods
            // 
            this.tbcNbrDaysAllowMods.BackColor = System.Drawing.Color.White;
            this.tbcNbrDaysAllowMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcNbrDaysAllowMods.ForeColor = System.Drawing.Color.Black;
            this.tbcNbrDaysAllowMods.Location = new System.Drawing.Point(51, 277);
            this.tbcNbrDaysAllowMods.Name = "tbcNbrDaysAllowMods";
            this.tbcNbrDaysAllowMods.Size = new System.Drawing.Size(84, 28);
            this.tbcNbrDaysAllowMods.TabIndex = 107;
            this.tbcNbrDaysAllowMods.Tag = "NbrDaysAllowMods";
            this.tbcNbrDaysAllowMods.Text = "51";
            this.tbcNbrDaysAllowMods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcNbrDaysAllowMods.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcNbrDaysAllowMods.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(141, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(457, 22);
            this.label18.TabIndex = 108;
            this.label18.Tag = "nbrdaysallowmods";
            this.label18.Text = "Number of Days after service date to allow modifications";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbcNbrMealsPerService
            // 
            this.tbcNbrMealsPerService.BackColor = System.Drawing.Color.White;
            this.tbcNbrMealsPerService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcNbrMealsPerService.ForeColor = System.Drawing.Color.Black;
            this.tbcNbrMealsPerService.Location = new System.Drawing.Point(51, 228);
            this.tbcNbrMealsPerService.Name = "tbcNbrMealsPerService";
            this.tbcNbrMealsPerService.Size = new System.Drawing.Size(84, 28);
            this.tbcNbrMealsPerService.TabIndex = 105;
            this.tbcNbrMealsPerService.Tag = "NbrMealsPerService";
            this.tbcNbrMealsPerService.Text = "50";
            this.tbcNbrMealsPerService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcNbrMealsPerService.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcNbrMealsPerService.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(141, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(301, 22);
            this.label17.TabIndex = 106;
            this.label17.Tag = "nbrmealsperservice";
            this.label17.Text = "Meals per service per family member";
            // 
            // tbcApptLogRefreshRate
            // 
            this.tbcApptLogRefreshRate.BackColor = System.Drawing.Color.White;
            this.tbcApptLogRefreshRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcApptLogRefreshRate.ForeColor = System.Drawing.Color.Black;
            this.tbcApptLogRefreshRate.Location = new System.Drawing.Point(51, 137);
            this.tbcApptLogRefreshRate.Name = "tbcApptLogRefreshRate";
            this.tbcApptLogRefreshRate.Size = new System.Drawing.Size(84, 28);
            this.tbcApptLogRefreshRate.TabIndex = 103;
            this.tbcApptLogRefreshRate.Tag = "ApptLogRefreshRate";
            this.tbcApptLogRefreshRate.Text = "49";
            this.tbcApptLogRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcApptLogRefreshRate.Visible = false;
            this.tbcApptLogRefreshRate.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcApptLogRefreshRate.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(141, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(389, 22);
            this.label16.TabIndex = 104;
            this.label16.Tag = "apptlogrefreshrate";
            this.label16.Text = "Appointment Log Auto Refresh Rate in seconds";
            this.label16.Visible = false;
            // 
            // tbcServiceLogRefreshRate
            // 
            this.tbcServiceLogRefreshRate.BackColor = System.Drawing.Color.White;
            this.tbcServiceLogRefreshRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcServiceLogRefreshRate.ForeColor = System.Drawing.Color.Black;
            this.tbcServiceLogRefreshRate.Location = new System.Drawing.Point(51, 91);
            this.tbcServiceLogRefreshRate.Name = "tbcServiceLogRefreshRate";
            this.tbcServiceLogRefreshRate.Size = new System.Drawing.Size(84, 28);
            this.tbcServiceLogRefreshRate.TabIndex = 101;
            this.tbcServiceLogRefreshRate.Tag = "ServiceLogRefreshRate";
            this.tbcServiceLogRefreshRate.Text = "48";
            this.tbcServiceLogRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcServiceLogRefreshRate.Visible = false;
            this.tbcServiceLogRefreshRate.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcServiceLogRefreshRate.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(141, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(349, 22);
            this.label15.TabIndex = 102;
            this.label15.Tag = "servicelogrefreshrate";
            this.label15.Text = "Service Log Auto Refresh Rate in seconds";
            this.label15.Visible = false;
            // 
            // chkFindClientAutoRefresh
            // 
            this.chkFindClientAutoRefresh.AutoSize = true;
            this.chkFindClientAutoRefresh.Checked = true;
            this.chkFindClientAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFindClientAutoRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFindClientAutoRefresh.Location = new System.Drawing.Point(51, 38);
            this.chkFindClientAutoRefresh.Name = "chkFindClientAutoRefresh";
            this.chkFindClientAutoRefresh.Size = new System.Drawing.Size(660, 29);
            this.chkFindClientAutoRefresh.TabIndex = 100;
            this.chkFindClientAutoRefresh.Tag = "findclientautorefresh";
            this.chkFindClientAutoRefresh.Text = "Automatically Refresh the Find Client List after Adding a New Household";
            this.chkFindClientAutoRefresh.UseVisualStyleBackColor = true;
            this.chkFindClientAutoRefresh.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkFindClientAutoRefresh.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkFindClientAutoRefresh.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tpMonthlyRpts
            // 
            this.tpMonthlyRpts.BackColor = System.Drawing.Color.Ivory;
            this.tpMonthlyRpts.Controls.Add(this.tbcDonorIdFLL);
            this.tpMonthlyRpts.Controls.Add(this.label41);
            this.tpMonthlyRpts.Controls.Add(this.tbcDonorIdTEFAP);
            this.tpMonthlyRpts.Controls.Add(this.label34);
            this.tpMonthlyRpts.Controls.Add(this.tbcDonorIdEFAP);
            this.tpMonthlyRpts.Controls.Add(this.label33);
            this.tpMonthlyRpts.Controls.Add(this.tbcDonorId2ndHarvest);
            this.tpMonthlyRpts.Controls.Add(this.label32);
            this.tpMonthlyRpts.Controls.Add(this.chkMeregeTeens);
            this.tpMonthlyRpts.Controls.Add(this.tbcNWHDonorId);
            this.tpMonthlyRpts.Controls.Add(this.label12);
            this.tpMonthlyRpts.Controls.Add(this.label29);
            this.tpMonthlyRpts.Controls.Add(this.cboFiscalStartMonth);
            this.tpMonthlyRpts.Controls.Add(this.btnRptSaveFldr);
            this.tpMonthlyRpts.Controls.Add(this.tbReportsSavePath);
            this.tpMonthlyRpts.Controls.Add(this.label28);
            this.tpMonthlyRpts.Controls.Add(this.tbcPreparedBy);
            this.tpMonthlyRpts.Controls.Add(this.label27);
            this.tpMonthlyRpts.Controls.Add(this.groupBox5);
            this.tpMonthlyRpts.Controls.Add(this.chkIncludeCommodityLbsInSecondHarvestInlandNW);
            this.tpMonthlyRpts.Controls.Add(this.chkIncludeCommodityLbsInNorthwestHarvest);
            this.tpMonthlyRpts.Controls.Add(this.chkIncludeCommodityLbsInFoodLifeline);
            this.tpMonthlyRpts.Controls.Add(this.chkIncludeCommodityLbsInCoalition);
            this.tpMonthlyRpts.Controls.Add(this.tbcInkindDollarsPerLb);
            this.tpMonthlyRpts.Controls.Add(this.label22);
            this.tpMonthlyRpts.Controls.Add(this.tbcInkindDollarsPerHour);
            this.tpMonthlyRpts.Controls.Add(this.label21);
            this.tpMonthlyRpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMonthlyRpts.Location = new System.Drawing.Point(4, 32);
            this.tpMonthlyRpts.Name = "tpMonthlyRpts";
            this.tpMonthlyRpts.Size = new System.Drawing.Size(1358, 809);
            this.tpMonthlyRpts.TabIndex = 2;
            this.tpMonthlyRpts.Tag = "Monthly Report Options";
            this.tpMonthlyRpts.Text = "Monthly Reports";
            // 
            // tbcDonorIdFLL
            // 
            this.tbcDonorIdFLL.BackColor = System.Drawing.Color.White;
            this.tbcDonorIdFLL.ForeColor = System.Drawing.Color.Black;
            this.tbcDonorIdFLL.Location = new System.Drawing.Point(124, 517);
            this.tbcDonorIdFLL.Name = "tbcDonorIdFLL";
            this.tbcDonorIdFLL.Size = new System.Drawing.Size(84, 28);
            this.tbcDonorIdFLL.TabIndex = 147;
            this.tbcDonorIdFLL.Tag = "donoridfll";
            this.tbcDonorIdFLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(217, 517);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(189, 22);
            this.label41.TabIndex = 148;
            this.label41.Text = "Food Lifeline Donor ID";
            // 
            // tbcDonorIdTEFAP
            // 
            this.tbcDonorIdTEFAP.BackColor = System.Drawing.Color.White;
            this.tbcDonorIdTEFAP.ForeColor = System.Drawing.Color.Black;
            this.tbcDonorIdTEFAP.Location = new System.Drawing.Point(124, 468);
            this.tbcDonorIdTEFAP.Name = "tbcDonorIdTEFAP";
            this.tbcDonorIdTEFAP.Size = new System.Drawing.Size(84, 28);
            this.tbcDonorIdTEFAP.TabIndex = 145;
            this.tbcDonorIdTEFAP.Tag = "donoridtefap";
            this.tbcDonorIdTEFAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcDonorIdTEFAP.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcDonorIdTEFAP.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(217, 468);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(145, 22);
            this.label34.TabIndex = 146;
            this.label34.Text = "TEFAP Donor ID";
            // 
            // tbcDonorIdEFAP
            // 
            this.tbcDonorIdEFAP.BackColor = System.Drawing.Color.White;
            this.tbcDonorIdEFAP.ForeColor = System.Drawing.Color.Black;
            this.tbcDonorIdEFAP.Location = new System.Drawing.Point(124, 418);
            this.tbcDonorIdEFAP.Name = "tbcDonorIdEFAP";
            this.tbcDonorIdEFAP.Size = new System.Drawing.Size(84, 28);
            this.tbcDonorIdEFAP.TabIndex = 143;
            this.tbcDonorIdEFAP.Tag = "donoridefap";
            this.tbcDonorIdEFAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcDonorIdEFAP.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcDonorIdEFAP.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(217, 418);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 22);
            this.label33.TabIndex = 144;
            this.label33.Text = "EFAP Donor ID";
            // 
            // tbcDonorId2ndHarvest
            // 
            this.tbcDonorId2ndHarvest.BackColor = System.Drawing.Color.White;
            this.tbcDonorId2ndHarvest.ForeColor = System.Drawing.Color.Black;
            this.tbcDonorId2ndHarvest.Location = new System.Drawing.Point(124, 369);
            this.tbcDonorId2ndHarvest.Name = "tbcDonorId2ndHarvest";
            this.tbcDonorId2ndHarvest.Size = new System.Drawing.Size(84, 28);
            this.tbcDonorId2ndHarvest.TabIndex = 141;
            this.tbcDonorId2ndHarvest.Tag = "donorid2harves";
            this.tbcDonorId2ndHarvest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcDonorId2ndHarvest.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcDonorId2ndHarvest.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(217, 369);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(183, 22);
            this.label32.TabIndex = 142;
            this.label32.Text = "2nd Harvest Donor ID";
            // 
            // chkMeregeTeens
            // 
            this.chkMeregeTeens.AutoSize = true;
            this.chkMeregeTeens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeregeTeens.Location = new System.Drawing.Point(128, 722);
            this.chkMeregeTeens.Name = "chkMeregeTeens";
            this.chkMeregeTeens.Size = new System.Drawing.Size(340, 29);
            this.chkMeregeTeens.TabIndex = 140;
            this.chkMeregeTeens.Tag = "mergeteens";
            this.chkMeregeTeens.Text = "Always Merge Teens with Children";
            this.chkMeregeTeens.UseVisualStyleBackColor = true;
            this.chkMeregeTeens.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkMeregeTeens.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkMeregeTeens.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tbcNWHDonorId
            // 
            this.tbcNWHDonorId.BackColor = System.Drawing.Color.White;
            this.tbcNWHDonorId.ForeColor = System.Drawing.Color.Black;
            this.tbcNWHDonorId.Location = new System.Drawing.Point(124, 320);
            this.tbcNWHDonorId.Name = "tbcNWHDonorId";
            this.tbcNWHDonorId.Size = new System.Drawing.Size(84, 28);
            this.tbcNWHDonorId.TabIndex = 126;
            this.tbcNWHDonorId.Tag = "donoridnwh";
            this.tbcNWHDonorId.Text = "60";
            this.tbcNWHDonorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcNWHDonorId.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcNWHDonorId.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(217, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 22);
            this.label12.TabIndex = 127;
            this.label12.Text = "NWH Donor ID";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(260, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(323, 22);
            this.label29.TabIndex = 121;
            this.label29.Text = "Start Month for Fiscal Year dup/undupe";
            // 
            // cboFiscalStartMonth
            // 
            this.cboFiscalStartMonth.FormattingEnabled = true;
            this.cboFiscalStartMonth.Location = new System.Drawing.Point(96, 22);
            this.cboFiscalStartMonth.Name = "cboFiscalStartMonth";
            this.cboFiscalStartMonth.Size = new System.Drawing.Size(139, 30);
            this.cboFiscalStartMonth.TabIndex = 120;
            this.cboFiscalStartMonth.Tag = "fiscalyearstartmonth";
            this.cboFiscalStartMonth.SelectionChangeCommitted += new System.EventHandler(this.cboFiscalStartMonth_SelectionChangeCommitted);
            // 
            // btnRptSaveFldr
            // 
            this.btnRptSaveFldr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRptSaveFldr.Location = new System.Drawing.Point(76, 643);
            this.btnRptSaveFldr.Name = "btnRptSaveFldr";
            this.btnRptSaveFldr.Size = new System.Drawing.Size(40, 28);
            this.btnRptSaveFldr.TabIndex = 137;
            this.btnRptSaveFldr.Text = "---";
            this.btnRptSaveFldr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRptSaveFldr.UseVisualStyleBackColor = true;
            this.btnRptSaveFldr.Click += new System.EventHandler(this.btnRptSaveFldr_Click);
            // 
            // tbReportsSavePath
            // 
            this.tbReportsSavePath.BackColor = System.Drawing.Color.White;
            this.tbReportsSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReportsSavePath.ForeColor = System.Drawing.Color.Black;
            this.tbReportsSavePath.Location = new System.Drawing.Point(124, 643);
            this.tbReportsSavePath.Name = "tbReportsSavePath";
            this.tbReportsSavePath.Size = new System.Drawing.Size(346, 28);
            this.tbReportsSavePath.TabIndex = 138;
            this.tbReportsSavePath.Tag = "ReportsSavePath";
            this.tbReportsSavePath.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbReportsSavePath.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(477, 646);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(254, 22);
            this.label28.TabIndex = 139;
            this.label28.Text = "Save Path for Monthly Reports";
            // 
            // tbcPreparedBy
            // 
            this.tbcPreparedBy.BackColor = System.Drawing.Color.White;
            this.tbcPreparedBy.ForeColor = System.Drawing.Color.Black;
            this.tbcPreparedBy.Location = new System.Drawing.Point(124, 595);
            this.tbcPreparedBy.Name = "tbcPreparedBy";
            this.tbcPreparedBy.Size = new System.Drawing.Size(208, 28);
            this.tbcPreparedBy.TabIndex = 135;
            this.tbcPreparedBy.Tag = "PreparedBy";
            this.tbcPreparedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcPreparedBy.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcPreparedBy.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(340, 597);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(290, 22);
            this.label27.TabIndex = 136;
            this.label27.Text = "Prepared by: Auto filled on Reports";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoUseLbsDonated);
            this.groupBox5.Controls.Add(this.rdoUseLbsServed);
            this.groupBox5.Location = new System.Drawing.Point(124, 176);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 118);
            this.groupBox5.TabIndex = 128;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calculate Percent Donor Lbs";
            // 
            // rdoUseLbsDonated
            // 
            this.rdoUseLbsDonated.AutoSize = true;
            this.rdoUseLbsDonated.Location = new System.Drawing.Point(39, 74);
            this.rdoUseLbsDonated.Name = "rdoUseLbsDonated";
            this.rdoUseLbsDonated.Size = new System.Drawing.Size(250, 26);
            this.rdoUseLbsDonated.TabIndex = 130;
            this.rdoUseLbsDonated.Text = "Use Lbs Donated in Period";
            this.rdoUseLbsDonated.UseVisualStyleBackColor = true;
            // 
            // rdoUseLbsServed
            // 
            this.rdoUseLbsServed.AutoSize = true;
            this.rdoUseLbsServed.Checked = true;
            this.rdoUseLbsServed.Location = new System.Drawing.Point(39, 38);
            this.rdoUseLbsServed.Name = "rdoUseLbsServed";
            this.rdoUseLbsServed.Size = new System.Drawing.Size(239, 26);
            this.rdoUseLbsServed.TabIndex = 129;
            this.rdoUseLbsServed.TabStop = true;
            this.rdoUseLbsServed.Text = "Use Lbs Served in Period";
            this.rdoUseLbsServed.UseVisualStyleBackColor = true;
            // 
            // chkIncludeCommodityLbsInSecondHarvestInlandNW
            // 
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.AutoSize = true;
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Checked = true;
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Location = new System.Drawing.Point(505, 365);
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Name = "chkIncludeCommodityLbsInSecondHarvestInlandNW";
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Size = new System.Drawing.Size(635, 26);
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.TabIndex = 134;
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Tag = "IncludeCommodityLbsInSecondHarvestInlandNW";
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Text = "Include Commodity Lbs in Second Harvest Inland NW Total Pounds Served";
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.UseVisualStyleBackColor = true;
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkIncludeCommodityLbsInSecondHarvestInlandNW.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkIncludeCommodityLbsInNorthwestHarvest
            // 
            this.chkIncludeCommodityLbsInNorthwestHarvest.AutoSize = true;
            this.chkIncludeCommodityLbsInNorthwestHarvest.Checked = true;
            this.chkIncludeCommodityLbsInNorthwestHarvest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeCommodityLbsInNorthwestHarvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeCommodityLbsInNorthwestHarvest.Location = new System.Drawing.Point(505, 316);
            this.chkIncludeCommodityLbsInNorthwestHarvest.Name = "chkIncludeCommodityLbsInNorthwestHarvest";
            this.chkIncludeCommodityLbsInNorthwestHarvest.Size = new System.Drawing.Size(567, 26);
            this.chkIncludeCommodityLbsInNorthwestHarvest.TabIndex = 133;
            this.chkIncludeCommodityLbsInNorthwestHarvest.Tag = "IncludeCommodityLbsInNorthwestHarvest";
            this.chkIncludeCommodityLbsInNorthwestHarvest.Text = "Include Commodity Lbs in Northwest Harvest Total Pounds Served";
            this.chkIncludeCommodityLbsInNorthwestHarvest.UseVisualStyleBackColor = true;
            this.chkIncludeCommodityLbsInNorthwestHarvest.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkIncludeCommodityLbsInNorthwestHarvest.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkIncludeCommodityLbsInNorthwestHarvest.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkIncludeCommodityLbsInFoodLifeline
            // 
            this.chkIncludeCommodityLbsInFoodLifeline.AutoSize = true;
            this.chkIncludeCommodityLbsInFoodLifeline.Checked = true;
            this.chkIncludeCommodityLbsInFoodLifeline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeCommodityLbsInFoodLifeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeCommodityLbsInFoodLifeline.Location = new System.Drawing.Point(505, 519);
            this.chkIncludeCommodityLbsInFoodLifeline.Name = "chkIncludeCommodityLbsInFoodLifeline";
            this.chkIncludeCommodityLbsInFoodLifeline.Size = new System.Drawing.Size(522, 26);
            this.chkIncludeCommodityLbsInFoodLifeline.TabIndex = 132;
            this.chkIncludeCommodityLbsInFoodLifeline.Tag = "IncludeCommodityLbsInFoodLifeline";
            this.chkIncludeCommodityLbsInFoodLifeline.Text = "Include Commodity Lbs in Food Lifeline Total Pounds Served";
            this.chkIncludeCommodityLbsInFoodLifeline.UseVisualStyleBackColor = true;
            this.chkIncludeCommodityLbsInFoodLifeline.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkIncludeCommodityLbsInFoodLifeline.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkIncludeCommodityLbsInFoodLifeline.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // chkIncludeCommodityLbsInCoalition
            // 
            this.chkIncludeCommodityLbsInCoalition.AutoSize = true;
            this.chkIncludeCommodityLbsInCoalition.Checked = true;
            this.chkIncludeCommodityLbsInCoalition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeCommodityLbsInCoalition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeCommodityLbsInCoalition.Location = new System.Drawing.Point(505, 214);
            this.chkIncludeCommodityLbsInCoalition.Name = "chkIncludeCommodityLbsInCoalition";
            this.chkIncludeCommodityLbsInCoalition.Size = new System.Drawing.Size(489, 26);
            this.chkIncludeCommodityLbsInCoalition.TabIndex = 131;
            this.chkIncludeCommodityLbsInCoalition.Tag = "IncludeCommodityLbsInCoalition";
            this.chkIncludeCommodityLbsInCoalition.Text = "Include Commodity Lbs in Coalition Total Pounds Served";
            this.chkIncludeCommodityLbsInCoalition.UseVisualStyleBackColor = true;
            this.chkIncludeCommodityLbsInCoalition.CheckedChanged += new System.EventHandler(this.chkBoxes_CheckedChanged);
            this.chkIncludeCommodityLbsInCoalition.Enter += new System.EventHandler(this.chkBoxes_Enter);
            this.chkIncludeCommodityLbsInCoalition.Leave += new System.EventHandler(this.chkBoxes_Leave);
            // 
            // tbcInkindDollarsPerLb
            // 
            this.tbcInkindDollarsPerLb.BackColor = System.Drawing.Color.White;
            this.tbcInkindDollarsPerLb.ForeColor = System.Drawing.Color.Black;
            this.tbcInkindDollarsPerLb.Location = new System.Drawing.Point(124, 115);
            this.tbcInkindDollarsPerLb.Name = "tbcInkindDollarsPerLb";
            this.tbcInkindDollarsPerLb.Size = new System.Drawing.Size(84, 28);
            this.tbcInkindDollarsPerLb.TabIndex = 124;
            this.tbcInkindDollarsPerLb.Tag = "inkindDollarsPerLb";
            this.tbcInkindDollarsPerLb.Text = "60";
            this.tbcInkindDollarsPerLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcInkindDollarsPerLb.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcInkindDollarsPerLb.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(214, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(499, 22);
            this.label22.TabIndex = 125;
            this.label22.Text = "Dollars per Pound rate for Food Donations  Inkind Calculation";
            // 
            // tbcInkindDollarsPerHour
            // 
            this.tbcInkindDollarsPerHour.BackColor = System.Drawing.Color.White;
            this.tbcInkindDollarsPerHour.ForeColor = System.Drawing.Color.Black;
            this.tbcInkindDollarsPerHour.Location = new System.Drawing.Point(124, 80);
            this.tbcInkindDollarsPerHour.Name = "tbcInkindDollarsPerHour";
            this.tbcInkindDollarsPerHour.Size = new System.Drawing.Size(84, 28);
            this.tbcInkindDollarsPerHour.TabIndex = 122;
            this.tbcInkindDollarsPerHour.Tag = "inkindDollarsPerHour";
            this.tbcInkindDollarsPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbcInkindDollarsPerHour.Enter += new System.EventHandler(this.tbCntls_Enter);
            this.tbcInkindDollarsPerHour.Leave += new System.EventHandler(this.tbCntls_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(214, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(489, 22);
            this.label21.TabIndex = 123;
            this.label21.Text = "Dollars per Hour rate for Volunteer Hours  Inkind Calculation";
            // 
            // tpDonorPercent
            // 
            this.tpDonorPercent.BackColor = System.Drawing.Color.Ivory;
            this.tpDonorPercent.Controls.Add(this.lblDonorId20);
            this.tpDonorPercent.Controls.Add(this.btnDonor20);
            this.tpDonorPercent.Controls.Add(this.tbDonorId20);
            this.tpDonorPercent.Controls.Add(this.lblDonorId19);
            this.tpDonorPercent.Controls.Add(this.btnDonor19);
            this.tpDonorPercent.Controls.Add(this.tbDonorId19);
            this.tpDonorPercent.Controls.Add(this.lblDonorId18);
            this.tpDonorPercent.Controls.Add(this.btnDonor18);
            this.tpDonorPercent.Controls.Add(this.tbDonorId18);
            this.tpDonorPercent.Controls.Add(this.lblDonorId17);
            this.tpDonorPercent.Controls.Add(this.btnDonor17);
            this.tpDonorPercent.Controls.Add(this.tbDonorId17);
            this.tpDonorPercent.Controls.Add(this.lblDonorId16);
            this.tpDonorPercent.Controls.Add(this.btnDonor16);
            this.tpDonorPercent.Controls.Add(this.tbDonorId16);
            this.tpDonorPercent.Controls.Add(this.lblDonorId15);
            this.tpDonorPercent.Controls.Add(this.btnDonor15);
            this.tpDonorPercent.Controls.Add(this.tbDonorId15);
            this.tpDonorPercent.Controls.Add(this.lblDonorId14);
            this.tpDonorPercent.Controls.Add(this.btnDonor14);
            this.tpDonorPercent.Controls.Add(this.tbDonorId14);
            this.tpDonorPercent.Controls.Add(this.lblDonorId13);
            this.tpDonorPercent.Controls.Add(this.btnDonor13);
            this.tpDonorPercent.Controls.Add(this.tbDonorId13);
            this.tpDonorPercent.Controls.Add(this.lblDonorId12);
            this.tpDonorPercent.Controls.Add(this.btnDonor12);
            this.tpDonorPercent.Controls.Add(this.tbDonorId12);
            this.tpDonorPercent.Controls.Add(this.lblDonorId11);
            this.tpDonorPercent.Controls.Add(this.btnDonor11);
            this.tpDonorPercent.Controls.Add(this.tbDonorId11);
            this.tpDonorPercent.Controls.Add(this.lblDonorId10);
            this.tpDonorPercent.Controls.Add(this.lblDonorId09);
            this.tpDonorPercent.Controls.Add(this.lblDonorId08);
            this.tpDonorPercent.Controls.Add(this.lblDonorId07);
            this.tpDonorPercent.Controls.Add(this.lblDonorId06);
            this.tpDonorPercent.Controls.Add(this.lblDonorId05);
            this.tpDonorPercent.Controls.Add(this.lblDonorId04);
            this.tpDonorPercent.Controls.Add(this.lblDonorId03);
            this.tpDonorPercent.Controls.Add(this.lblDonorId02);
            this.tpDonorPercent.Controls.Add(this.lblDonorId01);
            this.tpDonorPercent.Controls.Add(this.btnDonor10);
            this.tpDonorPercent.Controls.Add(this.btnDonor09);
            this.tpDonorPercent.Controls.Add(this.btnDonor08);
            this.tpDonorPercent.Controls.Add(this.btnDonor07);
            this.tpDonorPercent.Controls.Add(this.btnDonor06);
            this.tpDonorPercent.Controls.Add(this.btnDonor05);
            this.tpDonorPercent.Controls.Add(this.btnDonor04);
            this.tpDonorPercent.Controls.Add(this.btnDonor03);
            this.tpDonorPercent.Controls.Add(this.btnDonor02);
            this.tpDonorPercent.Controls.Add(this.btnDonor01);
            this.tpDonorPercent.Controls.Add(this.tbDonorId09);
            this.tpDonorPercent.Controls.Add(this.tbDonorId10);
            this.tpDonorPercent.Controls.Add(this.tbDonorId05);
            this.tpDonorPercent.Controls.Add(this.tbDonorId06);
            this.tpDonorPercent.Controls.Add(this.tbDonorId07);
            this.tpDonorPercent.Controls.Add(this.tbDonorId08);
            this.tpDonorPercent.Controls.Add(this.tbDonorId01);
            this.tpDonorPercent.Controls.Add(this.tbDonorId02);
            this.tpDonorPercent.Controls.Add(this.tbDonorId03);
            this.tpDonorPercent.Controls.Add(this.tbDonorId04);
            this.tpDonorPercent.Location = new System.Drawing.Point(4, 32);
            this.tpDonorPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDonorPercent.Name = "tpDonorPercent";
            this.tpDonorPercent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDonorPercent.Size = new System.Drawing.Size(1358, 809);
            this.tpDonorPercent.TabIndex = 6;
            this.tpDonorPercent.Text = "Donor Percent List";
            // 
            // lblDonorId20
            // 
            this.lblDonorId20.AutoSize = true;
            this.lblDonorId20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId20.Location = new System.Drawing.Point(1000, 420);
            this.lblDonorId20.Name = "lblDonorId20";
            this.lblDonorId20.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId20.TabIndex = 280;
            this.lblDonorId20.Tag = "DonorId20";
            this.lblDonorId20.Text = ".....";
            // 
            // btnDonor20
            // 
            this.btnDonor20.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor20.Location = new System.Drawing.Point(856, 412);
            this.btnDonor20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor20.Name = "btnDonor20";
            this.btnDonor20.Size = new System.Drawing.Size(122, 34);
            this.btnDonor20.TabIndex = 220;
            this.btnDonor20.Tag = "DonorId20";
            this.btnDonor20.Text = "Donor 20";
            this.btnDonor20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor20.UseVisualStyleBackColor = false;
            this.btnDonor20.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId20
            // 
            this.tbDonorId20.BackColor = System.Drawing.Color.White;
            this.tbDonorId20.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId20.Location = new System.Drawing.Point(756, 415);
            this.tbDonorId20.Name = "tbDonorId20";
            this.tbDonorId20.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId20.TabIndex = 260;
            this.tbDonorId20.Tag = "DonorId20";
            this.tbDonorId20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId19
            // 
            this.lblDonorId19.AutoSize = true;
            this.lblDonorId19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId19.Location = new System.Drawing.Point(1000, 382);
            this.lblDonorId19.Name = "lblDonorId19";
            this.lblDonorId19.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId19.TabIndex = 279;
            this.lblDonorId19.Tag = "DonorId19";
            this.lblDonorId19.Text = ".....";
            // 
            // btnDonor19
            // 
            this.btnDonor19.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor19.Location = new System.Drawing.Point(856, 374);
            this.btnDonor19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor19.Name = "btnDonor19";
            this.btnDonor19.Size = new System.Drawing.Size(122, 34);
            this.btnDonor19.TabIndex = 219;
            this.btnDonor19.Tag = "DonorId19";
            this.btnDonor19.Text = "Donor 19";
            this.btnDonor19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor19.UseVisualStyleBackColor = false;
            this.btnDonor19.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId19
            // 
            this.tbDonorId19.BackColor = System.Drawing.Color.White;
            this.tbDonorId19.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId19.Location = new System.Drawing.Point(756, 377);
            this.tbDonorId19.Name = "tbDonorId19";
            this.tbDonorId19.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId19.TabIndex = 259;
            this.tbDonorId19.Tag = "DonorId19";
            this.tbDonorId19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId18
            // 
            this.lblDonorId18.AutoSize = true;
            this.lblDonorId18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId18.Location = new System.Drawing.Point(1000, 343);
            this.lblDonorId18.Name = "lblDonorId18";
            this.lblDonorId18.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId18.TabIndex = 278;
            this.lblDonorId18.Tag = "DonorId18";
            this.lblDonorId18.Text = ".....";
            // 
            // btnDonor18
            // 
            this.btnDonor18.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor18.Location = new System.Drawing.Point(856, 335);
            this.btnDonor18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor18.Name = "btnDonor18";
            this.btnDonor18.Size = new System.Drawing.Size(122, 34);
            this.btnDonor18.TabIndex = 218;
            this.btnDonor18.Tag = "DonorId18";
            this.btnDonor18.Text = "Donor 18";
            this.btnDonor18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor18.UseVisualStyleBackColor = false;
            this.btnDonor18.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId18
            // 
            this.tbDonorId18.BackColor = System.Drawing.Color.White;
            this.tbDonorId18.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId18.Location = new System.Drawing.Point(756, 338);
            this.tbDonorId18.Name = "tbDonorId18";
            this.tbDonorId18.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId18.TabIndex = 258;
            this.tbDonorId18.Tag = "DonorId18";
            this.tbDonorId18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId17
            // 
            this.lblDonorId17.AutoSize = true;
            this.lblDonorId17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId17.Location = new System.Drawing.Point(1000, 305);
            this.lblDonorId17.Name = "lblDonorId17";
            this.lblDonorId17.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId17.TabIndex = 277;
            this.lblDonorId17.Tag = "DonorId17";
            this.lblDonorId17.Text = ".....";
            // 
            // btnDonor17
            // 
            this.btnDonor17.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor17.Location = new System.Drawing.Point(856, 297);
            this.btnDonor17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor17.Name = "btnDonor17";
            this.btnDonor17.Size = new System.Drawing.Size(122, 34);
            this.btnDonor17.TabIndex = 217;
            this.btnDonor17.Tag = "DonorId17";
            this.btnDonor17.Text = "Donor 17";
            this.btnDonor17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor17.UseVisualStyleBackColor = false;
            this.btnDonor17.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId17
            // 
            this.tbDonorId17.BackColor = System.Drawing.Color.White;
            this.tbDonorId17.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId17.Location = new System.Drawing.Point(756, 300);
            this.tbDonorId17.Name = "tbDonorId17";
            this.tbDonorId17.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId17.TabIndex = 257;
            this.tbDonorId17.Tag = "DonorId17";
            this.tbDonorId17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId16
            // 
            this.lblDonorId16.AutoSize = true;
            this.lblDonorId16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId16.Location = new System.Drawing.Point(1000, 266);
            this.lblDonorId16.Name = "lblDonorId16";
            this.lblDonorId16.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId16.TabIndex = 276;
            this.lblDonorId16.Tag = "DonorId16";
            this.lblDonorId16.Text = ".....";
            // 
            // btnDonor16
            // 
            this.btnDonor16.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor16.Location = new System.Drawing.Point(856, 258);
            this.btnDonor16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor16.Name = "btnDonor16";
            this.btnDonor16.Size = new System.Drawing.Size(122, 34);
            this.btnDonor16.TabIndex = 216;
            this.btnDonor16.Tag = "DonorId16";
            this.btnDonor16.Text = "Donor 16";
            this.btnDonor16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor16.UseVisualStyleBackColor = false;
            this.btnDonor16.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId16
            // 
            this.tbDonorId16.BackColor = System.Drawing.Color.White;
            this.tbDonorId16.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId16.Location = new System.Drawing.Point(756, 262);
            this.tbDonorId16.Name = "tbDonorId16";
            this.tbDonorId16.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId16.TabIndex = 256;
            this.tbDonorId16.Tag = "DonorId16";
            this.tbDonorId16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId15
            // 
            this.lblDonorId15.AutoSize = true;
            this.lblDonorId15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId15.Location = new System.Drawing.Point(1000, 231);
            this.lblDonorId15.Name = "lblDonorId15";
            this.lblDonorId15.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId15.TabIndex = 275;
            this.lblDonorId15.Tag = "DonorId15";
            this.lblDonorId15.Text = ".....";
            // 
            // btnDonor15
            // 
            this.btnDonor15.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor15.Location = new System.Drawing.Point(856, 223);
            this.btnDonor15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor15.Name = "btnDonor15";
            this.btnDonor15.Size = new System.Drawing.Size(122, 34);
            this.btnDonor15.TabIndex = 215;
            this.btnDonor15.Tag = "DonorId15";
            this.btnDonor15.Text = "Donor 15";
            this.btnDonor15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor15.UseVisualStyleBackColor = false;
            this.btnDonor15.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId15
            // 
            this.tbDonorId15.BackColor = System.Drawing.Color.White;
            this.tbDonorId15.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId15.Location = new System.Drawing.Point(756, 223);
            this.tbDonorId15.Name = "tbDonorId15";
            this.tbDonorId15.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId15.TabIndex = 255;
            this.tbDonorId15.Tag = "DonorId15";
            this.tbDonorId15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId14
            // 
            this.lblDonorId14.AutoSize = true;
            this.lblDonorId14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId14.Location = new System.Drawing.Point(1000, 189);
            this.lblDonorId14.Name = "lblDonorId14";
            this.lblDonorId14.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId14.TabIndex = 274;
            this.lblDonorId14.Tag = "DonorId14";
            this.lblDonorId14.Text = ".....";
            // 
            // btnDonor14
            // 
            this.btnDonor14.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor14.Location = new System.Drawing.Point(856, 182);
            this.btnDonor14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor14.Name = "btnDonor14";
            this.btnDonor14.Size = new System.Drawing.Size(122, 34);
            this.btnDonor14.TabIndex = 214;
            this.btnDonor14.Tag = "DonorId14";
            this.btnDonor14.Text = "Donor 14";
            this.btnDonor14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor14.UseVisualStyleBackColor = false;
            this.btnDonor14.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId14
            // 
            this.tbDonorId14.BackColor = System.Drawing.Color.White;
            this.tbDonorId14.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId14.Location = new System.Drawing.Point(756, 185);
            this.tbDonorId14.Name = "tbDonorId14";
            this.tbDonorId14.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId14.TabIndex = 254;
            this.tbDonorId14.Tag = "DonorId14";
            this.tbDonorId14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId13
            // 
            this.lblDonorId13.AutoSize = true;
            this.lblDonorId13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId13.Location = new System.Drawing.Point(1000, 151);
            this.lblDonorId13.Name = "lblDonorId13";
            this.lblDonorId13.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId13.TabIndex = 273;
            this.lblDonorId13.Tag = "DonorId13";
            this.lblDonorId13.Text = ".....";
            // 
            // btnDonor13
            // 
            this.btnDonor13.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor13.Location = new System.Drawing.Point(856, 143);
            this.btnDonor13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor13.Name = "btnDonor13";
            this.btnDonor13.Size = new System.Drawing.Size(122, 34);
            this.btnDonor13.TabIndex = 213;
            this.btnDonor13.Tag = "DonorId13";
            this.btnDonor13.Text = "Donor 13";
            this.btnDonor13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor13.UseVisualStyleBackColor = false;
            this.btnDonor13.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId13
            // 
            this.tbDonorId13.BackColor = System.Drawing.Color.White;
            this.tbDonorId13.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId13.Location = new System.Drawing.Point(756, 146);
            this.tbDonorId13.Name = "tbDonorId13";
            this.tbDonorId13.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId13.TabIndex = 253;
            this.tbDonorId13.Tag = "DonorId13";
            this.tbDonorId13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId12
            // 
            this.lblDonorId12.AutoSize = true;
            this.lblDonorId12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId12.Location = new System.Drawing.Point(1000, 112);
            this.lblDonorId12.Name = "lblDonorId12";
            this.lblDonorId12.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId12.TabIndex = 272;
            this.lblDonorId12.Tag = "DonorId12";
            this.lblDonorId12.Text = ".....";
            // 
            // btnDonor12
            // 
            this.btnDonor12.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor12.Location = new System.Drawing.Point(856, 105);
            this.btnDonor12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor12.Name = "btnDonor12";
            this.btnDonor12.Size = new System.Drawing.Size(122, 34);
            this.btnDonor12.TabIndex = 212;
            this.btnDonor12.Tag = "DonorId12";
            this.btnDonor12.Text = "Donor 12";
            this.btnDonor12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor12.UseVisualStyleBackColor = false;
            this.btnDonor12.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId12
            // 
            this.tbDonorId12.BackColor = System.Drawing.Color.White;
            this.tbDonorId12.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId12.Location = new System.Drawing.Point(756, 108);
            this.tbDonorId12.Name = "tbDonorId12";
            this.tbDonorId12.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId12.TabIndex = 252;
            this.tbDonorId12.Tag = "DonorId12";
            this.tbDonorId12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId11
            // 
            this.lblDonorId11.AutoSize = true;
            this.lblDonorId11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId11.Location = new System.Drawing.Point(1000, 74);
            this.lblDonorId11.Name = "lblDonorId11";
            this.lblDonorId11.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId11.TabIndex = 271;
            this.lblDonorId11.Tag = "DonorId11";
            this.lblDonorId11.Text = ".....";
            // 
            // btnDonor11
            // 
            this.btnDonor11.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor11.Location = new System.Drawing.Point(856, 66);
            this.btnDonor11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor11.Name = "btnDonor11";
            this.btnDonor11.Size = new System.Drawing.Size(122, 34);
            this.btnDonor11.TabIndex = 211;
            this.btnDonor11.Tag = "DonorId11";
            this.btnDonor11.Text = "Donor 11";
            this.btnDonor11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor11.UseVisualStyleBackColor = false;
            this.btnDonor11.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId11
            // 
            this.tbDonorId11.BackColor = System.Drawing.Color.White;
            this.tbDonorId11.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId11.Location = new System.Drawing.Point(756, 69);
            this.tbDonorId11.Name = "tbDonorId11";
            this.tbDonorId11.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId11.TabIndex = 251;
            this.tbDonorId11.Tag = "DonorId11";
            this.tbDonorId11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // lblDonorId10
            // 
            this.lblDonorId10.AutoSize = true;
            this.lblDonorId10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId10.Location = new System.Drawing.Point(315, 420);
            this.lblDonorId10.Name = "lblDonorId10";
            this.lblDonorId10.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId10.TabIndex = 270;
            this.lblDonorId10.Tag = "DonorId10";
            this.lblDonorId10.Text = ".....";
            // 
            // lblDonorId09
            // 
            this.lblDonorId09.AutoSize = true;
            this.lblDonorId09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId09.Location = new System.Drawing.Point(315, 382);
            this.lblDonorId09.Name = "lblDonorId09";
            this.lblDonorId09.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId09.TabIndex = 268;
            this.lblDonorId09.Tag = "DonorId09";
            this.lblDonorId09.Text = ".....";
            // 
            // lblDonorId08
            // 
            this.lblDonorId08.AutoSize = true;
            this.lblDonorId08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId08.Location = new System.Drawing.Point(315, 340);
            this.lblDonorId08.Name = "lblDonorId08";
            this.lblDonorId08.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId08.TabIndex = 268;
            this.lblDonorId08.Tag = "DonorId08";
            this.lblDonorId08.Text = ".....";
            // 
            // lblDonorId07
            // 
            this.lblDonorId07.AutoSize = true;
            this.lblDonorId07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId07.Location = new System.Drawing.Point(315, 302);
            this.lblDonorId07.Name = "lblDonorId07";
            this.lblDonorId07.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId07.TabIndex = 267;
            this.lblDonorId07.Tag = "DonorId07";
            this.lblDonorId07.Text = ".....";
            // 
            // lblDonorId06
            // 
            this.lblDonorId06.AutoSize = true;
            this.lblDonorId06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId06.Location = new System.Drawing.Point(315, 266);
            this.lblDonorId06.Name = "lblDonorId06";
            this.lblDonorId06.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId06.TabIndex = 266;
            this.lblDonorId06.Tag = "DonorId06";
            this.lblDonorId06.Text = ".....";
            // 
            // lblDonorId05
            // 
            this.lblDonorId05.AutoSize = true;
            this.lblDonorId05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId05.Location = new System.Drawing.Point(315, 228);
            this.lblDonorId05.Name = "lblDonorId05";
            this.lblDonorId05.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId05.TabIndex = 265;
            this.lblDonorId05.Tag = "DonorId05";
            this.lblDonorId05.Text = ".....";
            // 
            // lblDonorId04
            // 
            this.lblDonorId04.AutoSize = true;
            this.lblDonorId04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId04.Location = new System.Drawing.Point(315, 186);
            this.lblDonorId04.Name = "lblDonorId04";
            this.lblDonorId04.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId04.TabIndex = 264;
            this.lblDonorId04.Tag = "DonorId04";
            this.lblDonorId04.Text = ".....";
            // 
            // lblDonorId03
            // 
            this.lblDonorId03.AutoSize = true;
            this.lblDonorId03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId03.Location = new System.Drawing.Point(315, 148);
            this.lblDonorId03.Name = "lblDonorId03";
            this.lblDonorId03.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId03.TabIndex = 263;
            this.lblDonorId03.Tag = "DonorId03";
            this.lblDonorId03.Text = ".....";
            // 
            // lblDonorId02
            // 
            this.lblDonorId02.AutoSize = true;
            this.lblDonorId02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId02.Location = new System.Drawing.Point(315, 109);
            this.lblDonorId02.Name = "lblDonorId02";
            this.lblDonorId02.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId02.TabIndex = 262;
            this.lblDonorId02.Tag = "DonorId02";
            this.lblDonorId02.Text = ".....";
            // 
            // lblDonorId01
            // 
            this.lblDonorId01.AutoSize = true;
            this.lblDonorId01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorId01.Location = new System.Drawing.Point(315, 71);
            this.lblDonorId01.Name = "lblDonorId01";
            this.lblDonorId01.Size = new System.Drawing.Size(35, 22);
            this.lblDonorId01.TabIndex = 261;
            this.lblDonorId01.Tag = "DonorId01";
            this.lblDonorId01.Text = ".....";
            // 
            // btnDonor10
            // 
            this.btnDonor10.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor10.Location = new System.Drawing.Point(171, 412);
            this.btnDonor10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor10.Name = "btnDonor10";
            this.btnDonor10.Size = new System.Drawing.Size(122, 34);
            this.btnDonor10.TabIndex = 210;
            this.btnDonor10.Tag = "DonorId10";
            this.btnDonor10.Text = "Donor 10";
            this.btnDonor10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor10.UseVisualStyleBackColor = false;
            this.btnDonor10.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor09
            // 
            this.btnDonor09.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor09.Location = new System.Drawing.Point(171, 374);
            this.btnDonor09.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor09.Name = "btnDonor09";
            this.btnDonor09.Size = new System.Drawing.Size(122, 34);
            this.btnDonor09.TabIndex = 209;
            this.btnDonor09.Tag = "DonorId09";
            this.btnDonor09.Text = "Donor 09";
            this.btnDonor09.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor09.UseVisualStyleBackColor = false;
            this.btnDonor09.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor08
            // 
            this.btnDonor08.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor08.Location = new System.Drawing.Point(171, 335);
            this.btnDonor08.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor08.Name = "btnDonor08";
            this.btnDonor08.Size = new System.Drawing.Size(122, 34);
            this.btnDonor08.TabIndex = 208;
            this.btnDonor08.Tag = "DonorId08";
            this.btnDonor08.Text = "Donor 08";
            this.btnDonor08.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor08.UseVisualStyleBackColor = false;
            this.btnDonor08.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor07
            // 
            this.btnDonor07.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor07.Location = new System.Drawing.Point(171, 297);
            this.btnDonor07.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor07.Name = "btnDonor07";
            this.btnDonor07.Size = new System.Drawing.Size(122, 34);
            this.btnDonor07.TabIndex = 207;
            this.btnDonor07.Tag = "DonorId07";
            this.btnDonor07.Text = "Donor 07";
            this.btnDonor07.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor07.UseVisualStyleBackColor = false;
            this.btnDonor07.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor06
            // 
            this.btnDonor06.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor06.Location = new System.Drawing.Point(171, 258);
            this.btnDonor06.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor06.Name = "btnDonor06";
            this.btnDonor06.Size = new System.Drawing.Size(122, 34);
            this.btnDonor06.TabIndex = 206;
            this.btnDonor06.Tag = "DonorId06";
            this.btnDonor06.Text = "Donor 06";
            this.btnDonor06.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor06.UseVisualStyleBackColor = false;
            this.btnDonor06.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor05
            // 
            this.btnDonor05.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor05.Location = new System.Drawing.Point(171, 220);
            this.btnDonor05.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor05.Name = "btnDonor05";
            this.btnDonor05.Size = new System.Drawing.Size(122, 34);
            this.btnDonor05.TabIndex = 205;
            this.btnDonor05.Tag = "DonorId05";
            this.btnDonor05.Text = "Donor 05";
            this.btnDonor05.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor05.UseVisualStyleBackColor = false;
            this.btnDonor05.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor04
            // 
            this.btnDonor04.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor04.Location = new System.Drawing.Point(171, 182);
            this.btnDonor04.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor04.Name = "btnDonor04";
            this.btnDonor04.Size = new System.Drawing.Size(122, 34);
            this.btnDonor04.TabIndex = 204;
            this.btnDonor04.Tag = "DonorId04";
            this.btnDonor04.Text = "Donor 04";
            this.btnDonor04.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor04.UseVisualStyleBackColor = false;
            this.btnDonor04.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor03
            // 
            this.btnDonor03.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor03.Location = new System.Drawing.Point(171, 143);
            this.btnDonor03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor03.Name = "btnDonor03";
            this.btnDonor03.Size = new System.Drawing.Size(122, 34);
            this.btnDonor03.TabIndex = 203;
            this.btnDonor03.Tag = "DonorId03";
            this.btnDonor03.Text = "Donor 03";
            this.btnDonor03.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor03.UseVisualStyleBackColor = false;
            this.btnDonor03.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor02
            // 
            this.btnDonor02.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor02.Location = new System.Drawing.Point(171, 105);
            this.btnDonor02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor02.Name = "btnDonor02";
            this.btnDonor02.Size = new System.Drawing.Size(122, 34);
            this.btnDonor02.TabIndex = 202;
            this.btnDonor02.Tag = "DonorId02";
            this.btnDonor02.Text = "Donor 02";
            this.btnDonor02.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor02.UseVisualStyleBackColor = false;
            this.btnDonor02.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnDonor01
            // 
            this.btnDonor01.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDonor01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonor01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor01.Location = new System.Drawing.Point(171, 66);
            this.btnDonor01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonor01.Name = "btnDonor01";
            this.btnDonor01.Size = new System.Drawing.Size(122, 34);
            this.btnDonor01.TabIndex = 201;
            this.btnDonor01.Tag = "DonorId01";
            this.btnDonor01.Text = "Donor 01";
            this.btnDonor01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonor01.UseVisualStyleBackColor = false;
            this.btnDonor01.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // tbDonorId09
            // 
            this.tbDonorId09.BackColor = System.Drawing.Color.White;
            this.tbDonorId09.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId09.Location = new System.Drawing.Point(70, 377);
            this.tbDonorId09.Name = "tbDonorId09";
            this.tbDonorId09.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId09.TabIndex = 249;
            this.tbDonorId09.Tag = "DonorId09";
            this.tbDonorId09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId09.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId10
            // 
            this.tbDonorId10.BackColor = System.Drawing.Color.White;
            this.tbDonorId10.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId10.Location = new System.Drawing.Point(70, 415);
            this.tbDonorId10.Name = "tbDonorId10";
            this.tbDonorId10.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId10.TabIndex = 250;
            this.tbDonorId10.Tag = "DonorId10";
            this.tbDonorId10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId05
            // 
            this.tbDonorId05.BackColor = System.Drawing.Color.White;
            this.tbDonorId05.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId05.Location = new System.Drawing.Point(70, 223);
            this.tbDonorId05.Name = "tbDonorId05";
            this.tbDonorId05.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId05.TabIndex = 245;
            this.tbDonorId05.Tag = "DonorId05";
            this.tbDonorId05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId05.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId06
            // 
            this.tbDonorId06.BackColor = System.Drawing.Color.White;
            this.tbDonorId06.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId06.Location = new System.Drawing.Point(70, 262);
            this.tbDonorId06.Name = "tbDonorId06";
            this.tbDonorId06.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId06.TabIndex = 246;
            this.tbDonorId06.Tag = "DonorId06";
            this.tbDonorId06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId06.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId07
            // 
            this.tbDonorId07.BackColor = System.Drawing.Color.White;
            this.tbDonorId07.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId07.Location = new System.Drawing.Point(70, 300);
            this.tbDonorId07.Name = "tbDonorId07";
            this.tbDonorId07.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId07.TabIndex = 247;
            this.tbDonorId07.Tag = "DonorId07";
            this.tbDonorId07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId07.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId08
            // 
            this.tbDonorId08.BackColor = System.Drawing.Color.White;
            this.tbDonorId08.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId08.Location = new System.Drawing.Point(70, 338);
            this.tbDonorId08.Name = "tbDonorId08";
            this.tbDonorId08.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId08.TabIndex = 248;
            this.tbDonorId08.Tag = "DonorId08";
            this.tbDonorId08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId08.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId01
            // 
            this.tbDonorId01.BackColor = System.Drawing.Color.White;
            this.tbDonorId01.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId01.Location = new System.Drawing.Point(70, 69);
            this.tbDonorId01.Name = "tbDonorId01";
            this.tbDonorId01.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId01.TabIndex = 241;
            this.tbDonorId01.Tag = "DonorId01";
            this.tbDonorId01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId01.Enter += new System.EventHandler(this.tbDonor_Enter);
            this.tbDonorId01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId02
            // 
            this.tbDonorId02.BackColor = System.Drawing.Color.White;
            this.tbDonorId02.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId02.Location = new System.Drawing.Point(70, 108);
            this.tbDonorId02.Name = "tbDonorId02";
            this.tbDonorId02.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId02.TabIndex = 242;
            this.tbDonorId02.Tag = "DonorId02";
            this.tbDonorId02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId03
            // 
            this.tbDonorId03.BackColor = System.Drawing.Color.White;
            this.tbDonorId03.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId03.Location = new System.Drawing.Point(70, 146);
            this.tbDonorId03.Name = "tbDonorId03";
            this.tbDonorId03.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId03.TabIndex = 243;
            this.tbDonorId03.Tag = "DonorId03";
            this.tbDonorId03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId03.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // tbDonorId04
            // 
            this.tbDonorId04.BackColor = System.Drawing.Color.White;
            this.tbDonorId04.ForeColor = System.Drawing.Color.Black;
            this.tbDonorId04.Location = new System.Drawing.Point(70, 185);
            this.tbDonorId04.Name = "tbDonorId04";
            this.tbDonorId04.Size = new System.Drawing.Size(84, 26);
            this.tbDonorId04.TabIndex = 244;
            this.tbDonorId04.Tag = "DonorId04";
            this.tbDonorId04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDonorId04.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonor_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblToolTip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 845);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 37);
            this.panel2.TabIndex = 1;
            // 
            // lblToolTip
            // 
            this.lblToolTip.BackColor = System.Drawing.Color.Cornsilk;
            this.lblToolTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToolTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolTip.Location = new System.Drawing.Point(0, 0);
            this.lblToolTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToolTip.Name = "lblToolTip";
            this.lblToolTip.Size = new System.Drawing.Size(1366, 37);
            this.lblToolTip.TabIndex = 0;
            this.lblToolTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkAlertOAMsgON
            // 
            this.chkAlertOAMsgON.AutoSize = true;
            this.chkAlertOAMsgON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlertOAMsgON.Location = new System.Drawing.Point(688, 554);
            this.chkAlertOAMsgON.Name = "chkAlertOAMsgON";
            this.chkAlertOAMsgON.Size = new System.Drawing.Size(228, 29);
            this.chkAlertOAMsgON.TabIndex = 121;
            this.chkAlertOAMsgON.Tag = "alertoamsgon";
            this.chkAlertOAMsgON.Text = "Out of Area Alerts ON";
            this.chkAlertOAMsgON.UseVisualStyleBackColor = true;
            // 
            // tbcAlertOAMessageText
            // 
            this.tbcAlertOAMessageText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAlertOAMessageText.Location = new System.Drawing.Point(766, 597);
            this.tbcAlertOAMessageText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAlertOAMessageText.Name = "tbcAlertOAMessageText";
            this.tbcAlertOAMessageText.Size = new System.Drawing.Size(517, 29);
            this.tbcAlertOAMessageText.TabIndex = 122;
            this.tbcAlertOAMessageText.Tag = "AlertOAMessageText";
            this.tbcAlertOAMessageText.Text = "Out of Area client – can only shop Wednesdays from 4-7";
            // 
            // EditPreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 882);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPreferencesForm";
            this.Text = "Edit Preferences";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditPreferencesForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.chkBackPack.ResumeLayout(false);
            this.chkBackPack.PerformLayout();
            this.tpFeatures.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpgGeneral.ResumeLayout(false);
            this.tpgGeneral.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpViewGRBy.ResumeLayout(false);
            this.grpViewGRBy.PerformLayout();
            this.tpgMainForm.ResumeLayout(false);
            this.tpgMainForm.PerformLayout();
            this.tpgAlerts.ResumeLayout(false);
            this.tpgAlerts.PerformLayout();
            this.grpOutofArea.ResumeLayout(false);
            this.grpOutofArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertMonthSvc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertWeekSvc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertMinimumMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOoAAlertMinimumDays)).EndInit();
            this.grpAll.ResumeLayout(false);
            this.grpAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertMonthSvc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertWeekSvc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertMinimumMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertMinimumDays)).EndInit();
            this.grpbxOverRideLevel.ResumeLayout(false);
            this.grpbxOverRideLevel.PerformLayout();
            this.tpgFoodSvcs.ResumeLayout(false);
            this.tpgFoodSvcs.PerformLayout();
            this.tpgPoints.ResumeLayout(false);
            this.tpgPoints.PerformLayout();
            this.tpgFamilyMem.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpClientOptions.ResumeLayout(false);
            this.tpClientOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpFormOptions.ResumeLayout(false);
            this.tpFormOptions.PerformLayout();
            this.tpMonthlyRpts.ResumeLayout(false);
            this.tpMonthlyRpts.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tpDonorPercent.ResumeLayout(false);
            this.tpDonorPercent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chkBackPack;
        private System.Windows.Forms.TextBox tbcFoodBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpClientOptions;
        private System.Windows.Forms.TabPage tpFormOptions;
        private System.Windows.Forms.TextBox tbcPostalAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbcEmailAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbcPhysicalAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbcDefaultZipcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcDefaultState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcDefaultCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobNormally;
        private System.Windows.Forms.CheckBox chkAllowDuplicateMemberNames;
        private System.Windows.Forms.CheckBox chkAllowDuplicateHHNames;
        private System.Windows.Forms.RadioButton rdobNever;
        private System.Windows.Forms.RadioButton rdobAlways;
        private System.Windows.Forms.RadioButton rdobSometimes;
        private System.Windows.Forms.TextBox tbcServiceLogRefreshRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkFindClientAutoRefresh;
        private System.Windows.Forms.TextBox tbcNbrSvcDatesPast;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbcNbrSvcDatesFuture;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbcNbrDaysAllowMods;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbcNbrMealsPerService;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbcApptLogRefreshRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbcFaxNum;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbcCounty;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabPage tpMonthlyRpts;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboFiscalStartMonth;
        private System.Windows.Forms.Button btnRptSaveFldr;
        private System.Windows.Forms.TextBox tbReportsSavePath;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbcPreparedBy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoUseLbsDonated;
        private System.Windows.Forms.RadioButton rdoUseLbsServed;
        private System.Windows.Forms.CheckBox chkIncludeCommodityLbsInSecondHarvestInlandNW;
        private System.Windows.Forms.CheckBox chkIncludeCommodityLbsInNorthwestHarvest;
        private System.Windows.Forms.CheckBox chkIncludeCommodityLbsInFoodLifeline;
        private System.Windows.Forms.CheckBox chkIncludeCommodityLbsInCoalition;
        private System.Windows.Forms.TextBox tbcInkindDollarsPerLb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbcInkindDollarsPerHour;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tpDonorPercent;
        private System.Windows.Forms.Label lblDonorId20;
        private System.Windows.Forms.Button btnDonor20;
        private System.Windows.Forms.TextBox tbDonorId20;
        private System.Windows.Forms.Label lblDonorId19;
        private System.Windows.Forms.Button btnDonor19;
        private System.Windows.Forms.TextBox tbDonorId19;
        private System.Windows.Forms.Label lblDonorId18;
        private System.Windows.Forms.Button btnDonor18;
        private System.Windows.Forms.TextBox tbDonorId18;
        private System.Windows.Forms.Label lblDonorId17;
        private System.Windows.Forms.Button btnDonor17;
        private System.Windows.Forms.TextBox tbDonorId17;
        private System.Windows.Forms.Label lblDonorId16;
        private System.Windows.Forms.Button btnDonor16;
        private System.Windows.Forms.TextBox tbDonorId16;
        private System.Windows.Forms.Label lblDonorId15;
        private System.Windows.Forms.Button btnDonor15;
        private System.Windows.Forms.TextBox tbDonorId15;
        private System.Windows.Forms.Label lblDonorId14;
        private System.Windows.Forms.Button btnDonor14;
        private System.Windows.Forms.TextBox tbDonorId14;
        private System.Windows.Forms.Label lblDonorId13;
        private System.Windows.Forms.Button btnDonor13;
        private System.Windows.Forms.TextBox tbDonorId13;
        private System.Windows.Forms.Label lblDonorId12;
        private System.Windows.Forms.Button btnDonor12;
        private System.Windows.Forms.TextBox tbDonorId12;
        private System.Windows.Forms.Label lblDonorId11;
        private System.Windows.Forms.Button btnDonor11;
        private System.Windows.Forms.TextBox tbDonorId11;
        private System.Windows.Forms.Label lblDonorId10;
        private System.Windows.Forms.Label lblDonorId09;
        private System.Windows.Forms.Label lblDonorId08;
        private System.Windows.Forms.Label lblDonorId07;
        private System.Windows.Forms.Label lblDonorId06;
        private System.Windows.Forms.Label lblDonorId05;
        private System.Windows.Forms.Label lblDonorId04;
        private System.Windows.Forms.Label lblDonorId03;
        private System.Windows.Forms.Label lblDonorId02;
        private System.Windows.Forms.Label lblDonorId01;
        private System.Windows.Forms.Button btnDonor10;
        private System.Windows.Forms.Button btnDonor09;
        private System.Windows.Forms.Button btnDonor08;
        private System.Windows.Forms.Button btnDonor07;
        private System.Windows.Forms.Button btnDonor06;
        private System.Windows.Forms.Button btnDonor05;
        private System.Windows.Forms.Button btnDonor04;
        private System.Windows.Forms.Button btnDonor03;
        private System.Windows.Forms.Button btnDonor02;
        private System.Windows.Forms.Button btnDonor01;
        private System.Windows.Forms.TextBox tbDonorId09;
        private System.Windows.Forms.TextBox tbDonorId10;
        private System.Windows.Forms.TextBox tbDonorId05;
        private System.Windows.Forms.TextBox tbDonorId06;
        private System.Windows.Forms.TextBox tbDonorId07;
        private System.Windows.Forms.TextBox tbDonorId08;
        private System.Windows.Forms.TextBox tbDonorId01;
        private System.Windows.Forms.TextBox tbDonorId02;
        private System.Windows.Forms.TextBox tbDonorId03;
        private System.Windows.Forms.TextBox tbDonorId04;
        private System.Windows.Forms.TabPage tpFeatures;
        private System.Windows.Forms.TextBox tbcNWHDonorId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkMeregeTeens;
        private System.Windows.Forms.CheckBox chkFilterPeriodFromAddress;
        private System.Windows.Forms.TextBox tbcAgencyNbr;
        private System.Windows.Forms.Label lblAgencyNbr;
        private System.Windows.Forms.CheckBox chkEnableCDBGReporting;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpgGeneral;
        private System.Windows.Forms.CheckBox chkEnablePrintClientCard;
        private System.Windows.Forms.CheckBox chkEnableClientReceipt;
        private System.Windows.Forms.CheckBox chkEnableFoodDonations;
        private System.Windows.Forms.CheckBox chkEnableAppointments;
        private System.Windows.Forms.CheckBox chkUseTimeInOutForVols;
        private System.Windows.Forms.CheckBox chkEnableVolunteerHours;
        private System.Windows.Forms.CheckBox chkEnableCashDonations;
        private System.Windows.Forms.CheckBox chkEnableVouchers;
        private System.Windows.Forms.CheckBox chkEnableHomeDeliv;
        private System.Windows.Forms.CheckBox chkAutoGiveService;
        private System.Windows.Forms.CheckBox chkSearchFamilyMember;
        private System.Windows.Forms.CheckBox chkEnableBarcodePrompts;
        private System.Windows.Forms.TabPage tpgFoodSvcs;
        private System.Windows.Forms.TextBox tbcCommSigValidFor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEnableBabyServices;
        private System.Windows.Forms.CheckBox chkEnableFoodService;
        private System.Windows.Forms.CheckBox chkEnableSupplemental;
        private System.Windows.Forms.CheckBox chkEnableTEFAP;
        private System.Windows.Forms.CheckBox chkMustBeACommodityDay;
        private System.Windows.Forms.CheckBox chkEnableCSFPOnNewSvc;
        private System.Windows.Forms.CheckBox chkEnableBackPack;
        private System.Windows.Forms.CheckBox chkEnableCSFP;
        private System.Windows.Forms.GroupBox grpViewGRBy;
        private System.Windows.Forms.RadioButton rdoViewByFullWeek;
        private System.Windows.Forms.RadioButton rdoViewByCalendarWeek;
        private System.Windows.Forms.TextBox tbcLbsPerCSFPService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToolTip;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboSvcMnuTyp;
        private System.Windows.Forms.ComboBox cboFMIDType;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox chkCaptureSignature;
        private System.Windows.Forms.TextBox tbcEFAPLeadAgency;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkCSFPShowRoutes;
        private System.Windows.Forms.CheckBox chkCaptureTEFAPSign;
        private System.Windows.Forms.TextBox tbcDonorIdTEFAP;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbcDonorIdEFAP;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbcDonorId2ndHarvest;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox chkIncludeLbsOnFoodSvcList;
        private System.Windows.Forms.TabPage tpgPoints;
        private System.Windows.Forms.TextBox tbcMaxPointsPerWeek;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbcPointsPerWeekOutOfArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbcPointsPerFamMbr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbcPointsPerWeek;
        private System.Windows.Forms.Label lblPointsAllowed;
        private System.Windows.Forms.CheckBox chkEnablePointsTracking;
        private System.Windows.Forms.CheckBox chkEnableFTScale;
        private System.Windows.Forms.CheckBox chkFTScaleLbsIncludeTEFAP;
        private System.Windows.Forms.TabPage tpgMainForm;
        private System.Windows.Forms.CheckBox chkEnableHHUserDefinedFieldsTab;
        private System.Windows.Forms.CheckBox chkEnableHUDIncomeCategory;
        private System.Windows.Forms.CheckBox chkEnableClientPhone;
        private System.Windows.Forms.CheckBox chkEnableVerifyId;
        private System.Windows.Forms.CheckBox chkEnableHouseholdIncome;
        private System.Windows.Forms.CheckBox chkEnableServiceGroups;
        private System.Windows.Forms.TabPage tpgFamilyMem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkEnableIDFlds;
        private System.Windows.Forms.CheckBox chkEnableWorksInArea;
        private System.Windows.Forms.CheckBox chkEnableEthnicityHHMTab;
        private System.Windows.Forms.CheckBox chkEnableAdditionalHHMDataTab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkEnableFastTrack;
        private System.Windows.Forms.CheckBox chkEnableSchSupply;
        private System.Windows.Forms.CheckBox chkEnableCA;
        private System.Windows.Forms.TabPage tpgAlerts;
        private System.Windows.Forms.GroupBox grpOutofArea;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown nudOoAAlertMonthSvc;
        private System.Windows.Forms.TextBox tbcOoAAlertMinMonthsText;
        private System.Windows.Forms.NumericUpDown nudOoAAlertWeekSvc;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown nudOoAAlertMinimumMonths;
        private System.Windows.Forms.TextBox tbcOoAAlertMonthSvcText;
        private System.Windows.Forms.TextBox tbcOoAAlertMinDaysText;
        private System.Windows.Forms.TextBox tbcOoAAlertWeekSvcText;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown nudOoAAlertMinimumDays;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.Label lblAlertMonthSvc;
        private System.Windows.Forms.NumericUpDown nudAlertMonthSvc;
        private System.Windows.Forms.TextBox tbcAlertMinMonthsText;
        private System.Windows.Forms.NumericUpDown nudAlertWeekSvc;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudAlertMinimumMonths;
        private System.Windows.Forms.TextBox tbcAlertMonthSvcText;
        private System.Windows.Forms.TextBox tbcAlertMinDaysText;
        private System.Windows.Forms.TextBox tbcAlertWeekSvcText;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown nudAlertMinimumDays;
        private System.Windows.Forms.CheckBox chkUseLocalOutOfAreaAlerts;
        private System.Windows.Forms.GroupBox grpbxOverRideLevel;
        private System.Windows.Forms.RadioButton rdoOverRideAdmin;
        private System.Windows.Forms.RadioButton rdoOverRideInatkeAdmin;
        private System.Windows.Forms.RadioButton rdoOverRideIntake;
        private System.Windows.Forms.CheckBox chkWarnSvcEachPerson;
        private System.Windows.Forms.TextBox tbcDonorIdFLL;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox chkAllowIntakeEditing;
        private System.Windows.Forms.CheckBox chkEnableTransportation;
        private System.Windows.Forms.TextBox tbcAlertOAMessageText;
        private System.Windows.Forms.CheckBox chkAlertOAMsgON;
    }
}