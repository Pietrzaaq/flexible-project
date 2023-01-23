namespace FlexibleProject.Api.Entities;

public record Location(
    Street Street,
    string City,
    string State,
    string Country,
    int Postcode,
    Coordinates Coordinates,
    Timezone Timezone);