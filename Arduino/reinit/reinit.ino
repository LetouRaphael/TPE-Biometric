#include "FPS_GT511C3.h"
#include "SoftwareSerial.h"

// Hardware setup - FPS connected to:
//    digital pin 4(arduino rx, fps tx)
//    digital pin 5(arduino tx - 560ohm resistor fps rx - 1000ohm resistor - ground)
//    this brings the 5v tx line down to about 3.2v so we dont fry our fps

FPS_GT511C3 fps(4, 5);


void setup() {
  Serial.begin(9600);
  delay(100);
  fps.Open();
  fps.SetLED(true);
  fps.DeleteAll();
  if (fps.GetEnrollCount() == 0){
      Serial.println("Succes");
    }
  else {
    Serial.println("failed");
  }
  Serial.println("Fin");
}




void loop() {
  // put your main code here, to run repeatedly:

}
