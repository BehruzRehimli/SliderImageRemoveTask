namespace HomeworkPustok.Areas.Manage.ViewModels
{
    public class PaginationMV<T>
    {
        public List<T> Items { get; set; }
        public int PagesCount { get; set; }
        public int Page { get; set; }
        public string Search { get; set; } = null;
    }
}
