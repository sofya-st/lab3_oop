


class Object
{

    int x;
    int y;
    virtual public void show_param()
    {
        Console.WriteLine("element not found");
    }

    virtual public void dispPoint(int dx, int dy)
    {
        x = x + dx;
        y = y + dy;
    }
    ~Object()
    {

    }


}


class Animal: Object
{
    string sound;
    public Animal() : base()
    {
        sound = "";
    }
    public Animal(string sound) 
    {
        this.sound = sound;
    }
    override public void show_param()
    {
        Console.WriteLine("this is animal");
        Console.WriteLine(sound);
    }

    ~Animal()
    {

    }
}

class Point: Object
{ 
    int x;
    int y;

    public Point() : base()
    {
        x = 0;      
        y = 0;
    }
    public Point(int x, int y) 
    {
        this.x = x; 
        this.y = y;
    }
    override public void show_param() 
    {
        Console.WriteLine("this is point");
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
   override public void dispPoint(int dx, int dy) 
    {
        x = x + dx;
        y = y + dy;
    }
    ~Point()
    {

    }
}

class MyStorage
{
    Object[] arr;
    int size;

    public MyStorage()
    {
        size = 0;
        arr = new Object[size];
    }

    public MyStorage(int size)
    {
        this.size = size;
        arr = new Object[size];
    }

   private void resize(int newsize)
    {
        Object[] tmpArr = new Object[size];
        for(int i = 0; i < size; i++)
        {
            tmpArr[i] = arr[i];
        }
        arr = new Object[newsize];
        for (int i = 0; i < size; i++)
        {
            arr[i] = tmpArr[i];
        }
        size = newsize;
    }

    public void addObj(Object Obj)
    {
        int i;
        for(i = 0; i < size; i++)
        {
            if(arr[i] == null) {
                arr[i] = Obj; 
                break; 
            }
        }
        if (i == size)
        {
            resize(size + 10);
            setObj(i + 1, Obj);
        }

    }

    public void setObj(int pl, Object Obj)
    {
        arr[pl] = Obj;
    }

    public Object getObj(int pl)
    {
        if (arr[pl] != null)
        {
            return arr[pl];
        } else { return null; }
    }

    public int getSize()
    {
        return size;
    }

    public void deleteObg(int pl)
    {
        arr[pl] = null;
    }

    public Object popObj(int pl)
    {
        Object tmp = arr[pl];
        arr[pl] = new Object();
        return tmp;
    }

    public int findObj(Object Obj)
    {
        for (int i = 0;i < size;i++)
        {
            if (arr[i] == Obj)
            {
                return i;
            }
        }
        return -1;
    }
}


class Program 
{
    static void Main(string[] args)
    {
 
        MyStorage mySt = new MyStorage();
        Console.WriteLine(mySt.getSize());
        mySt.addObj(new Point(1, 2));
        Animal myAnimal = new Animal("fff");
        Console.WriteLine(mySt.findObj(myAnimal));
        Console.WriteLine(mySt.getSize());

        Console.ReadKey();

    }
    

   }










