﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProject.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private int idCategory;
        private float price;

        public int Id { get; set; }

        public string Name { get; set; }
        public int IdCategory { get; set; }

        public float Price { get; set; }


        public Food(int id, string name, int idCategory, float price)
        {
            this.Id = id;
            this.Name = name;
            this.IdCategory = idCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
         }
    }
}
