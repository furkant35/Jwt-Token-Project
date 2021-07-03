using FluentValidation;
using YSKProje.UdemyJwtProje.Entities.Dtos.AppUserDtos;

namespace YSKProje.UdemyJwtProje.Business.ValidationRules.FluentValidation
{
    public class AppUserAddDtoValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(I => I.FullName).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez");
        }
    }
}
