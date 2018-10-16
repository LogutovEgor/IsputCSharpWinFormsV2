using System;
using System.Collections.Generic;
using System.Text;

namespace IsputCSharpWinFormsV2
{
    [Serializable]
    public class Test
    {
        public List<Question> questions;
        public Test()
        {
            questions = new List<Question>();
        }
        
    }
}
