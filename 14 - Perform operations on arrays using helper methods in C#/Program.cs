/* Exercise 1 "reverse words in a sentence challenge"

string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');

foreach (var word in words)
{
    char[] characterarray = word.ToCharArray();
    Array.Reverse(characterarray);
    string result = String.Join("", characterarray);
    Console.Write($"{result} ");
}
*/

// Exercise 2 "Complete a challenge to parse a string of orders, sort the orders and tag possible errors"
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (var order in orders)
{
    if (order.Length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine($"{order}\t- Error");
    }
}
