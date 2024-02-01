// Title: "Geometry Basics: Distance between points in 2D"
// 8 kyu

using System;

public class Kata
{
    public static double DistanceBetweenPoints(Point a, Point b)
    {
        return Math.Round(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)), 6);
    }
}