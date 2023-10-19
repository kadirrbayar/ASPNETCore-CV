using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x=> x.ProjectUrl).NotEmpty().WithMessage("Proje URL alanı boş geçilemez");
            RuleFor(x=> x.ImageURL).NotEmpty().WithMessage("Image URL alanı boş geçilemez");
            RuleFor(x=> x.ImageURL2).NotEmpty().WithMessage("Image URL2 alanı boş geçilemez");
            RuleFor(x=> x.Name).Length(5,20).WithMessage("Ad alanı minimum 5 maksimum 20 karakter uzunluğunda olmalıdır.");
        }
    }
}
