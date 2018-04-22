

namespace FacadeStructuralPattern
{
    public class Facade
    {
        public void DoSomething()
        {
            Library1.Class1 a = new Library1.Class1();
            Library2.Class2 b = new Library2.Class2();
            Library3.Class3 c = new Library3.Class3();

            a.DoTask1();
            b.DoTask2();
            c.DoTask3();
        }
    }
}
