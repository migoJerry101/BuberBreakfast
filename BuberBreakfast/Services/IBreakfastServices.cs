using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services;

public interface IbreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
}