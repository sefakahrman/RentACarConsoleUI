

using RentACarConsoleUI.Models;

namespace RentACarConsoleUI.Data;

public class CarData
{
    List<Car> Cars = new List<Car>
    {
     new Car(1,1,1,1,"İKİNCİ EL",89000,2018,"34KFL28","HONDA","KLC12",628.569),
     new Car(2,2,2,2,"İKİNCİ EL",12000,20123,"34LFL28","SUZUKI","MM43",1052.000),
     new Car(1,1,1,1,"SIFIR",0,2024,"34HTK75","SKODA","MCT6",1.700000)
    };

    
    public Car GetById(int id)
    {
        Car? cars = null;
        foreach (Car item in Cars)
        {
            if (item.Id == id)
            {
                cars = item;
                break;
            }
        }
        return cars;
    }

    public Car Delete(int id)
    {
        Car? cars = GetById(id);

        if (cars is not null)
        {
            Cars.Remove(cars);
        }

        return cars;
    }

    public List<Car> GetAll()
    {
        return Cars;
    }

    /*
     * CarRepository, FuelRepository,
    TransmissionRepository,ColorRepository ve Servislerini
    oluşturunuz.
    ● Bütün Repository classlarda GetById, GetAll,
    Update,Delete,Add metodları olmalıdır
    ● CarService ve Repository classlarında CarDetailDto türünde
    bazı işlemler yapmanız belenmektedir.
     */
}


