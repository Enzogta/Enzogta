using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int pontos;
    public GameObject Player;
    public GameObject Map;

    public GameObject Menu;

    public GameObject GameOver;
    public Text m_pontos;
    public GameObject Pontos;


    void Update() {

        if(PlayerControl.GameOver){
            GameOver.SetActive(true);
            Player.SetActive(false);
            Pontos.SetActive(false);
            Map.SetActive(false);
        }
        m_pontos.text = pontos.ToString();
        if(pontos == 5 ){
            
        }
       
   }
   public void comeca(){
       Player.SetActive(true);
       Map.SetActive(true);
       Pontos.SetActive(true);
       Menu.SetActive(false);

   }
   public void restart (){
        GameOver.SetActive(false);
        PlayerControl.GameOver = false;
        Player.transform.position= new Vector3(0f,0f,-6.26f);
        Menu.SetActive(true);
        GameOver.SetActive(false);
   }

}
