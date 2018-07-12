﻿using baeswedding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace baeswedding.Controllers
{
    public class AveryAdminController : Controller
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["connBae"].ToString();
            con = new SqlConnection(constring);
        }

        // GET: AveryAdmin
        public ActionResult Guests()
        {
            SQL sql = new SQL();
            ModelState.Clear();
            return View(sql.GetGuests());
        }

        // GET: AveryAdmin
        public ActionResult Comments()
        {
            SQL sql = new SQL();
            ModelState.Clear();
            return View(sql.GetComments());
        }

    }
}