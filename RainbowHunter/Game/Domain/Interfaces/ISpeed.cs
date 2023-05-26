namespace RainbowHunter.Game.Domain.Interfaces;

public interface ISpeed
{
    int RoadSpeed { get; set; }
    int TrafficSpeed { get; set; }
    int PlayerSpeed { get; set; }

    void OnPause();
    void OnRestart(ISpeed lastSpeed);
}
