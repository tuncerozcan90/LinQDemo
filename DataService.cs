using LinQDemo.EFDbFirst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQDemo
{
    public class DataService
    {
        public List<ResultViewModel> GetPivotedData()
        {
            using (var dataContext = new AdventureWorksDW2022Entities())
            {
                var query = (
                    from s in dataContext.FactInternetSales
                    join p in dataContext.DimProducts on s.ProductKey equals p.ProductKey
                    group s by new
                    {
                        OrderYear = s.OrderDate.Value.Year,
                        p.EnglishProductName
                    }
                    into g
                    select new ResultViewModel
                    {
                        OrderYear = g.Key.OrderYear,
                        ProductName = g.Key.EnglishProductName,
                        TotalOrders = g.Sum(x => x.OrderQuantity)
                    }
                ).ToList();

                return query;
            }
        }
    }
}
