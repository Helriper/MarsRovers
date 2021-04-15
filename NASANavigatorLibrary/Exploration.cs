using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NASANavigatorLibrary.Enums;
using NASANavigatorLibrary.Common;

namespace NASANavigatorLibrary
{
    public class Exploration
    {
        private Grid _Grid;
        private List<Rover> _Rovers = new List<Rover>();

        public List<Rover> Rovers { get => _Rovers; set => _Rovers = value; }
        public Grid Grid { get => _Grid; set => _Grid = value; }

        public Exploration(List<UserInput> userInputs)
        {
            foreach (UserInput i in userInputs)
            {
                switch (i.CurrentType)
                {
                    case InputType.GridBounds:
                        _Grid =  new Grid(short.Parse(i.InputValue[0].ToString()), short.Parse(i.InputValue[2].ToString()));
                        break;

                    case InputType.RoverPosition:
                        _Rovers.Add(new Rover(new Position(i.InputValue)));
                        break;

                    case InputType.MoveInstructions:
                        if (_Rovers.Count > 0) { 
                            foreach (char a in i.InputValue)
                            {
                                _Rovers[_Rovers.Count - 1].Instructions.Add(Convertor.ConvertToActionType(a));
                            }
                        }
                        break;
                }
            }
        }

       
    }
}
