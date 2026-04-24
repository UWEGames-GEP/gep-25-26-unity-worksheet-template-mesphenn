using UnityEditor.PackageManager.UI;
using UnityEngine;
using static GameManager;

public class PauseUI : MonoBehaviour
{
    public GameManager gameManager;

  public void onResume()
    {
        gameManager.resume();
    }

   public void QuitGame()
   {
       Application.Quit();
   }
}
