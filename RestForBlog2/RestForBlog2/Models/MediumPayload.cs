namespace RestForBlog2.Models
{
    public class MediumPayload
    {
        public int Id { get; set; }

        public string StringValue { get; set; }

        public int IntValue { get; set; }

        public double DoubleValue { get; set; }

        public SmallPayload SmallPayloadOne { get; set; }

        public SmallPayload SmallPayloadTwo { get; set; }

        public SmallPayload SmallPayloadThree { get; set; }

        public SmallPayload SmallPayloadFour { get; set; }

        public SmallPayload SmallPayloadFive { get; set; }

        public SmallPayload SmallPayloadSix { get; set; }

        public MediumPayload(SmallPayload smallPayloadOne, SmallPayload smallPayloadTwo, SmallPayload smallPayloadThree, SmallPayload smallPayloadFour, SmallPayload smallPayloadFive, SmallPayload smallPayloadSix, double doubleValue, int intValue, string stringValue, int id)
        {
            Id = id;
            StringValue = stringValue;
            IntValue = intValue;
            DoubleValue = doubleValue;
            SmallPayloadOne = smallPayloadOne;
            SmallPayloadTwo = smallPayloadTwo;
            SmallPayloadThree = smallPayloadThree;
            SmallPayloadFour = smallPayloadFour;
            SmallPayloadFive = smallPayloadFive;
            SmallPayloadSix = smallPayloadSix;
        }

        public MediumPayload()
        {
        }
    }
}