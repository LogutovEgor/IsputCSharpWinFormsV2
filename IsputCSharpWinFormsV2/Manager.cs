using System;
using System.Collections.Generic;
using System.Text;

namespace IsputCSharpWinFormsV2
{
    class Manager
    {
        private static Manager Instance;
        private List<Question> questions;

        private Test currentTest;

        Manager()
        {
            questions = new List<Question>();
        }
        
        public void AddQuestion()
        {
            Question question = new Question();
            
            questions.Add(question);
        }
        public static Manager GetInstance()
        {
            if (Instance == null)
                Instance = new Manager();
            return Instance;
        }
        public List<Question> Questions { get { return questions; } } 
        public int ActiveQuestion { get; set; }
        public Test CurrentTest { get { return currentTest; } set { currentTest = value; } }
    }

}
