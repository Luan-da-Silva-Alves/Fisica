
using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ItemManager manager = FindAnyObjectByType<ItemManager>();
            if (manager != null)
            {
                manager.ColetarItem();
                Destroy(gameObject);
            }
        }
    }
}