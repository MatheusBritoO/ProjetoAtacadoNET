using Atacado.DAL.Estoque;
using Atacado.DAL.IBGE;
using Atacado.DAL.RH.Admin;
using Atacado.FakeDB.RH;
using Atacado.Domain.Estoque;
using Atacado.Domain.IBGE;
using Atacado.Domain.RH;
using FakeDB.IBGE;

namespace TesteAtacadoDAL
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Informe o código da Empresa:");
            int cod = Convert.ToInt32(Console.ReadLine());
            ApresentarEmpresa(cod);
            Console.ReadLine();
        }
    
        private static void ApresentarCategoria(int id)
        {          
            CategoriaDAO dao = new CategoriaDAO();
            Imprimir(id, dao);
        }
        private static void Imprimir(int id, CategoriaDAO dao)
        {
            Categoria cat = dao.Read(id);
            Console.Write("Código: {0} - ", cat.Codigo);
            Console.Write("Nome: {0} - ", cat.Descricao);
            Console.WriteLine("Situação: {0} - ", cat.Situacao);
        }

        private static void ApresentarSubcategoria(int id)
        {
            SubcategoriaDAO sub = new SubcategoriaDAO();
            Imprimir(id,sub);
        }
        private static void Imprimir(int id, SubcategoriaDAO sub)
        {
            Subcategoria subi = sub.Read(id);
            Console.Write("Código: {0} - ", subi.Codigo);
            Console.Write("Nome: {0} - ", subi.Descricao);
            Console.WriteLine("Situação: {0} - ", subi.Situacao);
        }
        //-------------------------------------------------------------------------
        private static void ApresentarFucionario(int id)
        {
            FuncionarioDAO fun = new FuncionarioDAO();
            Imprimir(id, fun);
        }  
        private static void Imprimir(int id, FuncionarioDAO fun)
        {
            Funcionario func = fun.Read(id);
            Console.Write("Código: {0} - ", func.Codigo);
            Console.Write("Nome: {0} - ", func.Nome);
            Console.WriteLine("Situação: {0} - ", func.Situacao);
        }

        private static void ApresentarEmpresa(int id)
        {
            EmpresaDAO emp = new EmpresaDAO();
            Imprimir(id, emp);
        }
        private static void Imprimir(int id, EmpresaDAO emp)
        {
            Empresa empr = emp.Read(id);
            Console.Write("Código: {0} - ", empr.Codigo);
            Console.Write("Nome: {0} - ", empr.NomeFantasia);
            Console.WriteLine("Situação: {0} - ", empr.Situacao);
        }
 //-------------------------------------------------------------------------
        private static void ApresentarEstado(int id)
        {
            EstadoDAO est = new EstadoDAO();
            Imprimir(id, est);
        }
        private static void Imprimir(int id, EstadoDAO est)
        {
            Estado esta = est.Read(id);
            Console.Write("Código: {0} - ", esta.Codigo);
            Console.Write("Nome: {0} - ", esta.SiglaUF);
            Console.WriteLine("Situação: {0} - ", esta.Descricao);
        }

        private static void ApresentarMunicipio(int id)
        {
            MunicipioDAO mun = new MunicipioDAO();
            Imprimir(id, mun);
        }
        private static void Imprimir(int id, MunicipioDAO mun)
        {
            Municipio muni = mun.Read(id);
            Console.Write("Código: {0} - ", muni.Codigo);
            Console.Write("Nome: {0} - ", muni.SiglaUF);
            Console.WriteLine("Situação: {0} - ", muni.Cep);
        }

        private static void ApresentarRegiao(int id)
        {
            RegiaoDAO reg = new RegiaoDAO();
            Imprimir(id, reg);
        }
        private static void Imprimir(int id, RegiaoDAO reg)
        {
            Regiao regi = reg.Read(id);
            Console.Write("Código: {0} - ", regi.Codigo);
            Console.Write("Nome: {0} - ", regi.Descricao);
            Console.WriteLine("Situação: {0} - ", regi.Estados);
        }
    }
}