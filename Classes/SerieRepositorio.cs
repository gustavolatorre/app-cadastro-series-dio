using System;
using System.Collections.Generic;
using cadastro.series.Interface;

namespace cadastro.series
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int Id, Serie objeto)
        {
            listaSerie[Id] = objeto;
        }

        public void Excluir(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return this.listaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}