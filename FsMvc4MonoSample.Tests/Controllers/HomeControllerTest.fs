namespace FsMvc4MonoSample.Tests
open NUnit.Framework
open System
open System.Collections.Generic
open System.Linq
open System.Text
open System.Web.Mvc
open FsMvc4MonoSample
open FsMvc4MonoSample.Controllers

[<TestFixture ()>]
type HomeControllerTest() =
    [<Test ()>]
    member x.Index () =
        // Arrange
        use controller = new HomeController ()

        // Act
        let result = controller.Index () :?> ViewResult

        // Assert
        Assert.AreEqual ("Welcome to F# ASP.NET MVC on Mono!", result.ViewData.["Message"])

