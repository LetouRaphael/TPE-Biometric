/* 
  FPS_Enroll.ino - Library example for controlling the GT-511C3 Finger Print Scanner (FPS)
  Created by Josh Hawley, July 23rd 2013
  Licensed for non-commercial use, must include this license message
  basically, Feel free to hack away at it, but just give me credit for my work =)
  TLDR; Wil Wheaton's Law
*/


#include "FPS_GT511C3.h"
#include "SoftwareSerial.h"

// Hardware setup - FPS connected to:
//    digital pin 4(arduino rx, fps tx)
//    digital pin 5(arduino tx - 560ohm resistor fps rx - 1000ohm resistor - ground)
//    this brings the 5v tx line down to about 3.2v so we dont fry our fps

FPS_GT511C3 fps(4, 5);

void setup()
{
  Serial.begin(9600);
  delay(100);
  fps.Open();
  fps.SetLED(true);

}

bool Identify(){
  bool tantque = true;
  Serial.println("Posez votre doigt");
  while(tantque == true){
  
    fps.CaptureFinger(false);
    int id = fps.Identify1_N();
    
    if (id <200)
    {
      //Serial.print("Verified ID:");
      Serial.println(id);
      tantque = false;
    }
   // else
   // {
      //Serial.println("Finger not found");
   // }
  
  delay(100);
}}



void Enroll()
{
  // Enroll test

  // find open enroll id
  int enrollid = 0;
  bool usedid = true;
  while (usedid == true)
  {
    usedid = fps.CheckEnrolled(enrollid);
    if (usedid==true) enrollid++;
  }
  fps.EnrollStart(enrollid);

  // enroll
  Serial.print("Press finger to Enroll #");
  Serial.println(enrollid);
  while(fps.IsPressFinger() == false) delay(100);
  bool bret = fps.CaptureFinger(true);
  int iret = 0;
  if (bret != false)
  {
    Serial.println("Remove finger");
    fps.Enroll1(); 
    while(fps.IsPressFinger() == true) delay(100);
    Serial.println("Press same finger again");
    while(fps.IsPressFinger() == false) delay(100);
    bret = fps.CaptureFinger(true);
    if (bret != false)
    {
      Serial.println("Remove finger");
      fps.Enroll2();
      while(fps.IsPressFinger() == true) delay(100);
      Serial.println("Press same finger yet again");
      while(fps.IsPressFinger() == false) delay(100);
      bret = fps.CaptureFinger(true);
      if (bret != false)
      {
        Serial.println("Remove finger");
        iret = fps.Enroll3();
        if (iret == 0)
        {
          Serial.println(enrollid);
          Serial.println("Inscription réussi !");
        }
        else
        {
          Serial.println("Failed");
        }
      }
      else Serial.println("Failed");
    }
    else Serial.println("Failed");
  }
  else Serial.println("Failed");
}

void delone(){
  bool tantque = true;
  int deb = fps.GetEnrollCount();
  Serial.println("ID a supprimer ? ");
  while(tantque == true){
    if (Serial.available() > 0) {
    int recv = Serial.read();
    fps.DeleteID(recv);
    if (fps.GetEnrollCount() == deb - 1 ){
      tantque = false;
      Serial.println("Succes");
      }
      
    }
  
  delay(10);
}}

void loop()
{
  delay(10);
    if (Serial.available() > 0) {

int recv = Serial.read();


switch (recv) {
 case '1':
 Enroll();
 break;
 case '2':
 Identify();
 break;
 case '3':
 delone();
 break;
}}
}

