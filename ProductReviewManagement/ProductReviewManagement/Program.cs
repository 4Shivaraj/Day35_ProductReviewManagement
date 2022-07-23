
using System;
using System.Collections.Generic;
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
                Console.WriteLine("Choose Option or press 0 for exit\n1:Add review to the list\n2:Top 3 high Rated product\n" +
                    "3:Products with Rating greater than 3\n4:Count of products for each ProductID\n5:Only ProductID with Review\n" +
                    "6:Skipping top 5 records and displaying remaining records");
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
UC-6
Product Review Management 
- skip top 5 records from the list using LINQ and display other records

Welcome To Product Review Management System

Choose Option or press 0 for exit
1:Add review to the list
2:Top 3 high Rated product
3:Products with Rating greater than 3
4:Count of products for each ProductID
5:Only ProductID with Review
6:Skipping top 5 records and displaying remaining records
6
Skipping top 5 records and displaying remaining records
ProductID: 7, UserID: 22, Review: Average, IsLike: True, Rating: 3
ProductID: 9, UserID: 11, Review: Good, IsLike: True, Rating: 3.9
ProductID: 3, UserID: 45, Review: Bad, IsLike: False, Rating: 2.5
ProductID: 6, UserID: 89, Review: Good, IsLike: True, Rating: 3.5
ProductID: 2, UserID: 24, Review: Good, IsLike: True, Rating: 4.8
ProductID: 7, UserID: 10, Review: Bad, IsLike: False, Rating: 2
 */