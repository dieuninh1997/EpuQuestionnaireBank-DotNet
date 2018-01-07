﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entity
{
    public class Teacher
    {
        private string id;
        private string name;
        private string username;
        private string password;
        private string avatar;
        public Teacher(string id, string name, string username, string password, string avatar)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Avatar = avatar;
        }

        public Teacher()
        {

        }
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public string Avatar
        {
            get
            {
                return avatar;
            }

            set
            {
                avatar = value;
            }
        }

        public void TeacherIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            Name = dr["name"] is DBNull ? string.Empty : dr["name"].ToString();
            Username = dr["username"] is DBNull ? string.Empty : dr["username"].ToString();
            Password = dr["password"] is DBNull ? " " : dr["password"].ToString();
            //avatar
            Avatar = dr["avatar"] is DBNull ? " " : dr["avatar"].ToString();
        }
    }
}
