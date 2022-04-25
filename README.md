# Fable.Builders.Fela

## Getting Started

```bash
yarn add fela
yarn add react-fela
dotnet package add Fable.Builders.Fela
```

## Usage

```
[<ReactComponent>]
let TestComponent () =
    let css = Fela.useFela ()
    let cls = css [
        style.backgroundColor color.red
        style.hover [
            style.backgroundColor color.blue
        ]
    ]
    
    div {
        className cls
        str "asd"
    }

let view model =
    Fela.RendererProvider {
        renderer (Fela.createRenderer ())
        
        TestComponent ()
    }
```