using System;
using Noises.Math;
using MathD = System.Math;

namespace Noises.Noise
{
    public static class Noise
    {
        public static double GetFract(double num) => num >= 0 ? num - MathD.Floor(num) : MathD.Ceiling(num);
        public static float GetFract(float num) => num >= 0 ? num - MathF.Floor(num) : MathF.Ceiling(num);

        public static double GetMixLerp(double x, double y, double value) => x * (1 - value) + y * value;
        public static float GetMixLerp(float x, float y, float value) => x * (1 - value) + y * value;

        public static double GetRandomDouble(Vector2 vec) => GetFract(MathD.Sin(vec.Dot(new Vector2(12.9898,78.233)) * 43758.5453123));
        public static double GetRandomDouble(double x, double y) => GetFract(MathD.Sin(new Vector2(x, y).Dot(new Vector2(12.9898,78.233)) * 43758.5453123));

        public static float GetNoise(float x, float y)
        {
            return (float)GetNoise((double)x, (double)y);
        }
        
        public static double GetNoise(double x, double y)
        {
            Vector2 i = new Vector2(MathD.Floor(x), MathD.Floor(y));
            Vector2 f = new Vector2(GetFract(x), GetFract(y));

            double a = GetRandomDouble(i);
            double b = GetRandomDouble(i + new Vector2(1, 0));
            double c = GetRandomDouble(i + new Vector2(0, 1));
            double d = GetRandomDouble(i + new Vector2(1, 1));

            Vector2 u = f * f * (3d - 2d * f);

            return GetMixLerp(a, b, u.GetX()) + (c - a) * u.GetY() * (1d - u.GetX()) + (d - b) * u.GetX() * u.GetY();
        }
    }
}