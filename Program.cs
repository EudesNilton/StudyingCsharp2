// See https://aka.ms/new-console-template for more information
using StudyingCsharp2.Models;

//auteração da localização do codigo
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

//IF TERNARIO
int number = 20;

bool ePar = false;

ePar = number % 2 == 0;

Console.WriteLine($"O número {number} é " + (ePar ? "par" : "impar"));

//IF comum

if(number % 2 == 0)
{
    Console.WriteLine($"O número {number} é par");
}
else{
    Console.WriteLine($"O numero {number} é impar");
}


//DESCONTRUTOR separador 
Pessoa p90 = new Pessoa("Eudes", "Nilton");

(string Name, string LastName) = p90;

Console.WriteLine($"{Name} {LastName}");



LeituraArquivo arquivo = new LeituraArquivo();
arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

//descarte é só colocar o _ no lugar da variavel
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    foreach(string linhas in linhasArquivo)
    {
        Console.WriteLine(linhas);
    }
} 
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}


//TUPLA
(int, string, string, decimal) tupla = (1, "Eudes", "Nilton", 1.70M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"altura: {tupla.Item4}");

//outra forma de tupla
ValueTuple<int, string, string, decimal> outraFormadeTupla =  (1, "Eudes", "Nilton", 1.70M);

//mais uma forma de tupla
var tupla3 = Tuple.Create(1, "Eudes", "Nilton", 1.70M);


//DICTIONARY
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("DF", "Distrito Federal");
estados.Add("BA", "Bahia");

Console.WriteLine(estados["DF"]);

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

//remover e alterar valor

estados.Remove("DF");

estados["DF"] = "Distrito Federal - novo";

//verificar elemento 
string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave:{chave}");
}

//PILHA

Stack<int> pilha = new Stack<int>();
pilha.Push(2); //adicionar elementos no topo da pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(1);
pilha.Push(0);
pilha.Push(9);

foreach(int itens in pilha)
{
    Console.WriteLine(itens);
}

pilha.Pop();//remove o elemento do topo da pilha, ultimo elemento colocado

//FILA

Queue<int> fila = new Queue<int>();

fila.Enqueue(2); //adicionar elementos na fila
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(1);
fila.Enqueue(0);
fila.Enqueue(9);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue(); //exclui o primeiro elemento da lista;

//THROW 
new ExemploExcecao().Metodo1();

//LEITURA DE UM ARQUIVO

try //tente
{


    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
 
    foreach(string linha in linhas)
    {
    Console.WriteLine(linha);
    } 
}
catch (FileNotFoundException ex) //pegar 
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
}
catch (Exception ex) //pegar 
{
    Console.WriteLine($"Aconteceu uma exeção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}


//FORMATAR VALORES MONETARIOS
decimal valorMonetario = 82.70M;
Console.WriteLine($"{valorMonetario:C}");

//alterando a localização do código de forma unitaria //C1 uma casa decimal C2 duas casas decimais
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .232334;

Console.WriteLine(porcentagem.ToString("P"));

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));



//concatenação de valores

int numer1 = 10;
int numer2 = 20;

int result = numer1 + numer2;

Console.WriteLine(result);


//pessoa

Pessoa p1 = new Pessoa(name: "Eudes", lastName: "Nilton");
Pessoa p2 = new Pessoa(name: "Maria", lastName: "Bethani");
Pessoa p3 = new Pessoa(name: "João", lastName: "Guilherme");
Pessoa p4 = new Pessoa(name: "Artur", lastName: "Miguel");


Curso englishCourse = new Curso();
englishCourse.Name = "FreeFire";
englishCourse.Students = new List<Pessoa>();

englishCourse.AddStudents(p1);
englishCourse.AddStudents(p2);
englishCourse.AddStudents(p3);
englishCourse.AddStudents(p4);
englishCourse.ListStudents();



