using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NASANavigatorLibrary.Enums;

namespace NASANavigatorLibrary.Common
{
    public static class Convertor
    {
        private static readonly Dictionary<char, ActionType> ActionTypes = new Dictionary<char, ActionType> { { 'M', ActionType.Move},  { 'L', ActionType.Left}, { 'R', ActionType.Right } };
        public static ActionType ConvertToActionType(char action) {

            return ActionTypes[action];
        }
    }


}
