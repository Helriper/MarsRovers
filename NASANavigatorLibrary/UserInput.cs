using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NASANavigatorLibrary.Enums;

namespace NASANavigatorLibrary
{
    public class UserInput
    {
        private InputType _InputType;
        private String _InputValue;

        public InputType CurrentType { get => _InputType; set => _InputType = value; }
        public string InputValue { get => _InputValue; set => _InputValue = value; }

        public UserInput() {


        }

    }
}
