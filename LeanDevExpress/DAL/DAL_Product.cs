using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LeanDevExpress.DAL
{
    class DAL_Product
    {
        
        public DAL_Product()
        {
            
        }

        public DataTable getProduct(DTO.DTO_Product product)
        {
           
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from c in db.tblProducts where c.idProduct == product.idProduct select c;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("price", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));

                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idProduct"] = element.idProduct;
                    row["nameProduct"] = element.nameProduct;
                    row["price"] = element.price;
                    row["amount"] = element.amount;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }




        public DataTable getAllProduct()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from c in db.tblProducts  select c;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("price", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));

                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idProduct"] = element.idProduct;
                    row["nameProduct"] = element.nameProduct;
                    row["price"] = element.price;
                    row["amount"] = element.amount;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
           
        }

        public bool insertProduct(DTO.DTO_Product product)
        {
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                tblProduct newProduct = new tblProduct();
                newProduct.idProduct = product.idProduct;
                newProduct.nameProduct = product.nameProduct;
                newProduct.price = product.price;
                newProduct.amount = product.amount;
                db.tblProducts.InsertOnSubmit(newProduct);
                db.SubmitChanges();
                return true;
            }
           
           
        }





        public bool updateProduct(DTO.DTO_Product product)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var update = db.tblProducts.Where(p => p.idProduct.Equals(product.idProduct)).SingleOrDefault();
                update.nameProduct = product.nameProduct;
                update.price = product.price;
                update.amount = product.amount;
                db.SubmitChanges();
                return true;
            }

        }
        public bool deleteProduct(DTO.DTO_Product product)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var delete = db.tblProducts.Where(p => p.idProduct.Equals(product.idProduct)).SingleOrDefault();

                db.tblProducts.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }

        }
    }
}
