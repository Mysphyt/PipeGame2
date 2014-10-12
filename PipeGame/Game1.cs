#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace PipeGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
 
        Readfile posArray = new Readfile();
        int gameR, gameC;
        //const int columns = 10;
        //const int rows = 10;
        int particlePosX;
        int particlePosY;
        //char[,] positionArray = new char[rows, columns];
        int[] size = new int[2];
        int[] start = new int[2];
        int[] finish = new int[2];
        char type;
        Pipe[,] level;
        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

           
            
            // TODO: Add your update logic here
            Pipe pipe;
            for (gameR = 0; gameR < columns; gameR++)
            {
                for (gameC = 0; gameC < rows; gameC++)
                {
                    //Find type
                    type = positionArray[gameR, gameC];
                    //Define pipe using 'Pipe(type)'
                    
                    //Fill Level[,] with the pipe
                    pipe = new Pipe(type);

                    //Fill the array of pipes
                    level[gameR, gameC] = pipe;
                }
            }
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            for (gameR = 0; gameR < rows; gameR++)
            {
                for (gameC = 0; gameC < columns; gameC++)
                {
                    System.Diagnostics.Debug.WriteLine(positionArray[gameR, gameC]);
                }
                Console.WriteLine("");
            }
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            // Rnder level:
            // ...

            base.Draw(gameTime);
        }
    }
}
