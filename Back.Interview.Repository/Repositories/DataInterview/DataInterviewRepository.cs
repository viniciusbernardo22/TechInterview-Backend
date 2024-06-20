using Back.Interview.Domain.Repositories;

namespace Back.Interview.Repository.Repositories.DataInterview;

public class DataInterviewRepository : IDataInterviewRepository
{
    public async Task<string> GetDataAsync()
        => "1 - Teste - Ativo";
}