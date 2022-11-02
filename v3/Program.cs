Console.WriteLine("If statement with C# in 30 sec");

int age = new Random().Next(10,30);

Console.WriteLine($"Your age is: {age}");

if(age >= 21)
{
    Console.WriteLine("You can drink ");
}
else
{
    Console.WriteLine("You cannot drink 🚫 (yet)");
}