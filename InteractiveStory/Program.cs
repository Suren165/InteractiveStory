String choice = "";

Console.WriteLine("Du har blivit kidnappad du vaknar i ett rumm ");
Console.WriteLine("Du kollar runt och ser att det finns två dörrar");
Console.WriteLine("Du ska välja mellan 2 dörrar välj mellan vänster dörr eller höger dörr");
choice = Console.ReadLine();
choice = choice.ToLower();


if (choice == "vänster dörr")
{
    Console.WriteLine("Du går igenom vänster dörr du ser att det är en lång korridor");
    Console.WriteLine("Du går igenom korridoren den är mörk och läskig ");
    Console.WriteLine("När du har gått igeonm korridoren så kommer du till ett nytt rum med två ventiler på taket");
    Console.WriteLine("Du ska välja mellan ventil 1 eller ventil 2 för att kunna fly från rummet");

    string val = Console.ReadLine();

    if (val == "ventil 1")
    {
        Console.WriteLine("bra val du har flytt från rummet grattis!");
        Console.WriteLine("Tryck enter för att avsluta spelet");
    }
    else if (val=="ventil 2")
    {
      Console.WriteLine("Du valde ventil 2 dåligt val du har dött av en drake som döda dig");
    }



}
else if (choice == "höger dörr")
{
    Console.WriteLine(" Du går igenom höger dörr du ser att det är en lång korridor");
    Console.WriteLine(" Du går igenom korridoren det låter som ett monster ");
    Console.WriteLine(" Det nya rummet har ett monster som har dödat dig ");
    Console.WriteLine("Tryck enter för att stänga av spelet");
    choice = Console.ReadLine();
    choice = choice.ToLower();

}


Console.ReadLine();