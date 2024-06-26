﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProject.DTO;

namespace WinFormsProject.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { MenuDAO.instance = value; }

        }

        private MenuDAO() { }

        public List<Menu> GetListMenyByTable(int id)
        {
            List<Menu> list = new List<Menu>();
            string query = "select f.[name], bi.[count], f.price, f.price* bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f\r\nwhere bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                list.Add(menu);
            }
            return list;
        }
    }
}

