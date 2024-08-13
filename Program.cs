using pratikPolymorphism;

Square square = new Square();
Rectangle rectangle = new Rectangle();
RightTriangle triangle = new RightTriangle();
Console.WriteLine("Area of Square : " + square.AreaCalculate(3,5));
Console.WriteLine("Area of rectangle: " + rectangle.AreaCalculate(4,16));
Console.WriteLine("Area of Right-triangle: " + triangle.AreaCalculate(3,16));