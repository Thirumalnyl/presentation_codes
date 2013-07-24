#r "lib/FSharp.Data.dll"

open FSharp.Data
open System.Linq

(*let countries = new CsvProvider<"http://www.andrewpatton.com/countrylist.csv">()

for country in countries.Data do 
    printfn "%s" country.``Common Name`` *)


let pincode = new CsvProvider<"http://data.gov.in/sites/default/files/all_india_pin_code.csv", CacheRows=false>()

for row in pincode.Data do
    if (row.regionname.Contains("Hyderabad")) then 
        printfn "%i" row.pincode





