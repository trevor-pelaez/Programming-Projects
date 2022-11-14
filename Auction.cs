using static System.Console;

public class Auction

{

   static void Main()

   {

       string strBid;

       int intBid = 0;

       double dblBid = 0.0;

       const int minBid = 10;

       //Prompt user

       Write("Enter bid: ");

       //Read in user input and assign to string variable

       strBid = ReadLine();

 

      if(int.TryParse(strBid, out intBid))

          AcceptBid(intBid, minBid);

      else

          if(double.TryParse(strBid, out dblBid))

             AcceptBid(dblBid, minBid);

          else

             AcceptBid(strBid, minBid);

       }

   public static void AcceptBid(int intBid , int minBid )

   {

       if(intBid >= minBid)

          Write("Bid accepted");

          

       else

          Write("Bid not high enough");

          

   }

   public static void AcceptBid(double dblBid, int minBid )

   {

       if(dblBid >= minBid)

          Write("Bid accepted");

       else

          Write("Bid not high enough");

   }

   public static void AcceptBid(string strBid, int minBid )

   {

       double bid = 0.0;

       string dollarsString = " dollars";

       if (strBid.Substring(0, 1).Equals("$")) 
       {

          if(double.TryParse(strBid.Substring(1 , strBid.Length - 1), out bid))

             AcceptBid(bid, minBid);//call appropriate method

          else

             WriteLine("Bid was not in correct format"); //output not in correct format
       }
       else

       {

          if(strBid.Substring(strBid.Length - dollarsString.Length, dollarsString.Length).Equals(dollarsString))

          {

             if (double.TryParse(strBid.Substring(0, strBid.Length - 8), out bid))//enter condition to test if numeric portion can be converted to double

                AcceptBid(bid, minBid);//call appropriate method

             else

                Write("Bid was not in correct format"); //output not in correct format

          }

         else

            Write("Bid was not in correct format"); //output not in correct format

      }

   }

}
