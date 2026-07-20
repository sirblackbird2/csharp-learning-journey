string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    showEmail(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    showEmail(external[i, 0], corporate[i, 1], domain: externalDomain);
}

void showEmail(string firstname, string lastname, string domain = "contoso.com") 
{
    string email = firstname.Substring(0,2) + lastname;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}