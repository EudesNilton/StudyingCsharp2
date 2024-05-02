using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyingCsharp2.Models
{
    public class Curso
    {
        public  String Name { get; set; }
        public List<Pessoa> Students { get; set; }

        //adicionar um estudante
        public void AddStudents(Pessoa student)
        {
            Students.Add(student);
        }

        //listar os estudantes
        public int NumberOfStudentsEnrolled()
        {
            int amount = Students.Count;
            return amount;
        }

        //remover um estudante
        public bool RemoveStudent(Pessoa student)
        {
            return Students.Remove(student);
        }

        //exibir alunos
        public void ListStudents()
        {
            Console.WriteLine($"Alunos do curso de: {Name}");

            for (int count = 0; count < Students.Count; count++)
            {
                //interpolação
                string text = $"Nº {count + 1} - {Students[count].FullName}";
                Console.WriteLine(text);
            }
          
        }
    }
}