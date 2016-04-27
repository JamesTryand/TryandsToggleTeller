namespace ToggleMonkey
{
    public class ArbitaryBadger
    {
        public ArbitaryBadger()
        {

        }

        public void Wibble() { }

        public int WhatBeMe()
        {
            return 19;
        }
    }
    public class ArbitaryGoat
    {
        private readonly IFeatureToggle _toggle;
        private int _classIterator;

        public ArbitaryGoat(IFeatureToggle toggle, int classIterator)
        {
            _toggle = toggle;
            _classIterator = classIterator;
        }

        public void Katonk()
        {
            if (_toggle.IsFeatureEnabled("MostCertainlyNotABug"))
            {
                DoSomethingElse();
            }

        }

        public int WhatAreIsI()
        {
            return _classIterator;
        }

        private int DoSomethingElse()
        {
            return _classIterator + 3;
        }
    }
}