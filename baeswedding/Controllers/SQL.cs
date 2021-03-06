﻿using baeswedding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;

namespace baeswedding.Models
{
    public class SQL : Controller
    {
        private SqlConnection con;

        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["connBae"].ToString();
            con = new SqlConnection(constring);
        }

        public List<GuestModel> GetGuests()
        {
            connection();
            List<GuestModel> guestlist = new List<GuestModel>();

            SqlCommand cmd = new SqlCommand("GetGuests", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                guestlist.Add(
                    new GuestModel
                    {
                        GuestID = Convert.ToInt32(dr["GuestID"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        Email = Convert.ToString(dr["Email"]),
                        Comment = Convert.ToString(dr["Comment"]),
                        Guest_1_Fname = Convert.ToString(dr["Guest_1_Fname"]),
                        Guest_1_Lname = Convert.ToString(dr["Guest_1_Lname"]),
                        Guest_2_Fname = Convert.ToString(dr["Guest_2_Fname"]),
                        Guest_2_Lname = Convert.ToString(dr["Guest_2_Lname"]),
                        Guest_3_Fname = Convert.ToString(dr["Guest_3_Fname"]),
                        Guest_3_Lname = Convert.ToString(dr["Guest_3_Lname"]),
                        Guest_4_Fname = Convert.ToString(dr["Guest_4_Fname"]),
                        Guest_4_Lname = Convert.ToString(dr["Guest_4_Lname"]),
                        Guest_5_Fname = Convert.ToString(dr["Guest_5_Fname"]),
                        Guest_5_Lname = Convert.ToString(dr["Guest_5_Lname"]),
                        Guest_6_Fname = Convert.ToString(dr["Guest_6_Fname"]),
                        Guest_6_Lname = Convert.ToString(dr["Guest_6_Lname"]),
                        Guest_7_Fname = Convert.ToString(dr["Guest_7_Fname"]),
                        Guest_7_Lname = Convert.ToString(dr["Guest_7_Lname"]),
                        Guest_8_Fname = Convert.ToString(dr["Guest_8_Fname"]),
                        Guest_8_Lname = Convert.ToString(dr["Guest_8_Lname"]),
                        Guest_9_Fname = Convert.ToString(dr["Guest_9_Fname"]),
                        Guest_9_Lname = Convert.ToString(dr["Guest_9_Lname"]),
                        Guest_10_Fname = Convert.ToString(dr["Guest_10_Fname"]),
                        Guest_10_Lname = Convert.ToString(dr["Guest_10_Lname"]),
                        Attending = Convert.ToBoolean(dr["Attending"]),
                        RSVP_Date = Convert.ToDateTime(dr["RSVP_Date"])
                    });
            }
            return guestlist;
        }

        public List<CommentModel> GetComments()
        {
            connection();
            List<CommentModel> commentList = new List<CommentModel>();

            SqlCommand cmd = new SqlCommand("GetComments", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                commentList.Add(
                    new CommentModel
                    {
                        CommentID = Convert.ToInt32(dr["CommentID"]),
                        Comment = Convert.ToString(dr["Comment"]),
                        CommentDate = Convert.ToDateTime(dr["CommentDate"])
                    });
            }
            return commentList;
        }

        public List<GuestModel> GetGuestsGoing()
        {
            connection();
            List<GuestModel> guestlist = new List<GuestModel>();

            SqlCommand cmd = new SqlCommand("GetGuests", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                guestlist.Add(
                    new GuestModel
                    {
                        GuestID = Convert.ToInt32(dr["GuestID"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        Email = Convert.ToString(dr["Email"]),
                        Comment = Convert.ToString(dr["Comment"]),
                        Guest_1_Fname = Convert.ToString(dr["Guest_1_Fname"]),
                        Guest_1_Lname = Convert.ToString(dr["Guest_1_Lname"]),
                        Guest_2_Fname = Convert.ToString(dr["Guest_2_Fname"]),
                        Guest_2_Lname = Convert.ToString(dr["Guest_2_Lname"]),
                        Guest_3_Fname = Convert.ToString(dr["Guest_3_Fname"]),
                        Guest_3_Lname = Convert.ToString(dr["Guest_3_Lname"]),
                        Guest_4_Fname = Convert.ToString(dr["Guest_4_Fname"]),
                        Guest_4_Lname = Convert.ToString(dr["Guest_4_Lname"]),
                        Guest_5_Fname = Convert.ToString(dr["Guest_5_Fname"]),
                        Guest_5_Lname = Convert.ToString(dr["Guest_5_Lname"]),
                        Guest_6_Fname = Convert.ToString(dr["Guest_6_Fname"]),
                        Guest_6_Lname = Convert.ToString(dr["Guest_6_Lname"]),
                        Guest_7_Fname = Convert.ToString(dr["Guest_7_Fname"]),
                        Guest_7_Lname = Convert.ToString(dr["Guest_7_Lname"]),
                        Guest_8_Fname = Convert.ToString(dr["Guest_8_Fname"]),
                        Guest_8_Lname = Convert.ToString(dr["Guest_8_Lname"]),
                        Guest_9_Fname = Convert.ToString(dr["Guest_9_Fname"]),
                        Guest_9_Lname = Convert.ToString(dr["Guest_9_Lname"]),
                        Guest_10_Fname = Convert.ToString(dr["Guest_10_Fname"]),
                        Guest_10_Lname = Convert.ToString(dr["Guest_10_Lname"]),
                        Attending = Convert.ToBoolean(dr["Attending"]),
                        RSVP_Date = Convert.ToDateTime(dr["RSVP_Date"])
                    });
            }
            return guestlist;
        }

        public List<GuestModel> GetGuestsNotGoing()
        {
            connection();
            List<GuestModel> guestlist = new List<GuestModel>();

            SqlCommand cmd = new SqlCommand("GetGuests", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                guestlist.Add(
                    new GuestModel
                    {
                        GuestID = Convert.ToInt32(dr["GuestID"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        Email = Convert.ToString(dr["Email"]),
                        Comment = Convert.ToString(dr["Comment"]),
                        Guest_1_Fname = Convert.ToString(dr["Guest_1_Fname"]),
                        Guest_1_Lname = Convert.ToString(dr["Guest_1_Lname"]),
                        Guest_2_Fname = Convert.ToString(dr["Guest_2_Fname"]),
                        Guest_2_Lname = Convert.ToString(dr["Guest_2_Lname"]),
                        Guest_3_Fname = Convert.ToString(dr["Guest_3_Fname"]),
                        Guest_3_Lname = Convert.ToString(dr["Guest_3_Lname"]),
                        Guest_4_Fname = Convert.ToString(dr["Guest_4_Fname"]),
                        Guest_4_Lname = Convert.ToString(dr["Guest_4_Lname"]),
                        Guest_5_Fname = Convert.ToString(dr["Guest_5_Fname"]),
                        Guest_5_Lname = Convert.ToString(dr["Guest_5_Lname"]),
                        Guest_6_Fname = Convert.ToString(dr["Guest_6_Fname"]),
                        Guest_6_Lname = Convert.ToString(dr["Guest_6_Lname"]),
                        Guest_7_Fname = Convert.ToString(dr["Guest_7_Fname"]),
                        Guest_7_Lname = Convert.ToString(dr["Guest_7_Lname"]),
                        Guest_8_Fname = Convert.ToString(dr["Guest_8_Fname"]),
                        Guest_8_Lname = Convert.ToString(dr["Guest_8_Lname"]),
                        Guest_9_Fname = Convert.ToString(dr["Guest_9_Fname"]),
                        Guest_9_Lname = Convert.ToString(dr["Guest_9_Lname"]),
                        Guest_10_Fname = Convert.ToString(dr["Guest_10_Fname"]),
                        Guest_10_Lname = Convert.ToString(dr["Guest_10_Lname"]),
                        Attending = Convert.ToBoolean(dr["Attending"]),
                        RSVP_Date = Convert.ToDateTime(dr["RSVP_Date"])
                    });
            }
            return guestlist;
        }
    }
}