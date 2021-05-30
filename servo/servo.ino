#include <Servo.h>

Servo myServo;
String angle_str;
int angle;

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  myServo.attach(A0);
  String str = "0";
  myServo.write(45);
  delay(800);
  myServo.write(180);
  while (!(str.indexOf("START") >= 0)) {
    str = Serial.readString();
  }
  digitalWrite(13, HIGH);
}

void loop() {
  //digitalWrite(13, LOW);
  digitalWrite(13, HIGH);
  do {
    angle_str = Serial.readString();
  } while (angle_str == "");
  
  int angle = angle_str.toInt();
  Serial.println(angle);
  myServo.write(angle);
  delay(1000);
  }
