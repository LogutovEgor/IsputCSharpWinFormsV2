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

        Graphics g;
        Graphics prev;

        // ТЕКСТОВА ВІДПОВІДЬ

        //додавання текстової відповіді
        private void варіантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indexAnswer = currentQuestion.Answers.Count;
            currentQuestion.Answers.Add(new AnswerText());
            (currentQuestion.Answers[indexAnswer] as AnswerText).Right = false;
            //ControlsForTextAnswer();
            if (matchToolStripMenuItem.Enabled)
                matchToolStripMenuItem.Enabled = false;
            EnableControlTextAnswer();
        }

        public void EnableControlTextAnswer()
        {
            if (panel3.Controls["Answer_" + indexAnswer] == null)
                ControlsForTextAnswer();
            panel3.Controls["Answer_" + indexAnswer].Visible = true;
            (panel3.Controls["Answer_" + indexAnswer].Controls["CheckBox_" + indexAnswer] as CheckBox).Checked = (currentQuestion.Answers[indexAnswer] as AnswerText).Right;
            panel3.Controls["Answer_" + indexAnswer].Controls["TextBox_" + indexAnswer].Text = (currentQuestion.Answers[indexAnswer] as AnswerText).Text;
            panel3.Controls.SetChildIndex(panel3.Controls["Answer_" + indexAnswer], 0);
        }

        public void ControlsForTextAnswer()
        {
            if (matchToolStripMenuItem.Enabled)
                matchToolStripMenuItem.Enabled = false;
            ///
            GroupBox groupBox = new GroupBox
            {
                Size = new Size(450, 44),
                Dock = DockStyle.Top,
                Padding = new Padding(10, 2, 2, 2),
                Name = "Answer_" + indexAnswer,
                Font = DefaultFont,
                Visible = false
            };
            ///
            CheckBox checkBox = new CheckBox
            {
                Size = new Size(25, 25),
                Dock = DockStyle.Right,
                Padding = new Padding(6, 0, 0, 5),
                Name = "CheckBox_" + indexAnswer,
                //Checked = (currentQuestion.Answers[indexAnswer] as AnswerText).Right
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
                Name = "TextBox_" + indexAnswer,
                //Text = (currentQuestion.Answers[indexAnswer] as AnswerText).Text
            };
            textBox.TextChanged += (senderText, ev) =>
            {
                (currentQuestion.Answers[indexAnswer] as AnswerText).Text = (senderText as TextBox).Text;
            };
            groupBox.Controls.AddRange(new Control[] { checkBox, textBox });
            groupBox.ContextMenuStrip = contextMenuStripAnswers;
            panel3.Controls.Add(groupBox);
            panel3.Controls.SetChildIndex(groupBox, 0);
            for (int i = 0; i < panel3.Controls[groupBox.Name].Controls.Count; i++)
            {
                panel3.Controls[groupBox.Name].Controls[i].GotFocus += GroupBox_GotFocus;
            }
        }

        /// <summary>
        /// Видалення текстового питання
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = indexQuestion;
            if (currentQuestion.Answers.Count == 1)
            {
                matchToolStripMenuItem.Enabled = true;
            }
            currentQuestion.Answers.RemoveAt(indexAnswer);
            panel3.Controls.RemoveByKey("Answer_" + indexAnswer.ToString());
            int num = 0;
            string[] splitStr;
            for (int i = 0; i < panel3.Controls.Count; i++)
            {
                splitStr = panel3.Controls[i].Name.Split('_');
                if (splitStr[0] == "TextBox" || splitStr[0] == "CheckBox" || splitStr[0] == "Answer")
                {
                    num = Convert.ToInt32(splitStr[1]);
                    if (num > indexAnswer)
                    {
                        panel3.Controls[i].Controls["TextBox_" + num].Name = "TextBox_" + (num - 1);
                        panel3.Controls[i].Controls["CheckBox_" + num].Name = "CheckBox_" + (num - 1);
                        panel3.Controls[i].Name = "Answer_" + (num - 1);
                    }
                }
            }
            indexQuestion = index;
            SlideGetFocus(SlidesPanel.Controls[indexQuestion.ToString()]);
        }
        //

        //ПИТАННЯ-ЗЄДНУВАЧ

        //додавання питання зєднувач
        private void зєднанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indexAnswer = currentQuestion.Answers.Count;
            currentQuestion.Answers.Add(new AnswerMatch());
            if (variantToolStripMenuItem.Enabled)
            {
                variantToolStripMenuItem.Enabled = false;
            }
            EnableControlMatchAnswer();
        }

        public void EnableControlMatchAnswer()
        {
            Control tablematchLayoutPanel = panel3.Controls[MatchCnt.matchLayoutPanel.ToString()];
            if (tablematchLayoutPanel.Visible == false)
            {
                tablematchLayoutPanel.Visible = true;
            }
            tablematchLayoutPanel.Controls[MatchCnt.panelMatchleft.ToString()].
                Controls[MatchCnt.groupBoxQuestionLeft + "_" + indexAnswer].Visible = true;

            tablematchLayoutPanel.Controls[MatchCnt.panelMatchleft.ToString()].
                Controls[MatchCnt.groupBoxQuestionLeft + "_" + indexAnswer].
                Controls["textLeft_" + indexAnswer].Text = (currentQuestion.Answers[indexAnswer] as AnswerMatch).Text.Key;

            tablematchLayoutPanel.Controls[MatchCnt.panelMatchRight.ToString()].
                Controls[MatchCnt.groupBoxQuestionRight + "_" + indexAnswer].
                Controls["textRight_" + indexAnswer].Text = (currentQuestion.Answers[indexAnswer] as AnswerMatch).Text.Value;

            tablematchLayoutPanel.Controls[MatchCnt.panelMatchRight.ToString()].
                Controls[MatchCnt.groupBoxQuestionRight + "_" + indexAnswer].Visible = true;
            tablematchLayoutPanel.Controls[MatchCnt.panelMatchingLines.ToString()].
                Controls[MatchCnt.RectMatchLeft + "_" + indexAnswer].Visible = true;
            tablematchLayoutPanel.Controls[MatchCnt.panelMatchingLines.ToString()].
                Controls[MatchCnt.RectMatchRight + "_" + indexAnswer].Visible = true;

            tablematchLayoutPanel.Controls[MatchCnt.panelMatchleft.ToString()].
                Controls.SetChildIndex(tablematchLayoutPanel.Controls[MatchCnt.panelMatchleft.ToString()].
                    Controls[MatchCnt.groupBoxQuestionLeft + "_" + indexAnswer], 0);
            tablematchLayoutPanel.Controls[MatchCnt.panelMatchRight.ToString()].
                Controls.SetChildIndex(tablematchLayoutPanel.Controls[MatchCnt.panelMatchRight.ToString()].
                    Controls[MatchCnt.groupBoxQuestionRight + "_" + indexAnswer], 0);
            (currentQuestion.Answers[indexAnswer] as AnswerMatch).Number = indexAnswer;
        }

        private void TableLayoutPanelForMatchAnswer()
        {
            TableLayoutPanel matchLayoutPanel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3,
                Name = MatchCnt.matchLayoutPanel.ToString(),
                Visible = false
            };
            matchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Percent, 100f));
            matchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 40f));
            matchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 20f));
            matchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 40f));
            panel3.Controls.Add(matchLayoutPanel);
            //Панель для відповідей праворуч
            Panel panelRight = new Panel()
            {
                Name = MatchCnt.panelMatchRight.ToString(),
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };
            //Панель для відповідей ліворуч
            Panel panelLeft = new Panel()
            {
                Name = MatchCnt.panelMatchleft.ToString(),
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };
            //Панель для зєднання точок питань
            PictureBox panelMatchingLines = new PictureBox()
            {
                Name = MatchCnt.panelMatchingLines.ToString(),
                Dock = DockStyle.Fill,
            };
            panelMatchingLines.Paint += (senderS, ev) =>
            {
                RedrawMatchingLines(true);
            };
            matchLayoutPanel.Controls.Add(panelRight, 2, 0);
            matchLayoutPanel.Controls.Add(panelLeft, 0, 0);
            matchLayoutPanel.Controls.Add(panelMatchingLines, 1, 0);
            panelMatchingLines.MouseClick += (senderpan, ev) =>
            {
                if (isStartMatching)
                {
                    isStartMatching = false;
                    mouseStart = new Point(mouseStart.X - 5, mouseStart.Y - 5);
                    for (int j = 0; j < (senderpan as Control).Controls.Count; j++)
                    {
                        if ((senderpan as Control).Controls[j].Location == mouseStart)
                        {
                            ((senderpan as Control)).Controls[j].BackColor = Color.White;
                        }
                    }
                }
            };
        }

        private void ControlsForMatchAnswer()
        {
            Control.ControlCollection matchPanels = panel3.Controls["matchLayoutPanel"].Controls;
            //
            //Створення groupbox для питання справа
            GroupBox groupBoxQuestionLeft = new GroupBox()
            {
                Dock = DockStyle.Top,
                Text = /*MatchCnt.groupBoxQuestionLeft.ToString() + '_' + indexAnswer*/"",
                Size = new Size(300, 35),
                Padding = new Padding(3),
                Name = MatchCnt.groupBoxQuestionLeft.ToString() + '_' + indexAnswer,
                Visible = false
            };
            groupBoxQuestionLeft.ContextMenuStrip = contextMenuStripAnsMatch;
            TextBox textLeft = new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(groupBoxQuestionLeft.Width - 27, 22),
                Location = new Point(5, 10),
                Name = "textLeft_" + indexAnswer
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
                Text = (indexAnswer + 1).ToString(),
                AutoSize = true,
                Name = "labelLeft_" + indexAnswer
            };
            //(currentQuestion.Answers[currentQuestion.Answers.Count - 1] as AnswerMatch).Number = Convert.ToInt32(labelLeft.Text);
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
                Padding = new Padding(3),
                Name = "groupBoxQuestionRight_" + indexAnswer,
                Visible = false
            };
            groupBoxQuestionRight.ContextMenuStrip = contextMenuStripAnsMatch;
            TextBox textRight = new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(groupBoxQuestionRight.Width - 27, 22),
                Location = new Point(25, 10),
                Name = "textRight_" + indexAnswer
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
                AutoSize = true,
                Name = "labelRight_" + indexAnswer

            };
            //(currentQuestion.Answers[currentQuestion.Answers.Count - 1] as AnswerMatch).Variant = labelLeft.Text[0];
            groupBoxQuestionRight.Controls.AddRange(new Control[] { textRight, labelRight });
            matchPanels["panelMatchRight"].Controls.Add(groupBoxQuestionRight);
            matchPanels["panelMatchRight"].Controls.SetChildIndex(groupBoxQuestionRight, 0);
            //
            //Створення панелі і кнопок для зєднання відповідних питань
            int i = matchPanels["panelMatchingLines"].Controls.Count - 1;
            Panel matchLabelLeft = new Panel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Name = "RectMatchLeft_" + indexAnswer,
                Text = "",
                AutoSize = true,
                Size = new Size(10, 10),
                BackColor = Color.White,
                Visible = false
            };
            matchLabelLeft.MouseClick += Label_Click;
            //matchLabelLeft.ContextMenuStrip = contextMenuStripMatchPanels;
            if (i == -1)
                matchLabelLeft.Location = new Point(5, 15);
            else
                matchLabelLeft.Location = new Point(5, matchPanels["panelMatchingLines"].Controls[i].Location.Y + 35);
            matchPanels["panelMatchingLines"].Controls.Add(matchLabelLeft);
            Panel matchLabelRight = new Panel
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Name = "RectMatchRight_" + indexAnswer,
                Text = "",
                AutoSize = true,
                Size = new Size(10, 10),
                BackColor = Color.White,
                Visible = false
            };
            matchLabelRight.MouseClick += Label_Click;
            //matchLabelRight.ContextMenuStrip = contextMenuStripMatchPanels;
            if (i == -1)
                matchLabelRight.Location = new Point(matchPanels["panelMatchingLines"].Width - 15, 15);
            else
                matchLabelRight.Location = new Point(matchPanels["panelMatchingLines"].Width - 15, matchPanels["panelMatchingLines"].Controls[i].Location.Y + 35);
            matchPanels["panelMatchingLines"].Controls.Add(matchLabelRight);
            g = matchPanels["panelMatchingLines"].CreateGraphics();
            matchPanels["panelMatchingLines"].MouseMove += (senderML, ev) =>
            {
                if (isStartMatching)
                {
                    RedrawMatchingLines();
                    g.DrawLine(new Pen(Brushes.White, 2), mouseStart, ev.Location);
                }
            };
        }

        //Видалення питання зєднувач
        private void deletetoolStripMenuItemMatchAns_Click(object sender, EventArgs e)
        {
            int index = indexQuestion;
            if (currentQuestion.Answers.Count == 1)
            {
                variantToolStripMenuItem.Enabled = true;
                panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].Visible = false;
            }
            Control.ControlCollection matchlayout = panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].Controls;
            int number = 0;
            bool needDecRV = false;
            for (int i = 0; i < currentQuestion.Answers.Count; i++)
            {
                needDecRV = false;
                if ((currentQuestion.Answers[i] as AnswerMatch).Number - 1 == indexAnswer)
                {
                    number = (currentQuestion.Answers[i] as AnswerMatch).RightVariant;
                    matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[MatchCnt.RectMatchLeft + "_" + i].BackColor = Color.White;
                    if (number != -1)
                        matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[MatchCnt.RectMatchRight + "_" + number].BackColor = Color.White;
                }

                if ((currentQuestion.Answers[i] as AnswerMatch).RightVariant == indexAnswer)
                {
                    number = (currentQuestion.Answers[i] as AnswerMatch).RightVariant;
                    matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[MatchCnt.RectMatchLeft + "_" + i].BackColor = Color.White;
                    matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[MatchCnt.RectMatchRight + "_" + number].BackColor = Color.White;
                    needDecRV = true;
                }

                if ((currentQuestion.Answers[i] as AnswerMatch).RightVariant > indexAnswer)
                {
                    (currentQuestion.Answers[i] as AnswerMatch).RightVariant -= 1;
                }
                if ((currentQuestion.Answers[i] as AnswerMatch).Number - 1 > indexAnswer)
                {
                    (currentQuestion.Answers[i] as AnswerMatch).Number -= 1;
                }
                if (needDecRV)
                {
                    (currentQuestion.Answers[i] as AnswerMatch).RightVariant = -1;
                }
            }

            currentQuestion.Answers.RemoveAt(indexAnswer);

            matchlayout[MatchCnt.panelMatchleft.ToString()].Controls.
                RemoveByKey(MatchCnt.groupBoxQuestionLeft.ToString() + "_" + indexAnswer);
            matchlayout[MatchCnt.panelMatchRight.ToString()].Controls.
                RemoveByKey(MatchCnt.groupBoxQuestionRight.ToString() + "_" + indexAnswer);
            matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls.
                RemoveByKey(MatchCnt.RectMatchLeft.ToString() + "_" + indexAnswer);
            matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls.
                RemoveByKey(MatchCnt.RectMatchRight.ToString() + "_" + indexAnswer);

            int num = 0;
            string[] splitStr;
            for (int i = 0; i < matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls.Count; i++)
            {
                splitStr = matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[i].Name.Split('_');
                num = Convert.ToInt32(splitStr[1]);
                if (num > indexAnswer)
                {
                    Point loc = matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[i].Location;

                    for (int j = 0; j < matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls.Count; j++)
                    {
                        if (matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[j].Location.Y == loc.Y)
                        {
                            matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[j].Location = new Point(loc.X, loc.Y - 35);
                            break;
                        }
                    }
                    matchlayout[MatchCnt.panelMatchingLines.ToString()].Controls[i].Location = new Point(loc.X, loc.Y - 35);
                }
            }
            string controlName = "";
            for (int j = 0; j < 3; j++)
            {
                if (j == 0)
                    controlName = MatchCnt.panelMatchleft.ToString();
                if (j == 1)
                    controlName = MatchCnt.panelMatchRight.ToString();
                if (j == 2)
                    controlName = MatchCnt.panelMatchingLines.ToString();
                for (int i = 0; i < matchlayout[controlName].Controls.Count; i++)
                {
                    splitStr = matchlayout[controlName].Controls[i].Name.Split('_');
                    num = Convert.ToInt32(splitStr[1]);
                    if (num > indexAnswer)
                    {
                        if (j == 0)
                        {
                            matchlayout[controlName].Controls[i].Controls[MatchCnt.labelLeft + "_" + num].Text = (num).ToString();
                            matchlayout[controlName].Controls[i].Controls[MatchCnt.textLeft + "_" + num].Name =
                                MatchCnt.textLeft.ToString() + "_" + (num - 1);
                            matchlayout[controlName].Controls[i].Controls[MatchCnt.labelLeft + "_" + num].Name =
                                MatchCnt.labelLeft.ToString() + "_" + (num - 1);
                            matchlayout[controlName].Controls[i].Name = MatchCnt.groupBoxQuestionLeft + "_" + (num - 1);
                        }
                        if (j == 2)
                        {
                            if (splitStr[0] == MatchCnt.RectMatchLeft.ToString())
                                matchlayout[controlName].Controls[i].Name = MatchCnt.RectMatchLeft + "_" + (num - 1);
                            else
                                matchlayout[controlName].Controls[i].Name = MatchCnt.RectMatchRight + "_" + (num - 1);
                        }
                        if (j == 1)
                        {
                            matchlayout[controlName].Controls[i].Controls[MatchCnt.labelRight + "_" + num].Text = Convert.ToChar(num - 1 + 1072).ToString();
                            matchlayout[controlName].Controls[i].Controls[MatchCnt.textRight + "_" + num].Name =
                                MatchCnt.textRight.ToString() + "_" + (num - 1);
                            matchlayout[controlName].Controls[i].Controls[MatchCnt.labelRight + "_" + num].Name =
                                MatchCnt.labelRight.ToString() + "_" + (num - 1);
                            matchlayout[controlName].Controls[i].Name = MatchCnt.groupBoxQuestionRight + "_" + (num - 1);
                        }
                    }
                }
            }

            RedrawMatchingLines();
            indexQuestion = index;
            SlideGetFocus(SlidesPanel.Controls[indexQuestion.ToString()]);
        }

        //

        private void RedrawMatchingLines(bool needCreate = true)
        {
            try
            {
                if (currentQuestion.Answers.Count != 0)
                {
                    if (currentQuestion.Answers[0] is AnswerMatch)
                    {
                        if (g != null)
                        {
                            if (needCreate)
                            {
                                try
                                {
                                    g = panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                        Controls[MatchCnt.panelMatchingLines.ToString()].CreateGraphics();
                                }
                                catch (Exception e)
                                {
                                }
                            }
                            g.Clear(Color.FromArgb(24, 73, 107));
                            for (int j = 0; j < currentQuestion.Answers.Count; j++)
                            {
                                int right = (currentQuestion.Answers[j] as AnswerMatch).RightVariant;
                                if (right != -1)
                                {
                                    Point startP = panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                            Controls[MatchCnt.panelMatchingLines.ToString()].
                                                Controls[MatchCnt.RectMatchLeft.ToString() + '_' + (j).ToString()].Location;
                                    Point endP = panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                            Controls[MatchCnt.panelMatchingLines.ToString()].
                                                Controls[MatchCnt.RectMatchRight.ToString() + '_' + (right).ToString()].Location;
                                    startP = new Point(startP.X + 5, startP.Y + 5);
                                    endP = new Point(endP.X + 5, endP.Y + 5);
                                    g.DrawLine(new Pen(Brushes.White, 2), startP, endP);
                                }
                            }
                        }
                        for (int i = 0; i < panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                                Controls[MatchCnt.panelMatchingLines.ToString()].
                                                    Controls.Count; i++)
                        {
                            panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                                Controls[MatchCnt.panelMatchingLines.ToString()].
                                                    Controls[i].BackColor = Color.White;
                        }
                        for (int i = 0; i < currentQuestion.Answers.Count; i++)
                        {

                            if ((currentQuestion.Answers[i] as AnswerMatch).RightVariant != -1)
                            {
                                panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchingLines.ToString()].
                                        Controls[MatchCnt.RectMatchLeft + "_" + i].BackColor = Color.Green;
                                panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                                    Controls[MatchCnt.panelMatchingLines.ToString()].
                                        Controls[MatchCnt.RectMatchRight + "_" + (currentQuestion.Answers[i] as AnswerMatch).RightVariant].BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            
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
            string[] name = senderObj.Name.Split('_');
            if (senderObj.BackColor != Color.Green)
            {
                if (isStartMatching)
                {
                    if (senderObj.Location.X + 5 != mouseStart.X)
                    {
                        mouseEnd = new Point(senderObj.Location.X + 5, senderObj.Location.Y + 5);
                        RedrawMatchingLines();
                        g.DrawLine(new Pen(Brushes.White, 2), mouseStart, mouseEnd);
                        isStartMatching = false;
                        senderObj.BackColor = Color.Green;
                        if (name[0] == MatchCnt.RectMatchLeft.ToString())
                            numberMatch = Convert.ToInt32(name[1]);
                        if (name[0] == MatchCnt.RectMatchRight.ToString())
                            variantMatch = Convert.ToInt32(name[1]);
                        (currentQuestion.Answers[numberMatch] as AnswerMatch).RightVariant = variantMatch;
                    }
                }
                else
                {
                    mouseStart = new Point(senderObj.Location.X + 5, senderObj.Location.Y + 5);
                    senderObj.BackColor = Color.Green;
                    isStartMatching = true;
                    if (name[0] == MatchCnt.RectMatchLeft.ToString())
                        numberMatch = Convert.ToInt32(name[1]);
                    if (name[0] == MatchCnt.RectMatchRight.ToString())
                        variantMatch = Convert.ToInt32(name[1]);
                }
            }
            else if (!isStartMatching)
            {
                senderObj.BackColor = Color.White;
                isStartMatching = true;
                Control.ControlCollection coll = panel3.Controls[MatchCnt.matchLayoutPanel.ToString()].
                        Controls[MatchCnt.panelMatchingLines.ToString()].Controls;
                if (name[0] == MatchCnt.RectMatchLeft.ToString())
                {
                    variantMatch = (currentQuestion.Answers[Convert.ToInt32(name[1])] as AnswerMatch).RightVariant;
                    (currentQuestion.Answers[Convert.ToInt32(name[1])] as AnswerMatch).RightVariant = -1;
                    mouseStart = coll[MatchCnt.RectMatchRight.ToString() + "_" + variantMatch].Location;
                    mouseStart = new Point(mouseStart.X + 5, mouseStart.Y + 5);
                }
                if (name[0] == MatchCnt.RectMatchRight.ToString())
                {
                    int num = Convert.ToInt32(name[1]);
                    numberMatch = (currentQuestion.Answers.FindIndex(answer => (answer as AnswerMatch).RightVariant == num));
                    (currentQuestion.Answers[numberMatch] as AnswerMatch).RightVariant = -1;
                    mouseStart = coll[MatchCnt.RectMatchLeft.ToString() + "_" + numberMatch].Location;
                    mouseStart = new Point(mouseStart.X + 5, mouseStart.Y + 5);
                }
                RedrawMatchingLines();
            }
        }
        
        
        //ПИТАННЯ 
        //Додати питання текст
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuestion.Text.Add("");
            ControlsForTextQuestion();
        }

        public void ControlsForTextQuestion()
        {
            QuestionGroupBox.ContextMenuStrip = contextMenuStripQuesDel;
            imageToolStripMenuItem.Enabled = false;
            textToolStripMenuItem.Enabled = false;
            currentQuestion.graphicInQuestion = false;
            TextBox QuestionText = new TextBox()
            {
                Name = "questionTextBox",
                Dock = DockStyle.Fill,
                Multiline = true,
                Text = currentQuestion.Text[0]
            };
            QuestionGroupBox.Controls.Add(QuestionText);
            //QuestionText.Focus();
            QuestionText.TextChanged += (senderQuestion, ev) =>
            {
                currentQuestion.Text[0] = (senderQuestion as TextBox).Text;
            };
        }

        //Додати питання картинку
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuestion.Text.Add("");
            currentQuestion.Text.Add("");
            ControlsForImageQuestion();
            ReadImage();
        }

        /// <summary>
        /// Зчитування картинки для питання
        /// </summary>
        public void ReadImage()
        {
            using (OpenFileDialog open_dialog = new OpenFileDialog())
            {
                open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
                if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
                {
                    try
                    {
                        Image image = Image.FromFile(open_dialog.FileName);
                        (QuestionGroupBox.Controls[1] as PictureBox).Image = image;
                        currentQuestion.Text[1] = ImageToString(image);
                    }
                    catch
                    {
                        DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        /// <summary>
        /// Створення UIелем для граф питання
        /// </summary>
        public void ControlsForImageQuestion()
        {
            QuestionGroupBox.ContextMenuStrip = contextMenuStripQuesDel;
            textToolStripMenuItem.Enabled = false;
            imageToolStripMenuItem.Enabled = false;
            currentQuestion.graphicInQuestion = true;
            PictureBox questionPicture = new PictureBox()
            {
                Name = "questionPictureBox",
                //Image = image,
                Dock = DockStyle.Left,
                SizeMode = PictureBoxSizeMode.Zoom,
                Padding = new Padding(5),
                BackColor = Color.White
            };
            questionPicture.MouseClick += (sen, ev1) =>
            {
                ReadImage();
            };
            QuestionGroupBox.Controls.Add(questionPicture);
            QuestionGroupBox.Controls.SetChildIndex(questionPicture, 0);
            questionPicture.Invalidate();
            TextBox questionTextBox = new TextBox()
            {
                Name = "questionTextBox",
                Multiline = true,
                Dock = DockStyle.Top,
            };
            QuestionGroupBox.Controls.Add(questionTextBox);
            QuestionGroupBox.Controls.SetChildIndex(questionTextBox, 0);
            //questionTextBox.Focus();
            
            questionTextBox.TextChanged += (senderQuestion, ev) =>
            {
                currentQuestion.Text[0] = (senderQuestion as TextBox).Text;
            };

        }

        //Конвертувати string to Image
        private Image StringToImage(string imageString)
        {
            if (imageString != "")
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
            else
                return null;
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
            textToolStripMenuItem.Enabled = enable;
            imageToolStripMenuItem.Enabled = enable;
        }

        private void CheckBtnEnable()
        {
            
        }

        private void delQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuestion.Text.Clear();
            QuestionGroupBox.Controls.Clear();
            textToolStripMenuItem.Enabled = true;
            imageToolStripMenuItem.Enabled = true;
        }
    }
}
