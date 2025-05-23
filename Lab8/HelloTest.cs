using Lab6._1.Services;

namespace Lab8
{
    //  There is nothing more to test
    public class HelloClassTest
    {
        [Fact]
        public void DummyTest()
        {
            IHello hello = new Hello();

            int h = DateTime.Now.Hour;
            string helloStr = hello.WelcomeUser();

            if (h >= 0 && h <= 6) Assert.Equal("Доброй ночи!", helloStr);
            else if (h > 6 && h < 12) Assert.Equal("Доброе утро!", helloStr);
            else if (h >= 12 && h < 18) Assert.Equal("Добрый день!", helloStr);
            else if (h >= 18 && h < 24) Assert.Equal("Добрый вечер!", helloStr);

        }
    }
}
