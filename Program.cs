using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Vendas1> listaVenda = JsonConvert.DeserializeObject<List<Vendas1>>(conteudoArquivo);

foreach (Vendas1 venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id}, Produto : {venda.Produto}" +
        $"Preço: {venda.Produto} " +
        $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}






// DateTime dataAtual = DateTime.Now;

// List<Vendas> listaVendas = new List<Vendas>();

// Vendas v1 = new Vendas(1, "Material de escritório", 25.00M, dataAtual);
// Vendas v2 = new Vendas(2, "Licença de Software ", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//   Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possível ler o arquivo");
// }

// (int, string, string) tupla = (1, "Leonardo", "Buta");

// Console.WriteLine(tupla.Item3);











// new ExemploExcecao().Metodo1();













//Leitrura de arquivo txt !
// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/_arquivoLeitura.txt");


//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }

// }

// catch (FileNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo . Arquivo nã oencontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//   Console.Clear();
//   Console.WriteLine($"Ocorreu uma exceção genérica. \n\n{ex.Message}");
// }













// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pr-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario:C}");


// Pessoa p1 = new Pessoa("Leonardo", "Buta");
// p1.Nome = "Alexandre";
// p1.Sobrenome = "Valter";
// p1.Idade = 20;

// Pessoa p2 = new Pessoa("Eduardo", "Neves Quiros");
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Queiros";
// p2.Idade = 25;

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// p1.Idade = 20;
// p1.Apresentar();