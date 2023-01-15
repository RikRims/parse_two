using parse_three;
using System.Diagnostics;
using System.Drawing;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        string pathFile = "result.txt";
        using (StreamWriter result = File.CreateText(pathFile))
        {
        }

        var getReqest = new GetReqest($"https://dom-rafinad.ru/ajax/get_flats_example.json?sort=price&sort_order=asc&price_from=7282410&price_to=13141155&area_from=34&area_to=79&floor_from=2&floor_to=8&action=get_flats&limit=280&offset=0&current_control=&last_control=");
        var proxy = new WebProxy("127.0.0.1:8888");
        var cookie = new CookieContainer();

        getReqest.Accept = "application/json, text/javascript, */*; q=0.01";
        getReqest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0";
        getReqest.Host = "dom-rafinad.ru";
        getReqest.Proxy = proxy;
        getReqest.Referer = "https://dom-rafinad.ru/genplan/flatlist/?sort=price&sort_order=asc&price_from=7282410&price_to=13141155&area_from=34&area_to=79&floor_from=2&floor_to=8";
        getReqest.Headers.Add("Sec-Fetch-Dest", "empty");
        getReqest.Headers.Add("Sec-Fetch-Mode", "cors");
        getReqest.Headers.Add("Sec-Fetch-Site", "same-origin");

        getReqest.Run(cookie);

        using (StreamWriter result = File.CreateText("result.json"))
        {
            result.WriteLine(getReqest.Response);
        }

        Rootobject rootobject = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(getReqest.Response);

        foreach (var flat in rootobject.flats)
        {

            double sprice = flat.price / flat.area;
            sprice = Math.Round(sprice, 2);

            string status;
            if (flat.furnish == 1) status = "Бронь";
            else status = "В продаже";

            using (StreamWriter result = File.AppendText(pathFile))
            {
                result.WriteLine($"{flat.id}|{flat.num}|{flat.bld}|{flat.floor}|{flat.area}|{flat.rooms}|{flat.price}|{sprice}|{status}|{DateTime.Now}");
            }
        }

        string[] scores = File.ReadAllLines(pathFile);
        using (StreamWriter result = File.CreateText(pathFile))
        {
        }

        using (StreamWriter result = File.AppendText(pathFile))
        {
            result.WriteLine("flat_id|flat_num|building|floor|area|rooms|price|sprice|status|date");

            foreach (string str in RunQuery(scores))
            {
                result.WriteLine(str);
            }
        }

        static IEnumerable<string> RunQuery(IEnumerable<string> source)
        {
            var scoreQuery = from line in source
                             let fields = line.Split('|')
                             orderby int.Parse(fields[2]), int.Parse(fields[3]),
                             int.Parse(fields[5]), int.Parse(fields[1])
                             select line;

            return scoreQuery;
        }
    }
}