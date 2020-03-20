namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.start = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fish = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ism = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guruh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cameraBox.Location = new System.Drawing.Point(0, 0);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(320, 240);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Top;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(320, 42);
            this.start.TabIndex = 3;
            this.start.Text = "Skanerlashni boshlash...";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.saveButton.Location = new System.Drawing.Point(411, 305);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 37);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Saqlash";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textName.Location = new System.Drawing.Point(180, 66);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(155, 29);
            this.textName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guvohnoma raqami:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ma\'lumot qo\'shish";
            // 
            // fish
            // 
            this.fish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.fish.ForeColor = System.Drawing.Color.Red;
            this.fish.Location = new System.Drawing.Point(12, 52);
            this.fish.Name = "fish";
            this.fish.ReadOnly = true;
            this.fish.Size = new System.Drawing.Size(238, 29);
            this.fish.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cameraBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(582, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 649);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fac);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.g);
            this.panel2.Controls.Add(this.y);
            this.panel2.Controls.Add(this.f);
            this.panel2.Controls.Add(this.i);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 368);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.start);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 409);
            this.panel3.TabIndex = 4;
            // 
            // ism
            // 
            this.ism.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ism.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ism.ForeColor = System.Drawing.Color.Red;
            this.ism.Location = new System.Drawing.Point(12, 138);
            this.ism.Name = "ism";
            this.ism.ReadOnly = true;
            this.ism.Size = new System.Drawing.Size(238, 29);
            this.ism.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ismi:";
            // 
            // fam
            // 
            this.fam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.fam.ForeColor = System.Drawing.Color.Red;
            this.fam.Location = new System.Drawing.Point(12, 210);
            this.fam.Name = "fam";
            this.fam.ReadOnly = true;
            this.fam.Size = new System.Drawing.Size(238, 29);
            this.fam.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Familiyasi:";
            // 
            // yon
            // 
            this.yon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.yon.ForeColor = System.Drawing.Color.Red;
            this.yon.Location = new System.Drawing.Point(271, 138);
            this.yon.Name = "yon";
            this.yon.ReadOnly = true;
            this.yon.Size = new System.Drawing.Size(238, 29);
            this.yon.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(36, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Yo\'nalishi";
            // 
            // guruh
            // 
            this.guruh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guruh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.guruh.ForeColor = System.Drawing.Color.Red;
            this.guruh.Location = new System.Drawing.Point(271, 210);
            this.guruh.Name = "guruh";
            this.guruh.ReadOnly = true;
            this.guruh.Size = new System.Drawing.Size(238, 29);
            this.guruh.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(36, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Guruhi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(36, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Guvohnoma";
            // 
            // i
            // 
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.i.Location = new System.Drawing.Point(180, 101);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(155, 29);
            this.i.TabIndex = 18;
            // 
            // f
            // 
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.f.Location = new System.Drawing.Point(180, 139);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(155, 29);
            this.f.TabIndex = 19;
            // 
            // y
            // 
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.y.Location = new System.Drawing.Point(180, 174);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(155, 29);
            this.y.TabIndex = 20;
            // 
            // g
            // 
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.g.Location = new System.Drawing.Point(180, 244);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(155, 29);
            this.g.TabIndex = 21;
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tel.Location = new System.Drawing.Point(180, 279);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(155, 29);
            this.tel.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label8.Location = new System.Drawing.Point(36, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefoni:";
            // 
            // fac
            // 
            this.fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.fac.Location = new System.Drawing.Point(180, 209);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(155, 29);
            this.fac.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label9.Location = new System.Drawing.Point(36, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fakultet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 649);
            this.Controls.Add(this.guruh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.yon);
            this.Controls.Add(this.fam);
            this.Controls.Add(this.ism);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fish);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ism;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox guruh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox g;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fac;
        private System.Windows.Forms.Label label9;
    }
}

