namespace WindowsFormsApp5
{
    partial class Addnew
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.plot_text = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Episode_text = new System.Windows.Forms.TextBox();
            this.Numberofseasons_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.season_box = new System.Windows.Forms.ComboBox();
            this.Title_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dubbed_check = new System.Windows.Forms.CheckBox();
            this.ongoing_check = new System.Windows.Forms.CheckBox();
            this.studio_box = new System.Windows.Forms.ComboBox();
            this.cat_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Studio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type";
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "Movies",
            "Series"});
            this.type_box.Location = new System.Drawing.Point(127, 78);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(144, 21);
            this.type_box.TabIndex = 15;
            this.type_box.SelectedIndexChanged += new System.EventHandler(this.type_box_SelectedIndexChanged);
            // 
            // plot_text
            // 
            this.plot_text.FormattingEnabled = true;
            this.plot_text.Location = new System.Drawing.Point(24, 344);
            this.plot_text.Name = "plot_text";
            this.plot_text.Size = new System.Drawing.Size(277, 56);
            this.plot_text.TabIndex = 28;
            this.plot_text.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description";
            // 
            // Episode_text
            // 
            this.Episode_text.Location = new System.Drawing.Point(127, 196);
            this.Episode_text.Name = "Episode_text";
            this.Episode_text.Size = new System.Drawing.Size(150, 20);
            this.Episode_text.TabIndex = 30;
            // 
            // Numberofseasons_text
            // 
            this.Numberofseasons_text.Location = new System.Drawing.Point(127, 225);
            this.Numberofseasons_text.Name = "Numberofseasons_text";
            this.Numberofseasons_text.Size = new System.Drawing.Size(150, 20);
            this.Numberofseasons_text.TabIndex = 31;
            this.Numberofseasons_text.TextChanged += new System.EventHandler(this.Numberofseasons_text_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "No of Episodes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Number of Seasons";
            // 
            // season_box
            // 
            this.season_box.FormattingEnabled = true;
            this.season_box.Items.AddRange(new object[] {
            "Fall",
            "Spring",
            "Summer",
            "Winter"});
            this.season_box.Location = new System.Drawing.Point(127, 256);
            this.season_box.Name = "season_box";
            this.season_box.Size = new System.Drawing.Size(121, 21);
            this.season_box.TabIndex = 35;
            this.season_box.SelectedIndexChanged += new System.EventHandler(this.season_box_SelectedIndexChanged);
            // 
            // Title_box
            // 
            this.Title_box.Location = new System.Drawing.Point(128, 39);
            this.Title_box.Name = "Title_box";
            this.Title_box.Size = new System.Drawing.Size(150, 20);
            this.Title_box.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Season Time";
            // 
            // dubbed_check
            // 
            this.dubbed_check.AutoSize = true;
            this.dubbed_check.Location = new System.Drawing.Point(133, 299);
            this.dubbed_check.Name = "dubbed_check";
            this.dubbed_check.Size = new System.Drawing.Size(64, 17);
            this.dubbed_check.TabIndex = 38;
            this.dubbed_check.Text = "Dubbed";
            this.dubbed_check.UseVisualStyleBackColor = true;
            // 
            // ongoing_check
            // 
            this.ongoing_check.AutoSize = true;
            this.ongoing_check.Location = new System.Drawing.Point(24, 299);
            this.ongoing_check.Name = "ongoing_check";
            this.ongoing_check.Size = new System.Drawing.Size(66, 17);
            this.ongoing_check.TabIndex = 39;
            this.ongoing_check.Text = "Ongoing";
            this.ongoing_check.UseVisualStyleBackColor = true;
            // 
            // studio_box
            // 
            this.studio_box.FormattingEnabled = true;
            this.studio_box.Items.AddRange(new object[] {
            "Movies",
            "Series"});
            this.studio_box.Location = new System.Drawing.Point(128, 127);
            this.studio_box.Name = "studio_box";
            this.studio_box.Size = new System.Drawing.Size(144, 21);
            this.studio_box.TabIndex = 40;
            this.studio_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cat_box
            // 
            this.cat_box.FormattingEnabled = true;
            this.cat_box.Items.AddRange(new object[] {
            "Movies",
            "Series"});
            this.cat_box.Location = new System.Drawing.Point(128, 166);
            this.cat_box.Name = "cat_box";
            this.cat_box.Size = new System.Drawing.Size(144, 21);
            this.cat_box.TabIndex = 41;
            this.cat_box.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Addnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 442);
            this.Controls.Add(this.cat_box);
            this.Controls.Add(this.studio_box);
            this.Controls.Add(this.ongoing_check);
            this.Controls.Add(this.dubbed_check);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.season_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Numberofseasons_text);
            this.Controls.Add(this.Episode_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plot_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Title_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type_box);
            this.Name = "Addnew";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.ListBox plot_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Episode_text;
        private System.Windows.Forms.TextBox Numberofseasons_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox season_box;
        private System.Windows.Forms.TextBox Title_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox dubbed_check;
        private System.Windows.Forms.CheckBox ongoing_check;
        private System.Windows.Forms.ComboBox studio_box;
        private System.Windows.Forms.ComboBox cat_box;
    }
}