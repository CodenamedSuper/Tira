using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tira
{
    public class Game1 : Game
    {
        public static GraphicsDeviceManager Graphics { get; private set; }
        public static Game1 Instance { get; set; }
        public static Camera Camera { get; private set; } = new Camera();

        public Player Player;

        public static SpriteBatch SpriteBatch { get; set; }

        public static WorldManager WorldManager;

        public Game1()
        {

            Instance = this;

            Graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            GraphicsConfig.SCREEN_WIDTH = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            GraphicsConfig.SCREEN_HEIGHT = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            GraphicsConfig.FULLSCREEN = false;
            GraphicsConfig.VSYNC = true;
            GraphicsConfig.FRAMERATE = 60;
            IsMouseVisible = true;
            GraphicsConfig.Apply();
        }

        protected override void Initialize()
        {
            base.Initialize();

            Input.Initialize();

        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            WorldManager = new WorldManager();

            WorldManager.Start(new World());

            Player = new Player(); Player.Start();

            Camera.Zoom = 4;

           // Camera.Position -= new Vector2(GraphicsConfig.SCREEN_WIDTH / 4, GraphicsConfig.SCREEN_HEIGHT / 4) / 2;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            WorldManager.Update();

            Player.Update();

            Input.Update();

            Camera.Update();

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, SamplerState.PointWrap, null, null, null, Camera.Matrix);

            WorldManager.Draw();

            Player.Draw();

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
