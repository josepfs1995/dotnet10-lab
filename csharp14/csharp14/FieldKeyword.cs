namespace csharp14;

public class FieldKeyword
{
   public int Stock { get; set => field = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Stock must be greater than 0"); }
   public int Stock2 { get; set => field = SetStock(value);   }
   private static int SetStock(int stock)
   {
      return stock switch
      {
         > 1_000 => throw new ArgumentOutOfRangeException(nameof(stock), "Stock must be less than 1000"),
         < 0 => -1,
         _ => stock
      };
   }
}