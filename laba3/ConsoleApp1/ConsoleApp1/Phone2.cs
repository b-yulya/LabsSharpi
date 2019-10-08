namespace ConsoleApp1
{
    partial class Phone
    {
        public override string ToString()
        {
            return $"Модель телефона {Name} с номером банковской карты {Number}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
