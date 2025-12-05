// See https://aka.ms/new-console-template for more information

using System.Numerics;

User user1 = new User(200,DateTime.UtcNow);
Console.WriteLine( user1.GetInfo());

class User
{
    int money;
    DateTime createdAt;

    public User(int money, DateTime createdAt)
    {
        this.money = money;
        this.createdAt = createdAt;
    }

    public string GetInfo()
    {
        return money + " " + createdAt.ToLongDateString();
    }
    public void Show()
    {
        Console.WriteLine("Hola soy un usuario");
    }
}


