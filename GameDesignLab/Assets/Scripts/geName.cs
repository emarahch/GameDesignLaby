using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class geName : MonoBehaviour
{

  public InputField nameField;



   void Start ()
   {

   }

   public void SubmitName()
   {

       Debug.Log(nameField.text);
       PersisData.Instance.SetName(nameField.text);

   }


   void Update()
   {

   }

}
