namespace Atacado.POCO.Estoque
{
    public class MunicipioPOCO
    {
           public  int Codigo { get; set; }
           public string Descricao { get; set; }
           public int CodigoUF { get; set; }
           public string SiglaUF { get; set; }
           public int CodigoMesoregiao { get; set; }
           public int CodigoMicroregiao { get; set; }
           public int CodigoIBGE6 { get; set; }
           public int CodigoIBGE7 { get; set; }
           public long CopulacaoMunicipio { get; set; }
           public string Porte { get; set; }
           public long Cep { get; set; }
    }
}
