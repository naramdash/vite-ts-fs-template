module App

open Fable.Core.JsInterop
open Fable.Core
open Browser.Dom

importSideEffects "./style.css"

// Member imports
[<Import("alertPass", from = "./usets")>]
let alertPass (msg1: string) (msg2: string) : unit = jsNative

// Get a reference to our button and cast the Element to an HTMLButtonElement
let app =
    document.querySelector ("#app") :?> Browser.Types.HTMLDivElement

// Register our listener
app.innerHTML <-
    """
    <h1>Hello Vite!</h1>
    <a href='https://vitejs.dev/guide/features.html' target='_blank'>Documentation</a>
"""

app.onclick <- fun _ -> alertPass "123" "abc"
