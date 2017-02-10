using System;

namespace ConsoleApplication
{
    public class Samurai : Human
    {
        public Samurai(string myName):base(myName,3,3,3,200){
        //    public Human(string myName, int myStrength, int myIntelligence, int myDexterity, int myHealth)
        }

        public void meditate(){
            health=200;
        }

        public void death_blow(Human human){
            if(human.health<51){
                human.health=0;
            }
        }
        
    }
}