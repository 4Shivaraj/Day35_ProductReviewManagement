
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome To Product Review Management System\n");
                List<ProductReview> list = ProductReviewManagement.AddProductsReview();
                DataTable table = ProductReviewManagement.CreatingDataTable();
                Console.WriteLine("Choose Option or press 0 for exit\n1:Add review to the list\n2:Top 3 high Rated product\n" +
                    "3:Products with Rating greater than 3\n4:Count of products for each ProductID\n5:Only ProductID with Review\n" +
                    "6:Skipping top 5 records and displaying remaining records\n7:Only Retrieving ProductID with Rating\n" +
                    "8:Create DataTable\n9:Retrieve Records withIsLike value as True");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        ProductReviewManagement.DisplayeProductsReview(list);
                        break;
                    case 2:
                        ProductReviewManagement.Top3HighRatedProduct(list);
                        break;
                    case 3:
                        ProductReviewManagement.ProductsRatingGreaterThan3(list);
                        break;
                    case 4:
                        ProductReviewManagement.CountofReviewForEachProductID(list);
                        break;
                    case 5:
                        ProductReviewManagement.RetrieveProductIDWithReview(list);
                        break;
                    case 6:
                        ProductReviewManagement.SkipTop5Records(list);
                        break;
                    case 7:
                        ProductReviewManagement.RetrieveProductIDWithRating(list);
                        break;
                    case 8:
                        ProductReviewManagement.DisplayDataTable(table);
                        break;
                    case 9:
                        ProductReviewManagement.RetriveRecordsWithIsLikeTrue(table);
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

/*
UC-9
Product Review Management 
- Retrieve all the records from the datatable variable who’s isLike value is true using LINQ

Welcome To Product Review Management System

Choose Option or press 0 for exit
1:Add review to the list
2:Top 3 high Rated product
3:Products with Rating greater than 3
4:Count of products for each ProductID
5:Only ProductID with Review
6:Skipping top 5 records and displaying remaining records
7:Only Retrieving ProductID with Rating
8:Create DataTable
9:Retrieve Records withIsLike value as True
9
Displaying reviews with IsLike value as True
ProductId, UserId, Review, IsLike, Rating
1,  34,  Good,  True,  4.5
3,  57,  Good,  True,  3.9
4,  56,  Average,  True,  3
8,  21,  Good,  True,  4.7
3,  67,  Good,  True,  4.3
2,  69,  Good,  True,  4.4
6,  81,  Average,  True,  3.5
5,  29,  Good,  True,  4.9

 */