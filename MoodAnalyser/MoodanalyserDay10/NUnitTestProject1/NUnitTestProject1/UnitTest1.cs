using NUnit.Framework;
using MoodAnalyserOfPerson;
namespace MoodAnalyserNUnitTest
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }

        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSad()
        {
            moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }
        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }
        public void GivenMessage_WhenSad_ShouldReturnin_negative_answer()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy  Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }





    }
}