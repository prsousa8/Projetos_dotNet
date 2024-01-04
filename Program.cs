using Projetos_dotNet.Models;
using System.Globalization;
using Newtonsoft.Json;

//DESERIALIZAÇÃO

string conteudoArquivo = File.ReadAllText("Arquivos/vendas3.json");

List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (var item in listaVendas)
{
    Console.WriteLine($"Id: {item.Id}, Produto: {item.Produto}, Preço: {item.Preco}, Data: {item.DataVenda}");
}






//SERIALIZAÇÃO

// DateTime data = DateTime.Now;

// Vendas venda1 = new Vendas(123,"Produto de Construção",78.00M,data);
// Vendas venda2 = new Vendas(456,"Software",7800.00M,data);

// List<Vendas> listVendas = new List<Vendas>();
// listVendas.Add(venda1);
// listVendas.Add(venda2);

// string serializado_1 = JsonConvert.SerializeObject(venda1);
// string serializado_2 = JsonConvert.SerializeObject(venda2, Formatting.Indented);
// string serializado_3 = JsonConvert.SerializeObject(listVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas1.json",serializado_1);
// File.WriteAllText("Arquivos/vendas2.json",serializado_2);
// File.WriteAllText("Arquivos/vendas3.json",serializado_3);

// Console.WriteLine(serializado_1);
// Console.WriteLine(serializado_2);



//IF TERNÁRIO
// int num = 15;
// bool EhPar = num % 2 == 0;
// Console.WriteLine($"O numero {num} é "+(EhPar?"Par":"Ímpar"));



//DESCONSTRUTOR
// Pessoa p1 = new Pessoa("Paulo","Ricardo",15);
// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");




//Metodo que retorna uma tupla
// LeituraArquivo arquivo = new LeituraArquivo();
// //NOTA: Usa-se '_' para descartar uma variavel Ex.: var (sucesso,linhas,_)
// var (sucesso,linhas,quantidade) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

// if(sucesso){
//     foreach (string item in linhas)
//     {
//         Console.WriteLine(item);
//     }
// }else{
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }





//TUPLA

// (int,string,string,decimal) tupla = (1,"Paulo","Santos",1.74M); //Forma 1 
// (int id,string nome,string sobrenome,decimal altura) tupla = (1,"Paulo","Santos",1.74M);
// ValueTuple<int,string,string,decimal> outroExemplo = (1,"Paulo","Santos",1.74M); //Forma 2
// var outroExemploCreate = Tuple.Create(1,"Paulo","Santos",1.74M); //Forma 3

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");





//DICIONÁRIO

// Dictionary<string,string> estados = new Dictionary<string, string>();   //<chave,valor>

// estados.Add("SP","São Paulo");
// estados.Add("MG","Minas Gerais");
// estados.Add("BA","Bahia");
// estados.Add("CE","Ceará");
// estados.Add("AM","Amazonas");

// foreach (var item in estados)
// {
//     Console.WriteLine($"{item.Key} --> {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor Alterado";
// Console.WriteLine("-----------------");

// foreach (var item in estados)
// {
//     Console.WriteLine($"{item.Key} --> {item.Value}");
// }

// string chave = "SP";
// Console.WriteLine($"Verificar se a chave {chave} já está na pilha");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine("Chave já existe.");
// }else{
//     Console.WriteLine("Chave não existe na pilha.");
// }



//PILHA
// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);
// pilha.Push(5);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {pilha.Pop()} do topo");

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



//PILHA
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }



//new ExemploExcecao().Metodo1();

// try{
//     string[] Linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

//     foreach (string linha in Linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
// }finally{
//     Console.WriteLine("Você chegou até aqui.");
// }





//FORMAS DE REPRESENTAR DATA E HORA
// DateTime data = DateTime.Now;
// Console.Write(data);
// Console.Write("\n"+data.ToString("HH:mm"));
// Console.Write("\n"+data.ToShortDateString());
// Console.Write("\n"+data.ToShortTimeString());

// DateTime newData = DateTime.Parse("17/02/2024 14:23");
// Console.WriteLine("\n"+newData);

//REPRESENTAÇÃO
// int x = 344555;
// Console.WriteLine(x.ToString("##-##-##"));


//PORCENTAGEM

// double x = .2334;
// Console.WriteLine(x.ToString("P"));



//VALORES MONETARIOS

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //opcional

// decimal ValorMonetario = 1234.43M;
// Console.WriteLine($"{ValorMonetario:C}"); //Opção 1
// Console.WriteLine(ValorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));




// DEFINIR CASAS DECIMAIS
// double x = 2.0/3;
// Console.WriteLine(Math.Round(x,2));

// Curso engenharia = new Curso();
// engenharia.Nome = "engenharia";
// List<Pessoa> Estudantes = new List<Pessoa>();
// engenharia.Alunos = Estudantes;

// Pessoa p1 = new Pessoa("Paulo","Santos",5);
// Pessoa p2 = new Pessoa("Pedro","Silva",15);

// engenharia.AdicionarAluno(p1);
// engenharia.AdicionarAluno(p2);

// engenharia.ListarAlunos();


//LISTAS
// List<string> lista = new List<string>();
// lista.Add("Paulo");
// lista.Add("Ricardo");
// lista.Add("Santos");
// lista.Add("Sousa");

// for(int i = 0;i<lista.Count;i++){
//     Console.WriteLine(lista[i]);
// }

// foreach (string nome in lista)
// {
//     Console.WriteLine(nome);
// }



//Copiar conteudo de um array para outro
// int[] array = {1,2};
// int[] newArray = new int[array.Length];
// Array.Copy(array,newArray,array.Length);
// foreach(int aux in newArray){
//     Console.WriteLine(aux);
// }




// int[] array = new int[2];
// Array.Resize(ref array, array.Length*2); //Redimensionando tamanho do array
// array[0]=1;
// array[1]=2;
// array[2]=3;
// array[3]=4;

// foreach (int m in array)
// {
//     Console.WriteLine(m);
// }






//ARRAYS
// int[] y = new int[]{1,3,5};
// int[] x = {1,2,3};


// //Percorrendo array com FOR
// for(int i = 0;i<x.Length;i++){
//     Console.WriteLine(x[i]);
// }

// //Percorrendo array com FOREACH
// foreach (int j in y){
//     Console.WriteLine(j);
// }




// Calculadora calc = new Calculadora();
// calc.Soma(2,3);
// calc.Multiplicar(2,3);
// calc.Dividir(2,3);
// calc.Potencia(2,3);
// calc.Seno(90);
// calc.Cosseno(0);
// calc.Tangente(45);
// calc.RaizQuadrada(4);

// Pessoa p = new Pessoa();
// p.nome = "Paulo";
// p.idade = 13;
// p.Apresentar();

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// //Conversão de String to Int
// int num = Convert.ToInt32("3"); // null --> 0
// num = int.Parse("5");

// //Conversão qualquer tipo para String
// string n = num.ToString();

// //Captura do limite maximo do tipo int
// int numMax = int.MaxValue;
// Console.WriteLine(numMax);

// //Tenta converter para int. Se não funciona, "gera" a saida b
// string a = "14-";
// int c = 9;
// int.TryParse(a, out c); // ou Int32.TryParse(a,out int b)
// Console.WriteLine($"Hoje é {c}");

// //Switch
// string letra ="c";
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//          Console.WriteLine("É uma vogal");
//          break;
//     default:
//          Console.WriteLine("Não é uma vogal");
//          break;
// }