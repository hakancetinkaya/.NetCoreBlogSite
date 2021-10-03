using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRules
{
  public  class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar Adı kısmı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Yazar Email adresi boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz.");
            RuleFor(x => x.Password).Must(IsPasswordValid).WithMessage("Parolanızda en az bir küçük harf bir büyük harf ve rakam olmalıdır");
        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }

        }
    
    }
}
