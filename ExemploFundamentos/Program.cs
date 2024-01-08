using ExemploFundamentos.Models;

//INSTANCIAR PESSOA EM CLASS
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Felipe";
// pessoa1.Idade = 36;
// pessoa1.Apresentar();



//TABUADA COM FOR
// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} * {contador} é igual a {numero * contador}");
// }


//MENU INTERATIVO
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu) {
//     Console.Clear();
// 	Console.WriteLine("Digite a sua opção: ");
// 	Console.WriteLine("1- Cadastrar cliente");
// 	Console.WriteLine("2 - Buscar cliente");
// 	Console.WriteLine("3 - Deletar cliente");
// 	Console.WriteLine("4 - Encerrar");

// 	opcao = Console.ReadLine();

//     Console.WriteLine($"Opção selecionada foi {opcao}");

// 	switch(opcao) {
// 		case "1": 
// 			Console.WriteLine("Cadastro de cliente");
// 			break;

// 		case "2": 
//             Console.WriteLine("Busca de cliente");
//             break;
            
// 		case "3": 
//             Console.WriteLine("Deletar cliente");
//             break;

// 		case "4": 
// 			Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             // Environment.Exit(0);
// 			break;

//         default: 
//             Console.WriteLine("Opção inválida");
//             break;
// 	}
// }

// Console.WriteLine("O programa se encerrou");



//LISTA
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("MG");
// listaString.Add("MA");

// //FOR OR
// // for(int contador = 0; contador < listaString.Count; contador++) {
// // 	Console.WriteLine($"Posicao número {contador} - {listaString[contador]}");
// // }

// //FOREACH
// int contadorForeach = 0;
// foreach(string item in listaString){
// 	Console.WriteLine($"Posicao número {contadorForeach } - {item}");
// 	contadorForeach++;
// }






//INSTANCIAR PESSOAS EM CLASS
Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome: "Franco");
Pessoa p2 = new Pessoa(nome: "Nayra", sobrenome: "Biondo"); 

//INSTANCIAR CURSO EM CLASS
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();