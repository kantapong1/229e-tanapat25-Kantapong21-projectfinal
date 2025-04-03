using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float countdownTime = 60f; 
    float elapsedTime;

    void Start()
    {
        elapsedTime = countdownTime; 
    }

    void Update()
    {
        if (elapsedTime > 0)
        {
            elapsedTime -= Time.deltaTime; 
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{1:00}:{0:00}", seconds, minutes);
        }
        else
        {
            timerText.text = "00:00";
        }
    }   
}