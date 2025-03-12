using UnityEngine;
using UnityEngine.SceneManagement;

public class Itens: MonoBehaviour
{
    public GameObject itemPrefab; // Prefab do item
    public int totalItens = 6; // Quantidade de itens a coletar
    public Transform spawnArea; // Objeto que define a área de spawn
    public Vector3 areaSize; // Tamanho da área de spawn

    private int itensColetados = 0;

    void Start()
    {
        SpawnItens();
    }

    void SpawnItens()
    {
        for (int i = 0; i < totalItens; i++)
        {
            Vector3 spawnPos = spawnArea.position + new Vector3(
                Random.Range(-areaSize.x / 2, areaSize.x / 2),
                Random.Range(-areaSize.y / 2, areaSize.y / 2),
                Random.Range(-areaSize.z / 2, areaSize.z / 2)
            );
            Instantiate(itemPrefab, spawnPos, Quaternion.identity);
        }
    }

    public void ColetarItem()
    {
        itensColetados++;
        if (itensColetados >= totalItens)
        {
            SceneManager.LoadScene("TelaVitoria");
        }
    }
}

