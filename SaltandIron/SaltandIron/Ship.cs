using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SaltandIron
{
    class Ship
    {
        public Vector2 position = new Vector2(0, 0);

        private Texture2D texture;
        private Vector2 textureCenter;


        public void LoadContent(ContentManager ContMan, string asset)
        {
            texture = ContMan.Load<Texture2D>(asset);
            textureCenter.X = texture.Width / 2;
            textureCenter.Y = texture.Height / 2;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, 0f, textureCenter, 0.5f, SpriteEffects.None, 0f);
        }


    }
}
