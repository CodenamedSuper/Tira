using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tira
{
    public class Game1 : Game
    {
        public static GraphicsDeviceManager Graphics { get; private set; }
        public static Game1 Instance { get; set; }
        public Camera Camera { get; private set; } = new Camera();



        public static SpriteBatch SpriteBatch { get; set; }

        private WorldManager WorldManager;

        public Game1()
        {

            Instance = this;

            Graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            GraphicsConfig.SCREEN_WIDTH = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            GraphicsConfig.SCREEN_HEIGHT = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            GraphicsConfig.FULLSCREEN = true;
            GraphicsConfig.VSYNC = true;
            GraphicsConfig.FRAMERATE = 60;
            IsMouseVisible = true;
            GraphicsConfig.Apply();
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

            Camera.Zoom = 4;

            Camera.Position -= new Vector2(GraphicsConfig.SCREEN_WIDTH / 4, GraphicsConfig.SCREEN_HEIGHT / 4) / 2;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            WorldManager.Update();

            Camera.Update();

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, SamplerState.PointWrap, null, null, null, Camera.Matrix);

            WorldManager.Draw();

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
