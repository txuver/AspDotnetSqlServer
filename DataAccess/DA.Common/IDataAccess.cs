namespace DA.Common
{
    public interface IDataAccess<T>
    {
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> Select(T entity);
        Task<IEnumerable<T>> List(T entity);
    }
}