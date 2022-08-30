
public class BankAccount {

  public string AccountNumber { get; set;}
  public decimal Balance { get; set;} = 0;

  public BankAccount() {
    AccountNumber = "";
    Balance = decimal.Zero;
  }

  public BankAccount(decimal newBalance) {
    AccountNumber = "";
    Balance = newBalance;
  }

  public void MakeDeposit(decimal amount) {
    if(amount < 0) {
      throw new Exception("Deposit must be non-negative");
    }
    Balance += amount;
  }

  public decimal MakeDepositGetBalance(decimal amount) {
    MakeDeposit(amount);
    return Balance;
  }

}