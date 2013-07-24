#r "lib/FSharp.Data.dll"
#r "System.Xml.Linq.dll"

open System
open FSharp.Data

type Catalog = XmlProvider<"data//books.xml">

let catalog = Catalog.Load("data//books.xml")

let fantasyBooks = query { for book in catalog.GetBooks() do
                            where (book.Genre.Equals("Fantasy"))
                            select book }

for book in fantasyBooks do
    printfn "%s-%A" book.Title book.Amount


(*type ThoughtWorksRssFeed = XmlProvider<"http://feeds.feedburner.com/thoughtworks-blogs">

let blog = ThoughtWorksRssFeed.GetSample()

printfn "Blog Title : %s" blog.Channel.Title

let recentItems = [for item in blog.Channel.GetItems() do
                    if item.PubDate > DateTime.Now.Subtract(new TimeSpan(5,0,0,0)) then
                        yield item]

for item in recentItems do
    printfn "%s" item.Title*)