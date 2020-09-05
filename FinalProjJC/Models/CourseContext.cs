using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FinalProjJC.Models;
using Microsoft.Extensions.DependencyInjection;

namespace FinalProjJC.Models
{
    public class CourseContext
    {

        
        public string ConnectionString { get; set; }

        public CourseContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<AllCourse> GetAllCourses()
        {
            List<AllCourse> list = new List<AllCourse>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM schedule WHERE DataSci='1'", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AllCourse()
                        {                           
                            CourseName = reader.GetString("CourseName"),
                            CourseNum = reader.GetString("CourseNumber"),
                            PB_40 = reader.GetString("PB_40"),
                            ME_40 = reader.GetString("ME_40"),
                            CO_40 = reader.GetString("CO_40"),
                            TI_40 = reader.GetString("TI_40"),
                            EL_40 = reader.GetString("EL_40"),
                            PB_10 = reader.GetString("PB_10"),
                            ME_10 = reader.GetString("ME_10"),
                            CO_10 = reader.GetString("CO_10"),
                            TI_10 = reader.GetString("TI_10"),
                            EL_10 = reader.GetString("EL_10"),
                            PB_20 = reader.GetString("PB_20"),
                            ME_20 = reader.GetString("ME_20"),
                            CO_20 = reader.GetString("CO_20"),
                            TI_20 = reader.GetString("TI_20"),
                            EL_20 = reader.GetString("EL_20")                          

                        });
                    }
                }
            }
            return list;
        }

        public List<AllCourse> GetAllCyber()
        {
            List<AllCourse> list = new List<AllCourse>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM schedule WHERE CyberSec='1'", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AllCourse()
                        {
                            CourseName = reader.GetString("CourseName"),
                            CourseNum = reader.GetString("CourseNumber"),
                            PB_40 = reader.GetString("PB_40"),
                            ME_40 = reader.GetString("ME_40"),
                            CO_40 = reader.GetString("CO_40"),
                            TI_40 = reader.GetString("TI_40"),
                            EL_40 = reader.GetString("EL_40"),
                            PB_10 = reader.GetString("PB_10"),
                            ME_10 = reader.GetString("ME_10"),
                            CO_10 = reader.GetString("CO_10"),
                            TI_10 = reader.GetString("TI_10"),
                            EL_10 = reader.GetString("EL_10"),
                            PB_20 = reader.GetString("PB_20"),
                            ME_20 = reader.GetString("ME_20"),
                            CO_20 = reader.GetString("CO_20"),
                            TI_20 = reader.GetString("TI_20"),
                            EL_20 = reader.GetString("EL_20")
                        });
                    }
                }
            }
            return list;
        }

        public List<AllCourse> GetAllProjMgmt()
        {
            List<AllCourse> list = new List<AllCourse>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM schedule WHERE ProjMgmt='1'", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AllCourse()
                        {
                            CourseName = reader.GetString("CourseName"),
                            CourseNum = reader.GetString("CourseNumber"),
                            PB_40 = reader.GetString("PB_40"),
                            ME_40 = reader.GetString("ME_40"),
                            CO_40 = reader.GetString("CO_40"),
                            TI_40 = reader.GetString("TI_40"),
                            EL_40 = reader.GetString("EL_40"),
                            PB_10 = reader.GetString("PB_10"),
                            ME_10 = reader.GetString("ME_10"),
                            CO_10 = reader.GetString("CO_10"),
                            TI_10 = reader.GetString("TI_10"),
                            EL_10 = reader.GetString("EL_10"),
                            PB_20 = reader.GetString("PB_20"),
                            ME_20 = reader.GetString("ME_20"),
                            CO_20 = reader.GetString("CO_20"),
                            TI_20 = reader.GetString("TI_20"),
                            EL_20 = reader.GetString("EL_20")
                        });
                    }
                }
            }
            return list;
        }

        public List<AllCourse> GetAllSoftwareDev()
        {
            List<AllCourse> list = new List<AllCourse>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM schedule WHERE SoftwareDev='1'", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AllCourse()
                        {
                            CourseName = reader.GetString("CourseName"),
                            CourseNum = reader.GetString("CourseNumber"),
                            PB_40 = reader.GetString("PB_40"),
                            ME_40 = reader.GetString("ME_40"),
                            CO_40 = reader.GetString("CO_40"),
                            TI_40 = reader.GetString("TI_40"),
                            EL_40 = reader.GetString("EL_40"),
                            PB_10 = reader.GetString("PB_10"),
                            ME_10 = reader.GetString("ME_10"),
                            CO_10 = reader.GetString("CO_10"),
                            TI_10 = reader.GetString("TI_10"),
                            EL_10 = reader.GetString("EL_10"),
                            PB_20 = reader.GetString("PB_20"),
                            ME_20 = reader.GetString("ME_20"),
                            CO_20 = reader.GetString("CO_20"),
                            TI_20 = reader.GetString("TI_20"),
                            EL_20 = reader.GetString("EL_20")
                        });
                    }
                }
            }
            return list;
        }

        public List<AllCourse> GetAllNetworking()
        {
            List<AllCourse> list = new List<AllCourse>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM schedule WHERE Networking='1'", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AllCourse()
                        {
                            CourseName = reader.GetString("CourseName"),
                            CourseNum = reader.GetString("CourseNumber"),
                            PB_40 = reader.GetString("PB_40"),
                            ME_40 = reader.GetString("ME_40"),
                            CO_40 = reader.GetString("CO_40"),
                            TI_40 = reader.GetString("TI_40"),
                            EL_40 = reader.GetString("EL_40"),
                            PB_10 = reader.GetString("PB_10"),
                            ME_10 = reader.GetString("ME_10"),
                            CO_10 = reader.GetString("CO_10"),
                            TI_10 = reader.GetString("TI_10"),
                            EL_10 = reader.GetString("EL_10"),
                            PB_20 = reader.GetString("PB_20"),
                            ME_20 = reader.GetString("ME_20"),
                            CO_20 = reader.GetString("CO_20"),
                            TI_20 = reader.GetString("TI_20"),
                            EL_20 = reader.GetString("EL_20")
                        });
                    }
                }
            }
            return list;
        }
    }
    

    
}
