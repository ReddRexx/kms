using UnityEngine;

public class MasterLvlInfo : MonoBehaviour
{
    public static int goldCount = 0;
    [SerializeField] GameObject goldDisplay;

    private void Update()
    {
        goldDisplay.GetComponent<TMPro.TMP_Text>().text = "Gold Coins:" + goldCount;
    }
}
