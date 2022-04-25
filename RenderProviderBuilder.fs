module Fable.Builders.Fela.RendererProviderBuilder

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz

type IFelaRenderer = interface end


type RendererProviderBuilder() =
    inherit ReactBuilder(import "RendererProvider" "react-fela")
    
    [<CustomOperation("renderer")>] member inline _.renderer (x: DSLElement, v: IFelaRenderer) = x.attr "renderer" v
    
