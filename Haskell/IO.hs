-- stack runghc --package strict

add :: IO Int -> IO Int -> IO Int
add getX getY = do
    x <- getX
    y <- getY
    return (x + y)

add2 :: Maybe Int -> Maybe Int -> Maybe Int
add2 getX getY = do
    x <- getX
    y <- getY
    return (x + y)

main = do
    x <- add (return 0) (return 1)
    let y = add2 (Just 1) (Nothing)
    print x 
    print y