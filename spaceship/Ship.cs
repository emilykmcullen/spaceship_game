using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace spaceship
{
    public class Ship
    {
        
        public int speed = 180;
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 position = defaultPosition;

        public Ship()
        {
        }

        public void shipUpdate(GameTime gameTime, Controller gameController)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float) gameTime.ElapsedGameTime.TotalSeconds;

            if (gameController.inGame)
            {
                //check if a key is down and that the player is not going off screen
                if (kState.IsKeyDown(Keys.Right) && position.X < 1280)
                {
                    position.X += speed * dt;
                }
                if (kState.IsKeyDown(Keys.Left) && position.X > 0)
                {
                    position.X -= speed * dt;
                }
                if (kState.IsKeyDown(Keys.Up) && position.Y > 0)
                {
                    position.Y -= speed * dt;
                }
                if (kState.IsKeyDown(Keys.Down) && position.Y < 720)
                {
                    position.Y += speed * dt;
                }
            }
        }
    }
}
