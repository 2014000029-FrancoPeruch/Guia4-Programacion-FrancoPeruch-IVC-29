Algoritmo Lecc24_Act3_Inc1
	Definir num, i, cont, suma Como Entero
	
    suma = 0
	
    Para num = 2 Hasta 50 Hacer
		
        cont = 0
		
        Para i = 1 Hasta num Hacer
			
            Si num MOD i = 0 Entonces
                cont = cont + 1
            FinSi
			
        FinPara
		
        Si cont = 2 Entonces
            Escribir num
            suma <- suma + num
        FinSi
		
    FinPara
	
    Escribir "La suma de los números primos es: ", suma
FinAlgoritmo
