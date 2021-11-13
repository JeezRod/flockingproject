using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using FlockingBackend;

namespace FlockingSimulation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        private SpriteBatch _spriteBatch;

        private World world;

        private SparrowFlockSprite sparrowFlockSprite;

        private RavenFlockSprite ravenFlockSprite;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            world = new World();
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferHeight = World._height;
            _graphics.PreferredBackBufferWidth = World._width;

            sparrowFlockSprite = new SparrowFlockSprite(this, world._sparrows);
            Components.Add(sparrowFlockSprite);

            ravenFlockSprite = new RavenFlockSprite(this, world._raven);
            Components.Add(ravenFlockSprite);

            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            world.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
