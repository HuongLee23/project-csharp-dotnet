﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProject.DTO
{
    public class BillInfo
    {
        private int id;
        public int Id { 
            get { return id; } 
            set { id = value; }
        }

        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int foodID;
        private int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public BillInfo()
        {
            
        }

        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.Id = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
            this.Count = (int)row["count"];
        }

    }
}
