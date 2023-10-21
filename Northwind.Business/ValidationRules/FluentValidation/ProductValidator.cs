using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name cannot be empty");
            RuleFor(p => p.ProductName).Length(2, 20).WithMessage("Product name must be between 2 and 20 characters");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Unit price cannot be empty");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Unit price must be greater than 0");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Quantity per unit cannot be empty");
            RuleFor(p => p.QuantityPerUnit).Length(1, 20).WithMessage("Quantity per unit must be between 1 and 20 characters");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Units in stock cannot be empty");
            RuleFor(p => p.UnitsInStock).GreaterThan((short)0).WithMessage("Units in stock must be greater than 0");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category cannot be empty");
            RuleFor(p => p.CategoryId).GreaterThan(0).WithMessage("Category must be greater than 0");
        }
    }
}
