#r "System.Xml.Linq.dll"
#r "lib/FSharp.Data.dll"
#load "lib/GuiExtensions.fs"

open FSharp.Data
open FSharp.WebBrowser
open System.Linq
open System


let fb = FreebaseData.GetDataContext()

for teams in fb.Sports.Cricket.``Cricket Teams`` do
    printfn "%s" teams.Name
  

























(* let fb = FreebaseData.GetDataContext()

let usPresidents = 
    [for president in fb.Society.Government.``US Presidents`` do
        yield sprintf "<strong>%s<strong><img src='%s'/>" president.Name president.MainImage]

usPresidents |> showList *)
