namespace RestForBlog2.Models
{
    public class SmallPayload
    {
        public int Id { get; set; }
        public string StringValueOne { get; set; }
        public string StringValueTwo { get; set; }
        public string StringValueThree { get; set; }
        public int IntValueOne { get; set; }
        public int IntValueTwo { get; set; }
        public int IntValueThree { get; set; }
        public double DoubleValueOne { get; set; }
        public double DoubleValueTwo { get; set; }
        public double DoubleValueThree { get; set; }

        public SmallPayload(int id, string stringValueOne, string stringValueTwo, string stringValueThree, int intValueOne, int intValueTwo, int intValueThree, double doubleValueOne, double doubleValueTwo, double doubleValueThree)
        {
            Id = id;
            StringValueOne = stringValueOne;
            StringValueTwo = stringValueTwo;
            StringValueThree = stringValueThree;
            IntValueOne = intValueOne;
            IntValueTwo = IntValueTwo;
            IntValueThree = intValueThree;
            DoubleValueOne = doubleValueOne;
            DoubleValueTwo = doubleValueTwo;
            DoubleValueThree = doubleValueThree;
        }

        public SmallPayload()
        {
        }
    }
}