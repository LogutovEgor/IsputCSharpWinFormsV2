using System;
using System.Collections.Generic;
using System.Text;


//Kiyashko
namespace IsputCSharpWinFormsV2
{
    [Serializable]
    public class Question
    {
        //Right answers
        public List<int> rightAnswers;
        public string questiontext { get; set; }
        public List<Answer> Answers { get; }
        public List<int> RightAnswer { get { return rightAnswers; } set { value = rightAnswers; } }
        public Question()
        { }
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
