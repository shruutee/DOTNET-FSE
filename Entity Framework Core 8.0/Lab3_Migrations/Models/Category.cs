using System.Collections.Generic;

namespace Lab3_Migrations.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public List<Product> Products { get; set; } = new();
    }
}