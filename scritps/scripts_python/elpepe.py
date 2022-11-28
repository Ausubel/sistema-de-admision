with open("facultades.txt", encoding="utf8") as file:
    for lines in file:
        count = 0
        for i in lines:
            count = count+1
            if count >= 44:
                if not (i == ';'):
                    print(i, end='')
        print('', end=',')
