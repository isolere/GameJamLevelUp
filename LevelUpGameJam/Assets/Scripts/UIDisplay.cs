using TMPro;
using UnityEngine;
using UnityEngine.UI;

/**
 * Component per configurar la interficie d'usuari durant el joc.
 */
public class UIDisplay : MonoBehaviour
{
    [Header("Player Stats")] [SerializeField]
    private Slider eterSlider;


    [Header("Animations")] [SerializeField]

     Animation scoreAnimation;

    void Start()
    {
        GameState.Instance.OnScoreChanged += UpdateScore;

        eterSlider.maxValue =100;
        eterSlider.value = 0;

      }


    void UpdateScore()
    {
        if (scoreAnimation)
        {
            scoreAnimation.Play();
        }

        eterSlider.value = GameState.Instance.GetScore();



    }
    
    private void OnDestroy()
    {
        // Com que _gameState és un singleton, si no ens desuscribim quan
        // es canvia de nivell continua intentant actualitzar la UI antiga
        GameState.Instance.OnScoreChanged -= UpdateScore;
    }
}