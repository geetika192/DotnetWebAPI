using SoftDelete.Repository;

namespace SoftDelete.Model
{
    public class Book : IIsDeleted
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        //… other properties left out to focus on Soft delete

        public bool SoftDeleted { get; set; }

    }
}