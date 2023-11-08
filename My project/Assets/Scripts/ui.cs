using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    public Text creditsText;
    public float scrollSpeed = 30.0f;

    public bool isScrolling = true;

    void Start()
    {

    }

    void Update()
    {
        if (isScrolling)
        {
            creditsText.rectTransform.anchoredPosition += Vector2.up * scrollSpeed * Time.deltaTime;
        }

        if ((Input.anyKeyDown) && (isScrolling))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangeSceneSample()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ChangeSceneCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }


    public void StartScrolling()
    {
        isScrolling = true;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}