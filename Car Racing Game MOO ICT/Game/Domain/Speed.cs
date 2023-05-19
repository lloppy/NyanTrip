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
    
    public void onPause()
    {
        roadSpeed = 0;
        trafficSpeed = 0;
        playerSpeed = 0;
    }

    public void onRestart(Speed lastSpeed)
    {
        this.roadSpeed = lastSpeed.roadSpeed;
        this.trafficSpeed = lastSpeed.trafficSpeed;
        this.playerSpeed = lastSpeed.playerSpeed;
    }
    
}