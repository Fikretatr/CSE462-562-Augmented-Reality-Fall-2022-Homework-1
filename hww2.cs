using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Globalization;
public class hww2 : MonoBehaviour
{
    float x1, y1, z1;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("fikret");
        FileInfo theSourceFile = new FileInfo(@"C:\Users\atarf\Desktop\arodev2\file2.txt");
        StreamReader reader = theSourceFile.OpenText();

        string text;
        //print("fikret");
        //Debug.Log("fikret");

        int sayac = 0;
        //  int ilk = 1;

        int flag = 0;

        do
        {
            text = reader.ReadLine();
           // Console.WriteLine(text);
            //string phrase = "The quick brown fox jumps over the lazy dog.";
            if (text == null)
            {
                break;
            }
            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                if (sayac == 1)
                {
                    x1 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                    //x1 = (float)Convert.ToFL(word);

                    sayac++;
                }
                else if (sayac == 2)
                {
                    y1 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                    //y1 = (float)Convert.ToDouble(word);
                    sayac++;
                }
                else if (sayac == 3)
                {
                    z1 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                    //z1 = (float)Convert.ToDouble(word);
                    flag = 1;
                    sayac = 1;

                }
                else if (sayac == 0)
                {
                    sayac++;
                    break;
                }

                if (flag == 1)
                {
                    Debug.Log(x1);
                    Debug.Log(y1);
                    Debug.Log(z1);
                    GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    sphere.transform.position = new Vector3(x1, y1, z1);
                    sphere.GetComponent<Renderer>().material.color = new Color32(0, 96, 145, 125);
                    Debug.Log("ilk küp ok");

                    flag = 0;
                }


                // Debug.Log($"<{word}>");

            }

            Debug.Log("bitti22");
            if (text != null)
            {
                //  Debug.Log(text);
            }
            Debug.Log("bitti33");
            // print(text);
            // print("fikret");

        } while (text != null);
       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
