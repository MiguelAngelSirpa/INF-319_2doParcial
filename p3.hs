tribRec :: Integer -> Integer
tribRec 0 = 0
tribRec 1 = 0
tribRec 2 =	1
tribRec n = tribRec (n-1) + tribRec (n-2) + tribRec (n-3)

main = do
	let mutable longitud=1
	putStrLn "La serie de tribRecursivo es:"
	let triR=0
	where
	longitud= show(10)
	triR=tribRec longitud
		print(triR)
	longitud=longitud+1