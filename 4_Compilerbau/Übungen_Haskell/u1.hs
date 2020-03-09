
-- Übung 1a
lastElement (l : []) = l
lastElement l = lastElement (tail l)


-- Übung 1b
stripList (_ : list) = reverse $ tail $ reverse list


-- Übung 1c
isPalindrom :: (Eq a) => [a] -> Bool
isPalindrom [] = True
isPalindrom (_ : []) = True
isPalindrom list = if (head list) == (lastElement list) then isPalindrom $ stripList list else False


-- Übung 6a
curry3 :: ((a, b, c) -> d) -> (a -> b -> c -> d)
--uncurry3 :: (a -> b -> c -> d) -> ((a, b, c) -> d)

curry3 f = \a -> \b -> \c -> f (a, b, c)
