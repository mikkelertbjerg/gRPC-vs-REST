namespace RestForBlog2.Models.PayloadDepths
{
    public class DepthFour
    {
        public int Id { get; set; }

        public string StringValue { get; set; }
        public int IntValue { get; set; }

        public double DoubleValue { get; set; }

        public DepthThree DepthThree { get; set; }
    }
}