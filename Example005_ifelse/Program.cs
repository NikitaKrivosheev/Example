Console.WriteLine("Привет, как тебя зовут ?");
string userName = Console.ReadLine();
string name = "маша";
if (userName.ToLower() == name)
{
    Console.Write("Привет дорогая, " + name);
} 
else 
{
    Console.Write("Привет, " + userName);
}
