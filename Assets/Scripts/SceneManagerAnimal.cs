using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAnimal : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
