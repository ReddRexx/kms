using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeToBlack;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());

    }

    IEnumerator CollisionEnd()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        
        yield return new WaitForSeconds(1);
        fadeToBlack.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
