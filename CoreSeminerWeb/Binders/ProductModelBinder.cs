using CoreSeminerWeb.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSeminerWeb.Binders
{
    public class ProductModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentException(nameof(bindingContext));
            }

            int prodId = Convert.ToInt32(bindingContext.ValueProvider.GetValue("ProductId").FirstValue);
            string prodName = bindingContext.ValueProvider.GetValue("ProductName").FirstValue;
            string quantity = bindingContext.ValueProvider.GetValue("QuantityPerUnit").FirstValue;
            string price = bindingContext.ValueProvider.GetValue("UnitPrice").FirstValue;
            decimal realPrice = Convert.ToDecimal(price, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            short inStock = Convert.ToInt16(bindingContext.ValueProvider.GetValue("UnitsInStock").FirstValue);
            short onOrder = Convert.ToInt16(bindingContext.ValueProvider.GetValue("UnitsOnOrder").FirstValue);
            short reorder = Convert.ToInt16(bindingContext.ValueProvider.GetValue("ReorderLevel").FirstValue);

            ProductModel model = new ProductModel()
            {
                Discontinued = true,
                ProductId = prodId,
                ProductName = prodName,
                QuantityPerUnit = quantity,
                ReorderLevel = reorder,
                UnitPrice = realPrice,
                UnitsInStock = inStock,
                UnitsOnOrder = onOrder
            };
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
