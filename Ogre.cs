using System;

namespace RPG
{
  public class Ogre : ICanBeHit
  {
    public int health { get; set; } = 50;

    public void damage(int hit)
    {
      health = health - hit;
      if (health < 0)
      {
        Console.WriteLine("Ogre Defeated");
      }
      else
      {
        Console.WriteLine("Ogre health is {0}", health);
      }
    }

  }
}