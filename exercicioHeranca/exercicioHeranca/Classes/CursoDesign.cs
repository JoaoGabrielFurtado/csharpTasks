using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class CursoDesign : ICurso
    {
        public string curso;
        public Instrutor instrutor;
        public CursoDesign(string curso, Instrutor instrutor)
        {
            this.curso = curso;
            this.instrutor = instrutor;
        }

        public void ValidarConteudo()
        {
            Console.WriteLine($"Validando conteúdo do curso de design: {curso}");
        }
        public void PublicarCurso()
        {
            Console.WriteLine($"Curso publicado com sucesso: {curso} - Instrutora: {instrutor.nome} ({instrutor.especialidade})\n");
        }

    }
}
