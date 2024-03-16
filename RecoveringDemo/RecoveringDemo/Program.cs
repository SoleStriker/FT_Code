using System;
using static System.Console;
using System.Globalization;
class RecoveringDemo
{
    static void Main()
    {
        // Write your code here
        Patient patient = new Patient();
        Upholsterer upholsterer = new Upholsterer();
        FootballPlayer footballPlayer = new FootballPlayer();
        
        WriteLine("Patient: ");
        patient.Recover();
        
        WriteLine("Upholsterer: ");
        upholsterer.Recover();
        
        WriteLine("Football Player: ");
        footballPlayer.Recover();
    }
}

interface IRecoverable
{
    public void Recover();
}

class Patient : IRecoverable
{
    public void Recover()
    {
        WriteLine("I am getting better.");
    }
}

class Upholsterer : IRecoverable
{
    public void Recover()
    {
        WriteLine("I have new material for the couch.");
    }
}

class FootballPlayer : IRecoverable
{
    public void Recover()
    {
        WriteLine("I picked up the ball after a fumble.");
    }
}


