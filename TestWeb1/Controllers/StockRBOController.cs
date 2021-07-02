using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TestWeb1.Interfaces;
using TestWeb1.Models;
using TestWeb1.Services;

namespace TestWeb1.Controllers
{
    public class StockRBOController : Controller
    {
        IDatabase DatabaseInterface;

        public StockRBOController()
        {
            this.DatabaseInterface = new DatabaseService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetData()
        {
            List<StockModel> stocks = new List<StockModel>();
            stocks = GetStockModels();
            return Json(stocks);
        }

        public List<StockModel> GetStockModels()
        {
            List<StockModel> stocks = new List<StockModel>();
            SqlConnection con = DatabaseInterface.ConnectRBO();
            con.Open();
            string str_cmd = "select * from CTL_RBO";
            SqlCommand cmd = new SqlCommand(str_cmd, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    StockModel stock = new StockModel()
                    {
                        id = dr["No.1"] != DBNull.Value ? dr["No.1"].ToString() : "",
                        description = dr["Description"] != DBNull.Value ? dr["Description"].ToString() : "",
                        price = ((dr["Price"] != DBNull.Value) && (dr["Price"].ToString() != "")) ? Convert.ToDouble(dr["Price"]) : 0,
                        stock_quantity_hq = dr["Stock Quantity"] != DBNull.Value ? Convert.ToInt32(dr["Stock Quantity"]) : 0,
                        stock_location_hq = dr["Stock Location"] != DBNull.Value ? dr["Stock Location"].ToString() : "",
                        stock_quantity_rbo = dr["Stock Quantity RBO"] != DBNull.Value ? Convert.ToInt32(dr["Stock Quantity RBO"]) : 0,
                        stock_location_rbo = dr["Stock Location RBO"] != DBNull.Value ? dr["Stock Location RBO"].ToString() : "",
                        stock_quantity_kbo = dr["Stock Quantity KBO"] != DBNull.Value ? Convert.ToInt32(dr["Stock Quantity KBO"]) : 0,
                        stock_location_kbo = dr["Stock Location KBO"] != DBNull.Value ? dr["Stock Location KBO"].ToString() : "",
                        unit = dr["Unit"] != DBNull.Value ? dr["Unit"].ToString() : "",
                    };
                    stocks.Add(stock);
                }
                dr.Close();
            }
            con.Close();
            return stocks;
        }
    }
}
