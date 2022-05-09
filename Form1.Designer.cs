namespace Encrypt_Decrypt
{
    partial class tool_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tool_form));
            this.label1 = new System.Windows.Forms.Label();
            this.encrypt_text = new System.Windows.Forms.RichTextBox();
            this.decrypt_text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.elist = new System.Windows.Forms.ComboBox();
            this.key_text = new System.Windows.Forms.TextBox();
            this.option_text = new System.Windows.Forms.TextBox();
            this.optionLabel = new System.Windows.Forms.Label();
            this.encrypt_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.mode_label = new System.Windows.Forms.Label();
            this.import_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encrypt Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // encrypt_text
            // 
            this.encrypt_text.BackColor = System.Drawing.SystemColors.Window;
            this.encrypt_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encrypt_text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encrypt_text.Location = new System.Drawing.Point(33, 74);
            this.encrypt_text.Name = "encrypt_text";
            this.encrypt_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.encrypt_text.Size = new System.Drawing.Size(628, 166);
            this.encrypt_text.TabIndex = 3;
            this.encrypt_text.Text = "";
            this.encrypt_text.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // decrypt_text
            // 
            this.decrypt_text.BackColor = System.Drawing.SystemColors.Window;
            this.decrypt_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decrypt_text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decrypt_text.Location = new System.Drawing.Point(33, 319);
            this.decrypt_text.Name = "decrypt_text";
            this.decrypt_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.decrypt_text.Size = new System.Drawing.Size(628, 166);
            this.decrypt_text.TabIndex = 5;
            this.decrypt_text.Text = "";
            this.decrypt_text.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(33, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decrypt Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(699, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyLabel.ForeColor = System.Drawing.Color.DimGray;
            this.keyLabel.Location = new System.Drawing.Point(699, 252);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(45, 28);
            this.keyLabel.TabIndex = 8;
            this.keyLabel.Text = "Key";
            this.keyLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // elist
            // 
            this.elist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.elist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.elist.FormattingEnabled = true;
            this.elist.Items.AddRange(new object[] {
            "Ceasar",
            "Transposition",
            "Affine",
            "Vigenere",
            "Hill",
            "RSA"});
            this.elist.SelectedIndex = 0;
            this.elist.Location = new System.Drawing.Point(699, 113);
            this.elist.Name = "elist";
            this.elist.Size = new System.Drawing.Size(264, 31);
            this.elist.TabIndex = 13;
            this.elist.SelectedIndexChanged += new System.EventHandler(this.elist_SelectedIndexChanged);
            // 
            // key_text
            // 
            this.key_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key_text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key_text.Location = new System.Drawing.Point(699, 295);
            this.key_text.Name = "key_text";
            this.key_text.Size = new System.Drawing.Size(262, 23);
            this.key_text.TabIndex = 14;
            this.key_text.TextChanged += new System.EventHandler(this.key_text_TextChanged);
            // 
            // option_text
            // 
            this.option_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.option_text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.option_text.Location = new System.Drawing.Point(699, 199);
            this.option_text.Name = "option_text";
            this.option_text.Size = new System.Drawing.Size(262, 23);
            this.option_text.TabIndex = 17;
            this.option_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.optionLabel.Location = new System.Drawing.Point(699, 159);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(75, 28);
            this.optionLabel.TabIndex = 16;
            this.optionLabel.Text = "Option";
            this.option_text.Enabled = false;
            this.optionLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.AutoRoundedCorners = true;
            this.encrypt_btn.BackColor = System.Drawing.Color.Transparent;
            this.encrypt_btn.BorderRadius = 45;
            this.encrypt_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.encrypt_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.encrypt_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.encrypt_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.encrypt_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encrypt_btn.ForeColor = System.Drawing.Color.White;
            this.encrypt_btn.Image = ((System.Drawing.Image)(resources.GetObject("encrypt_btn.Image")));
            this.encrypt_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.encrypt_btn.Location = new System.Drawing.Point(691, 380);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.ShadowDecoration.BorderRadius = 40;
            this.encrypt_btn.ShadowDecoration.Depth = 10;
            this.encrypt_btn.ShadowDecoration.Enabled = true;
            this.encrypt_btn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.encrypt_btn.Size = new System.Drawing.Size(272, 93);
            this.encrypt_btn.TabIndex = 19;
            this.encrypt_btn.Text = "ENCRYPT";
            this.encrypt_btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(908, 12);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(55, 31);
            this.guna2ToggleSwitch1.TabIndex = 20;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // mode_label
            // 
            this.mode_label.AutoSize = true;
            this.mode_label.BackColor = System.Drawing.Color.Transparent;
            this.mode_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mode_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mode_label.Location = new System.Drawing.Point(736, 12);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(166, 28);
            this.mode_label.TabIndex = 21;
            this.mode_label.Text = "ENCRYPT MODE";
            this.mode_label.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // import_btn
            // 
            this.import_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.import_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.import_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.import_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.import_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.import_btn.ForeColor = System.Drawing.Color.White;
            this.import_btn.Image = ((System.Drawing.Image)(resources.GetObject("import_btn.Image")));
            this.import_btn.Location = new System.Drawing.Point(524, 27);
            this.import_btn.Name = "import_btn";
            this.import_btn.ShadowDecoration.BorderRadius = 5;
            this.import_btn.ShadowDecoration.Depth = 5;
            this.import_btn.ShadowDecoration.Enabled = true;
            this.import_btn.Size = new System.Drawing.Size(138, 31);
            this.import_btn.TabIndex = 22;
            this.import_btn.Text = "Import";
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Pink;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(867, 228);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 5;
            this.guna2Button1.ShadowDecoration.Depth = 5;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(96, 31);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Import";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Pink;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(865, 324);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 5;
            this.guna2Button2.ShadowDecoration.Depth = 5;
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.Size = new System.Drawing.Size(96, 31);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Text = "Import";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // tool_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 529);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.mode_label);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.option_text);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.key_text);
            this.Controls.Add(this.elist);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrypt_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encrypt_text);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tool_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EDTool";
            this.Load += new System.EventHandler(this.tool_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RichTextBox encrypt_text;
        private RichTextBox decrypt_text;
        private Label label2;
        private Label label3;
        private Label keyLabel;
        private ComboBox elist;
        private TextBox key_text;
        private TextBox option_text;
        private Label optionLabel;
        private Guna.UI2.WinForms.Guna2Button encrypt_btn;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Label mode_label;
        private Guna.UI2.WinForms.Guna2Button import_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}