namespace ProjectTemplate.Core.Abstractions
{
    public interface IEntityKey<out TKey>
    {
        TKey Id { get; }
    }
}
