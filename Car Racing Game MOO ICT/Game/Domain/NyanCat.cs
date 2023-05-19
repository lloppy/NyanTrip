using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game.Domain;

public class NyanCat
{
    private readonly Random _rand = new Random();
    private readonly Random _catPosition = new Random();

    private PictureBox BonusCat { get; }

    public NyanCat(PictureBox bonus)
    {
        BonusCat = bonus;
        SetPicture();
        SetPosition();
    }
    
    public NyanCat(){}
    
    private void SetPosition()
    {
        BonusCat.Top = _catPosition.Next(100, 400) * -1;

        if ((string)BonusCat.Tag == "bonusLeft")
        {
            BonusCat.Left = _catPosition.Next(5, 200);
        }
        else if ((string)BonusCat.Tag == "bonusRight")
        {
            BonusCat.Left = _catPosition.Next(245, 422);
        }
    }
    
    public void MoveTraffic(PictureBox BONUS1, PictureBox BONUS2, Speed speed)
    {
        BONUS1.Top += speed.trafficSpeed;
        BONUS2.Top += speed.trafficSpeed;
        if (BONUS1.Top > 530)
        {
            ChangeAIBonus(BONUS1);
        }
        if (BONUS2.Top > 530)
        {
            ChangeAIBonus(BONUS2);
        }
    }
    
    private void SetPicture()
    {
        var bonusImageRand = _rand.Next(1, 2);

        if (bonusImageRand % 2 == 0) BonusCat.Image = Properties.Resources.nyan_cat_right;
        BonusCat.Image = Properties.Resources.nyan_cat_left;
    }
            
    private void ChangeAIBonus(PictureBox tempCat)
    {
        var ai = new NyanCat(tempCat);
    }
}