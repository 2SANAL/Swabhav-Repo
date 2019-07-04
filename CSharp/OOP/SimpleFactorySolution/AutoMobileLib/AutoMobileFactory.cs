
namespace AutoMobileLib
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _automobile;

        private AutoMobileFactory()
        {

        }

        public IAutoMobile Make(AutoType autoType)
        {
            if (autoType.Equals(AutoType.AUDI))
            {
                return new Audi();
            }
            if (autoType.Equals(AutoType.BMW))
            {
                return new BMW();
            }
            if (autoType.Equals(AutoType.TESLA))
            {
                return new Tesla();
            }
            return null;
        }

        public static AutoMobileFactory GetInstance()
        {
            if (_automobile == null)
            {
                _automobile = new AutoMobileFactory();
            }
            return _automobile;
        }
    }
}
