﻿namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CategoryName { get; set; }
    }
}