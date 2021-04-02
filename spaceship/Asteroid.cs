using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


using System;
namespace spaceship
{
    public class Asteroid
    {
        public Vector2 position;
        public int speed;
        public int radius = 59;
        Random rand = new Random();

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;
            
            position = new Vector2(1280 + radius, rand.Next(0,721));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }



    }
}
