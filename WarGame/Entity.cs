
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WarGame
{
    public class Entity
    {
        public Texture2D Texture;
        public Point Position;
        public Point Size;
        public Color Color;

        public  Entity(int x, int y, int w, int h) :
            this(new Point(x, y),
                new Point(w, h),
                Color.Aqua)
        {
        }

        public Entity(Point position, Point size, Color color)
        {
            Position = position;
            Size = size;
            Color = color;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Bounds, Color);
        }

        public Rectangle Bounds => new Rectangle(Position, Size);
    }
}