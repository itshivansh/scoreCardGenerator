## Problem Statement: Calculate Percentage of Overall Score obtained by student in different assessments

**Develop the solution for above problem statement usig enumerations, structures and StringBuilder**

**This exercise contains a class named Program with the below given methods.**

     +GetOverAllScore : int
         - Should take set of Assessment Cards
         - Retrieve the maximum score for each assessment type. Assessment type should be an enumeration
         - Should return average value as integer for the average calculated

------------------------------------------------------

      +PrintScoreCard : string
         - Should take set of Assessment Cards
         - Retrieve the maximum score for each assessment type. 
         - Assessment type should be an enumeration
         - Should send error message if all value in array are not positive
         - Should send error message if array is empty
         - Should build a string using StringBuiler that outputs cadetno, cadetName, date of appraisal, appraisal type, card data and overall score

------------------------------------------------------

      +AssessmentType : enum
         - Should contain named constants for types of assessment such as Quiz, Calibration, KBA and Hackathon
         - Maximum scores for these assessment types are :
            - Quiz : 50
            - KBA : 100
            - Calibration : 150
            - Hackathon : 200
         - The maximum score must be obtained from the enum values itself

-------------------------------------------------------

      + AssessmentCard : struct
         - Should declare struct with score, assessment type and assessment date
         - Should declare assessment type of type enum AssessmentType
         - Should be used as type for storing multiple card details

--------------------------------------------------------

## Instructions

- Avoid printing unnecessary values
- Take care of whitespace/trailing whitespace
- Do not change the provided class/method names unless instructed
- Follow best practices while coding
- Regularly push code to git
- Submit to [Hobbes](https:\\hobbes-cgi.stackroute.in) for automated testing