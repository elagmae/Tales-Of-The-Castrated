using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject musicManager;

    private void Update()
    {
        var currentScene = SceneManager.GetActiveScene();
        var sceneName = currentScene.name;

        if (sceneName == "Menu" || sceneName == "Fin" || sceneName == "DeathScene" || sceneName == "12")
        {
            DontDestroyOnLoad(musicManager);
            if (!musicManager.GetComponent<AudioSource>().isPlaying)
            {
                musicManager.GetComponent<AudioSource>().Stop();

            }

            if (musicManager.GetComponent<AudioSource>().isPlaying)
            {
                musicManager.GetComponent<AudioSource>().Stop();
            }
            musicManager.GetComponent<AudioSource>().Stop();
        }

        if (sceneName == "1" && !musicManager.GetComponent<AudioSource>().isPlaying)
        {
            musicManager.GetComponent<AudioSource>().Play();
        }

        DontDestroyOnLoad(musicManager);
    }
}
