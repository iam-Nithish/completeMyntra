using Nyntra.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Nyntra.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
       
        // Details action method to fetch and display product details
        //display
        public ActionResult ProductList()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyntraEntities"].ConnectionString))
            {
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        ProductPrice = reader["ProductPrice"] as decimal?,
                        ProductDescription = reader["ProductDescription"].ToString(),
                        ProductImage = reader["ProductImage"].ToString(),
                        Category = reader["Category"].ToString(),
                        Status = reader["Status"].ToString(),
                        Color = reader["Color"].ToString(),
                        Brand = reader["Brand"].ToString()
                    };
                    products.Add(product);
                }
            }

            return View(products);
        }

        //create 
        ///Create
        public ActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProducts(Product product, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string path = Path.Combine(Server.MapPath("~/Images/"), Path.GetFileName(file.FileName));
                file.SaveAs(path);
                product.ProductImage = "~/Images/" + file.FileName;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyntraEntities"].ConnectionString))
            {
                string query = "INSERT INTO Products (ProductName, ProductPrice, ProductDescription, ProductImage, Category, Status, Color, Brand) VALUES (@Name, @Price, @Desc, @Image, @Category, @Status, @Color, @Brand)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", product.ProductName);
                cmd.Parameters.AddWithValue("@Price", product.ProductPrice);
                cmd.Parameters.AddWithValue("@Desc", product.ProductDescription);
                cmd.Parameters.AddWithValue("@Image", product.ProductImage);
                cmd.Parameters.AddWithValue("@Category", product.Category); // New field
                cmd.Parameters.AddWithValue("@Status", product.Status);     // New field
                cmd.Parameters.AddWithValue("@Color", product.Color);       // New field
                cmd.Parameters.AddWithValue("@Brand", product.Brand);       // New field

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return RedirectToAction("AddProducts");
        }

        // GET: Admin/Edit/5
        [HttpGet]
        public ActionResult EditProducts(int id)
        {
            Product product = null;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyntraEntities"].ConnectionString))
            {
                string query = "SELECT * FROM Products WHERE ProductId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        ProductPrice = reader["ProductPrice"] != DBNull.Value ? Convert.ToDecimal(reader["ProductPrice"]) : (decimal?)null,
                        ProductDescription = reader["ProductDescription"].ToString(),
                        ProductImage = reader["ProductImage"].ToString(),
                        Category = reader["Category"].ToString(),  // Include Category if needed
                        Status = reader["Status"].ToString(),      // Include Status if needed
                        Color = reader["Color"].ToString(),        // Include Color if needed
                        Brand = reader["Brand"].ToString()         // Include Brand if needed
                    };
                }
                conn.Close();
            }

            return View(product);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult EditProducts(Product product, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string path = Path.Combine(Server.MapPath("/Images/"), Path.GetFileName(file.FileName));
                file.SaveAs(path);
                product.ProductImage = "~/Images/" + file.FileName;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyntraEntities"].ConnectionString))
            {
                string query = "UPDATE Products SET ProductName = @Name, ProductPrice = @Price, ProductDescription = @Desc, ProductImage = @Image WHERE ProductID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", product.ProductName);
                cmd.Parameters.AddWithValue("@Price", product.ProductPrice);
                cmd.Parameters.AddWithValue("@Desc", product.ProductDescription);
                cmd.Parameters.AddWithValue("@Image", product.ProductImage);
                cmd.Parameters.AddWithValue("@Id", product.ProductID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return RedirectToAction("Productlist"); // Redirect to the Index action after editing
        }

        public ActionResult MyProfile()
        {
            return View();
        }
    }
}