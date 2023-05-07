// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal selekteerida oma sugu (m/f)
//rakendus  palub sisetada kasutajanime
//lähtudes kasutajavalikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome Mr. [kasutaja perekonnanimi] / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please , select your gender (m/f):");

char userGender = Char.Parse (Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your name");

string userLastName = Console.ReadLine ();

    string userLastname = Console.ReadLine ();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome! {userLastName}");
}

