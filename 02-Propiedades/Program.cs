// See https://aka.ms/new-console-template for more information



class User
{
    private int money;
    private DateTime createdAt;

    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            if (value < 0)
                value = 0;
            money = value;
        }
    }

    public User(int money, DateTime createdAt)
    {
        this.money = money;
        this.createdAt = createdAt;
    }

    public string GetInfo()
    {
        return money + " " + createdAt.ToLongDateString();
    }

}