
def TriboNormal(n):
    a = -1
    b = 1
    c = 0
    d = 0
    for k in range(n):
        a = b
        b = c
        c = d
        d = a+b+c
        
    return d


def TriboRec(n) :
    if (n == 0 ) :
        return 0
    if (n == 1) :
        return 0
    if (n == 2) :
        return 1
    
    return (TriboRec(n - 1) +TriboRec(n - 2) +TriboRec(n - 3))
         
# ==========================================

def FuncionOrdenS(funcion,n):
    return funcion(n)


#==========FUNCIONES TEMPORALES========================

triboR = lambda FuncionOrdenS, n=10: FuncionOrdenS(n)

n=10
for k in range(0, n) :
    print((triboR(TriboNormal,k)) , ", ", end = "")
    
print("\n")

for h in range(1, n+1) :
    print (triboR(TriboRec,h) , ", ", end = "")
