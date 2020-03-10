using System;

namespace ClassIntro
{
  public class Car
  {
    // Anthing you make private make it a field
    // Fields
    private int _milesDriven;

    // Properties
    // Properties have get; set; and are typically public
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool NeedsMaintenance { get; set; } = false;
    public bool isClean { get; set; } = false;

    // Computed Property
    // It's a readonly property cannot be set
    public string Description
    {
      get
      {
        return $"{Year} {Make} {Model}";
      }
    }

    // Methods
    public void Drive(int miles)
    {
      _milesDriven += miles;

      if (_milesDriven > 10000)
      {
        NeedsMaintenance = true;
      }
    }

    public void Service()
    {
      NeedsMaintenance = false;
    }

    // Method overloading
    // Shares a method name. but has different arguments
    public void Service(bool addCleanService)
    {
      NeedsMaintenance = false;

      if (addCleanService)
      {
        isClean = addCleanService;
      }
    }

    // This is a Constructor. It doesn't have a return type and the name of the method is the same as the name of the class
    public Car(int milesDriven)
    {
      _milesDriven = milesDriven;
    }

    public Car(int milesDriven, string make, string model, int year)
    {
      _milesDriven = milesDriven;
      Make = make;
      Model = model;
      Year = year;
    }
  }
}