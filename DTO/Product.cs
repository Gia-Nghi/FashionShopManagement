using System;
using System.Data;

namespace DTO
{
    public class Product
    {
        public string MaSP { get; set; }
        public string Name { get; set; }          // TenSP
        public decimal Price { get; set; }        // DonGia
        public string Size { get; set; }           // Size

        public Product(DataRow row)
        {
            this.MaSP = row["MaSP"].ToString();
            this.Name = row["TenSP"].ToString();                // TenSP
            this.Price = Convert.ToDecimal(row["DonGia"]);      // DonGia
            this.Size = row["Size"].ToString();                  // Size
        }
    }
}
