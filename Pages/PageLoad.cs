﻿using Masterwatch.Managers;
using Microsoft.Xna.Framework;

namespace Masterwatch.Pages
{
    // Change PageName to the name of the page class
    public class PageLoad : Page
    {
        // Title for debug of which screen is selected
        string title = "Masterwatch - Load";

        // Change PageName to the name of the page class and change 'PageID.name' to the ID of the page in PageID.cs
        public PageLoad() : base(PageID.load)
        {

        }

        public override void Init(MainGame game)
        {

        }

        public override void Update(GameTime gameTime, MainGame game)
        {
            // set window title 
            game.Window.Title = title;
        }

        public override void Draw(MainGame game)
        {
            // clear
            game.GraphicsDevice.Clear(Color.DarkSlateGray);

        }
    }
}
