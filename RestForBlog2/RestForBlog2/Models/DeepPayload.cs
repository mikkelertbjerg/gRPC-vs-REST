using RestForBlog2.Models.PayloadDepths;

namespace RestForBlog2.Models
{
    public class DeepPayload
    {
        public int Id { get; set; }
        public DepthOne DepthOne { get; set; }
        public DepthTwo DepthTwo { get; set; }
        public DepthThree DepthThree { get; set; }
        
    }
}