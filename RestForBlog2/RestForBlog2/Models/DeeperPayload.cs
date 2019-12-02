using RestForBlog2.Models.PayloadDepths;

namespace RestForBlog2.Models
{
    public class DeeperPayload
    {
        public int Id { get; set; }
        public DepthFour DepthFour { get; set; }
        public DepthFive DepthFive { get; set; }
        public DepthSix DepthSix { get; set; }

    }
}