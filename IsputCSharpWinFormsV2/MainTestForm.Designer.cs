namespace IsputCSharpWinFormsV2
{
    partial class MainTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTestForm));
            this.Header = new System.Windows.Forms.Panel();
            this.ButtonMaximizeWindow = new System.Windows.Forms.Button();
            this.ButtonMinimizeWindow = new System.Windows.Forms.Button();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.MainWorkSpacePanel = new System.Windows.Forms.Panel();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SlidesPanelInTest = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.PreviousQuestionButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ResizePictureBox = new System.Windows.Forms.PictureBox();
            this.QuestionComboBox = new System.Windows.Forms.ComboBox();
            this.SwitchQuestionButton = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.MainWorkSpacePanel.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.Header.Controls.Add(this.ButtonMaximizeWindow);
            this.Header.Controls.Add(this.ButtonMinimizeWindow);
            this.Header.Controls.Add(this.ButtonCloseWindow);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 32);
            this.Header.TabIndex = 1;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // ButtonMaximizeWindow
            // 
            this.ButtonMaximizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximizeWindow.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Maximize_Window_32px;
            this.ButtonMaximizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.ButtonMaximizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.ButtonMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ButtonMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaximizeWindow.Location = new System.Drawing.Point(728, 0);
            this.ButtonMaximizeWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMaximizeWindow.Name = "ButtonMaximizeWindow";
            this.ButtonMaximizeWindow.Size = new System.Drawing.Size(36, 32);
            this.ButtonMaximizeWindow.TabIndex = 2;
            this.ButtonMaximizeWindow.UseVisualStyleBackColor = true;
            this.ButtonMaximizeWindow.Click += new System.EventHandler(this.RestoreWindowButton_Click);
            // 
            // ButtonMinimizeWindow
            // 
            this.ButtonMinimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimizeWindow.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Minimize_Window_32px;
            this.ButtonMinimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.ButtonMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ButtonMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizeWindow.Location = new System.Drawing.Point(692, 0);
            this.ButtonMinimizeWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimizeWindow.Name = "ButtonMinimizeWindow";
            this.ButtonMinimizeWindow.Size = new System.Drawing.Size(36, 32);
            this.ButtonMinimizeWindow.TabIndex = 1;
            this.ButtonMinimizeWindow.UseVisualStyleBackColor = true;
            this.ButtonMinimizeWindow.Click += new System.EventHandler(this.MinimizeWindowButton_Click);
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
            this.ButtonCloseWindow.Location = new System.Drawing.Point(764, 0);
            this.ButtonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(36, 32);
            this.ButtonCloseWindow.TabIndex = 0;
            this.ButtonCloseWindow.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // MainWorkSpacePanel
            // 
            this.MainWorkSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.MainWorkSpacePanel.Controls.Add(this.TableLayoutPanel);
            this.MainWorkSpacePanel.Controls.Add(this.ControlPanel);
            this.MainWorkSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWorkSpacePanel.Location = new System.Drawing.Point(0, 32);
            this.MainWorkSpacePanel.Name = "MainWorkSpacePanel";
            this.MainWorkSpacePanel.Size = new System.Drawing.Size(800, 386);
            this.MainWorkSpacePanel.TabIndex = 2;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.SlidesPanelInTest, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(672, 386);
            this.TableLayoutPanel.TabIndex = 2;
            // 
            // SlidesPanelInTest
            // 
            this.SlidesPanelInTest.AutoScroll = true;
            this.SlidesPanelInTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.SlidesPanelInTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlidesPanelInTest.Location = new System.Drawing.Point(0, 0);
            this.SlidesPanelInTest.Margin = new System.Windows.Forms.Padding(0);
            this.SlidesPanelInTest.Name = "SlidesPanelInTest";
            this.SlidesPanelInTest.Size = new System.Drawing.Size(672, 96);
            this.SlidesPanelInTest.TabIndex = 0;
            this.SlidesPanelInTest.Resize += new System.EventHandler(this.SlidesPanelInTest_SizeChanged);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.ControlPanel.Controls.Add(this.SwitchQuestionButton);
            this.ControlPanel.Controls.Add(this.QuestionComboBox);
            this.ControlPanel.Controls.Add(this.PreviousQuestionButton);
            this.ControlPanel.Controls.Add(this.NextQuestionButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(672, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(128, 386);
            this.ControlPanel.TabIndex = 1;
            // 
            // PreviousQuestionButton
            // 
            this.PreviousQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousQuestionButton.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Back_Arrow_64px;
            this.PreviousQuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PreviousQuestionButton.FlatAppearance.BorderSize = 0;
            this.PreviousQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.PreviousQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.PreviousQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousQuestionButton.Location = new System.Drawing.Point(0, 322);
            this.PreviousQuestionButton.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousQuestionButton.Name = "PreviousQuestionButton";
            this.PreviousQuestionButton.Size = new System.Drawing.Size(64, 64);
            this.PreviousQuestionButton.TabIndex = 1;
            this.PreviousQuestionButton.UseVisualStyleBackColor = true;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionButton.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.icons8_forward_button_64;
            this.NextQuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextQuestionButton.FlatAppearance.BorderSize = 0;
            this.NextQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.NextQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.NextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuestionButton.Location = new System.Drawing.Point(64, 322);
            this.NextQuestionButton.Margin = new System.Windows.Forms.Padding(0);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(64, 64);
            this.NextQuestionButton.TabIndex = 2;
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ResizePictureBox);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Enabled = false;
            this.BottomPanel.Location = new System.Drawing.Point(0, 418);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 32);
            this.BottomPanel.TabIndex = 3;
            // 
            // ResizePictureBox
            // 
            this.ResizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ResizePictureBox.Image")));
            this.ResizePictureBox.Location = new System.Drawing.Point(768, 0);
            this.ResizePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResizePictureBox.Name = "ResizePictureBox";
            this.ResizePictureBox.Size = new System.Drawing.Size(32, 32);
            this.ResizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ResizePictureBox.TabIndex = 1;
            this.ResizePictureBox.TabStop = false;
            // 
            // QuestionComboBox
            // 
            this.QuestionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.QuestionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionComboBox.ForeColor = System.Drawing.Color.White;
            this.QuestionComboBox.FormattingEnabled = true;
            this.QuestionComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.QuestionComboBox.Location = new System.Drawing.Point(8, 8);
            this.QuestionComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.QuestionComboBox.Name = "QuestionComboBox";
            this.QuestionComboBox.Size = new System.Drawing.Size(112, 28);
            this.QuestionComboBox.TabIndex = 3;
            // 
            // SwitchQuestionButton
            // 
            this.SwitchQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.SwitchQuestionButton.FlatAppearance.BorderSize = 0;
            this.SwitchQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.SwitchQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.SwitchQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchQuestionButton.ForeColor = System.Drawing.Color.White;
            this.SwitchQuestionButton.Location = new System.Drawing.Point(8, 46);
            this.SwitchQuestionButton.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchQuestionButton.Name = "SwitchQuestionButton";
            this.SwitchQuestionButton.Size = new System.Drawing.Size(112, 30);
            this.SwitchQuestionButton.TabIndex = 6;
            this.SwitchQuestionButton.Text = "Перейти";
            this.SwitchQuestionButton.UseVisualStyleBackColor = false;
            // 
            // MainTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainWorkSpacePanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainTestForm";
            this.Text = "MainTestForm";
            this.Header.ResumeLayout(false);
            this.MainWorkSpacePanel.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ButtonMaximizeWindow;
        private System.Windows.Forms.Button ButtonMinimizeWindow;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Panel MainWorkSpacePanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox ResizePictureBox;
        private System.Windows.Forms.Panel SlidesPanelInTest;
        private System.Windows.Forms.Button PreviousQuestionButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.ComboBox QuestionComboBox;
        private System.Windows.Forms.Button SwitchQuestionButton;
    }
}