using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconstruct.negocio
{
    class Reconstrucoes
    {

        /*
        * Descrição para a classe que representa um objeto
        * como um todo
        */

        private int     _idreconstrucao;
        private string  _nome;
        private string  _caminho;
        private string  _osexame;


        public int Idreconstrucao { get => _idreconstrucao; set => _idreconstrucao = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Caminho { get => _caminho; set => _caminho = value; }
        public string Osexame { get => _osexame; set => _osexame = value; }

        public Reconstrucoes()
        {

        }

        public Reconstrucoes(string nome, string caminho, string osexame)
        {
            _nome = nome;
            _caminho = caminho;
            _osexame = osexame;
        }

    }
}
