using Projetos_dotNet.Models;

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