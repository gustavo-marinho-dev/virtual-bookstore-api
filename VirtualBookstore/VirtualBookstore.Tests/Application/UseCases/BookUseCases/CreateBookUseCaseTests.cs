using AutoMapper;
using NSubstitute;
using System.Linq.Expressions;
using VirtualBookstore.Application.DTOs.Book;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Application.UseCases.BookUseCases;
using VirtualBookstore.Domain.Entities;
using VirtualBookstore.Domain.Enums;
using VirtualBookstore.UnitTests.Application.AutoMapper;

namespace VirtualBookstore.UnitTests.Application.UseCases.BookUseCases
{
    public class CreateBookUseCaseTests
    {
        private readonly IUnitOfWork _unitOfWorkMock;
        private readonly IBookRepository _bookRepositoryMock;
        private readonly IAuthorRepository _authorRepositoryMock;
        private readonly IMapper _mapper;

        public CreateBookUseCaseTests()
        {
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
            _bookRepositoryMock = Substitute.For<IBookRepository>();
            _authorRepositoryMock = Substitute.For<IAuthorRepository>();
            _mapper = AutoMapperHelper.Initialize();
        }

        [Fact]
        public async Task Handle_WithValidRequest_ShouldCreateBookAndReturnResponse()
        {
            // Arrange
            var AuthorIdList = new List<Guid> { Guid.NewGuid() };

            var createBookRequest = new CreateBookRequest
            {
                Title = "Livro 1",
                PublicationYear = DateTime.UtcNow,
                Publisher = "Editora 1",
                Subject = Subject.Arts, 
                Categorie = "Ficção",
                Thumbnail = "https://example.com/ficticio_thumbnail.jpg",
                Synopsis = "Uma história incrível e imaginária.",
                Rating = 4.5,
                Price = 19.99,
                Language = "Português",
                ISBN = "1234567890",
                Pages = 200,
                Backing = Backing.Hardback, 
                Dimensions = "10.0 x 7.0 x 1.2 inches",
                Authors = AuthorIdList
            };

            var authors = new List<Author>
            {
                new Author
                {
                    Id = AuthorIdList.First(),
                    FullName = "Author 1",
                    DateOfBirth = new DateTime(1980, 1, 1),
                    Nationality = "Country 1",
                    Biography = "Biography 1"
                }
            };

            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = "Livro 1",
                PublicationYear = DateTime.UtcNow,
                Publisher = "Editora 1",
                Subject = Subject.Arts,
                Categorie = "Ficção",
                Thumbnail = "https://example.com/ficticio_thumbnail.jpg",
                Synopsis = "Uma história incrível e imaginária.",
                Rating = 4.5,
                Price = 19.99,
                Language = "Português",
                ISBN = "1234567890",
                Pages = 200,
                Backing = Backing.Hardback,
                Dimensions = "10.0 x 7.0 x 1.2 inches",
                Authors = authors
            };

            _authorRepositoryMock.GetWhere(Arg.Any<Expression<Func<Author, bool>>>())
                .ReturnsForAnyArgs(Task.FromResult(authors));

            var createBookUseCase = new CreateBookUseCase(
                _unitOfWorkMock,
                _bookRepositoryMock,
                _authorRepositoryMock,
                _mapper
            ); 

            // Act
            var result = await createBookUseCase.Handle(createBookRequest, CancellationToken.None);

            // Assert
            _bookRepositoryMock.Received(1).Create(Arg.Any<Book>());
            await _unitOfWorkMock.Received(1).Save(CancellationToken.None);
            Assert.NotNull(result);
            Assert.IsType<BookResponse>(result);
        }
    }
}