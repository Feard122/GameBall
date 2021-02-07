using UnityEngine.UI;
using UnityEngine;

namespace GameBall
{ 
public class DisplayBonuses:IView
{ 
    private Text _text;
    private int _point;
    public DisplayBonuses()
    {
        _text = Object.FindObjectOfType<Text>();
    }

    public void Display(int value)
    {
        _point += value;
        _text.text = $"Вы набрали очков: {_point}";
    }
}

class MyClassrtty : IView
{
    public void Display(int value)
    {
        throw new System.NotImplementedException();
    }
}
}
