
namespace ObjectCalisthenicsOnlyOneLevelApp
{
    class OnlyOneLevel

    {
        private int[] _data;
        private bool flag = true;
        private int temp;
        private int dataLength;
        private int index;

        public OnlyOneLevel(int[] data)
        {
            _data = data;
        }

        public void Bublesort()
        {
            dataLength = _data.Length;


            for (int i = 1; (i <= (dataLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (dataLength - 1); j++)
                {
                    if (_data[j + 1] > _data[j])
                    {
                        temp = _data[j];
                        _data[j] = _data[j + 1];
                        _data[j + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        public int[] getdata()
        {
            return _data;
        }

        public void OnlyOneLevelBubbleSor1()
        {
            dataLength = _data.Length;
            for (index = 1; (index <= (dataLength - 1)) && flag; index++)
            {
                flag = false;
                OnlyOneLevelBubbleSor2();

            }

        }
        public void OnlyOneLevelBubbleSor2()
        {

            for (int columnIndex = 0; columnIndex < (dataLength - 1); columnIndex++)
            {
                if (_data[columnIndex + 1] > _data[columnIndex])
                {
                    temp = _data[columnIndex];
                    _data[columnIndex] = _data[columnIndex + 1];
                    _data[columnIndex + 1] = temp;
                    flag = true;
                }
            }
        }
    }
}
