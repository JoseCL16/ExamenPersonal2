using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Button button;
    public string scene;

    void Awake()
    {
        button = GetComponent<Button>();
    }

    void Start()
    {
        button.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(scene);
        AmmoCountShotgun.Ammo = 12;
        AmmoCountUzi.Ammo = 30;
        CoinCount.coinAmount = 0;
        ShotgunShoot.Shells = 12;
        UziShoot.Ammo = 30;
        WaveCounter.Wave = 1;
        EnemyCount.Entities = 10;
    }
}