using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NASANavigatorLibrary.Enums;
using NASANavigatorLibrary.Common;

namespace NASANavigatorLibrary
{
    public class RoverController
    {
        private Exploration _exploration;

        public RoverController(Exploration exploration)
        {
            _exploration = exploration;
        }

        public void ExecuteInstructions()
        {
            foreach (Rover r in _exploration.Rovers)
            {
                foreach (ActionType i in r.Instructions)
                {
                    switch (i)
                    {
                        case ActionType.Move:
                            r.Move();
                            break;
                        case ActionType.Left:
                            r.Left();
                            break;
                        case ActionType.Right:
                            r.Right();
                            break;
                    }
                }
            }
        }

    }

}
