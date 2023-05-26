using RainbowHunter.Game.Domain.Interfaces;

namespace RainbowHunter.Game.Domain;

public class Speed : ISpeed
{
    public int RoadSpeed { get; set; }
    public int TrafficSpeed { get; set; }
    public int PlayerSpeed { get; set; }

    public Speed(int roadSpeed, int trafficSpeed, int playerSpeed)
    {
        RoadSpeed = roadSpeed;
        TrafficSpeed = trafficSpeed;
        PlayerSpeed = playerSpeed;
    }

    public void OnPause()
    {
        RoadSpeed = 0;
        TrafficSpeed = 0;
        PlayerSpeed = 0;
    }

    public void OnRestart(ISpeed lastSpeed)
    {
        RoadSpeed = lastSpeed.RoadSpeed;
        TrafficSpeed = lastSpeed.TrafficSpeed;
        PlayerSpeed = lastSpeed.PlayerSpeed;
    }
}
