using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSelect : MonoBehaviour
{
    public int selectedWeapon = 0;

    void Start()
    {
        SelectedWeapon();
    }

    public void character1()
    {

        selectedWeapon = 0;

    }

    public void character2()
    {
       if (transform.childCount >= 2)
            selectedWeapon = 1;
        SelectedWeapon();

    }
    public void character3()
    {
      if (transform.childCount >= 3)
            selectedWeapon = 2;
        SelectedWeapon();
    }

    public void character4()
    {
       if (transform.childCount >= 4)
            selectedWeapon = 3;

        SelectedWeapon();
    }
    void SelectedWeapon()
    {

        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;


        }



    }
}
