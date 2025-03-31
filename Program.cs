string Espécie, Raça, Alcunha, idade, Pelagem;

Console.ForegroundColor = ConsoleColor.Gray;


 Console.WriteLine("Espécie");
 Espécie = Console.ReadLine()!;
 
 Console.WriteLine("Raça");
Raça = Console.ReadLine()!;

Console.WriteLine("Alcunha");
Alcunha = Console.ReadLine()!;

Console.WriteLine("idade");
idade = Console.ReadLine()!;

Console.WriteLine("Pelagem");
Pelagem = Console.ReadLine()!;


 Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");
Console.WriteLine("|                 Pet Hotel 'Nem um pio'                  |");
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"| Espécie: {Espécie.PadLeft(16,'.').Remove(16)} | Raça: : {Raça.PadLeft(20,'.').Remove(20)}|");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"| Atende pela alcunha de: {Alcunha.PadLeft(32,'.').Remove(32)}|");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"| Idade: {idade.PadLeft(2,'0').Remove(2)} ano(s) | Pelagem/cor : {Pelagem.PadLeft(23,'.').Remove(23)}|");

 Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

//Espécie 16
//Raça 20
//Alcunha 32
//pelagem 23
