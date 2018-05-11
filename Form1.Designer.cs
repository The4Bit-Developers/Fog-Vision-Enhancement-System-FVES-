namespace FVES_Interface
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
            this.components = new System.ComponentModel.Container();
            this.CurrentTime_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserName_pnl = new System.Windows.Forms.Panel();
            this.CurrentUser_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Status_pnl = new System.Windows.Forms.Panel();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.functions_pnl = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.FilePath_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileName_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Main_Picture = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Marksheet_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.panel3.SuspendLayout();
            this.UserName_pnl.SuspendLayout();
            this.Status_pnl.SuspendLayout();
            this.functions_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentTime_lbl
            // 
            this.CurrentTime_lbl.AutoSize = true;
            this.CurrentTime_lbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime_lbl.ForeColor = System.Drawing.Color.White;
            this.CurrentTime_lbl.Location = new System.Drawing.Point(17, 10);
            this.CurrentTime_lbl.Name = "CurrentTime_lbl";
            this.CurrentTime_lbl.Size = new System.Drawing.Size(176, 49);
            this.CurrentTime_lbl.TabIndex = 19;
            this.CurrentTime_lbl.Text = "00:00:00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.UserName_pnl);
            this.panel3.Controls.Add(this.Status_pnl);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.Marksheet_btn);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(10, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 400);
            this.panel3.TabIndex = 22;
            // 
            // UserName_pnl
            // 
            this.UserName_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName_pnl.Controls.Add(this.CurrentUser_lbl);
            this.UserName_pnl.Controls.Add(this.label1);
            this.UserName_pnl.Location = new System.Drawing.Point(3, 4);
            this.UserName_pnl.Name = "UserName_pnl";
            this.UserName_pnl.Size = new System.Drawing.Size(186, 47);
            this.UserName_pnl.TabIndex = 22;
            // 
            // CurrentUser_lbl
            // 
            this.CurrentUser_lbl.AutoSize = true;
            this.CurrentUser_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUser_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.CurrentUser_lbl.Location = new System.Drawing.Point(0, 22);
            this.CurrentUser_lbl.Name = "CurrentUser_lbl";
            this.CurrentUser_lbl.Size = new System.Drawing.Size(128, 19);
            this.CurrentUser_lbl.TabIndex = 24;
            this.CurrentUser_lbl.Text = "Temporary User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Logged in as:";
            // 
            // Status_pnl
            // 
            this.Status_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status_pnl.Controls.Add(this.Status_lbl);
            this.Status_pnl.Controls.Add(this.label3);
            this.Status_pnl.Location = new System.Drawing.Point(3, 347);
            this.Status_pnl.Name = "Status_pnl";
            this.Status_pnl.Size = new System.Drawing.Size(186, 47);
            this.Status_pnl.TabIndex = 21;
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.Status_lbl.Location = new System.Drawing.Point(2, 22);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(116, 19);
            this.Status_lbl.TabIndex = 25;
            this.Status_lbl.Text = "Initial Window";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Current Status:";
            // 
            // functions_pnl
            // 
            this.functions_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.functions_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functions_pnl.Controls.Add(this.button11);
            this.functions_pnl.Controls.Add(this.button12);
            this.functions_pnl.Controls.Add(this.button8);
            this.functions_pnl.Controls.Add(this.button10);
            this.functions_pnl.Controls.Add(this.button7);
            this.functions_pnl.Controls.Add(this.button9);
            this.functions_pnl.Location = new System.Drawing.Point(211, 334);
            this.functions_pnl.Name = "functions_pnl";
            this.functions_pnl.Size = new System.Drawing.Size(524, 90);
            this.functions_pnl.TabIndex = 23;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(349, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(169, 36);
            this.button11.TabIndex = 31;
            this.button11.TabStop = false;
            this.button11.Text = "Discard Changes";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(349, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(169, 36);
            this.button12.TabIndex = 30;
            this.button12.TabStop = false;
            this.button12.Text = "Adjust BlackLight";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(176, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 36);
            this.button8.TabIndex = 29;
            this.button8.TabStop = false;
            this.button8.Text = "Grayscale";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(176, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(169, 36);
            this.button10.TabIndex = 28;
            this.button10.TabStop = false;
            this.button10.Text = "Auto Contrast";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(3, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 36);
            this.button7.TabIndex = 27;
            this.button7.TabStop = false;
            this.button7.Text = "Sharpen";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(3, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 36);
            this.button9.TabIndex = 26;
            this.button9.TabStop = false;
            this.button9.Text = "Dehaze Image";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FilePath_lbl
            // 
            this.FilePath_lbl.AutoSize = true;
            this.FilePath_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePath_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.FilePath_lbl.Location = new System.Drawing.Point(71, 0);
            this.FilePath_lbl.Name = "FilePath_lbl";
            this.FilePath_lbl.Size = new System.Drawing.Size(132, 21);
            this.FilePath_lbl.TabIndex = 28;
            this.FilePath_lbl.Text = "*browse image*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "FilePath:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "File Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FileName_lbl
            // 
            this.FileName_lbl.AutoSize = true;
            this.FileName_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.FileName_lbl.Location = new System.Drawing.Point(86, 21);
            this.FileName_lbl.Name = "FileName_lbl";
            this.FileName_lbl.Size = new System.Drawing.Size(124, 21);
            this.FileName_lbl.TabIndex = 30;
            this.FileName_lbl.Text = "*filenamehere*";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileName_lbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FilePath_lbl);
            this.panel1.Location = new System.Drawing.Point(204, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 44);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main_Picture
            // 
            this.Main_Picture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Main_Picture.Image = global::FVES_Interface.Properties.Resources.Initial_Image;
            this.Main_Picture.Location = new System.Drawing.Point(211, 12);
            this.Main_Picture.Name = "Main_Picture";
            this.Main_Picture.Size = new System.Drawing.Size(524, 316);
            this.Main_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Main_Picture.TabIndex = 0;
            this.Main_Picture.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::FVES_Interface.Properties.Resources.exitapppsj;
            this.button6.Location = new System.Drawing.Point(3, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 36);
            this.button6.TabIndex = 23;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::FVES_Interface.Properties.Resources.browow;
            this.button2.Location = new System.Drawing.Point(3, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 36);
            this.button2.TabIndex = 13;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::FVES_Interface.Properties.Resources.resppp;
            this.button5.Location = new System.Drawing.Point(3, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 36);
            this.button5.TabIndex = 16;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Marksheet_btn
            // 
            this.Marksheet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.Marksheet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Marksheet_btn.FlatAppearance.BorderSize = 0;
            this.Marksheet_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.Marksheet_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.Marksheet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Marksheet_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marksheet_btn.ForeColor = System.Drawing.Color.White;
            this.Marksheet_btn.Image = global::FVES_Interface.Properties.Resources.acct1;
            this.Marksheet_btn.Location = new System.Drawing.Point(3, 223);
            this.Marksheet_btn.Name = "Marksheet_btn";
            this.Marksheet_btn.Size = new System.Drawing.Size(186, 36);
            this.Marksheet_btn.TabIndex = 11;
            this.Marksheet_btn.TabStop = false;
            this.Marksheet_btn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::FVES_Interface.Properties.Resources.edit;
            this.button4.Location = new System.Drawing.Point(3, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 36);
            this.button4.TabIndex = 15;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FVES_Interface.Properties.Resources.alog;
            this.button1.Location = new System.Drawing.Point(3, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 36);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::FVES_Interface.Properties.Resources.Untitled_21;
            this.button3.Location = new System.Drawing.Point(3, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 36);
            this.button3.TabIndex = 14;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(746, 481);
            this.Controls.Add(this.functions_pnl);
            this.Controls.Add(this.CurrentTime_lbl);
            this.Controls.Add(this.Main_Picture);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.UserName_pnl.ResumeLayout(false);
            this.UserName_pnl.PerformLayout();
            this.Status_pnl.ResumeLayout(false);
            this.Status_pnl.PerformLayout();
            this.functions_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Main_Picture;
        private System.Windows.Forms.Button Marksheet_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label CurrentTime_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel UserName_pnl;
        private System.Windows.Forms.Panel Status_pnl;
        private System.Windows.Forms.Label CurrentUser_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel functions_pnl;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label FilePath_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FileName_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog savefile;


    }
}

