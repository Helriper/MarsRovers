using System;
using System.Collections.Generic;
using NASANavigatorLibrary;
using NASANavigatorLibrary.Enums;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            InputManager manager = new InputManager();

            List<string> inputs = new List<string>();
            string line = string.Empty;

            Console.WriteLine("New exploration");

            do
            {
                line = Console.ReadLine();

                if(line.Trim() != string.Empty)
                {
                    inputs.Add(line.ToUpper());
                }
                else
                {
                    break;
                }


            } while (line.Trim() != string.Empty);

            List<UserInput> userInputs = manager.SetInputs(inputs);
            Exploration exploration = new Exploration(userInputs);

            if (exploration.Rovers.Count > 0)
            {

                RoverController roverController = new RoverController(exploration);
                roverController.ExecuteInstructions();

                foreach (Rover rover in exploration.Rovers)
                {
                    if (exploration.Grid.X < rover.CurrentPosition.X || exploration.Grid.Y < rover.CurrentPosition.Y || rover.CurrentPosition.X < 0 || rover.CurrentPosition.Y < 0)
                    {
                        Console.WriteLine("Rover location unknown!");

                    }
                    else { 
                        Console.WriteLine($"{rover.CurrentPosition.X} {rover.CurrentPosition.Y} {rover.CurrentPosition.Z}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Rovers ready!!");
            }


            if (exploration.Rovers.Count > 0) { 
                
            }
           

        }
    }
}
