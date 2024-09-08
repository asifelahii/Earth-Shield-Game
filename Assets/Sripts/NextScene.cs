using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] int scenePluse;

    public void NextScene()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + scenePluse);
    }
}
