using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSampleTestLet
{
    //    Using Test-First Development build the functionality below -
    //·       There is a Testlet with a fixed set of 10 items. 6 of the items are operational and 4 of them are pretest items.
    //·       The requirement is that the _order_ of these items should be randomized such that -
    //o   The first 2 items are always pretest items selected randomly from the 4 pretest items.
    //o   The next 8 items are mix of pretest and operational items ordered randomly from the remaining 8 items.
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class LoadQuestions
    {
        public LoadQuestions() { }
        public static Dictionary<int, Question> QuestionInformation()
        {
            Question question1 = new Question()   {
                        Id = 1,
                        QuestionDesc = "Sample Testlet Question1",
                        Order = 1,
                        Answers = new List<Answer>(){  new Answer{ Id=1, AnswerDesc ="Pretest Answer1", Order =1, Answertype = AnswerType.Pretest}   //1
                                                    ,new Answer { Id=2, AnswerDesc ="Pretest Answer2", Order =2, Answertype = AnswerType.Pretest} //2
                                                    ,new Answer { Id=3, AnswerDesc ="Operational Answer1", Order =3, Answertype = AnswerType.Operational} //3
                                                    ,new Answer { Id=4, AnswerDesc ="Operational Answer2", Order =4, Answertype = AnswerType.Operational} //4
                                                    ,new Answer { Id=5, AnswerDesc ="Operational Answer3", Order =5, Answertype = AnswerType.Operational} //5
                                                    ,new Answer { Id=6, AnswerDesc ="Operational Answer4", Order =6, Answertype = AnswerType.Operational} //6
                                                    ,new Answer { Id=7, AnswerDesc ="Pretest Answer3", Order =7, Answertype = AnswerType.Pretest} //7
                                                    ,new Answer { Id=8, AnswerDesc ="Operational Answer5", Order =8, Answertype = AnswerType.Operational} //8
                                                    ,new Answer { Id=9, AnswerDesc ="Pretest Answer4", Order =9, Answertype = AnswerType.Pretest} //9
                                                    ,new Answer { Id=10, AnswerDesc ="Operational Answer6", Order =10, Answertype = AnswerType.Operational} //10
                                                }
                    };
            Question question2 = new Question()
            {
                Id = 1,
                QuestionDesc = "Sample Testlet Question1",
                Order = 1,
                Answers = new List<Answer>(){  new Answer{ Id=1, AnswerDesc ="Pretest Answer1", Order =1, Answertype = AnswerType.Pretest}   //1
                                                                    ,new Answer { Id=2, AnswerDesc ="Pretest Answer2", Order =2, Answertype = AnswerType.Pretest} //2
                                                                    ,new Answer { Id=3, AnswerDesc ="Operational Answer1", Order =3, Answertype = AnswerType.Operational} //3
                                                                    ,new Answer { Id=4, AnswerDesc ="Operational Answer2", Order =4, Answertype = AnswerType.Operational} //4
                                                                    ,new Answer { Id=5, AnswerDesc ="Operational Answer3", Order =5, Answertype = AnswerType.Operational} //5
                                                                    ,new Answer { Id=6, AnswerDesc ="Operational Answer4", Order =6, Answertype = AnswerType.Operational} //6
                                                                    ,new Answer { Id=7, AnswerDesc ="Operational Answer5", Order =7, Answertype = AnswerType.Pretest} //7
                                                                    ,new Answer { Id=8, AnswerDesc ="Operational Answer6", Order =8, Answertype = AnswerType.Operational} //8
                                                                    ,new Answer { Id=9, AnswerDesc ="Pretest Answer3", Order =9, Answertype = AnswerType.Pretest} //9
                                                                    ,new Answer { Id=10, AnswerDesc ="Pretest Answer4", Order =10, Answertype = AnswerType.Operational} //10
                                                                }
            };

            Dictionary<int, Question> questions = new Dictionary<int, Question>();
            questions.Add(1, question1);
            questions.Add(2, question2);

            
            return questions;
        }
    }

    public class Question 
    {
            public Question()
            {    
            }

            private int _id;
            private string _questionDesc;
            private int _order;
            private List<Answer> _answers;
 
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            

            public string QuestionDesc
            {
                get { return _questionDesc; }
                set { _questionDesc = value; }
            }
            

            public int Order
            {
                get { return _order; }
                set { _order = value; }
            }

            public List<Answer> Answers
            {
                get { return _answers; }
                set { _answers = value; }
            } 
    }

    public class Answer
    {
            public Answer()
            {
            }

            private int _id;
            private string _answerDesc;
            private int _order;
            private AnswerType _answerType;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }


            public string AnswerDesc
            {
                get { return _answerDesc; }
                set { _answerDesc = value; }
            }


            public int Order
            {
                get { return _order; }
                set { _order = value; }
            }

            public AnswerType Answertype
            {
                get { return _answerType; }
                set { _answerType = value; }
            } 
    }

    public enum AnswerType
    {
        Pretest = 0,
        Operational = 1
    }
}
