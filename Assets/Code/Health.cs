using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

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
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("�������� ������: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
            print("������������ ����");
        }
    }
}
