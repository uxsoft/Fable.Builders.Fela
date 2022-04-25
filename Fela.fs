module Fable.Builders.Fela.Fela

open Fable.Builders.Fela.RendererProviderBuilder
open Fable.Core
open Fable.Core.JsInterop
open Feliz

let RendererProvider = RendererProviderBuilder()

[<ImportMember("fela")>]
let createRenderer () : IFelaRenderer = jsNative

[<Import("useFela", "react-fela")>]
let private useFelaInternal: unit -> {| css: obj -> string |} = jsNative
let useFela () =
    let css = useFelaInternal().css
    (fun (x: #IStyleAttribute list) -> css (createObj !!x)) 