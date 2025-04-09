using UnityEngine;

public class MasterLevelInfo : MonoBehaviour
{
    public static int goldCount = 0;
    [SerializeField] GameObject goldDisplay;

   

    // Update is called once per frame
    void Update()
    {
        goldDisplay.GetComponent<TMPro.TMP_Text>().text = "Gold Coins: " + goldCount;
    }
}
