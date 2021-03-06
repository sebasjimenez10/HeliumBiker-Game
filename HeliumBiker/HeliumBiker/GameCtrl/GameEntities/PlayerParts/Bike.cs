﻿using HeliumBiker.GameCtrl.GameEntities.ShapeCtrl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HeliumBiker.GameCtrl.GameEntities.PlayerParts
{
    internal class Bike : PhysicsObject
    {
        public Bike(Vector2 position, float angle, Color color)
            : base(position, new Vector2(76, 76), angle, color, getLibTexuture(), Animation.getAnimation(getLibTexuture()), getShapes())
        {
            LayerDepth = 0.1f;
        }

        private static Texture2D getLibTexuture()
        {
            return GameLib.getInstance().get(TextureE.bike);
        }

        private static Shape[] getShapes()
        {
            return new Shape[]
            {
                new CircleShape(new Vector2(-19, 26), 10f), // Rueda izquierda
                new CircleShape(new Vector2(20, 27), 10f)   // Rueda derecha
            };
        }
    }
}