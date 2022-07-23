
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
                    "8:Create DataTable");
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
UC-8
Product Review Management 
- Create DataTable using C# and Add ProductID, UserID, Rating, Review and isLike fields in that.
- Add 25 default values in datatable list which we have created.

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
8
ProductId,  UserId,  Rating,  Review,  IsLike
1,  34, Good,  True, 4.5
3,  57, Good,  True, 3.9
4,  56, Average,  True, 3
7,  22, Bad,  False, 2
8,  21, Good,  True, 4.7
3,  67, Good,  True, 4.3
2,  69, Good,  True, 4.4
9,  13, Bad,  False, 1.5
6,  81, Average,  True, 3.5
5,  29, Good,  True, 4.9
2,  30, Bad,  False, 2

 */