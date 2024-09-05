using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Data;
using System.Runtime.InteropServices;

namespace IDK2.Classes.Entities
{
    internal class Sprite
    {
        public Texture2D _texture;
        public Rectangle srect, drect;

        //Basic collision system
        public Rectangle bounds
        {
            get
            {
                return new Rectangle((int)drect.X, (int)drect.Y, _texture.Width, _texture.Height);
            }
        }

        public Sprite(Texture2D texture, Rectangle drect, Rectangle srect)
        {
            _texture = texture;
            this.drect = drect;
            this.srect = srect;
        }

        public virtual void Update(GameTime gametime)
        {

        }

        public virtual void Draw(SpriteBatch spritebatch, Vector2 offset)
        {
            Rectangle dest = new(
                    drect.X + (int)offset.X,
                    drect.Y + (int)offset.Y,
                    drect.Width,
                    drect.Height);

            spritebatch.Draw(_texture, dest, srect, Color.White);
        }
    }
}
