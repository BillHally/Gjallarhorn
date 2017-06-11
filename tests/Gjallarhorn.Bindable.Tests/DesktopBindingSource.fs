namespace Gjallarhorn.Bindable.Tests

open System
open Gjallarhorn.Wpf

open NUnit.Framework

[<TestFixture>]
type DesktopBindingSourceTest() =
    [<Test>]
    member __.``BindingSourceTypeDescriptorProvider.GetTypeDescriptor, when passed a null 'inst' parameter, returns a default type descriptor`` () =
        let result = BindingSourceTypeDescriptorProvider().GetTypeDescriptor(typeof<DesktopBindingSource<obj>>, null)
        Assert.AreEqual("DefaultTypeDescriptor", result.GetType().Name)
