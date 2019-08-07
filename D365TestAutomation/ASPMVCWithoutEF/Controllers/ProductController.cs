using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using ASPMVCWithoutEF.Models;

namespace ASPMVCWithoutEF.Controllers
{
    public class ProductController : Controller
    {
        string connectionString = @"Data Source = HP840G3-2158; Initial Catalog = MvcCrudDB; Integrated Security = True";
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dtTableProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from product", sqlCon);
                adapter.Fill(dtTableProduct);
            }
            return View(dtTableProduct);
        }

       [HttpGet]
        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "insert into product values(@ProductName,@Price,@Count)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                cmd.Parameters.AddWithValue("@Price", productModel.Price);
                cmd.Parameters.AddWithValue("@Count", productModel.Count);
                cmd.ExecuteNonQuery();
            }
            
            return RedirectToAction("Index");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
