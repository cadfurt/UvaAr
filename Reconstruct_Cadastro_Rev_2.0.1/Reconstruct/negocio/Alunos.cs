using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconstruct.negocio
{
    /*
     * Descrição para a classe que representa um objeto
     * como um todo
     * 
    */
    class Alunos
    {
        private int      _alunoID;
        private string   _nome;
        private string   _endereco;
        private int      _idade;

        public int AlunoID { get => _alunoID; set => _alunoID = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public Alunos()
        {

        }

        public Alunos(string nome, string endereco, int idade)
        {
            _nome = nome;
            _endereco = endereco;
            _idade = idade;
        }
    }
}
