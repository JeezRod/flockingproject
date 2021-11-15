using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FlockingBackend;

namespace FlockingSimulation{

    public class RavenFlockSprite: DrawableGameComponent{

        private Game1 game;

        private SpriteBatch spriteBatch;

        private Raven raven;

        private Texture2D sparrowImg;

        public RavenFlockSprite(Game1 game, Raven raven): base(game){
            this.game = game;
            this.raven = raven;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent(){
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sparrowImg = game.Content.Load<Texture2D>("raven");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
           spriteBatch.Begin();
            spriteBatch.Draw(sparrowImg, new Microsoft.Xna.Framework.Vector2(raven.Position.Vx,
            raven.Position.Vy), null, Color.White, raven.Rotation, new Microsoft.Xna.Framework.Vector2(10, 10), 1, SpriteEffects.None, 0f);
           spriteBatch.End();
           base.Draw(gameTime);
        }
    }
}