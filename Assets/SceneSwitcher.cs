using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {
    
    public void SwitchScene () {
        Scene currentScene = SceneManager.GetActiveScene();

        int nextScene = currentScene.buildIndex == 0 ? 1 : 0;

        SceneManager.LoadScene(nextScene);
    }
}
