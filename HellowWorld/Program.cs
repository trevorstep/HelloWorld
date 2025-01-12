static string Reverse(string text)
{
string rev_text = "";
foreach (char c  in  text)
{
rev_text = c + rev_text;
}
return rev_text;
}



Console.WriteLine("Hello World!!!");

Console.WriteLine(Reverse("Hello World!!!"));

