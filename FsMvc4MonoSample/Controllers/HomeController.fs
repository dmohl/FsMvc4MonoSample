namespace FsMvc4MonoSample.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

type HomeController() =
    inherit Controller()
    member this.Index () =
        base.ViewData.["Message"] <- "Welcome to F# ASP.NET MVC on Mono!"
        this.View() :> ActionResult

