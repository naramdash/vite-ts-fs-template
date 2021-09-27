# Use FSharp Fable with Typescript on Vite

_last update: 2021-09-27_

## What is ...

- [FSharp](https://fsharp.org/)
- [Fable](https://fable.io/)
- [Typescript](https://www.typescriptlang.org/)
- [Vite](https://vitejs.dev/)

## Why I use this

You can use Typescript for NPM package glue to FSharp Code. You don't need to use `ts2fable`. Just write type informations as you need on `fs`. Enjoy `@types` of NPM packages in Typescript without hassle.

And Goodbye to Dinosaur `webpack.config.js`.

## How to use this template

Click `Use this template` button on [GitHub Repository Site](https://github.com/naramdash/vite-ts-fs-template)

## How to use `.ts` file in `.fs`

```fsharp
// App.fs

open Fable.Core

// Member imports
// import { alertPass } from "./usets"
// Same as Import("alertPass", "./usets")
[<Import("alertPass", from = "./usets")>]
let alertPass (msg1: string) (msg2: string) : unit = jsNative

app.onclick <- fun _ -> alertPass "123" "abc"
```

```typescript
// usets.ts

function alertPass(msg1: string, msg2: string) {
  alert(`msg1: ${msg1}\nmsg2: ${msg2}`);
}

export { alertPass };
```

Check more information on [Fable document](https://fable.io/docs/communicate/js-from-fable.html#Type-safety-with-Imports-and-Interfaces).

## NPM Scripts

### From Vite

- `dev`: start dev server
- `build`: build for production
- `serve`: locally preview production build

### From Fable

- `postinstall`: install dotnet tools (automatically called after `npm install`)

### From [Fable.Lit](https://github.com/AngelMunoz/Fable.Lit.Templates)

- `format`: format `*.fs` files using [fantomas](https://github.com/fsprojects/fantomas)

### Template-Own

- `trashfsjs`: trash `*.fs.js` files in `src`
