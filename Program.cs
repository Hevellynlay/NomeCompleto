Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");

Console.Write($"Boa noite, {sobrenome.ToUpper()}, tudo bem?");