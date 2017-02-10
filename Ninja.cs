using System;

namespace ConsoleApplication
{
    public class Ninja : Human
    {
        public Ninja(string myName):base(myName,3,3,175,100){
        //    public Human(string myName, int myStrength, int myIntelligence, int myDexterity, int myHealth)
        }

        public void steal(Human human){
            human.intelligence-=1;
            health+=10;
        }

        public void GetAway(){
            health-=15;
        }
        
    }
}