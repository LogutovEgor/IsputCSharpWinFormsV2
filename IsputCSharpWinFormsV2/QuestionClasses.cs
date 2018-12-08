using System;
using System.Collections.Generic;
using System.Text;


//Kiyashko
namespace IsputCSharpWinFormsV2
{
    [Serializable]
    public class Question
    {
        public List<string> Text { get; set; }
        public List<Answer> Answers { get; set; }
        public bool graphicInQuestion { get; set; }
        public Question()
        {
            Text = new List<string>();
            Answers = new List<Answer>();
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
        public char Variant { get; set; }
        public KeyValuePair<string, string> Text { get; set; }
        public char RightVariant { get; set; }
        public AnswerMatch()
        {
            Text = new KeyValuePair<string, string>();
        }
        public override string Show()
        {
            return "Number " + Number + " Variant " + Variant + " Text " + Text.Key + "," + Text.Value + 
                " RightVariant " + RightVariant + Environment.NewLine;
        }
    }
}
