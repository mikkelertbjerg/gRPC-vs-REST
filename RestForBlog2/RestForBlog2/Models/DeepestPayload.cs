using RestForBlog2.Models.PayloadDepths;

namespace RestForBlog2.Models
{
    public class DeepestPayload
    {
        public int Id { get; set; }

        public DepthSeven DepthSeven { get; set; }
        public DepthEight DepthEight { get; set; }
        public DepthNine DepthNine { get; set; }
    }
}