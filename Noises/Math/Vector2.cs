namespace Noises.Math
{
    public struct Vector2
    {
        private double _x;
        private double _y;

        public double GetX() => _x;
        public double SetX(double x) => _x = x;
        
        public double GetY() => _y;
        public double SetY(double y) => _y = y;
        
        public Vector2(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Vector2(double point)
        {
            _x = point;
            _y = point;
        }

        public Vector2(float x, float y)
        {
            _x = x;
            _y = y;
        }
        
        public Vector2(float point)
        {
            _x = point;
            _y = point;
        }

        public void Set(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void Set(double point)
        {
            _x = point;
            _y = point;
        }

        public void Set(float x, float y)
        {
            _x = x;
            _y = y;
        }
        
        public void Set(float point)
        {
            _x = point;
            _y = point;
        }

        public double Dot(Vector2 other) => _x * other._x + _y * other._y;
        public static double Dot(Vector2 a, Vector2 b) => a._x * b._x + a._y * b._y;
        
        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a._x + b._x, a._y + b._y);
        public static Vector2 operator +(Vector2 a, double b) => new Vector2(a._x + b, a._y + b);
        public static Vector2 operator +(Vector2 a, float b) => new Vector2(a._x + b, a._y + b);
        public static Vector2 operator +(double a, Vector2 b) => new Vector2(a + b._x, a + b._y);
        public static Vector2 operator +(float a,  Vector2 b) => new Vector2(a + b._x, a + b._y);
        
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a._x - b._x, a._y - b._y);
        public static Vector2 operator -(Vector2 a, double b) => new Vector2(a._x - b, a._y - b);
        public static Vector2 operator -(Vector2 a, float b) => new Vector2(a._x - b, a._y - b);
        public static Vector2 operator -(double a, Vector2 b) => new Vector2(a - b._x, a - b._y);
        public static Vector2 operator -(float a, Vector2 b) => new Vector2(a - b._x, a - b._y);

        public static Vector2 operator *(Vector2 a, Vector2 b) => new Vector2(a._x * b._x, a._y * b._y);
        public static Vector2 operator *(Vector2 a, double b) => new Vector2(a._x * b, a._y * b);
        public static Vector2 operator *(Vector2 a, float b) => new Vector2(a._x * b, a._y * b);
        public static Vector2 operator *(double a, Vector2 b) => new Vector2(a * b._x, a * b._y);
        public static Vector2 operator *(float a, Vector2 b) => new Vector2(a * b._x, a * b._y);

        public static Vector2 operator /(Vector2 a, Vector2 b) => new Vector2(a._x / b._x, a._y / b._y);
        public static Vector2 operator /(Vector2 a, double b) => new Vector2(a._x / b, a._y / b);
        public static Vector2 operator /(Vector2 a, float b) => new Vector2(a._x / b, a._y / b);
        public static Vector2 operator /(double a, Vector2 b) => new Vector2(a / b._x, a / b._y);
        public static Vector2 operator /(float a, Vector2 b) => new Vector2(a / b._x, a / b._y);

        public bool Equals(Vector2 other)                      => _x.Equals(other._x) && _y.Equals(other._y);
        public static bool Equals(Vector2 a, Vector2 b)        => a.Equals(b);

        public override bool Equals(object obj)                => !ReferenceEquals(null, obj) && (obj.GetType() == GetType() && Equals((Vector2) obj));
        
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _x.GetHashCode();
                hashCode = (hashCode * 397) ^ _y.GetHashCode();
                return hashCode;
            }
        }
    }
}