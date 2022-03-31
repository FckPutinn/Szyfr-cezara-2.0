// See https://aka.ms/new-console-template for more information
string fraza;
int klucz;
Console.WriteLine("Podaj klucz szyfru:");
klucz = Int32.Parse(Console.ReadLine());
Console.WriteLine("Podaj fraze do zaszyfrowania:");
fraza = Console.ReadLine();
char[] myChar = fraza.ToCharArray();
for (int index = 0; index < myChar.Length; index++)
{
    myChar[index] = (char)(myChar[index] + klucz);
        if (myChar[index] > 90)
        {
        myChar[index] = (char)((char)myChar[index] - 26 - 6);
        }
}
string szyfr = new string(myChar);
Console.WriteLine("Zaszyfrowana wiadomośc:");
Console.WriteLine(szyfr);