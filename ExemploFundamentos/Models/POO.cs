using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class POO
    {
/*4 pilares POO:
- Abstração 
- Encapsulamento
- Herança
- Polimorfismo

Principal conceito de POO > CLASSES e OBJETOS
Ex: Class Pessoa (representa algo do mundo real) e Objeto Bob do tipo Pessoa (classe instanciada)

Paradigmas de programação
- Programação orientada a objetos POO (estudando)
- Programação estruturada
- Programação imperativa
- Programação procedural
- Programação orientada a eventos
- Programação lógica


---------------------- ABSTRAÇÃO ---------------------- 
FILE > Pessoa.cs
public class Pessoa
{ 
    public string Nome { get; set; };
    public string Idade { get; set; };

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos!");
    }
}

FILE > Program.cs
using ExemploPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Felipe";
p1.Idade = 36;
p1.Apresentar();


---------------------- ENCAPSULAMENTO ---------------------- 
Protege uma classe e define limites para alteração de suas propriedades.
Oculta o comportamento e expõe somente o necessário.

FILE > ContaCorrente.cs
public class ContaCorrente
{
    public ContaCorrente(int numeroConta, decimal saldo)
    {
        NumeroConta = numeroConta;
        saldo = saldoInicial;
    }

    public int NumeroConta { get; set; };

    private decimal saldo;

    public void Sacar(decimal valor)
    {
        if(saldo >= valor) 
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
        } 
        else 
        { 
            Console.WriteLine("Valor desejado é maior que o saldo disponível");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine("Seu saldo disponível é: " + saldo);
    }
}

FILE > Program.cs
using ExemploPOO.Models;

ContaCorrente C1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();


---------------------- HERANÇA ----------------------
Reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
Agrupa objetos que são do mesmo tipo, porém com características diferentes.

FILE > Program.cs
using ExemploPOO.Models;

Aluno a1 = new Aluno();
a1.Nome = "Felipe";
a1.Idade = 36;
a1.Email = "teste@hotmail.com";
a1.Nota = 10;
a1.Apresentar();

FILE > Aluno.cs
namespace ExemploPOO.Models
{ 
    public class Aluno : Pessoa
    {
        public double Nota { get; set; };
    }
}

FILE > Pessoa.cs
namespace ExemploPOO.Models
    public class Pessoa
    { 
        public string Nome { get; set; };
        public string Idade { get; set; };
        public string Email { get; set; };

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos!");
        }
    }
}

FILE > Professor.cs
namespace ExemploPOO.Models;
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; };
    }
}

---------------------- POLIMORFISMO ----------------------
Com o polimorfismo podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

FILE > Program.cs
```csharp
using ExemploPOO.Models;

Aluno a1 = new Aluno();
a1.Nome = "Felipe";
a1.Idade = 36;
a1.Email = "teste@hotmail.com";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Franco";
p1.Idade = 35;
p1.Salario = 1000;
a1.Apresentar();
```

FILE > Aluno.cs
```csharp
namespace ExemploPOO.Models
{ 
    public class Aluno : Pessoa
    {
        public double Nota { get; set; };

				public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {idade} anos e sou um aluno nota {Nota}!");
        }
    }
}
```

FILE > Pessoa.cs

```csharp
namespace ExemploPOO.Models
    public class Pessoa
    { 
        public string Nome { get; set; };
        public string Idade { get; set; };
        public string Email { get; set; };

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos!");
        }
    }
}
```

FILE > Professor.cs

```csharp
namespace ExemploPOO.Models;
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; };

				public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {idade} anos e sou um professor que ganha {Salario}!");
        }
    }
}
```
*/
    }
}