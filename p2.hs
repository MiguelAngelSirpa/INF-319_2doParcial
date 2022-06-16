tribRec :: Integer -> Integer
tribRec 0 = 0
tribRec 1 = 0
tribRec 2 =	1
tribRec n = tribRec (n-1) + tribRec (n-2) + tribRec (n-3)


incValorDeTribo = \x -> x+1

main = do
print(incValorDeTribo(tribRec 3))
