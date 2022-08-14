namespace CAAbstractVsInteface
{
    public interface IVehicle
    {
        void Go();
        void Stop();
    }

    public interface IRideable
    {
        void Ride();
    }

    public interface IFlyable
    {
        void Soar();
    }

    public class Car : BaseVehicle
    {
     
    }

    public class Bike : BaseVehicle, IRideable
    {
     

        public void Ride()
        {
            throw new NotImplementedException();
        }

    }

    public class Plane : BaseVehicle,IFlyable
    {

        public void Soar()
        {
            throw new NotImplementedException();
        }

    }

    public abstract class BaseVehicle : IVehicle
    {
        public  void Go()
        {
            Console.WriteLine("go");
        }
        public  void Stop()
        {
            Console.WriteLine("stop");

        }
    }
}
