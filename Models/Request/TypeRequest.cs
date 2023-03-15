namespace ZooManagement.Models.Request
{
    public class SpeciesRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public virtual string Filters => "";
    }
    public class SpeciesSearchRequest : SpeciesRequest
    {
        private string _search;
        public string Search
        {
            get => _search?.ToLower();
            set => _search = value;
        }

        public override string Filters => Search == null ? "" : $"&search={Search}";
    }

    public class PostSpeciesRequest : SpeciesRequest
    {
        public string Species { get; set; }
        public override string Filters => Species == null ? "" : $"&species={Species}";
    }
}