# EGC - Posmangiu

 Posmangiu Ionuț-Nicolae
 Grupa 3133a

## **Laborator 2 - întrebări**

- **Ce este un viewport?**

  Un viewport reprezintă o regiune în fereastra de afișare în care se desenează obiectele, acesta având 2 parametri (lățime și înălțime). 

- **Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?**

  FPS (Frames Per Second) în OpenGL indică numărul de cadre randate pe secundă și afectează fluiditatea animației.
 
- **Când este rulată metoda OnUpdateFrame()?**

  Metoda OnUpdateFrame() rulează în fiecare cadru pentru actualizări logice.

- **Ce este modul imediat de randare?**

  Modul imediat este o metodă învechită de randare în OpenGL.

- **Care este ultima versiune de OpenGL care acceptă modul imediat?**

  Ultima versiune care a acceptat modul imediat a fost OpenGL 3.x.

- **Când este rulată metoda OnRenderFrame()?**

  Metoda OnRenderFrame() rulează în fiecare cadru pentru randare.

- **De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?**

  Metoda OnResize() trebuie rulată cel puțin o dată pentru setarea corectă a viewport-ului.

- **Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?**

  CreatePerspectiveFieldOfView() creează o matrice de perspectivă cu parametrii: unghi, raport, distanță apropiată și distanță depărtată.


## **Laborator 3 - întrebări**

  2. Anti-aliasing este o tehnică utilizată în grafica pe calculator pentru a reduce sau elimina efectul de aliasing, care este o formă de distorsiune a imaginii care apare atunci când obiectele sau liniile sunt reprezentate cu rezoluție scăzută sau atunci când sunt afișate pe ecrane cu pixeli vizibili.
  
  3. GL.LineWidth(float) stabilește grosimea liniilor desenate în OpenGL pentru primitivele de linie, cum ar fi GL_LINES. GL.PointSize(float) setează dimensiunea punctelor desenate pentru primitivele de punct, cum ar fi GL_POINTS. Acestea nu funcționează în interiorul unui bloc GL.Begin().
  
  4.
 - GL_LINE_LOOP: Creează o buclă închisă cu segmente de dreaptă multiple. Ultimul punct se conectează la primul, formând o figură închisă (de exemplu, un triunghi);
 - GL_LINE_STRIP: Creează un șir de segmente de dreaptă conectate, fără a închide figura;
 - GL_TRIANGLE_FAN: Desenează segmentele de dreaptă pentru a forma un evantai în jurul unui punct central, creând o figură închisă (de exemplu, o formă circulară);
 - GL_TRIANGLE_STRIP: Creează un șir de segmente de dreaptă conectate, alternând între ele, pentru a desena o figură deschisă sau închisă.

  6. Folosirea de culori diferite în desenarea obiectelor 3D ajută la percepția adâncimii, identificarea obiectelor, organizarea, evidențierea detaliilor, estetică și semnalizarea informațiilor. Este important pentru a face o scenă mai ușor de înțeles și mai atractivă vizual.
  
  7. Un gradient de culoare este o tranziție treptată între două sau mai multe culori. În OpenGL, se poate obține un gradient de culoare folosind shadere pentru a interpola culorile între vârfurile primitivelor, astfel obținând o tranziție treptată între ele. Aceasta se face de obicei într-un shader de fragmente, unde se calculează culoarea pentru fiecare fragment în funcție de poziția sa și culorile vârfurilor. 


 ## **Laborator 9 - întrebări**

- **Utilizați pentru texturare imagini cu transparență și fără. Ce observați?**

  La texturarea cu imagini cu transparență partea transparentă este înlocuită cu o culoare solidă.
- **Ce formate de imagine pot fi aplicate în procesul de texturare în OpenGL?**

  Formatele de imagine ce pot fi aplicate în procesul de texturare sunt: BMP, PNG, JPED, TGA, DDS, HDR, KTX.
- **Specificați ce se întâmplă atunci când se modifică culoarea (prin manipularea canalelor RGB) obiectului texturat.**

  Manipularea canalelor RGB ale unui obiect texturat afectează culoarea finală a obiectului, iar operațiile pot include schimbări uniforme, multiplicare sau adunare cu culorile texturii, și pot implica ajustarea opacității prin canalul alfa.
- **Ce deosebiri există între scena ce utilizează obiecte texturate în modul iluminare activat, respectiv dezactivat?**   

  Cu iluminarea activată în OpenGL, obiectele texturate reflectă lumina ambientală și direcțională, producând umbre și efecte de iluminare, în timp ce cu iluminarea dezactivată, obiectele texturate afișează culorile lor originale fără influența luminii.

