module Feliz.style

open Fable.Core.JsInterop

let hover (style: #IStyleAttribute list) =
    unbox<IStyleAttribute>(":hover", createObj !!style)
    
let active (style: #IStyleAttribute list) =
    unbox<IStyleAttribute>(":active", createObj !!style)
    
let before (style: #IStyleAttribute list) =
    unbox<IStyleAttribute>(":before", createObj !!style)
    
let after (style: #IStyleAttribute list) =
    unbox<IStyleAttribute>(":after", createObj !!style)