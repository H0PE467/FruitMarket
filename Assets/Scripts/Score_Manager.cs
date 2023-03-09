using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Score_Text;
    int score = 0;

    public static Score_Manager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Score_Text.text = "Puntuación: " + score.ToString();
    }

    public void AddPoints(int points)
    {
        score += points;
        Score_Text.text = "Puntuación: " + score.ToString();
    }
}
