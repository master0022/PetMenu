using UnityEngine;

public class NavigationHighliter : MonoBehaviour
{
    public GameObject ActiveHouse;
    public GameObject ActiveFood;
    public GameObject ActiveCalendar;
    public GameObject House;
    public GameObject Food;
    public GameObject Calendar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HouseFunction()
    {
        // Enable ActiveHouse and disable other Active objects
        ActiveHouse.SetActive(true);
        House.SetActive(true);

        ActiveFood.SetActive(false);
        Food.SetActive(false);

        ActiveCalendar.SetActive(false);
        Calendar.SetActive(false);

    }

    public void FoodFunction()
    {
        // Enable ActiveFood and disable other Active objects
        ActiveHouse.SetActive(false);
        House.SetActive(false);

        ActiveFood.SetActive(true);
        Food.SetActive(true);

        ActiveCalendar.SetActive(false);
        Calendar.SetActive(false);
    }

    public void CalendarFunction()
    {
        // Enable ActiveCalendar and disable other Active objects
        ActiveHouse.SetActive(false);
        House.SetActive(false);

        ActiveFood.SetActive(false);
        Food.SetActive(false);

        ActiveCalendar.SetActive(true);
        Calendar.SetActive(true);
    }
}