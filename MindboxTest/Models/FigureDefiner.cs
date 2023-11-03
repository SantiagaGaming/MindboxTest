namespace MindboxTest.Models
{
    public class FigureDefiner
    {
        private float _a;
        private float _b;
        private float _c;

        public FigureDefiner(float a)
        {
            _a = a;
        }
        public FigureDefiner(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public string Define()
        {
            if(_b!=0 && _c!=0)
            {
                var figure = new Triangle(_a, _b, _c);
                return $"Фигура является треугольником. Площадь: {figure.GetArea()}";
            }
            else
            {
                var figure = new Circle(_a);
                return $"Фигура является кругом. Площадь: {figure.GetArea()}";
            }
        }
    }
}
