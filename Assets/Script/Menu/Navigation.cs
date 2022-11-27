using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{

    // scenes need to be loaded
    private string ChooseCarScene = "ChooseCar";
    private string StartMenuScene = "StartMenu";
    private string LeaderboardScene = "Leaderboard";
    private string ExplanationScene = "Explanation";
    private string ChooseTrack = "ChooseTrack";
    private string Track1PoliceCar = "Track1PoliceCar";
    private string Track1SportsCar = "Track1SportsCar";
    private string Track1Truck = "Track1Truck";
    private string Track2PoliceCar = "Track2PoliceCar";
    private string Track2SportsCar = "Track2SportsCar";
    private string Track2Truck = "Track2Truck";
 

    // store info of menu selected things 
    private static string ChoosenCar = "initial";
    private static string ChoosenTrack = "initial";

    // car names 
    private string policeCar = "PoliceCar";
    private string sportsCar = "SportsCar";
    private string truck = "Truck";

    // track names 
    private string track1 = "Track1";
    private string track2 = "Track2";
  
 
    public void StartGame()
    {
        SceneManager.LoadScene(ChooseCarScene);
    }


    // main menu 

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(StartMenuScene);
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene(LeaderboardScene);
    }

    public void Explanation()
    {
        SceneManager.LoadScene(ExplanationScene);
    }


    // choose car menu
    public void FurtherCar1()
    {
        ChoosenCar = truck;
        SceneManager.LoadScene(ChooseTrack);
    }

    public void FurtherCar2()
    {
        ChoosenCar = policeCar;
        SceneManager.LoadScene(ChooseTrack);
    }

    public void FurtherCar3()
    {
        ChoosenCar = sportsCar;
        SceneManager.LoadScene(ChooseTrack);
    }


    // choose track menu
    public void FurtherTrack1()
    {
       ChoosenTrack = track1;
       LoadGameScene(ChoosenCar, ChoosenTrack);
    }

    public void FurtherTrack2()
    {
        ChoosenTrack = track2;
        LoadGameScene(ChoosenCar, ChoosenTrack);
    }

    
    // this function loads the gamescenen based on the options made in the menu / choose car & track
    public void LoadGameScene(string choosenCar, string choosenTrack)
    {
        if(choosenCar == policeCar && choosenTrack == track1)
        {

            Debug.Log(choosenCar + " " + choosenTrack);
            SceneManager.LoadScene(Track1PoliceCar);
        }
        else if (choosenCar == truck && choosenTrack == track1)
        {
            Debug.Log(choosenCar + " " + choosenTrack);
            SceneManager.LoadScene(Track1Truck);
        }
        else if (choosenCar == sportsCar && choosenTrack == track1)
        {
            Debug.Log(choosenCar + " " + choosenTrack);
            SceneManager.LoadScene(Track1SportsCar);
        }

        else if(choosenCar == policeCar && choosenTrack == track2)
        {

            Debug.Log(choosenCar + " " + choosenTrack);
            SceneManager.LoadScene(Track2PoliceCar);
        }
        else if (choosenCar == truck && choosenTrack == track2)
        {
            Debug.Log(choosenCar + " " + choosenTrack);
            SceneManager.LoadScene(Track2Truck);
        }
        else if (choosenCar == sportsCar && choosenTrack == track2)
        {
            Debug.Log(choosenCar + " " + choosenTrack);
            SceneManager.LoadScene(Track2SportsCar);
        }
    }

}
