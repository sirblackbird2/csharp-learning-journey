const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";
int quantitystart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantitystart;
quantity = input.Substring(quantitystart, quantityLength);
quantity = $"Quantity: {quantity}";

output = input.Replace("&trade;", "&reg");

const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

const string closeDiv = "</div>";
int divEnd = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divEnd, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);