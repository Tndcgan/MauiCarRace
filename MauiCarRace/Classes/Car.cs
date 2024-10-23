using System;

namespace MauiCarRace.Classes;

public class Car
{
    public string Model ;
    public string Color;
    public double speed;
    public double Fuel;
    public double TotalMile;
    public double UseFuelRate; // xxx liter per Mile

    public Car(string model , double speed , double fuel )
    {
        this.Model = model;
        this.speed = speed;
        this.Fuel = fuel;
    }

    public void Run(double Mile)
    {
        //this.TotalMile = this.TotalMile + Mile;
        this.TotalMile += Mile;
        var use_fuel = Mile * this.UseFuelRate ;
        this.Fuel = this.Fuel - use_fuel;
    }

    public uint TimeUseForRun(double mile)
    {
        var timeuse = mile/speed;
        this.Run(mile);
        return Convert.ToUInt16(timeuse);
    }

    public string ShowInfo()
    {
        var info = $"Model : {this.Model } \nTotal Mile : { this.TotalMile } \nFuel {this.Fuel }";
        return info;
    }
}
