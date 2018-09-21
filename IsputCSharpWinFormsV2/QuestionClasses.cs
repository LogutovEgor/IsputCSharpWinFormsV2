﻿using System;
using System.Collections.Generic;
using System.Text;


//Kiyashko
namespace IsputCSharpWinFormsV2
{
    class Questions
    {
        //Right answers
        List<int> rightAnswers;
        public string Question { get; set; }
        public List<Answer> Answers { get; }
        public List<int> RightAnswer { get { return rightAnswers; } set { value = rightAnswers; } }
        public void AddTextAnswer(string answer)
        {
            Answers.Add(new TextAnswer(answer));
        }
        public void AddImageAnswer(string path)
        {
            Answers.Add(new ImageAnswer(path));
        }
        public void AddRightAnswer(int index)
        {
            rightAnswers.Add(index + 1);
        }
    }

}