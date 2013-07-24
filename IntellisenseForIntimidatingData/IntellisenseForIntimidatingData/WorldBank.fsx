#r "lib/FSharp.Data.dll"
#load "lib/FSharpChart.fsx"

open FSharp.Data
open Samples.FSharp.Charting


let worldBank = WorldBankData.GetDataContext()

worldBank.Countries.China.Indicators.``Population, total``
|> Chart.Line

let countries = 
    [worldBank.Countries.India
     worldBank.Countries.China
     worldBank.Countries.``United States``]

Chart.Combine
    [for c in countries do 
        let data = c.Indicators.``Population ages 0-14 (% of total)``
        yield Chart.Line(data, Name=c.Name)]





