using ErrorOr;

namespace BuberBreakfast.ServiceError;

public static class Errors
{
    public static class Breakfast
    {
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.Notfound",
            description: "Breakfast not found"
        );
    }

}