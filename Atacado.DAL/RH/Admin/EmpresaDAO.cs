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
    public class EmpresaDAO : BaseAncestralDAO<Empresa>
    {
        public override Empresa Create(Empresa obj)
        {
            int chave = EmpresaFakeDB.Empresas.Max(cat => cat.Codigo) + 1;
            obj.Codigo = chave;
            EmpresaFakeDB.Empresas.Add(obj);
            return obj;
        }

        public override Empresa Delete(int id)
        {
            Empresa del = this.Read(id);
            EmpresaFakeDB.Empresas.Remove(del);
            return del;
        }

        public override Empresa Delete(Empresa obj)
        {
            return this.Delete(obj.Codigo);
        }

        public override Empresa Read(int id)
        {
            Empresa obj = EmpresaFakeDB.Empresas.SingleOrDefault(emp => emp.Codigo == id);
            return obj;
        }

        public override List<Empresa> ReadAll()
        {
            return EmpresaFakeDB.Empresas;
        }

        public override Empresa Update(Empresa obj)
        {
            Empresa alt = this.Read(obj.Codigo);
            alt.Codigo = obj.Codigo;
            alt.NomeFantasia = obj.NomeFantasia;
            alt.RazaoSocial = obj.RazaoSocial;
            alt.Situacao = obj.Situacao;
            alt.Cnpj = obj.Cnpj;
            alt.Email = obj.Email;
            alt.Endereco = obj.Endereco;
            alt.Telefone = obj.Telefone;
            return alt;
        }
    }
}
