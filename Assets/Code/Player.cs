using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins = 0;
    private int health = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Здоровье игрока: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
            print("Перезагрузка игры");
        }
    }

    public void CollectCoins()
    {
        coins++;
        print(coins);
    }
}
