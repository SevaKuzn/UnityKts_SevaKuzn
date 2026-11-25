using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ShopManager : MonoBehaviour
{
    [System.Serializable]
    public class Product
    {
        public string name;
        public float price;
        public TextMeshProUGUI nameText;
        public TextMeshProUGUI priceText;
        public Button buyButton;
    }

    public List<Product> storeProducts = new List<Product>();


    public Transform cartContent;
    public TextMeshProUGUI cartTotalText;
    public GameObject cartItemPrefab;

    public Button nextDayButton;

    private List<Product> cart = new List<Product>();

    void Start()
    {
        for (int i = 0; i < storeProducts.Count; i++)
        {
            int index = i;
            storeProducts[i].buyButton.onClick.AddListener(() => AddToCart(index));
        }
        nextDayButton.onClick.AddListener(NextDay);

        UpdateCartUI();
    }

    void AddToCart(int storeIndex)
    {
        Product storeItem = storeProducts[storeIndex];

        Product cartItem = new Product();
        cartItem.name = storeItem.name;
        cartItem.price = storeItem.price;

        GameObject uiObj = Instantiate(cartItemPrefab, cartContent);
        cartItem.nameText = uiObj.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        cartItem.priceText = uiObj.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

        cartItem.nameText.text = cartItem.name;
        cartItem.priceText.text = cartItem.price.ToString("F2");

        cart.Add(cartItem);
        UpdateCartUI();
    }

    void NextDay()
    {
        for (int i = 0; i < storeProducts.Count; i++)
        {
            DoublePrice(ref storeProducts[i].price);
            storeProducts[i].priceText.text = storeProducts[i].price.ToString("F2");
        }

        for (int i = 0; i < cart.Count; i++)
        {
            DoublePrice(ref cart[i].price);
            cart[i].priceText.text = cart[i].price.ToString("F2");
        }

        UpdateCartUI();
    }

    void DoublePrice(ref float price)
    {
        price *= 2f;
    }

    void UpdateCartUI()
    {
        float total = CalculateTotal();

        foreach (var item in cart)
        {
            Debug.Log(item.name + ": " + item.price);
        }

        cartTotalText.text = "Сумма: " + total.ToString("F1");
    }

    float CalculateTotal()
    {
        float sum = 0;
        foreach (var item in cart)
        {
            sum += item.price;
        }
        return sum;
    }
}