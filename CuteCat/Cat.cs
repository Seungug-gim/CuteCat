using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    // internal : 클래스 앞에 아무것도 안 써져있으면 internal 이 생략되어있음(기본)
    // internal 의 의미는 namespace CuteCat 안에서만 사용 가능
    // public 을 사용하면 밖에서 사용 가능

    public class Cat
    {
        // 클래스 만드는 법
        // private 와 public 의 차이
        // private : 숨김, 호출불가능
        // public : 보임, 호출가능
        private string Name;
        public int Age;

        public int Happiness = 60;

        // 생성자는 무조건 public, 생성자는 리턴이 없다
        public Cat(string name, int age)
        {
            //test
            this.Name = name;
            this.Age = age;
        }

        public void GetBored()
        {
            Happiness = Happiness - 10;

            if (Happiness < 0)
            {
                Happiness = 0;
            }    
        }

        public void Play()
        {
            Happiness = Happiness + 10;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public void Eat()
        {
            Happiness = Happiness + 20;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public string Express()
        {
            string message = "";

            if (Happiness >= 80)
            {
                message = "I'm very happy.";
            }
            else if (Happiness >= 60)
            {
                message = "I'm happy.";
            }
            else if (Happiness >= 40)
            {
                message = "I'm so so.";
            }
            else if (Happiness >= 20)
            {
                message = "I'm gloomy";
            }
            else
            {
                message = "I'm sad.";
            }

            return this.Name + ": " + message;
        }
    }
}
