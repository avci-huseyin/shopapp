namespace shopapp.business.Abstract
{
    public interface IValidator<T>
    {
        // Dictionary<string, string> ErrorMessage 
        string ErrorMessage {get; set;}
        bool Validation(T entity);

    }
}