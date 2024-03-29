using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    /// <summary>
    /// Ecoute l'event d'update de l'ui de l'argent
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _moneyText;

    public void Start()
    {
        Shop.Instance.ChangeMoneyUI += UpdateUI;
    }

    public void UpdateUI(int newMoneyCount)
    {
        _moneyText.text = newMoneyCount.ToString();
    }
}
