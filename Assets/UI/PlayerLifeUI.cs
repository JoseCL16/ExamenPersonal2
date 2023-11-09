using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeUI : MonoBehaviour
{
    public int health;
    public int Nhearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        if(health >Nhearts)
        {
            health = Nhearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i<health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i<Nhearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
        }

        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            health -= 1;
        }
    }
}