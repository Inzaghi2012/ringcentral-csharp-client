using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AccountPath : PathSegment
    {
        internal AccountPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "account";
            }
        }
        public ActiveCallsPath ActiveCalls()
        {
            return new ActiveCallsPath(this);
        }
        public BusinessAddressPath BusinessAddress()
        {
            return new BusinessAddressPath(this);
        }
        public CallLogPath CallLog(string _id)
        {
            return new CallLogPath(this, _id);
        }
        public CallLogPath CallLog()
        {
            return new CallLogPath(this);
        }
        public DepartmentPath Department(string _id)
        {
            return new DepartmentPath(this, _id);
        }
        public DevicePath Device(string _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        public DialingPlanPath DialingPlan()
        {
            return new DialingPlanPath(this);
        }
        public ExtensionPath Extension(string _id)
        {
            return new ExtensionPath(this, _id);
        }
        public ExtensionPath Extension()
        {
            return new ExtensionPath(this, "~");
        }
        public OrderPath Order(string _id)
        {
            return new OrderPath(this, _id);
        }
        public OrderPath Order()
        {
            return new OrderPath(this);
        }
        public PhoneNumberPath PhoneNumber(string _id)
        {
            return new PhoneNumberPath(this, _id);
        }
        public PhoneNumberPath PhoneNumber()
        {
            return new PhoneNumberPath(this);
        }
        public RecordingPath Recording(string _id)
        {
            return new RecordingPath(this, _id);
        }
        public ServiceInfoPath ServiceInfo()
        {
            return new ServiceInfoPath(this);
        }
        // Get Account Info by ID
        public Task<AccountInfo> Get()
        {
            return RC.Get<AccountInfo>(Endpoint(true), null);
        }
    }
}
