using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LeanDevExpress.BUS
{
    class BUS_Product
    {
        DAL.DAL_Product dalProduct;
        public BUS_Product()
        {
            dalProduct = new DAL.DAL_Product();
        }

        public DataTable getProduct(DTO.DTO_Product Product)
        {
            return dalProduct.getProduct(Product);
        }
        public DataTable getAllProduct()
        {
            return dalProduct.getAllProduct();
        }
        public bool insertProduct(DTO.DTO_Product Product)
        {
            return dalProduct.insertProduct(Product);
        }
        public bool updateProduct(DTO.DTO_Product Product)
        {
            return dalProduct.updateProduct(Product);
        }
        public bool deleteProduct(DTO.DTO_Product Product)
        {
            return dalProduct.deleteProduct(Product);
        }

    }
}
