using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        { 
	        get 
            { 
                return _nome;
            }

            //VALIDAR SE CAMPO ESTA VAZIO OU NAO
            set
            { 
                if(value == "")
                { 
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value; 
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome.ToUpper()} {Sobrenome.ToUpper()}";

        public int Idade
        { 
            get 
            { 
                return _idade;
            }

            //VALIDAR SE CAMPO ESTÄ VAZIO OU NAO
            set
            { 
                if(value < 0)
                { 
                    throw new ArgumentException("A idade nao pode ser menor que 0");
                }

                _idade = value; 
            }
        }

        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}