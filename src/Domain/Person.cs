using System;

namespace Domain
{
    public class Person
    {
        private string name = "Benjamin";

        public void SayHello(){
            System.Console.WriteLine("Hello " + name);
        }
    }
}
