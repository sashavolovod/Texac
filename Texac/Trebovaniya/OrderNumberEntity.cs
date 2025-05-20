namespace Texac
{
    public class OrderNumberEntity
    {
        public int id { get; set; }
        public int num { get; set; }

        public OrderNumberEntity(int id, int num)
        {
            this.id = id;
            this.num = num;
        }

    }
}
