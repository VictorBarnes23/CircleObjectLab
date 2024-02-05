using CircleObjectsLab;

Console.WriteLine("Please eneter the radius of the circle");
int radiusValue = -1;
while(!int.TryParse(Console.ReadLine(), out  radiusValue)|| radiusValue <= 0)
{
    Console.WriteLine("Invalid input. Try again");
}

//Make Circle
Circle c = new Circle(radiusValue);

bool growCircle = true;
while (growCircle)
{
    //Math

    Console.WriteLine($"Diameter: {c.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {c.CalculateCircumfrence()}");
    Console.WriteLine($"Area: {c.CalculateArea()}");

    //continue
    while (true)
    {
        Console.WriteLine("Would you like to grow your circle? yes/no");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "yes")
        {
            c.Grow();
            break;
        }
        else if (answer == "no")
        {
            Console.WriteLine($"Goodbye. Your circles info was {c.GetRadius()}");
            growCircle = false;
            break;
        }
        else
        {
            Console.WriteLine("Not a proper answer try again.");
        }
    }
}