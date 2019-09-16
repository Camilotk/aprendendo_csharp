using System;

namespace SetsTest.SortedSet
{
    public class MySortedSet<T> where T : IComparable
    {
        private RedBlackTree<T> _elements { get; set; }

        public MySortedSet () => _elements = new RedBlackTree<T>();

        public int Count()
        {
            return Convert.ToInt32(_elements.numberOfElements);
        }

        public bool Add(T item)
        {
            try 
            {
                _elements.Add(item);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool Remove(T item)
        {
            try
            {
                _elements.Remove(item);
                return true;
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
