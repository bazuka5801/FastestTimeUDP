namespace FastestTimeUDP.Client.Forms
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblStatusCaption           = new System.Windows.Forms.Label();
            this.lblReceivedPackagesCaption = new System.Windows.Forms.Label();
            this.groupBox1                  = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1          = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceivedPackages        = new System.Windows.Forms.Label();
            this.lblStatus                  = new System.Windows.Forms.Label();
            this.ms                         = new System.Windows.Forms.MenuStrip();
            this.msConnect                  = new System.Windows.Forms.ToolStripMenuItem();
            this.msInfo                     = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusCaption.Location  = new System.Drawing.Point(2, 2);
            this.lblStatusCaption.Margin    = new System.Windows.Forms.Padding(0);
            this.lblStatusCaption.Name      = "lblStatusCaption";
            this.lblStatusCaption.Padding   = new System.Windows.Forms.Padding(5);
            this.lblStatusCaption.Size      = new System.Drawing.Size(174, 29);
            this.lblStatusCaption.TabIndex  = 1;
            this.lblStatusCaption.Text      = "Статус: ";
            this.lblStatusCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceivedPackagesCaption
            // 
            this.lblReceivedPackagesCaption.Location  = new System.Drawing.Point(2, 31);
            this.lblReceivedPackagesCaption.Margin    = new System.Windows.Forms.Padding(0);
            this.lblReceivedPackagesCaption.Name      = "lblReceivedPackagesCaption";
            this.lblReceivedPackagesCaption.Padding   = new System.Windows.Forms.Padding(5);
            this.lblReceivedPackagesCaption.Size      = new System.Drawing.Size(174, 29);
            this.lblReceivedPackagesCaption.TabIndex  = 1;
            this.lblReceivedPackagesCaption.Text      = "PPS:";
            this.lblReceivedPackagesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name     = "groupBox1";
            this.groupBox1.Padding  = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size     = new System.Drawing.Size(388, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop  = false;
            this.groupBox1.Text     = "Информация";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0226F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9774F));
            this.tableLayoutPanel1.Controls.Add(this.lblReceivedPackages, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblReceivedPackagesCaption, 0, 1);
            this.tableLayoutPanel1.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name     = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding  = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size     = new System.Drawing.Size(368, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblReceivedPackages
            // 
            this.lblReceivedPackages.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblReceivedPackages.Location  = new System.Drawing.Point(176, 31);
            this.lblReceivedPackages.Margin    = new System.Windows.Forms.Padding(0);
            this.lblReceivedPackages.Name      = "lblReceivedPackages";
            this.lblReceivedPackages.Padding   = new System.Windows.Forms.Padding(5);
            this.lblReceivedPackages.Size      = new System.Drawing.Size(190, 29);
            this.lblReceivedPackages.TabIndex  = 3;
            this.lblReceivedPackages.Text      = "0";
            this.lblReceivedPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location  = new System.Drawing.Point(176, 2);
            this.lblStatus.Margin    = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name      = "lblStatus";
            this.lblStatus.Padding   = new System.Windows.Forms.Padding(5);
            this.lblStatus.Size      = new System.Drawing.Size(190, 29);
            this.lblStatus.TabIndex  = 2;
            this.lblStatus.Text      = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.msConnect, this.msInfo});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name     = "ms";
            this.ms.Size     = new System.Drawing.Size(412, 24);
            this.ms.TabIndex = 3;
            this.ms.Text     = "menuStrip1";
            // 
            // msConnect
            // 
            this.msConnect.Name  =  "msConnect";
            this.msConnect.Size  =  new System.Drawing.Size(111, 20);
            this.msConnect.Text  =  "Присоединиться";
            this.msConnect.Click += new System.EventHandler(this.msConnect_Click);
            // 
            // msInfo
            // 
            this.msInfo.Name  =  "msInfo";
            this.msInfo.Size  =  new System.Drawing.Size(51, 20);
            this.msInfo.Text  =  "Инфо";
            this.msInfo.Click += new System.EventHandler(this.msInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(412, 141);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ms);
            this.Font            = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon            = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip   = this.ms;
            this.Margin          = new System.Windows.Forms.Padding(4);
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "MainForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Fastest Time - UDP";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblReceivedPackagesCaption;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblReceivedPackages;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem msInfo;
        private System.Windows.Forms.ToolStripMenuItem msConnect;
        private System.Windows.Forms.MenuStrip ms;
    }
}