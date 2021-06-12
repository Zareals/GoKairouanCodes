using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public int sceneToLoad;
    public Sprite[] backgrounds;
    public Image bg;
    [SerializeField] string[] tips;
    //[SerializeField] Text tipHolder;
    [SerializeField] Text isReady;

    AsyncOperation loadingOperation;

    public Image progressBar;

    void Start()
    {
        bg.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
        progressBar.fillAmount = 0;
        //int rand = Random.Range(0, tips.Length);
        //tipHolder.text = tips[rand];
        StartCoroutine(LoadScene(sceneToLoad));
    }


    IEnumerator LoadScene(int scene)
    {
        yield return null;

        loadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        loadingOperation.allowSceneActivation = false;
        while (!loadingOperation.isDone)
        {
            isReady.text = "Loading progress: " + (loadingOperation.progress * 100) + "%";
            progressBar.fillAmount = Mathf.Clamp01(loadingOperation.progress / 0.9f);

            if (loadingOperation.progress >= 0.9f)
            {
                isReady.text = "Touch Anywhere to Play";
                if (Input.GetMouseButtonDown(0))
                    loadingOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
