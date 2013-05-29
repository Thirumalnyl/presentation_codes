type Temperature = 
    | Celcius of double
    | Farenheit of double

let hasFever temperature = 
        match temperature with 
            | Celcius value -> ( value > 37.5)
            | Farenheit value -> ( value > 99.0 )

let result = hasFever (Celcius 55.6)

