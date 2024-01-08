using ExemploFundamentos.Models;

//PROGRAMA PESSOA - CURSO
// Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome: "Franco");
// Pessoa p2 = new Pessoa(nome: "Nayra", sobrenome: "Biondo"); 

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


//Dictionary
//Colecao de chave-valor para armazenar valores únicos sem uma ordem específica
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "Sao Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("MA", "Manharao");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}" );
}

Console.WriteLine("------------------------");

estados.Remove("MA");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}" );
}