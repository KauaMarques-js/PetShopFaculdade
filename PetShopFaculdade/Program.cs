// See https://aka.ms/new-console-template for more information



Console.WriteLine("Nome do seu pet: ");
   string Nome = Console.ReadLine();

Console.WriteLine("Qual a raça: ");
   string Raca = Console.ReadLine();

Console.WriteLine("Quantos anos ele tem: ");
   int idade = int.Parse(Console.ReadLine());


string classe;
    if(idade <= 1)
    {
    Console.WriteLine("Filhote");
    classe = "Filhote";
    }
    else if(idade <= 7)
    {
    Console.WriteLine("Adulto");
    classe = "Adulto";
    }
    else
    {
    Console.WriteLine("Idoso");
    classe = "Idoso";
    }
Console.WriteLine("Tamanho do bicho EM NUMERO(1:Pequeno, 2: Médio, 3: Grande): ");

int porte = int.Parse(Console.ReadLine());


double valor;
string porteTamanho;
switch (porte)
{
        case 1:
      
        Console.WriteLine("25,00 R$");
        porteTamanho = "Pequeno";
        valor = 25.00;
       
        break;

        case 2:
      
        Console.WriteLine("35,00 R$");
        valor = 35.00;
        porteTamanho = "Médio";
        break;

        case 3: 
      
        Console.WriteLine("45,00 R$");
        valor = 45.00;
        porteTamanho = "Grande";
        break;

        default: 
        Console.WriteLine("Digitou errou fi de rapariga, tenta denovo");
        valor = 00.00; //se nao atribuir o valor para o default ele da erro, pq var n pode estar vazia e pa
        porteTamanho = "";
        break;
}

Console.WriteLine("===============================================");
Console.WriteLine("Nome do Pet :" + Nome);
Console.WriteLine("Idade do Pet: "+ idade);
Console.WriteLine("Raça: " + Raca);
Console.WriteLine($"Porte do Pet e Classe: {porteTamanho}, ele é {classe} ");
Console.WriteLine($"Valor do banhoo: {valor}");
Console.WriteLine("===============================================");



