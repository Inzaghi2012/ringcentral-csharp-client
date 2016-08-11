
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DialingPlan : Model
    {
        internal DialingPlan(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "dialing-plan";
            }
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public int? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public int? perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of countries which can be selected for a dialing plan
            public DialingPlanCountryInfo[] records { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
        }
    }
}