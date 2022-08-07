namespace PingTTL.View {
    partial class MonitoringView {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.monitoring_box = new System.Windows.Forms.GroupBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.configBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.computer_status_lbl = new System.Windows.Forms.Label();
            this.computer_ip_lbl = new System.Windows.Forms.Label();
            this.computer_name_lbl = new System.Windows.Forms.Label();
            this.monitoring_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitoring_box
            // 
            this.monitoring_box.Controls.Add(this.reset_btn);
            this.monitoring_box.Controls.Add(this.label3);
            this.monitoring_box.Controls.Add(this.label2);
            this.monitoring_box.Controls.Add(this.label1);
            this.monitoring_box.Controls.Add(this.configBtn);
            this.monitoring_box.Controls.Add(this.quitBtn);
            this.monitoring_box.Controls.Add(this.title);
            this.monitoring_box.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitoring_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monitoring_box.Location = new System.Drawing.Point(12, 12);
            this.monitoring_box.Name = "monitoring_box";
            this.monitoring_box.Size = new System.Drawing.Size(1080, 275);
            this.monitoring_box.TabIndex = 0;
            this.monitoring_box.TabStop = false;
            this.monitoring_box.Text = "Monitoring";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset_btn.Location = new System.Drawing.Point(487, 223);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(131, 46);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "État";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // configBtn
            // 
            this.configBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.configBtn.Location = new System.Drawing.Point(6, 223);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(182, 46);
            this.configBtn.TabIndex = 1;
            this.configBtn.Text = "Configuration";
            this.configBtn.UseVisualStyleBackColor = false;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.quitBtn.Location = new System.Drawing.Point(943, 223);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(131, 46);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "Quitter";
            this.quitBtn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(480, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(161, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Ping TTL";
            // 
            // computer_status_lbl
            // 
            this.computer_status_lbl.AutoSize = true;
            this.computer_status_lbl.Font = new System.Drawing.Font("Ebrima", 16.2F);
            this.computer_status_lbl.Location = new System.Drawing.Point(829, 164);
            this.computer_status_lbl.Name = "computer_status_lbl";
            this.computer_status_lbl.Size = new System.Drawing.Size(245, 38);
            this.computer_status_lbl.TabIndex = 3;
            this.computer_status_lbl.Text = "Non Fonctionnelle";
            // 
            // computer_ip_lbl
            // 
            this.computer_ip_lbl.AutoSize = true;
            this.computer_ip_lbl.Font = new System.Drawing.Font("Ebrima", 16.2F);
            this.computer_ip_lbl.Location = new System.Drawing.Point(460, 164);
            this.computer_ip_lbl.Name = "computer_ip_lbl";
            this.computer_ip_lbl.Size = new System.Drawing.Size(200, 38);
            this.computer_ip_lbl.TabIndex = 2;
            this.computer_ip_lbl.Text = "192.168.172.25";
            // 
            // computer_name_lbl
            // 
            this.computer_name_lbl.AutoSize = true;
            this.computer_name_lbl.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_name_lbl.Location = new System.Drawing.Point(6, 164);
            this.computer_name_lbl.Name = "computer_name_lbl";
            this.computer_name_lbl.Size = new System.Drawing.Size(109, 38);
            this.computer_name_lbl.TabIndex = 1;
            this.computer_name_lbl.Text = "Socrate";
            // 
            // MonitoringView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1113, 306);
            this.Controls.Add(this.monitoring_box);
            this.Name = "MonitoringView";
            this.Text = "Form1";
            this.monitoring_box.ResumeLayout(false);
            this.monitoring_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox monitoring_box;
        private System.Windows.Forms.Label computer_status_lbl;
        private System.Windows.Forms.Label computer_ip_lbl;
        private System.Windows.Forms.Label computer_name_lbl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button reset_btn;
    }
}