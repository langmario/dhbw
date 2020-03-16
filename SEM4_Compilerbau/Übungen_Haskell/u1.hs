
-- Übung 1
-- a
lastElement (l : []) = l
lastElement l = lastElement (tail l)


-- b
stripList (_ : list) = reverse $ tail $ reverse list


-- c
isPalindrom :: (Eq a) => [a] -> Bool
isPalindrom [] = True
isPalindrom (_ : []) = True
isPalindrom list = if (head list) == (lastElement list) then isPalindrom $ stripList list else False


-- Übung 3
curry3 :: ((a, b, c) -> d) -> (a -> b -> c -> d)
-- uncurry3 :: (a -> b -> c -> d) -> ((a, b, c) -> d)

curry3 f = \a -> \b -> \c -> f (a, b, c)



-- Übung 6
-- a
data BTree a = emptyTree
            | Node a (BTree a) (BTree a)
            deriving Show;

-- b
mapTree :: BTree a -> (a -> b) -> BTree b
mapTree (BTree a) f = 42


-- c
