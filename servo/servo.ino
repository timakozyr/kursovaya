#include <Servo.h>

Servo myServo;
String angle_str;
int angle;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  //Serial.println("I AM SERVO");
  pinMode(13, OUTPUT);
  myServo.attach(A0);
  String str = "0";
  myServo.write(45);
  delay(800);
  myServo.write(180);
//  myServo.write(45);
//  myServo.write(180);
//  myServo.write(45);
  while (str != "START\n") {
    str = Serial.readString();
    str[str.length()] = '\0';
  }
  //Serial.println("paf");
}

void loop() {
  // put your main code here, to run repeatedly:
  //Serial.println("asdasd");
  digitalWrite(13, HIGH);
  do {
    angle_str = Serial.readString();
    //angle_str[angle_str.length()] = '\0';
  } while (angle_str == "");
  int angle = angle_str.toInt();
  //if (angle > 44) digitalWrite(13, HIGH);
  myServo.write(angle);
  //delay(50);
  }
