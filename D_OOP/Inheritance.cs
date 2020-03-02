using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect() {
            Console.WriteLine("General Connected Protocol");
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id)
        {
        }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("Additional action for X");
        }
    }
    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)
        {
        }
        public override void Connect()
        {
            Console.WriteLine("Additional action");
        }
    }
}
