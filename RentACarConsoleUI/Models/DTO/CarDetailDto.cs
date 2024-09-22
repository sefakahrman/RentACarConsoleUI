namespace RentACarConsoleUI.Models.DTO;

public record CarDetailDto(
    int Id,
    string FuelName,
    string TransmissionName,
    string ColorName,
    string CarState,
    int Kilometer,
    short ModelYear,
    string Plate,
    string BrandName,
    string ModelName,
    double DailtPrice
    );
