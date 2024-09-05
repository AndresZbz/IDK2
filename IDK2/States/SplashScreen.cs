using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

/*
SPLASH SCREEN
 */

namespace IDK2.States
{
    internal class SplashScreen : State 
    {
        private Texture2D splashTexture;

        //the total time of the splash screen
        private float screenTime = 3;
        private float timer = 0;

        //time of the fade effect
        private float fadeTime = 1;
        private float alpha = 0;

        public SplashScreen(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {
            //LOAD CONTENT AND INITIALIZATION OF STUFF SUCH LIKE CLASSES (ex. player = new Player())
            splashTexture = content.Load<Texture2D>("splash");
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            _graphic.Clear(Color.Black);


            spriteBatch.Begin();
            spriteBatch.Draw(splashTexture, new Vector2( 400, 300), Color.White * alpha);
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gametime)
        {
            //throw new NotImplementedException();
        }

        public override void Update(GameTime gametime)
        {
            timer += (float)gametime.ElapsedGameTime.TotalSeconds;

            if (timer < fadeTime)
            {
                alpha = MathHelper.Lerp(0, 1, timer / fadeTime);

            }

            if (timer > screenTime - fadeTime) {
                float fadeOutStart = screenTime - fadeTime;
                alpha = MathHelper.Lerp(1, 0, (timer - fadeOutStart) / fadeTime);
            }

            if (timer >= screenTime)
            {
                _game.ChangeState(new TemplateState(_game, _graphic, _content));
            }
            //throw new NotImplementedException();
        }
    }
}
