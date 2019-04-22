using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TShirtShop.Domain.Entities;
using TShirtShop.Persistence;

namespace TShirtShop.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly TShirtShopDbContext _context;

        public CreateProductCommandHandler(TShirtShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                 Name = request.Name,
                 Description = request.Description,
                 Display = request.Display,
                 DiscountedPrice = request.DiscountedPrice,
                 Image = request.Image,
                 Image2 = request.Image2,
                 Thumbnail = request.Thumbnail,
                 Price = request.Price
            };

            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProductId;
        }
    }
}
