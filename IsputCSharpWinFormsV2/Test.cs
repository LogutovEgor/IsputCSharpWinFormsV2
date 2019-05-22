using System;
using System.Collections.Generic;
using System.Text;

namespace IsputCSharpWinFormsV2
{
    [Serializable]
    public class Test
    {
        public List<Question> Questions { get; set; }
        public int variantCount;
        public string password;
        public Test()
        {
            Questions = new List<Question>();
            variantCount = 1;
        }
    }
}
