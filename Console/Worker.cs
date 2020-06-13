using System;
namespace StarterProgram
{
    // public  delegate void AddNumbersHandler(object sender,AddNumbersEventArgs eventArgs);  
    public class Worker
    {
        public event EventHandler<AddNumbersEventArgs> AddNumbers;
        public event EventHandler WorkCompleted;
        public void DoWork(int a ,int b)
        {
            for(int i=0;i<3;i++){
                System.Threading.Thread.Sleep(1000);
                OnAddNumbers(a,b);
            }

            OnWorkCompleted();

        }  

        public void OnAddNumbers(int a, int b)
        {
            var del=AddNumbers as EventHandler<AddNumbersEventArgs>;
            if(del!=null)
            {
                del(this,new AddNumbersEventArgs(a,b));
            }
        }

        public void OnWorkCompleted()
        {
          var del=WorkCompleted as EventHandler;
            if(del!=null)
            {
                del(this,EventArgs.Empty);
            }  
        }
    }

    
    public class AddNumbersEventArgs:System.EventArgs
    {
        public int A { get; set; }     
        public int B { get; set; }  
        public AddNumbersEventArgs(int a,int b)
        {
            A=a;
            B=b;
        }   
    }
}