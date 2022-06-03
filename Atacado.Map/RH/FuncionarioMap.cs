using Atacado.Modelo.Estoque;
using Atacado.Modelo.RH;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class FuncionarioMap
    {
        public static FuncionarioPOCO ConverterParaPoco(Funcionario modelo)
        {
            FuncionarioPOCO poco = new  FuncionarioPOCO();
            poco.Codigo = modelo.Codigo;
            poco.Nome = modelo.Nome;
            poco. = modelo.Situacao;
            return poco;
        }

        public static Funcionario ConverterParaModelo(FuncionarioPOCO poco)
        {
            return new Funcionario(poco.Codigo, poco.Descricao, poco.Situacao);
        }
    }
}
