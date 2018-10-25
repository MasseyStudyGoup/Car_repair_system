using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Configuration;
using System.Data;

namespace TcarSystem.DAL
{
    public class SqliteHelper
    {
        //connect string
        private static readonly string
            str = ConfigurationManager.ConnectionStrings["connTcardb"].ConnectionString;

        /// <summary>
        /// Add, delete, delete and check the database
        /// </summary>
        /// <param name="sql">sql sentence</param>
        /// <param name="ps">sql sentence parameter</param>
        /// <returns>retrun the number of rows affected</returns>
        public static int ExecuteNoneQuery(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// select first row and col
        /// </summary>
        /// <param name="sql">sql sentence</param>
        /// <param name="ps">sql sentence paramenter</param>
        /// <returns>retrun first row and col object</returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql,con))
                {
                    con.Open();
                    if (ps!=null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// for data selection
        /// </summary>
        /// <param name="sql">sql sentence</param>
        /// <param name="ps">sql sentence paramenter</param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] ps)
        {
            SQLiteConnection con = new SQLiteConnection(str);
            using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
            {
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    con.Close();
                    con.Dispose();
                    throw ex;
                }
                 
            }
        }

        /// <summary>
        /// table query
        /// </summary>
        /// <param name="sql">sql sentence</param>
        /// <param name="ps">sql sentence paramenter</param>
        /// <returns>table</returns>
        public static DataTable ExecuteTable(string sql, params SQLiteParameter[] ps)
        {
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, str))
            {
                if (ps != null)
                {
                    sda.SelectCommand.Parameters.AddRange(ps);
                }
                sda.Fill(dt);
            }
            return dt;
        }
    }
}
