namespace RestForBlog2.Models
{
    public class LargePayload
    {
        public int Id { get; set; }

        public string StringValue { get; set; }

        public int IntValue { get; set; }

        public double DoubleValue { get; set; }

        public MediumPayload MediumPayloadOne { get; set; }

        public MediumPayload MediumPayloadTwo { get; set; }

        public MediumPayload MediumPayloadThree { get; set; }

        public MediumPayload MediumPayloadFour { get; set; }

        public MediumPayload MediumPayloadFive { get; set; }

        public MediumPayload MediumPayloadSix { get; set; }
        public LargePayload(MediumPayload mediumPayloadSix, MediumPayload mediumPayloadFive, MediumPayload mediumPayloadFour, MediumPayload mediumPayloadThree, MediumPayload mediumPayloadTwo, MediumPayload mediumPayloadOne, double doubleValue, int intValue, string stringValue, int id)
        {
            MediumPayloadSix = mediumPayloadSix;
            MediumPayloadFive = mediumPayloadFive;
            MediumPayloadFour = mediumPayloadFour;
            MediumPayloadThree = mediumPayloadThree;
            MediumPayloadTwo = mediumPayloadTwo;
            MediumPayloadOne = mediumPayloadOne;
            DoubleValue = doubleValue;
            IntValue = intValue;
            StringValue = stringValue;
            this.Id = id;
        }

        public LargePayload()
        {
        }
    }
}