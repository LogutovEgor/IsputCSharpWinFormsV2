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

            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SlidesPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionTextGroupBox = new System.Windows.Forms.GroupBox();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.AnswersGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AnswerTextLabel = new System.Windows.Forms.Label();
            this.AddAnswerButton = new System.Windows.Forms.Button();

            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddQuestion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.ToolStripInsert = new System.Windows.Forms.ToolStrip();
            this.TabsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InsertTabButton = new System.Windows.Forms.Button();
            this.FileTabButton = new System.Windows.Forms.Button();
            this.MainTabButton = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.ButtonMaximizeWindow = new System.Windows.Forms.Button();
            this.ButtonMinimizeWindow = new System.Windows.Forms.Button();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ResizePictureBox = new System.Windows.Forms.PictureBox();
            this.LeftMenuAndInfPanel = new System.Windows.Forms.Panel();
            this.LeftMenuPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFileAsButton = new System.Windows.Forms.Button();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainWorkSpacePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.QuestionTextGroupBox.SuspendLayout();
            this.AnswersGroupBox.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.TabsLayoutPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePictureBox)).BeginInit();
            this.LeftMenuAndInfPanel.SuspendLayout();
            this.LeftMenuPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWorkSpacePanel
            // 
            this.MainWorkSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.MainWorkSpacePanel.Controls.Add(this.tableLayoutPanel3);
            this.MainWorkSpacePanel.Controls.Add(this.ToolStripMain);
            this.MainWorkSpacePanel.Controls.Add(this.ToolStripInsert);
            this.MainWorkSpacePanel.Controls.Add(this.TabsLayoutPanel);
            this.MainWorkSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWorkSpacePanel.Location = new System.Drawing.Point(0, 39);
            this.MainWorkSpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainWorkSpacePanel.Name = "MainWorkSpacePanel";

            this.MainWorkSpacePanel.Size = new System.Drawing.Size(818, 437);
            this.MainWorkSpacePanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.SlidesPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(818, 407);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // SlidesPanel
            // 
            this.SlidesPanel.AutoScroll = true;
            this.SlidesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.SlidesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlidesPanel.Location = new System.Drawing.Point(3, 3);
            this.SlidesPanel.Name = "SlidesPanel";
            this.SlidesPanel.Padding = new System.Windows.Forms.Padding(5);
            this.SlidesPanel.Size = new System.Drawing.Size(157, 401);
            this.SlidesPanel.TabIndex = 4;
            this.SlidesPanel.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(166, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 401);
            this.panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.QuestionTextGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AnswersGroupBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(649, 401);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // QuestionTextGroupBox
            // 
            this.QuestionTextGroupBox.AutoSize = true;
            this.QuestionTextGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuestionTextGroupBox.Controls.Add(this.QuestionTextBox);
            this.QuestionTextGroupBox.Controls.Add(this.QuestionTextLabel);
            this.QuestionTextGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionTextGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionTextGroupBox.Location = new System.Drawing.Point(10, 10);
            this.QuestionTextGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.QuestionTextGroupBox.Name = "QuestionTextGroupBox";
            this.QuestionTextGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.QuestionTextGroupBox.Size = new System.Drawing.Size(629, 112);
            this.QuestionTextGroupBox.TabIndex = 9;
            this.QuestionTextGroupBox.TabStop = false;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.QuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionTextBox.Location = new System.Drawing.Point(10, 40);
            this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionTextBox.Size = new System.Drawing.Size(609, 62);
            this.QuestionTextBox.TabIndex = 1;
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.QuestionTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionTextLabel.Location = new System.Drawing.Point(10, 23);
            this.QuestionTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(609, 17);
            this.QuestionTextLabel.TabIndex = 2;
            this.QuestionTextLabel.Text = "Текст вопроса";
            this.QuestionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnswersGroupBox
            // 
            this.AnswersGroupBox.Controls.Add(this.panel3);
            this.AnswersGroupBox.Controls.Add(this.AnswerTextLabel);
            this.AnswersGroupBox.Controls.Add(this.AddAnswerButton);
            this.AnswersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswersGroupBox.Location = new System.Drawing.Point(10, 142);
            this.AnswersGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.AnswersGroupBox.Name = "AnswersGroupBox";
            this.AnswersGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.AnswersGroupBox.Size = new System.Drawing.Size(629, 249);
            this.AnswersGroupBox.TabIndex = 13;
            this.AnswersGroupBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 169);
            this.panel3.TabIndex = 6;
            // 
            // AnswerTextLabel
            // 
            this.AnswerTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(107)))));
            this.AnswerTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnswerTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextLabel.ForeColor = System.Drawing.Color.White;
            this.AnswerTextLabel.Location = new System.Drawing.Point(10, 23);
            this.AnswerTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AnswerTextLabel.Name = "AnswerTextLabel";
            this.AnswerTextLabel.Size = new System.Drawing.Size(609, 17);
            this.AnswerTextLabel.TabIndex = 4;
            this.AnswerTextLabel.Text = "Ответы";
            this.AnswerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.AddAnswerButton.Location = new System.Drawing.Point(10, 209);
            this.AddAnswerButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(609, 30);
            this.AddAnswerButton.TabIndex = 5;
            this.AddAnswerButton.Text = "Добавить ответ";
            this.AddAnswerButton.UseVisualStyleBackColor = false;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ToolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {

            this.toolStripButtonAddQuestion,
            this.toolStripButtonSettings});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 30);

            this.ToolStripMain.Name = "ToolStripMain";

            this.ToolStripMain.Size = new System.Drawing.Size(818, 27);

            this.ToolStripMain.TabIndex = 2;
            this.ToolStripMain.Text = "toolStrip1";
            this.ToolStripMain.Visible = false;
            // 
            // toolStripButtonAddQuestion
            // 

            this.toolStripButtonAddQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.toolStripButtonAddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddQuestion.Image")));
            this.toolStripButtonAddQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddQuestion.Name = "toolStripButtonAddQuestion";
            this.toolStripButtonAddQuestion.Size = new System.Drawing.Size(126, 24);
            this.toolStripButtonAddQuestion.Text = "Добавить вопрос";
            this.toolStripButtonAddQuestion.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.toolStripButtonSettings.Image = global::IsputCSharpWinFormsV2.Properties.Resources.icons8_settings_32__1_;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(91, 24);
            this.toolStripButtonSettings.Text = "Настройки";
            this.toolStripButtonSettings.ToolTipText = "Настройки";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);

            // 
            // ToolStripInsert
            // 
            this.ToolStripInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ToolStripInsert.ImageScalingSize = new System.Drawing.Size(20, 20);

            this.ToolStripInsert.Location = new System.Drawing.Point(0, 30);
            this.ToolStripInsert.Name = "ToolStripInsert";

            this.ToolStripInsert.Size = new System.Drawing.Size(818, 25);

            this.ToolStripInsert.TabIndex = 3;
            this.ToolStripInsert.Text = "toolStrip1";
            this.ToolStripInsert.Visible = false;
            // 
            // TabsLayoutPanel
            // 
            this.TabsLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.TabsLayoutPanel.ColumnCount = 4;

            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TabsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 578F));

            this.TabsLayoutPanel.Controls.Add(this.InsertTabButton, 2, 0);
            this.TabsLayoutPanel.Controls.Add(this.FileTabButton, 0, 0);
            this.TabsLayoutPanel.Controls.Add(this.MainTabButton, 1, 0);
            this.TabsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TabsLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabsLayoutPanel.Name = "TabsLayoutPanel";
            this.TabsLayoutPanel.RowCount = 1;
            this.TabsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.TabsLayoutPanel.Size = new System.Drawing.Size(818, 30);

            this.TabsLayoutPanel.TabIndex = 1;
            // 
            // InsertTabButton
            // 
            this.InsertTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertTabButton.FlatAppearance.BorderSize = 0;
            this.InsertTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.InsertTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.InsertTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertTabButton.ForeColor = System.Drawing.Color.White;
            this.InsertTabButton.Location = new System.Drawing.Point(215, 0);
            this.InsertTabButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.InsertTabButton.Name = "InsertTabButton";
            this.InsertTabButton.Size = new System.Drawing.Size(105, 37);
            this.InsertTabButton.TabIndex = 2;
            this.InsertTabButton.Text = "Вставка";
            this.InsertTabButton.UseVisualStyleBackColor = true;
            this.InsertTabButton.Click += new System.EventHandler(this.TabButton_Click);
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
            this.FileTabButton.Size = new System.Drawing.Size(106, 37);
            this.FileTabButton.TabIndex = 0;
            this.FileTabButton.Text = "Файл";
            this.FileTabButton.UseVisualStyleBackColor = true;
            this.FileTabButton.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // MainTabButton
            // 
            this.MainTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabButton.FlatAppearance.BorderSize = 0;
            this.MainTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.MainTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.MainTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabButton.ForeColor = System.Drawing.Color.White;
            this.MainTabButton.Location = new System.Drawing.Point(108, 0);
            this.MainTabButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MainTabButton.Name = "MainTabButton";
            this.MainTabButton.Size = new System.Drawing.Size(105, 37);
            this.MainTabButton.TabIndex = 1;
            this.MainTabButton.Text = "Главная";
            this.MainTabButton.UseVisualStyleBackColor = true;
            this.MainTabButton.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.Header.Controls.Add(this.ButtonMaximizeWindow);
            this.Header.Controls.Add(this.ButtonMinimizeWindow);
            this.Header.Controls.Add(this.ButtonCloseWindow);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header.Name = "Header";

            this.Header.Size = new System.Drawing.Size(818, 32);

            this.Header.TabIndex = 0;
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

            this.ButtonMaximizeWindow.Location = new System.Drawing.Point(746, 0);
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

            this.ButtonMinimizeWindow.Location = new System.Drawing.Point(710, 0);
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

            this.ButtonCloseWindow.Location = new System.Drawing.Point(782, 0);
            this.ButtonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(36, 32);

            this.ButtonCloseWindow.TabIndex = 0;
            this.ButtonCloseWindow.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ResizePictureBox);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Enabled = false;

            this.BottomPanel.Location = new System.Drawing.Point(0, 469);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(818, 32);

            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // ResizePictureBox
            // 
            this.ResizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ResizePictureBox.Image")));

            this.ResizePictureBox.Location = new System.Drawing.Point(786, 0);
            this.ResizePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResizePictureBox.Name = "ResizePictureBox";
            this.ResizePictureBox.Size = new System.Drawing.Size(32, 32);

            this.ResizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ResizePictureBox.TabIndex = 1;
            this.ResizePictureBox.TabStop = false;
            // 
            // LeftMenuAndInfPanel
            // 
            this.LeftMenuAndInfPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LeftMenuAndInfPanel.Controls.Add(this.LeftMenuPanel);
            this.LeftMenuAndInfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftMenuAndInfPanel.Location = new System.Drawing.Point(0, 39);
            this.LeftMenuAndInfPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftMenuAndInfPanel.Name = "LeftMenuAndInfPanel";

            this.LeftMenuAndInfPanel.Size = new System.Drawing.Size(818, 437);

            this.LeftMenuAndInfPanel.TabIndex = 4;
            // 
            // LeftMenuPanel
            // 
            this.LeftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.LeftMenuPanel.Controls.Add(this.tableLayoutPanel1);
            this.LeftMenuPanel.Controls.Add(this.BackButton);
            this.LeftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMenuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftMenuPanel.Name = "LeftMenuPanel";

            this.LeftMenuPanel.Size = new System.Drawing.Size(128, 437);

            this.LeftMenuPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SaveFileAsButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CreateFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveFileButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OpenFileButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 118);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());

            this.tableLayoutPanel1.Size = new System.Drawing.Size(128, 341);

            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SaveFileAsButton
            // 
            this.SaveFileAsButton.FlatAppearance.BorderSize = 0;
            this.SaveFileAsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.SaveFileAsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.SaveFileAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileAsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileAsButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileAsButton.Location = new System.Drawing.Point(0, 177);
            this.SaveFileAsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveFileAsButton.Name = "SaveFileAsButton";
            this.SaveFileAsButton.Size = new System.Drawing.Size(171, 59);
            this.SaveFileAsButton.TabIndex = 3;
            this.SaveFileAsButton.Text = "Сохранить как";
            this.SaveFileAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveFileAsButton.UseVisualStyleBackColor = true;
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
            this.CreateFileButton.Size = new System.Drawing.Size(171, 59);
            this.CreateFileButton.TabIndex = 0;
            this.CreateFileButton.Text = "Создать";
            this.CreateFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateFileButton.UseVisualStyleBackColor = true;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.SaveFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileButton.Location = new System.Drawing.Point(0, 118);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(171, 59);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "Сохранить";
            this.SaveFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveFileButton.UseVisualStyleBackColor = true;
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
            this.OpenFileButton.Location = new System.Drawing.Point(0, 59);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(171, 59);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Открыть";
            this.OpenFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::IsputCSharpWinFormsV2.Properties.Resources.Back_Arrow_64px;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(93)))), ((int)(((byte)(149)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(171, 118);
            this.BackButton.TabIndex = 0;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));

            this.ClientSize = new System.Drawing.Size(818, 501);

            this.Controls.Add(this.MainWorkSpacePanel);
            this.Controls.Add(this.LeftMenuAndInfPanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.BottomPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainWorkSpacePanel.ResumeLayout(false);
            this.MainWorkSpacePanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.QuestionTextGroupBox.ResumeLayout(false);
            this.QuestionTextGroupBox.PerformLayout();
            this.AnswersGroupBox.ResumeLayout(false);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.TabsLayoutPanel.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePictureBox)).EndInit();
            this.LeftMenuAndInfPanel.ResumeLayout(false);
            this.LeftMenuPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainWorkSpacePanel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ButtonMaximizeWindow;
        private System.Windows.Forms.Button ButtonMinimizeWindow;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox ResizePictureBox;
        private System.Windows.Forms.TableLayoutPanel TabsLayoutPanel;
        private System.Windows.Forms.Button FileTabButton;
        private System.Windows.Forms.Button MainTabButton;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.Button InsertTabButton;
        private System.Windows.Forms.ToolStrip ToolStripInsert;
        private System.Windows.Forms.Panel LeftMenuAndInfPanel;
        private System.Windows.Forms.Panel LeftMenuPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileAsButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddQuestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SlidesPanel;
        private System.Windows.Forms.GroupBox QuestionTextGroupBox;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.GroupBox AnswersGroupBox;
        private System.Windows.Forms.Label AnswerTextLabel;
        private System.Windows.Forms.Button AddAnswerButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
    }
}

