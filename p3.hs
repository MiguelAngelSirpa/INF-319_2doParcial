tribRec :: Integer -> Integer
tribRec 0 = 0
tribRec 1 = 0
tribRec 2 =	1
tribRec n = tribRec (n-1) + tribRec (n-2) + tribRec (n-3)

funcSumaValorAtrib f x =f(tribRec x)

main = do

	print(funcSumaValorAtrib(+8) 2)
