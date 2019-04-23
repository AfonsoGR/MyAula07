using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the red and purple colors
            Color red = new Color (255, 0, 0);
            Color purple = new Color(255, 0, 255);
            // Create two different balls of different colors and sizes
            Ball bigRed = new Ball(red, 5 );
            Ball littlePurple = new Ball(purple, 3);
            // Check i n d i v i d u a l c o l o r s o f the p u r p l e c o l o r
            Console.WriteLine($"Purple = ({purple.GetRed()}, {purple.GetGreen()}, {purple.GetBlue()})");
            // Throw the big red ball around a few times
            bigRed.GetXThrown();
            bigRed.GetXThrown();
            bigRed.GetXThrown();
            Console.WriteLine(bigRed.GetXThrown());

            // Throw the little purple ball around a few times
            littlePurple.GetXThrown();
            littlePurple.GetXThrown();
            littlePurple.GetXThrown();
            Console.WriteLine(littlePurple.GetXThrown());

            // Pop the little purple ball and make sure that the throw
            // count doesn’t keep going up if the ball has been popped
            littlePurple.Burst();
            littlePurple.GetXThrown();
            Console.WriteLine(littlePurple.GetXThrown());
        }
    }
}
