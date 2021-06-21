using System;

public class intern : Person{

    public int Age{
        get {return calcAge();}
        set {}
    }
    public int calcAge(){
        int surplus = 0;
        int years = DateTime.Now.Year - DateOfBirth.Year;
        int months = DateTime.Now.Month - DateOfBirth.Month;
        int days = DateTime.Now.Day - DateOfBirth.Day;

        if(((days == 0 || days > 0) && months == 0) || (months > 0)){
            surplus = 1;
        }

        return years + surplus;
    }
    public bool IsGraduated {get; set;}

    public string FullName(){
        return LastName + " " + FirstName;
    }



}