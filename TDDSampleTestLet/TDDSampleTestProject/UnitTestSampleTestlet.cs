using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDSampleTestLet;

namespace TDDSampleTestProject
{
    //·       There is a Testlet with a fixed set of 10 items. 6 of the items are operational and 4 of them are pretest items.
    //·       The requirement is that the _order_ of these items should be randomized such that -
    //o   The first 2 items are always pretest items selected randomly from the 4 pretest items.
    //o   The next 8 items are mix of pretest and operational items ordered randomly from the remaining 8 items.

    [TestClass]
    public class UnitTestSampleTestlet
    {
         
        [TestMethod]
        public void TestAnswersCount()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
             * Question -Id
             *          Question
             *          Order
             *          AnswerList
             *                      Id
             *                      Answer
             *                      AnswerType - Enum Type {Pretest , Operational}
             var dictionary = new Dictionary<int, Question>
            {
                    { question1.Id, question1 },
                    { question2.Id, question2 }
            }
            */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            Int32 answersCount = question.Answers.Count;
            Assert.AreEqual(answersCount, 10);
        }

        [TestMethod]
        public void TestPreTestAnswersCount()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
             * Question -Id
             *          Question
             *          Order
             *          AnswerList
             *                      Id
             *                      Answer
             *                      AnswerType - Enum Type {Pretest , Operational}
             var dictionary = new Dictionary<int, Question>
            {
                    { question1.Id, question1 },
                    { question2.Id, question2 }
            }
            */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            Int32 preTestTypeCount = question.Answers.Where(x=>x.Answertype == AnswerType.Pretest).ToList().Count;
            Assert.AreEqual(preTestTypeCount, 4);
        }

        [TestMethod]
        public void TestOperationalAnswersCount()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
              * Question -Id
              *          Question
              *          Order
              *          AnswerList
              *                      Id
              *                      Answer
              *                      AnswerType - Enum Type {Pretest , Operational}
              var dictionary = new Dictionary<int, Question>
             {
                     { question1.Id, question1 },
                     { question2.Id, question2 }
             }
             */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            Int32 operationalTypeCount = question.Answers.Where(x => x.Answertype == AnswerType.Operational).ToList().Count;
            Assert.AreEqual(operationalTypeCount, 6);
        }

        [TestMethod]
        public void TestFirstAnswerType()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
              * Question -Id
              *          Question
              *          Order
              *          AnswerList
              *                      Id
              *                      Answer
              *                      AnswerType - Enum Type {Pretest , Operational}
              var dictionary = new Dictionary<int, Question>
             {
                     { question1.Id, question1 },
                     { question2.Id, question2 }
             }
             */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            AnswerType pretestType = question.Answers[0].Answertype;
            Assert.AreEqual(pretestType, AnswerType.Pretest);
        }

        [TestMethod]
        public void TestSecondAnswerType()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
              * Question -Id
              *          Question
              *          Order
              *          AnswerList
              *                      Id
              *                      Answer
              *                      AnswerType - Enum Type {Pretest , Operational}
              var dictionary = new Dictionary<int, Question>
             {
                     { question1.Id, question1 },
                     { question2.Id, question2 }
             }
             */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            AnswerType pretestType = question.Answers[1].Answertype;
            Assert.AreEqual(pretestType, AnswerType.Pretest);
        }

        [TestMethod]
        public void TestRandomPreTestCount()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
              * Question -Id
              *          Question
              *          Order
              *          AnswerList
              *                      Id
              *                      Answer
              *                      AnswerType - Enum Type {Pretest , Operational}
              var dictionary = new Dictionary<int, Question>
             {
                     { question1.Id, question1 },
                     { question2.Id, question2 }
             }
             */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            Int32 answerPretestCount = question.Answers.Skip(2)    // Start at appropriate index
                                        .Take(8)            // Only consider the next three values
                                         .Where(x => x.Answertype == AnswerType.Pretest).ToList().Count; // Filter appropriately
             
            Assert.AreEqual(answerPretestCount, 2);
        }

        [TestMethod]
        public void TestRandomOperationalCount()
        {
            //Testlet -- Collection
            var testletCollection = new Dictionary<int, Question>();
            testletCollection = LoadQuestions.QuestionInformation();
            /*
              * Question -Id
              *          Question
              *          Order
              *          AnswerList
              *                      Id
              *                      Answer
              *                      AnswerType - Enum Type {Pretest , Operational}
              var dictionary = new Dictionary<int, Question>
             {
                     { question1.Id, question1 },
                     { question2.Id, question2 }
             }
             */
            // Return the Question with ID 1 
            var question = testletCollection[1];
            Int32 answerPretestCount = question.Answers.Skip(2)    // Start at appropriate index
                                        .Take(8)            // Only consider the next three values
                                         .Where(x => x.Answertype == AnswerType.Operational).ToList().Count; // Filter appropriately

            Assert.AreEqual(answerPretestCount, 6);
        }
    }
}
