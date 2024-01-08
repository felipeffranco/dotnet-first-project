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
// new ExemploExcecao().Metodo1();


//QUEUE (FILAS) - HORIZONTAL - First in, first out (FIFO)
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine(item);
}


//STACK (PILHA) - VERTICAL - Last in, first out (LIFO)
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach(int item in pilha)
{
    Console.WriteLine($"Item número {item}");
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine($"Item número {item}");
}