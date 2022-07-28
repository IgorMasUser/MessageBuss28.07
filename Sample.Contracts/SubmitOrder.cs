namespace Sample.Contracts
{
    public class SubmitOrder
    {
       public Guid OrderId { get; set; }
       public DateTime Timestamp { get; set; }
       public string CustomerNumber { get; set; }
    }

    //public interface IOrderSubmissionAccepted
    //{
    //    Guid OrderId { set;}
    //    DateTime Timestamp { get; }
    //    string CustomerNumber { get; }
    //}

   

}