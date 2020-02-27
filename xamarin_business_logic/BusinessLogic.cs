using System;

namespace xamarin_business_logic
{
    public class BusinessLogic
    {
        public static string getImage(bool toggle)
        {
            if (toggle)
            {
                return "lightOn.png";
            }
            else
            {
                return "lightOff.png";
            }
        }

        public static string getRoom()
        {
            return "Living Room";
        }
    }
}
