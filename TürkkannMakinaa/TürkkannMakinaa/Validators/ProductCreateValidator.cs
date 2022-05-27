using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Validators
{
    public class ProductCreateValidator : AbstractValidator<Product>
    {
        public ProductCreateValidator()
        {
            this.ApplyValidationRules();
        }

        void ApplyValidationRules()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Kategori boş geçilemez");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Lütfen Fiyat giriniz");
            RuleFor(x => x.Currency).NotEmpty().WithMessage("Para birimi seçiniz");
            RuleFor(x => x.MainPhoto).NotEmpty().WithMessage("Resim Boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adı giriniz");
        }
    }
}
