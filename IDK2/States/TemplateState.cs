using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using IDK2.Classes.Entities;

/*
This is the state template, you can make a new class an then copy everythong from this file or just duplicate it.
Remember to change the name of public TemplateState to the name of the new State (ex. GameState)
 */

namespace IDK2.States
{
    internal class TemplateState : State 
    {
  
        //VARIABLES AND STUFF
        public TemplateState(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {
            //LOAD CONTENT AND INITIALIZATION OF STUFF SUCH LIKE CLASSES (ex. player = new Player())

        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            _graphic.Clear(Color.CornflowerBlue);
        }

        public override void PostUpdate(GameTime gametime)
        {
            //throw new NotImplementedException();
        }

        public override void Update(GameTime gametime)
        {
            //throw new NotImplementedException();
        }
    }
}
