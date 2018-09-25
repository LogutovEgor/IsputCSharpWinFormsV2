using System;
using System.Collections.Generic;
using System.Text;

namespace IsputCSharpWinFormsV2
{
    class Manager
    {
        private static Manager Instance;
        private List<Question> questions; 
        Manager()
        {
           
        }
        
        public void AddQuestion()
        {
            Question question = null;
            
            questions.Add(question);
        }
        public Manager GetInstance()
        {
            if (Instance == null)
                Instance = new Manager();
            return Instance;
        }
        public List<Question> Questions { get { return questions; } } 
        public int ActiveQuestion { get; set; }
    }

}
