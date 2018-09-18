using System;
using System.Collections.Generic;
using System.Text;

//Kiyashko
namespace IsputCSharpWinFormsV2
{
    class Answer
    {

    }

    //Answer can be in string form
    class TextAnswer:Answer
    {
        public TextAnswer(string answer)
        {
            this.answer = answer;
        }
        string answer;
    }
    //Answer can be image
    class ImageAnswer:Answer
    {
        string path;
        public ImageAnswer(string path)
        {
            this.path = path;
        }
    }

}
