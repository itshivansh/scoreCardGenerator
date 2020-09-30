using System;
using System.Text;

namespace AssessmentScoreCardGenerator
{

    /* 
     * Declare enum AssessmentType with named constant for types of assessments
     * assessment types with the maximum score is:
     * QUIZ - 50
     * KBA - 100
     * CALIBRATION - 150
     * HACKATHON - 200

     * the maximum score can be set as value for enum constants
     */
    public enum AssessmentType
    {
        QUIZ = 50,
        KBA = 100,
        CALIBRATION = 150,
        HACKATHON = 200
    }

    /*
     * Declare struct AssessmentCard
     * Structure members should be assessmentType, score and datetime
     */
    public struct AssessmentCard
    {
        public int score;
        public string datetime;
        public AssessmentType assessmentType;
        public AssessmentCard(AssessmentType atype, int sco, string dt)
        {
            assessmentType = atype;
            score = sco;
            datetime = dt;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            // this code is optional here however it wil help 
            // you to understand the requirements better    
        }
        // this method accepts assessment cards and calculates total percentage
        public static int GetOverallScore(AssessmentCard[] Cards)
        {
            // the logic put here should use foreach loop to read 
            // card data and calculate percentage as mentioned.
            // the maximum score value for each assessment type can be retrieve
            // from enum constant 
            int sum = 0;
            int max = 0;
            foreach (var i in Cards)
            {
                sum = sum + i.score;
            }
            max = (int)AssessmentType.QUIZ + (int)AssessmentType.KBA + (int)AssessmentType.HACKATHON + (int)AssessmentType.CALIBRATION;
            int percentage = sum*100 / max;
            return percentage;
        }

        // this method should generate score card from the details provided
        public static string GenerateScoreCard(int cadetNo, string cadetName, AssessmentCard[] Cards, int overall)
        {
            // the code here should build string with contents such as
            // cadet no, cadet name, calibration type, score obtained

            // the built string should be returned as string and not as StringBuilder
            StringBuilder sb = new StringBuilder("");
            sb.Append(cadetNo +" ");
            sb.Append(cadetName +" ");
            foreach (AssessmentCard card in Cards)
            {
                sb.Append(card.datetime + " ");
                sb.Append(card.assessmentType + " ");
                sb.Append(card.score + " ");
            }
            sb.Append(overall + "%");
            return Convert.ToString(sb);

        }
    }

}
