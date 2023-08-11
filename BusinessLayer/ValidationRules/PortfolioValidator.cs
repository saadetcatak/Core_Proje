﻿using EntityLayer.Concrete;
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
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.Image2Url).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmak Zorundadır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı En Az 100 Karakterden Oluşmak Zorundadır");
        }
    }
}
