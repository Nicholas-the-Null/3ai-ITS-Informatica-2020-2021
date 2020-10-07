# Il costrutto for 

riferimenti a pag 34




Il costrutto for si utilizza per ripetere una serie di istruzzioni un numero noto di volte.
--------------------------------------------------------------------------------------------





## Le parole chiavi  del For





For Indice = "numero_di_partenza" To "To_fine"  Step(opzionale è il valore per il quale verrà incrementato di default è 1)

  istruzzioni
     
Next Indice  



Un piccolo esempio Stampare i numeri da 0 a 100
-----------------



```Visual Basic.net
Dim num as Integer



for Num = 0 To 100



      MsgBox(Num)
      
      
      
Next Num


```


se invece volessimo stampare solo i numeri pari potremmo adoperare la funzione step che ci incrementera il numero di 2







```Visual Basic.net
Dim num as Integer



for Num = 0 To 100 Step 2



      MsgBox(Num)
      
      
      
Next Num


```
