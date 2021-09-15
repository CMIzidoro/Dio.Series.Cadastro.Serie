using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series

{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}