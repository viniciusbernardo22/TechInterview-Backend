namespace Back.Interview.Domain.Repositories;

public interface IDataInterviewRepository
{
    Task<string> GetDataAsync();
}