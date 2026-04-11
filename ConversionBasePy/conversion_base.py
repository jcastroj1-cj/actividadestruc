from typing import NamedTuple


# Clase Objeto
class ConversionObj:
    def __init__(self, base, digitos):
        self.base = base
        self.digitos = digitos

    def obtener_valor(self):
        return ''.join(self.digitos)

    def mostrar_resultado(self):
        print(f"{self.base}: {self.obtener_valor()}")


# Record (NamedTuple)g
class ConversionRecord(NamedTuple):
    base: str
    digitos: list

    def obtener_valor(self):
        return ''.join(self.digitos)

    def mostrar_resultado(self):
        print(f"{self.base}: {self.obtener_valor()}")


# Main
try:
    n = int(input("Número base 10: "))

    # Con Objetos
    conversiones = [
        ConversionObj("Binario",     list(bin(n)[2:])),
        ConversionObj("Octal",       list(oct(n)[2:])),
        ConversionObj("Hexadecimal", list(hex(n)[2:].upper()))
    ]

    print("\n--- Con Objetos ---")
    for c in conversiones:
        c.mostrar_resultado()

    # Con Record
    conversiones_record = [
        ConversionRecord("Binario",     list(bin(n)[2:])),
        ConversionRecord("Octal",       list(oct(n)[2:])),
        ConversionRecord("Hexadecimal", list(hex(n)[2:].upper()))
    ]

    print("\n--- Con Record ---")
    for c in conversiones_record:
        c.mostrar_resultado()

except ValueError:
    print("Entrada inválida. Por favor ingrese un número entero.")
