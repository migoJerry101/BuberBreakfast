using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.ServiceError;
using ErrorOr;

namespace BuberBreakfast.Services;

public class BreakfastService : IbreakfastService
{
    private readonly Dictionary<Guid, Breakfast> _breakfast = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfast.Add(breakfast.Id, breakfast);
    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfast.Remove(id);
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (_breakfast.TryGetValue(id, out var breakfast))
        {
            return breakfast;
        }

        return Errors.Breakfast.NotFound;
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
        _breakfast[breakfast.Id] = breakfast;
    }
}