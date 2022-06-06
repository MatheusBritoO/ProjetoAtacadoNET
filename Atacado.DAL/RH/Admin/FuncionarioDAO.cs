using Atacado.DAL.Ancestral;
using Atacado.FakeDB.RH;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.RH.Admin
{
    public class FuncionarioDAO : BaseAncestralDAO<Funcionario>
    {
        public override Funcionario Create(Funcionario obj)
        {
            int chave = FuncionarioFakeDB.Funcionarios.Max(cat => cat.Codigo) + 1;
            obj.Codigo = chave;
            FuncionarioFakeDB.Funcionarios.Add(obj);
            return obj;
        }

        public override Funcionario Delete(int id)
        {
            Funcionario del = this.Read(id);
            FuncionarioFakeDB.Funcionarios.Remove(del);
            return del;
        }

        public override Funcionario Delete(Funcionario obj)
        {
            return this.Delete(obj.Codigo);
        }

        public override Funcionario Read(int id)
        {
            Funcionario obj = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == id);
            return obj;
        }

        public override List<Funcionario> ReadAll()
        {
            return FuncionarioFakeDB.Funcionarios;
        }

        public override Funcionario Update(Funcionario obj)
        {
            Funcionario alt = this.Read(obj.Codigo);
            alt.Codigo = obj.Codigo;
            alt.Nome = obj.Nome;
            alt.SobreNome = obj.SobreNome;
            alt.Situacao = obj.Situacao;
            alt.Rg = obj.Rg;
            alt.Cpf = obj.Cpf;            
            alt.DtNascimento = obj.DtNascimento;
            alt.Email = obj.Email;
            alt.Endereco = obj.Endereco;           
            alt.Altura = obj.Altura;
            alt.Peso = obj.Peso;
            alt.Idade = obj.Idade;
            alt.Nacionalidade = obj.Nacionalidade;
            alt.Naturalidade = obj.Naturalidade;
            alt.Telefone = obj.Telefone;
            return alt;
        }
    }
}
