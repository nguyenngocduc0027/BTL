﻿namespace Assignment1CAndNSecurity
{
    partial class FormDES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDES));
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnOpenFileIn = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.PictureBox();
            this.btnGenerateKey = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFolderIn = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDecrypt = new System.Windows.Forms.PictureBox();
            this.btnOutOpen = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCheckIsEncryptFolder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFileIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolderIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOutOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(950, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 108);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.labelKey;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(154, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(331, 139);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(325, 20);
            this.tbKey.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.labelInput;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(149, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tbInput
            // 
            this.tbInput.BackColor = System.Drawing.Color.White;
            this.tbInput.Enabled = false;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbInput.Location = new System.Drawing.Point(326, 221);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(325, 20);
            this.tbInput.TabIndex = 4;
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFileIn.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnOpenFile;
            this.btnOpenFileIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFileIn.Location = new System.Drawing.Point(666, 189);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(101, 91);
            this.btnOpenFileIn.TabIndex = 5;
            this.btnOpenFileIn.TabStop = false;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenIn_Click);
            this.btnOpenFileIn.MouseLeave += new System.EventHandler(this.btnOpenFileIn_MouseLeave);
            this.btnOpenFileIn.MouseHover += new System.EventHandler(this.btnOpenFileIn_MouseHover);
            this.btnOpenFileIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpenFileIn_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.labelOutput;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(149, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(171, 50);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.Color.White;
            this.tbOutput.Enabled = false;
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbOutput.Location = new System.Drawing.Point(326, 370);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(325, 20);
            this.tbOutput.TabIndex = 7;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnEncrypt3;
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncrypt.Location = new System.Drawing.Point(247, 407);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(210, 117);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.TabStop = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.btnEncrypt.MouseLeave += new System.EventHandler(this.btnEncrypt_MouseLeave);
            this.btnEncrypt.MouseHover += new System.EventHandler(this.btnEncrypt_MouseHover);
            this.btnEncrypt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEncrypt_MouseMove);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateKey.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnGenerate;
            this.btnGenerateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateKey.Location = new System.Drawing.Point(664, 96);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(101, 91);
            this.btnGenerateKey.TabIndex = 9;
            this.btnGenerateKey.TabStop = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            this.btnGenerateKey.MouseLeave += new System.EventHandler(this.btnGenerateKey_MouseLeave);
            this.btnGenerateKey.MouseHover += new System.EventHandler(this.btnGenerateKey_MouseHover);
            this.btnGenerateKey.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGenerateKey_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.labelMode;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(149, 280);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 50);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(326, 299);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(325, 21);
            this.comboBoxMode.TabIndex = 11;
            // 
            // btnOpenFolderIn
            // 
            this.btnOpenFolderIn.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFolderIn.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnOpenFolder;
            this.btnOpenFolderIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFolderIn.Location = new System.Drawing.Point(943, 189);
            this.btnOpenFolderIn.Name = "btnOpenFolderIn";
            this.btnOpenFolderIn.Size = new System.Drawing.Size(101, 91);
            this.btnOpenFolderIn.TabIndex = 12;
            this.btnOpenFolderIn.TabStop = false;
            this.btnOpenFolderIn.Click += new System.EventHandler(this.btnOpenFolderIn_Click);
            this.btnOpenFolderIn.MouseLeave += new System.EventHandler(this.btnOpenFolderIn_MouseLeave);
            this.btnOpenFolderIn.MouseHover += new System.EventHandler(this.btnOpenFolderIn_MouseHover);
            this.btnOpenFolderIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpenFolderIn_MouseMove);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 530);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(722, 33);
            this.progressBar1.TabIndex = 13;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnDecrypt;
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecrypt.Location = new System.Drawing.Point(481, 407);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(210, 117);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.TabStop = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            this.btnDecrypt.MouseLeave += new System.EventHandler(this.btnDecrypt_MouseLeave);
            this.btnDecrypt.MouseHover += new System.EventHandler(this.btnDecrypt_MouseHover);
            this.btnDecrypt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDecrypt_MouseMove);
            // 
            // btnOutOpen
            // 
            this.btnOutOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOutOpen.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnOpen1;
            this.btnOutOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutOpen.Location = new System.Drawing.Point(665, 323);
            this.btnOutOpen.Name = "btnOutOpen";
            this.btnOutOpen.Size = new System.Drawing.Size(101, 91);
            this.btnOutOpen.TabIndex = 15;
            this.btnOutOpen.TabStop = false;
            this.btnOutOpen.Click += new System.EventHandler(this.btnOutOpen_Click);
            this.btnOutOpen.MouseLeave += new System.EventHandler(this.btnOutOpen_MouseLeave);
            this.btnOutOpen.MouseHover += new System.EventHandler(this.btnOutOpen_MouseHover);
            this.btnOutOpen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOutOpen_MouseMove);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnReset2;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(788, 397);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 127);
            this.btnReset.TabIndex = 16;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            this.btnReset.MouseHover += new System.EventHandler(this.btnReset_MouseHover);
            this.btnReset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnBack1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(1004, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 86);
            this.btnBack.TabIndex = 27;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.labelLoadingFile;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(10, 515);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(185, 59);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = " ...";
            // 
            // cbCheckIsEncryptFolder
            // 
            this.cbCheckIsEncryptFolder.BackColor = System.Drawing.Color.White;
            this.cbCheckIsEncryptFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheckIsEncryptFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckIsEncryptFolder.FormattingEnabled = true;
            this.cbCheckIsEncryptFolder.Location = new System.Drawing.Point(771, 220);
            this.cbCheckIsEncryptFolder.Name = "cbCheckIsEncryptFolder";
            this.cbCheckIsEncryptFolder.Size = new System.Drawing.Size(166, 21);
            this.cbCheckIsEncryptFolder.TabIndex = 30;
            // 
            // FormDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.bgDES;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 600);
            this.Controls.Add(this.cbCheckIsEncryptFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOutOpen);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnOpenFolderIn);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnOpenFileIn);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDES";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.FormDES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFileIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolderIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOutOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox btnOpenFileIn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.PictureBox btnEncrypt;
        private System.Windows.Forms.PictureBox btnGenerateKey;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox btnOpenFolderIn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox btnDecrypt;
        private System.Windows.Forms.PictureBox btnOutOpen;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCheckIsEncryptFolder;

    }
}