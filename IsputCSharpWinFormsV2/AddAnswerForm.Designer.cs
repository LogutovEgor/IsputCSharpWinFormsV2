namespace IsputCSharpWinFormsV2
{
    partial class AddAnswerForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AnswerTextGroupBox = new System.Windows.Forms.GroupBox();
            this.AnswerTextLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.SaveAnswerButton = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.AnswerTextGroupBox.SuspendLayout();
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
            this.ButtonCloseWindow.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SaveAnswerButton);
            this.MainPanel.Controls.Add(this.AnswerTextGroupBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(450, 418);
            this.MainPanel.TabIndex = 3;
            // 
            // AnswerTextGroupBox
            // 
            this.AnswerTextGroupBox.Controls.Add(this.AnswerTextLabel);
            this.AnswerTextGroupBox.Controls.Add(this.AnswerTextBox);
            this.AnswerTextGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerTextGroupBox.Location = new System.Drawing.Point(25, 13);
            this.AnswerTextGroupBox.Margin = new System.Windows.Forms.Padding(25, 10, 25, 2);
            this.AnswerTextGroupBox.Name = "AnswerTextGroupBox";
            this.AnswerTextGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.AnswerTextGroupBox.Size = new System.Drawing.Size(400, 120);
            this.AnswerTextGroupBox.TabIndex = 9;
            this.AnswerTextGroupBox.TabStop = false;
            // 
            // AnswerTextLabel
            // 
            this.AnswerTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.AnswerTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextLabel.ForeColor = System.Drawing.Color.White;
            this.AnswerTextLabel.Location = new System.Drawing.Point(10, 18);
            this.AnswerTextLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.AnswerTextLabel.Name = "AnswerTextLabel";
            this.AnswerTextLabel.Size = new System.Drawing.Size(200, 17);
            this.AnswerTextLabel.TabIndex = 2;
            this.AnswerTextLabel.Text = "Текст ответа";
            this.AnswerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.AnswerTextBox.Location = new System.Drawing.Point(140, 45);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(250, 60);
            this.AnswerTextBox.TabIndex = 1;
            // 
            // SaveAnswerButton
            // 
            this.SaveAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.SaveAnswerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveAnswerButton.FlatAppearance.BorderSize = 0;
            this.SaveAnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.SaveAnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.SaveAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAnswerButton.ForeColor = System.Drawing.Color.White;
            this.SaveAnswerButton.Location = new System.Drawing.Point(0, 388);
            this.SaveAnswerButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SaveAnswerButton.Name = "SaveAnswerButton";
            this.SaveAnswerButton.Size = new System.Drawing.Size(450, 30);
            this.SaveAnswerButton.TabIndex = 10;
            this.SaveAnswerButton.Text = "Сохранить";
            this.SaveAnswerButton.UseVisualStyleBackColor = false;
            // 
            // AddAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAnswerForm";
            this.Text = "AddAnswerForm";
            this.Header.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.AnswerTextGroupBox.ResumeLayout(false);
            this.AnswerTextGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox AnswerTextGroupBox;
        private System.Windows.Forms.Label AnswerTextLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button SaveAnswerButton;
    }
}