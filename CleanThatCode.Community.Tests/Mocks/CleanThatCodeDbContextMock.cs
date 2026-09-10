using CleanThatCode.Community.Models.Entities;

namespace CleanThatCode.Community.Tests.Mocks;

using CleanThatCode.Community.Repositories.Data;

public class CleanThatCodeDbContextMock : ICleanThatCodeDbContext
{
	public IEnumerable<Comment> Comments => FakeData.Comments;

	public IEnumerable<Post> Posts => FakeData.Posts;
}