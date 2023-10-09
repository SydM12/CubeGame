using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter () //a11
    {
        gameManager.CompleteLevel();//a22
    }
}
