using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Ball
    {
        // Instance variables
        private Color color;
        private float radius;
        private int xThrown; // Number of times thrown

        // Constructor that accepts color and radius and degines xThrown
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.xThrown = 0;
        }

        // Method that bursts the ball
        public void Burst()
        {
            radius = 0;
        }

        // Method that throws the balls
        public void Yeet()
        {
            if (radius > 0)
            {
                xThrown++;
            }
        }

        // Method that registers the times they were thrown
        public int GetXThrown()
        {
            return xThrown;
        }
    }
}
