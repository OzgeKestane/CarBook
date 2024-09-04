namespace CarBook.Dto.BlogDtos
{
    public class ResultAllBlogsWithAuthorDto
    {

        public int blogId { get; set; }
        public string title { get; set; }
        public string authorName { get; set; }
        public string categoryName { get; set; }
        public int authorId { get; set; }
        public string coverImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public int categoryId { get; set; }
        public string Description { get; set; }


    }
}
