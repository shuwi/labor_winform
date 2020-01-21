namespace LaborStackApp.Service.Inter
{
    public interface LaborServiceInterface<T>
    {
        T GetSingle(object[] paramsList);
        bool UpdateSingle(T obj);
        bool AddSingle(T obj);
    }
}
