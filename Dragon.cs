using System;

namespace RPG
{
  public class Dragon : ICanBeHit
  {
    public int health { get; set; } = 100;

    public void damage(int hit)
    {
      health = health - hit;
      if (health < 0)
      {
        Console.WriteLine("Dragon Defeated");
      }
      else
      {
        Console.WriteLine("Dragon health is {0}", health);
      }
    }

  }
}