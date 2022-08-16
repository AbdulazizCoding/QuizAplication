using MyQuizzApplication.Data;
using MyQuizzApplication.Entities;

namespace MyQuizzApplication.Repository;

public class TopicRepository : GenericRepository<Topic>, ITopicRepository
{
    public TopicRepository(ApplicationDbContext context) 
        : base(context) { }
}