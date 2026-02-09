using AutoMapper;
using eCommerceApp.Application.DTOs;
using eCommerceApp.Application.DTOs.Category;
using eCommerceApp.Application.Services.Interfaces;
using eCommerceApp.Domain.Entities;
using eCommerceApp.Domain.Interfaces;

namespace eCommerceApp.Application.Services.implementations;

public class CategoryService(IGeneric<Category> categoryInterface, IMapper mapper) : ICategoryService
{
    public Task<IEnumerable<GetCategory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GetCategory> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse> AddAsync(CreateCategory category)
    {
        var mappedData = mapper.Map<Category>(category);
        int result = await categoryInterface.AddAsync(mappedData);
        return result > 0
            ? new ServiceResponse(true, "Category added")
            : new ServiceResponse(false, "Category failed to be added");
    }

    public Task<ServiceResponse> UpdateAsync(UpdateCategory category)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse> DeleteAsync(Guid id)
    {
        int result = await categoryInterface.DeleteAsync(id);
        return result > 0 ? new ServiceResponse(true, "Category deleted") :
            new ServiceResponse(false, "Category deleted");
    }
}