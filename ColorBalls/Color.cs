using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Color
    {
        // Instance variables
        private int red; // Variable for red 
        private int green; // Variable for green 
        private int blue; // Variable for blue
        private int alpha; // Variable for alpha
        private int v1;
        private int v2;
        private int v3;

        // Constructor that accepts values for the variables
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        // Constructor that accepts values for the colors and defines alpha's value
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        // Methods that obtain (get) the variables
        public int GetRed() // Gets red
        {
            return red; 
        }
        public int GetGreen() // Gets green
        {
            return green;
        }
        public int GetBlue() // Gets blue
        {
            return blue;
        }
        public int GetAlpha() // Gets alpha
        {
            return alpha;
        }

        // Methods that define (set) the variables
        public void SetRed(int red) => this.red = red; // Sets red
        public void SetGreen(int green) => this.green = green;  // Sets green
        public void SetBlue(int blue) => this.blue = blue; // Sets blue
        public void SetAlpha(int alpha) => this.alpha = alpha; // Sets alpha

        // Method that obtains the level of gray (Grayscale)
        public int GetGrayscale()
        {
            return (int)((red + green + blue) / 3);
        }
    }
}
