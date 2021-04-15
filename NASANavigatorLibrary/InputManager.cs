using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NASANavigatorLibrary.Enums;
using NASANavigatorLibrary.Common;

namespace NASANavigatorLibrary
{
    public class InputManager
    {
        private List<UserInput> _userInputs = new List<UserInput>();
        public List<UserInput> UserInputs { get => _userInputs;}

        public List<UserInput> SetInputs(List<string> inputs)
        {
            inputs.ForEach(x => ValidateInput(x));

            return _userInputs;
        }

        public void ValidateInput(string input) {

            int value;
            if (input.Length == 3 && int.TryParse(input[0].ToString(), out value) && int.TryParse(input[2].ToString(), out value))
            {
                _userInputs.Add(new UserInput { CurrentType = InputType.GridBounds, InputValue = input });
                return;
            }

            string cardinals = "NSEW";
            if (input.Length == 5 && int.TryParse(input[0].ToString(), out value) && int.TryParse(input[2].ToString(), out value) && cardinals.Contains(input[4]))
            {
                _userInputs.Add(new UserInput { CurrentType = InputType.RoverPosition, InputValue = input });
                return;
            }

            string moves = "LRM";
            if (input.Length > 0 && !input.Any(c => !moves.Contains(c)))
            {
                _userInputs.Add(new UserInput { CurrentType = InputType.MoveInstructions, InputValue = input });
                return;
            }

            _userInputs.Add(new UserInput { CurrentType = InputType.InvalidType, InputValue = input });
        }

       
    }

    
}
