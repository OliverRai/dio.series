using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series
{
    public class SerieRepositorio : iRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int id, Series objetoEntidade)
        {
            listaSeries[id] = objetoEntidade;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Exclui();
        }

        public void Insere(Series objetoEntidade)
        {
            listaSeries.Add(objetoEntidade);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
           return listaSeries[id]; 
        }
    }
}