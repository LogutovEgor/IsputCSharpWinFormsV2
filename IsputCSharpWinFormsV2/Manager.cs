using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.Office.Interop.Word;

namespace IsputCSharpWinFormsV2
{
    class Manager
    {
        private static Manager InstanceVar;

        public Test CurrentTest { get; set; }

        public GoTest goTest;
        public Dictionary<int, int> rating;

        Manager()
        {
            CurrentTest = new Test();
            goTest = new GoTest();
            rating = new Dictionary<int, int>();
            //
            rating.Add(1, 0);
            rating.Add(2, 5);
            rating.Add(3, 10);
            rating.Add(4, 20);
            rating.Add(5, 40);
            rating.Add(6, 50);
            rating.Add(7, 60);
            rating.Add(8, 70);
            rating.Add(9, 75);
            rating.Add(10, 80);
            rating.Add(11, 85);
            rating.Add(12, 100);
            //
        }

        public void SetQuestionsForTest(int variant)
        {
            goTest.variant = variant;
            for (int i = 0; i < CurrentTest.Questions.Count; i++)
            {
                if (CurrentTest.Questions[i].InVariant[goTest.variant - 1])
                {
                    goTest.questions.Add(new Question()
                    {
                        Text = CurrentTest.Questions[i].Text,
                        Answers = new List<Answer>(),
                        ImageSlide = CurrentTest.Questions[i].ImageSlide,
                        graphicInQuestion = CurrentTest.Questions[i].graphicInQuestion
                    });
                    for (int j = 0; j < CurrentTest.Questions[i].Answers.Count; j++)
                    {
                        if (CurrentTest.Questions[i].Answers.Count > 0)
                        {
                            if (CurrentTest.Questions[i].Answers[0] is AnswerText)
                            {
                                goTest.questions[goTest.questions.Count - 1].Answers.Add(new AnswerText()
                                {
                                    Right = (CurrentTest.Questions[i].Answers[j] as AnswerText).Right,
                                    Text = (CurrentTest.Questions[i].Answers[j] as AnswerText).Text
                                });
                            }
                            else
                            {
                                goTest.questions[goTest.questions.Count - 1].Answers.Add(new AnswerMatch()
                                {
                                    Number = (CurrentTest.Questions[i].Answers[j] as AnswerMatch).Number,
                                    RightVariant = (CurrentTest.Questions[i].Answers[j] as AnswerMatch).RightVariant,
                                    Text = (CurrentTest.Questions[i].Answers[j] as AnswerMatch).Text
                                });
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < goTest.questions.Count; i++)
            {
                goTest.userQuestions.Add(new Question()
                {
                    Text = goTest.questions[i].Text,
                    Answers = new List<Answer>()
                });
                for (int j = 0; j < goTest.questions[i].Answers.Count; j++)
                {
                    if (goTest.questions[i].Answers.Count > 0)
                    {
                        if (goTest.questions[i].Answers[0] is AnswerText)
                        {
                            goTest.userQuestions[goTest.userQuestions.Count - 1].Answers.Add(new AnswerText()
                            {
                                Right = false,
                                Text = (goTest.questions[i].Answers[j] as AnswerText).Text
                            });
                        }
                        else
                        {
                            goTest.userQuestions[goTest.userQuestions.Count - 1].Answers.Add(new AnswerMatch()
                            {
                                Number = (goTest.questions[i].Answers[j] as AnswerMatch).Number,
                                RightVariant = -1,
                                Text = (goTest.questions[i].Answers[j] as AnswerMatch).Text
                            });
                        }
                    }
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
            public List<Question> userQuestions;
            public int indexQuestion;
            public GoTest()
            {
                questions = new List<Question>();
                userQuestions = new List<Question>();
                variant = 0;
                indexQuestion = 0;
            }
        }
        /// <summary>
        /// Load Questions From Word
        /// </summary>
        public void LoadQuestionsFromWord()
        {
            StringBuilder text = new StringBuilder();
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            object path = @"C:\Users\Maxon\Desktop\тесты\тест за варіантами — копия.doc";
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            string[] docsStrings = docs.Content.Text.Split('\r');
            docs.Close();
            //docStrings split to Test
            int currentVariant = 0, indexQuestion = 0, k;
            string nextLine = "";
            for (int i = 0; i < docsStrings.Length; i++)
            {
                nextLine = docsStrings[i];
                if (nextLine.Split(' ')[0].ToLower() == "варіант" && int.TryParse(nextLine.Split(' ')[1], out currentVariant))
                {
                    if (currentVariant > CurrentTest.variantCount)
                    {
                        CurrentTest.variantCount++;
                        for (int j = 0; j < CurrentTest.Questions.Count; j++)
                        {
                            CurrentTest.Questions[j].InVariant.Add(false);
                        }
                    }
                }
                else if (int.TryParse(nextLine.Split('.')[0], out k))
                {
                    CurrentTest.Questions.Add(new Question());
                    indexQuestion = CurrentTest.Questions.Count - 1;
                    CurrentTest.Questions[indexQuestion].Text.Add(nextLine);
                    CurrentTest.Questions[indexQuestion].InVariant[currentVariant - 1] = true;
                }
                else if (nextLine != "")
                {
                    CurrentTest.Questions[indexQuestion].Answers.Add(new AnswerText()
                    {
                        Text = nextLine
                    });
                }
            }
        }
    }

}
