using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pr-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");


Pessoa p1 = new Pessoa("Leonardo", "Buta");
// p1.Nome = "Alexandre";
// p1.Sobrenome = "Valter";
// p1.Idade = 20;

Pessoa p2 = new Pessoa("Eduardo", "Neves Quiros");
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Queiros";
// p2.Idade = 25;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// p1.Idade = 20;
// p1.Apresentar();