using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series
{
    public class SerieRepositorio : iRepositorio<Series>
    {
        public void Atualiza(int id, Series entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            throw new NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Series RetornaPorId(int id)
        {
           throw new NotImplementedException(); 
        }
    }
}