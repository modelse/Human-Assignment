using System;

namespace ConsoleApplication
{
    public class Wizard : Human
    {
        public Wizard(string myName):base(myName,3,25,3,50){
        //    public Human(string myName, int myStrength, int myIntelligence, int myDexterity, int myHealth)
        }

        public void Heal(){
            health+=10*intelligence;
        }

        public void Fireball(Human human){
            Random rand= new Random();
            human.health-=rand.Next(20,51);
        }
        
    }
}