using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MasterLvlInfo.goldCount += 1;

        this.gameObject.SetActive(false);

    }
}
