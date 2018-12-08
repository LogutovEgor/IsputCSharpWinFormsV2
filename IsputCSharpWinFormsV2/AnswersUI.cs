using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace IsputCSharpWinFormsV2
{
    //Функції Вкладка ВСТАВИТИ

    public partial class MainForm
    {
        //додавання текстової відповіді
        private void варіантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuestion.Answers.Add(new AnswerText());
            indexAnswer = panel3.Controls.Count;
            (currentQuestion.Answers[indexAnswer] as AnswerText).Right = false;
            matchToolStripMenuItem.Enabled = false;
            ///
            GroupBox groupBox = new GroupBox
            {
                Size = new Size(450, 44),
                Dock = DockStyle.Top,
                Padding = new Padding(10, 2, 2, 2),
                Text = "",
                Name = "Answer " + (currentQuestion.Answers.Count - 1),
                Font = DefaultFont
            };
            ///
            CheckBox checkBox = new CheckBox
            {
                Size = new Size(25, 25),
                Dock = DockStyle.Right,
                Padding = new Padding(6, 0, 0, 5),
                Name = "CheckBox_" + (currentQuestion.Answers.Count - 1)
            };
            checkBox.CheckedChanged += (senderCheck, ev) =>
            {
                (currentQuestion.Answers[indexAnswer] as AnswerText).Right = (senderCheck as CheckBox).Checked;
            };
            ///
            TextBox textBox = new TextBox
            {
                Size = new Size(10, 20),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Name = "TextBox_" + (currentQuestion.Answers.Count - 1),
            };
            textBox.TextChanged += (senderText, ev) =>
            {
                (currentQuestion.Answers[indexAnswer] as AnswerText).Text = (senderText as TextBox).Text;
            };
            groupBox.Controls.AddRange(new Control[] { checkBox, textBox });
            panel3.Controls.Add(groupBox);
            panel3.Controls.SetChildIndex(groupBox, 0);
            for (int i = 0; i < panel3.Controls[groupBox.Name].Controls.Count; i++)
            {
                panel3.Controls[groupBox.Name].Controls[i].GotFocus += GroupBox_GotFocus;
            }
            textBox.Focus();
        }

        //додавання питання зєднувач
        private void зєднанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuestion.Answers.Add(new AnswerMatch());
            if (panel3.Controls.Count != 0)
            {
                indexAnswer = panel3.Controls[ControlName.matchLayoutPanel.ToString()].
                    Controls[ControlName.panelMatchRight.ToString()].Controls.Count;
                //(currentQuestion.Answers[indexAnswer] as AnswerMatch).Number = 0;
                //(currentQuestion.Answers[indexAnswer] as AnswerMatch).RightVariant = 'a';
                //(currentQuestion.Answers[indexAnswer] as AnswerMatch).Variant = 'a';
            }
            else
            {
                indexAnswer = 0;
                //(currentQuestion.Answers[indexAnswer] as AnswerMatch).Number = 0;
                //(currentQuestion.Answers[indexAnswer] as AnswerMatch).RightVariant = 'a';
                //(currentQuestion.Answers[indexAnswer] as AnswerMatch).Variant = 'a';
            }
            //Створення tableLayout і panel
            if (panel3.Controls.Count == 0)
            {
                TableLayoutPanel matchLayoutPanel = new TableLayoutPanel()
                {
                    Dock = DockStyle.Fill,
                    RowCount = 1,
                    ColumnCount = 3,
                    Name = ControlName.matchLayoutPanel.ToString(),
                };
                matchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Percent, 100f));
                matchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 40f));
                matchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 20f));
                matchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 40f));
                panel3.Controls.Add(matchLayoutPanel);
                //Панель для відповідей праворуч
                Panel panelRight = new Panel()
                {
                    Name = ControlName.panelMatchRight.ToString(),
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                };
                //Панель для відповідей ліворуч
                Panel panelLeft = new Panel()
                {
                    Name = ControlName.panelMatchleft.ToString(),
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                };
                //Панель для зєднання точок питань
                Panel panelMatchingLines = new Panel()
                {
                    Name = ControlName.panelMatchingLines.ToString(),
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                matchLayoutPanel.Controls.Add(panelRight, 2, 0);
                matchLayoutPanel.Controls.Add(panelLeft, 0, 0);
                matchLayoutPanel.Controls.Add(panelMatchingLines, 1, 0);
            }
            Control.ControlCollection matchPanels = panel3.Controls["matchLayoutPanel"].Controls;
            //
            //Створення groupbox для питання справа
            GroupBox groupBoxQuestionLeft = new GroupBox()
            {
                Dock = DockStyle.Top,
                Text = "",
                Size = new Size(300, 35),
                Padding = new Padding(3)
            };
            TextBox textLeft = new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(groupBoxQuestionLeft.Width - 27, 22),
                Location = new Point(5, 10),
                Name = "textLeft_" + (currentQuestion.Answers.Count - 1).ToString(),
            };
            textLeft.TextChanged += (obj, EventArgs) =>
            {
                KeyValuePair<string, string> text = (currentQuestion.Answers[indexAnswer] as AnswerMatch).Text;
                (currentQuestion.Answers[indexAnswer] as AnswerMatch).Text = new KeyValuePair<string, string>(textLeft.Text, text.Value);
            };
            textLeft.GotFocus += (obj, EventArgs) =>
            {
                indexAnswer = Convert.ToInt32((obj as Control).Name.Split('_')[1]);
            };
            Label labelLeft = new Label()
            {
                Dock = DockStyle.Right,
                Text = (matchPanels["panelMatchLeft"].Controls.Count + 1).ToString(),
                AutoSize = true
            };
            (currentQuestion.Answers[indexAnswer] as AnswerMatch).Number = Convert.ToInt32(labelLeft.Text);
            groupBoxQuestionLeft.Controls.AddRange(new Control[] { textLeft, labelLeft });
            matchPanels["panelMatchLeft"].Controls.Add(groupBoxQuestionLeft);
            matchPanels["panelMatchLeft"].Controls.SetChildIndex(groupBoxQuestionLeft, 0);
            //
            //Створення groupbox для питання зліва
            GroupBox groupBoxQuestionRight = new GroupBox()
            {
                Dock = DockStyle.Top,
                Text = "",
                Size = new Size(300, 35),
                Padding = new Padding(3)
            };
            TextBox textRight = new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(groupBoxQuestionRight.Width - 27, 22),
                Location = new Point(25, 10),
                Name = "textRight_" + (currentQuestion.Answers.Count - 1).ToString(),
            };
            textRight.TextChanged += (obj, EventArgs) =>
            {
                KeyValuePair<string, string> text = (currentQuestion.Answers[indexAnswer] as AnswerMatch).Text;
                (currentQuestion.Answers[indexAnswer] as AnswerMatch).Text = new KeyValuePair<string, string>(text.Key, textRight.Text);
            };
            textRight.GotFocus += (obj, EventArgs) =>
            {
                indexAnswer = Convert.ToInt32((obj as Control).Name.Split('_')[1]);
            };
            Label labelRight = new Label()
            {
                Dock = DockStyle.Left,
                Text = Convert.ToChar(matchPanels["panelMatchRight"].Controls.Count + 1072).ToString(),
                AutoSize = true
            };
            (currentQuestion.Answers[indexAnswer] as AnswerMatch).Variant = labelLeft.Text[0];
            groupBoxQuestionRight.Controls.AddRange(new Control[] { textRight, labelRight });
            matchPanels["panelMatchRight"].Controls.Add(groupBoxQuestionRight);
            matchPanels["panelMatchRight"].Controls.SetChildIndex(groupBoxQuestionRight, 0);
            //
            //Створення панелі і кнопок для зєднання відповідних питань
            int i = matchPanels["panelMatchingLines"].Controls.Count - 1;
            Panel matchLabelLeft = new Panel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Name = "Left_" + currentQuestion.Answers.Count,
                Text = "",
                AutoSize = true,
                Size = new Size(10, 10),
                BackColor = Color.White
            };
            matchLabelLeft.MouseClick += Label_Click;
            if (i == -1)
                matchLabelLeft.Location = new Point(5, 15);
            else
                matchLabelLeft.Location = new Point(5, matchPanels["panelMatchingLines"].Controls[i].Location.Y + 35);
            matchPanels["panelMatchingLines"].Controls.Add(matchLabelLeft);
            Panel matchLabelRight = new Panel
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Name = "Right_" + currentQuestion.Answers.Count,
                Text = "",
                AutoSize = true,
                Size = new Size(10, 10),
                BackColor = Color.White
            }; 
            matchLabelRight.MouseClick += Label_Click;
            if (i == -1)
                matchLabelRight.Location = new Point(matchPanels["panelMatchingLines"].Width - 15, 15);
            else
                matchLabelRight.Location = new Point(matchPanels["panelMatchingLines"].Width - 15, matchPanels["panelMatchingLines"].Controls[i].Location.Y + 35);
            matchPanels["panelMatchingLines"].Controls.Add(matchLabelRight);
        }

        private void GroupBox_GotFocus(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            string[] namesplit = name.Split('_');
            indexAnswer = Convert.ToInt32(namesplit[1]);
        }

        //Для зєднання відповідей
        private void Label_Click(object sender, MouseEventArgs e)
        {
            Control senderObj = sender as Control;
            if (senderObj.BackColor != Color.Green)
            {
                string[] name = senderObj.Name.Split('_');
                if (isStartMatching)
                {
                    mouseEnd = new Point(senderObj.Location.X + 5, senderObj.Location.Y + 5);
                    Graphics g = panel3.Controls["matchLayoutPanel"].Controls["panelMatchingLines"].CreateGraphics();
                    g.DrawLine(new Pen(Brushes.White, 2), mouseStart, mouseEnd);
                    isStartMatching = false;
                    senderObj.BackColor = Color.Green;
                    if (name[0] == "Left")
                        numberMatch = Convert.ToInt32(name[1]);
                    if (name[0] == "Right")
                        variantMatch = name[1][0];
                    (currentQuestion.Answers[numberMatch - 1] as AnswerMatch).RightVariant = variantMatch;
                }
                else
                {
                    mouseStart = new Point(senderObj.Location.X + 5, senderObj.Location.Y + 5);
                    senderObj.BackColor = Color.Green;
                    isStartMatching = true;
                    if (name[0] == "Left")
                        numberMatch = Convert.ToInt32(name[1]);
                    if (name[0] == "Right")
                        variantMatch = name[1][0];
                }
            }
        }

        //Питання

        //Додати питання текст
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuestion.graphicInQuestion = false;
            currentQuestion.Text.Add("");
            TextBox QuestionText = new TextBox()
            {
                Name = "questionTextBox",
                Dock = DockStyle.Fill,
                Multiline = true,
            };
            QuestionTextGroupBox.Controls.Add(QuestionText);
            QuestionText.Focus();
            QuestionText.TextChanged += (senderQuestion, ev) =>
            {
                currentQuestion.Text[0] = (senderQuestion as TextBox).Text;
            };
        }

        //Додати питання картинку
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Instance.CurrentTest.Questions.Add(new Question());
            currentQuestion.graphicInQuestion = true;
            currentQuestion.Text.Add("");
            using (OpenFileDialog open_dialog = new OpenFileDialog())
            {
                open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
                if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
                {
                    try
                    {
                        Image image = Image.FromFile(open_dialog.FileName);
                        PictureBox questionPicture = new PictureBox()
                        {
                            Name = "questionPictureBox",
                            Image = image,
                            Dock = DockStyle.Left,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Padding = new Padding(5)
                        };
                        QuestionTextGroupBox.Controls.Add(questionPicture);
                        QuestionTextGroupBox.Controls.SetChildIndex(questionPicture, 0);
                        questionPicture.Invalidate();
                        TextBox questionTextBox = new TextBox()
                        {
                            Name = "questionTextBox",
                            Multiline = true,
                            Dock = DockStyle.Top,
                        };
                        QuestionTextGroupBox.Controls.Add(questionTextBox);
                        QuestionTextGroupBox.Controls.SetChildIndex(questionTextBox, 0);
                        questionTextBox.Focus();    
                        currentQuestion.Text.Add(ImageToString(image));
                        questionTextBox.TextChanged += (senderQuestion, ev) =>
                        {
                            currentQuestion.Text[0] = (senderQuestion as TextBox).Text;
                        };
                    }
                    catch
                    {
                        DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Конвертувати string to Image
        private Image StringToImage(string imageString)
        {
            byte[] imageBytes;
            // Convert Base64 String to byte[]
            imageBytes = Convert.FromBase64String(imageString);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            return Image.FromStream(ms, true);
        }

        //Конвектировать Image to string
        private string ImageToString(Image image)
        {
            byte[] imageBytes;
            string imageString;
            using (MemoryStream mss = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(mss, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = mss.ToArray();
                // Convert byte[] to Base64 String
                imageString = Convert.ToBase64String(imageBytes);
            }
            return imageString;
        }

        //Дозвіл чи заборона додавання питання
        private void EnableQuestion(bool enable)
        {
            toolStripDropDownButtonAddQuestion.Enabled = enable;
            imageToolStripMenuItem.Enabled = enable;
        }

        //Дозвіл чи заборона видалення питання та відповідей
        private void EnableAnswers(bool enable)
        {
            questionDeleteToolStripMenuItem.Enabled = enable;
            answerDeleteToolStripMenuItem.Enabled = enable;
        }
        //видалення питання
        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int count = QuestionTextGroupBox.Controls.Count;
            while (i < count)
            {
                if (QuestionTextGroupBox.Controls[i].Name != "QuestionTextLabel")
                {
                    QuestionTextGroupBox.Controls.RemoveAt(i);
                    i--;
                    count--;
                }
                i++;
            }
            EnableQuestion(true);
        }
        //Видалення відповіді
        private void answerDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AnswersGroupBox.Controls["panel3"].Controls.Count; i++)
            {
                if (i == activeAnswer)
                    AnswersGroupBox.Controls["panel3"].Controls.RemoveAt(i);
            }
            if (AnswersGroupBox.Controls["panel3"].Controls.Count == 0)
            {
                matchToolStripMenuItem.Enabled = true;
                variantToolStripMenuItem.Enabled = true;
            }

        }

    }
}
