namespace IsputCSharpWinFormsV2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainWorkSpacePanel = new System.Windows.Forms.Panel();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.TabsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FileTabButton = new System.Windows.Forms.Button();
            this.MainTabButton = new System.Windows.Forms.Button();
            this.Header1 = new System.Windows.Forms.Panel();
            this.ButtonMaximizeWindow1 = new System.Windows.Forms.Button();
            this.ButtonMinimizeWindow1 = new System.Windows.Forms.Button();
            this.ButtonCloseWindow1 = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ResizePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MainWorkSpacePanel.SuspendLayout();
            this.TabsLayoutPanel.SuspendLayout();
            this.Header1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWorkSpacePanel
            // 
            this.MainWorkSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.MainWorkSpacePanel.Controls.Add(this.button1);
            this.MainWorkSpacePanel.Controls.Add(this.MainTabButton);
            this.MainWorkSpacePanel.Controls.Add(this.ToolStripMain);
            this.MainWorkSpacePanel.Controls.Add(this.TabsLayoutPanel);
            this.MainWorkSpacePanel.Controls.Add(this.Header1);
            this.MainWorkSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWorkSpacePanel.Location = new System.Drawing.Point(0, 0);
            this.MainWorkSpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainWorkSpacePanel.Name = "MainWorkSpacePanel";
            this.MainWorkSpacePanel.Size = new System.Drawing.Size(800, 418);
            this.MainWorkSpacePanel.TabIndex = 0;
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ToolStripMain.Location = new System.Drawing.Point(0, 62);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(800, 25);
            this.ToolStripMain.TabIndex = 2;
            this.ToolStripMain.Text = "toolStrip1";
            this.ToolStripMain.Visible = false;
            // 
            // TabsLayoutPanel
            // 
            this.TabsLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.TabsLayoutPanel.ColumnCount = 4;
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabsLayoutPanel.Controls.Add(this.FileTabButton, 0, 0);
            this.TabsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabsLayoutPanel.Location = new System.Drawing.Point(0, 32);
            this.TabsLayoutPanel.Name = "TabsLayoutPanel";
            this.TabsLayoutPanel.RowCount = 1;
            this.TabsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabsLayoutPanel.Size = new System.Drawing.Size(800, 30);
            this.TabsLayoutPanel.TabIndex = 1;
            // 
            // FileTabButton
            // 
            this.FileTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTabButton.FlatAppearance.BorderSize = 0;
            this.FileTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.FileTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.FileTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileTabButton.ForeColor = System.Drawing.Color.White;
            this.FileTabButton.Location = new System.Drawing.Point(0, 0);
            this.FileTabButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.FileTabButton.Name = "FileTabButton";
            this.FileTabButton.Size = new System.Drawing.Size(79, 30);
            this.FileTabButton.TabIndex = 0;
            this.FileTabButton.Text = "Файл";
            this.FileTabButton.UseVisualStyleBackColor = true;
            this.FileTabButton.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // MainTabButton
            // 
            this.MainTabButton.FlatAppearance.BorderSize = 0;
            this.MainTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.MainTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.MainTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabButton.ForeColor = System.Drawing.Color.White;
            this.MainTabButton.Location = new System.Drawing.Point(117, 105);
            this.MainTabButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MainTabButton.Name = "MainTabButton";
            this.MainTabButton.Size = new System.Drawing.Size(74, 24);
            this.MainTabButton.TabIndex = 1;
            this.MainTabButton.Text = "Главная";
            this.MainTabButton.UseVisualStyleBackColor = true;
            this.MainTabButton.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // Header1
            // 
            this.Header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.Header1.Controls.Add(this.ButtonMaximizeWindow1);
            this.Header1.Controls.Add(this.ButtonMinimizeWindow1);
            this.Header1.Controls.Add(this.ButtonCloseWindow1);
            this.Header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header1.Location = new System.Drawing.Point(0, 0);
            this.Header1.Name = "Header1";
            this.Header1.Size = new System.Drawing.Size(800, 32);
            this.Header1.TabIndex = 0;
            this.Header1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // ButtonMaximizeWindow1
            // 
            this.ButtonMaximizeWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximizeWindow1.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Maximize_Window_32px;
            this.ButtonMaximizeWindow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMaximizeWindow1.FlatAppearance.BorderSize = 0;
            this.ButtonMaximizeWindow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.ButtonMaximizeWindow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ButtonMaximizeWindow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaximizeWindow1.Location = new System.Drawing.Point(728, 0);
            this.ButtonMaximizeWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMaximizeWindow1.Name = "ButtonMaximizeWindow1";
            this.ButtonMaximizeWindow1.Size = new System.Drawing.Size(36, 32);
            this.ButtonMaximizeWindow1.TabIndex = 2;
            this.ButtonMaximizeWindow1.UseVisualStyleBackColor = true;
            this.ButtonMaximizeWindow1.Click += new System.EventHandler(this.RestoreWindowButton_Click);
            // 
            // ButtonMinimizeWindow1
            // 
            this.ButtonMinimizeWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimizeWindow1.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Minimize_Window_32px;
            this.ButtonMinimizeWindow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMinimizeWindow1.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizeWindow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.ButtonMinimizeWindow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ButtonMinimizeWindow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizeWindow1.Location = new System.Drawing.Point(692, 0);
            this.ButtonMinimizeWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimizeWindow1.Name = "ButtonMinimizeWindow1";
            this.ButtonMinimizeWindow1.Size = new System.Drawing.Size(36, 32);
            this.ButtonMinimizeWindow1.TabIndex = 1;
            this.ButtonMinimizeWindow1.UseVisualStyleBackColor = true;
            this.ButtonMinimizeWindow1.Click += new System.EventHandler(this.MinimizeWindowButton_Click);
            // 
            // ButtonCloseWindow1
            // 
            this.ButtonCloseWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseWindow1.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Close_Window_32px;
            this.ButtonCloseWindow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonCloseWindow1.FlatAppearance.BorderSize = 0;
            this.ButtonCloseWindow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(59)))), ((int)(((byte)(36)))));
            this.ButtonCloseWindow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ButtonCloseWindow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseWindow1.Location = new System.Drawing.Point(764, 0);
            this.ButtonCloseWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseWindow1.Name = "ButtonCloseWindow1";
            this.ButtonCloseWindow1.Size = new System.Drawing.Size(36, 32);
            this.ButtonCloseWindow1.TabIndex = 0;
            this.ButtonCloseWindow1.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow1.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ResizePictureBox);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Enabled = false;
            this.BottomPanel.Location = new System.Drawing.Point(0, 418);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 32);
            this.BottomPanel.TabIndex = 1;
            // 
            // ResizePictureBox
            // 
            this.ResizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ResizePictureBox.Image")));
            this.ResizePictureBox.Location = new System.Drawing.Point(768, 0);
            this.ResizePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResizePictureBox.Name = "ResizePictureBox";
            this.ResizePictureBox.Size = new System.Drawing.Size(32, 32);
            this.ResizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ResizePictureBox.TabIndex = 1;
            this.ResizePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainWorkSpacePanel);
            this.Controls.Add(this.BottomPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainWorkSpacePanel.ResumeLayout(false);
            this.MainWorkSpacePanel.PerformLayout();
            this.TabsLayoutPanel.ResumeLayout(false);
            this.Header1.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainWorkSpacePanel;
        private System.Windows.Forms.Panel Header1;
        private System.Windows.Forms.Button ButtonMaximizeWindow1;
        private System.Windows.Forms.Button ButtonMinimizeWindow1;
        private System.Windows.Forms.Button ButtonCloseWindow1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox ResizePictureBox;
        private System.Windows.Forms.TableLayoutPanel TabsLayoutPanel;
        private System.Windows.Forms.Button FileTabButton;
        private System.Windows.Forms.Button MainTabButton;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.Button button1;
    }
}

