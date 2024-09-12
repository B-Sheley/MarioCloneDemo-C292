using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] TextMeshProUGUI healthText;
    private GameObject player;
    private int coinsCollected = 0;
    private int healthRemaining = 10;


    public void Awake() 
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    public void UpdateCoinText(int coin) {
        coinsCollected += coin;
        coinText.text = "Coins: " + coinsCollected;
    }

    public void UpdateHealth(int damage)
    {
        healthRemaining -= damage;
        healthText.text = "Health: " + healthRemaining;
    }
}
