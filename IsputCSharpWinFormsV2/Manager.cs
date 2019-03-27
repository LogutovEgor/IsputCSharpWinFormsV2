using System;
using System.Collections.Generic;
using System.Text;

namespace IsputCSharpWinFormsV2
{
    class Manager
    {
        private static Manager InstanceVar;

        public Test CurrentTest { get; set; }

        public GoTest goTest;

        Manager()
        {
            CurrentTest = new Test();
            goTest = new GoTest();
        }

        public void SetQuestionsForTest(int variant)
        {
            goTest.variant = variant;
            for (int i = 0; i < CurrentTest.Questions.Count; i++)
            {
                if (CurrentTest.Questions[i].InVariant[goTest.variant - 1])
                {
                    goTest.questions.Add(CurrentTest.Questions[i]);
                }
            }
        }

        public static Manager Instance
        {
            get
            {
                if (InstanceVar == null)
                    InstanceVar = new Manager();
                return InstanceVar;
            }
        }
        public class GoTest
        {
            public int variant;
            public List<Question> questions;
            public GoTest()
            {
                questions = new List<Question>();
                variant = 0;
            }
        }

    }

}
