//Namespace caminho para encontrar a classe
using C_.Models;






// //Trabalhando com listas
// List<string> listaString = new List<string>();
// listaString.Add("SP");
// listaString.Add("RJ");
// listaString.Add("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// Console.WriteLine("Percorrendo a lista com o FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posicao nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForEach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posicao nº {contadorForEach} - {item}");
//     contadorForEach++;
// }


//Trabalhando com Array
// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[2] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Redimencionando array
// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posicao nº {contador} - {arrayInteiros[contador]}");
// }

// int contadorForEach = 0;
// Console.WriteLine("Percorrendo o array com o FOR");
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posicao nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }


//Criando um menu interativo
// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("1- Cadastrar Cliente");
//     Console.WriteLine("2- Buscar Cliente");
//     Console.WriteLine("3- Apagar Cliente");
//     Console.WriteLine("4- Encerrar");

//     opcao = Console.ReadLine();


//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro do cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca do cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0); outra forma de encerrar o programa
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("Programa encerrado");



// //Utilizando Do While
// int soma = 0, numero = 0;

// do{
//     Console.WriteLine("Digite o numero zero (0) para parar:");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");



// //Utilizando o While
// int valor = 10;
// int contador = 1;

// while (contador <= valor)
// {
//     Console.WriteLine($"{contador + 1}° Execução: {contador} x {valor} = {contador * valor}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }



//Utilizando o laço de repetição FOR
// int valor = 10;

// for (int contador = 0; contador <= valor; contador++ )
// {
// Console.WriteLine($"{contador} X {valor} = {contador * valor} ");
// }


//Usando Incremento e decremento
// int incrementoNumero = 10;
// incrementoNumero++;
// Console.WriteLine(incrementoNumero);

// int decrementoNumero = 10;
// Console.WriteLine($"Decremento o numero: {decrementoNumero}");
// decrementoNumero--;
// Console.WriteLine($"Decremento: {decrementoNumero}");


//Recebendo um valor de entrada via cmd
// Console.WriteLine("Digite uma linha");
// string letra = Console.ReadLine();


//Estrutura condicional IF
// int quantidadeEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em estoque " + quantidadeEstoque);
// Console.WriteLine("Quantidade de compra " + quantidadeCompra);
// Console.WriteLine("É possivel realizar compra? " + possivelVenda);

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");

// }
// else
// {
//     Console.WriteLine("Não tem estoque suficiente");

// }



// //Declaração e formatação de variavel do tipo data
// DateTime dataAtual = DateTime.Now.AddDays(2);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));



// //Cast - casting conversão de de dados
// int a =  Convert.ToInt32("5");
// int c = int.Parse("5");
// Console.WriteLine(a + " " + c);

// string s = "15-";
// int b = 0;
// //Tratamento de erro
// int.TryParse(s, out b);
// Console.WriteLine(b);



//Declrando e instanciando a classe Calculadora
// Calculadora calc =  new Calculadora();
//chamando metodos do objeto
// calc.Somar(10,10);
// calc.Subtrair(10,2);
// calc.Dividir(10,5);
// calc.Multiplicar(2,20);
// calc.Potencia(2,2);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(20);


//Declrando e instanciando a classe Pessoa
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Diogo";
// pessoa1.Idade = 33;
// pessoa1.Apresentar();


//Declarações de variáveis e seus tipos.
// string apresentacao = "Olá, seja bem vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade " + quantidade);
// Console.WriteLine("Valor da variavel altua " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco " + preco);
// Console.WriteLine("Valor da variavel condicao " + condicao);


//Classe para mensagem
//Console.WriteLine("Hello, World!");
