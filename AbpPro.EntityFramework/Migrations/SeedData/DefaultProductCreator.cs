using System.Collections.Generic;
using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using AbpPro.EntityFramework;
using AbpPro.Tasks;
using AbpPro.Products;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AbpPro.Migrations.SeedData
{
    public class DefaultProductCreator
    {
        private readonly AbpProDbContext _context;

        public static List<Product> InitalProducts { get; private set; }
        public DefaultProductCreator(AbpProDbContext context)
        {
            _context = context;
        }


         static DefaultProductCreator()
        {
            string json= File.ReadAllText("E:\\project\\git\\AbpPro_Rep\\AbpPro.Web\\App\\json\\product\\list.json");
            InitalProducts = DeserializeJsonToList<Product>(json);
        }



        public void Create()
        {
            CreateProducts();
        }

        public void CreateProducts()
        {
            foreach(var product in InitalProducts)
            {
                AddProductIfNotExists(product);
            }
        }

        private void AddProductIfNotExists(Product product)
        {
            if (_context.Products.Any(s => s.Uuid == product.Uuid))
            {
                return;
            }

            _context.Products.Add(product);
            _context.SaveChanges();
        }
        /// <summary>
        /// 解析JSON数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
        /// <returns>对象实体集合</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }
    }
}