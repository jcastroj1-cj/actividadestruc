from typing import NamedTuple

class Estudiante(NamedTuple):
    nombre: str
    edad: int
    promedio: float

# Crear instancia
e1 = Estudiante("Ana García", 22, 9.5)
print(e1)