using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryApiIntegrationTests.Books
{
    class GettingAllBooks : IClassFixture<WebTestFixture>
    {
        private HttpClient _client;
        public GettingAllBooks(WebTestFixture factory)
        {
            _client = factory.CreateClient();
        }
        public async Task CorrectStatusCode()
        {
            var resp = await _client.GetAsync("/books");
            Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
        }
        public async Task UseCorrectMediaType()
        {
            var resp = await _client.GetAsync("/books");
            Assert.Equal("application/json", resp.Content.Headers.ContentType.MediaType);
        }

        public async Task HasCorrectDataRepresentation()
        {
            var resp = await _client.GetAsync("/books");
            var content = await resp.Content.ReadAsAsync<GetBooksResponse>();
            Assert.Equal(2, content.numberOfBooks);
            Assert.Null(content.genreFilter);
        }
    }

    public class GetBooksResponse
    {
        public Book[] books { get; set; }
        public string genreFilter { get; set; }
        public int numberOfBooks { get; set; }
    }

    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int numberOfPages { get; set; }
    }

}

