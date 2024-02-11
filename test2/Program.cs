using System;
using vehicle;
using person;

class Program {

    static void Main(string[] args) {
        Console.WriteLine("Hello WOrld");

        // Car car = new Car();
        // Console.WriteLine(car.color);

        // Person person = new Person(pid: "#0001", fName: "Sudipto", lName: "Shahin");
        // person.showData();

        // Person person2 = new Person(pid: "#0002", "adsass", "hello");
        // person2.showData();
        // Console.WriteLine("fname: "+person2.FirstName);
        // person2.FirstName = "John";
        // Console.WriteLine("updated fname: " +person2.FirstName);
        // person2.showData();

        Car car1 = new Car("Ford", 1);
        car1.show();

        Car car2 = new Car("BMW", "black", 2);
        car2.show();

    }
}