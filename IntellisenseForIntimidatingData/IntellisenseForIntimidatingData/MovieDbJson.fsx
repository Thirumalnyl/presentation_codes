#r "lib/FSharp.Data.dll"
#load "lib/GuiExtensions.fs"

open FSharp.Net
open FSharp.Data
open FSharp.WebBrowser

type MovieSearch = JsonProvider<"data//movieSearch.json">

let showMovies seachTerm = 
    let key = "api_key=6ce0ef5b176501f8c07c634dfa933cff"
    let url = "http://api.themoviedb.org/3/search/movie?query=" + seachTerm + "&" + key

    let data = Http.Request(url, headers=["accept", "application/json"])

    let movies = MovieSearch.Parse(data)


    [for movie in movies.Results do
        yield sprintf "<b>%s</b>" movie.Title]
    |> showList


showMovies "pursuit"