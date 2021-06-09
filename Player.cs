using System;

namespace RPG
{
  public class Player
  {
    public int hitPower { get; set; } = 1;

    public void levelUp()
    {
      hitPower = hitPower + 40;
    }

    public void hit(ICanBeHit character)
    {
      character.damage(hitPower);
    }
  }
}