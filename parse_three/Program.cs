using parse_three;
using System.Diagnostics;
using System.Drawing;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        //var getReqest = new GetReqest("https://2.ac-biryuzovaya-zhemchuzhina.ru/flats/all");
        //var proxy = new WebProxy("127.0.0.1:8888");
        //var cookie = new CookieContainer();

        //getReqest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8";
        //getReqest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0";
        //getReqest.Host = "2.ac-biryuzovaya-zhemchuzhina.ru";
        //getReqest.Proxy = proxy;
        //getReqest.Headers.Add("Sec-Fetch-Dest", "document");
        //getReqest.Headers.Add("Sec-Fetch-Mode", "navigate");
        //getReqest.Headers.Add("Sec-Fetch-Site", "same-origin");
        //getReqest.Headers.Add("Sec-Fetch-User", "?1");
        //getReqest.Headers.Add("Upgrade-Insecure-Requests", "1");

        //getReqest.Run(cookie);

        //string pathFile = "result.txt";
        //using (StreamWriter result = File.CreateText(pathFile))
        //{
        //}
        
        //string strIndex = "http://2.ac-biryuzovaya-zhemchuzhina.ru/flats/";
        //var startPos = getReqest.Response.IndexOf("<tbody>");
        //while (true)
        //{
        //    startPos = getReqest.Response.IndexOf(strIndex, startPos) + strIndex.Length;
        //    var endPos = getReqest.Response.IndexOf("\">", startPos);
        //    var flatId = getReqest.Response.Substring(startPos, endPos - startPos);
            
        //    startPos = endPos + 2;
        //    endPos = getReqest.Response.IndexOf("-комнатная", endPos);
        //    var rooms = getReqest.Response.Substring(startPos, endPos - startPos);
        //    if (rooms.IndexOf("Студия") != -1) rooms = "0";
            
        //    startPos = getReqest.Response.IndexOf("<td>", endPos) + 4;
        //    endPos = getReqest.Response.IndexOf("</td>", startPos);
        //    var area = getReqest.Response.Substring(startPos, endPos - startPos);

        //    startPos = getReqest.Response.IndexOf("<a href=\"/flats", endPos) + 22;
        //    endPos = getReqest.Response.IndexOf(" руб.</a>", startPos);
        //    var price = getReqest.Response.Substring(startPos, endPos - startPos);

        //    startPos = getReqest.Response.IndexOf("btn btn-xs btn-default", endPos) + 4;
        //    endPos = getReqest.Response.IndexOf("</td>", startPos);
        //    string status = "";
        //    if (rooms.IndexOf("Студия") != -1) status = "Бронь";
        //    else status = "В продаже";

        //    startPos = getReqest.Response.IndexOf("\"?floor=", endPos) + 13;
        //    endPos = getReqest.Response.IndexOf("</a></td>", startPos);
        //    var floor = getReqest.Response.Substring(startPos, endPos - startPos);
            
        //    startPos = getReqest.Response.IndexOf("ru/flats", endPos) + 15;
        //    endPos = getReqest.Response.IndexOf("</a></td>", startPos);
        //    var flat_num = getReqest.Response.Substring(startPos, endPos - startPos);
            
        //    startPos = getReqest.Response.IndexOf("<td>", endPos) + 4;
        //    startPos = getReqest.Response.IndexOf("<td>", startPos) + 4;
        //    startPos = getReqest.Response.IndexOf("<td>", startPos) + 4;
        //    endPos = getReqest.Response.IndexOf("</td>", startPos);
        //    var building = getReqest.Response.Substring(startPos, endPos - startPos);
            
        //    double sprice = double.Parse(price.Replace('.', ',')) / double.Parse(area.Replace('.', ','));
        //    sprice = Math.Round(sprice, 2);
            
        //    DateTime date = DateTime.Now.Date;
            
        //    using (StreamWriter result = File.AppendText(pathFile))
        //    {
        //        result.WriteLine($"{flatId}|{flat_num}|{building}|{floor}|{area}|{rooms}|{price}|{sprice}|{status}|{date}");
        //    }

        //    if (flatId == "4828") break;

        //    startPos = getReqest.Response.IndexOf("</tr>", startPos);
        //}


        //string[] scores = File.ReadAllLines("result.txt");
        //using (StreamWriter result = File.CreateText(pathFile))
        //{
        //}

        
        //    using (StreamWriter result = File.AppendText(pathFile))
        //    {
        //        result.WriteLine("flat_id|flat_num|building|floor|area|rooms|price|sprice|status|date");
                
        //        foreach (string str in RunQuery(scores))
        //        {
        //            result.WriteLine(str);
        //        }
        //    }   


        //static IEnumerable<string> RunQuery(IEnumerable<string> source)
        //{
        //    var scoreQuery = from line in source
        //                        let fields = line.Split('|')
        //                        orderby int.Parse(fields[2]), int.Parse(fields[3]), 
        //                        int.Parse(fields[5]), int.Parse(fields[1])
        //                        select line;

        //    return scoreQuery;
        //}
    }
}