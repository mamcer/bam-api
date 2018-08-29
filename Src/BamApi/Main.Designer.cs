namespace BamApi
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBuildDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkCopyGeneralInfo = new System.Windows.Forms.LinkLabel();
            this.lblActivePlans = new System.Windows.Forms.Label();
            this.lblActiveProjects = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAvgPlanProject = new System.Windows.Forms.Label();
            this.lblTotalPlans = new System.Windows.Forms.Label();
            this.lblTotalProjects = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblBuildNumber = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalPlansCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalProjectsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkExportAllProjects = new System.Windows.Forms.LinkLabel();
            this.allProjectsGrid = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PlanShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AverageTimeInSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkUserName = new System.Windows.Forms.LinkLabel();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lnkBamboo = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allProjectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 75);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1157, 436);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1149, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBuildDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lnkCopyGeneralInfo);
            this.groupBox1.Controls.Add(this.lblActivePlans);
            this.groupBox1.Controls.Add(this.lblActiveProjects);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblAvgPlanProject);
            this.groupBox1.Controls.Add(this.lblTotalPlans);
            this.groupBox1.Controls.Add(this.lblTotalProjects);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.lblBuildNumber);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1141, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.AutoSize = true;
            this.lblBuildDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildDate.Location = new System.Drawing.Point(136, 86);
            this.lblBuildDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(73, 20);
            this.lblBuildDate.TabIndex = 24;
            this.lblBuildDate.Text = "loading...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Build Date";
            // 
            // lnkCopyGeneralInfo
            // 
            this.lnkCopyGeneralInfo.AutoSize = true;
            this.lnkCopyGeneralInfo.Location = new System.Drawing.Point(13, 340);
            this.lnkCopyGeneralInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkCopyGeneralInfo.Name = "lnkCopyGeneralInfo";
            this.lnkCopyGeneralInfo.Size = new System.Drawing.Size(129, 20);
            this.lnkCopyGeneralInfo.TabIndex = 5;
            this.lnkCopyGeneralInfo.TabStop = true;
            this.lnkCopyGeneralInfo.Text = "Copy to clipboard";
            this.lnkCopyGeneralInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyGeneralInfo_LinkClicked);
            // 
            // lblActivePlans
            // 
            this.lblActivePlans.AutoSize = true;
            this.lblActivePlans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivePlans.Location = new System.Drawing.Point(136, 303);
            this.lblActivePlans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivePlans.Name = "lblActivePlans";
            this.lblActivePlans.Size = new System.Drawing.Size(73, 20);
            this.lblActivePlans.TabIndex = 22;
            this.lblActivePlans.Text = "loading...";
            // 
            // lblActiveProjects
            // 
            this.lblActiveProjects.AutoSize = true;
            this.lblActiveProjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveProjects.Location = new System.Drawing.Point(136, 271);
            this.lblActiveProjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveProjects.Name = "lblActiveProjects";
            this.lblActiveProjects.Size = new System.Drawing.Size(73, 20);
            this.lblActiveProjects.TabIndex = 21;
            this.lblActiveProjects.Text = "loading...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Active Plans";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 271);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Active Projects";
            // 
            // lblAvgPlanProject
            // 
            this.lblAvgPlanProject.AutoSize = true;
            this.lblAvgPlanProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPlanProject.Location = new System.Drawing.Point(136, 236);
            this.lblAvgPlanProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvgPlanProject.Name = "lblAvgPlanProject";
            this.lblAvgPlanProject.Size = new System.Drawing.Size(73, 20);
            this.lblAvgPlanProject.TabIndex = 17;
            this.lblAvgPlanProject.Text = "loading...";
            // 
            // lblTotalPlans
            // 
            this.lblTotalPlans.AutoSize = true;
            this.lblTotalPlans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlans.Location = new System.Drawing.Point(136, 202);
            this.lblTotalPlans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPlans.Name = "lblTotalPlans";
            this.lblTotalPlans.Size = new System.Drawing.Size(73, 20);
            this.lblTotalPlans.TabIndex = 16;
            this.lblTotalPlans.Text = "loading...";
            // 
            // lblTotalProjects
            // 
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjects.Location = new System.Drawing.Point(136, 170);
            this.lblTotalProjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(73, 20);
            this.lblTotalProjects.TabIndex = 15;
            this.lblTotalProjects.Text = "loading...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Plans";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Avg Plan/Project";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total Projects";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(136, 118);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(73, 20);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "loading...";
            // 
            // lblBuildNumber
            // 
            this.lblBuildNumber.AutoSize = true;
            this.lblBuildNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildNumber.Location = new System.Drawing.Point(136, 54);
            this.lblBuildNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildNumber.Name = "lblBuildNumber";
            this.lblBuildNumber.Size = new System.Drawing.Size(73, 20);
            this.lblBuildNumber.TabIndex = 10;
            this.lblBuildNumber.Text = "loading...";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(136, 22);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(73, 20);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "loading...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Build Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bamboo Version";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalPlansCount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblTotalProjectsCount);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lnkExportAllProjects);
            this.tabPage2.Controls.Add(this.allProjectsGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1149, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalPlansCount
            // 
            this.lblTotalPlansCount.AutoSize = true;
            this.lblTotalPlansCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlansCount.Location = new System.Drawing.Point(348, 15);
            this.lblTotalPlansCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPlansCount.Name = "lblTotalPlansCount";
            this.lblTotalPlansCount.Size = new System.Drawing.Size(73, 20);
            this.lblTotalPlansCount.TabIndex = 18;
            this.lblTotalPlansCount.Text = "loading...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Plans:";
            // 
            // lblTotalProjectsCount
            // 
            this.lblTotalProjectsCount.AutoSize = true;
            this.lblTotalProjectsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjectsCount.Location = new System.Drawing.Point(115, 15);
            this.lblTotalProjectsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProjectsCount.Name = "lblTotalProjectsCount";
            this.lblTotalProjectsCount.Size = new System.Drawing.Size(73, 20);
            this.lblTotalProjectsCount.TabIndex = 16;
            this.lblTotalProjectsCount.Text = "loading...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Projects:";
            // 
            // lnkExportAllProjects
            // 
            this.lnkExportAllProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExportAllProjects.AutoSize = true;
            this.lnkExportAllProjects.Location = new System.Drawing.Point(1035, 15);
            this.lnkExportAllProjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkExportAllProjects.Name = "lnkExportAllProjects";
            this.lnkExportAllProjects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkExportAllProjects.Size = new System.Drawing.Size(100, 20);
            this.lnkExportAllProjects.TabIndex = 6;
            this.lnkExportAllProjects.TabStop = true;
            this.lnkExportAllProjects.Text = "Export to CSV";
            this.lnkExportAllProjects.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkExportAllProjects.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExportAllProjects_LinkClicked);
            // 
            // allProjectsGrid
            // 
            this.allProjectsGrid.AllowUserToAddRows = false;
            this.allProjectsGrid.AllowUserToDeleteRows = false;
            this.allProjectsGrid.AllowUserToResizeRows = false;
            this.allProjectsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allProjectsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allProjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectKey,
            this.ProjectLink,
            this.PlanShortName,
            this.PlanKey,
            this.PlanEnabled,
            this.PlanLink,
            this.AverageTimeInSeconds,
            this.Stages,
            this.Branches});
            this.allProjectsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allProjectsGrid.Location = new System.Drawing.Point(0, 42);
            this.allProjectsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.allProjectsGrid.MultiSelect = false;
            this.allProjectsGrid.Name = "allProjectsGrid";
            this.allProjectsGrid.ReadOnly = true;
            this.allProjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allProjectsGrid.ShowCellErrors = false;
            this.allProjectsGrid.ShowCellToolTips = false;
            this.allProjectsGrid.ShowEditingIcon = false;
            this.allProjectsGrid.ShowRowErrors = false;
            this.allProjectsGrid.Size = new System.Drawing.Size(1144, 355);
            this.allProjectsGrid.TabIndex = 0;
            this.allProjectsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allProjectsGrid_CellContentClick);
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 118;
            // 
            // ProjectKey
            // 
            this.ProjectKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectKey.HeaderText = "Project Key";
            this.ProjectKey.Name = "ProjectKey";
            this.ProjectKey.ReadOnly = true;
            this.ProjectKey.Width = 103;
            // 
            // ProjectLink
            // 
            this.ProjectLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectLink.HeaderText = "Project Link";
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.ReadOnly = true;
            this.ProjectLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProjectLink.TrackVisitedState = false;
            this.ProjectLink.Width = 105;
            // 
            // PlanShortName
            // 
            this.PlanShortName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlanShortName.HeaderText = "Plan Short Name";
            this.PlanShortName.Name = "PlanShortName";
            this.PlanShortName.ReadOnly = true;
            this.PlanShortName.Width = 136;
            // 
            // PlanKey
            // 
            this.PlanKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlanKey.HeaderText = "Plan Key";
            this.PlanKey.Name = "PlanKey";
            this.PlanKey.ReadOnly = true;
            this.PlanKey.Width = 87;
            // 
            // PlanEnabled
            // 
            this.PlanEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlanEnabled.HeaderText = "Plan Enabled";
            this.PlanEnabled.Name = "PlanEnabled";
            this.PlanEnabled.ReadOnly = true;
            this.PlanEnabled.Width = 114;
            // 
            // PlanLink
            // 
            this.PlanLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlanLink.HeaderText = "Plan Link";
            this.PlanLink.Name = "PlanLink";
            this.PlanLink.ReadOnly = true;
            this.PlanLink.TrackVisitedState = false;
            this.PlanLink.Width = 66;
            // 
            // AverageTimeInSeconds
            // 
            this.AverageTimeInSeconds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AverageTimeInSeconds.HeaderText = "Average Build Time";
            this.AverageTimeInSeconds.Name = "AverageTimeInSeconds";
            this.AverageTimeInSeconds.ReadOnly = true;
            this.AverageTimeInSeconds.Width = 124;
            // 
            // Stages
            // 
            this.Stages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stages.HeaderText = "Stages";
            this.Stages.Name = "Stages";
            this.Stages.ReadOnly = true;
            this.Stages.Width = 82;
            // 
            // Branches
            // 
            this.Branches.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Branches.HeaderText = "Branches";
            this.Branches.Name = "Branches";
            this.Branches.ReadOnly = true;
            this.Branches.Width = 97;
            // 
            // lnkUserName
            // 
            this.lnkUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUserName.AutoSize = true;
            this.lnkUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUserName.Location = new System.Drawing.Point(146, 39);
            this.lnkUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkUserName.Name = "lnkUserName";
            this.lnkUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkUserName.Size = new System.Drawing.Size(85, 20);
            this.lnkUserName.TabIndex = 2;
            this.lnkUserName.TabStop = true;
            this.lnkUserName.Text = "anonymous";
            this.lnkUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkUserName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUserName_LinkClicked);
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtConsole.Location = new System.Drawing.Point(1, 508);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(1151, 192);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.WordWrap = false;
            // 
            // lnkBamboo
            // 
            this.lnkBamboo.AutoSize = true;
            this.lnkBamboo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBamboo.Location = new System.Drawing.Point(146, 13);
            this.lnkBamboo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkBamboo.Name = "lnkBamboo";
            this.lnkBamboo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkBamboo.Size = new System.Drawing.Size(66, 20);
            this.lnkBamboo.TabIndex = 5;
            this.lnkBamboo.TabStop = true;
            this.lnkBamboo.Text = "bamboo";
            this.lnkBamboo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkBamboo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBamboo_LinkClicked);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "CSV (comma delimited)|*.csv";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "User:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Bamboo Instance:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 701);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnkBamboo);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lnkUserName);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bamboo API";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allProjectsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel lnkUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblBuildNumber;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvgPlanProject;
        private System.Windows.Forms.Label lblTotalPlans;
        private System.Windows.Forms.Label lblTotalProjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblActivePlans;
        private System.Windows.Forms.Label lblActiveProjects;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.LinkLabel lnkCopyGeneralInfo;
        private System.Windows.Forms.LinkLabel lnkBamboo;
        private System.Windows.Forms.Label lblBuildDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView allProjectsGrid;
        private System.Windows.Forms.Label lblTotalProjectsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkExportAllProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectKey;
        private System.Windows.Forms.DataGridViewLinkColumn ProjectLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanEnabled;
        private System.Windows.Forms.DataGridViewLinkColumn PlanLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageTimeInSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branches;
        private System.Windows.Forms.Label lblTotalPlansCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}

