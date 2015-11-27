#r "./lib/fun3d/OpenTK.dll"
#r "./lib/fun3d/OpenTK.GLControl.dll"
#load "./lib/fun3d/functional3d.fs"

open System
open System.Drawing
open Functional3D

let spike r =
    Fun.cone
    |> Fun.scale (0.5,0.5,2.0)
    |> Fun.translate (0.0,0.0,-1.0)
    |> Fun.rotate (r, 0.0, 0.0)

(spike 0.0 $ spike 90.0 $ spike 180.0 $ spike 270.0)
|> Fun.color Color.Gold