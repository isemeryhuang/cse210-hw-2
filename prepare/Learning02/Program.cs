using System;
    public class Person
    {
            public string _givenName = "";
            public string _familyName = "";
            public Person()
            {
            }
            public void ShowEasternName()
            {
                Console.WriteLine($"{_familyName}, {_givenName}");
            }
            public void ShowWesternName()
            {
                Console.WriteLine($"{_givenName},{_familyName}");
            }

    }