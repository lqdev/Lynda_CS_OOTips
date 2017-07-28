using System;

namespace ConsoleApplication
{
    class PowerController : IPowerOn
    {
        public bool isOn { get ; private set ;}

        protected void TurnOn() {
            isOn = true;
        }

        protected void TurnOff() {
            isOn = false;
        }

        public virtual void TogglePower() {
            if(isOn)
            {
                TurnOff();
            } else 
            {
                TurnOn();
            }
        }        
    }
}