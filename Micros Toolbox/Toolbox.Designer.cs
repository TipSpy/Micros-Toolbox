namespace Micros_Toolbox
{
    partial class Toolbox
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbox));
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.hostnameInput = new System.Windows.Forms.TextBox();
            this.checkStatusBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.killSarOpsBtn = new System.Windows.Forms.Button();
            this.killCalBtn = new System.Windows.Forms.Button();
            this.rebootBtn = new System.Windows.Forms.Button();
            this.LogRTB = new System.Windows.Forms.RichTextBox();
            this.startSarOpsBtn = new System.Windows.Forms.Button();
            this.getServicesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(157, 9);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(125, 15);
            this.hostnameLabel.TabIndex = 0;
            this.hostnameLabel.Text = "Terminal Hostname/IP";
            // 
            // hostnameInput
            // 
            this.hostnameInput.Location = new System.Drawing.Point(136, 27);
            this.hostnameInput.Name = "hostnameInput";
            this.hostnameInput.Size = new System.Drawing.Size(166, 23);
            this.hostnameInput.TabIndex = 1;
            this.hostnameInput.TextChanged += new System.EventHandler(this.hostnameInput_TextChanged);
            // 
            // checkStatusBtn
            // 
            this.checkStatusBtn.Location = new System.Drawing.Point(319, 26);
            this.checkStatusBtn.Name = "checkStatusBtn";
            this.checkStatusBtn.Size = new System.Drawing.Size(108, 23);
            this.checkStatusBtn.TabIndex = 2;
            this.checkStatusBtn.Text = "Connect";
            this.checkStatusBtn.UseVisualStyleBackColor = true;
            this.checkStatusBtn.Click += new System.EventHandler(this.checkStatusBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(319, 8);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 15);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Yellow;
            this.status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.status.Location = new System.Drawing.Point(367, 8);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(57, 15);
            this.status.TabIndex = 4;
            this.status.Text = "Waiting...";
            // 
            // killSarOpsBtn
            // 
            this.killSarOpsBtn.Enabled = false;
            this.killSarOpsBtn.Location = new System.Drawing.Point(12, 371);
            this.killSarOpsBtn.Name = "killSarOpsBtn";
            this.killSarOpsBtn.Size = new System.Drawing.Size(131, 67);
            this.killSarOpsBtn.TabIndex = 5;
            this.killSarOpsBtn.Text = "Kill SarOps";
            this.killSarOpsBtn.UseVisualStyleBackColor = true;
            this.killSarOpsBtn.Click += new System.EventHandler(this.killSarOpsBtn_Click);
            // 
            // killCalBtn
            // 
            this.killCalBtn.Enabled = false;
            this.killCalBtn.Location = new System.Drawing.Point(154, 371);
            this.killCalBtn.Name = "killCalBtn";
            this.killCalBtn.Size = new System.Drawing.Size(131, 67);
            this.killCalBtn.TabIndex = 6;
            this.killCalBtn.Text = "Kill CAL Client";
            this.killCalBtn.UseVisualStyleBackColor = true;
            this.killCalBtn.Click += new System.EventHandler(this.killCalBtn_Click);
            // 
            // rebootBtn
            // 
            this.rebootBtn.Location = new System.Drawing.Point(296, 371);
            this.rebootBtn.Name = "rebootBtn";
            this.rebootBtn.Size = new System.Drawing.Size(131, 67);
            this.rebootBtn.TabIndex = 7;
            this.rebootBtn.Text = "Reboot Terminal";
            this.rebootBtn.UseVisualStyleBackColor = true;
            this.rebootBtn.Click += new System.EventHandler(this.rebootBtn_Click);
            // 
            // LogRTB
            // 
            this.LogRTB.Location = new System.Drawing.Point(12, 66);
            this.LogRTB.Name = "LogRTB";
            this.LogRTB.ReadOnly = true;
            this.LogRTB.Size = new System.Drawing.Size(415, 215);
            this.LogRTB.TabIndex = 8;
            this.LogRTB.Text = "";
            // 
            // startSarOpsBtn
            // 
            this.startSarOpsBtn.Location = new System.Drawing.Point(154, 298);
            this.startSarOpsBtn.Name = "startSarOpsBtn";
            this.startSarOpsBtn.Size = new System.Drawing.Size(131, 67);
            this.startSarOpsBtn.TabIndex = 9;
            this.startSarOpsBtn.Text = "Start SarOps";
            this.startSarOpsBtn.UseVisualStyleBackColor = true;
            // 
            // getServicesBtn
            // 
            this.getServicesBtn.Location = new System.Drawing.Point(299, 298);
            this.getServicesBtn.Name = "getServicesBtn";
            this.getServicesBtn.Size = new System.Drawing.Size(128, 67);
            this.getServicesBtn.TabIndex = 10;
            this.getServicesBtn.Text = "List Services";
            this.getServicesBtn.UseVisualStyleBackColor = true;
            this.getServicesBtn.Click += new System.EventHandler(this.getServicesBtn_Click);
            // 
            // Toolbox
            // 
            this.AcceptButton = this.checkStatusBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.getServicesBtn);
            this.Controls.Add(this.startSarOpsBtn);
            this.Controls.Add(this.LogRTB);
            this.Controls.Add(this.rebootBtn);
            this.Controls.Add(this.killCalBtn);
            this.Controls.Add(this.killSarOpsBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.checkStatusBtn);
            this.Controls.Add(this.hostnameInput);
            this.Controls.Add(this.hostnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Toolbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micros Toolbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.TextBox hostnameInput;
        private System.Windows.Forms.Button checkStatusBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button killSarOpsBtn;
        private System.Windows.Forms.Button killCalBtn;
        private System.Windows.Forms.Button rebootBtn;
        private System.Windows.Forms.RichTextBox LogRTB;
        private System.Windows.Forms.Button startSarOpsBtn;
        private System.Windows.Forms.Button getServicesBtn;
    }
}

