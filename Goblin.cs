using System;

namespace RPG
{
  public class Goblin : ICanBeHit
  {
    public int health { get; set; } = 10;

    public void damage(int hit)
    {
      health = health - hit;
      if (health < 0)
      {
        Console.WriteLine("Goblin Defeated");
      }
      else
      {
        Console.WriteLine("Goblin health is {0}", health);
      }
    }

  }
}