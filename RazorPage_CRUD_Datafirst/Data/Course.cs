using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPage_CRUD_Datafirst.Data
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // bỏ tăng tự động
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
}
