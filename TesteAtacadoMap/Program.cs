using Atacado.DAL.Estoque;
using Atacado.Map.Estoque;
using Atacado.Modelo.Estoque;
using Atacado.POCO.Estoque;

namespace TesteAtacadoDAL
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o código da Categoria: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            CategoriaDAO dao = new CategoriaDAO();
            Categoria modelo = dao.Read(codigo);

            CategoriaPOCO poco = CategoriaMap.ConverterParaPoco(modelo);

            Console.WriteLine("Código {0}", poco.Codigo);
            Console.WriteLine("Descrição {0}", poco.Descricao);
            Console.WriteLine("Situação {0}", poco.Situacao);

            Console.ReadLine();
        }
    }
}