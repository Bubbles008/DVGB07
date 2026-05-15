using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Store.Models;

namespace Store.Logic
{
    public class ApiHandler
    {
        private string apiUrl = "https://hex.cse.kau.se/~jonavest/csharp-api/";

        public async Task<XDocument> GetApiDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(apiUrl);
                return XDocument.Parse(response);
            }
        }

        public void UpdateProductsFromApi(XDocument xmlData, List<Product> localProducts)
        {
            XElement? productsElement = xmlData.Root?.Element("products");

            if (productsElement == null)
            {
                throw new Exception("Products section not found in API response.");
            }

            foreach (XElement productElement in productsElement.Elements())
            {
                XElement? idElement = productElement.Element("id");
                XElement? priceElement = productElement.Element("price");
                XElement? stockElement = productElement.Element("stock");

                if (idElement == null || priceElement == null || stockElement == null)
                {
                    continue;
                }

                int id = int.Parse(idElement.Value);
                float newPrice = float.Parse(priceElement.Value);
                int newStock = int.Parse(stockElement.Value);

                Product? localProduct = localProducts.Find(p => p.Id == id);

                if (localProduct != null)
                {
                    localProduct.Price = newPrice;
                    localProduct.QuantityInStock = newStock;
                }
            }
        }
    }
}