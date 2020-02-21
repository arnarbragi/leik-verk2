using UnityEngine;

public class EndController : MonoBehaviour
{
    public GameManager gameManager;
    
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
