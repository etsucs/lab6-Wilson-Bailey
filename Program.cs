static void ShowCharacter(string text, int index)
{
    index -= 1;
    char subText = text[index];
    Console.WriteLine(subText);
}
ShowCharacter("New York", 2);


static float CalculateRetail()
{
    float retailPrice = 0.0f;
    float wholeSaleCost = 0.0f;
    float percentage = 0.0f;
    float total = 0.0f;


    //Get wholesale price
    Console.WriteLine("Enter wholesale cost: ");
    wholeSaleCost = float.Parse(Console.ReadLine());

    //Get Markup percentage
    Console.WriteLine("Enter markup percentage: ");
    percentage = float.Parse(Console.ReadLine());

    //calculate retail price
    total = wholeSaleCost * percentage;
    retailPrice = wholeSaleCost + total;

    return retailPrice;

}

Console.WriteLine(CalculateRetail());

float Celsius(float fahrenheit)
{
    float celsius = 0.0f;
    celsius = 5.0f / 9.0f * (fahrenheit - 32);
    return celsius;


}
for (float i = 80.0f; i <= 100.0f; i++)
{
    Console.Write("Farenheit   Celsius");
    Console.WriteLine("");
    Console.WriteLine(i + " " + Celsius(i));

}

void IsPrime(int number)
{
    int counter = 0;
    for (int i = number; i > 0; i--)
    {
        if (number % i == 0)
        {
            counter++;
        }
    }
    if (counter == 2)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }


}
Console.WriteLine("Check if a number is prime: ");
IsPrime(Convert.ToInt32(Console.ReadLine()));

