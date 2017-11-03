-- stack runghc --package strict

rand :: Int -> Int
rand seed = (1103515245 * seed + 12345) `mod` (2^32) 

main :: IO ()
main = do
    let a = rand 123456789 -- change for different sequences
    let b = rand a
    let c = rand b
    let d = rand c
    print (a, b, c, d)