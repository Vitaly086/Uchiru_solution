namespace Task10.Services;

public struct OperationResult<T>
{
    public bool Success { get; init; }
    public T Data { get; init; }
    public string ErrorMessage { get; init; }

    public static OperationResult<T> CreateSuccessResult(T data)
    {
        return new OperationResult<T>
        {
            Success = true, Data = data
        };
    }

    public static OperationResult<T> CreateFailure(string errorMessage)
    {
        return new OperationResult<T>
        {
            Success = false, ErrorMessage = errorMessage
        };
    }
}