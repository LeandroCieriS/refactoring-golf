namespace Hole2
{
    public class Money // +1 Remove unnecessary code * 2
    {
        public readonly int value;  //+1 Rename
        public readonly string currency;  //+1 Rename

        public Money(int value, string currency) // +2 +2 change types
        {
            this.value = value;  // +1 Change type
            this.currency = currency; // +1 Change type
        }
    }
}