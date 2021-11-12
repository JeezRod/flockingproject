using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using FlockingBackend;

namespace FlockingSimulation{

    public class SparrowFlockSprite: DrawableGameComponent{

        private Game1 game;

        private SpriteBatch spriteBatch;

        private List<Sparrow> sparrowList;

        private Texture2D sparrowImg;

        public SparrowFlockSprite(Game1 game, List<Sparrow> sparrowList): base(game){
            this.game = game;
            this.sparrowList = sparrowList;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent(){
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sparrowImg = game.Content.Load<Texture2D>("sparrow");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
           spriteBatch.Begin();
           foreach(Sparrow sparrow in sparrowList){
               spriteBatch.Draw(sparrowImg, new Microsoft.Xna.Framework.Vector2(sparrow.Position.Vx,
               sparrow.Position.Vy), null, Color.White, sparrow.Rotation, new Microsoft.Xna.Framework.Vector2(10, 10), 1, SpriteEffects.None, 0f);
           }
           spriteBatch.End();
           base.Draw(gameTime);
        }
    }
}