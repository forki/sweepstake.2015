(*** hide ***)
#I "../../src/Sweepstake.2015/bin/Release"

#r "Sweepstake.2015.dll"
open AOrNotA.Sweepstake2015.HtmlContent

let indexHtml = getIndexHtml ()

(**
Latest news
===========
*)

(*** include-value: indexHtml ***)

