// See https://aka.ms/new-console-template for more information


bool isActive = true;
bool isPremiun = true;

if(isActive && isPremiun && IsPayProcess("Visa",15.0))
{
    Console.WriteLine("Puedes acceder");
}
else
{
    Console.WriteLine("No haz pagado suscripcion");
}


static bool IsOpenRestaurant(string name, int hour = 0)
{
    if(name == "Papitas Queen" && hour > 8 && hour <23)
    {
        return true;
    }
    else if (name == "Restaurant 24 horas")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool IsPayProcess(string name, double pay = 0.0)
{
    if ( (name == "Visa" || name == "MasterCard") && (pay >10.20 && pay < 40.9))
    {
        return true;
    }
    else if (name == "Google Pay")
    {
        return true;
    }
    else
    {
        return false;
    }

}