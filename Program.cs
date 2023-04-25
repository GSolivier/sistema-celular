using sistema_celular;

Celular celular = new Celular();
string estadoEscolha;
string escolhaMenu;
bool loopBreak = true;

Console.WriteLine($"Digite a cor do seu celular:");
celular.Cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do seu celular?");
celular.Modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do seu celular?");
celular.Tamanho = Console.ReadLine();

escolhaEstado:
Console.WriteLine($"O seu celular está ligado? 's' para sim / 'n' para não.");
estadoEscolha = Console.ReadLine().ToLower();

switch (estadoEscolha)
{
    case "s":
    celular.Estado = true;
        break;

    case "n":
    celular.Estado = false;
    break;

    default:
    Console.WriteLine($"Digite uma letra válida.");
    
    goto escolhaEstado;
}

do
{
    menuStart:
    Console.Clear();
    Console.WriteLine(@$"
    O que deseja fazer?

    [1] - Realizar Ligação
    [2] - Enviar Mensagem
    [3] - Informações sobre o dispositivo
    [4] - Ligar/Desligar aparelho
    ");

    if (celular.Estado == true)
    {
        Console.WriteLine($"O celular está atualmente ligado!");
        
    }
    else{
        Console.WriteLine($"O celular está atualmente desligado!");
        
    }
escolhaMenu = Console.ReadLine();

switch (escolhaMenu)
{
    case "1":
    Console.Clear();
    celular.Chamada();
    goto menuStart;
    
    case "2":
    Console.Clear();
    celular.Mensagem();
    goto menuStart;    

    case "3":
    Console.WriteLine($"Cor: {celular.Cor}");
    Console.WriteLine($"Modelo: {celular.Modelo}");
    Console.WriteLine($"Tamanho: {celular.Tamanho}");

    Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
    Console.ReadKey();
    goto menuStart;

    case "4":
    if(celular.Estado == true){
        celular.Desligar();
        goto menuStart;
    }
    else{
        celular.Ligar();
        goto menuStart;
    }
    default:
    Console.Clear();
    Console.WriteLine($"Digite uma opção válida!");
        goto menuStart;
}

    
} while (loopBreak);





