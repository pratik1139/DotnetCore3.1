using System;
public  class SingleTon
{
    private SingleTon()
    {

    }
    private static object mutex=new object();
    private static SingleTon _instance;
    public int a=10;
    public static  SingleTon Instance { 
        get
        {
            lock(mutex)
            {
            if(_instance==null)
            {
                _instance=new SingleTon();
            }
            return _instance;
            }
        }    
    }

    public int Getdata()
    {
        return a;
    }
}

