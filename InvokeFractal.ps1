<#
.SYNOPSIS

Convenience script to invoke the fractal function

.PARAMETER BaseUri

The base uri of the fractal api e.g. http://localhost:5000

.PARAMETER Iterations

The number of iterations to use

.PARAMETER BottomLeftX

The X coordinate of the bottom left point to start the fractal

.PARAMETER BottomLeftY

The Y coordinate of the bottom left point to start the fractal

.PARAMETER TopRightX

The X coordinate of the top right point to end the fractal

.PARAMETER TopRightY

The y coordinate of the top right point to end the fractal
#>
Param(
    [Parameter()]
    [string] $BaseUri="http://localhost:5000",
    [Parameter()]
    [int] $Iterations=1000,
    [Parameter()]
    [double] $BottomLeftX=-1.0,
    [Parameter()]
    [double] $BottomLeftY=-1.0,
    [Parameter()]
    [double] $TopRightX=1.0,
    [Parameter()]
    [double] $TopRightY=1.0
)

$fractalCreate = @{"Iterations"=$Iterations;"BottomLeftX"=$BottomLeftX;"BottomLeftY"=$BottomLeftY;"TopRightX"=$TopRightX;"TopRightY"=$TopRightY}

$result = Invoke-WebRequest -Uri ($BaseUri + "/api/fractal") -Method POST -Body ($fractalCreate | ConvertTo-Json) -ContentType "application/json"

$result