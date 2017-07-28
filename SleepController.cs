using System;

namespace ConsoleApplication
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; private set; }

        public void ToggleSleep ()
        {
            isSleeping = !isSleeping;
        }
    }
}