#r "System.Data.dll"
#r "FSharp.Data.TypeProviders.dll"
#r "System.Data.Linq.dll"

open System
open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders
open Microsoft.FSharp.Linq

type dbSchema = SqlDataConnection<"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;">
let db = dbSchema.GetDataContext()

let seaFoods = query { for product in db.Products do
                        where (product.Categories.CategoryName.Equals("Seafood"))
                        select product }

for seaFood in seaFoods do
    printfn "%s" seaFood.ProductName


//select [ProductName] from Products as P,Categories as C 
//where P.CategoryID = C.CategoryID and C.CategoryName = 'SeaFood'