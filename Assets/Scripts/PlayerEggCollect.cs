using UnityEngine;

public class PlayerEggCollect : MonoBehaviour
{
    public int eggs = 0;
    public GameObject eggScore1;
    public GameObject eggScore2;
    public GameObject eggScore3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Egg"))
        {
            eggs++;
        }

        if (eggs == 1)
        {
            eggScore1.SetActive(true);
        }
        else if (eggs == 2)
        {
            eggScore2.SetActive(true);
        }
        else if (eggs == 3)
        {
            eggScore3.SetActive(true);
        }
    }
}
