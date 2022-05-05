using Newtonsoft.Json;
using System.Net.Http.Headers;

public class Regiao
{
    public int id { get; set; }
    public string sigla { get; set; }
    public string nome { get; set; }
}

public class UF
{
    public int id { get; set; }
    public string sigla { get; set; }
    public string nome { get; set; }
    public Regiao regiao { get; set; }
}

public class Mesorregiao
{
    public int id { get; set; }
    public string nome { get; set; }
    public UF UF { get; set; }
}

public class Microrregiao
{
    public int id { get; set; }
    public string nome { get; set; }
    public Mesorregiao mesorregiao { get; set; }
}

public class RegiaoIntermediaria
{
    public int id { get; set; }
    public string nome { get; set; }
    public UF UF { get; set; }
}

public class RegiaoImediata
{
    public int id { get; set; }
    public string nome { get; set; }

    [JsonProperty("regiao-intermediaria")]
    public RegiaoIntermediaria RegiaoIntermediaria { get; set; }
}

public class Municipios
{
    public string id { get; set; }
    public string nome { get; set; }
    public Microrregiao microrregiao { get; set; }

    [JsonProperty("regiao-imediata")]
    public RegiaoImediata RegiaoImediata { get; set; }

    public static List<Municipios> BuscarMunicipio(string escolha)
     {


         string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/"+escolha+"/municipios";
         string json = (new System.Net.WebClient()).DownloadString(url);

         var mun = JsonConvert.DeserializeObject<List<Municipios>>(json);

         return mun;
     }
   /* public static async Task<List<Municipios>> BuscarMunicipio()
    {
        
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://servicodados.ibge.gov.br/api/v1/localidades/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromSeconds(60);


            HttpResponseMessage response = await client.GetAsync("estados/" + "SC" + "/municipios");

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Municipios>>(json);

    }*/
}




