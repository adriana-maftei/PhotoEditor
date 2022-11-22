namespace PhotoEditor
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.FILTERS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Control;
            this.btn_reset.Location = new System.Drawing.Point(813, 347);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(165, 36);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset image";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(813, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Vulcano";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(813, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ancient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(813, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Plum";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(813, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Fog";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(813, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "Flash";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(813, 292);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "Frozen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "RED";
            // 
            // redBar
            // 
            this.redBar.BackColor = System.Drawing.SystemColors.Control;
            this.redBar.Location = new System.Drawing.Point(88, 418);
            this.redBar.Maximum = 20;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(719, 56);
            this.redBar.TabIndex = 9;
            this.redBar.ValueChanged += new System.EventHandler(this.redBar_ValueChanged);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(88, 480);
            this.greenBar.Maximum = 20;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(719, 56);
            this.greenBar.TabIndex = 11;
            this.greenBar.ValueChanged += new System.EventHandler(this.greenBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(23, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "GREEN";
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(88, 542);
            this.blueBar.Maximum = 20;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(719, 56);
            this.blueBar.TabIndex = 13;
            this.blueBar.ValueChanged += new System.EventHandler(this.blueBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(23, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "BLUE";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(813, 452);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(165, 36);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(813, 515);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(165, 36);
            this.btn_open.TabIndex = 15;
            this.btn_open.Text = "Open file...";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(813, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Winter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FILTERS
            // 
            this.FILTERS.AutoSize = true;
            this.FILTERS.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FILTERS.ForeColor = System.Drawing.Color.Crimson;
            this.FILTERS.Location = new System.Drawing.Point(827, 9);
            this.FILTERS.Name = "FILTERS";
            this.FILTERS.Size = new System.Drawing.Size(134, 26);
            this.FILTERS.TabIndex = 17;
            this.FILTERS.Text = "Color Filters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.FILTERS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_reset;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private TrackBar redBar;
        private TrackBar greenBar;
        private Label label2;
        private TrackBar blueBar;
        private Label label3;
        private Button btn_save;
        private Button btn_open;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Label FILTERS;
    }
}