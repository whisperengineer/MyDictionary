using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler= new MyDictionary<int, string>();
            sehirler.Add(1, "Adana");
            sehirler.Add(1, "Adıyaman");
            Console.WriteLine(sehirler.Count);
        }
    }
        
    class MyDictionary<T, A>
    {   
        T[] _keys, _tempKeys;
        A[] _value, _tempValue;
       
        
        public MyDictionary()
        {  //arraylerimize eleman atadık
            _keys = new T[0];
            _value = new A[0];
        }
        public void Add(T item, A item1)
        {   // arraylere ekleme yaparken new yapacağımız için elemanları başka bir array de tuttuk
            _tempKeys = _keys;
            _tempValue = _value;

            // şimdi yeni eleman için yer oluşturacağız
            _keys = new T[_keys.Length + 1];
            _value = new A[_value.Length + 1];

            // for ile eski elemanları  atadık
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _value[i] = _tempValue[i];

            }
            _keys[_keys.Length - 1] = item;
            _value[_value.Length - 1] = item1;
        }
        private int _count;

        public int Count
        {
            get { return _keys.Length; }

        }


    }
}