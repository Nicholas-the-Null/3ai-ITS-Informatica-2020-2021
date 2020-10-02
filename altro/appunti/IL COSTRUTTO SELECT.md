                                                        # IL COSTRUTTO SELECT  (02-10-2020)
                                                      
                                                      
                                                      
Riferimenti al libro a pagina 32




Il costrutto case si utilizza solitamente come un sostituto degli If annidati quando, questi ultimi diventono di una quantita consistente.



## Funzioni chiavi



Select Case Nome_variabile

Case Istruzzione

Case Else

End Select







###Spiegazione funzioni chiavi

1)Select case Nome_Variabile è l'inizio della nostra funzione Select Case


un esempio in cui dobbiamo chiedere in input un numero da uno a 2

--------------------------
Dim numero as Integere
numero=Console.ReadLine()

Select Case Numero 

--------------------------






2) Case istruzzione come detto prima, gli if e il costrutto select sono pressochè identici, ed è per questo che la funzione di questo è identica agli if apparte per l'assenza del Then 





Continua l'esempio



---------------------
Case 1                       'se il numero è uguale a uno entra qui
'istruzzione
Case 2                        'se invece il numero è 2 entrera qua

-------------------








3) Case Else               se il numero non è ne uno ne 2 entrera 


Continua l'esempio


---------------------

Case Else  
Console.WriteLine("il numero inserito non è valido")
--------------------------------------------------------------



4) Per chiudere il costrutto come nel caso degli If si usava End if qua si usa End Select



esempio Completo




Dim numero as Integere
numero=Console.ReadLine()

Select Case Numero 
Case 1                       'se il numero è uguale a uno entra qui
'istruzzione
Case 2                        'se invece il numero è 2 entrera qua
Case Else  
Console.WriteLine("il numero inserito non è valido")
End Case 
-----------------------------------------------------------------------------------------------------------------

In conclusione il costrutto select case puo sostituire il costrutto if, soltanto per una questione di leggibilità ma le loro funzioni sono equivalenti

