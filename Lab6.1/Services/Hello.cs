namespace Lab6._1.Services
{
    public class Hello : IHello
    {
        public string WelcomeUser()
        {
            int hour = DateTime.Now.Hour;
            string welcomeStr;

            switch (hour)
            {
                case int h when (h >= 0 && h <= 6):
                    welcomeStr = "Доброй ночи!";
                    break;
                case int h when (h > 6 && h < 12):
                    welcomeStr = "Доброе утро!";
                    break;
                case int h when (h >= 12 && h < 18):
                    welcomeStr = "Добрый день!";
                    break;
                default:
                    welcomeStr = "Добрый вечер!";
                    break;
            }
            return welcomeStr;
        }
    }
}
