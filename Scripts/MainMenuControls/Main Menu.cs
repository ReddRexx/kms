using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject fadeOutIntro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(StarButton());
    }

    IEnumerator StarButton()
    {
        fadeOutIntro.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

   
}
