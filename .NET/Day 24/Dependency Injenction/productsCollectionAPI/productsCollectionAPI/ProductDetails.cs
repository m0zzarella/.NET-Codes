namespace productsCollectionAPI
{
    public class ProductDetails
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        public string pCategory { get; set; }
        #endregion

        #region Data

        static List<ProductDetails> productsList = new List<ProductDetails>()
        {

            new ProductDetails { pId = 101, pName = "Pepsi", pCategory = "Cold-Drink", pIsInStock = true, pPrice = 50 },
            new ProductDetails { pId = 102, pName = "Maggie", pCategory = "Junk-Food", pIsInStock = true, pPrice = 250 },
            new ProductDetails { pId = 103, pName = "Appy", pCategory = "Cold-Drink", pIsInStock = false, pPrice = 150 },
            new ProductDetails { pId = 104, pName = "Lays", pCategory = "Junk-Food", pIsInStock = true, pPrice = 90 },
            new ProductDetails { pId = 105, pName = "Maaza", pCategory = "Cold-Drink", pIsInStock = true, pPrice = 190 },
            new ProductDetails { pId = 106, pName = "Good Day", pCategory = "Buiscuits", pIsInStock = true, pPrice = 240 },
            new ProductDetails { pId = 107, pName = "Bourborne", pCategory = "Buiscuits", pIsInStock = true, pPrice = 23 },
            new ProductDetails { pId = 108, pName = "Pringles", pCategory = "Junk-Food", pIsInStock = true, pPrice = 28 },
            new ProductDetails { pId = 109, pName = "Bhujya", pCategory = "Junk-Food", pIsInStock = false, pPrice = 100 },
            new ProductDetails { pId = 110, pName = "Butter", pCategory = "Dairy", pIsInStock = true, pPrice = 190 },
            new ProductDetails { pId = 111, pName = "Cheese", pCategory = "Dairy", pIsInStock = true, pPrice = 168 },
            new ProductDetails { pId = 112, pName = "Milk", pCategory = "Dairy", pIsInStock = true, pPrice = 295 },
            new ProductDetails { pId = 113, pName = "Bread", pCategory = "Dairy", pIsInStock = true, pPrice = 12 },
            new ProductDetails { pId = 114, pName = "Jam", pCategory = "Dairy", pIsInStock = false, pPrice = 18 },
        };
        #endregion

        #region Get Products Methods
        public List<ProductDetails> GetAllProducts()
        {
            return productsList;
        }

        public ProductDetails GetProdctById(int id)
        {
            var data = (from p in productsList
                       where p.pId == id 
                       select p).Single();
            return data;
        }

        public List<ProductDetails> GetProductByCategory(string  category)
        {
            var data = (from p in productsList
                       where p.pCategory == category
                       select p).ToList();
            return data;
        }

        public List<ProductDetails> GetProductInStock(string isavailable)
        {
            if (isavailable == "yes")
            {
                var data = (from a in productsList
                           where a.pIsInStock == true
                           select a).ToList();
                return data;
            }
            else
            {
                var data = (from a in productsList
                            where a.pIsInStock == false
                            select a).ToList();
                return data;
            }
        }

        public int TotalProducts()
        {
            var total = productsList.Count;
            return total;
        }

        public string AddNewProduct(ProductDetails product)
        {
            productsList.Add(product);
            return "Product Added";
        }

        public string DeleteProduct(int id)
        {
            var data = (from p in productsList
                        where p.pId == id
                        select p).Single();

            productsList.Remove(data);
            return "Product Deleted Successfully";
        }

        public string EditProduct(ProductDetails product)
        {
            var data = (from p in productsList
                        where p.pId == product.pId
                        select p).Single();

            data.pName = product.pName;
            data.pPrice = product.pPrice;
            data.pCategory = product.pCategory;
            data.pIsInStock = product.pIsInStock;
            return "Product Detail updated";

        }


        #endregion
    }
}



