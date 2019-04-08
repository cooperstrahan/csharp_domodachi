using System;

namespace Dojodachi.Models
{
    public class Dojo
    {
       public int Fullness { get; set; }
       public int Happiness { get; set; }
       public int Meals { get; set; }
       public int Energy { get; set; }
       public string Status { get; set; }
       public bool isDead { get; set; }

       public Dojo()
       {
           Fullness = 20;
           Happiness = 20;
           Meals = 3;
           Energy = 50;
           Status = "Your Dojodachi is ready to get this game going!";
           isDead = false;
       }

       Random random = new Random();

        public void Feed()
        {
            if(Meals > 0)
            {
                Meals--;
                if(random.Next(0,4) > 0)
                {
                    int addedFullness = random.Next(5,11);
                    Fullness += addedFullness;
                    Status = $"Your Dojodachi gained {addedFullness} Fullness and ate 1 Meal!";
                }
                else
                {
                    Status = "Your Dojodachi wasn't hungry!";
                }
            }
            else
            {
                Status = "You are out of meals work to earn more meals!";
            }
            Won();
            Dead();

        }
        public void Play()
        {
            if(Energy >= 5)
            {
                Energy -= 5;
                if(random.Next(0,4) > 0)
                {
                    int addedHappiness = random.Next(5,11);
                    Happiness += addedHappiness;
                    Status = $"Your Dojodachi gained {addedHappiness} Happiness and used 5 Energy!";
                }
                else
                {
                    Status = "Your Dojodachi didn't want to play!";
                }
            }
            else
            {
                Status = "You are out of energy Eat to gain more energy!";
            } 
            Won();
            Dead(); 
        }
         
        public void Work()
        {
            if(Energy >= 5)
            {
                Energy -= 5;
                int earnedMeals = random.Next(1,4);
                Meals += earnedMeals;
                Status = $"Your Dojodachi earned {earnedMeals} Meals and used 5 Energy!";
            }
            else
            {
                Status = "You are out of energy Eat to gain more energy!";
            }
            Won();
            Dead();
        }

        public void Sleep()
        {
            if(Fullness >= 5 && Happiness >= 5)
            {
                Fullness -= 5;
                Happiness -= 5;
                Energy += 15;
            }
            else
            {
                Status = "You don't have enough Happiness and/or Fullness for that!";
            }
            Won();
            Dead();
        }

        public bool Dead()
        {
            if(Fullness == 0 && Energy == 0 && Happiness == 0)
            {
                isDead = true;
                Status = "Your Domodachi passed away... please restart if you would like to play again";
                return true;
            }
            else {return false;}
        }

        public bool Won()
        {
            if(Fullness > 99 && Energy > 99 && Happiness > 99)
            {
                isDead = true;
                Status = "You won! Would you like to play again?";
                return true;
            }
            else {return false;}
        }

        public void Reset()
        {
            Fullness = 20;
            Happiness = 20;
            Meals = 3;
            Energy = 50;
            isDead = false;
            Status = "Your Dojodachi is ready to get this game going!";
        }

    }

    
}