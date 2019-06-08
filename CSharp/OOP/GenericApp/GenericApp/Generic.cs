
namespace GenericApp
{
    class Generic<T>
    {
        private T data;
        public T Value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
                
        }
        
    }
}
