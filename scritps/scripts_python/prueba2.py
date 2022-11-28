# con imbecil
print("+++ 2 ++++")
datos1 = []
datos2 = []
datos3 = []
mensaje = ""
perfil = ""
i = 0
with open("imecil.txt", encoding="utf8") as fname:
    for lineas in fname:
        datos1.append(lineas.split())
        datos2 = datos1[i].copy()
        datos3 = datos2.copy()
        # if ("case" in datos2 ):
        # print("***************************COMIENZO*******")
        if ("//perfil" in datos2):
            datos3.pop(0)
            perfil = " ".join(datos3)
            mensaje += " \r\n"+perfil+"\r\n"

        if ("string" in datos2):
            for j in range(0, 3):
                datos2.pop(0)

            mensaje += " ".join(datos2)
            # print(datos2)
        i = i+1

print("***NIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")
print(mensaje)
