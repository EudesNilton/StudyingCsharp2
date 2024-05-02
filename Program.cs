// See https://aka.ms/new-console-template for more information
using StudyingCsharp2.Models;

//auteração da localização do codigo
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

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



