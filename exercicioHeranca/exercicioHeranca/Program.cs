using exercicioHeranca.Classes;
using exercicioHeranca.Interfaces;


// Usando Construtores interligados para criar o Objeto
#region class CLienteVIP / class Pessoa 

ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

Console.WriteLine($"Bem-vindo, cliente VIP: {cliente1.Nome}");
Console.WriteLine($"Idade: {cliente1.Idade}");
Console.WriteLine($"Nível de Fidelidade: {cliente1.NivelFidelidade}");
Console.WriteLine($"Código VIP: {cliente1.CodigoVIP}\n");

Console.WriteLine($"Bem-vindo, cliente VIP: {cliente2.Nome}");
Console.WriteLine($"Idade: {cliente2.Idade}");
Console.WriteLine($"Nível de Fidelidade: {cliente2.NivelFidelidade}");
Console.WriteLine($"Código VIP: {cliente2.CodigoVIP}\n");

#endregion

#region class Funcionario / class FreeLancer / class Interno

Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
FreeLancer f2 = new FreeLancer("Carlos", "Designer", 3500.00m);

Console.WriteLine($"Funcionária {f1.Nome} – Cargo: {f1.Cargo} – Salário: R$ {f1.Salario}");
Console.WriteLine($"Freelancer {f2.Nome} – Cargo: {f2.Cargo} – Projeto atual: R$ {f2.ValorProjeto}");

#endregion

#region class Pessoa / class Passageiro

Passageiro p1 = new Passageiro("Lúcia", 45, 3);
Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

p1.MostrarDadosPassageiro();
p2.MostrarDadosPassageiro();

#endregion

#region class Profissao / class Analista / class Docente / class Certificado

Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matemática");
Certificado cerf1 = new Certificado(analista);
Certificado certf2 = new Certificado(docente);

cerf1.MostrarDados();
certf2.MostrarDados();

#endregion

#region class ItemDigital / class Pergaminho

Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");

pergaminhoAntigo.MostrarDetalhes();

#endregion

// Implementação de interfaces
#region Interface ISensor / 

SensorTemperatura temp = new SensorTemperatura();
SensorPresenca presenca = new SensorPresenca();

temp.Ativar();
temp.Desativar();

presenca.Ativar();
presenca.Desativar();

#endregion

// Composição com classes
#region class PlacaMae / class Processador / class PC

Processador cpu = new Processador("Intel", "i7-12700K");
PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");

PC pc = new PC(mobo, cpu);

pc.ExibirConfiguracao();

#endregion

// Trabalhando com Interface e Herança combinados
#region class PessoaPagamento / Interface IPagamento / class PagamentoCredito / class PagamentoBoleto

PagamentoCredito c1 = new PagamentoCredito("André", "andre@email.com");
PagamentoBoleto c2 = new PagamentoBoleto("Juliana", "juliana@email.com");

c1.ProcessarPag();
c2.ProcessarPag();

#endregion

// Trabalhando com Interface e Composição combinados
#region Interface IServico / class FuncionarioServico / class Manutencao / class Consultoria

FuncionarioServico tecnico = new FuncionarioServico("João", "TI");
IServico s1 = new Manutencao("Atualização de servidor", tecnico);

FuncionarioServico _analista = new FuncionarioServico("Marina", "Consultoria");
IServico s2 = new Consultoria("Planejamento estratégico", _analista);

s1.ExecutarServico();
s2.ExecutarServico();

#endregion

#region Interface ICurso / class Instrutor / class CursoProgramacao / class CursoDesign

Instrutor instrutor1 = new Instrutor("Carla", "Back-end");
ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);

Instrutor instrutor2 = new Instrutor("Felipe", "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);

curso1.ValidarConteudo();
curso1.PublicarCurso();

curso2.ValidarConteudo();
curso2.PublicarCurso();

#endregion