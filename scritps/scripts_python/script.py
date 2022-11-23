def cleaning():
    with open("imecil.txt", encoding="utf8") as file:
        for line in file:
            if line[0] == '/':
                if line[2] == 'p':
                    print(line[9:], end='')
                if line[2] == 'c':
                    print(line[7:], end='')
                if line[2] == 'd':
                    print(line[8:], end='')
            elif line[0] == 't':
                continue
            elif line[0] == 'b' and line[1] == 'r':
                continue
            elif line[0] == 's' and line[1] == 't' and line[2] == 'r':
                print(line[line.index('"')+1:line.index(';')-1], end='\n')
            else:
                print(line, end='')


def adding_linesbreaks():
    with open("output2.txt") as file:
        for line in file:
            if not line[len(line)-2] == '.':
                print(line[len(line)-2], end='')
            else:
                print(line, end='')


def searching():
    with open("output2.txt") as file:
        for line in file:
            print(line[len(line)//2:])


def run():
    cleaning()
    # adding_linesbreaks()
    # searching()


if __name__ == '__main__':
    run()
