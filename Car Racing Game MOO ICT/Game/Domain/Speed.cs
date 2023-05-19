namespace Car_Racing_Game_MOO_ICT.Game.Domain;

public class Speed
{
    public int roadSpeed { get; set; }
    public int trafficSpeed { get; set; }
    public int playerSpeed { get; set; }

    public Speed(int roadSpeed, int trafficSpeed, int playerSpeed)
    {
        this.roadSpeed = roadSpeed;
        this.trafficSpeed = trafficSpeed;
        this.playerSpeed = playerSpeed;
    }
}