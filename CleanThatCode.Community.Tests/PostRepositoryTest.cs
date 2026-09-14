using System.Globalization;
using CleanThatCode.Community.Repositories.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Repositories.Implementations;
using CleanThatCode.Community.Tests.Mocks;
using CleanThatCode.Community.Models.Entities;
using System.Linq;
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
		var post1 = new Faker<Post>()
			.RuleFor(p => p.Title, f => "Grayskull")
			.RuleFor(p => p.Author, f => "He-Man")
			.Generate();

		var post2 = new Faker<Post>()
			.RuleFor(p => p.Title, f => "Grayskull")
			.RuleFor(p => p.Author, f => "He-Man")
			.Generate();

		var post3 = new Faker<Post>()
			.RuleFor(p => p.Title, f => "Hack the planet!")
			.RuleFor(p => p.Author, f => "Richard Stallman")
			.Generate();


		_posts = new List<Post> { post1, post2, post3 };


		_mockContext = new Mock<ICleanThatCodeDbContext>();

		_repository = new PostRepository(_mockContext.Object);

		_mockContext.Setup(c => c.Posts).Returns(_posts);

	}

	[TestMethod]
	public void GetAllPosts_NoFilter_ShouldContainAListOfThree()
	{
		var result = _repository.GetAllPosts("","");

		Assert.AreEqual(3, result.Count());
	}

	public void GetAllPosts_NoFilter_ShouldContainAListOfThree()
	{
		return 0;
	}
} 