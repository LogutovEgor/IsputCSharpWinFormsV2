using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Runtime.InteropServices;

namespace IsputCSharpWinFormsV2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Інформація про тести
        /// </summary>
        int indexQuestion;
        Thread thread;
        Question currentQuestion { get { return Manager.Instance.CurrentTest.Questions[indexQuestion]; } }
        int indexAnswer;

        /// </summary>
        private int activeAnswer = -1;
        private Point mouseStart;
        private Point mouseEnd;
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
            Program.arg.Add("C:\\Users\\Maxon\\Desktop\\1.tst");
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

        }
        public void EditTest()
        {
            if (textBoxPassword.Text != Manager.Instance.CurrentTest.password && !openStartPage)
            {
                MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.tableLayoutPanelStart.Visible = false;
                timerUpdateElements.Start();
                this.MainWorkSpacePanel.BringToFront();
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

                test = new TestData();
                defImageSlide = new Bitmap(panel2.Width, panel2.Height);
                panel2.DrawToBitmap(defImageSlide, new Rectangle(0, 0, panel2.Width, panel2.Height));


                //Thread read = new Thread(KeyRead);
                //read.Start();

                test.Show();

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
                //Program.arg.Add("C:\\Users\\Maxon\\Desktop\\1.tst");
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
            this.panelSetting.Visible = true;
            panelSetting.BringToFront();
        }

        private void toolStripButtonCreateQuestion_Click(object sender, EventArgs e)
        {
            CreateSlideButton();
        }

        private void UpdateSlideButton()
        {
            //Кнопка-слайдом
            Bitmap printscreen = new Bitmap(panel2.Width, panel2.Height);
            panel2.DrawToBitmap(printscreen, new Rectangle(0, 0, panel2.Width, panel2.Height));
            SlidesPanel.Controls[indexQuestion].BackgroundImage = printscreen;   
        }

        private void CreateSlideButton()
        {
            //Створ нове питання
            Manager.Instance.CurrentTest.Questions.Add(new Question());
            indexQuestion = Manager.Instance.CurrentTest.Questions.Count - 1;
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
            panel2.DrawToBitmap(printscreen, new Rectangle(0, 0, panel2.Width, panel2.Height));
            for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                if (SlidesPanel.Controls[i] is Button)
                    if (SlidesPanel.Controls[i].Name == indexQuestion.ToString())
                        (SlidesPanel.Controls[i] as Button).BackgroundImage = printscreen;
            test.UpdateForm(new List<string>(), indexQuestion);
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
                        Checked = currentQuestion.InVariant[i],
                        AutoSize = true
                    };
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
            tableLayoutPanelStart.Visible = false;
            panelStartGoTest.Visible = true;
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
            panelSetting.Visible = false;
        }

        private void buttonStartGoTest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Розпочати тестування", "Перевірка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                panelTestRun.Visible = true;
                panelTestRun.BringToFront();
                panelStartGoTest.Visible = false;
                Manager.Instance.SetQuestionsForTest(Convert.ToInt32(comboBoxVariant.Text));
                Manager.GoTest goTestQues = Manager.Instance.goTest;
                QuestionComboBox.Items.Clear();
                for (int i = 0; i < goTestQues.questions.Count; i++)
                {
                    QuestionComboBox.Items.Add(i + 1);
                }
            }
        }

        private void comboBoxVariant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
