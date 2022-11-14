using static System.Console;
class DemoCarLoan
{
	static void Main()
	{
		Loan aLoan = new Loan();
		CarLoan aCarLoan = new CarLoan();
		aLoan.LoanNumber = 2239;
		aLoan.LastName = "Mitchell";
		aLoan.LoanAmount = 1_000.00;
		aCarLoan.LoanNumber = 3358;
		aCarLoan.LastName = "Jansen";
		aCarLoan.LoanAmount = 20_000.00;
		aCarLoan.Make = "Ford";
		aCarLoan.Year = 2007;
		WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));
		WriteLine("Loan #{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
		WriteLine(" Loan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
	}
}

class Loan
{
	public int LoanNumber {get; set;}
	public string LastName {get; set;}
	public double LoanAmount 
	{
		set
		{
			if(value < MINIMUM_LOAN)
			  loanAmount = MINIMUM_LOAN;
			else
			  loanAmount = value;
		}
		get
		{
			return loanAmount;
		}
	}
	public const double MINIMUM_LOAN = 5_000;
	protected double loanAmount;
}

class CarLoan : Loan
{
	private int year;
	public int Year 
	{
		set
		{
			if(value < EARLIEST_YEAR)
			{
				year = value;
				loanAmount = 0;
			}
			else
			  year = value;
		}
		get
		{
			return year;
		}
	
	}
	public string Make {get; set;}
	private const int EARLIEST_YEAR = 2008;
	private const int LOWEST_INVALID_NUM = 1000;
	public new int LoanNumber
	{
		get
		{
			return base.LoanNumber;
		}
		set
		{
			if(value < LOWEST_INVALID_NUM)
			  base.LoanNumber = value;
			else
			  base.LoanNumber = value % LOWEST_INVALID_NUM;
		}
	}
}
