using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Runtime.InteropServices;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace IsputCSharpWinFormsV2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Інформація про тести
        /// </summary>
        int indexQuestion;
        Thread thread;
        Question currentQuestion {
            get
            {
                if (Manager.Instance.CurrentTest.Questions.Count != 0)
                    return Manager.Instance.CurrentTest.Questions[indexQuestion];
                else
                    return null;
            }
        }
        int indexAnswer;
        Control currentPanel;

        /// </summary>
        private int activeAnswer = -1;
        private System.Drawing.Point mouseStart;
        private System.Drawing.Point mouseEnd;
        private bool isStartMatching;
        private int numberMatch;
        private int variantMatch;
        Bitmap defImageSlide;
        TestData test;
        bool openStartPage;



        public MainForm()
        {
            InitializeComponent();


            _arrows = new List<GraphicsPath>();
            openStartPage = true;
            //Program.arg.Add("C:\\Users\\Maxon\\Desktop\\pas.tst");
            for (int i = 0; i < Program.arg.Count; i++)
            {
                if (Program.arg[i].Split('.')[Program.arg[i].Split('.').Length - 1] == "tst")
                {
                    //ReadWriteTest.GetInstance().ReadTest(Program.arg[i]);
                    openStartPage = false;
                }
            }
            if (openStartPage)
                textBoxPassword.Visible = false;

            SetCurrentPanel(tableLayoutPanelStart);

            for (int i = 0; i < Program.arg.Count; i++)
            {
                if (Program.arg[i].Split('.')[Program.arg[i].Split('.').Length - 1] == "tst")
                {
                    ReadWriteTest.GetInstance().ReadTest(Program.arg[i]);
                }
            }

            //tableLayoutPanelStart.Hide();
            //panelStartGoTest.Visible = true;
            //panelStartGoTest.BringToFront();
            comboBoxSubject.Items.Add(Subject.Відсутній);
            comboBoxSubject.Items.Add(Subject.Алгоритм);
            comboBoxSubject.Items.Add(Subject.Матем);
        }

        public void SetCurrentPanel(Control panel)
        {
            if (currentPanel != null)
                currentPanel.Visible = false;
            currentPanel = panel;
            currentPanel.Visible = true;
        }

        public void EditTest()
        {
            if (textBoxPassword.Text != Manager.Instance.CurrentTest.password && !openStartPage)
            {
                MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SetCurrentPanel(MainWorkSpacePanel);

                timerUpdateElements.Start();
                indexAnswer = 0;
                indexQuestion = 0;
                MouseMove += MainForm_MouseMove;
                MouseUp += MainForm_MouseUp;
                MouseDown += MainForm_MouseDown;
                Paint += MainForm_Paint;
                isStartMatching = false;

                MouseClick += (senders, evs) => UpdateSlideButton();

                this.FormBorderStyle = FormBorderStyle.None;
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.ResizeRedraw, true);

                LeftMenuAndInfPanel.Visible = false;
                MainWorkSpacePanel.Visible = true;

                ////udalit!!!
                //MainTestForm form = new MainTestForm();
                //form.Show();

                //ReadWriteTest.GetInstance().WriteTest();

                //test = new TestData();
                defImageSlide = new Bitmap(panel2.Width, panel2.Height);
                panel2.DrawToBitmap(defImageSlide, new System.Drawing.Rectangle(0, 0, panel2.Width, panel2.Height));


                //Thread read = new Thread(KeyRead);
                //read.Start();

                //test.Show();

                for (int i = 0; i < 25; i++)
                {
                    indexAnswer = i;
                    ControlsForTextAnswer();
                    panel3.Controls[0].Visible = false;
                }

                TableLayoutPanelForMatchAnswer();
                for (int i = 0; i < 25; i++)
                {
                    indexAnswer = i;
                    ControlsForMatchAnswer();
                }
                //CreateSlideButton();
                //SlideGetFocus(this.SlidesPanel.Controls["0"]);

                //bool openStartPage = true;
                //Program.arg.Add("C:\\Users\\Maxon\\Desktop\\тесты\\tests.tst");
                openStartPage = true;
                for (int i = 0; i < Program.arg.Count; i++)
                {
                    if (Program.arg[i].Split('.')[Program.arg[i].Split('.').Length - 1] == "tst")
                    {
                        ReadWriteTest.GetInstance().ReadTest(Program.arg[i]);
                        currentFileName = Program.arg[i];
                        SlidesPanel.Controls.Clear();
                        for (int j = 0; j < Manager.Instance.CurrentTest.variantCount; j++)
                        {
                            if (j > 0)
                            {
                                CheckBox variant = new CheckBox()
                                {
                                    Dock = DockStyle.Left,
                                    Text = (j + 1).ToString(),
                                    Name = "VariantCheckbox_" + j,
                                    Checked = currentQuestion.InVariant[j],
                                    AutoSize = true
                                };
                                variant.CheckedChanged += Variant_CheckedChanged;
                                panelCheckBoxVariant.Controls.Add(variant);
                            }
                            else
                                (panelCheckBoxVariant.Controls["VariantCheckbox_" + 0] as CheckBox).Checked = currentQuestion.InVariant[0];
                        }
                        UIForTets();
                        openStartPage = false;
                        break;
                    }
                }

                if (openStartPage)
                {
                    //Manager.Instance.CurrentTest.Questions.Add(new Question());
                    //UIForTets();
                    CreateSlideButton();
                    needSave = true;
                    saveAs = true;
                }
                else
                {
                    needSave = true;
                    saveAs = false;
                }
           
            }
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            //SettingsForm settingsForm = new SettingsForm();
            //settingsForm.ShowDialog();
            SetCurrentPanel(panelSetting);
        }

        private void toolStripButtonCreateQuestion_Click(object sender, EventArgs e)
        {
            CreateSlideButton();
        }

        private void UpdateSlideButton()
        {
            //Кнопка-слайдом
            Bitmap printscreen = new Bitmap(panel2.Width, panel2.Height);
            panel2.DrawToBitmap(printscreen, new System.Drawing.Rectangle(0, 0, panel2.Width, panel2.Height));
            SlidesPanel.Controls[indexQuestion].BackgroundImage = printscreen;   
        }

        private void CreateSlideButton()
        {
            //Створ нове питання
            Manager.Instance.CurrentTest.Questions.Add(new Question());
            indexQuestion = Manager.Instance.CurrentTest.Questions.Count - 1;
            //Панель з питаннями та відповідями очищується
            if (panel3.Controls[MatchCnt.matchLayoutPanel.ToString()] != null)
            {
                for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchleft.ToString()].Controls.Count; i++)
                {
                    panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchleft.ToString()].Controls[i].Visible = false;
                }
                for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchRight.ToString()].Controls.Count; i++)
                {
                    panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchRight.ToString()].Controls[i].Visible = false;
                }
                for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchingLines.ToString()].Controls.Count; i++)
                {
                    panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchingLines.ToString()].Controls[i].Visible = false;
                }
            }
            for (int i = 0; i < panel3.Controls.Count; i++)
            {
                panel3.Controls[i].Visible = false;
            }
            //panel3.Controls.Clear();
            textToolStripMenuItem.Enabled = true;
            variantToolStripMenuItem.Enabled = true;
            matchToolStripMenuItem.Enabled = true;
            imageToolStripMenuItem.Enabled = true;

            CreateUIForSlide(Manager.Instance.CurrentTest.Questions.Count);
        }

        public void CreateUIForSlide(int num)
        {
            //int num = num;/*Manager.Instance.CurrentTest.Questions.Count*/;
                //.SlidesPanel.Controls.Count - 1;
            Button pictureButton = new Button
            {
                Name = (num - 1).ToString(),
                BackgroundImage = this.defImageSlide,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat
            };
            pictureButton.ContextMenuStrip = contextMenuStripSlideDel;
            Label questionNumberLabel = new Label
            {
                Name = "questionNumberLabel_" + (num - 1).ToString(),
                Text = num.ToString(),
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Padding = new Padding(3, 6, 3, 3),
            };
            pictureButton.FlatAppearance.BorderSize = 1;
            pictureButton.FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);
            pictureButton.MouseEnter += (object sender2, EventArgs e2) =>
            {
                if (Convert.ToInt32((sender2 as Button).Name) != indexQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(60, 155, 200);
            };
            pictureButton.MouseLeave += delegate (object sender2, EventArgs e2)
            {
                if (Convert.ToInt32((sender2 as Button).Name) != indexQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);
            };
            pictureButton.MouseDown += delegate (object sender2, MouseEventArgs e2)
            {
                timerUpdateElements.Stop();
            };
            pictureButton.MouseClick += delegate (object sender2, MouseEventArgs e2)
            {
                SlideGetFocus(sender2);
            };
            SlidesPanel.Controls.Add(pictureButton);
            SlidesPanel.Controls.Add(questionNumberLabel);

            pictureButton.Size = new Size(pictureButton.Size.Width, (int)(pictureButton.Size.Width * 0.75f));

            SlidesPanel.Controls.SetChildIndex(questionNumberLabel, 0);
            SlidesPanel.Controls.SetChildIndex(pictureButton, 0);

            pictureButton.GotFocus += (senderPB, ev) =>
            {
                for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                    if (SlidesPanel.Controls[i] is Button)
                        (SlidesPanel.Controls[i] as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

                (senderPB as Button).FlatAppearance.BorderColor = Color.White;
                indexQuestion = Convert.ToInt32(((senderPB as Button).Name));
            };
            for (int i = 0; i < Manager.Instance.CurrentTest.variantCount; i++)
            {
                (panelCheckBoxVariant.Controls["VariantCheckbox_" + i] as CheckBox).Checked = currentQuestion.InVariant[i];
            }
            pictureButton.Focus();
        }

        public void SlideGetFocus(object sender2)
        {
            for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                if (SlidesPanel.Controls[i] is Button)
                    (SlidesPanel.Controls[i] as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

            (sender2 as Button).FlatAppearance.BorderColor = Color.White;
            indexQuestion = Convert.ToInt32(((sender2 as Button).Name));
            //Панель з питаннями та відповідями очищується
            QuestionGroupBox.Controls.Clear();
            if (panel3.Controls[MatchCnt.matchLayoutPanel.ToString()] != null)
            {
                for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchleft.ToString()].Controls.Count; i++)
                {
                    panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchleft.ToString()].Controls[i].Visible = false;
                }
                for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchRight.ToString()].Controls.Count; i++)
                {
                    panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchRight.ToString()].Controls[i].Visible = false;
                }
                for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchingLines.ToString()].Controls.Count; i++)
                {
                    panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchingLines.ToString()].Controls[i].Visible = false;
                }
            }
            for (int i = 0; i < panel3.Controls.Count; i++)
            {
                panel3.Controls[i].Visible = false;
            }
            //panel3.Controls.Clear();
            //Отрисовка вопроса
            if (currentQuestion.Text.Count != 0)
            {
                if (!currentQuestion.graphicInQuestion)
                {
                    ControlsForTextQuestion();
                }
                else
                {
                    ControlsForImageQuestion();
                    QuestionGroupBox.Controls[0].Text = currentQuestion.Text[0];
                    (QuestionGroupBox.Controls[1] as PictureBox).Image = StringToImage(currentQuestion.Text[1]);
                }
            }
            else
            {
                EnableQuestion(true);
            }
            
            //Відображення питань
            if (currentQuestion.Answers.Count != 0)
            {
                if (currentQuestion.Answers[0] is AnswerText)
                {
                    for (int i = 0; i < currentQuestion.Answers.Count; i++)
                    {
                        indexAnswer = i;
                        EnableControlTextAnswer();
                    }
                }
                if (currentQuestion.Answers[0] is AnswerMatch)
                {
                    TableLayoutPanelForMatchAnswer();
                    for (int i = 0; i < currentQuestion.Answers.Count; i++)
                    {
                        indexAnswer = i;
                        EnableControlMatchAnswer();
                    }
                }
            }
            else
            {
                variantToolStripMenuItem.Enabled = true;
                matchToolStripMenuItem.Enabled = true;
            }

            for (int i = 0; i < Manager.Instance.CurrentTest.variantCount; i++)
            {
                (panelCheckBoxVariant.Controls["VariantCheckbox_" + i] as CheckBox).Checked = currentQuestion.InVariant[i];
            }

            EnableToolStrip();

            timerUpdateElements.Start();
        }

        public void EnableToolStrip()
        {
            EnableQuestion(currentQuestion.Text.Count == 0);
            if (currentQuestion.Answers.Count != 0)
            {
                if (currentQuestion.Answers[0] is AnswerText)
                {
                    variantToolStripMenuItem.Enabled = true;
                    matchToolStripMenuItem.Enabled = false;
                }
                else
                {
                    matchToolStripMenuItem.Enabled = true;
                    variantToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                matchToolStripMenuItem.Enabled = true;
                variantToolStripMenuItem.Enabled = true;
            }
        }
        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            test.UpdateForm(Program.arg, indexQuestion);
            
        }

        //Видалення кнопки з питанням
        private void slidedelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Manager.Instance.CurrentTest.Questions.Count > 1)
            {
                int num = Convert.ToInt32(indexQuestion);
                SlidesPanel.Controls.RemoveByKey(num.ToString());
                SlidesPanel.Controls.RemoveByKey("questionNumberLabel_" + num);
                Manager.Instance.CurrentTest.Questions.RemoveAt(indexQuestion);
                if (indexQuestion != 0)
                    indexQuestion--;
                string[] splitStr;
                for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                {
                    splitStr = SlidesPanel.Controls[i].Name.Split('_');
                    if (splitStr[0] != "questionNumberLabel")
                    {
                        int number = Convert.ToInt32(SlidesPanel.Controls[i].Name);
                        if (number > num)
                        {
                            SlidesPanel.Controls.SetChildIndex(SlidesPanel.Controls[number.ToString()], 0);
                            SlidesPanel.Controls[number.ToString()].Name = (number - 1).ToString();
                        }
                    }
                    else
                    {
                        int number = Convert.ToInt32(splitStr[1]);
                        if (number > num)
                        {
                            SlidesPanel.Controls.SetChildIndex(SlidesPanel.Controls["questionNumberLabel_" + number], 0);
                            SlidesPanel.Controls["questionNumberLabel_" + number].Text = (number).ToString();
                            SlidesPanel.Controls["questionNumberLabel_" + number].Name = "questionNumberLabel_" + (number - 1);
                        }
                    }
                }
                for (int i = 0; i < SlidesPanel.Controls.Count / 2; i++)
                {
                    SlidesPanel.Controls.SetChildIndex(SlidesPanel.Controls["questionNumberLabel_" + i], 0);
                    SlidesPanel.Controls.SetChildIndex(SlidesPanel.Controls[i.ToString()], 0);
                }
                SlidesPanel.Controls[indexQuestion.ToString()].Focus();
                SlideGetFocus(SlidesPanel.Controls[indexQuestion.ToString()]);
            }
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSlideButton();
        }

        private void timerUpdateElements_Tick(object sender, EventArgs e)
        {
            UpdateSlidePanelControls();
        }

        public void UpdateSlidePanelControls()
        {
            //Кнопка-слайдом
            Bitmap printscreen = new Bitmap(panel2.Width, panel2.Height);
            panel2.DrawToBitmap(printscreen, new System.Drawing.Rectangle(0, 0, panel2.Width, panel2.Height));
            for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                if (SlidesPanel.Controls[i] is Button)
                    if (SlidesPanel.Controls[i].Name == indexQuestion.ToString())
                        (SlidesPanel.Controls[i] as Button).BackgroundImage = printscreen;
            //test.UpdateForm(new List<string>(), indexQuestion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls[0].Visible = false;
        }

        private void contextMenuStripAnswers_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDownVariantCount_ValueChanged(object sender, EventArgs e)
        {
            int oldVarCount = Manager.Instance.CurrentTest.variantCount;
            Manager.Instance.CurrentTest.variantCount = Convert.ToInt32(numericUpDownVariantCount.Value);
            //panelCheckBoxVariant.Controls.Clear();
            for (int i = 0; i < Manager.Instance.CurrentTest.variantCount; i++)
            {
                if (panelCheckBoxVariant.Controls["VariantCheckbox_" + i] == null)
                {
                    for (int j = 0; j < Manager.Instance.CurrentTest.Questions.Count; j++)
                        Manager.Instance.CurrentTest.Questions[j].InVariant.Add(false);
                    CheckBox variant = new CheckBox()
                    {
                        Dock = DockStyle.Left,
                        Text = (i + 1).ToString(),
                        Name = "VariantCheckbox_" + i, 
                        AutoSize = true
                    };
                    if (currentQuestion != null)
                        variant.Checked = currentQuestion.InVariant[i];
                    variant.CheckedChanged += Variant_CheckedChanged;
                    panelCheckBoxVariant.Controls.Add(variant);
                }
            }
            for (int i = Manager.Instance.CurrentTest.variantCount; i < oldVarCount; i++)
            {
                panelCheckBoxVariant.Controls.RemoveByKey("VariantCheckbox_" + i);
                for (int j = 0; j < Manager.Instance.CurrentTest.Questions.Count; j++)
                    Manager.Instance.CurrentTest.Questions[j].InVariant.RemoveAt(i);
            }
        }

        private void Variant_CheckedChanged(object sender, EventArgs e)
        {
            string[] name = (sender as Control).Name.Split('_');
            currentQuestion.InVariant[Convert.ToInt32(name[1])] = (sender as CheckBox).Checked;
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (!saveAs)
            {
                for (int i = 0; i < Manager.Instance.CurrentTest.Questions.Count; i++)
                {
                    Manager.Instance.CurrentTest.Questions[i].ImageSlide = SlidesPanel.Controls[i.ToString()].BackgroundImage;
                }
                ReadWriteTest.GetInstance().WriteTest(currentFileName);
            }
            else
                SaveAs();
        }

        private void buttonGoTest_Click(object sender, EventArgs e)
        {
            SetCurrentPanel(panelStartGoTest);
            for (int i = 0; i < Manager.Instance.CurrentTest.variantCount; i++)
            {
                comboBoxVariant.Items.Add(i + 1);
            }
            comboBoxVariant.Text = "1";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditTest();
        }

        private void SavePassswordBut_Click(object sender, EventArgs e)
        {
            Manager.Instance.CurrentTest.password = textBoxChangePass.Text;
            MessageBox.Show("Успішно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetCurrentPanel(MainWorkSpacePanel);
        }

        private void buttonStartGoTest_Click(object sender, EventArgs e)
        {
            //Program.arg.Add("C:\\Users\\Maxon\\Desktop\\тесты\\tests.tst");
            for (int i = 0; i < Program.arg.Count; i++)
            {
                if (Program.arg[i].Split('.')[Program.arg[i].Split('.').Length - 1] == "tst")
                {
                    ReadWriteTest.GetInstance().ReadTest(Program.arg[i]);
                    break;
                }
            }
            if (MessageBox.Show("Розпочати тестування", "Перевірка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SetCurrentPanel(panelTestRun);
                Manager.Instance.SetQuestionsForTest(Convert.ToInt32(comboBoxVariant.Text));
                Manager.GoTest goTestQues = Manager.Instance.goTest;
                CreateButtonsReferenceToQuestions();
                Manager.Instance.goTest.indexQuestion = 0;
                ShowQuestion();
            }
        }

        public void CreateButtonsReferenceToQuestions()
        {
            for (int i = 0; i < Manager.Instance.goTest.questions.Count; i++)
            {
                Button nextPanel = new Button()
                {
                    Name = i.ToString(),
                    Text = (i + 1).ToString(),
                    Size = new Size(32, 32),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Location = new Point((i % 25) * 34 + 5, (int)(i / 25) * 34 + 5)
                };
                nextPanel.Font = new System.Drawing.Font("Times New Roman", 7);
                nextPanel.Click += NextPanel_Click;
                SlidesPanelInTest.Controls.Add(nextPanel);
            }
        }

        private void NextPanel_Click(object sender, EventArgs e)
        {
            Manager.Instance.goTest.indexQuestion = Convert.ToInt32((sender as Control).Name);
            ShowQuestion();
        }
        /// <summary>
        /// Контроли для графічного питання
        /// </summary>
        void GraphicControlQuestion(Question question)
        {
            PictureBox questionPicture = new PictureBox()
            {
                Name = "questionPictureBox",
                Dock = DockStyle.Left,
                SizeMode = PictureBoxSizeMode.Zoom,
                Padding = new Padding(5),
                BackColor = Color.White,
                Size = new Size(300, 100),
                Image = StringToImage(question.Text[1])
            };
            panelQuestion.Controls.Add(questionPicture);
            panelQuestion.Controls.SetChildIndex(questionPicture, 0);
            questionPicture.Invalidate();
            Label questionTextBox = new Label()
            {
                Name = "labelQuestion",
                Dock = DockStyle.Top,
                Text = question.Text[0],
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Times New Roman", 16),
                AutoSize = false
            };
            panelQuestion.Controls.Add(questionTextBox);
            panelQuestion.Controls.SetChildIndex(questionTextBox, 0);
        }

        /// <summary>
        /// Контроли для текстового питання
        /// </summary>
        void TextControlQuestion(Question question)
        {
            Label questionTextBox = new Label()
            {
                Name = "labelQuestion",
                Dock = DockStyle.Fill,
                Text = question.Text[0],
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Times New Roman", 16),
                AutoSize = false,
            };
            panelQuestion.Controls.Add(questionTextBox);
            panelQuestion.Controls.SetChildIndex(questionTextBox, 0);
        }

        /// <summary>
        /// Контроли для текстової відповіді
        /// </summary>
        /// <param name="question"></param>
        void ControlForTextAnswer(Question question)
        {
            for (int i = 0; i < question.Answers.Count; i++)
            {
                ///
                GroupBox groupBox = new GroupBox
                {
                    Size = new Size(450, 44),
                    Dock = DockStyle.Top,
                    Padding = new Padding(10, 2, 2, 2),
                    Name = "Answer_" + i,
                    Font = DefaultFont,
                };
                ///
                CheckBox checkBox = new CheckBox
                {
                    Size = new Size(25, 25),
                    Dock = DockStyle.Right,
                    Padding = new Padding(6, 0, 0, 5),
                    Name = i.ToString(),
                };
                //Write userAnswer
                checkBox.CheckedChanged += (sender, ev) =>
                {
                    (Manager.Instance.goTest.userQuestions[Manager.Instance.goTest.indexQuestion].
                        Answers[Convert.ToInt32((sender as Control).Name)] as AnswerText).Right = (sender as CheckBox).Checked;
                    for (int j = 0; j < panelAnswer.Controls.Count; j++)
                    {
                        if (panelAnswer.Controls["Answer_" + j].Controls[j.ToString()] is CheckBox)
                        {
                            if ((panelAnswer.Controls["Answer_" + j].Controls[j.ToString()] as CheckBox).Checked)
                            {
                                SlidesPanelInTest.Controls[Manager.Instance.goTest.indexQuestion].BackColor = Color.Gray;
                                return;
                            }
                        }
                    }
                    SlidesPanelInTest.Controls[Manager.Instance.goTest.indexQuestion].BackColor = Color.White;
                };
                ///
                Label textBox = new Label
                {
                    Size = new Size(10, 20),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0),
                    Name = "TextBox_" + indexAnswer,
                    Text = (question.Answers[i] as AnswerText).Text,
                    ForeColor = Color.White
                };
                groupBox.Controls.AddRange(new Control[] { checkBox, textBox });
                groupBox.ContextMenuStrip = contextMenuStripAnswers;
                panelAnswer.Controls.Add(groupBox);
                panelAnswer.Controls.SetChildIndex(groupBox, 0);
            }
        }

        /// <summary>
        /// Контроли для відповіді-зєднання
        /// </summary>
        void ControlForMatchAnswer(Question question)
        {
            int yDelta = 0;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Label labelAnswerLeft = new Label()
                {
                    Dock = DockStyle.Top,
                    Text = (i + 1) + ". " + (question.Answers[i] as AnswerMatch).Text.Key,
                    ForeColor = Color.White
                };
                Label labelAnswerRight = new Label()
                {
                    Dock = DockStyle.Top,
                    Text = Convert.ToChar(i + 1072) + ". " + (question.Answers[i] as AnswerMatch).Text.Value,
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.TopRight
                };
                panelAnswer.Controls.Add(labelAnswerLeft);
                panelAnswer.Controls.SetChildIndex(labelAnswerLeft, 0);

                panelAnswer.Controls.Add(labelAnswerRight);
                panelAnswer.Controls.SetChildIndex(labelAnswerRight, 0);

                yDelta = labelAnswerRight.Location.Y;
            }

            yDelta += 64;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Label label = new Label()
                {
                    Text = (i + 1).ToString(),
                    ForeColor = Color.White,
                    Location = new Point(3, (i % 10) * 34 + 5 + yDelta),
                    AutoSize = true
                };
                label.Font = new System.Drawing.Font("Times New Roman", 10);
                panelAnswer.Controls.Add(label);
                label = new Label()
                {
                    Text = Convert.ToChar(i + 1072).ToString(),
                    ForeColor = Color.White,
                    Location = new Point(i * 34 + 38, yDelta - 16),
                    AutoSize = true
                };
                label.Font = new System.Drawing.Font("Times New Roman", 10);
                panelAnswer.Controls.Add(label);
            }

            for (int i = 0; i < question.Answers.Count; i++)
            {
                for (int j = 0; j < question.Answers.Count; j++)
                {
                    Button nextPanel = new Button()
                    {
                        Name = i + "_" + j,
                        //Text = i + "_" + j,
                        Size = new Size(32, 32),
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Location = new Point(j * 34 + 32, (i % 10) * 34 + 5 + yDelta)
                    };

                    nextPanel.Click += (sender, ev) =>
                    {
                        Button button = (sender as Button);
                        string[] buttonName = button.Name.Split('_');
                        int x = Convert.ToInt32(buttonName[0]), y = Convert.ToInt32(buttonName[1]);
                        (Manager.Instance.goTest.userQuestions[Manager.Instance.goTest.indexQuestion].Answers.
                           Find(obj => (obj as AnswerMatch).Number == x) as AnswerMatch).RightVariant = y;
                        for (int k = 0; k < question.Answers.Count; k++)
                        {
                            (panelAnswer.Controls.Find(x + "_" + k.ToString(), false)[0] as Button).BackColor = Color.White;
                        }
                        button.BackColor = Color.Gray;
                        SlidesPanelInTest.Controls[Manager.Instance.goTest.indexQuestion].BackColor = Color.Gray;
                    };
                    nextPanel.Font = new System.Drawing.Font("Times New Roman", 7);
                    panelAnswer.Controls.Add(nextPanel);
                }
            }
        }

        private void comboBoxVariant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SwitchQuestionButton_Click(object sender, EventArgs e)
        {
            Manager.Instance.goTest.indexQuestion++;
            ShowQuestion();   
        }

        /// <summary>
        /// Create Controls for current question
        /// </summary>
        public void ShowQuestion()
        {
            if (Manager.Instance.goTest.indexQuestion == Manager.Instance.goTest.questions.Count - 1)
                SwitchQuestionButton.Visible = false;
            else
                SwitchQuestionButton.Visible = true;

            Question question = Manager.Instance.goTest.questions[Manager.Instance.goTest.indexQuestion];
            //Створення елементів для питання
            panelQuestion.Controls.Clear();
            if (question.graphicInQuestion)
            {
                GraphicControlQuestion(question);
            }
            else
            {
                TextControlQuestion(question);
            }
            panelAnswer.Controls.Clear();
            if (question.Answers.Count != 0)
            {
                if (question.Answers[0] is AnswerText)
                {
                    ControlForTextAnswer(question);
                }
                else
                {
                    ControlForMatchAnswer(question);
                }
            }
        }

        //Підрахунок результатів
        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            Button curBut;
            int rightAns = 0, wrongAns = 0, ballCount = 0;
            int rightInOneAns = 0;
            int indexRightAns = 0;
            float percent;

            var document = new iTextSharp.text.Document();
            using (var writer = PdfWriter.GetInstance(document, new FileStream("result.pdf", FileMode.Create)))
            {
                document.Open();
                Paragraph p;

                iTextSharp.text.pdf.BaseFont bfR;
                bfR = iTextSharp.text.pdf.BaseFont.CreateFont("C:\\WINDOWS\\Fonts\\Arial.TTF",
                  iTextSharp.text.pdf.BaseFont.IDENTITY_H,
                  iTextSharp.text.pdf.BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bfR, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                document.Add(new Paragraph("Протокол тестування.", font));
                document.Add(new Paragraph("Здобувач освіти: " + textBoxPIB.Text, font));
                font.Size = 14;
                p = new Paragraph();
                p.Alignment = Element.ALIGN_LEFT;
                p.TabSettings = new TabSettings(100f);
                p.Add(Chunk.TABBING);
                p.Add(new Chunk("Правильний варіант", font));
                p.Add(Chunk.TABBING);
                p.Add(new Chunk("Вибраний варіант", font));
                document.Add(p);
                font.SetStyle(iTextSharp.text.Font.NORMAL);
                for (int i = 0; i < Manager.Instance.goTest.userQuestions.Count; i++)
                {
                    indexRightAns = 0;
                    rightInOneAns = 0;
                    //
                    curBut = (SlidesPanelInTest.Controls[i.ToString()] as Button);
                    curBut.Enabled = false;
                    curBut.BackColor = Color.Green;
                    //
                    if (Manager.Instance.goTest.userQuestions[i].Answers.Count > 0)
                    {
                        //TextAnswer
                        if (Manager.Instance.goTest.userQuestions[i].Answers[0] is AnswerText)
                        {
                            //Find index of right answers
                            for (int j = 0; j < Manager.Instance.goTest.userQuestions[i].Answers.Count; j++)
                            {
                                //
                                if ((Manager.Instance.goTest.questions[i].Answers[j] as AnswerText).Right)
                                {
                                    indexRightAns = j;
                                    //
                                    p = new Paragraph();
                                    p.TabSettings = new TabSettings(150f);
                                    p.Add(Chunk.TABBING);
                                    p.Add(new Chunk((indexRightAns + 1).ToString(), font));
                                    ballCount++;
                                    //
                                }
                            }
                            //if index of right answers == userAnswer index then ++ball
                            for (int j = 0; j < Manager.Instance.goTest.userQuestions[i].Answers.Count; j++)
                            {
                                if ((Manager.Instance.goTest.userQuestions[i].Answers[j] as AnswerText).Right)
                                {
                                    //
                                    p.TabSettings = new TabSettings(150f);
                                    p.Add(Chunk.TABBING);
                                    p.Add(new Chunk((j + 1).ToString(), font));
                                    document.Add(p);
                                    //
                                    if (j == indexRightAns)
                                        rightInOneAns++;
                                    else
                                    {
                                        wrongAns++;
                                        rightInOneAns = 0;
                                        break;
                                    }
                                }
                            }
                            if (rightInOneAns == 0)
                                curBut.BackColor = Color.Red;
                            rightAns += rightInOneAns;
                        }
                        //MatchAnwer
                        else
                        {
                            ballCount += Manager.Instance.goTest.questions[i].Answers.Count;
                            //
                            p = new Paragraph();
                            p.TabSettings = new TabSettings(150f);
                            p.Add(Chunk.TABBING);
                            //
                            //if index of right answers == userAnswer index then ++ball
                            for (int j = 0; j < Manager.Instance.goTest.questions[i].Answers.Count; j++)
                            {
                                p.Add(new Chunk((j + 1).ToString() + ") - " + ((Manager.Instance.goTest.questions[i].Answers[j] as AnswerMatch).RightVariant + 1).ToString() + " ", font));
                                //
                                if ((Manager.Instance.goTest.userQuestions[i].Answers[j] as AnswerMatch).RightVariant ==
                                    (Manager.Instance.goTest.questions[i].Answers[j] as AnswerMatch).RightVariant)
                                {
                                    rightAns++;
                                    rightInOneAns++;
                                }
                                else
                                {
                                    wrongAns++;
                                }
                            }
                            for (int j = 0; j < Manager.Instance.goTest.userQuestions[i].Answers.Count; j++)
                            {
                                p.Add(new Chunk((j + 1).ToString() + ") - " + ((Manager.Instance.goTest.userQuestions[i].Answers[j] as AnswerMatch).RightVariant + 1).ToString() + " ", font));
                                //
                            }
                            //
                            document.Add(p);
                            //
                            if (rightInOneAns == 0)
                            {
                                curBut.BackColor = Color.Red;
                            }
                            else if (rightInOneAns > 0 && rightInOneAns < Manager.Instance.goTest.userQuestions[i].Answers.Count)
                            {
                                curBut.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
                //
                percent = (float)rightAns / (ballCount) * 100f;
                //
                p = new Paragraph("\nВідсоток правильних відповідей: " + percent + " %", font);
                p.Alignment = Element.ALIGN_RIGHT;
                document.Add(p);
                document.Close();
            }
            
            

            //
            panelQuestion.Controls.Clear();
            panelAnswer.Controls.Clear();
            buttonEndTest.Visible = false;
            SwitchQuestionButton.Visible = false;
            Label labelRezult = new Label()
            {
                Text = "Балів: " + rightAns + " з " + (ballCount) + " можливих",
                Dock = DockStyle.Top,
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 14),
                ForeColor = Color.White
            };
            panelQuestion.Controls.Add(labelRezult);
            
            labelRezult.Text += Environment.NewLine + "Відсоток правильних відповідей: " + Math.Round(percent, 2) + " %";
        }


        private void toolStripButtonGoMenu_Click(object sender, EventArgs e)
        {
            if (needSave)
            {
                DialogResult rezult = MessageBox.Show(
                    "Зберегти зміни в " + currentFileName + "?",
                    "ТЕСТ",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (rezult == DialogResult.Yes)
                    Save();
                if (rezult != DialogResult.Cancel)
                {
                    SetCurrentPanel(tableLayoutPanelStart);
                    TopMost = true;
                }
                if (rezult == DialogResult.Cancel)
                    TopMost = true;
            }
            else
            {
                SetCurrentPanel(tableLayoutPanelStart);
                TopMost = true;
            }
        }


        /// <summary>
        /// LoadTestFromWord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonLoadTestFromWord_Click(object sender, EventArgs e)
        {
            if (Manager.Instance.LoadQuestionsFromWord())
            {
                SlidesPanel.Controls.Clear();
                for (int j = 0; j < Manager.Instance.CurrentTest.variantCount; j++)
                {
                    CheckBox variant = new CheckBox()
                    {
                        Dock = DockStyle.Left,
                        Text = (j + 1).ToString(),
                        Name = "VariantCheckbox_" + j,
                        Checked = currentQuestion.InVariant[j],
                        AutoSize = true
                    };
                    variant.CheckedChanged += Variant_CheckedChanged;
                    panelCheckBoxVariant.Controls.Add(variant);
                }
                UIForTets();
            }
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manager.Instance.CurrentTest.Questions[indexQuestion].subject = (Subject)Enum.Parse(typeof(Subject), (sender as ComboBox).Text);
        }
    }
}
