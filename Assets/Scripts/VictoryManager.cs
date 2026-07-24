using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _victoryManager;
    private void Update()
    {
        var currentScene = SceneManager.GetActiveScene();
        var sceneName = currentScene.name;

        if(sceneName == "12" || sceneName == "Fin")
        {
            if(!_victoryManager.GetComponent<AudioSource>().isPlaying)
            {
                _victoryManager.GetComponent<AudioSource>().Play();
            }
        }

        if (sceneName != "12" && sceneName != "Fin")
        {
            _victoryManager.GetComponent<AudioSource>().Stop();
        }
        DontDestroyOnLoad(_victoryManager);
    }
}
