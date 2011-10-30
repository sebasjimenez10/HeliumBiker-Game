﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeliumBiker.ScreenCtrl;
using HeliumBiker.DeviceCtrl;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace HeliumBiker.MenuCtrl
{
    class ConnectionScreen : Screen
    {
        private Button b;

        public ConnectionScreen(Game1 game, ScreenManager screenManager, DeviceManager dev)
            : base(game, screenManager, dev)
        {
            GameLib.getInstance().loadGUITextures();
            Texture2D bText = GameLib.getInstance().get(TextureE.connect);
            b = new Button(new Vector2(Game1.width / 2 - bText.Width / 2, Game1.height / 2 - bText.Height / 2), new Vector2(400, 400), TextureE.connect);
            b.Focus = true;
        }

        public override void update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            if (Game1.testText.Length > 0)
            {
                // go to menu
                ScreenManager.startMenu();
            }
            b.update(gameTime);
        }

        public override void draw(Microsoft.Xna.Framework.GameTime gameTime)
        {
            SpriteBatch sb = GameLib.getInstance().SpriteBatch;
            sb.Begin();
            sb.Draw(GameLib.getInstance().get(TextureE.menuScreen), Vector2.Zero, Color.White);
            b.draw(sb);
            sb.End();
        }

        public override void transitionOut(Microsoft.Xna.Framework.GameTime gameTime)
        {
        }

        public override void transitionIn(Microsoft.Xna.Framework.GameTime gameTime)
        {
            setState(State.active);
        }
    }
}