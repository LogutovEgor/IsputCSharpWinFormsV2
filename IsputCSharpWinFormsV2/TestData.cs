﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IsputCSharpWinFormsV2
{
    
    public partial class TestData : Form
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public Control.ControlCollection control;
        public TestData()
        {
            InitializeComponent();

            Location = new Point(950, 0);
            this.StartPosition = FormStartPosition.Manual;

            

        }

        public void UpdateForm(List<string> arg, int index)
        {
            //while (true)
            //{
            //    for (int i = 0; i < 255; i++)
            //    {
            //        int state = GetAsyncKeyState(i);
            //        if (state == 1 || state == -32767)
            //        {
            //            BackColor = System.Drawing.Color.Black;
            //            //UpdateSlideButton();
            //        }
            //    }
            //}
            textBoxTest.Text = "";
            textBoxTest.Text += "Test: " + Environment.NewLine;
            for (int i = 0; i < Manager.Instance.CurrentTest.Questions.Count; i++)
            {
                textBoxTest.Text += "Question: " + Environment.NewLine;
                for (int j = 0; j < Manager.Instance.CurrentTest.Questions[i].Text.Count; j++)
                {
                    textBoxTest.Text += "\t" + Manager.Instance.CurrentTest.Questions[i].Text[j] + Environment.NewLine;
                }
                textBoxTest.Text += "Answers: " + Environment.NewLine;
                for (int k = 0; k < Manager.Instance.CurrentTest.Questions[i].Answers.Count; k++)
                {
                    textBoxTest.Text += "\t" + Manager.Instance.CurrentTest.Questions[i].Answers[k].Show() + Environment.NewLine;
                }
            }
            for (int i = 0; i < arg.Count; i++)
            {
                textBoxTest.Text += "\n" + arg[i];
            }

            textBoxTest.Text += "Index: " + index + Environment.NewLine;
        }

    }
}