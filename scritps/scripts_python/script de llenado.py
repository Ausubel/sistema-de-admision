
# Con Johan


print("+++ 2 ++++")
datos1 = []
datos2 = []
i = 0
with open("johan.txt") as fname:
    for lineas in fname:
        datos1.append(lineas.split())
        datos2 = datos1[i]
        for j in range(0, 3):
            datos2.pop(0)
        print(datos2)
        i = i+1
print(datos2)
print("***")
