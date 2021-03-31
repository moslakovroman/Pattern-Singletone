using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{ 
    class SingletonClass1
    {
        private SingletonClass1() { }

        private static SingletonClass1 _singletonInstanse;

        public static SingletonClass1 SingletonGetInstanse()
        {
            if (_singletonInstanse == null)
            {
                _singletonInstanse = new SingletonClass1();
            }
            return _singletonInstanse;
        }

        public static void OtherMethod()
        {

        }
    }
}
