using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO {
    public class Produto {

        #region atributos
        string _descricao;
        double _precoCusto, _margemLucro;

        #endregion

        #region construtores
        public Produto(string desc, double precoCusto, double margemLucro) {
            if(margemLucro < 10 || margemLucro > 50)
            {
                _margemLucro = 10;
            }
            if(precoCusto < 0)
            {
                precoCusto = 0.1;
            }
            if(desc.Length == 0)
            {
                desc = "produto sem descrição";
            }

            _descricao = desc;
            _precoCusto = precoCusto;
            _margemLucro = margemLucro;
        }
        #endregion

        #region métodos de negócio
        public double ValorVenda() {
            //TODO: calcular valor de venda de acordo com a regra do produto
            return _precoCusto * (1 + _margemLucro / 100);
        }

        public string NotaDeVenda() {
            //TODO: criar nota de venda formatada de acordo com a regra do produto
            string nota = "NOTA DE VENDA";
            nota += "\n####################";
            nota += $"\nDescrição: {_descricao}";
            nota += $"\nPreço: {ValorVenda():C2}";
            nota += "\n####################";
            return nota ;
        }
        #endregion
    }
}
