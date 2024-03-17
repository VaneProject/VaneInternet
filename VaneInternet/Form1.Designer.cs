namespace VaneInternet {
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
            if (disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gateway = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subnet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dns = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "서브넷 마스크";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gateway
            // 
            this.gateway.Location = new System.Drawing.Point(109, 57);
            this.gateway.Name = "gateway";
            this.gateway.Size = new System.Drawing.Size(260, 21);
            this.gateway.TabIndex = 2;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(109, 3);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(260, 21);
            this.ip.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "게이트웨이";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subnet
            // 
            this.subnet.Location = new System.Drawing.Point(109, 30);
            this.subnet.Name = "subnet";
            this.subnet.Size = new System.Drawing.Size(260, 21);
            this.subnet.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subnet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gateway);
            this.panel1.Controls.Add(this.ip);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 133);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "기본 DNS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dns
            // 
            this.dns.Location = new System.Drawing.Point(109, 84);
            this.dns.Name = "dns";
            this.dns.Size = new System.Drawing.Size(260, 21);
            this.dns.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dns;

        private System.Windows.Forms.TextBox subnet;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox gateway;
        private System.Windows.Forms.TextBox ip;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}