using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;//333
    public float restartDlay = 1f;//777
    public GameObject completeLevelUI;//b11
    public void CompleteLevel () //a11
    {
        Debug.Log("LevelCompelete!"); //a11
        completeLevelUI.SetActive(true);//b11  Refrence levelcomplete panel in unity
    }
    public void EndGame ()
    { if (gameHasEnded == false)///444
        { 
        gameHasEnded = true; 
        Debug.Log("GameOver!");///444
        Invoke("Restart", restartDlay);
        }
    }
    void Restart ()//555
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//666  TURN OF AUTO GENARATE LIGHTING!!!!
    }
}
