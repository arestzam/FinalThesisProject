using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketStore.Models;

namespace MarketStore.Controllers
{

    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller

    {

        MarketStoreEntities dbStored = new MarketStoreEntities();



        // GET: StoreManager
        //This index controller action will retrieve product information 
        

        public ActionResult Index()
        {

            var products = dbStored.Products;

            return View(products.ToList());

        }



        // GET: StoreManager/Details/5

        //This Details controller action queries for the product id and returns it to the view

        public ActionResult Details(int prodid)
        {

            Product product = dbStored.Products.Find(prodid);

            return View();


        }

        // GET: StoreManager/Create
        // This controller action will create the new the entry details in dropdown menus. It handles the HTTP-GET request
        public ActionResult Create()

        {

            ViewBag.CategoryId = new SelectList(dbStored.Categories, "CategoryId", "Category Name");
            ViewBag.SupplierId = new SelectList(dbStored.Suppliers, "SupplierId", "Supplier Name");

            return View();
        }


        // It handles the HTTP-POST request that contains the submitted form values. It will read the form values and if valid it will add them into the list otherwise will 
        // display validation errors

        // POST: StoreManager/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)

            {


                dbStored.Products.Add(product);                                

                dbStored.SaveChanges();

                return RedirectToAction("Index");

            }



                ViewBag.CategoryId = new SelectList(dbStored.Categories, "CategoryId", "Category Name", product.CategoryId);
                ViewBag.SupplierId = new SelectList(dbStored.Suppliers, "SupplierId", "Supplier Name", product.SupplierId);

                return View();



         }
        
        

        // GET: StoreManager/Edit/5
        //This GET controller action will edit the already added product into the database and modify it
        
        public ActionResult Edit(int id)
        {

                Product product = dbStored.Products.Find(id);

                ViewBag.CategoryId = new SelectList(dbStored.Categories, "CategoryId", "Category Name", product.CategoryId);

                ViewBag.SupplierId = new SelectList(dbStored.Suppliers, "SupplierId", "Supplier Name", product.SupplierId);
                
            
                return View(product);
        }




        // POST: StoreManager/Edit/5
        //This POST controller action will validate the changes


        [HttpPost]
        public ActionResult Edit(Product product)
        {

            if (ModelState.IsValid)

            {

                dbStored.Entry(product).State = System.Data.Entity.EntityState.Modified;

                dbStored.SaveChanges();

                
                return RedirectToAction("Index");

            }


                ViewBag.CategoryId = new SelectList(dbStored.Categories, "CategoryId", "Category Name", product.CategoryId);
                ViewBag.SupplierId = new SelectList(dbStored.Suppliers, "SupplierId", "Supplier Name", product.SupplierId);

            return View(product);

            
        }
        
            

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int id)

        {

            Product product = dbStored.Products.Find(id);
            return View(product);
        }




        // POST: StoreManager/Delete/5
        //This will validate the delete action in three steps as follows. It will delete the product by id, save the changes and then will redirect back to index

        [HttpPost, ActionName("Delete")]
       
        
        public ActionResult DeleteToBeConfirmed(int id)
        {

            Product product = dbStored.Products.Find(id);
            dbStored.Products.Remove(product);

            dbStored.SaveChanges();

                      
                return RedirectToAction("Index");

        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


    }
 }

