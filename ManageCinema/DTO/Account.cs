﻿using System;
using System.Data;
using System.Linq;

namespace ManageCinema.DTO
{
    public class Account
    {
        public Account(string userName, string staffID, int type, string? password = null)
        {
            this.UserName = userName;
            this.Password = password;
            this.Type = type;
            this.StaffID = staffID;
        }

        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["LoaiTK"];
            this.StaffID = row["idTK"].ToString();
        }


        public int Type { get; set; }

        public string? Password { get; set; }

        public string? StaffID { get; set; }

        public string? UserName { get; set; }

    }
}
