namespace DevExpressTest_Mariane
{
    partial class Form1
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.claimsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.claimsGridControl = new DevExpress.XtraGrid.GridControl();
            this.claimsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.claimPropsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.claimPropertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.bottomDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.lawFirmDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.lawFirmPropsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.panelContainer2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.lawFirmGridControl = new DevExpress.XtraGrid.GridControl();
            this.lawFirmGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lawFirmPropertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.claimsDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsGridView)).BeginInit();
            this.claimPropsDockPanel.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimPropertyGridControl)).BeginInit();
            this.bottomDockPanel.SuspendLayout();
            this.lawFirmDockPanel.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            this.lawFirmPropsDockPanel.SuspendLayout();
            this.controlContainer2.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.panelContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lawFirmGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawFirmGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawFirmPropertyGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1233, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 620);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1233, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1233, 49);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.panelContainer2,
            this.bottomDockPanel});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // claimsDockPanel
            // 
            this.claimsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.claimsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.claimsDockPanel.ID = new System.Guid("c34167c2-0d41-4cb8-9838-efc5a7dfe7c0");
            this.claimsDockPanel.Location = new System.Drawing.Point(4, 23);
            this.claimsDockPanel.Name = "claimsDockPanel";
            this.claimsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.claimsDockPanel.Size = new System.Drawing.Size(191, 517);
            this.claimsDockPanel.Text = "Claims";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.claimsGridControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 517);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // claimsGridControl
            // 
            this.claimsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimsGridControl.Location = new System.Drawing.Point(0, 0);
            this.claimsGridControl.MainView = this.claimsGridView;
            this.claimsGridControl.MenuManager = this.barManager1;
            this.claimsGridControl.Name = "claimsGridControl";
            this.claimsGridControl.Size = new System.Drawing.Size(191, 517);
            this.claimsGridControl.TabIndex = 0;
            this.claimsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.claimsGridView});
            // 
            // gridView1
            // 
            this.claimsGridView.GridControl = this.claimsGridControl;
            this.claimsGridView.Name = "gridView1";
            this.claimsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.claimGridView_FocusedRowChanged);
            // 
            // claimPropsDockPanel
            // 
            this.claimPropsDockPanel.Controls.Add(this.dockPanel2_Container);
            this.claimPropsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.claimPropsDockPanel.ID = new System.Guid("d5f09d3d-fdd7-4490-8b66-2e9309ed2039");
            this.claimPropsDockPanel.Location = new System.Drawing.Point(5, 23);
            this.claimPropsDockPanel.Name = "claimPropsDockPanel";
            this.claimPropsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.claimPropsDockPanel.Size = new System.Drawing.Size(191, 517);
            this.claimPropsDockPanel.Text = "Claim Props";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.claimPropertyGridControl);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(191, 517);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // claimPropertyGridControl
            // 
            this.claimPropertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimPropertyGridControl.Location = new System.Drawing.Point(0, 0);
            this.claimPropertyGridControl.Name = "claimPropertyGridControl";
            this.claimPropertyGridControl.Size = new System.Drawing.Size(191, 517);
            this.claimPropertyGridControl.TabIndex = 0;
            // 
            // bottomDockPanel
            // 
            this.bottomDockPanel.Controls.Add(this.dockPanel3_Container);
            this.bottomDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.bottomDockPanel.ID = new System.Guid("e7b54431-a324-421b-a707-92b9d857cfa2");
            this.bottomDockPanel.Location = new System.Drawing.Point(200, 420);
            this.bottomDockPanel.Name = "bottomDockPanel";
            this.bottomDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.bottomDockPanel.Size = new System.Drawing.Size(833, 200);
            this.bottomDockPanel.Text = "#Bottom";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(825, 172);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // lawFirmDockPanel
            // 
            this.lawFirmDockPanel.Controls.Add(this.controlContainer1);
            this.lawFirmDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.lawFirmDockPanel.ID = new System.Guid("a0852b8f-e1af-4f78-b4cd-61dd973a517c");
            this.lawFirmDockPanel.Location = new System.Drawing.Point(4, 23);
            this.lawFirmDockPanel.Name = "lawFirmDockPanel";
            this.lawFirmDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.lawFirmDockPanel.Size = new System.Drawing.Size(191, 517);
            this.lawFirmDockPanel.Text = "Law Firms";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.lawFirmGridControl);
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(191, 517);
            this.controlContainer1.TabIndex = 0;
            // 
            // lawFirmPropsDockPanel
            // 
            this.lawFirmPropsDockPanel.Controls.Add(this.controlContainer2);
            this.lawFirmPropsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.lawFirmPropsDockPanel.ID = new System.Guid("6b4af8be-c17f-44e7-996b-a66c293d101c");
            this.lawFirmPropsDockPanel.Location = new System.Drawing.Point(5, 23);
            this.lawFirmPropsDockPanel.Name = "lawFirmPropsDockPanel";
            this.lawFirmPropsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.lawFirmPropsDockPanel.Size = new System.Drawing.Size(191, 517);
            this.lawFirmPropsDockPanel.Text = "Law Firm Props";
            // 
            // controlContainer2
            // 
            this.controlContainer2.Controls.Add(this.lawFirmPropertyGridControl);
            this.controlContainer2.Location = new System.Drawing.Point(0, 0);
            this.controlContainer2.Name = "controlContainer2";
            this.controlContainer2.Size = new System.Drawing.Size(191, 517);
            this.controlContainer2.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.lawFirmDockPanel;
            this.panelContainer1.Controls.Add(this.lawFirmDockPanel);
            this.panelContainer1.Controls.Add(this.claimsDockPanel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.ID = new System.Guid("2c6bc1ef-cdd2-4470-b911-b7ec804cbc50");
            this.panelContainer1.Location = new System.Drawing.Point(0, 49);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 571);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // panelContainer2
            // 
            this.panelContainer2.ActiveChild = this.lawFirmPropsDockPanel;
            this.panelContainer2.Controls.Add(this.lawFirmPropsDockPanel);
            this.panelContainer2.Controls.Add(this.claimPropsDockPanel);
            this.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer2.ID = new System.Guid("ac6d61a9-04d9-4558-95cc-8ea211d25fd1");
            this.panelContainer2.Location = new System.Drawing.Point(1033, 49);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer2.Size = new System.Drawing.Size(200, 571);
            this.panelContainer2.Tabbed = true;
            this.panelContainer2.Text = "panelContainer2";
            // 
            // lawFirmGridControl
            // 
            this.lawFirmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lawFirmGridControl.Location = new System.Drawing.Point(0, 0);
            this.lawFirmGridControl.MainView = this.lawFirmGridView;
            this.lawFirmGridControl.MenuManager = this.barManager1;
            this.lawFirmGridControl.Name = "lawFirmGridControl";
            this.lawFirmGridControl.Size = new System.Drawing.Size(191, 517);
            this.lawFirmGridControl.TabIndex = 0;
            this.lawFirmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lawFirmGridView});
            // 
            // gridView2
            // 
            this.lawFirmGridView.GridControl = this.lawFirmGridControl;
            this.lawFirmGridView.Name = "gridView2";
            this.lawFirmGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.lawFirmGridView_FocusedRowChanged);
            // 
            // lawFirmPropertyGridControl
            // 
            this.lawFirmPropertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lawFirmPropertyGridControl.Location = new System.Drawing.Point(0, 0);
            this.lawFirmPropertyGridControl.Name = "lawFirmPropertyGridControl";
            this.lawFirmPropertyGridControl.Size = new System.Drawing.Size(191, 517);
            this.lawFirmPropertyGridControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 643);
            this.Controls.Add(this.bottomDockPanel);
            this.Controls.Add(this.panelContainer2);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.claimsDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsGridView)).EndInit();
            this.claimPropsDockPanel.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimPropertyGridControl)).EndInit();
            this.bottomDockPanel.ResumeLayout(false);
            this.lawFirmDockPanel.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            this.lawFirmPropsDockPanel.ResumeLayout(false);
            this.controlContainer2.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.panelContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lawFirmGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawFirmGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawFirmPropertyGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel bottomDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel claimPropsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel claimsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl claimsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView claimsGridView;
        private DevExpress.XtraVerticalGrid.PropertyGridControl claimPropertyGridControl;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer2;
        private DevExpress.XtraBars.Docking.DockPanel lawFirmPropsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel lawFirmDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl lawFirmPropertyGridControl;
        private DevExpress.XtraGrid.GridControl lawFirmGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView lawFirmGridView;
    }
}

