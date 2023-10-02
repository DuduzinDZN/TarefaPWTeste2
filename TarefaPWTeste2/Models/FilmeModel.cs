using System;
using System.Collections.Generic;

namespace TarefaPWTeste2.Models
{
    public class FilmeModel
    {
        public String Nome { get; set; }
        public string Genero { get; set; }
        public DateTime Lançamento { get; set; }
        public int Nota { get; set; }

        public FilmeModel()
        {
            Nome = "Rango";
            Genero = "Animação/Comédia";
            Lançamento = new DateTime(2011, 3, 9);
            Nota = 10;
        }
        public static FilmeModel CriarFilme()
        {
            var filme = new FilmeModel();
            filme.Nome = "Jojo Rabbit";
            filme.Genero = "Comédia/Drama";
            filme.Lançamento = new DateTime(2018, 2, 6);
            filme.Nota = 8;

            return filme;

        }

        public static List<FilmeModel> CriarLista()
        {
            var lista = new List<FilmeModel>();
            lista.Add(new FilmeModel());
            lista.Add(FilmeModel.CriarFilme());

            return lista;
        }
    }
}
