Algoritmo Lecc11_Act2_Inc3
	Definir num1, num2, men, may, i Como Entero
	
    Escribir "Ingrese el primer número:"
    Leer num1
	
    Escribir "Ingrese el segundo número:"
    Leer num2
	
    Si num1 < num2 Entonces
        men = num1
        may = num2
    SiNo
        men = num2
        may = num1
    FinSi
	
    i = men
	
    Repetir
        Si i MOD 4 = 0 Entonces
            Escribir i
        FinSi
		
        i = i + 1
    Hasta Que i > may
FinAlgoritmo
