using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDK2.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace IDK2.Classes
{
    internal class FollowCamera
    {

        public Vector2 pos;

        public FollowCamera(Vector2 pos)
        {
            this.pos = pos;
        }

        public void follow(Rectangle target, Vector2 screenSize)
        {
            pos = new Vector2(
                    -target.X + (screenSize.X / 2 - target.Width / 2),
                    -target.Y + (screenSize.Y / 2 - target.Height / 2)
                );
        }

        public void Draw(SpriteBatch spriteBatch, List<Entities.Sprite> sprites) {
            List<Entities.Sprite> sorted = sprites.OrderBy(obj => obj.drect.Bottom).ToList();

            foreach (Entities.Sprite sprite in sorted)
            {
                sprite.Draw(spriteBatch, pos);
            }
        }
    }   
}
