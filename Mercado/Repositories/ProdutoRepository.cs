using Mercado.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace Mercado.Repositories
{
    public class ProdutoRepository
    {

        public void ExportarJson(Produto produto)
        {
            var json = JsonConvert.SerializeObject(produto, Newtonsoft.Json.Formatting.Indented);
            using (var streamWriter = new StreamWriter($"C:\\temp\\_produto{produto.Id}.json"))
            {
                streamWriter.WriteLine(json);
            }

        }

        public void ExportarXml(Produto produto)
        {
            var xml = new XmlSerializer(typeof(Produto));
            using (var streamWriter = new StreamWriter($"C:\\temp\\_produto{produto.Id}.xml"))
            {
                xml.Serialize(streamWriter, produto);
            }
        }
    }
}
