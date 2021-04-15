using System;
using System.Collections.Generic;
using NASANavigatorLibrary.Enums;

namespace NASANavigatorLibrary
{
    public class Rover
    {
        private Position _Position;
        private List<ActionType> _Instructions = new List<ActionType>();

        public Position CurrentPosition { get => _Position; }
        public List<ActionType> Instructions { get => _Instructions; set => _Instructions = value; }

        public Rover(Position position)
        {
            _Position = position;
        }

        public void Right()
        {
            switch (_Position.Z)
            {
                case "N":
                    _Position.Z = "E";
                    break;

                case "E":
                    _Position.Z = "S";
                    break;
                case "S":
                    _Position.Z = "W";
                    break;
                case "W":
                    _Position.Z = "N";
                    break;
                default:
                    break;
            }
        }

        public void Left()
        {
            switch (_Position.Z)
            {
                case "N":
                    _Position.Z = "W";
                    break;

                case "E":
                    _Position.Z = "N";
                    break;
                case "S":
                    _Position.Z = "E";
                    break;
                case "W":
                    _Position.Z = "S";
                    break;
                default:
                    break;
            }
        }

        public void Move()
        {
            switch (_Position.Z)
            {
                case "N":
                    _Position.Y++;
                    break;

                case "E":
                    _Position.X++;
                    break;
                case "S":
                    _Position.Y--;
                    break;
                case "W":
                    _Position.X--;
                    break;
                default:
                    break;
            }

        }


    }

   
}
