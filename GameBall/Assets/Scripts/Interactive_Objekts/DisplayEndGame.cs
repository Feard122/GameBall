using UnityEngine;
using UnityEngine.UI;


namespace GameBall
{
    public sealed class DisplayEndGame
    { 
        public GameObject panel;

        public DisplayEndGame()
        {
           panel = GameObject.Find("PanelEndGame");
           panel.SetActive(false);
        }
        public void GameOver()
        {
            Time.timeScale = 0;
            panel.SetActive(true);            
        }
        
    }
}