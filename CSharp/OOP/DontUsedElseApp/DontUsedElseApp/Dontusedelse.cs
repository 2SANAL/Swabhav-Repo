
namespace DontUsedElseApp
{
    class Dontusedelse
    {
        private int _boye1;
        private int _boye2;
        
        private static int _greator=0;

        public Dontusedelse(int boye1, int boye2)
        {
            _boye1 = boye1;
            _boye2 = boye2;
           
        }

        public void GreaterAge()
        {
            if (_boye1 > _boye2 )
            {
                _greator = _boye1;
                
            }
            else 
            {
                _greator = _boye2;
            }

        }

        public void withoutelse()
        {
            if(_boye1 > _boye2)
            {
                _greator = _boye1;
            }
            _greator = _boye2;

        }

        public int greator()
        {
            return _greator;
        }
    }
}
