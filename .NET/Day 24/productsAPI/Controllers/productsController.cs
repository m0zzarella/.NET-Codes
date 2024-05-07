using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        static List<string> productList = new List<string>()
        {"Pepsi", "Coca Cola", "Nestle", "Cadbury", "Tim Hortons", "Parle", "Amul", "Good Day", "Toblerone", "Nutella" };

        #region 1. Get All Data
        [HttpGet("getAllData")] //1. Get All Data
        public IActionResult getAllData()
        { 
            return Ok(productList);
        }
        #endregion

        #region 2. Order the Data
        [HttpGet("getDataOrder/{order}")] //2. Order the Data
        public IActionResult getDataOrder(int order) 
        {
            if (order == 1)
            {
                var ascending1 = from e in productList
                                 orderby e
                                 select e;
                return Ok(ascending1);
            }
            else if (order == 2) 
            {
                var descending1 = from e in productList
                                  orderby e descending
                                  select e;
                return Ok(descending1);
            }
            return BadRequest();
            
        }
        #endregion

        #region 3. Count all data
        [HttpGet("countAllData")]  //3. Count all data
        public IActionResult countAllData(int count)
        {
            return Ok($"Count of all data is: {productList.Count()}");
         }
        #endregion

        #region 4. Get Data Which Starts With --
        [HttpGet("getDataWith/{charac}")] //4. Get Data Which Starts With --
        public IActionResult getAllDataWith(char charac)
        {
            var filter1 = (from e in productList
                           where e.StartsWith(charac)
                           select e);
            return Ok(filter1);
        }
        #endregion

        #region 5. Add New Product
        [HttpPut("addnewProduct/{pName}")] //5. Add New Product
        public IActionResult addProduct(string pName)
        {
            productList.Add(pName);
            return Created("", $"{pName} has been added to product list!");
        }
        #endregion

        #region 6. Delete Product By Name
        [HttpDelete("deleteProductbyName/{pName}")] //6. Delete Product By Name
        public IActionResult removeProductName(string pName)
        {

            productList.Remove(pName);
            return Accepted($"Product with name {pName} has been deleted! ");
            //var idx = 0;
            //idx = productList.IndexOf(pName);
            //if (idx < 0)
            //    return NotFound("Product not found");
            //else
            //{
            //    productList.Remove(productList[idx]);
            //    return Accepted($"Product with name {pName} has been deleted! ");
            //}
        }
        #endregion

        #region 7. Edit Product Name
        [HttpPut("editName/{position}/{newpName}")] //7. Edit Product Name
        public IActionResult editProductName(int position, string newpName)
        {
            productList[position] = newpName;
            return Ok("Product name was edited!");
        }
        #endregion

        #region 8. Custom Product
        [HttpGet("customProduct")]    //8. Custom Product
        public IActionResult GetCustomProductDetails()
        {
            productInfo newProduct = new productInfo()
            {
               pID = 0,
               pName = "Hersheys",
               pCategory = "Chocolate",
               pPrice = 200,
               pQty = 500
            };
            return Ok(newProduct);
        }
        #endregion
    }
}
