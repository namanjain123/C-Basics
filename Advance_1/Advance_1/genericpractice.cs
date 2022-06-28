namespace Advance_1
{
    //We will practice Generics
    class genericpractice<T>
    {
        private T data;
        public T value
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
