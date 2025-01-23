using UnityEngine;

public class Task2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public double originalPriceX;
    public double numberOfCopiesY;
    public bool isBookstore;

    private double bookCost;
    private double shippingCost;
    private double totalCost;
    private double profit;

    void Start()
    {
        if (numberOfCopiesY > 0)
        {
            bookCost = originalPriceX * numberOfCopiesY;
        }
        else
        {
            bookCost = 0;
        }
       
        // sets discounted total cost for bookstores
        if (isBookstore)
        {
            bookCost = bookCost * 0.6;
        }
        Debug.Log("The cost of the books is: " + bookCost);

        // calculates the total shipping cost if the first book 

        if (numberOfCopiesY > 0)
        {
            shippingCost = (3 * (numberOfCopiesY / numberOfCopiesY)) + (0.75 * (numberOfCopiesY - 1));
        } 
        else
        {
            shippingCost = 0;
        }
        Debug.Log("The shipping cost is: " + shippingCost);

        totalCost = bookCost + shippingCost;
        Debug.Log("Your total cost is: " +  totalCost);
  
        if (isBookstore)
        {
            profit = (bookCost / 0.6) - totalCost;
            Debug.Log("Your potential profit will be: " + profit);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
