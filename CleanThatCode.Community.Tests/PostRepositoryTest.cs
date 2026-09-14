using System.Globalization;
using CleanThatCode.Community.Repositories.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Repositories.Implementations;
using CleanThatCode.Community.Tests.Mocks;
using Moq;
using Bogus;

namespace CleanThatCode.Community.Tests;

[TestClass]
public class PostRepositoryTests
{
	private readonly Mock<ICleanThatCodeDbContext> _mockContext;

	private readonly PostRepository _repository;

	private readonly List<Post> _posts;

	public PostRepositoryTests()
	{
		_posts = new Faker<Post>()
		.RuleFor(p => p.Id, f => f.Random.Int(1, 1000))
		.RuleFor(p => p.Title, f => f.Lorem.Sentence())
		.RuleFor(p => p.Content, f => f.Lorem.Paragraph())
		.Generate(10);

		_mockContext = new Mock<ICleanThatCodeDbContext>();

		_repository = new PostRepository(_mockContext.Object);
	}

	[TestMethod]
	public void 

} 