using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>//,IdentityErrorDescriber
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez").EmailAddress().WithMessage("Geçerli bir e-posta değeri giriniz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın");
            RuleFor(x => x.WriterPassword).NotNull().WithMessage("Şifre boş geçilemez")
                .MinimumLength(8).WithMessage("En az 8 karakterden oluşmalı")
                .Matches("[A-Z]").WithMessage("En az 1 büyük harf içermeli")
                .Matches("[a-z]").WithMessage("En az 1 küçük harf içermeli")
                .Matches("[0-9]").WithMessage("En az 1 sayı içermeli")
                .Matches("[^a-zA-Z0-9]").WithMessage("En az 1 özel karaker içermeli");
            RuleFor(x => x.City.CityName).NotEmpty().WithMessage("Lütfen şehir seçiniz");
        }
    }
}
