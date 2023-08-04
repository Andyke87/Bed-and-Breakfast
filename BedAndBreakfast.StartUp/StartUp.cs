using BedAndBreakfast.Domain;
using BedAndBreakfast.Cui;
namespace BedAndBreakfast.StartUp
{
    class Startup
    {
        static void Main(string[] args)
        {
            BedAndBreakfastApp cui = new();
            cui.Start();
        }
    }
}