using System;

namespace programm {
    
    class newapp {
        
        private float a = 49;
        private float b = 15;
        
        public float c1 {
            get {return a*=b;}
            
        }
        public float c2 {
            get {return a=++b;}
        }
        public float c3 {
            get {return a/b;}
        }
        
    }
    
    class program {
        
        static void Main (string[] args) {
        newapp pop = new newapp();
        
        Console.WriteLine(pop.c1);
        Console.WriteLine(pop.c2);
        Console.WriteLine(pop.c3);
        Console.ReadKey();

    }
    
    }
  
}
