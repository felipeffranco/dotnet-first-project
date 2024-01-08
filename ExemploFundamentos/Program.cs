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


//PROGRAMA EXCECOES
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo.txt");

//     foreach(string linha in linhas) 
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine($"Chegou aqui");
// }


//THROW
new ExemploExcecao().Metodo1();