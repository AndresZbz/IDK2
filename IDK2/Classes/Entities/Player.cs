using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace IDK2.Classes.Entities
{
    internal class Player : Sprite
    {
        
        public int speed = 5;
        public Player(Texture2D texture, Rectangle drect, Rectangle srect) : base(texture, drect, srect)
        {

        }

        public override void Update(GameTime gametime)
        {
            KeyboardState kstate = Keyboard.GetState();

            if(kstate.IsKeyDown(Keys.Right))
            {
                drect.X += -speed;
            }

            if (kstate.IsKeyDown(Keys.Left))
            {
                drect.X += speed;
            }

            if (kstate.IsKeyDown(Keys.Up))
            {
                drect.Y += speed;
            }

            if (kstate.IsKeyDown(Keys.Down))
            {
                drect.Y += -speed;
            }

            base.Update(gametime);
        }
    }
}
