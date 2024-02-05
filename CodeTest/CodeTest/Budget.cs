namespace CodeTest;

public abstract class Budget
{
    public abstract double Factor();
    public virtual int SchoolDays() => 200;
    public virtual double Result() => Factor() * SchoolDays(); 
}