using System;


namespace TrackFittNumberTwo.Models
{
   
    public class CalorieCalculation : AccountInfo
    {
        



         public int CalorieCalc(int height, int weight, int age, int activityNum, string gender)
         {
            int result = 0;
            double maleBmr = 10 * weight + 6.25 * height - 5 * age + 5;
            double femaleBmr = 10 * weight + 6.25 * height - 5 * age - 161;

           
                if ( activityNum == 1)
                {
                    activityNum = (int)(double)1.2;
                }
                if (activityNum == 2)
                {
                    activityNum = (int)(double)1.375;
                }
                if (activityNum == 3)
                {
                    activityNum = (int)(double)1.55;
                }
             
                if (activityNum == 4)
                {
                    activityNum = (int)(double)1.725;
                }
             
                if (activityNum == 5)
                {
                    activityNum = (int)(double)1.9;
                }




            if (gender == "male")
            {
                result = (int)(maleBmr * activityNum);
          
            }
            if (gender == "female")
            {
                
                result = (int)(femaleBmr * activityNum);
               
            }

            return result;

         }


    }
}
