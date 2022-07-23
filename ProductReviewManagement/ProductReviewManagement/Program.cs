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
            Console.WriteLine("Welcome To Product Review Management System");
            List<ProductReview> list = ProductReviewManagement.AddProductsReview();
            ProductReviewManagement.DisplayeProductsReview(list);
            Console.ReadLine();
        }
    }
}

/*
UC-1
Product Review Management
- Create Product review class with ProductID, UserID, Rating, Review and isLike fields
- Create variable for List of Product Review class in Main method
- Add 25 default values in list which we have created

 * Welcome To Product Review Management System
ProductID: 1, UserID: 34, Review: Good, IsLike: True, Rating: 4.5
ProductID: 4, UserID: 23, Review: Bad, IsLike: False, Rating: 1.5
ProductID: 5, UserID: 39, Review: Good, IsLike: True, Rating: 3.5
ProductID: 8, UserID: 57, Review: Average, IsLike: True, Rating: 3.5
ProductID: 1, UserID: 78, Review: Good, IsLike: True, Rating: 3.5
ProductID: 7, UserID: 22, Review: Average, IsLike: True, Rating: 3
ProductID: 9, UserID: 11, Review: Good, IsLike: True, Rating: 3.9
ProductID: 3, UserID: 45, Review: Bad, IsLike: False, Rating: 2.5
ProductID: 6, UserID: 89, Review: Good, IsLike: True, Rating: 3.5
ProductID: 2, UserID: 24, Review: Good, IsLike: True, Rating: 4.8
ProductID: 7, UserID: 10, Review: Bad, IsLike: False, Rating: 2
 */