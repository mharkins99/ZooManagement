/*using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models;
using ZooManagement.Models.Request;
using ZooManagement.Models.Response;

namespace ZooManagement.Models.Response
{
    public class SpeciesListResponse<T>
    {
        private readonly string _path;
        private readonly string _filters;
        
        public IEnumerable<T> Items { get; }
        public int TotalNumberOfItems { get; }
        public int Page { get; }
        public int PageSize { get; }

        public string NextPage => !HasNextPage() ? null : $"/{_path}?page={Page + 1}&pageNumber={PageSize}{_filters}";

        public string PreviousPage => Page <= 1 ? null : $"/{_path}?page={Page - 1}&pageNumber={PageSize}{_filters}";

        public SpeciesListResponse(SpeciesRequest search, IEnumerable<T> items, int totalNumberOfItems, string path)
        {
            Items = items;
            TotalNumberOfItems = totalNumberOfItems;
            Page = search.Page;
            PageSize = search.PageSize;
            _path = path;
            _filters = search.Filters;
        }
        
        private bool HasNextPage()
        {
            return Page * PageSize < TotalNumberOfItems;
        }
    }

   
    
    public class SpeciesListResponse : SpeciesListResponse<SpeciesResponse>
    {
        private SpeciesListResponse(SearchRequest search, IEnumerable<SpeciesResponse> items, int totalNumberOfItems) 
            : base(search, items, totalNumberOfItems, "types") { }
        
        public static SpeciesListResponse Create(SearchRequest search, IEnumerable<User> users, int totalNumberOfItems)
        {
            var userModels = users.Select(user => new UserResponse(user));
            return new SpeciesListResponse(search, userModels, totalNumberOfItems);
        }
    }
    
    
}
*/