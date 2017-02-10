using System;

namespace ConsoleApplication
{
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public Human(string myName){
            name=myName;
            strength=3;
            intelligence=3;
            dexterity=3;
            health=100;
        }

        public Human(string myName, int myStrength, int myIntelligence, int myDexterity, int myHealth){
            name=myName;
            strength=myStrength;
            intelligence=myIntelligence;
            dexterity=myDexterity;
            health=myHealth;
        }

        public void attack(Human human){
            human.health -= 5*strength;

        } 
          
    }
}