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
    public class EstadoDAO : BaseAncestralDAO<Estado>
    {
        public override Estado Create(Estado obj)
        {
            int chave = EstadoFakeFB.Estados.Max(est => est.Codigo) + 1;
            obj.Codigo = chave;
            EstadoFakeFB.Estados.Add(obj);
            return obj;
        }

        public override Estado Delete(int id)
        {
            Estado del = this.Read(id);
            EstadoFakeFB.Estados.Remove(del);
            return del;
        }

        public override Estado Delete(Estado obj)
        {
            return this.Delete(obj.Codigo);
        }

        public override Estado Read(int id)
        {
            Estado obj = EstadoFakeFB.Estados.SingleOrDefault(est => est.Codigo == id);
            return obj;
        }

        public override List<Estado> ReadAll()
        {
            return EstadoFakeFB.Estados;
        }

        public override Estado Update(Estado obj)
        {
            Estado alt = this.Read(obj.Codigo);
            alt.Codigo = obj.Codigo;
            alt.SiglaUF = obj.SiglaUF;
            alt.Descricao = obj.Descricao;
            alt.RegiaoBrasil = obj.RegiaoBrasil;
            alt.Municipios = obj.Municipios;
            return alt;
        }
    }
}
