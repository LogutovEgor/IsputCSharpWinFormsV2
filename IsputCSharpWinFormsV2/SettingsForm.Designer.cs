﻿namespace IsputCSharpWinFormsV2
{
    partial class SettingsForm
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
            this.Header = new System.Windows.Forms.Panel();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.LeftMenuPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.AddAnswerButton = new System.Windows.Forms.Button();
            this.panelSecurity = new System.Windows.Forms.Panel();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            this.LeftMenuPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.Header.Controls.Add(this.ButtonCloseWindow);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(450, 32);
            this.Header.TabIndex = 2;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseWindow.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Close_Window_32px;
            this.ButtonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonCloseWindow.FlatAppearance.BorderSize = 0;
            this.ButtonCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(59)))), ((int)(((byte)(36)))));
            this.ButtonCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ButtonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(414, 0);
            this.ButtonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(36, 32);
            this.ButtonCloseWindow.TabIndex = 0;
            this.ButtonCloseWindow.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.ButtonCloseWindow_Click);
            // 
            // LeftMenuPanel
            // 
            this.LeftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.LeftMenuPanel.Controls.Add(this.tableLayoutPanel1);
            this.LeftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPanel.Location = new System.Drawing.Point(0, 32);
            this.LeftMenuPanel.Name = "LeftMenuPanel";
            this.LeftMenuPanel.Size = new System.Drawing.Size(128, 238);
            this.LeftMenuPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CreateFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenFileButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(128, 238);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateFileButton.FlatAppearance.BorderSize = 0;
            this.CreateFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.CreateFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.CreateFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateFileButton.ForeColor = System.Drawing.Color.White;
            this.CreateFileButton.Location = new System.Drawing.Point(0, 0);
            this.CreateFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(128, 48);
            this.CreateFileButton.TabIndex = 0;
            this.CreateFileButton.Text = "Безопасность";
            this.CreateFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateFileButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.OpenFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 48);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(128, 48);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Язык";
            this.OpenFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // AddAnswerButton
            // 
            this.AddAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.AddAnswerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddAnswerButton.FlatAppearance.BorderSize = 0;
            this.AddAnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.AddAnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.AddAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAnswerButton.ForeColor = System.Drawing.Color.White;
            this.AddAnswerButton.Location = new System.Drawing.Point(0, 270);
            this.AddAnswerButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(450, 30);
            this.AddAnswerButton.TabIndex = 6;
            this.AddAnswerButton.Text = "Сохранить";
            this.AddAnswerButton.UseVisualStyleBackColor = false;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // panelSecurity
            // 
            this.panelSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.panelSecurity.Controls.Add(this.textBox1);
            this.panelSecurity.Controls.Add(this.checkBox1);
            this.panelSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecurity.Location = new System.Drawing.Point(128, 32);
            this.panelSecurity.Name = "panelSecurity";
            this.panelSecurity.Size = new System.Drawing.Size(322, 238);
            this.panelSecurity.TabIndex = 7;
            // 
            // panelLanguage
            // 
            this.panelLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.panelLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLanguage.Location = new System.Drawing.Point(128, 32);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(322, 238);
            this.panelLanguage.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(18, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Защита паролем";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.panelSecurity);
            this.Controls.Add(this.panelLanguage);
            this.Controls.Add(this.LeftMenuPanel);
            this.Controls.Add(this.AddAnswerButton);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Header.ResumeLayout(false);
            this.LeftMenuPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSecurity.ResumeLayout(false);
            this.panelSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Panel LeftMenuPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button AddAnswerButton;
        private System.Windows.Forms.Panel panelSecurity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelLanguage;
    }
}