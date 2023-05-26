using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Controller.Interfaces;

public interface IMovementUtility
{
    void MovePlayer();
    void MoveRoad();
    void MoveMushroom(Mushrooms mushroom);
    void MoveSun(Sun sun);
}
