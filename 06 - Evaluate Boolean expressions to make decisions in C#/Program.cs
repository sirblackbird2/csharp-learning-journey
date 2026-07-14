/*  EQUALITY
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
*/

/*   IMPROVED EQUALITY
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

/*  INEQUALITY
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

/*  COMPARISON
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

/*  CONDITIONAL
int saleAmount = 1001;
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
    if (level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    
    else 
        Console.WriteLine("Welcome, Admin user.");

else if (permission.Contains("Manager"))
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access.");

    else
        Console.WriteLine("You do not have sufficient privileges.");

else 
    Console.WriteLine("You do not have sufficient privileges.");