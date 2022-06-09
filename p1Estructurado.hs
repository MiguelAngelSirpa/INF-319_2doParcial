fibonaci = map fst (iterate f (0,1)) where f (x,y) = (y,x+y)

main = do
	take 10 fibonaci

