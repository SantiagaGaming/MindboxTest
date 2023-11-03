
namespace MindboxTest.Models
{
    public class Circle : Shape
    {
        private float _pi = 3.14f;
        private float _radius;
        public Circle(float radius) => _radius = radius;
        public override float GetArea() => _pi * _radius * _radius;
    }
}
