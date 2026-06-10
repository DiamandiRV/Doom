using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class scenecontroller : MonoBehaviour
{
    [SerializeField]

    private Animator fade;
     [SerializeField]
     private UnityEvent onSceneStart;
     private void Start()
    {
        onSceneStart?.Invoke();
    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneWhithFade(string sceneName)
    {
        StartCoroutine(LoadSceneWhithFadeCoroutine(sceneName));
    }

    private IEnumerator LoadSceneWhithFadeCoroutine(string sceneName)
    {
        fade.Play("FadeOut");
        yield return new WaitForSeconds(fade.GetCurrentAnimatorStateInfo(0).length);
        LoadScene(sceneName);
    }

}
