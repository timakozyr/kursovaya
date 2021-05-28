int rezistor0, rezistor1, rezistor2, rezistor3;
int angle0, angle1, angle2, angle3;
int currentAngle;
int min0, min1, min2, min3;

int max0, max1, max2, max3;
String flag, str;

void repeat() {
  str = "0";
  while (str != "MAX\n") {
    str = Serial.readString();
    str[str.length()] = '\0';
    if (str == "START\n") {digitalWrite(13, HIGH); loop();}
  }
  Serial.println(analogRead(A3)); // max0
  Serial.println(analogRead(A2)); // max1
  Serial.println(analogRead(A1)); // max2
  Serial.println(analogRead(A0)); // max3
  digitalWrite(13, HIGH);
  // фиксируем минимальные значения напряжений после нажатия кнопки пользователем
  str = "0";
  while (str != "MIN\n") {
    str = Serial.readString();
    str[str.length()] = '\0';
  }
  Serial.println(analogRead(A3)); // min0
  Serial.println(analogRead(A2)); // min1
  Serial.println(analogRead(A1)); // min2
  Serial.println(analogRead(A0)); // min3
  digitalWrite(13, LOW);
  str = "0";
}

void calibration(){
  str = "0";
  while (str != "MAX\n") {
    str = Serial.readString();
    str[str.length()] = '\0';
    if (str == "START\n") {digitalWrite(13, HIGH); loop();}
  }
  Serial.println(analogRead(A3)); // max0
  Serial.println(analogRead(A2)); // max1
  Serial.println(analogRead(A1)); // max2
  Serial.println(analogRead(A0)); // max3
  digitalWrite(13, HIGH);
  // фиксируем минимальные значения напряжений после нажатия кнопки пользователем
  str = "0";
  while (str != "MIN\n") {
    str = Serial.readString();
    str[str.length()] = '\0';
  }
  Serial.println(analogRead(A3)); // min0
  Serial.println(analogRead(A2)); // min1
  Serial.println(analogRead(A1)); // min2
  Serial.println(analogRead(A0)); // min3
  digitalWrite(13, LOW);
  str = "0";
  while (str != "COUNTINUE\n") {  // задерживаемся в ожидании решения пользователя
    str = Serial.readString();
    str[str.length()] = '\0';
    if (str == "REPEAT\n") repeat();
    if (str == "START\n") start();// идем в начало, если пользователь решил повторить
  }
}

void start(){
  String max0_str = "";
  String max1_str = "";
  String max2_str = "";
  String max3_str = "";
  String min0_str = "";
  String min1_str = "";
  String min2_str = "";
  String min3_str = "";
  do
  {
    max0_str = Serial.readString();
  } while (max0_str == "");
  do
  {
    max1_str = Serial.readString();
  } while (max1_str == "");
  do
  {
    max2_str = Serial.readString();
  } while (max2_str == "");
  do
  {
    min0_str = Serial.readString();
  } while (min0_str == "");
  do
  {
    min1_str = Serial.readString();
  } while (min1_str == "");
  do
  {
    min2_str = Serial.readString();
    //if (min2_str.toInt() > 0) ********
      //Serial.println(min2_str.toInt()); ***********
  } while (min2_str == "");
  do
  {
    min3_str = Serial.readString();
  } while (min3_str == "");
  max0 = max0_str.toInt();
  Serial.println(max0_str);
  max1 = max1_str.toInt();
  //Serial.println(max1);
  max2 = max2_str.toInt();
  Serial.println(max2);
  max3 = max3_str.toInt();
  //Serial.println(max3);
  min0 = min0_str.toInt();
  Serial.println(min0);
  min1 = min1_str.toInt();
  //Serial.println(min1);
  min2 = min2_str.toInt();
  Serial.println(min2);
  min3 = min3_str.toInt();
  loop();
}

void setup() {
  Serial.begin(9600);
  //Serial.println("I AM POTENZ");
  pinMode(13, OUTPUT);
  digitalWrite(13, LOW);
  //устанавливаем пины
  pinMode(A0, INPUT);
  pinMode(A1, INPUT);
  pinMode(A2, INPUT);
  pinMode(A3, INPUT);
  // фиксируем максимальные значения напряжений после нажатия кнопки пользователем
  str = "0";
  while (str != "MAX\n") {
    str = Serial.readString();
    if (!(str.indexOf('\0') >= 0))
      str += '\0';
    if (str.indexOf("START") >= 0) {
      digitalWrite(13, HIGH); 
      start();
      }
  }
  Serial.println(analogRead(A3)); // max0
  Serial.println(analogRead(A2)); // max1
  Serial.println(analogRead(A1)); // max2
  //Serial.println(analogRead(A0)); // max3
  digitalWrite(13, HIGH);
  // фиксируем минимальные значения напряжений после нажатия кнопки пользователем
  str = "0";
  while (str != "MIN\n") {
    str = Serial.readString();
    str[str.length()] = '\0';
  }
  Serial.println(analogRead(A3)); // min0
  Serial.println(analogRead(A2)); // min1
  Serial.println(analogRead(A1)); // min2
  Serial.println(analogRead(A0)); // min3
  digitalWrite(13, LOW);
  // осуществляем возможность повтора калибровки
  str = "0";
  while (str != "CALIBRATION\n") {  // задерживаемся в ожидании решения пользователя
    str = Serial.readString();
    str[str.length()] = '\0';
    if (str == "REPEAT\n") repeat();
    if (str == "START\n") 
    {
      digitalWrite(13, HIGH);
      start();// идем в начало, если пользователь решил повторить
    }
  }
  calibration();
  // пользователем осуществлен выход из окна калибровки
}

void loop() {
  while (true)
  {
    rezistor0 = analogRead(A3);
    rezistor1 = analogRead(A2);
    rezistor2 = analogRead(A1);
    //rezistor3 = analogRead(A0);
    //angle0 analysis
    angle0 = (135 * rezistor0 - 135 * max0) / (max0 - min0) + 180;
    angle0 < 45 ? angle0 = 45 : angle0; 
    angle0 > 180 ? angle0 = 180 : angle0;
    //angle1 analysis
    angle1 = (135 * rezistor1 - 135 * max1) / (max1 - min1) + 180;
    angle1 < 45 ? angle1 = 45 : angle1;
    angle1 > 180 ? angle1 = 180 : angle1;
    //angle2 analysis
    angle2 = (135 * rezistor2 - 135 * max2) / (max2 - min2) + 180;
    angle2 < 45 ? angle2 = 45 : angle2;
    angle2 > 180 ? angle2 = 180 : angle2;
    //angle3 analysis
    //angle3 = (135 * rezistor3 - 135 * max3) / (max3 - min3) + 180;
    //angle3 < 45 ? angle3 = 45 : angle3;
    //angle3 > 180 ? angle3 = 180 : angle3;
    currentAngle = (angle0 + angle1 + angle2) / 3;
    Serial.println(currentAngle);
    //Servo.write(currentAngle);
  
  // put your main code here, to run repeatedly:
  }
}
