using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private float currentExp;
    private float maxExp;
    private string itemName;
    private int currentLevel;

    [SerializeField] private Image imageSlot;
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private Button button;
    [SerializeField] private Image expSlider;

    private void Awake()
    {
        button.onClick.AddListener(AddExp);
        currentLevel = 1;
        currentExp = 0;
        maxExp = 10;
    }

    private void Start()
    {
        Setup();
    }

    public void Setup()
    {
        imageSlot.sprite = itemSprite;
    }

    private void CheckIfCanLevelUp()
    {
        if (currentExp >= maxExp)
        {
            LevelUpItem();
        }
    }

    private void LevelUpItem()
    {
        currentLevel++;
        ResetLevel();
    }

    private void ResetLevel()
    {
        currentExp = 0;
    }

    private void AddExp()
    {
        CheckIfCanLevelUp();
        currentExp++;
        UpdateEXPSlider();
    }

    private void UpdateEXPSlider()
    {
        expSlider.fillAmount =  currentExp / maxExp;
    }
}