namespace FlowCRM.CustomActionFilters
{
    public class CustomErrorResult
    {
        public bool Succeeded { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }

}
