namespace RestForBlog2.Models.PayloadDepths
{
    public class DepthThree
    {
        public int Id { get; set; }

        public string StringValue { get; set; }
        public int IntValue { get; set; }

        public double DoubleValue { get; set; }
        public DepthTwo DepthTwo { get; set; }
    }
}