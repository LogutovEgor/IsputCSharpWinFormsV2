using System;
using System.Collections.Generic;
using System.Text;

//Kiyashko
namespace IsputCSharpWinFormsV2
{
    [Serializable]
    public class Answer
    {
        public bool rightAnswer;
        public Answer() { }
    }

    //Answer can be in string form
    [Serializable]
    public class TextAnswer:Answer
    {
        public string answer;

        public TextAnswer()
        {
            this.answer = "";
            this.rightAnswer = false;
        }
        public TextAnswer(string answer)
        {
            this.answer = answer;
            this.rightAnswer = false;
        }

    }
    //Answer can be image
    [Serializable]
    public class ImageAnswer:Answer
    {
        public string path;
        public ImageAnswer(string path)
        {
            this.path = path;
        }
        public ImageAnswer() { }
    }
}
