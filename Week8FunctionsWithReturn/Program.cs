using System.IO.Pipes;

string[] tvShows = { "The Last Of Us", "Peaky Blinders", "How I Met Your Mother", "Stranger Things", "Firefly", "Office", "Friends" };
string[] food = { "sushi", "pizza", "burger and chips", "chips", "popcorn", "chicken wings", "Chinese Takeaway" };
string[] drink = { "mineral water", "Coca cola", "apple juice", "milk", "beer" };

string randoMovie = PickRandomFromArray(tvShows);
string randomfood = PickRandomFromArray(food);
string randomdrink = PickRandomFromArray(drink);

Console.WriteLine($"ı recommend you to watch {randoMovie} tonight");
Console.WriteLine($"Order some {randomfood} and {randomdrink}.");

PickRandomFromArray(tvShows);
PickRandomFromArray(food);
PickRandomFromArray(drink);
static string PickRandomFromArray(string[] someArray)
{
    Random rnd = new Random();

    int randomİndex = rnd.Next(0, someArray.Length);
    string randomElements = someArray[randomİndex];
    return randomElements;
}
