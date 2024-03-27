using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;

    public void Start()
    {
        Shop.Instance.MoneyChangeUI += UpdateUI;
    }

    public void UpdateUI(int newMoneyCount)
    {
        _moneyText.text = newMoneyCount.ToString();
    }
}
