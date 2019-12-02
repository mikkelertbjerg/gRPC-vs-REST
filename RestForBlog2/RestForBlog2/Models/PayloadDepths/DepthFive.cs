namespace RestForBlog2.Models.PayloadDepths
{
    public class DepthFive
    {
        public int Id { get; set; }

        public string StringValue { get; set; }
        public int IntValue { get; set; }

        public double DoubleValue { get; set; }

        public DepthFour DepthFour { get; set; }
    }
}