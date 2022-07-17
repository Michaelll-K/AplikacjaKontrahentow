using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKontrahentów.Tools
{
    internal class BoxedValues
    {
        public bool CheckIfCorrect(string name, string nip, int type, string description)
        {
            var nameLenght = name.Length;
            var nipLength = nip.Length;
            var typeSet = type;
            var descriptionLength = description.Length;

            if (nameLenght != 0 &&
                nameLenght <= 50 &&
                nipLength == 10 &&
                typeSet != -1 &&
                descriptionLength != 0 &&
                descriptionLength <= 500)
            {
                return true;
            }

            return false;
        }
    }
}
