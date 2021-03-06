using Atacado.Domain.Estoque;
using Atacado.Domain.RH;
using Atacado.POCO.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.RH
{
    public static class FuncionarioMap
    {
        public static FuncionarioPOCO ConverterParaPoco(Funcionario modelo)
        {
            FuncionarioPOCO poco = new  FuncionarioPOCO();
            poco.Codigo = modelo.Codigo;
            poco.Nome = modelo.Nome;
            poco.SobreNome = modelo.SobreNome;
            poco.Sexo = modelo.Sexo;
            poco.Rg = modelo.Rg;
            poco.Cpf = modelo.Cpf;
            poco.Email = modelo.Email;
            poco.Endereco = modelo.Endereco;
            poco.DtNascimento = modelo.DtNascimento;
            poco.Idade = modelo.Idade;
            poco.Telefone = modelo.Telefone;
            poco.Altura = modelo.Altura;
            poco.Peso = modelo.Peso;
            poco.Nacionalidade = modelo.Nacionalidade;
            poco.Naturalidade = modelo.Naturalidade;           
            return poco;
        }

        public static Funcionario ConverterParaDomain(FuncionarioPOCO poco)
        {
            return new Funcionario(
                poco.Codigo,
                poco.Telefone,
                poco.Email,
                poco.Endereco,
                poco.Nome,
                poco.SobreNome,
                poco.Idade,
                poco.Altura,
                poco.Peso,
                poco.DtNascimento,
                poco.Naturalidade,
                poco.Nacionalidade,
                poco.Sexo,
                poco.Cpf,
                poco.Rg
                );
        }
    }
}
