using System;

namespace NumberSystemConverter
{
    public class NumberSystemConverter_
    {
        public string ConvertNumber(int number)
        {
            if(number > 3000 || number < 1){
                throw new IndexOutOfRangeException();
            }  
            switch(number)
            {
                case 1:
                {
                    return "I";
                }
                case 2:
                {
                    return "II";
                }
            }
            throw new NotImplementedException();
        }
    }
}
