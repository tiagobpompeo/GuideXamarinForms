using System;
namespace GuideXamarinForms.Models.AbstractClass
{
    public class Children:Father
    {
        public override void Call()
        {
            Console.WriteLine("Eu chamei");
        }
    }
}
