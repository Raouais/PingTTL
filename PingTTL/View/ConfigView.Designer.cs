namespace PingTTL.View {
    partial class ConfigView {
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
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.step_lbl = new System.Windows.Forms.Label();
            this.nb_computers_lbl = new System.Windows.Forms.Label();
            this.nb_computers_input = new System.Windows.Forms.TextBox();
            this.enter_computers_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.ip_lbl = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.ip_input = new System.Windows.Forms.TextBox();
            this.ttl_input = new System.Windows.Forms.TextBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.email_lbl = new System.Windows.Forms.Label();
            this.from_lbl = new System.Windows.Forms.Label();
            this.to_lbl = new System.Windows.Forms.Label();
            this.subject_lbl = new System.Windows.Forms.Label();
            this.port_lbl = new System.Windows.Forms.Label();
            this.host_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.from_input = new System.Windows.Forms.TextBox();
            this.to_input = new System.Windows.Forms.TextBox();
            this.subject_input = new System.Windows.Forms.TextBox();
            this.port_input = new System.Windows.Forms.TextBox();
            this.host_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.emai_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emai_btn);
            this.groupBox1.Controls.Add(this.password_input);
            this.groupBox1.Controls.Add(this.host_input);
            this.groupBox1.Controls.Add(this.port_input);
            this.groupBox1.Controls.Add(this.subject_input);
            this.groupBox1.Controls.Add(this.to_input);
            this.groupBox1.Controls.Add(this.from_input);
            this.groupBox1.Controls.Add(this.password_lbl);
            this.groupBox1.Controls.Add(this.host_lbl);
            this.groupBox1.Controls.Add(this.port_lbl);
            this.groupBox1.Controls.Add(this.subject_lbl);
            this.groupBox1.Controls.Add(this.to_lbl);
            this.groupBox1.Controls.Add(this.from_lbl);
            this.groupBox1.Controls.Add(this.email_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurations";
            // 
            // step_lbl
            // 
            this.step_lbl.AutoSize = true;
            this.step_lbl.Location = new System.Drawing.Point(526, 42);
            this.step_lbl.Name = "step_lbl";
            this.step_lbl.Size = new System.Drawing.Size(67, 29);
            this.step_lbl.TabIndex = 3;
            this.step_lbl.Text = "Etape";
            // 
            // nb_computers_lbl
            // 
            this.nb_computers_lbl.AutoSize = true;
            this.nb_computers_lbl.Location = new System.Drawing.Point(6, 96);
            this.nb_computers_lbl.Name = "nb_computers_lbl";
            this.nb_computers_lbl.Size = new System.Drawing.Size(414, 36);
            this.nb_computers_lbl.TabIndex = 0;
            this.nb_computers_lbl.Text = "Nombre de PC à surveiller [1-8]";
            // 
            // nb_computers_input
            // 
            this.nb_computers_input.Location = new System.Drawing.Point(358, 96);
            this.nb_computers_input.Name = "nb_computers_input";
            this.nb_computers_input.Size = new System.Drawing.Size(100, 22);
            this.nb_computers_input.TabIndex = 1;
            // 
            // enter_computers_btn
            // 
            this.enter_computers_btn.Location = new System.Drawing.Point(6, 156);
            this.enter_computers_btn.Name = "enter_computers_btn";
            this.enter_computers_btn.Size = new System.Drawing.Size(116, 46);
            this.enter_computers_btn.TabIndex = 2;
            this.enter_computers_btn.Text = "Suivant";
            this.enter_computers_btn.UseVisualStyleBackColor = true;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(6, 68);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(74, 29);
            this.name_lbl.TabIndex = 4;
            this.name_lbl.Text = "Nom :";
            // 
            // ip_lbl
            // 
            this.ip_lbl.AutoSize = true;
            this.ip_lbl.Location = new System.Drawing.Point(6, 152);
            this.ip_lbl.Name = "ip_lbl";
            this.ip_lbl.Size = new System.Drawing.Size(141, 29);
            this.ip_lbl.TabIndex = 5;
            this.ip_lbl.Text = "Adresse IP :";
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.AutoSize = true;
            this.ttl_lbl.Location = new System.Drawing.Point(6, 241);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Size = new System.Drawing.Size(124, 29);
            this.ttl_lbl.TabIndex = 6;
            this.ttl_lbl.Text = "Intervalle :";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(155, 68);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(100, 22);
            this.name_input.TabIndex = 7;
            // 
            // ip_input
            // 
            this.ip_input.Location = new System.Drawing.Point(155, 146);
            this.ip_input.Name = "ip_input";
            this.ip_input.Size = new System.Drawing.Size(100, 22);
            this.ip_input.TabIndex = 8;
            // 
            // ttl_input
            // 
            this.ttl_input.Location = new System.Drawing.Point(155, 241);
            this.ttl_input.Name = "ttl_input";
            this.ttl_input.Size = new System.Drawing.Size(100, 22);
            this.ttl_input.TabIndex = 9;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(530, 282);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(119, 43);
            this.next_btn.TabIndex = 10;
            this.next_btn.Text = "Suivant";
            this.next_btn.UseVisualStyleBackColor = true;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(236, 31);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(139, 29);
            this.email_lbl.TabIndex = 0;
            this.email_lbl.Text = "Adresse mail";
            // 
            // from_lbl
            // 
            this.from_lbl.AutoSize = true;
            this.from_lbl.Location = new System.Drawing.Point(6, 94);
            this.from_lbl.Name = "from_lbl";
            this.from_lbl.Size = new System.Drawing.Size(65, 29);
            this.from_lbl.TabIndex = 1;
            this.from_lbl.Text = "De : ";
            // 
            // to_lbl
            // 
            this.to_lbl.AutoSize = true;
            this.to_lbl.Location = new System.Drawing.Point(6, 144);
            this.to_lbl.Name = "to_lbl";
            this.to_lbl.Size = new System.Drawing.Size(73, 29);
            this.to_lbl.TabIndex = 2;
            this.to_lbl.Text = "Pour :";
            // 
            // subject_lbl
            // 
            this.subject_lbl.AutoSize = true;
            this.subject_lbl.Location = new System.Drawing.Point(6, 201);
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(83, 29);
            this.subject_lbl.TabIndex = 3;
            this.subject_lbl.Text = "Sujet :";
            // 
            // port_lbl
            // 
            this.port_lbl.AutoSize = true;
            this.port_lbl.Location = new System.Drawing.Point(303, 94);
            this.port_lbl.Name = "port_lbl";
            this.port_lbl.Size = new System.Drawing.Size(72, 29);
            this.port_lbl.TabIndex = 4;
            this.port_lbl.Text = "Port :";
            // 
            // host_lbl
            // 
            this.host_lbl.AutoSize = true;
            this.host_lbl.Location = new System.Drawing.Point(303, 144);
            this.host_lbl.Name = "host_lbl";
            this.host_lbl.Size = new System.Drawing.Size(77, 29);
            this.host_lbl.TabIndex = 5;
            this.host_lbl.Text = "Hôte :";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(303, 201);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(163, 29);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "Mot de passe :";
            // 
            // from_input
            // 
            this.from_input.Location = new System.Drawing.Point(95, 94);
            this.from_input.Name = "from_input";
            this.from_input.Size = new System.Drawing.Size(202, 35);
            this.from_input.TabIndex = 7;
            // 
            // to_input
            // 
            this.to_input.Location = new System.Drawing.Point(95, 144);
            this.to_input.Name = "to_input";
            this.to_input.Size = new System.Drawing.Size(202, 35);
            this.to_input.TabIndex = 8;
            // 
            // subject_input
            // 
            this.subject_input.Location = new System.Drawing.Point(95, 195);
            this.subject_input.Name = "subject_input";
            this.subject_input.Size = new System.Drawing.Size(202, 35);
            this.subject_input.TabIndex = 9;
            // 
            // port_input
            // 
            this.port_input.Location = new System.Drawing.Point(472, 91);
            this.port_input.Name = "port_input";
            this.port_input.Size = new System.Drawing.Size(177, 35);
            this.port_input.TabIndex = 10;
            // 
            // host_input
            // 
            this.host_input.Location = new System.Drawing.Point(472, 141);
            this.host_input.Name = "host_input";
            this.host_input.Size = new System.Drawing.Size(177, 35);
            this.host_input.TabIndex = 11;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(472, 195);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(177, 35);
            this.password_input.TabIndex = 12;
            // 
            // emai_btn
            // 
            this.emai_btn.Location = new System.Drawing.Point(549, 286);
            this.emai_btn.Name = "emai_btn";
            this.emai_btn.Size = new System.Drawing.Size(100, 39);
            this.emai_btn.TabIndex = 13;
            this.emai_btn.Text = "Entrer";
            this.emai_btn.UseVisualStyleBackColor = true;
            // 
            // ConfigView
            // 
            this.ClientSize = new System.Drawing.Size(681, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enter_computers_btn;
        private System.Windows.Forms.TextBox nb_computers_input;
        private System.Windows.Forms.Label nb_computers_lbl;
        private System.Windows.Forms.Label step_lbl;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TextBox ttl_input;
        private System.Windows.Forms.TextBox ip_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Label ip_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button emai_btn;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox host_input;
        private System.Windows.Forms.TextBox port_input;
        private System.Windows.Forms.TextBox subject_input;
        private System.Windows.Forms.TextBox to_input;
        private System.Windows.Forms.TextBox from_input;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label host_lbl;
        private System.Windows.Forms.Label port_lbl;
        private System.Windows.Forms.Label subject_lbl;
        private System.Windows.Forms.Label to_lbl;
        private System.Windows.Forms.Label from_lbl;
        private System.Windows.Forms.Label email_lbl;
    }
}