using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;


namespace BuzonSunat
{
    class Program
    {
        // Test with Xataca 
        //static void Main(string[] args) {
        //    var url = "https://www.xataka.com/";
        //    HtmlWeb web = new HtmlWeb();
        //    HtmlDocument html = web.Load(url);

        //    var nodes = html.DocumentNode.CssSelect("[class='poster-title']").Select(x => x.InnerText);

        //    nodes.ToList().ForEach(e =>
        //    {
        //        Console.WriteLine(e);
        //    });
        //}

        // test sunat --> response tramites
        //static void Main(string[] args)
        //{
        //    var url = "https://www.sunat.gob.pe/sol.html";
        //    HtmlWeb web = new HtmlWeb();
        //    HtmlDocument html = web.Load(url);

        //    var nodes = html.DocumentNode.CssSelect("[class='w-full ml-4 uppercase lg:text-xl lg:ml-6 lg:h-10']").Select(x => x.InnerText);

        //    nodes.ToList().ForEach(e =>
        //    {
        //        Console.WriteLine(e);
        //    });
        //}

        static void Main1(string[] args)
        {
            var url = "https://e-menu.sunat.gob.pe/cl-ti-itmenu/MenuInternet.htm?pestana=*&agrupacion=*";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument html = web.Load(url);

            var nodes = html.DocumentNode.CssSelect("[class='list-group no-border-radius']").Select(x => x.InnerText);

            nodes.ToList().ForEach(e =>
            {
                Console.WriteLine(e);
            });
        }
    }
}
