using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyingCsharp2.Models
{
    public class Pessoa
    {
        //construtor (sempre tem o mesmo nome da sua classe)
        public Pessoa()
        {

        }
        public Pessoa(string name, string lastName)
        {
            Name = name;
            LastName = lastName;

        }
        private string _name;
        private int _age;

        public string Name 
        { 
            get => _name.ToUpper(); //body expressions

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _name = value;
            }
        }
        public string LastName { get; set; }

        public string FullName => $"{Name} {LastName}".ToUpper();
        public int Age 
        { 
            get => _age;
        
            set
            {
            if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _age = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {FullName}, idade: {Age}");
        }
    }
}