using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipCalculator : MonoBehaviour
{

    ///Create a program that will calculate the prefered tip for a dinner bill.For example, your meal cost $20. Have 3 suggested tip values: 
    ///15%, 20% and 25%.
    ///Include support for a custom percent tip and calculate the tip amount and total bill.
    ///Use the inspector to input your data. 
    ///Example Print Your bill is $20 
    ///15% tip = $3 with a final total of: $23 
    ///20% tip = $4 with a final total of: $24 
    ///25% tip = $5 with a final total of: $25 Your custom tip of 18.5% = $3.70 with a final total of $23.70


    [SerializeField] private Text _instructions;
    [SerializeField] private Text _yourBill;
    [SerializeField] private InputField _billAmount;
    [SerializeField] private Button _15;
    [SerializeField] private Button _20;
    [SerializeField] private Button _25;
    [SerializeField] private Button _custom;
    [SerializeField] private InputField _customTip;
    [SerializeField] private Text _totalBillText;
    [SerializeField] private Text _customTipText;
    [SerializeField] private Button _yes;
    [SerializeField] private Button _no;
    [SerializeField] private float _totalBill;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _yourBill.text = "Your Bill is : $" + _billAmount.text + " Would you like to leave a tip?";
            _yes.gameObject.SetActive(true);
            _no.gameObject.SetActive(true);

            float bill = float.Parse(_billAmount.textComponent.text);
            _totalBill = bill;     
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float customTip = float.Parse(_customTip.textComponent.text)/100;
            TipCalculatorMath(customTip);
            _customTip.gameObject.SetActive(false);
            _customTipText.gameObject.SetActive(false);
            _yourBill.text = "Mahalo you have selected a %" + _customTip.textComponent.text + " Tip";
            _totalBillText.text = "Your total bill is : $" + _totalBill;
        }
    }

    private void TipCalculatorMath(float TipAmount)
    {
        _totalBill = _totalBill + (_totalBill * TipAmount);
    }
    private void TipButtonsActive()
    {
        _15.gameObject.SetActive(true);
        _20.gameObject.SetActive(true);
        _25.gameObject.SetActive(true);
        _custom.gameObject.SetActive(true);
    }

    private void TipButtonDeactive()
    {
        _15.gameObject.SetActive(false);
        _20.gameObject.SetActive(false);
        _25.gameObject.SetActive(false);
        _custom.gameObject.SetActive(false);
    }

    public void YesClick()
    {
        TipButtonsActive();
        _yes.gameObject.SetActive(false);
        _no.gameObject.SetActive(false);
    }

    public void NoClick()
    {
        _yes.gameObject.SetActive(false);
        _billAmount.gameObject.SetActive(false);
        _instructions.gameObject.SetActive(false);
        _yourBill.color = Color.red;
        _yourBill.text = "You are a terrible person!!!";
    }

    public void ClickFifteen()
    {
        float fifteen = .15f;
        TipButtonDeactive();
        TipCalculatorMath(fifteen);
        _yourBill.text = "Mahalo you have selected a %15 Tip";
        _totalBillText.text = "Your total bill is : $" + _totalBill;
    }

    public void ClickTwenty()
    {
        float twenty = .20f;
        TipButtonDeactive();
        TipCalculatorMath(twenty);
        _yourBill.text = "Mahalo you have selected a %20 Tip";
        _totalBillText.text = "Your total bill is : $" + _totalBill;
    }

    public void ClickTwentyFive()
    {
        float twentyFive = .25f;
        TipButtonDeactive();
        TipCalculatorMath(twentyFive);
        _yourBill.text = "Mahalo you have selected a %25 Tip";
        _totalBillText.text = "Your total bill is : $" + _totalBill;
    }

    public void ClickCustom()
    {
        TipButtonDeactive();
        _customTip.gameObject.SetActive(true);
        _customTipText.gameObject.SetActive(true);
    }






}
