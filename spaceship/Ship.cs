﻿using System;
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
                if (kState.IsKeyDown(Keys.Right))
                {
                    position.X += speed * dt;
                }
                if (kState.IsKeyDown(Keys.Left))
                {
                    position.X -= speed * dt;
                }
                if (kState.IsKeyDown(Keys.Up))
                {
                    position.Y -= speed * dt;
                }
                if (kState.IsKeyDown(Keys.Down))
                {
                    position.Y += speed * dt;
                }
            }
        }
    }
}
