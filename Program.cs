// See https://aka.ms/new-console-template for more information
using StudyingCsharp2.Models;


Pessoa p1 = new Pessoa(name: "Eudes", lastName: "Nilton");
Pessoa p2 = new Pessoa(name: "Maria", lastName: "Bethani");


Curso englishCourse = new Curso();
englishCourse.Name = "English";
englishCourse.Students = new List<Pessoa>();

englishCourse.AddStudents(p1);
englishCourse.AddStudents(p2);
englishCourse.ListStudents();



