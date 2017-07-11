using System;
using System.Collections.Generic;

namespace API
{
    public class API
    {
        private API instance;
        private API ()
        {

        }

        public API GetInstance()
        {
            if (instance == null)
            {
                API instance = new API();
            }

            return instance;
        }

        public static void Read()
        {
            
        }

        public static void Write()
        {
            
        }
    }
}
