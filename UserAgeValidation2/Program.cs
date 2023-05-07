// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal sisetada enda vanuse
//kui kasutaja vanus on vähem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13- stack-int tüüpi

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
//else if (userAge == 13) ka variant kui tahad lisaridu koodi
//{
    //Console.WriteLine("Welcome to Instagram!");
//}
else // if käsuga saab ka aga pole vaja
{
    Console.WriteLine("You are too young to use Instagram");
}
