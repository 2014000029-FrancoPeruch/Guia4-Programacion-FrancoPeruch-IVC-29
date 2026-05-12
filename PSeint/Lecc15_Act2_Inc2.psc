Algoritmo Lecc15_Act2_Inc2
	Definir billete, i, cantidad, suma Como Entero
	
    cantidad = 0
    suma = 0
	
    Para i = 1 Hasta 1000 Hacer
		
        Escribir "Ingrese el valor del billete:"
        Leer billete
		
        Si billete = 100 Entonces
            cantidad = cantidad + 1
            suma = suma + 100
        FinSi
		
    FinPara
	
    Escribir "Cantidad de billetes de $100: ", cantidad
    Escribir "Total de dinero en billetes de $100: $", suma
FinAlgoritmo
