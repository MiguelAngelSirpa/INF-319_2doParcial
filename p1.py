# -*- coding: utf-8 -*-
"""
Created on Thu Jun  9 08:39:30 2022

@author: Cliente
"""
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

def ImprimeTriboNormal(n) :
    for j in range(0, n) :
        print( TriboNormal(j) , ", ", end = "")



def TriboRec(n) :
    if (n == 0 ) :
        return 0
    if (n == 1) :
        return 0
    if (n == 2) :
        return 1
    
    return (TriboRec(n - 1) +TriboRec(n - 2) +TriboRec(n - 3))
         
 
def ImprimeTribo(n) :
    for i in range(1, n+1) :
        print( TriboRec(i) , ", ", end = "")
         
 
    
 
    
 
# Driver code
n = 10
ImprimeTribo(n)
print()
ImprimeTriboNormal(n)