
using Newtonsoft.Json;

public class RegiaoEstado
{
    public int id { get; set; }
    public string sigla { get; set; }
    public string nome { get; set; }
}

public class Estado
{
    public int id { get; set; }
    public string sigla { get; set; }
    public string nome { get; set; }
    public RegiaoEstado regiao { get; set; }

    public static List<Estado> BuscarEstados( )
    {


        string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome";
        string json = (new System.Net.WebClient()).DownloadString(url);

        var est = JsonConvert.DeserializeObject<List<Estado>>(json);

        return est;
    }
}

