using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class CursoProgramacao : ICurso
    {
        public string curso;
        public Instrutor instrutor;
        public CursoProgramacao(string curso, Instrutor instrutor)
        {
            this.curso = curso;
            this.instrutor = instrutor;
        }

        public void ValidarConteudo()
        {
            Console.WriteLine($"Validando conteúdo do curso de programação: {curso}");
        }
        public void PublicarCurso()
        {
            Console.WriteLine($"Curso publicado com sucesso: {curso} - Instrutora: {instrutor.nome} ({instrutor.especialidade})\n");
        }

    }
}
