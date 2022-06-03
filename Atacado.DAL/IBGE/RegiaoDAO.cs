using Atacado.DAL.Ancestral;
using Atacado.Modelo.IBGE;
using FakeDB.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.IBGE
{
    public class RegiaoDAO : BaseAncestralDAO<Regiao>
    {
        public override Regiao Create(Regiao obj)
        {
            int chave = RegiaoFakeDB.Regioes.Max(reg => reg.Codigo) + 1;
            obj.Codigo = chave;
            RegiaoFakeDB.Regioes.Add(obj);
            return obj;
        }

        public override Regiao Delete(int id)
        {
            Regiao del = this.Read(id);
            RegiaoFakeDB.Regioes.Remove(del);
            return del;
        }

        public override Regiao Delete(Regiao obj)
        {
           return this.Delete(obj.Codigo);
        }

        public override Regiao Read(int id)
        {
            Regiao obj = RegiaoFakeDB.Regioes.SingleOrDefault(reg=> reg.Codigo == id);
            return obj;
        }

        public override List<Regiao> ReadAll()
        {
            return RegiaoFakeDB.Regioes;
        }

        public override Regiao Update(Regiao obj)
        {
            Regiao alt = this.Read(obj.Codigo);
            alt.Codigo = obj.Codigo;
            alt.Descricao = obj.Descricao;
            alt.Estados = obj.Estados;
            return alt;
        }
    }
}
