using ASSIGNMENT3PT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASSIGNMENT3PT2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                // Danh sach cate
                ViewBag.pCode = context.Products.Select(p => p.ProductCode).ToList();

                // List product
                var products = context.Products.ToList();

                return View(products);
            }
        }

        [HttpPost]
        public IActionResult Index(string productCode, string action, string newName, string oldPrice, string newPrice, string newImage, string newU)
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var products = context.Products.Where(p => p.ProductCode == productCode).ToList();
                // Danh sach cate
                ViewBag.pCode = context.Products.Select(p => p.ProductCode).ToList();

                ViewBag.SelectedCode = productCode;

                var product = context.Products.FirstOrDefault(p => p.ProductCode == productCode);

                if (product != null)
                {
                    ViewBag.SelectedProduct = product;

                    if (action == "update")
                    {
                        product.ProductName = newName;
                        if (float.TryParse(newPrice, out float parsedPrice))
                        {
                            product.Price = parsedPrice;
                        }
                        product.Image = newImage;
                        product.Unit = newU;

                        context.SaveChanges();
                    }

                    

                }

                if (action == "filName")
                {
                    if (newName != null || !newName.Equals(""))
                    {
                        products = context.Products.ToList();
                        products = products.Where(p => p.ProductName.Contains(newName)).ToList();
                    if (products == null || products.Count ==0)
                    {
                        products = context.Products.ToList();
                    }
                    }
                }else if(action == "filPrice")
                {
                    if (float.TryParse(newPrice, out float parsedNewPrice) && float.TryParse(oldPrice, out float parsedOldPrice))
                    {
                        products = context.Products.ToList();
                        products = products.Where(p => p.Price >= parsedOldPrice && p.Price <= parsedNewPrice).ToList();
                    }
                    else
                    {
                        products = context.Products.ToList();
                    }
                }else if (action == "filImg")
                {
                    if (newImage != null || !newImage.Equals(""))
                    {
                        products = context.Products.ToList();
                        products = products.Where(p => p.Image.Contains(newImage)).ToList();
                        if (products == null || products.Count == 0)
                        {
                            products = context.Products.ToList();
                        }
                    }
                }
                
                return View(products);
            }
        }

    }
}
