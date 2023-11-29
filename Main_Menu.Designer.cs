namespace My_Mario
{
    partial class Main_Menu
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
            this.play_button = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.options_buttom = new System.Windows.Forms.Button();
            this.MusicOnOFF = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MusicOnOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.SystemColors.MenuBar;
            this.play_button.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.play_button.Location = new System.Drawing.Point(477, 100);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(94, 29);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // exit_but
            // 
            this.exit_but.BackColor = System.Drawing.SystemColors.MenuBar;
            this.exit_but.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_but.Location = new System.Drawing.Point(477, 240);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(94, 29);
            this.exit_but.TabIndex = 2;
            this.exit_but.Text = "Exit";
            this.exit_but.UseVisualStyleBackColor = false;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // options_buttom
            // 
            this.options_buttom.BackColor = System.Drawing.SystemColors.MenuBar;
            this.options_buttom.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.options_buttom.Location = new System.Drawing.Point(477, 194);
            this.options_buttom.Name = "options_buttom";
            this.options_buttom.Size = new System.Drawing.Size(94, 29);
            this.options_buttom.TabIndex = 3;
            this.options_buttom.Text = "Options";
            this.options_buttom.UseVisualStyleBackColor = false;
            // 
            // MusicOnOFF
            // 
            this.MusicOnOFF.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MusicOnOFF.Image = global::My_Mario.Properties.Resources.MusicOn;
            this.MusicOnOFF.Location = new System.Drawing.Point(577, 194);
            this.MusicOnOFF.Name = "MusicOnOFF";
            this.MusicOnOFF.Size = new System.Drawing.Size(29, 29);
            this.MusicOnOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MusicOnOFF.TabIndex = 4;
            this.MusicOnOFF.TabStop = false;
            this.MusicOnOFF.Click += new System.EventHandler(this.MusicOnOFF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Mario.Properties.Resources.Main_Menu;
            this.pictureBox1.Location = new System.Drawing.Point(-91, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1207, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(477, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Camp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MusicOnOFF);
            this.Controls.Add(this.options_buttom);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MusicOnOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button play_button;
        private Button exit_but;
        private Button options_buttom;
        private PictureBox MusicOnOFF;
        private PictureBox pictureBox1;
        private Button Enter_to_Bonfire;
        private Button button1;
    }
}