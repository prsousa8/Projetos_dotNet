using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotNet.Models
{
    public class Pessoa
    {
        //Construtor
        public Pessoa(string nome, string sobrenome, int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        //Desconstrutor
        public void Deconstruct(out string nome, out string sobrenome){
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome = "";
        private int _idade = 0;
        public string Nome { 
            get{
                return _nome.ToUpper(); //Body Expressions --> get => _nome.ToUpper();
            } 
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto =>$"{Nome} {Sobrenome.ToUpper()}";

        public int Idade { 
            get => _idade; 
            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            } 
        }

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e tenho {Idade} anos");
        }
    }
}