﻿namespace UrnaEletronica.App.Entities
{
    public class Partido
    {
        public Partido(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
