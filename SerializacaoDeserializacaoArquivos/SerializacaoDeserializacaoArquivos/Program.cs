using SerializacaoDeserializacaoArquivos;
using System.Text.Json;

#region Serializando usuário / criando arquivo
Usuario usuario = new Usuario("João", 30, " email@email.com ");

string json = JsonSerializer.Serialize(usuario, new JsonSerializerOptions
{
    WriteIndented = true // Formata o JSON para ser mais legível
});

string caminhoArquivo = "usuario.json";

File.WriteAllText(caminhoArquivo, json);

Console.WriteLine($"Usuário serializado e salvo em {Path.GetFullPath(caminhoArquivo)}");
#endregion

#region Deserializando usuário / lendo arquivo

string caminhoArquivo1 = $"{Path.GetFullPath("usuario.json")}";

string json1 = File.ReadAllText(caminhoArquivo1);
Usuario usuarioJson = JsonSerializer.Deserialize<Usuario>(json1)!;

Console.WriteLine($"Nome: {usuarioJson.Nome} / Idade: {usuarioJson.Idade} / Email: {usuarioJson.Email}");

#endregion

#region Serializando lista de usuários / criando arquivo
Usuario usuario1 = new Usuario("João", 20, " j@email.com ");
Usuario usuario2 = new Usuario("Gabriel", 25, " g@email.com ");
Usuario usuario3 = new Usuario("Gabriela", 19, " gla@email.com ");
Usuario usuario4 = new Usuario("Marcos", 56, " m@email.com ");
Usuario usuario5 = new Usuario("Rafael", 12, " r@email.com ");
Usuario usuario6 = new Usuario("Beto", 43, " b@email.com ");

List<Usuario> usuarios = new List<Usuario>
{
    usuario1,
    usuario2,
    usuario3,
    usuario4,
    usuario5,
    usuario6
};

string caminhoArquivo2 = "ListaUsuarios.json";

string json2 = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions
{
    WriteIndented = true
});

File.WriteAllText(caminhoArquivo2, json2);

Console.WriteLine($"Lista de usuários serializada e salva em {Path.GetFullPath(caminhoArquivo2)}");

#endregion

#region Deserializando lista de usuários / lendo arquivo

string caminhoArquivo3 = $"{Path.GetFullPath("ListaUsuarios.json")}";

string json3 = File.ReadAllText(caminhoArquivo3);
List<Usuario> usuarios3 = new List<Usuario>();
usuarios = JsonSerializer.Deserialize<List<Usuario>>(json3)!;

foreach (Usuario usuariou in usuarios3)
{
    Console.WriteLine($"Nome: {usuariou.Nome} / Idade: {usuariou.Idade} / Email: {usuariou.Email}\n");
}

#endregion

#region Lendo arquivo Json e colocando filtros 

string caminhoArquivo4 = $"{Path.GetFullPath("ListaUsuarios.json")}";

string json4 = File.ReadAllText(caminhoArquivo4);
List<Usuario> usuarios4 = new List<Usuario>();
usuarios = JsonSerializer.Deserialize<List<Usuario>>(json4)!;

int idade = 20;

List<Usuario> usuariosFiltrados = usuarios4
    .Where(u => u.Idade == idade)
    .OrderBy(u => u.Nome)
    .ToList();

foreach (Usuario usuariou in usuariosFiltrados)
{
    Console.WriteLine($"Nome: {usuariou.Nome} / Idade: {usuariou.Idade} / Email: {usuariou.Email}\n");
}

#endregion

