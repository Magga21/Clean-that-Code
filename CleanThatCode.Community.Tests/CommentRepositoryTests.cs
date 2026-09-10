using CleanThatCode.Community.Repositories.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Repositories.Implementations;
using CleanThatCode.Community.Tests.Mocks;

namespace CleanThatCode.Community.Tests;

[TestClass]
public class CommentRepositoryTests
{
	// Test til að sjá hvort það virki að setja mock data inn i þetta fall
	[TestMethod]
	public void GetAllCommentsByPostId()
	{

	var mockContext = new CleanThatCodeDbContextMock();
	var repository = new CommentRepository(mockContext);

	var result = repository.GetAllCommentsByPostId(1);

	Assert.AreEqual(2, result.Count());

	}	
}