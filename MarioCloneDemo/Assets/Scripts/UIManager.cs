using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] TextMeshProUGUI coinText;
    private int coinsCollected = 0;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCoinText(int coin) {
        coinsCollected += coin;
        coinText.text = "Coins: " + coinsCollected;
    }
}
