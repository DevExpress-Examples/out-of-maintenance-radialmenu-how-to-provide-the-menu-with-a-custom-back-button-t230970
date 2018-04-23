namespace WindowsFormsApplication711 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.customRadialMenu1 = new WindowsFormsApplication711.CustomRadialMenu(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.customRadialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // customRadialMenu1
            // 
            this.customRadialMenu1.BackButtonImage = global::WindowsFormsApplication711.Properties.Resources.reset_32x32;
            this.customRadialMenu1.Glyph = global::WindowsFormsApplication711.Properties.Resources.show_32x32;
            this.customRadialMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.customRadialMenu1.Manager = this.barManager1;
            this.customRadialMenu1.Name = "customRadialMenu1";
            // 
            // barSubItem1
            // 
            this.customRadialMenu1.SetAutoSize(this.barSubItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default);
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.customRadialMenu1.SetItemAutoSize(this.barSubItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default);
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.customRadialMenu1.SetAutoSize(this.barButtonItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default);
            this.barButtonItem1.Caption = "Cut";
            this.barButtonItem1.Glyph = global::WindowsFormsApplication711.Properties.Resources.splitappointment_32x32;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.customRadialMenu1.SetAutoSize(this.barButtonItem2, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default);
            this.barButtonItem2.Caption = "Paste";
            this.barButtonItem2.Glyph = global::WindowsFormsApplication711.Properties.Resources.paste_16x16;
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = global::WindowsFormsApplication711.Properties.Resources.paste_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 455);
            this.barDockControlBottom.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 455);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(790, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 455);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(312, 402);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(163, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Click on form to show Radial Menu";
            // 
            // barButtonItem3
            // 
            this.customRadialMenu1.SetAutoSize(this.barButtonItem3, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default);
            this.barButtonItem3.Caption = "Copy";
            this.barButtonItem3.Glyph = global::WindowsFormsApplication711.Properties.Resources.copy_16x16;
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = global::WindowsFormsApplication711.Properties.Resources.copy_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.customRadialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomRadialMenu customRadialMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;

    }
}

