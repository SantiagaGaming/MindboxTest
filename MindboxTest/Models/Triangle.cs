namespace MindboxTest.Models
{
    public class Triangle : Shape
    {
        private float _sideA;
        private float _sideB;
        private float _sideC;
        private float _halfPeremitr => (_sideA + _sideB + _sideC) / 2;
        public Triangle(float sideA, float sideB, float sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override float GetArea()
        {
          var result =  Math.Sqrt(_halfPeremitr * (_halfPeremitr - _sideA) * (_halfPeremitr - _sideB) * (_halfPeremitr - _sideC));
            return (float)result;
        }
        public bool IsRectangular()
        {
            float hypotenuse = (float)Math.Pow(_sideA,2);
            float leg1 = (float)Math.Pow(_sideC, 2);
            float leg2 = (float)Math.Pow(_sideB, 2);
            bool result = hypotenuse == leg1 + leg2;
            return result;
        }
    }
}
