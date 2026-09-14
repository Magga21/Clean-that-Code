using System.Globalization;
using CleanThatCode.Community.Repositories.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Repositories.Implementations;
using CleanThatCode.Community.Tests.Mocks;

namespace CleanThatCode.Community.Tests;

[TestClass]
public class CommentRepositoryTests
{
	private readonly CommentRepository _repository;

	public CommentRepositoryTests()
	{
		var culture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;

		var mockContext = new CleanThatCodeDbContextMock();
		_repository = new CommentRepository(mockContext);
	}

	[TestMethod]
	public void GetAllCommentsByPostId_GivenWrongPostId_ShouldReturnNoComments()
	{
		var result = _repository.GetAllCommentsByPostId(5);

		Assert.AreEqual(0, result.Count());
	}

	[TestMethod]
	public void GetAllCommentsByPostId_GivenValidPostId_ShouldReturnTwoComment()
	{
		var result = _repository.GetAllCommentsByPostId(1);

		Assert.AreEqual(2, result.Count());
	}
}