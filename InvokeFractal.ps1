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
    [string] $BaseUri="https://localhost:5001",
    [Parameter()]
    [int] $Iterations=1000,
    [Parameter()]
    [double] $BottomLeftX=-1.0,
    [Parameter()]
    [double] $BottomLeftY=-1.0,
    [Parameter()]
    [double] $TopRightX=1.0,
    [Parameter()]
    [double] $TopRightY=1.0,
    [Parameter()]
    [int] $Steps=1000
)

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$fractalCreate = @{"Iterations"="$Iterations";"BottomLeftX"="$BottomLeftX";"BottomLeftY"="$BottomLeftY";"TopRightX"="$TopRightX";"TopRightY"="$TopRightY";"Steps"="$Steps"}

$json = $fractalCreate | ConvertTo-Json

Write-Host $json

$result = Invoke-WebRequest -Uri ($BaseUri + "/api/fractal") -Method POST -Body $json -ContentType "application/json"

$result