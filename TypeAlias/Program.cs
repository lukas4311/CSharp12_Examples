// See https://aka.ms/new-console-template for more information

using GeoLocation = (int lat, int lng);



Console.WriteLine("Hello, World!");

class DistanceCalculator(GeoLocation currentLocation)
{
    public int CalculateDistance(GeoLocation desination)
    {
        int distance = calculateDistanceAlgo(currentLocation, desination);
        return distance;
    }
}