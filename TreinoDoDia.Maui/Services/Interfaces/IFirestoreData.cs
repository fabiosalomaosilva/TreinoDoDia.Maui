namespace TreinoDoDia.Maui.Services.Interfaces;

public interface IFirestoreData<T> where T : class
{
    Task AddAsync(T entity);
    Task<T?> GetAsync(string id);
    Task<IEnumerable<T>> GetAllAsync();
    Task UpdateAsync(string id, T entity);
    Task DeleteAsync(string id);
}