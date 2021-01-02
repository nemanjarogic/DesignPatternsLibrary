using System;

namespace PrototypeLibrary.LogicPuzzleExample
{
    public class LogicPuzzle : ICloneable
    {
        private int _blueSwitchCharge;
        private int _redSwitchCharge;
        private bool _smallToggle;
        private bool _bigToggle;
        private bool _doorOpen;
        private bool _slatLocked;
        private int _moveCount;

        public void SwitchBlueSwitch()
        {
            if (_smallToggle)
            {
                _blueSwitchCharge++;
            }

            _bigToggle = !_bigToggle;
            _moveCount++;
        }

        public void SwitchRedSwitch()
        {
            if (!_smallToggle && _blueSwitchCharge < 3)
            {
                _doorOpen = true;
                _blueSwitchCharge = 0;
            }
            else
            {
                _redSwitchCharge++;
                _slatLocked = true;
                _smallToggle = !_smallToggle;
            }

            _moveCount++;
        }

        public void ToggleBigToggle()
        {
            if (_doorOpen)
            {
                _doorOpen = false;
            }

            _slatLocked = false;
            _redSwitchCharge = 0;
            _moveCount++;
        }

        public void ToggleSmallToggle()
        {
            if (_blueSwitchCharge < 3 || _redSwitchCharge > 5)
            {
                _slatLocked = false;
                _doorOpen = true;
            }

            _moveCount++;
        }

        public void PrintState()
        {
            Console.WriteLine($"Blue switch charge: {_blueSwitchCharge}");
            Console.WriteLine($"Red switch charge: {_redSwitchCharge}");
            Console.WriteLine($"Small toggle: {_smallToggle}");
            Console.WriteLine($"Big toggle: {_bigToggle}");
            Console.WriteLine($"Door open: {_doorOpen}");
            Console.WriteLine($"Slat locked: {_slatLocked}");
            Console.WriteLine($"Move count: {_moveCount}");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
