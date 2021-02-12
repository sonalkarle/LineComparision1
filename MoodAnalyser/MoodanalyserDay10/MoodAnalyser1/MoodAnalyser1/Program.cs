using System;

namespace MoodAnalyserOfPerson
{
    public class MoodAnalyser
    {
        string Mood;

        public MoodAnalyser()
        {
        }

        public MoodAnalyser(string Mood)
        {
            this.Mood = Mood;
        }

        public string AnalyseMood()
        {
            if (Mood.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
        static void Main(string[] args)
        {

        }
    }
}
