using FluentValidation;

namespace FluentVal.Entity
{
	public class ProductValidator : AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(p => p.Name)
				.NotEmpty().WithMessage("Ürün ismi Boş Kalamaz.")
				.MaximumLength(50).WithMessage("En fazla 50 karakter olabilir");

			RuleFor(p => p.Price)
				.GreaterThan(0).WithMessage("Fiyatı 0 TL olamaz.");

			RuleFor(p => p.Stock)
				.GreaterThanOrEqualTo(0).WithMessage("Stok Miktarı 0 dan az olamaz.");
		}
	}
}
