using System.ComponentModel;

namespace FastestTimeUDP.Client.Forms
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FastestTimeUDP.Client.Forms.MainForm));
            this.tlpGrid        = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect     = new System.Windows.Forms.Button();
            this.tlpFormFields  = new System.Windows.Forms.TableLayoutPanel();
            this.tbPort         = new System.Windows.Forms.TextBox();
            this.lblIPCaption   = new System.Windows.Forms.Label();
            this.lblPortCaption = new System.Windows.Forms.Label();
            this.tbIP           = new System.Windows.Forms.TextBox();
            this.tlpGrid.SuspendLayout();
            this.tlpFormFields.SuspendLayout();
            this.SuspendLayout();
            this.tlpGrid.ColumnCount = 1;
            this.tlpGrid.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tlpGrid.Controls.Add(this.btnConnect, 0, 1);
            this.tlpGrid.Controls.Add(this.tlpFormFields, 0, 0);
            this.tlpGrid.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrid.Location = new System.Drawing.Point(0, 0);
            this.tlpGrid.Name     = "tlpGrid";
            this.tlpGrid.Padding  = new System.Windows.Forms.Padding(5);
            this.tlpGrid.RowCount = 2;
            this.tlpGrid.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.63918F));
            this.tlpGrid.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.36082F));
            this.tlpGrid.Size     = new System.Drawing.Size(290, 131);
            this.tlpGrid.TabIndex = 0;
            this.btnConnect.Dock  = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold,
                                                           System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnConnect.Location                =  new System.Drawing.Point(5, 81);
            this.btnConnect.Margin                  =  new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnConnect.Name                    =  "btnConnect";
            this.btnConnect.Size                    =  new System.Drawing.Size(280, 45);
            this.btnConnect.TabIndex                =  2;
            this.btnConnect.Text                    =  "Присоединиться";
            this.btnConnect.UseVisualStyleBackColor =  true;
            this.btnConnect.Click                   += new System.EventHandler(this.btnConnect_Click);
            this.tlpFormFields.ColumnCount          =  2;
            this.tlpFormFields.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.02158F));
            this.tlpFormFields.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.97842F));
            this.tlpFormFields.Controls.Add(this.tbPort, 1, 1);
            this.tlpFormFields.Controls.Add(this.lblIPCaption, 0, 0);
            this.tlpFormFields.Controls.Add(this.lblPortCaption, 0, 1);
            this.tlpFormFields.Controls.Add(this.tbIP, 1, 0);
            this.tlpFormFields.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormFields.Location = new System.Drawing.Point(5, 5);
            this.tlpFormFields.Margin   = new System.Windows.Forms.Padding(0);
            this.tlpFormFields.Name     = "tlpFormFields";
            this.tlpFormFields.RowCount = 2;
            this.tlpFormFields.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormFields.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormFields.Size       = new System.Drawing.Size(280, 66);
            this.tlpFormFields.TabIndex   = 1;
            this.tbPort.BorderStyle       = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPort.Dock              = System.Windows.Forms.DockStyle.Fill;
            this.tbPort.Location          = new System.Drawing.Point(67, 36);
            this.tbPort.Name              = "tbPort";
            this.tbPort.Size              = new System.Drawing.Size(210, 27);
            this.tbPort.TabIndex          = 1;
            this.tbPort.TextAlign         = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblIPCaption.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.lblIPCaption.Location    = new System.Drawing.Point(3, 0);
            this.lblIPCaption.Name        = "lblIPCaption";
            this.lblIPCaption.Size        = new System.Drawing.Size(58, 33);
            this.lblIPCaption.TabIndex    = 0;
            this.lblIPCaption.Text        = "IP:";
            this.lblIPCaption.TextAlign   = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPortCaption.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblPortCaption.Location  = new System.Drawing.Point(3, 33);
            this.lblPortCaption.Name      = "lblPortCaption";
            this.lblPortCaption.Size      = new System.Drawing.Size(58, 33);
            this.lblPortCaption.TabIndex  = 1;
            this.lblPortCaption.Text      = "PORT:";
            this.lblPortCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIP.BorderStyle         = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIP.Dock                = System.Windows.Forms.DockStyle.Fill;
            this.tbIP.Location            = new System.Drawing.Point(67, 3);
            this.tbIP.Name                = "tbIP";
            this.tbIP.Size                = new System.Drawing.Size(210, 27);
            this.tbIP.TabIndex            = 0;
            this.tbIP.TextAlign           = System.Windows.Forms.HorizontalAlignment.Center;
            this.AutoScaleDimensions      = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode            = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize               = new System.Drawing.Size(290, 131);
            this.Controls.Add(this.tlpGrid);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular,
                                                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon            = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin          = new System.Windows.Forms.Padding(4);
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "ConnectForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Включение";
            this.tlpGrid.ResumeLayout(false);
            this.tlpFormFields.ResumeLayout(false);
            this.tlpFormFields.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TableLayoutPanel tlpGrid;
        private System.Windows.Forms.TableLayoutPanel tlpFormFields;
        private System.Windows.Forms.Label lblIPCaption;
        private System.Windows.Forms.Label lblPortCaption;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
    }
}