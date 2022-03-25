// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string firstName;
        int age;

        Console.WriteLine("This program gets a user's address.");
        Console.WriteLine("");

        Console.Write("Enter your street name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter your street number: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + age + " " + firstName + ".");

        Console.WriteLine("\nDone.");
    }
}