namespace NorthwindApp.Api.Payloads
{
    public class CategoryPayload
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
