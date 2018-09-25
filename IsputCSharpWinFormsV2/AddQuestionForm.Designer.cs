namespace IsputCSharpWinFormsV2
{
    partial class AddQuestionForm
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
            this.Header = new System.Windows.Forms.Panel();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DifficultLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.DifficultLevelTextLabel = new System.Windows.Forms.Label();
            this.DifficultLevelTextBox = new System.Windows.Forms.TextBox();
            this.CorrectAnswersGroupBox = new System.Windows.Forms.GroupBox();
            this.CorrectAnswersTextLabel = new System.Windows.Forms.Label();
            this.CorrectAnswersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AnswersGroupBox = new System.Windows.Forms.GroupBox();
            this.AnswerTextLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAnswerButton = new System.Windows.Forms.Button();
            this.QuestionTextGroupBox = new System.Windows.Forms.GroupBox();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.SaveQuestionButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Header.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.DifficultLevelGroupBox.SuspendLayout();
            this.CorrectAnswersGroupBox.SuspendLayout();
            this.AnswersGroupBox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.QuestionTextGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.Header.Controls.Add(this.ButtonCloseWindow);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(695, 32);
            this.Header.TabIndex = 1;
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
            this.ButtonCloseWindow.Location = new System.Drawing.Point(659, 0);
            this.ButtonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(36, 32);
            this.ButtonCloseWindow.TabIndex = 0;
            this.ButtonCloseWindow.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DifficultLevelGroupBox);
            this.MainPanel.Controls.Add(this.CorrectAnswersGroupBox);
            this.MainPanel.Controls.Add(this.AnswersGroupBox);
            this.MainPanel.Controls.Add(this.QuestionTextGroupBox);
            this.MainPanel.Controls.Add(this.SaveQuestionButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(50, 20, 3, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(695, 438);
            this.MainPanel.TabIndex = 2;
            // 
            // DifficultLevelGroupBox
            // 
            this.DifficultLevelGroupBox.Controls.Add(this.DifficultLevelTextLabel);
            this.DifficultLevelGroupBox.Controls.Add(this.DifficultLevelTextBox);
            this.DifficultLevelGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DifficultLevelGroupBox.Location = new System.Drawing.Point(437, 13);
            this.DifficultLevelGroupBox.Name = "DifficultLevelGroupBox";
            this.DifficultLevelGroupBox.Size = new System.Drawing.Size(232, 120);
            this.DifficultLevelGroupBox.TabIndex = 11;
            this.DifficultLevelGroupBox.TabStop = false;
            // 
            // DifficultLevelTextLabel
            // 
            this.DifficultLevelTextLabel.AutoSize = true;
            this.DifficultLevelTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultLevelTextLabel.ForeColor = System.Drawing.Color.White;
            this.DifficultLevelTextLabel.Location = new System.Drawing.Point(10, 18);
            this.DifficultLevelTextLabel.Name = "DifficultLevelTextLabel";
            this.DifficultLevelTextLabel.Size = new System.Drawing.Size(137, 17);
            this.DifficultLevelTextLabel.TabIndex = 1;
            this.DifficultLevelTextLabel.Text = "Уровень сложности";
            // 
            // DifficultLevelTextBox
            // 
            this.DifficultLevelTextBox.Location = new System.Drawing.Point(13, 45);
            this.DifficultLevelTextBox.Name = "DifficultLevelTextBox";
            this.DifficultLevelTextBox.Size = new System.Drawing.Size(209, 20);
            this.DifficultLevelTextBox.TabIndex = 0;
            // 
            // CorrectAnswersGroupBox
            // 
            this.CorrectAnswersGroupBox.Controls.Add(this.CorrectAnswersTextLabel);
            this.CorrectAnswersGroupBox.Controls.Add(this.CorrectAnswersCheckedListBox);
            this.CorrectAnswersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CorrectAnswersGroupBox.Location = new System.Drawing.Point(437, 140);
            this.CorrectAnswersGroupBox.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.CorrectAnswersGroupBox.Name = "CorrectAnswersGroupBox";
            this.CorrectAnswersGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.CorrectAnswersGroupBox.Size = new System.Drawing.Size(232, 250);
            this.CorrectAnswersGroupBox.TabIndex = 10;
            this.CorrectAnswersGroupBox.TabStop = false;
            // 
            // CorrectAnswersTextLabel
            // 
            this.CorrectAnswersTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.CorrectAnswersTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CorrectAnswersTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectAnswersTextLabel.ForeColor = System.Drawing.Color.White;
            this.CorrectAnswersTextLabel.Location = new System.Drawing.Point(10, 18);
            this.CorrectAnswersTextLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CorrectAnswersTextLabel.Name = "CorrectAnswersTextLabel";
            this.CorrectAnswersTextLabel.Size = new System.Drawing.Size(200, 17);
            this.CorrectAnswersTextLabel.TabIndex = 7;
            this.CorrectAnswersTextLabel.Text = "Правильный ответ/ответы";
            this.CorrectAnswersTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CorrectAnswersCheckedListBox
            // 
            this.CorrectAnswersCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CorrectAnswersCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CorrectAnswersCheckedListBox.FormattingEnabled = true;
            this.CorrectAnswersCheckedListBox.Location = new System.Drawing.Point(13, 45);
            this.CorrectAnswersCheckedListBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CorrectAnswersCheckedListBox.Name = "CorrectAnswersCheckedListBox";
            this.CorrectAnswersCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CorrectAnswersCheckedListBox.Size = new System.Drawing.Size(209, 180);
            this.CorrectAnswersCheckedListBox.TabIndex = 6;
            // 
            // AnswersGroupBox
            // 
            this.AnswersGroupBox.Controls.Add(this.listBox1);
            this.AnswersGroupBox.Controls.Add(this.AnswerTextLabel);
            this.AnswersGroupBox.Controls.Add(this.AddAnswerButton);
            this.AnswersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswersGroupBox.Location = new System.Drawing.Point(25, 140);
            this.AnswersGroupBox.Margin = new System.Windows.Forms.Padding(10, 5, 2, 2);
            this.AnswersGroupBox.Name = "AnswersGroupBox";
            this.AnswersGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.AnswersGroupBox.Size = new System.Drawing.Size(400, 250);
            this.AnswersGroupBox.TabIndex = 9;
            this.AnswersGroupBox.TabStop = false;
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
            this.AnswerTextLabel.TabIndex = 4;
            this.AnswerTextLabel.Text = "Ответы";
            this.AnswerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // AddAnswerButton
            // 
            this.AddAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.AddAnswerButton.FlatAppearance.BorderSize = 0;
            this.AddAnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.AddAnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.AddAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAnswerButton.ForeColor = System.Drawing.Color.White;
            this.AddAnswerButton.Location = new System.Drawing.Point(270, 210);
            this.AddAnswerButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(120, 30);
            this.AddAnswerButton.TabIndex = 5;
            this.AddAnswerButton.Text = "Добавить ответ";
            this.AddAnswerButton.UseVisualStyleBackColor = false;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // QuestionTextGroupBox
            // 
            this.QuestionTextGroupBox.Controls.Add(this.QuestionTextLabel);
            this.QuestionTextGroupBox.Controls.Add(this.QuestionTextBox);
            this.QuestionTextGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionTextGroupBox.Location = new System.Drawing.Point(25, 13);
            this.QuestionTextGroupBox.Margin = new System.Windows.Forms.Padding(25, 10, 25, 2);
            this.QuestionTextGroupBox.Name = "QuestionTextGroupBox";
            this.QuestionTextGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.QuestionTextGroupBox.Size = new System.Drawing.Size(400, 120);
            this.QuestionTextGroupBox.TabIndex = 8;
            this.QuestionTextGroupBox.TabStop = false;
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.QuestionTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionTextLabel.Location = new System.Drawing.Point(10, 18);
            this.QuestionTextLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(200, 17);
            this.QuestionTextLabel.TabIndex = 2;
            this.QuestionTextLabel.Text = "Текст вопроса";
            this.QuestionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.QuestionTextBox.Location = new System.Drawing.Point(13, 45);
            this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(377, 60);
            this.QuestionTextBox.TabIndex = 1;
            // 
            // SaveQuestionButton
            // 
            this.SaveQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.SaveQuestionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveQuestionButton.FlatAppearance.BorderSize = 0;
            this.SaveQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.SaveQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.SaveQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQuestionButton.ForeColor = System.Drawing.Color.White;
            this.SaveQuestionButton.Location = new System.Drawing.Point(0, 408);
            this.SaveQuestionButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SaveQuestionButton.Name = "SaveQuestionButton";
            this.SaveQuestionButton.Size = new System.Drawing.Size(695, 30);
            this.SaveQuestionButton.TabIndex = 0;
            this.SaveQuestionButton.Text = "Сохранить";
            this.SaveQuestionButton.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 147);
            this.listBox1.TabIndex = 6;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(695, 470);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuestionForm";
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.DifficultLevelGroupBox.ResumeLayout(false);
            this.DifficultLevelGroupBox.PerformLayout();
            this.CorrectAnswersGroupBox.ResumeLayout(false);
            this.AnswersGroupBox.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.QuestionTextGroupBox.ResumeLayout(false);
            this.QuestionTextGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SaveQuestionButton;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button AddAnswerButton;
        private System.Windows.Forms.Label AnswerTextLabel;
        private System.Windows.Forms.Label CorrectAnswersTextLabel;
        private System.Windows.Forms.CheckedListBox CorrectAnswersCheckedListBox;
        private System.Windows.Forms.GroupBox QuestionTextGroupBox;
        private System.Windows.Forms.GroupBox AnswersGroupBox;
        private System.Windows.Forms.GroupBox CorrectAnswersGroupBox;
        private System.Windows.Forms.GroupBox DifficultLevelGroupBox;
        private System.Windows.Forms.Label DifficultLevelTextLabel;
        private System.Windows.Forms.TextBox DifficultLevelTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}