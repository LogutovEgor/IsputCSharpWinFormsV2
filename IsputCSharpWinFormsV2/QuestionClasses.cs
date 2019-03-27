using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Runtime.InteropServices;


//Kiyashko
namespace IsputCSharpWinFormsV2
{
    [Serializable]
    public class Question
    {
        public List<string> Text { get; set; }
        public List<Answer> Answers { get; set; }
        public bool graphicInQuestion { get; set; }
        public Image ImageSlide { get; set; }

        public List<bool> InVariant { get; set; }

        public Question()
        {
            Text = new List<string>();
            Answers = new List<Answer>();
            InVariant = new List<bool>();
            for (int i = 0; i < Manager.Instance.CurrentTest.variantCount; i++)
            {
                InVariant.Add(false);
            }

        }
        public int AnswersCount
        {
            get { return Answers.Count; }
        }
    }

    [Serializable]
    public abstract class Answer {
        public abstract string Show();
    }
    [Serializable]
    public class AnswerText:Answer
    {
        public bool Right { get; set; }
        public string Text { get; set; }
        public AnswerText() { }

        public override string Show()
        {
            return "Right " + Right + " Text " + Text + Environment.NewLine;
        }

    }
    [Serializable]
    public class AnswerMatch:Answer
    { 
        public int Number { get; set; }
        //public char Variant { get; set; }
        public KeyValuePair<string, string> Text { get; set; }
        public int RightVariant { get; set; }
        public AnswerMatch()
        {
            Text = new KeyValuePair<string, string>();
            RightVariant = -1;
        }
        public override string Show()
        {
            return "Number " + Number + " Text " + Text.Key + "," + Text.Value + 
                " RightVariant " + RightVariant + Environment.NewLine;
        }
    }
}
