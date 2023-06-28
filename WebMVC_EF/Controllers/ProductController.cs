using Microsoft.AspNetCore.Mvc;
using WebMVC_EF.Models;

namespace WebMVC_EF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Danh sach cate
                ViewBag.Categories = context.Categories.ToList();

                //list product
                var products = context.Products.ToList();

                return View(products);
            }

        }

        [HttpPost]
        public IActionResult Index(int cateId)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Danh sach cate
                ViewBag.Categories = context.Categories.ToList();

                ViewBag.SelectedId = cateId;

                //list product
                var products = new List<Product>();
                if (cateId == 0)
                {
                    products = context.Products.ToList();
                }
                else
                {
                    products = context.Products.Where(p => p.CategoryId == cateId).ToList();
                }

                return View(products);
            }

        }

        public IActionResult Add()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Danh sach cate
                ViewBag.Categories = context.Categories.ToList();


                return View();

            }

        }
        [HttpPost]
        public IActionResult Add(Product p)
        {
            if (ModelState.IsValid)
            {
                using (MySaleDBContext context = new MySaleDBContext())
                {
                    context.Add(p);
                    context.SaveChanges();
                    return RedirectToAction("Index");



                    //Danh sach cate
                    //ViewBag.Categories = context.Categories.ToList();


                }
            }
            else
            {
                
                    return View(p);
                
            }

        }

        public IActionResult Delete(int id)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                Product p = context.Products.FirstOrDefault(p=>p.ProductId == id);
                context.Products.Remove(p);
                context.SaveChanges();
                
                return RedirectToAction("Index");
            }
        }

        public IActionResult Update(int id)
        {
            
            using (MySaleDBContext context = new MySaleDBContext())
            {
                ViewBag.Categories = context.Categories.ToList();
                Product p = context.Products.FirstOrDefault(p => p.ProductId == id);
                return View(p);
            }
        }
        [HttpPost]
        public IActionResult Update(Product pd)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                Product p1 = context.Products.FirstOrDefault(p => p.ProductId == pd.ProductId);
                p1.ProductName = pd.ProductName;
                p1.UnitPrice = pd.UnitPrice;
                p1.UnitsInStock = pd.UnitsInStock;
                p1.Image = pd.Image;
                p1.CategoryId = pd.CategoryId;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
