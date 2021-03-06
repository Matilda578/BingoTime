﻿using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ahrg
{
    class Program
    {
        public static void Main(string[] args)
        {
            var isOpen = true;

            System.Console.Write("Please input a number to be the upper limit for the Bingo draw:");
            var Uplimit = Console.ReadLine();
            var upperlimit = 0;

            var valid = false;
            while (valid == false)
            {
                try
                {
                    upperlimit = int.Parse(Uplimit);
                    if (upperlimit < 1)
                    {
                        throw new Exception();
                    }
                    valid = true;
                }
                catch
                {
                    System.Console.Write("Please enter a number:  ");

                    Uplimit = Console.ReadLine();
                }
            }




                List<int> numberList = new List<int>();


                while (isOpen)
                {

                    var menuselec = Menu();

                    if (menuselec == 1)
                    {
                        if (numberList.Count >= upperlimit)
                        {
                            Console.WriteLine("You have reached the maximum number!");
                        }
                        else //if (numberList.Count < upperlimit)
                        {
                            var numbergen = new Random();
                            var banan = numbergen.Next(1, upperlimit + 1);

                            while (numberList.Contains(banan) == true)
                            {
                                banan = numbergen.Next(1, upperlimit + 1);
                            }
                            numberList.Add(banan);
                            Console.WriteLine("The number drawn was: " + banan);

                            // if (numberList.Contains(banan) == false)
                            // {

                            //     numberList.Add(banan);
                            //     Console.WriteLine("The number drawn was: " + banan);
                            // }
                            // else{
                            //     System.Console.WriteLine("The number drawn was a duplicate");

                            // }
                            continue;
                        }
                    }
                    if (menuselec == 2)
                    {
                        Console.WriteLine("Press 1 to see all numbers");
                        Console.WriteLine("Press 2 to see all numbers in numerical order");
                        var selection = Console.ReadLine();
                        var selectedlist = int.Parse(selection);
                        if (selectedlist == 1)
                        {
                            Console.Write("Previously drawn numbers: ");
                            foreach (int i in numberList)

                                Console.Write(i + ", ");
                        }
                        else if (selectedlist == 2)
                        {
                            List<int> sortedNumbers = numberList.OrderBy(number => number).ToList();
                            foreach (int number in sortedNumbers)
                                Console.WriteLine(number);

                        }

                    }


                    else if (menuselec == 3)
                    {

                        System.Console.Write("Please input a number to check: ");
                        var usercheckpls = Console.ReadLine();
                        var userCheckingNum = int.Parse(usercheckpls);
                        {
                            if (numberList.Contains(userCheckingNum) == true)
                            {
                                Console.WriteLine("This number had been drawn!");
                            }
                            else
                            {
                                Console.WriteLine("This number has not been drawn");
                            }
                        }
                    }

                    else if (menuselec == 4)
                    {
                        isOpen = false;
                    }



                }
            }

            static int Menu()
            {
                System.Console.WriteLine("Welcome to the Swinburne Bingo Club");
                System.Console.WriteLine("1. Draw next number");
                System.Console.WriteLine("2. View all drawn numbers");
                System.Console.WriteLine("3. Check specific number");
                System.Console.WriteLine("4. Exit");


                var input = Console.ReadLine();
                int inputNum = 45;
                var valid = false;
                while (valid == false)
                {
                    try
                    {
                        inputNum = int.Parse(input);
                        if (inputNum > 4 || inputNum < 1)
                        {
                            throw new Exception();
                        }
                        valid = true;
                    }
                    catch
                    {
                        System.Console.WriteLine("Please enter a number between 1-4");

                        input = Console.ReadLine();
                    }


                }


                // var inputNum = int.Parse(input);
                return inputNum;


            }
        }
    }





