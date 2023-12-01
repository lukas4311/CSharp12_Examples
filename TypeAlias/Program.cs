// See https://aka.ms/new-console-template for more information

using GeoLocation = (int lat, int lng);



Console.WriteLine("Hello, World!");

class DistanceCalculator(GeoLocation currentLocation)
{
    public int CalculateDistance(GeoLocation desination)
    {
        int distance = CalculateDistanceAlgo(currentLocation, desination);
        return distance;
    }

    private int CalculateDistanceAlgo((int lat, int lng) currentLocation, (int lat, int lng) desination) => throw new NotImplementedException();
}