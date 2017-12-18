using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class PontuacaoScript : MonoBehaviour
{


    public Text txtPontos; 
    public Text txtLives;

    public static int score;
    public static int lives;

    void Update()
    {
        txtPontos.text = PontuacaoScript.score.ToString();
        txtLives.text = PontuacaoScript.lives.ToString();
    }

}
