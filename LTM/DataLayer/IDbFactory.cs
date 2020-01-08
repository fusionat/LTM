namespace DataLayer
{
    public interface IDbFactory
    {
        LtmDataContext Get();
    }
}