using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesage : MonoBehaviour
{
    public GameObject Mes;
  public void Message(bool show)
    {
        if (Mes)
        {
            Mes.SetActive(false);
        }
    }
}
