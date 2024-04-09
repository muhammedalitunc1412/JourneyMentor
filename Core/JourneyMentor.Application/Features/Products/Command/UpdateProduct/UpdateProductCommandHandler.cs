using JourneyMentor.Application.Bases;
using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using JourneyMentor.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : BaseHandler, IRequestHandler<UpdateProductCommandRequest, Unit>
    {

        public UpdateProductCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }
        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id );

            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);

            //var productCategories = await unitOfWork.GetReadRepository<ProductCategory>()
            //    .GetAllAsync(x => x.ProductId == product.Id);

            //await unitOfWork.GetWriteRepository<ProductCategory>()
            //    .HardDeleteRangeAsync(productCategories);

            //foreach (var categoryId in request.CategoryIds)
            //    await unitOfWork.GetWriteRepository<ProductCategory>()
            //        .AddAsync(new() { CategoryId = categoryId, ProductId = product.Id });

            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}