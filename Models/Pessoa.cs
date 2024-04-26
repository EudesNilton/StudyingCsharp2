using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyingCsharp2.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Name}, idade: {Age}");
        }
    }
}