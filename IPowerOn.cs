using System;

namespace ConsoleApplication
{
    interface IPowerOn
    {
        bool isOn { get; }
        void TogglePower();
    }
}