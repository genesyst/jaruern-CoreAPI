namespace jaruernCore.Models
{
    public class mdlProductGroup
    {
        public Guid Id { get; set; }

        public string? Productgroupcode { get; set; }

        public string? Productgroupname { get; set; }

        public Guid Producttypeid { get; set; }
    }
}
