using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace spaceship
{
    public class Controller
    {
        public List<Asteroid> asteroids = new List<Asteroid>();
        public double timer = 2D;
        public double maxTime = 2D;
        public int nextSpeed = 240;

        public bool inGame = false;

        public Controller()
        {
            
        }

        public void conUpdate(GameTime gameTime)
        {
            if (inGame)
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
            }
            else
            {
                KeyboardState kState = Keyboard.GetState();
                if (kState.IsKeyDown(Keys.Enter)){
                    inGame = true;
                }
            }
            
            //game starts when timer reaches 0
            if (timer <= 0)
            {
                //every *timer* seconds add a new asteroid, and then decrease the time between
                //asteroids spawning
                asteroids.Add(new Asteroid(nextSpeed));
                timer = maxTime;
                if (maxTime > 0.5)
                {
                    maxTime -= 0.1D;
                }

                // increase the speed with each new asteroid
                if (nextSpeed < 720)
                {
                    nextSpeed += 4;
                }
                
            }

        }
    }
}
