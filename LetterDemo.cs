using static System.Console;
using System;
class LetterDemo
{
   static void Main()
   {
     Letter aLetter = new Letter();
     CertifiedLetter aCertifiedLetter = new CertifiedLetter();
     aLetter.Date = "Dec 12, 2019";
     aLetter.Name = "Bruce";
     aCertifiedLetter.Date = "Nov 23, 2021";
     aCertifiedLetter.Name = "Harry";
   }
}

class Letter
{
  public string Name {get; set;}
  public string Date {get; set;}
  public override string ToString()
  {
    return(GetType() + ": " + Name + Date);
  }
}

class CertifiedLetter : Letter
{
public override string ToString()
  {
    return(GetType() + ": " + Name + Date);
  }
}


// Write your classes here
