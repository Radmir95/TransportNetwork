
namespace TransportNetwork.WebFormsApplication.Helpers
{
    public static class DistanceBetweenCities
    {

        public static int GetDistance(string startPoint, string endPoint)
        {
            if (startPoint == "Казань" && endPoint == "Москва")
            {
                return 719;
            }
            if (startPoint == "Казань" && endPoint == "Чебоксары")
            {
                return 122;
            }
            if (startPoint == "Казань" && endPoint == "Альметьевск")
            {
                return 225;
            }
            if (startPoint == "Казань" && endPoint == "УФА")
            {
                return 451;
            }
            if (startPoint == "Казань" && endPoint == "Набережные челны")
            {
                return 206;
            }
            if (startPoint == "Казань" && endPoint == "Саратов")
            {
                return 516;
            }
            if (startPoint == "Казань" && endPoint == "Набережные челны")
            {
                return 1201;
            }
            return 200;
        }

    }
}
