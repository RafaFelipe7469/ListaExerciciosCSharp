//TURMA: 2TDSA
//RM: 87469
//NOME: Rafael Felipe Zamignani


// Ex: 1

Console.Write("Digite a medida de A: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Digite a medida de B: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Digite a medida de C: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine($"Área do trângulo tendo A como base e C por altura: {(a * c) / 2}");

Console.WriteLine($"Área do círculo de raio C: {(Math.PI * Math.Pow(c, 2)).ToString("F")}");

Console.WriteLine($"Área do trapézio que tem A e B como bases e C por altura: {((a + b) * c) / 2}");

Console.WriteLine($"Área do quadrado que tem lado B: {Math.Pow(b, 2)}");

Console.WriteLine($"Área do retângulo que tem lados A e B: {a * b}");

// Ex: 2

Console.Write("Digite a medida de A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Digite a medida de B: ");
int B = int.Parse(Console.ReadLine());

bool multiplos = false;

if (A > B)
{
    multiplos = A % B == 0 ? true : false;
}
else if (B > A)
{
    multiplos = B % A == 0 ? true : false;
}
else
{
    multiplos = true;
}

if (multiplos)
{
    Console.WriteLine("Os números são múltiplos");
}
else
{
    Console.WriteLine("Os números não são múltiplos");
}

// Ex: 3

Console.Write("Digite a estimativa otimista (em hrs): ");
int otimista = int.Parse(Console.ReadLine());

Console.Write("Digite a estimativa pessimista (em hrs: ");
int pessimista = int.Parse(Console.ReadLine());

Console.Write("Digite a estimativa mais provável (em hrs: ");
int provavel = int.Parse(Console.ReadLine());

double pert = (otimista + pessimista + (4 * provavel)) / 6;

Console.WriteLine($"PERT = {pert}");

// Ex: 4

Console.Write("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7) Console.WriteLine("Aprovado");
else if (nota < 7 && nota >= 4) Console.WriteLine("Recuperação");
else Console.WriteLine("Reprovado");

// Ex: 5

Console.Write("Selecione uma opção de 1 a 3: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Bom dia");
        break;
    case 2:
        Console.WriteLine("Boa tarde");
        break;
    case 3:
        Console.WriteLine("Boa noite");
        break;
    default:
        Console.WriteLine("Número inválido");
        break;
}

// Ex: 6

Console.Write("Digite o número que deseja para calcular o fatorial: ");
int numero2, numero3 = int.Parse(Console.ReadLine());
numero2 = numero3;
int fatorial = 1;

while (numero3 != 1)
{
    if (numero3 == 0) break;
    fatorial *= numero3;
    numero3--;
}

Console.WriteLine($"O fatorial de: {numero2} é: {fatorial}");

// Ex: 7

Console.Write("Digite o número desejado (inteiro): ");
int numeroDesejado = int.Parse(Console.ReadLine());

if (numeroDesejado <= 0) Console.WriteLine("Número inválido");

int contador = 0;

while (numeroDesejado > 0)
{
    numeroDesejado--;
    contador++;
    Console.WriteLine($"{contador} {Math.Pow(contador, 2)} {Math.Pow(contador, 3)}");
}

// Ex: 8

int chaves = 0;
int chiquinha = 0;
int quico = 0;
int nulo = 0;


Console.WriteLine("Opções de Voto: ");
Console.WriteLine("1. Candidato Chaves");
Console.WriteLine("2. Candidato Chiquinha");
Console.WriteLine("3. Candidato Quico");
Console.WriteLine("4. Nulo/Branco");
Console.WriteLine("5. Encerrar a votação");
while (true)
{
    Console.Write("Entre com seu voto: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você votou no Candidato Chaves");
            chaves++;
            break;
        case 2:
            Console.WriteLine("Você votou na Candidato Chiquinha");
            chiquinha++;
            break;
        case 3:
            Console.WriteLine("Você votou no Candidato Quico");
            quico++;
            break;
        case 4:
            Console.WriteLine("Você votou Nulo/Branco");
            nulo++;
            break;
        case 5:
            Console.WriteLine("Votação Encerrada");
            Console.WriteLine($"Candidato Chaves: {chaves} votos");
            Console.WriteLine($"Candidato Chiquinha: {chiquinha} votos");
            Console.WriteLine($"Candidato Quico: {quico} votos");
            Console.WriteLine($"Nulo/Branco: {nulo} votos");

            double totalVotos = chaves + chiquinha + quico + nulo;

            Console.WriteLine($"Porcentagem de votos Nulos: {(nulo / totalVotos) * 10} %");
            Console.WriteLine($"Porcentagem de votos Brancos: {(nulo / totalVotos) * 10} %");

            List<int> escolhaVotos = new List<int> { chaves, chiquinha, quico };
            int maisVotado = escolhaVotos.Max();

            int repeticoes = 0;
            string ganhador = "";

            if (maisVotado == chaves)
            {
                repeticoes++;
                ganhador += "Chaves ";
            }
            if (maisVotado == chiquinha)
            {
                repeticoes++;
                ganhador += "Chiquinha ";
            }
            if (maisVotado == quico)
            {
                repeticoes++;
                ganhador += "Quico ";
            }

            if (repeticoes == 1) Console.WriteLine($"O ganhador foi {ganhador}");
            else Console.WriteLine($"Houve um empate! O ganhadores foram {ganhador}");

            break;
        default:
            Console.WriteLine("Opção Inválida");
            Console.ReadKey();
            break;
    }
    if (opcao == 5) break;
}
