using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tira
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        public static Game1 Instance { get; set; }

        public static SpriteBatch SpriteBatch { get; set; }

        private WorldManager WorldManager;

        public Game1()
        {

            Instance = this;

            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            WorldManager = new WorldManager();

            WorldManager.Start(new World());
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            WorldManager.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, SamplerState.PointWrap, null, null, null);

            WorldManager.Draw();

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
