using System;

class MainClass {
  public static void Main (string[] args) {

    double average_speed = 0;
    int car_num = 1;
    Console.WriteLine ("Enter the number of cars to average the speed:");
    var entry = Console.ReadLine();
    double cars_needed = Convert.ToDouble(entry);
    int counter = 0;
    while (counter < cars_needed)
    {
        Console.WriteLine ("Enter the distance covered by car #" + car_num);
        var distance = Console.ReadLine();
        double distance_covered = Convert.ToDouble(distance);

        Console.WriteLine ("Enter the time taken by car #" + car_num);
        var time = Console.ReadLine();
        double time_taken = Convert.ToDouble(time);

        double car_speed = (distance_covered/time_taken);

        Console.WriteLine ("The speed of this car is " + (car_speed));

        car_num =  car_num+1;

        average_speed = (average_speed + car_speed);

        counter = counter + 1;
    }
  double speed = (average_speed/counter);
  Console.WriteLine("The average speed of the cars is " + speed);
  }
}