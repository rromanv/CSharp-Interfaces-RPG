using System;

using RPG;

Player Rodolfo = new();

Dragon Smaug = new();

Goblin Nobody = new();

Ogre Another = new();

Console.WriteLine(Rodolfo.hitPower);

for (var i = 0; i < 3; i++)
{
  Rodolfo.hit(Smaug);
}

Rodolfo.hit(Nobody);


Rodolfo.levelUp();

Rodolfo.hit(Smaug);
Rodolfo.hit(Smaug);
Rodolfo.hit(Smaug);

Rodolfo.hit(Nobody);

Rodolfo.hit(Another);
Rodolfo.hit(Another);

