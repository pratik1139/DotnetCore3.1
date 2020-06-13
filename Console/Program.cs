using System;

namespace StarterProgram {

   // public  delegate void AddNumbersHandler(int a,int b);  
    
    class Program {
        static int  numb=0;
        static void Main (string[] args) {
            
            Console.WriteLine("Hello World!");
          //  string a= Console.ReadLine();
            var work =new Worker();
            
           // work.AddNumbers+=new EventHandler<AddNumbersEventArgs>(PerformOperation);
           // work.WorkCompleted+=new EventHandler(WorkCompleted);
          
           //above is long form
        
            // Using delegate inference
           //work.AddNumbers+=PerformOperation;//compiler generates above statments behin
           //work.WorkCompleted+=WorkPerfromed;

           // Using anonymous methods
           work.AddNumbers+=delegate(object sender,AddNumbersEventArgs e)
           {
               Console.WriteLine(" hello  i am   {0}, {1} " , e.A,e.B);
           };
           work.WorkCompleted+=delegate(object sender,EventArgs e)
           {
               Console.WriteLine("Work is completed");
           };
            work.DoWork(3,4);

         }

        //   static void PerformOperation(object sender,AddNumbersEventArgs e)
        //   {
        //       Console.WriteLine(" hello  i am   {0}, {1} " , e.A,e.B);
        //   }  

        // static void WorkPerfromed(object sender,EventArgs e)
        // {
        //             Console.WriteLine("Work is completed");
        // }  
          
          
        // static void Substract(int a,int b)
        //  {
        //      numb=a-b;
        //      Console.WriteLine(numb);
        //  }
        //  static void Add(int a,int b)
        //  {
        //      numb=a+b;
        //      Console.WriteLine(numb);
        //  }

        //  static void Multiply(int a,int b)
        //  {
        //      numb=a*b;
        //      Console.WriteLine(numb);
        //  }
    }


}